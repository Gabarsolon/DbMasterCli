using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x0200005D RID: 93
	public class DbFile
	{
		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00030319 File Offset: 0x0002E519
		// (set) Token: 0x060007FF RID: 2047 RVA: 0x00030321 File Offset: 0x0002E521
		public Table[] Table
		{
			get
			{
				return this.m_Table;
			}
			set
			{
				this.m_Table = value;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06000800 RID: 2048 RVA: 0x0003032A File Offset: 0x0002E52A
		public int NTables
		{
			get
			{
				return this.m_NTables;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (set) Token: 0x06000801 RID: 2049 RVA: 0x00030332 File Offset: 0x0002E532
		public ToolStripProgressBar ProgressBar
		{
			set
			{
				this.m_ProgressBar = value;
			}
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06000802 RID: 2050 RVA: 0x0003033B File Offset: 0x0002E53B
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x170001B8 RID: 440
		// (get) Token: 0x06000803 RID: 2051 RVA: 0x00030343 File Offset: 0x0002E543
		public string XmlFileName
		{
			get
			{
				return this.m_XmlFileName;
			}
		}

		// Token: 0x170001B9 RID: 441
		// (get) Token: 0x06000804 RID: 2052 RVA: 0x0003034B File Offset: 0x0002E54B
		// (set) Token: 0x06000805 RID: 2053 RVA: 0x00030353 File Offset: 0x0002E553
		public DataSet DescriptorDataSet
		{
			get
			{
				return this.m_DescriptorDataSet;
			}
			set
			{
				this.m_DescriptorDataSet = value;
			}
		}

		// Token: 0x170001BA RID: 442
		// (get) Token: 0x06000806 RID: 2054 RVA: 0x0003035C File Offset: 0x0002E55C
		// (set) Token: 0x06000807 RID: 2055 RVA: 0x00030364 File Offset: 0x0002E564
		public FifaPlatform Platform
		{
			get
			{
				return this.m_Platform;
			}
			set
			{
				this.m_Platform = value;
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0003036D File Offset: 0x0002E56D
		public DbFile()
		{
			this.m_FileName = null;
			this.m_XmlFileName = null;
			this.m_DescriptorDataSet = null;
			this.m_Platform = FifaPlatform.PC;
		}

		// Token: 0x06000809 RID: 2057 RVA: 0x00030391 File Offset: 0x0002E591
		public DbFile(string dbFileName, string xmlFileName, ToolStripProgressBar toolStripProgressBar)
		{
			this.m_ProgressBar = toolStripProgressBar;
			this.m_FileName = dbFileName;
			this.m_XmlFileName = xmlFileName;
			this.m_DescriptorDataSet = null;
			this.m_Platform = FifaPlatform.PC;
			this.Load();
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x000303C3 File Offset: 0x0002E5C3
		public DbFile(string dbFileName, string xmlFileName)
		{
			this.m_ProgressBar = null;
			this.m_FileName = dbFileName;
			this.m_XmlFileName = xmlFileName;
			this.m_DescriptorDataSet = null;
			this.m_Platform = FifaPlatform.PC;
			this.Load();
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x000303F8 File Offset: 0x0002E5F8
		public void ComputeAllCrc(DbReader r, DbWriter w)
		{
			long num = this.m_SignaturePosition;
			int num2 = (int)(this.m_CrcHeaderPosition - num);
			this.ComputeAndWriteCrc(r, w, num, num2);
			num += (long)(num2 + 4);
			num2 = (int)(this.m_CrcShortNamesPosition - num);
			this.ComputeAndWriteCrc(r, w, num, num2);
			for (int i = 0; i < this.m_NTables; i++)
			{
				num += (long)(num2 + 4);
				num2 = (int)(this.m_Table[i].CrcTableHeaderPosition - num);
				this.ComputeAndWriteCrc(r, w, num, num2);
				num += (long)(num2 + 4);
				num2 = (int)(this.m_Table[i].CrcRecordsPosition - num);
				this.ComputeAndWriteCrc(r, w, num, num2);
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00030494 File Offset: 0x0002E694
		public bool ComputeAllCrc()
		{
			if (!File.Exists(this.m_FileName))
			{
				return false;
			}
			FileStream fileStream = new FileStream(this.m_FileName, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
			DbWriter dbWriter = new DbWriter(fileStream, this.m_Platform);
			DbReader dbReader = new DbReader(fileStream, this.m_Platform);
			this.ComputeAllCrc(dbReader, dbWriter);
			dbReader.Close();
			dbWriter.Close();
			fileStream.Close();
			return true;
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x000304F4 File Offset: 0x0002E6F4
		public int ComputeAndWriteCrc(DbReader r, DbWriter w, long offset, int count)
		{
			byte[] array = new byte[count];
			r.BaseStream.Seek(offset, SeekOrigin.Begin);
			array = r.ReadBytes(count);
			int num = FifaUtil.ComputeCrcDb11(array);
			w.Write(num);
			return num;
		}

		// Token: 0x0600080E RID: 2062 RVA: 0x00030530 File Offset: 0x0002E730
		public bool LoadDb(string fileName)
		{
			if (!File.Exists(fileName))
			{
				return false;
			}
			this.m_FileName = fileName;
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			DbReader dbReader = new DbReader(fileStream, FifaPlatform.PC);
			bool flag = this.LoadDb(dbReader, false);
			dbReader.Close();
			fileStream.Close();
			return flag;
		}

		// Token: 0x0600080F RID: 2063 RVA: 0x00030578 File Offset: 0x0002E778
		public bool LoadDb(DbReader r, bool skipData)
		{
			bool flag = false;
			if (skipData)
			{
				while (r.BaseStream.Position <= r.BaseStream.Length - 4L)
				{
					if (r.ReadUInt32() == 134234692U)
					{
						flag = true;
						r.BaseStream.Position -= 4L;
						break;
					}
					r.BaseStream.Position -= 3L;
				}
				if (!flag)
				{
					return false;
				}
			}
			flag = true;
			this.m_SignaturePosition = r.BaseStream.Position;
			this.m_Signature = r.ReadChars(8);
			if (this.m_Signature[0] != 'D' || this.m_Signature[1] != 'B' || this.m_Signature[2] != '\0' || this.m_Signature[3] != '\b' || this.m_Signature[5] != '\0' || this.m_Signature[6] != '\0' || this.m_Signature[7] != '\0')
			{
				return false;
			}
			if (this.m_Signature[4] == '\0')
			{
				this.m_Platform = FifaPlatform.PC;
				r.Platform = this.m_Platform;
			}
			else
			{
				if (this.m_Signature[4] != '\u0001')
				{
					return false;
				}
				this.m_Platform = FifaPlatform.XBox;
				r.Platform = this.m_Platform;
			}
			this.m_FileLength = r.ReadInt32();
			if ((long)this.m_FileLength > r.BaseStream.Length)
			{
				return false;
			}
			r.ReadInt32();
			this.m_NTables = r.ReadInt32();
			this.m_TableOffset = new uint[this.m_NTables];
			TableDescriptor.DescriptorDataSet = this.m_DescriptorDataSet;
			this.m_Table = new Table[this.m_NTables];
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = this.m_NTables;
			}
			this.m_CrcHeaderPosition = r.BaseStream.Position;
			this.m_CrcHeader = r.ReadUInt32();
			for (int i = 0; i < this.m_NTables; i++)
			{
				this.m_Table[i] = new Table();
				this.m_Table[i].LoadTableName(r);
				this.m_TableOffset[i] = r.ReadUInt32();
			}
			this.m_CrcShortNamesPosition = r.BaseStream.Position;
			this.m_CrcShortNames = r.ReadUInt32();
			long position = r.BaseStream.Position;
			for (int j = 0; j < this.m_NTables; j++)
			{
				if (this.m_ProgressBar != null)
				{
					this.m_ProgressBar.Value = j;
				}
				this.m_Table[j].Load(r, position + (long)((ulong)this.m_TableOffset[j]));
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
			return flag;
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x000307E2 File Offset: 0x0002E9E2
		public bool LoadDb()
		{
			return this.m_FileName != null && this.LoadDb(this.m_FileName);
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x000307FA File Offset: 0x0002E9FA
		public bool LoadXml(string xmlFileName)
		{
			if (!File.Exists(xmlFileName))
			{
				return false;
			}
			this.m_XmlFileName = xmlFileName;
			this.m_NeedToSaveXmlFile = false;
			this.m_DescriptorDataSet = new DataSet("XML_Descriptor");
			this.m_DescriptorDataSet.ReadXml(this.m_XmlFileName);
			return true;
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00030837 File Offset: 0x0002EA37
		public bool LoadXml()
		{
			return this.m_XmlFileName != null && this.LoadXml(this.m_XmlFileName);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x0003084F File Offset: 0x0002EA4F
		public bool Load()
		{
			return this.LoadXml() && this.LoadDb();
		}

		// Token: 0x06000814 RID: 2068 RVA: 0x00030864 File Offset: 0x0002EA64
		public bool SaveDb(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.ReadWrite);
			DbWriter dbWriter = new DbWriter(fileStream, this.m_Platform);
			this.SaveDb(dbWriter);
			dbWriter.Close();
			fileStream.Close();
			this.ComputeAllCrc();
			return true;
		}

		// Token: 0x06000815 RID: 2069 RVA: 0x000308A4 File Offset: 0x0002EAA4
		public bool SaveDb(DbWriter w)
		{
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = this.m_NTables;
			}
			w.Write(this.m_Signature);
			long position = w.BaseStream.Position;
			w.Write(-1L);
			w.Write(this.m_NTables);
			this.m_CrcHeaderPosition = w.BaseStream.Position;
			w.Write(-1);
			long num = w.BaseStream.Position + 4L;
			for (int i = 0; i < this.m_NTables; i++)
			{
				w.Write(this.m_Table[i].TableDescriptor.ShortName);
				w.Write(-1);
			}
			this.m_CrcShortNamesPosition = w.BaseStream.Position;
			w.Write(-1);
			long position2 = w.BaseStream.Position;
			for (int j = 0; j < this.m_NTables; j++)
			{
				if (this.m_ProgressBar != null)
				{
					this.m_ProgressBar.Value = j;
				}
				this.m_TableOffset[j] = (uint)(w.BaseStream.Position - position2);
				this.m_Table[j].Save(w);
			}
			this.m_FileLength = (int)(w.BaseStream.Position - this.m_SignaturePosition);
			w.BaseStream.Position = position;
			w.Write(this.m_FileLength);
			w.Write(0);
			w.BaseStream.Position = num;
			for (int k = 0; k < this.m_NTables; k++)
			{
				w.Write(this.m_TableOffset[k]);
				w.BaseStream.Position += 4L;
			}
			w.Seek(0, SeekOrigin.End);
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
			return true;
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00030A5B File Offset: 0x0002EC5B
		public bool SaveXml(string xmlFileName)
		{
			if (this.m_NeedToSaveXmlFile)
			{
				this.m_DescriptorDataSet.WriteXml(xmlFileName, XmlWriteMode.IgnoreSchema);
			}
			this.m_NeedToSaveXmlFile = false;
			return true;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00030A7A File Offset: 0x0002EC7A
		public bool SaveXml()
		{
			return this.m_XmlFileName != null && this.SaveXml(this.m_XmlFileName);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00030A92 File Offset: 0x0002EC92
		public bool SaveDb()
		{
			return this.m_FileName != null && this.SaveDb(this.m_FileName);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00030AAC File Offset: 0x0002ECAC
		public void Document()
		{
			if (this.m_FileName == null)
			{
				return;
			}
			string text = Path.GetFullPath(this.m_FileName);
			text = text.Replace(".db", ".txt");
			FileStream fileStream = new FileStream(text, FileMode.Create);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			for (int i = 0; i < this.m_NTables; i++)
			{
				string tableName = this.m_Table[i].TableDescriptor.TableName;
				streamWriter.WriteLine(string.Concat(new string[] { "static private string t_", tableName, " = \"", tableName, "\";" }));
			}
			for (int j = 0; j < this.m_NTables; j++)
			{
				string tableName2 = this.m_Table[j].TableDescriptor.TableName;
				streamWriter.WriteLine("static public int " + tableName2 + ";");
			}
			for (int k = 0; k < this.m_NTables; k++)
			{
				string tableName3 = this.m_Table[k].TableDescriptor.TableName;
				streamWriter.WriteLine(tableName3 + " = fifaDbFile.GetTableIndex(t_" + tableName3 + ");");
			}
			for (int l = 0; l < this.m_NTables; l++)
			{
				string tableName4 = this.m_Table[l].TableDescriptor.TableName;
				for (int m = 0; m < this.m_Table[l].TableDescriptor.NFields; m++)
				{
					string fieldName = this.m_Table[l].TableDescriptor.FieldDescriptors[m].FieldName;
					FieldDescriptor.EFieldTypes fieldType = this.m_Table[l].TableDescriptor.FieldDescriptors[m].FieldType;
					streamWriter.WriteLine(string.Concat(new string[] { "public static int ", tableName4, "_", fieldName, " = -1;" }));
				}
			}
			for (int n = 0; n < this.m_NTables; n++)
			{
				string tableName5 = this.m_Table[n].TableDescriptor.TableName;
				for (int num = 0; num < this.m_Table[n].TableDescriptor.NFields; num++)
				{
					string fieldName2 = this.m_Table[n].TableDescriptor.FieldDescriptors[num].FieldName;
					FieldDescriptor.EFieldTypes fieldType2 = this.m_Table[n].TableDescriptor.FieldDescriptors[num].FieldType;
					streamWriter.WriteLine(string.Concat(new string[]
					{
						tableName5,
						"_",
						fieldName2,
						" = ",
						this.m_Table[n].TableDescriptor.FieldDescriptors[num].TypeIndex.ToString(),
						"; //",
						fieldType2.ToString()
					}));
				}
			}
			streamWriter.Close();
			fileStream.Close();
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00030DB4 File Offset: 0x0002EFB4
		public DataSet ConvertToDataSet()
		{
			if (this.m_NTables == 0)
			{
				return null;
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = this.m_NTables;
			}
			DataSet dataSet = new DataSet();
			for (int i = 0; i < this.m_NTables; i++)
			{
				if (this.m_ProgressBar != null)
				{
					this.m_ProgressBar.Value = i;
				}
				dataSet.Tables.Add(this.Table[i].ConvertToDataTable());
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
			return dataSet;
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00030E3C File Offset: 0x0002F03C
		public void ConvertFromDataSet(DataSet dataSet)
		{
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = this.m_NTables;
			}
			for (int i = 0; i < this.m_NTables; i++)
			{
				if (this.m_ProgressBar != null)
				{
					this.m_ProgressBar.Value = i;
				}
				this.Table[i].ConvertFromDataTable(dataSet.Tables[i]);
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00030EB4 File Offset: 0x0002F0B4
		public int GetTableIndex(string tableName)
		{
			for (int i = 0; i < this.NTables; i++)
			{
				if (this.Table[i].TableDescriptor.TableName == tableName)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00030EF0 File Offset: 0x0002F0F0
		public bool Expand()
		{
			bool flag = true;
			bool flag2 = this.ExpandTableField("playernames", "commentaryid", 20, 0);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("playernames");
			flag2 = this.ExpandTableField("career_lastnames", "lastname", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("career_lastnames", "lastnameid", 12);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("career_lastnames");
			flag2 = this.ExpandTableField("career_firstnames", "firstname", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("career_firstnames", "firstnameid", 12);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("career_firstnames");
			flag2 = this.ExpandTableField("career_commonnames", "firstname", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("career_lastnames", "lastname", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("career_commonnames", "commonnameid", 12);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("career_commonnames");
			flag2 = this.ExpandTableField("trainingteamplayernames", "nameid", 16);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("trainingteamplayernames");
			flag2 = this.ExpandTableField("players", "firstnameid", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("players", "lastnameid", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("players", "commonnameid", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("players", "playerjerseynameid", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("players", "shoetypecode", 9);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("players");
			flag2 = this.ExpandTableField("trainingteamplayernames", "firstnameid", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("trainingteamplayernames", "lastnameid", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("trainingteamplayernames", "commonnameid", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("trainingteamplayernames", "playerjerseynameid", 16);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("trainingteamplayernames", "shoetypecode", 9);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("trainingteamplayernames");
			flag2 = this.ExpandTableField("referee", "refereeid", 10);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("referee");
			flag2 = this.ExpandTableField("leaguerefereelinks", "refereeid", 10);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("leaguerefereelinks");
			flag2 = this.ExpandTableField("stadiums", "stadiumgoalnetstyle", 6);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("stadiums", "stadiummowpattern_code", 5);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("stadiums");
			flag2 = this.ExpandTableField("teamkits", "numberfonttype", 10);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("teamkits", "shortsnumberfonttype", 10);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("teamkits");
			flag2 = this.ExpandTableField("teams", "adboardid", 12);
			flag = flag && !flag2;
			flag2 = this.ExpandTableField("teams", "balltype", 12);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("teams");
			flag2 = this.ExpandTableField("teamballs", "ballid", 12);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("teamballs");
			flag2 = this.ExpandTableField("competition", "ballid", 12);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("competition");
			flag2 = this.ExpandTableField("temp_teams_adboardid", "adboardid", 12);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("temp_teams_adboardid");
			flag2 = this.ExpandTableField("temp_teams", "adboardid", 12);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("temp_teams");
			flag2 = this.ExpandTableField("temp_arenateam", "adboardid", 12);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("temp_arenateam");
			flag2 = this.ExpandTableField("factory_teams", "adboardid", 12);
			flag = flag && !flag2;
			this.RecalculateFieldOffset("factory_teams");
			this.m_NeedToSaveXmlFile = true;
			return flag;
		}

		// Token: 0x0600081E RID: 2078 RVA: 0x000313BC File Offset: 0x0002F5BC
		private bool ExpandTableField(string tableName, string fieldName, int nBits)
		{
			Table table = this.GetTable(tableName);
			return table != null && table.ExpandField(fieldName, nBits);
		}

		// Token: 0x0600081F RID: 2079 RVA: 0x000313E0 File Offset: 0x0002F5E0
		private bool ExpandTableField(string tableName, string fieldName, int nBits, int minValue)
		{
			Table table = this.GetTable(tableName);
			return table != null && table.ExpandField(fieldName, nBits, minValue);
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00031404 File Offset: 0x0002F604
		private bool RecalculateFieldOffset(string tableName)
		{
			Table table = this.GetTable(tableName);
			if (table == null)
			{
				return false;
			}
			table.TableDescriptor.RecalculateFieldOffset();
			return true;
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x0003142C File Offset: 0x0002F62C
		public Table GetTable(string longName)
		{
			for (int i = 0; i < this.m_NTables; i++)
			{
				if (this.m_Table[i].TableDescriptor.TableName == longName)
				{
					return this.m_Table[i];
				}
			}
			return null;
		}

		// Token: 0x04000344 RID: 836
		protected char[] m_Signature;

		// Token: 0x04000345 RID: 837
		protected int m_FileLength;

		// Token: 0x04000346 RID: 838
		private long m_SignaturePosition;

		// Token: 0x04000347 RID: 839
		private uint m_CrcHeader;

		// Token: 0x04000348 RID: 840
		private long m_CrcHeaderPosition;

		// Token: 0x04000349 RID: 841
		private uint m_CrcShortNames;

		// Token: 0x0400034A RID: 842
		private long m_CrcShortNamesPosition;

		// Token: 0x0400034B RID: 843
		private uint[] m_TableOffset;

		// Token: 0x0400034C RID: 844
		private Table[] m_Table;

		// Token: 0x0400034D RID: 845
		protected int m_NTables;

		// Token: 0x0400034E RID: 846
		private ToolStripProgressBar m_ProgressBar;

		// Token: 0x0400034F RID: 847
		protected string m_FileName;

		// Token: 0x04000350 RID: 848
		protected string m_XmlFileName;

		// Token: 0x04000351 RID: 849
		protected DataSet m_DescriptorDataSet;

		// Token: 0x04000352 RID: 850
		private bool m_NeedToSaveXmlFile;

		// Token: 0x04000353 RID: 851
		protected FifaPlatform m_Platform;
	}
}
