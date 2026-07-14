using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200000E RID: 14
	public class BhFile
	{
		// Token: 0x1700003E RID: 62
		// (get) Token: 0x060000FE RID: 254 RVA: 0x0000A661 File Offset: 0x00008861
		public int NFiles
		{
			get
			{
				return this.m_NFiles;
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000A66C File Offset: 0x0000886C
		private bool Load(string fileName)
		{
			if (!File.Exists(fileName))
			{
				return false;
			}
			this.m_BhName = fileName;
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			char[] array = binaryReader.ReadChars(4);
			if (array[0] != 'V' || array[1] != 'i' || array[2] != 'V' || array[3] != '4')
			{
				binaryReader.Close();
				fileStream.Close();
				return false;
			}
			this.m_TotalFileSize = binaryReader.ReadInt32();
			this.m_NFiles = FifaUtil.SwapEndian(binaryReader.ReadInt32());
			FifaUtil.SwapEndian(binaryReader.ReadInt32());
			this.m_BhFileReference = new BhFileReference[this.m_NFiles];
			for (int i = 0; i < this.m_NFiles; i++)
			{
				this.m_BhFileReference[i] = new BhFileReference();
				this.m_BhFileReference[i].Load(binaryReader);
			}
			if (binaryReader.BaseStream.Position <= binaryReader.BaseStream.Length - 4L)
			{
				this.m_TotalBigFileSize = FifaUtil.SwapEndian(binaryReader.ReadInt32());
			}
			binaryReader.Close();
			fileStream.Close();
			return true;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000A76C File Offset: 0x0000896C
		public bool Load(FifaBigFile bigFile, bool hideExternalFiles)
		{
			int num = bigFile.PhysicalName.IndexOf("\\Game\\", 0, StringComparison.InvariantCultureIgnoreCase);
			string text;
			if (num >= 0)
			{
				text = bigFile.PhysicalName.Substring(0, num + 6);
			}
			else
			{
				text = Path.GetDirectoryName(bigFile.PhysicalName) + "\\";
			}
			this.m_BhName = Path.GetDirectoryName(bigFile.PhysicalName) + "\\" + Path.GetFileNameWithoutExtension(bigFile.PhysicalName) + ".bh";
			this.m_NFiles = bigFile.NFiles;
			if (this.m_BhName.Contains("FIFA 11"))
			{
				this.m_TotalFileSize = 16 + (this.m_NFiles + 1) * 20;
			}
			else
			{
				this.m_TotalFileSize = 16 + this.m_NFiles * 20;
			}
			this.m_BhFileReference = new BhFileReference[this.m_NFiles];
			this.m_TotalBigFileSize = bigFile.UncompressedSize;
			for (int i = 0; i < this.m_NFiles; i++)
			{
				int startPosition = bigFile.Headers[i].StartPosition;
				int size = bigFile.Headers[i].Size;
				if (bigFile.Files[i] == null)
				{
					bigFile.LoadArchivedFile(i);
				}
				int num2;
				if (bigFile.Files[i].CompressionMode == ECompressionMode.Compressed_10FB)
				{
					num2 = bigFile.Files[i].UncompressedSize;
				}
				else
				{
					num2 = 0;
				}
				string name = bigFile.Headers[i].Name;
				this.m_BhFileReference[i] = new BhFileReference(startPosition, size, num2, name);
				if (hideExternalFiles)
				{
					string text2 = text + name;
					if (File.Exists(text2))
					{
						this.m_BhFileReference[i].Hide();
					}
				}
			}
			return true;
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000A8FC File Offset: 0x00008AFC
		public bool Hide(string fileName)
		{
			int archivedFileIndex = this.GetArchivedFileIndex(fileName);
			return this.Hide(archivedFileIndex);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000A918 File Offset: 0x00008B18
		public bool Hide(int fileIndex)
		{
			if (fileIndex < 0 || fileIndex >= this.m_NFiles)
			{
				return false;
			}
			this.m_BhFileReference[fileIndex].Hide();
			return true;
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000A937 File Offset: 0x00008B37
		public bool IsHidden(int fileIndex)
		{
			return fileIndex >= 0 && fileIndex < this.m_NFiles && this.m_BhFileReference[fileIndex].IsHidden();
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000A958 File Offset: 0x00008B58
		public bool IsHidden(string fileName)
		{
			int archivedFileIndex = this.GetArchivedFileIndex(fileName);
			return this.IsHidden(archivedFileIndex);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000A974 File Offset: 0x00008B74
		public bool Restore(string fileName, int fileIndex)
		{
			if (fileIndex < 0 || fileIndex >= this.m_NFiles)
			{
				return false;
			}
			this.m_BhFileReference[fileIndex].Restore(fileName);
			return true;
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000A994 File Offset: 0x00008B94
		public BhFile(FifaBigFile bigFile, bool hideExternalFiles)
		{
			this.Load(bigFile, hideExternalFiles);
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000A9A5 File Offset: 0x00008BA5
		public BhFile(string fileName)
		{
			if (this.Load(fileName))
			{
				this.m_BhName = fileName;
				return;
			}
			this.Reset();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000A9C4 File Offset: 0x00008BC4
		private void Reset()
		{
			this.m_TotalFileSize = 0;
			this.m_NFiles = 0;
			this.m_BhFileReference = null;
			this.m_BhName = null;
			this.m_TotalBigFileSize = 0;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000A9EC File Offset: 0x00008BEC
		public static void Regenerate(FifaBigFile bigFile, bool hideExternalFiles)
		{
			BhFile bhFile = new BhFile(bigFile, hideExternalFiles);
			bhFile.Save();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000AA08 File Offset: 0x00008C08
		public static void Regenerate(string bigFileName, bool hideExternalFiles)
		{
			FifaBigFile fifaBigFile = new FifaBigFile(bigFileName);
			if (fifaBigFile == null)
			{
				return;
			}
			fifaBigFile.LoadArchivedFiles();
			BhFile.Regenerate(fifaBigFile, hideExternalFiles);
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000AA30 File Offset: 0x00008C30
		public bool Save()
		{
			string bhName = this.m_BhName;
			if (this.m_BhName == null)
			{
				return false;
			}
			if (File.Exists(bhName))
			{
				FileAttributes attributes = File.GetAttributes(bhName);
				if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					File.SetAttributes(bhName, FileAttributes.Archive);
				}
			}
			FileStream fileStream = new FileStream(bhName, FileMode.Create, FileAccess.Write);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			if (this.m_NFiles == 0)
			{
				binaryWriter.Write(0);
			}
			else
			{
				binaryWriter.Write(86);
				binaryWriter.Write(105);
				binaryWriter.Write(86);
				binaryWriter.Write(52);
				binaryWriter.Write(this.m_TotalFileSize);
				binaryWriter.Write(FifaUtil.SwapEndian(this.m_NFiles));
				binaryWriter.Write(FifaUtil.SwapEndian(this.m_TotalFileSize));
				for (int i = 0; i < this.m_NFiles; i++)
				{
					this.m_BhFileReference[i].Save(binaryWriter);
				}
			}
			binaryWriter.Close();
			fileStream.Close();
			return true;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000AB0C File Offset: 0x00008D0C
		private bool SaveEmptyReference(BinaryWriter w)
		{
			for (int i = 0; i < 4; i++)
			{
				w.Write(0);
			}
			return true;
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000AB30 File Offset: 0x00008D30
		public int GetArchivedFileIndex(ulong hash)
		{
			for (int i = 0; i < this.m_NFiles; i++)
			{
				if (this.m_BhFileReference[i].Hash == hash)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000AB64 File Offset: 0x00008D64
		public int GetArchivedFileIndex(string fileName)
		{
			ulong num = FifaUtil.ComputeBhHash(fileName);
			return this.GetArchivedFileIndex(num);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000AB7F File Offset: 0x00008D7F
		public ulong GetHash(int fileIndex)
		{
			if (fileIndex < this.m_NFiles)
			{
				return this.m_BhFileReference[fileIndex].Hash;
			}
			return 0UL;
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000AB9C File Offset: 0x00008D9C
		public bool IsArchivedFilePresent(string fileName)
		{
			ulong num = FifaUtil.ComputeBhHash(fileName);
			return this.GetArchivedFileIndex(num) >= 0;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000ABBD File Offset: 0x00008DBD
		public bool IsArchivedFilePresent(ulong hash)
		{
			return this.GetArchivedFileIndex(hash) >= 0;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000ABCC File Offset: 0x00008DCC
		public bool Delete(int index)
		{
			if (index >= this.m_NFiles)
			{
				return false;
			}
			this.m_NFiles--;
			for (int i = index; i < this.m_NFiles; i++)
			{
				this.m_BhFileReference[i] = this.m_BhFileReference[i + 1];
			}
			this.m_TotalFileSize -= 20;
			return true;
		}

		// Token: 0x0400009A RID: 154
		private int m_TotalFileSize;

		// Token: 0x0400009B RID: 155
		private int m_NFiles;

		// Token: 0x0400009C RID: 156
		private BhFileReference[] m_BhFileReference;

		// Token: 0x0400009D RID: 157
		private string m_BhName;

		// Token: 0x0400009E RID: 158
		private int m_TotalBigFileSize;
	}
}
