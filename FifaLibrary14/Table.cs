using System;
using System.Data;

namespace FifaLibrary
{
	// Token: 0x02000062 RID: 98
	public class Table
	{
		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x0600086C RID: 2156 RVA: 0x0003234C File Offset: 0x0003054C
		// (set) Token: 0x0600086D RID: 2157 RVA: 0x00032354 File Offset: 0x00030554
		public int Unknown00
		{
			get
			{
				return this.m_Unknown00;
			}
			set
			{
				this.m_Unknown00 = value;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x0600086E RID: 2158 RVA: 0x0003235D File Offset: 0x0003055D
		// (set) Token: 0x0600086F RID: 2159 RVA: 0x00032365 File Offset: 0x00030565
		public uint CompressedStringLength
		{
			get
			{
				return this.m_CompressedStringLength;
			}
			set
			{
				this.m_CompressedStringLength = value;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000870 RID: 2160 RVA: 0x0003236E File Offset: 0x0003056E
		// (set) Token: 0x06000871 RID: 2161 RVA: 0x00032376 File Offset: 0x00030576
		public int Unknown14
		{
			get
			{
				return this.m_Unknown14;
			}
			set
			{
				this.m_Unknown14 = value;
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000872 RID: 2162 RVA: 0x0003237F File Offset: 0x0003057F
		// (set) Token: 0x06000873 RID: 2163 RVA: 0x00032387 File Offset: 0x00030587
		public int Unknown1C
		{
			get
			{
				return this.m_Unknown1C;
			}
			set
			{
				this.m_Unknown1C = value;
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000874 RID: 2164 RVA: 0x00032390 File Offset: 0x00030590
		// (set) Token: 0x06000875 RID: 2165 RVA: 0x00032398 File Offset: 0x00030598
		public uint CrcTableHeader
		{
			get
			{
				return this.m_CrcTableHeader;
			}
			set
			{
				this.m_CrcTableHeader = value;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000876 RID: 2166 RVA: 0x000323A1 File Offset: 0x000305A1
		// (set) Token: 0x06000877 RID: 2167 RVA: 0x000323A9 File Offset: 0x000305A9
		public long CrcTableHeaderPosition
		{
			get
			{
				return this.m_CrcTableHeaderPosition;
			}
			set
			{
				this.m_CrcTableHeaderPosition = value;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x06000878 RID: 2168 RVA: 0x000323B2 File Offset: 0x000305B2
		// (set) Token: 0x06000879 RID: 2169 RVA: 0x000323BA File Offset: 0x000305BA
		public uint CrcRecords
		{
			get
			{
				return this.m_CrcRecords;
			}
			set
			{
				this.m_CrcRecords = value;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600087A RID: 2170 RVA: 0x000323C3 File Offset: 0x000305C3
		// (set) Token: 0x0600087B RID: 2171 RVA: 0x000323CB File Offset: 0x000305CB
		public long CrcRecordsPosition
		{
			get
			{
				return this.m_CrcRecordsPosition;
			}
			set
			{
				this.m_CrcRecordsPosition = value;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x0600087C RID: 2172 RVA: 0x000323D4 File Offset: 0x000305D4
		// (set) Token: 0x0600087D RID: 2173 RVA: 0x000323DC File Offset: 0x000305DC
		public int NRecords
		{
			get
			{
				return this.m_NRecords;
			}
			set
			{
				this.m_NRecords = value;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x0600087E RID: 2174 RVA: 0x000323E5 File Offset: 0x000305E5
		// (set) Token: 0x0600087F RID: 2175 RVA: 0x000323ED File Offset: 0x000305ED
		public int NValidRecords
		{
			get
			{
				return this.m_NValidRecords;
			}
			set
			{
				this.m_NValidRecords = value;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000880 RID: 2176 RVA: 0x000323F6 File Offset: 0x000305F6
		// (set) Token: 0x06000881 RID: 2177 RVA: 0x000323FE File Offset: 0x000305FE
		public Record[] Records
		{
			get
			{
				return this.m_Records;
			}
			set
			{
				this.m_Records = value;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00032407 File Offset: 0x00030607
		// (set) Token: 0x06000883 RID: 2179 RVA: 0x0003240F File Offset: 0x0003060F
		public TableDescriptor TableDescriptor
		{
			get
			{
				return this.m_TableDescriptor;
			}
			set
			{
				this.m_TableDescriptor = value;
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x00032418 File Offset: 0x00030618
		public Table()
		{
			this.m_TableDescriptor = new TableDescriptor();
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x0003242B File Offset: 0x0003062B
		public Table(TableDescriptor tableDescriptor)
		{
			this.m_TableDescriptor = tableDescriptor;
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x0003243A File Offset: 0x0003063A
		public void LoadTableName(DbReader r)
		{
			this.m_TableDescriptor.LoadTableName(r);
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x00032448 File Offset: 0x00030648
		public bool Load(DbReader r, long offset)
		{
			bool flag = true;
			r.BaseStream.Position = offset;
			this.m_Unknown00 = r.ReadInt32();
			this.m_TableDescriptor.RecordSize = r.ReadInt32();
			this.m_TableDescriptor.NBitRecords = r.ReadUInt32();
			this.m_CompressedStringLength = r.ReadUInt32();
			this.m_NRecords = (int)r.ReadUInt16();
			this.m_NValidRecords = (int)r.ReadUInt16();
			this.m_Unknown14 = r.ReadInt32();
			this.m_TableDescriptor.NFields = (int)r.ReadByte();
			r.ReadBytes(3);
			this.m_Unknown1C = r.ReadInt32();
			this.m_CrcTableHeaderPosition = r.BaseStream.Position;
			this.m_CrcTableHeader = r.ReadUInt32();
			this.m_TableDescriptor.LoadFieldDescriptors(r);
			this.m_TableDescriptor.SortFields();
			if (this.m_NRecords > 0)
			{
				this.m_Records = new Record[this.m_NRecords];
				Record.HuffmannTreeSize = int.MaxValue;
				for (int i = 0; i < this.m_NRecords; i++)
				{
					this.m_Records[i] = new Record(this.m_TableDescriptor);
					bool flag2 = this.m_Records[i].Load(r);
					flag = flag && flag2;
				}
				if (this.m_TableDescriptor.NCompressedStringFields > 0)
				{
					long position = r.BaseStream.Position;
					int num = Record.HuffmannTreeSize / 4;
					this.m_TableDescriptor.HuffmannTree = new HuffmannTree(num);
					this.m_TableDescriptor.HuffmannTree.Load(r);
					for (int j = 0; j < this.m_NRecords; j++)
					{
						r.BaseStream.Position = position;
						this.m_Records[j].LoadCompressedStrings(r);
					}
					r.BaseStream.Position = (long)((ulong)this.m_CompressedStringLength + (ulong)position);
				}
			}
			this.m_CrcRecordsPosition = r.BaseStream.Position;
			this.m_CrcRecords = r.ReadUInt32();
			return flag;
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00032628 File Offset: 0x00030828
		public void Save(DbWriter w)
		{
			w.Write(this.m_Unknown00);
			w.Write(this.m_TableDescriptor.RecordSize);
			w.Write(this.m_TableDescriptor.NBitRecords);
			long position = w.BaseStream.Position;
			if (this.m_TableDescriptor.NCompressedStringFields == 0)
			{
				w.Write(0);
			}
			else
			{
				w.Write(-1);
			}
			w.Write((ushort)this.m_NRecords);
			w.Write((ushort)this.m_NValidRecords);
			w.Write(this.m_Unknown14);
			w.Write((byte)this.m_TableDescriptor.NFields);
			w.Write(new byte[3]);
			w.Write(this.m_Unknown1C);
			this.m_CrcTableHeaderPosition = w.BaseStream.Position;
			w.Write(-1);
			this.m_TableDescriptor.SaveFieldDescriptors(w);
			long num = w.BaseStream.Position + (long)(this.m_NRecords * this.m_TableDescriptor.RecordSize);
			int num2 = 0;
			if (this.m_TableDescriptor.HuffmannTree != null)
			{
				num2 = this.m_TableDescriptor.HuffmannTree.Size;
			}
			if (this.m_NRecords > 0)
			{
				for (int i = 0; i < this.m_NValidRecords; i++)
				{
					num2 = this.m_Records[i].Save(w, num, num2);
				}
				for (int j = this.m_NValidRecords; j < this.m_NRecords; j++)
				{
					this.m_Records[j].Fill(w);
				}
				if (this.m_TableDescriptor.HuffmannTree != null)
				{
					w.BaseStream.Position = position;
					this.m_CompressedStringLength = (uint)num2;
					w.Write(num2);
					w.BaseStream.Position = num;
					this.m_TableDescriptor.HuffmannTree.Save(w);
				}
				num2 = FifaUtil.RoundUp(num2, 8);
				this.m_CrcRecordsPosition = num + (long)num2;
				w.BaseStream.Position = this.m_CrcRecordsPosition;
				w.Write(-1);
				return;
			}
			this.m_CrcRecordsPosition = w.BaseStream.Position;
			w.Write(-1);
		}

		// Token: 0x06000889 RID: 2185 RVA: 0x00032820 File Offset: 0x00030A20
		public void SortByKeys()
		{
			if (this.m_TableDescriptor.KeyIndex.Length == 0)
			{
				return;
			}
			if (this.m_NRecords >= 2)
			{
				Array.Sort(this.m_Records, Table.s_RecordComparer);
			}
		}

		// Token: 0x0600088A RID: 2186 RVA: 0x0003284C File Offset: 0x00030A4C
		public void SortByKeys(int keyIndex)
		{
			if (this.m_TableDescriptor.KeyIndex.Length == 0)
			{
				return;
			}
			int num = this.m_TableDescriptor.KeyIndex[0];
			this.m_TableDescriptor.KeyIndex[0] = keyIndex;
			if (this.m_TableDescriptor.NKeyFields == 0)
			{
				this.m_TableDescriptor.NKeyFields = 1;
			}
			if (this.m_NRecords >= 2)
			{
				Array.Sort(this.m_Records, Table.s_RecordComparer);
			}
			this.m_TableDescriptor.KeyIndex[0] = num;
		}

		// Token: 0x0600088B RID: 2187 RVA: 0x000328C8 File Offset: 0x00030AC8
		public Record SearchByKeys(Record r)
		{
			if (this.m_Records == null || r == null)
			{
				return null;
			}
			int num = Array.BinarySearch(this.m_Records, r, Table.s_RecordComparer);
			if (num >= 0)
			{
				return this.m_Records[num];
			}
			return null;
		}

		// Token: 0x0600088C RID: 2188 RVA: 0x00032904 File Offset: 0x00030B04
		public string SearchStringByKey(int key)
		{
			Record record = new Record(this.m_TableDescriptor);
			record.KeyField[0] = key;
			int num = Array.BinarySearch(this.m_Records, record, Table.s_RecordComparer);
			if (num >= 0)
			{
				return this.m_Records[num].StringField[0];
			}
			return null;
		}

		// Token: 0x0600088D RID: 2189 RVA: 0x00032950 File Offset: 0x00030B50
		public void ExchangeRecords(int i, int j)
		{
			Record record = new Record(this.m_TableDescriptor);
			record = this.m_Records[i];
			this.m_Records[i] = this.m_Records[j];
			this.m_Records[j] = record;
		}

		// Token: 0x0600088E RID: 2190 RVA: 0x0003298C File Offset: 0x00030B8C
		public Record[] ResizeRecords(int nRecords)
		{
			int num = 0;
			if (this.m_Records != null)
			{
				num = this.m_Records.Length;
				Array.Resize<Record>(ref this.m_Records, nRecords);
			}
			else
			{
				this.m_Records = new Record[nRecords];
			}
			if (num < nRecords)
			{
				for (int i = num; i < nRecords; i++)
				{
					this.m_Records[i] = new Record(this.m_TableDescriptor);
				}
			}
			this.m_NRecords = nRecords;
			this.m_NValidRecords = nRecords;
			return this.m_Records;
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x00032A00 File Offset: 0x00030C00
		public bool ExpandField(string fieldName, int nBits)
		{
			FieldDescriptor fieldDescriptor = this.m_TableDescriptor.GetFieldDescriptor(fieldName);
			return fieldDescriptor != null && fieldDescriptor.Expand(nBits);
		}

		// Token: 0x06000890 RID: 2192 RVA: 0x00032A28 File Offset: 0x00030C28
		public bool ExpandField(string fieldName, int nBits, int minValue)
		{
			FieldDescriptor fieldDescriptor = this.m_TableDescriptor.GetFieldDescriptor(fieldName);
			return fieldDescriptor != null && fieldDescriptor.Expand(nBits, minValue);
		}

		// Token: 0x06000891 RID: 2193 RVA: 0x00032A50 File Offset: 0x00030C50
		public DataTable ConvertToDataTable()
		{
			DataTable dataTable = this.CreateEmptyDataTable();
			for (int i = 0; i < this.m_NRecords; i++)
			{
				dataTable.Rows.Add(this.Records[i].ConvertToDataRow());
			}
			return dataTable;
		}

		// Token: 0x06000892 RID: 2194 RVA: 0x00032A90 File Offset: 0x00030C90
		public DataTable ConvertToDataTable(int[] keys, string fieldName)
		{
			DataTable dataTable = this.CreateEmptyDataTable();
			int fieldIndex = this.m_TableDescriptor.GetFieldIndex(fieldName);
			Array.Sort<int>(keys);
			this.SortByKeys(fieldIndex);
			int num = 0;
			int i = num;
			int num2 = 0;
			while (num2 < keys.Length && i < this.m_NRecords)
			{
				i = num;
				while (i < this.m_NRecords)
				{
					if (this.Records[i].IntField[fieldIndex] >= keys[num2])
					{
						if (this.Records[i].IntField[fieldIndex] == keys[num2])
						{
							dataTable.Rows.Add(this.Records[i].ConvertToDataRow());
							num = i + 1;
							break;
						}
						num = i;
						num2++;
						break;
					}
					else
					{
						i++;
					}
				}
			}
			return dataTable;
		}

		// Token: 0x06000893 RID: 2195 RVA: 0x00032B44 File Offset: 0x00030D44
		public DataTable ConvertToDataTableUsingRtsg(int[] keys, string fieldName)
		{
			DataTable dataTable = this.CreateEmptyDataTable();
			int fieldIndex = this.m_TableDescriptor.GetFieldIndex(fieldName);
			Array.Sort<int>(keys);
			for (int i = 0; i < this.m_NRecords; i++)
			{
				int num = (this.Records[i].IntField[fieldIndex] >> 20) & 4095;
				for (int j = 0; j < keys.Length; j++)
				{
					if (keys[j] == num)
					{
						dataTable.Rows.Add(this.Records[i].ConvertToDataRow());
						break;
					}
				}
			}
			return dataTable;
		}

		// Token: 0x06000894 RID: 2196 RVA: 0x00032BCC File Offset: 0x00030DCC
		public DataTable ConvertToDataTableUsingIntField(int[] keys, int intFieldIndex)
		{
			DataTable dataTable = this.CreateEmptyDataTable();
			Array.Sort<int>(keys);
			for (int i = 0; i < this.m_NRecords; i++)
			{
				for (int j = 0; j < keys.Length; j++)
				{
					if (keys[j] == this.Records[i].IntField[intFieldIndex])
					{
						dataTable.Rows.Add(this.Records[i].ConvertToDataRow());
						break;
					}
				}
			}
			return dataTable;
		}

		// Token: 0x06000895 RID: 2197 RVA: 0x00032C38 File Offset: 0x00030E38
		public DataTable CreateEmptyDataTable()
		{
			int num = 0;
			float num2 = 1f;
			string text = "string";
			Type type = num.GetType();
			Type type2 = num2.GetType();
			Type type3 = text.GetType();
			DataTable dataTable = new DataTable(this.m_TableDescriptor.TableName);
			for (int i = 0; i < this.m_TableDescriptor.NFields; i++)
			{
				FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
					dataTable.Columns.Add(this.TableDescriptor.FieldDescriptors[i].FieldName, type3);
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
					dataTable.Columns.Add(this.TableDescriptor.FieldDescriptors[i].FieldName, type);
					break;
				case FieldDescriptor.EFieldTypes.Float:
					dataTable.Columns.Add(this.TableDescriptor.FieldDescriptors[i].FieldName, type2);
					break;
				default:
					switch (fieldType)
					{
					case FieldDescriptor.EFieldTypes.ShortCompressedString:
						dataTable.Columns.Add(this.TableDescriptor.FieldDescriptors[i].FieldName, type3);
						break;
					case FieldDescriptor.EFieldTypes.LongCompressedString:
						dataTable.Columns.Add(this.TableDescriptor.FieldDescriptors[i].FieldName, type3);
						break;
					}
					break;
				}
			}
			return dataTable;
		}

		// Token: 0x06000896 RID: 2198 RVA: 0x00032DA4 File Offset: 0x00030FA4
		public void ConvertFromDataTable(DataTable dataTable)
		{
			this.m_NRecords = dataTable.Rows.Count;
			this.m_NValidRecords = this.m_NRecords;
			if (this.Records != null)
			{
				this.ResizeRecords(this.m_NRecords);
			}
			else
			{
				this.Records = new Record[this.m_NRecords];
				for (int i = 0; i < this.m_NRecords; i++)
				{
					this.Records[i] = new Record(this.m_TableDescriptor);
				}
			}
			for (int j = 0; j < this.m_NRecords; j++)
			{
				this.Records[j].ConvertFromDataRow(dataTable.Rows[j]);
			}
		}

		// Token: 0x0400037E RID: 894
		private int m_Unknown00;

		// Token: 0x0400037F RID: 895
		private uint m_CompressedStringLength;

		// Token: 0x04000380 RID: 896
		private int m_Unknown14;

		// Token: 0x04000381 RID: 897
		private int m_Unknown1C;

		// Token: 0x04000382 RID: 898
		private uint m_CrcTableHeader;

		// Token: 0x04000383 RID: 899
		private long m_CrcTableHeaderPosition;

		// Token: 0x04000384 RID: 900
		private uint m_CrcRecords;

		// Token: 0x04000385 RID: 901
		private long m_CrcRecordsPosition;

		// Token: 0x04000386 RID: 902
		private int m_NRecords;

		// Token: 0x04000387 RID: 903
		private int m_NValidRecords;

		// Token: 0x04000388 RID: 904
		private static RecordComparer s_RecordComparer = new RecordComparer();

		// Token: 0x04000389 RID: 905
		protected Record[] m_Records;

		// Token: 0x0400038A RID: 906
		private TableDescriptor m_TableDescriptor;
	}
}
