using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000012 RID: 18
	public class FifaFat
	{
		// Token: 0x17000047 RID: 71
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000B222 File Offset: 0x00009422
		public ToolStripProgressBar ProgressBar
		{
			set
			{
				this.m_ProgressBar = value;
			}
		}

		// Token: 0x17000048 RID: 72
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000B22B File Offset: 0x0000942B
		public string PathName
		{
			get
			{
				return this.m_PathName;
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0000B234 File Offset: 0x00009434
		public FifaBigFile GetBigFile(int index)
		{
			if (index < 0 || index >= this.m_NBigFiles)
			{
				return null;
			}
			if (this.m_BigFiles[index] != null)
			{
				return this.m_BigFiles[index];
			}
			this.m_BigFiles[index] = new FifaBigFile(this.m_BigFileNames[index]);
			return this.m_BigFiles[index];
		}

		// Token: 0x17000049 RID: 73
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000B280 File Offset: 0x00009480
		public int NBigFiles
		{
			get
			{
				return this.m_NBigFiles;
			}
		}

		// Token: 0x1700004A RID: 74
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000B288 File Offset: 0x00009488
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000B290 File Offset: 0x00009490
		public FifaFat.EFifaFatSaveOption SaveOption
		{
			get
			{
				return this.m_SaveOption;
			}
			set
			{
				this.m_SaveOption = value;
			}
		}

		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000B299 File Offset: 0x00009499
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000B2A1 File Offset: 0x000094A1
		public int Min_Zdata
		{
			get
			{
				return this.m_MinZdata;
			}
			set
			{
				this.m_MinZdata = value;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000B2AC File Offset: 0x000094AC
		public static FifaFat Create(string rootPath)
		{
			if (!Directory.Exists(rootPath + "\\Game"))
			{
				return null;
			}
			FifaFat fifaFat = new FifaFat();
			fifaFat.m_PathName = rootPath;
			fifaFat.Load();
			fifaFat.m_SaveOption = FifaFat.EFifaFatSaveOption.SaveAlways;
			return fifaFat;
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000B2E8 File Offset: 0x000094E8
		private void LoadBigFromFolder(string folder)
		{
			if (!Directory.Exists(folder))
			{
				return;
			}
			string[] files = Directory.GetFiles(folder, "*.big");
			if (files == null)
			{
				return;
			}
			foreach (string text in files)
			{
				string text2 = text;
				string text3 = folder + Path.GetFileNameWithoutExtension(text) + ".bh";
				if (File.Exists(text2))
				{
					this.m_BigFileNames[this.m_NBigFiles] = text2;
					this.m_BhFileNames[this.m_NBigFiles] = text3;
					if (File.Exists(text3))
					{
						this.m_BhFiles[this.m_NBigFiles] = new BhFile(text3);
					}
					else
					{
						this.m_BigFiles[this.m_NBigFiles] = new FifaBigFile(text2);
						if (this.m_BhFiles[this.m_NBigFiles] == null)
						{
							this.m_BigFiles[this.m_NBigFiles].LoadArchivedFiles();
							this.m_BhFiles[this.m_NBigFiles] = new BhFile(this.m_BigFiles[this.m_NBigFiles], true);
						}
					}
					this.m_NBigFiles++;
				}
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000B3EC File Offset: 0x000095EC
		private void Load()
		{
			this.m_NBigFiles = 0;
			string text = this.m_PathName + "\\Game\\";
			this.LoadBigFromFolder(text);
			text = this.m_PathName + "\\Game\\data\\ui\\imgAssets\\heads\\";
			this.LoadBigFromFolder(text);
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000B430 File Offset: 0x00009630
		public void Save()
		{
			for (int i = 0; i <= this.m_NBigFiles; i++)
			{
				if (this.m_NeedToSaveBig[i])
				{
					this.GetBigFile(i).Save();
				}
				if (this.m_BhFiles[i] != null)
				{
					this.m_BhFiles[i].Save();
				}
			}
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000B47C File Offset: 0x0000967C
		public void RegenerateAllBh(bool hideExternalFiles)
		{
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = this.m_NBigFiles;
				this.m_ProgressBar.Value = 0;
			}
			for (int i = 0; i < this.m_NBigFiles; i++)
			{
				string bigFileNameByIndex = this.GetBigFileNameByIndex(i);
				if (File.Exists(bigFileNameByIndex))
				{
					BhFile.Regenerate(bigFileNameByIndex, hideExternalFiles);
					if (this.m_ProgressBar != null)
					{
						this.m_ProgressBar.Value = i;
					}
				}
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
			this.Load();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000B504 File Offset: 0x00009704
		public bool IsArchivedFilePresent(string fileName)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			return archivingBhFileIndex >= 0;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000B520 File Offset: 0x00009720
		public bool IsPhisycalFilePresent(string fileName)
		{
			string text = this.m_PathName + "\\Game\\" + fileName;
			return File.Exists(text);
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0000B548 File Offset: 0x00009748
		public bool IsHeadFilePresent(string fileName)
		{
			for (int i = this.m_NBigFiles - 1; i >= 0; i--)
			{
				if (this.m_BhFileNames[i].Contains("heads"))
				{
					int archivedFileIndex = this.m_BhFiles[i].GetArchivedFileIndex(fileName);
					if (archivedFileIndex >= 0)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0000B594 File Offset: 0x00009794
		public string GetBigFileNameByIndex(int index)
		{
			if (index < this.m_NBigFiles)
			{
				return this.m_BigFileNames[index];
			}
			return null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000B5AC File Offset: 0x000097AC
		public string GetBhFileName(int bigIndex)
		{
			return this.m_PathName + "\\Game\\data" + bigIndex.ToString() + ".bh";
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000B5D8 File Offset: 0x000097D8
		public string GetBigFileName(int bigIndex)
		{
			return this.m_PathName + "\\Game\\data" + bigIndex.ToString() + ".big";
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000B604 File Offset: 0x00009804
		public static string GetBhFileName(int bigIndex, string rootPath)
		{
			return rootPath + "\\Game\\data" + bigIndex.ToString() + ".bh";
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000B62C File Offset: 0x0000982C
		public static string GetBigFileName(int bigIndex, string rootPath)
		{
			return rootPath + "\\Game\\data" + bigIndex.ToString() + ".big";
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000B654 File Offset: 0x00009854
		private int SearchBigName(string fileName)
		{
			string fileName2 = Path.GetFileName(fileName);
			for (int i = 0; i <= this.m_NBigFiles; i++)
			{
				string fileName3 = Path.GetFileName(this.GetBigFileName(i));
				if (fileName2 == fileName3)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0000B694 File Offset: 0x00009894
		public FifaFile GetArchivedFile(string fileName)
		{
			ulong num = FifaUtil.ComputeBhHash(fileName);
			for (int i = this.m_NBigFiles; i >= 0; i--)
			{
				if (this.m_BhFiles[i] != null)
				{
					int archivedFileIndex = this.m_BhFiles[i].GetArchivedFileIndex(num);
					if (archivedFileIndex >= 0)
					{
						return this.GetBigFile(i).GetArchivedFile(archivedFileIndex);
					}
				}
			}
			return null;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000B6E8 File Offset: 0x000098E8
		public bool DeleteFile(string fileName)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			if (archivingBhFileIndex < 0)
			{
				return false;
			}
			int archivedFileIndex = this.m_BhFiles[archivingBhFileIndex].GetArchivedFileIndex(fileName);
			if (archivedFileIndex < 0)
			{
				return false;
			}
			this.GetBigFile(archivingBhFileIndex).Delete(archivedFileIndex);
			this.m_BhFiles[archivingBhFileIndex].Delete(archivedFileIndex);
			if (this.m_SaveOption == FifaFat.EFifaFatSaveOption.SaveAlways)
			{
				this.GetBigFile(archivingBhFileIndex).Save();
				this.m_BhFiles[archivingBhFileIndex].Save();
			}
			else
			{
				this.m_NeedToSaveBig[archivingBhFileIndex] = true;
			}
			return true;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0000B764 File Offset: 0x00009964
		public bool HideFile(string fileName)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			if (archivingBhFileIndex < 0)
			{
				return false;
			}
			int archivedFileIndex = this.m_BhFiles[archivingBhFileIndex].GetArchivedFileIndex(fileName);
			return this.m_BhFiles[archivingBhFileIndex].Hide(archivedFileIndex);
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000B7A0 File Offset: 0x000099A0
		public bool RestoreFile(string fileName)
		{
			int num;
			int archivingBigFileIndex = this.GetArchivingBigFileIndex(fileName, out num);
			return archivingBigFileIndex >= 0 && this.m_BhFiles[archivingBigFileIndex].Restore(fileName, num);
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000B7D0 File Offset: 0x000099D0
		public bool ExportFile(string fileName, string exportDir)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			if (archivingBhFileIndex < 0)
			{
				return false;
			}
			int archivedFileIndex = this.m_BhFiles[archivingBhFileIndex].GetArchivedFileIndex(fileName);
			return this.GetBigFile(archivingBhFileIndex).Export(archivedFileIndex, exportDir);
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0000B808 File Offset: 0x00009A08
		public bool ExportFile(string fileName)
		{
			return this.ExportFile(fileName, this.m_PathName + "\\Game\\");
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0000B824 File Offset: 0x00009A24
		public bool ExtractFile(string fileName)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			if (archivingBhFileIndex < 0)
			{
				return false;
			}
			int archivedFileIndex = this.m_BhFiles[archivingBhFileIndex].GetArchivedFileIndex(fileName);
			bool flag = this.GetBigFile(archivingBhFileIndex).Export(archivedFileIndex, this.m_PathName + "\\Game");
			if (flag)
			{
				flag = this.m_BhFiles[archivingBhFileIndex].Hide(archivedFileIndex);
			}
			return flag;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0000B880 File Offset: 0x00009A80
		public bool ImportFileAs(string fileName, string archivedName, bool delete, ECompressionMode compressionMode)
		{
			delete = delete && !fileName.Contains("#");
			archivedName = archivedName.Replace('\\', '/');
			int num = this.m_DeafultDataIndex;
			if (num < 0)
			{
				num = this.GetArchivingBhFileIndex(archivedName);
				if (num < 0)
				{
					num = this.GetAvailableBigFileIndex();
				}
			}
			if (num < 0)
			{
				return false;
			}
			this.GetBigFile(num).ImportFileAs(fileName, archivedName, compressionMode);
			if (this.m_SaveOption == FifaFat.EFifaFatSaveOption.SaveAlways)
			{
				this.GetBigFile(num).Save();
				this.m_BhFiles[num] = new BhFile(this.GetBigFile(num), true);
				this.m_BhFiles[num].Save();
			}
			else
			{
				this.m_BhFiles[num] = new BhFile(this.GetBigFile(num), true);
				this.m_NeedToSaveBig[num] = true;
			}
			if (delete)
			{
				File.Delete(fileName);
			}
			return true;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0000B944 File Offset: 0x00009B44
		public bool ImportFile(string fileName, bool delete, ECompressionMode compressionMode)
		{
			string fileName2 = Path.GetFileName(fileName);
			return this.ImportFileAs(fileName, fileName2, delete, compressionMode);
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000B964 File Offset: 0x00009B64
		public ECompressionMode GetCompressionMode(string fileName)
		{
			FifaFile archivedFile = this.GetArchivedFile(fileName);
			if (archivedFile == null)
			{
				return ECompressionMode.None;
			}
			return archivedFile.CompressionMode;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000B984 File Offset: 0x00009B84
		private FifaBigFile GetArchivingBigFile(string fileName)
		{
			int archivingBhFileIndex = this.GetArchivingBhFileIndex(fileName);
			if (archivingBhFileIndex >= 0)
			{
				return this.GetBigFile(archivingBhFileIndex);
			}
			return null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000B9A8 File Offset: 0x00009BA8
		private int GetArchivingBhFileIndex(string fileName)
		{
			ulong num = FifaUtil.ComputeBhHash(fileName);
			for (int i = this.m_NBigFiles; i >= 0; i--)
			{
				if (this.m_BhFiles[i] != null && this.m_BhFiles[i].IsArchivedFilePresent(num))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0000B9EC File Offset: 0x00009BEC
		private int GetArchivingBigFileIndex(string fileName, out int fileIndex)
		{
			fileIndex = -1;
			for (int i = this.m_NBigFiles - 1; i >= 0; i--)
			{
				fileIndex = this.GetBigFile(i).GetArchivedFileIndex(fileName, true);
				if (fileIndex >= 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0000BA28 File Offset: 0x00009C28
		private FifaBigFile GetAvailableBigFile()
		{
			int availableBigFileIndex = this.GetAvailableBigFileIndex();
			if (availableBigFileIndex < 0)
			{
				return null;
			}
			return this.GetBigFile(availableBigFileIndex);
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000BA4C File Offset: 0x00009C4C
		private int GetAvailableBigFileIndex()
		{
			for (int i = this.m_MinZdata; i < 100; i++)
			{
				if (this.m_BigFiles[i] == null)
				{
					this.CreateNewBigFile(i);
					return i;
				}
				if (this.m_BigFiles[i].NFiles < 500)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000BA98 File Offset: 0x00009C98
		public void CreateNewBigFile(int index)
		{
			string bigFileName = this.GetBigFileName(index);
			FileStream fileStream = new FileStream(bigFileName, FileMode.Create, FileAccess.Write);
			fileStream.WriteByte(0);
			fileStream.Close();
			this.m_BigFiles[index] = new FifaBigFile(bigFileName);
			this.m_BhFiles[index] = new BhFile(this.m_BigFiles[index], false);
			this.m_NeedToSaveBig[index] = false;
			if (index > this.m_NBigFiles)
			{
				this.m_NBigFiles = index;
			}
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0000BB00 File Offset: 0x00009D00
		public void SetDefaultDataBig(int bigNumber)
		{
			if (this.m_BigFiles[bigNumber] == null)
			{
				this.CreateNewBigFile(bigNumber);
			}
			this.m_DeafultDataIndex = bigNumber;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x0000BB1A File Offset: 0x00009D1A
		public void ResetDefaultZdata()
		{
			this.m_DeafultDataIndex = -1;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x0000BB24 File Offset: 0x00009D24
		public ArrayList FindDuplicatedFiles()
		{
			ArrayList arrayList = new ArrayList();
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Maximum = 100;
			}
			int num = 0;
			for (int i = 0; i < 100; i++)
			{
				if (this.m_ProgressBar != null)
				{
					this.m_ProgressBar.Value = i;
				}
				if (this.m_BhFiles[i] != null)
				{
					for (int j = 0; j < this.m_BhFiles[i].NFiles; j++)
					{
						ulong hash = this.m_BhFiles[i].GetHash(j);
						for (int k = i + 1; k < 100; k++)
						{
							if (this.m_BhFiles[k] != null)
							{
								int archivedFileIndex = this.m_BhFiles[k].GetArchivedFileIndex(hash);
								if (archivedFileIndex >= 0)
								{
									num++;
									FifaBigFile fifaBigFile = new FifaBigFile(this.GetBigFileName(i));
									FifaFile fifaFile = fifaBigFile.Files[j];
									string text = string.Concat(new string[]
									{
										fifaFile.Name,
										" is duplicated in ",
										fifaBigFile.Name,
										" and ",
										Path.GetFileName(this.GetBigFileName(k)),
										"\r\n"
									});
									arrayList.Add(text);
								}
							}
						}
					}
				}
			}
			if (this.m_ProgressBar != null)
			{
				this.m_ProgressBar.Value = 0;
			}
			if (num == 0)
			{
				arrayList.Add("No duplicated files found.");
			}
			else
			{
				arrayList.Add(num.ToString() + " duplicated files found.");
			}
			return arrayList;
		}

		// Token: 0x040000B0 RID: 176
		private ToolStripProgressBar m_ProgressBar;

		// Token: 0x040000B1 RID: 177
		private string m_PathName;

		// Token: 0x040000B2 RID: 178
		private BhFile[] m_BhFiles = new BhFile[100];

		// Token: 0x040000B3 RID: 179
		private FifaBigFile[] m_BigFiles = new FifaBigFile[100];

		// Token: 0x040000B4 RID: 180
		private bool[] m_NeedToSaveBig = new bool[100];

		// Token: 0x040000B5 RID: 181
		private string[] m_BigFileNames = new string[100];

		// Token: 0x040000B6 RID: 182
		private string[] m_BhFileNames = new string[100];

		// Token: 0x040000B7 RID: 183
		private int m_NBigFiles;

		// Token: 0x040000B8 RID: 184
		private FifaFat.EFifaFatSaveOption m_SaveOption;

		// Token: 0x040000B9 RID: 185
		private int m_MinZdata = 8;

		// Token: 0x040000BA RID: 186
		private int m_DeafultDataIndex = -1;

		// Token: 0x02000013 RID: 19
		public enum EFifaFatSaveOption
		{
			// Token: 0x040000BC RID: 188
			SaveAlways,
			// Token: 0x040000BD RID: 189
			SaveOnCommand
		}
	}
}
