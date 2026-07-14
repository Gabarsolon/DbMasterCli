using System;
using System.Collections;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200008D RID: 141
	public class FifaBigFile : FifaFile
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x00049850 File Offset: 0x00047A50
		public int NFiles
		{
			get
			{
				return this.m_NFiles;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000AE3 RID: 2787 RVA: 0x00049858 File Offset: 0x00047A58
		public FifaFileHeader[] Headers
		{
			get
			{
				return this.m_Headers;
			}
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06000AE4 RID: 2788 RVA: 0x00049860 File Offset: 0x00047A60
		public FifaFile[] Files
		{
			get
			{
				return this.m_Files;
			}
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x00049868 File Offset: 0x00047A68
		private int EstimateAlignement()
		{
			int num = 256;
			for (int i = 0; i < this.m_NFiles; i++)
			{
				int num2 = FifaUtil.ComputeAlignement(this.m_Headers[i].StartPosition);
				if (num2 < num)
				{
					num = num2;
				}
			}
			return num;
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x000498A8 File Offset: 0x00047AA8
		public FifaBigFile(FifaFile fifaFile)
			: base(fifaFile)
		{
			if (base.IsCompressed)
			{
				base.Decompress();
			}
			BinaryReader reader = base.GetReader();
			this.Load(reader);
			base.ReleaseReader(reader);
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x000498EC File Offset: 0x00047AEC
		public FifaBigFile(string fileName)
			: base(fileName, true)
		{
			if (base.IsCompressed)
			{
				base.Decompress();
			}
			BinaryReader reader = base.GetReader();
			this.Load(reader);
			base.ReleaseReader(reader);
		}

		// Token: 0x06000AE8 RID: 2792 RVA: 0x00049930 File Offset: 0x00047B30
		private bool Load(BinaryReader r)
		{
			char[] array = r.ReadChars(4);
			if (array[0] != 'B' || array[1] != 'I' || array[2] != 'G' || (array[3] != 'F' && array[3] != '4'))
			{
				return false;
			}
			this.m_TotalFileSize = r.ReadInt32();
			this.m_NFiles = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_HeaderSize = FifaUtil.SwapEndian(r.ReadInt32());
			this.m_Headers = new FifaFileHeader[this.m_NFiles];
			this.m_Files = new FifaFile[this.m_NFiles];
			for (int i = 0; i < this.m_NFiles; i++)
			{
				this.m_Headers[i] = new FifaFileHeader(this);
				this.m_Headers[i].Load(r);
			}
			if (this.m_HeaderSize == (int)r.BaseStream.Position + 8)
			{
				this.m_EndSignature = r.ReadBytes(8);
			}
			this.m_Alignement = this.EstimateAlignement();
			return true;
		}

		// Token: 0x06000AE9 RID: 2793 RVA: 0x00049A18 File Offset: 0x00047C18
		public bool LoadArchivedFiles()
		{
			BinaryReader reader = base.GetReader();
			this.m_Files = new FifaFile[this.m_NFiles];
			for (int i = 0; i < this.m_NFiles; i++)
			{
				this.m_Files[i] = new FifaFile(this.m_Headers[i], reader);
			}
			base.ReleaseReader(reader);
			return true;
		}

		// Token: 0x06000AEA RID: 2794 RVA: 0x00049A6C File Offset: 0x00047C6C
		public bool LoadArchivedFile(int fileIndex)
		{
			if (fileIndex < 0 || fileIndex >= this.m_NFiles)
			{
				return false;
			}
			BinaryReader reader = base.GetReader();
			this.m_Files[fileIndex] = new FifaFile(this.m_Headers[fileIndex], reader);
			base.ReleaseReader(reader);
			return true;
		}

		// Token: 0x06000AEB RID: 2795 RVA: 0x00049AB0 File Offset: 0x00047CB0
		public FifaFile[] GetArchivedFiles(string searchPattern, bool useFullPath)
		{
			bool[] array = new bool[this.m_NFiles];
			int num = 0;
			for (int i = 0; i < this.m_NFiles; i++)
			{
				string text = this.m_Headers[i].Name;
				if (!useFullPath)
				{
					text = Path.GetFileName(text);
				}
				if (array[i] = FifaUtil.CompareWildcardString(searchPattern, text))
				{
					num++;
				}
			}
			FifaFile[] array2 = new FifaFile[num];
			if (num == 0)
			{
				return array2;
			}
			BinaryReader binaryReader = null;
			for (int j = 0; j < this.m_NFiles; j++)
			{
				if (array[j] && this.m_Files[j] == null)
				{
					binaryReader = base.GetReader();
					break;
				}
			}
			num = 0;
			for (int k = 0; k < this.m_NFiles; k++)
			{
				if (array[k])
				{
					if (this.m_Files[k] == null)
					{
						this.m_Files[k] = new FifaFile(this.m_Headers[k], binaryReader);
					}
					array2[num++] = this.m_Files[k];
				}
			}
			if (binaryReader != null)
			{
				base.ReleaseReader(binaryReader);
			}
			return array2;
		}

		// Token: 0x06000AEC RID: 2796 RVA: 0x00049BAC File Offset: 0x00047DAC
		public string[] GetArchivedFileNames(string searchPattern, bool useFullPath)
		{
			bool[] array = new bool[this.m_NFiles];
			int num = 0;
			for (int i = 0; i < this.m_NFiles; i++)
			{
				string text = this.m_Headers[i].Name;
				if (!useFullPath)
				{
					text = Path.GetFileName(text);
				}
				if (array[i] = FifaUtil.CompareWildcardString(searchPattern, text))
				{
					num++;
				}
			}
			string[] array2 = new string[num];
			num = 0;
			for (int j = 0; j < this.m_NFiles; j++)
			{
				if (array[j])
				{
					array2[num++] = this.m_Headers[j].Name;
				}
			}
			return array2;
		}

		// Token: 0x06000AED RID: 2797 RVA: 0x00049C44 File Offset: 0x00047E44
		public FifaFile GetArchivedFile(string fileName, bool useFullPath)
		{
			FifaFile[] archivedFiles = this.GetArchivedFiles(fileName, useFullPath);
			if (archivedFiles.Length == 0)
			{
				return null;
			}
			if (archivedFiles.Length > 1)
			{
				return null;
			}
			return archivedFiles[0];
		}

		// Token: 0x06000AEE RID: 2798 RVA: 0x00049C6C File Offset: 0x00047E6C
		public int GetArchivedFileIndex(string fileName, bool useFullPath)
		{
			if (!useFullPath)
			{
				fileName = Path.GetFileName(fileName);
			}
			for (int i = 0; i < this.m_NFiles; i++)
			{
				if (FifaUtil.CompareWildcardString(fileName, this.m_Headers[i].Name))
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000AEF RID: 2799 RVA: 0x00049CB0 File Offset: 0x00047EB0
		public FifaFile GetArchivedFile(int fileIndex)
		{
			if (fileIndex >= 0 && fileIndex < this.NFiles)
			{
				if (this.m_Files[fileIndex] == null)
				{
					BinaryReader reader = base.GetReader();
					this.m_Files[fileIndex] = new FifaFile(this.m_Headers[fileIndex], reader);
					base.ReleaseReader(reader);
				}
				return this.m_Files[fileIndex];
			}
			return null;
		}

		// Token: 0x06000AF0 RID: 2800 RVA: 0x00049D04 File Offset: 0x00047F04
		public bool Export(string fileName, string exportDir)
		{
			FifaFile archivedFile = this.GetArchivedFile(fileName, true);
			return archivedFile != null && archivedFile.UncompressedSize != 0 && archivedFile.Export(exportDir);
		}

		// Token: 0x06000AF1 RID: 2801 RVA: 0x00049D30 File Offset: 0x00047F30
		public bool Export(int fileIndex, string exportDir)
		{
			FifaFile archivedFile = this.GetArchivedFile(fileIndex);
			return archivedFile != null && archivedFile.UncompressedSize != 0 && archivedFile.Export(exportDir);
		}

		// Token: 0x06000AF2 RID: 2802 RVA: 0x00049D5C File Offset: 0x00047F5C
		public bool Export(string[] fileNames, string exportDir)
		{
			bool flag = false;
			if (fileNames.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < fileNames.Length; i++)
			{
				bool flag2 = this.Export(fileNames[i], exportDir);
				flag = flag || flag2;
			}
			return flag;
		}

		// Token: 0x06000AF3 RID: 2803 RVA: 0x00049D94 File Offset: 0x00047F94
		public void ImportReplacingFile(string path, int fileIndex)
		{
			FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			fileStream.Close();
			binaryReader.Close();
			FifaFile archivedFile = this.GetArchivedFile(fileIndex);
			if (archivedFile.CompressionMode == ECompressionMode.Chunkzip2)
			{
				this.m_Files[fileIndex] = new FifaFile(this, array, archivedFile.Name, ECompressionMode.None);
				return;
			}
			this.m_Files[fileIndex] = new FifaFile(this, array, archivedFile.Name, archivedFile.CompressionMode);
		}

		// Token: 0x06000AF4 RID: 2804 RVA: 0x00049E14 File Offset: 0x00048014
		public int ImportNewFile(string path, ECompressionMode compressionMode)
		{
			string fileName = Path.GetFileName(path);
			return this.ImportNewFileAs(path, fileName, compressionMode);
		}

		// Token: 0x06000AF5 RID: 2805 RVA: 0x00049E34 File Offset: 0x00048034
		public int ImportNewFileAs(string path, string archivedName, ECompressionMode compressionMode)
		{
			if (this.m_Files == null || this.m_Files.Length <= this.m_NFiles + 1)
			{
				this.Resize(this.m_NFiles + 32);
			}
			FileStream fileStream = new FileStream(path, FileMode.Open, FileAccess.Read);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			byte[] array = binaryReader.ReadBytes((int)binaryReader.BaseStream.Length);
			fileStream.Close();
			binaryReader.Close();
			this.m_Files[this.m_NFiles] = new FifaFile(this, array, archivedName, compressionMode);
			this.m_NFiles++;
			return this.m_NFiles - 1;
		}

		// Token: 0x06000AF6 RID: 2806 RVA: 0x00049EC8 File Offset: 0x000480C8
		public void ImportFile(string path, ECompressionMode compressionMode)
		{
			string fileName = Path.GetFileName(path);
			int archivedFileIndex = this.GetArchivedFileIndex(fileName, true);
			if (archivedFileIndex != -1)
			{
				this.ImportReplacingFile(path, archivedFileIndex);
				return;
			}
			this.ImportNewFile(path, compressionMode);
		}

		// Token: 0x06000AF7 RID: 2807 RVA: 0x00049EFC File Offset: 0x000480FC
		public void ImportFileAs(string path, string archivedName, ECompressionMode compressionMode)
		{
			int archivedFileIndex = this.GetArchivedFileIndex(archivedName, true);
			if (archivedFileIndex != -1)
			{
				this.ImportReplacingFile(path, archivedFileIndex);
				return;
			}
			this.ImportNewFileAs(path, archivedName, compressionMode);
		}

		// Token: 0x06000AF8 RID: 2808 RVA: 0x00049F2C File Offset: 0x0004812C
		public void Resize(int nFiles)
		{
			if (this.m_NFiles == 0)
			{
				this.m_Files = new FifaFile[nFiles];
				return;
			}
			int nfiles = this.m_NFiles;
			FifaFile[] array = (FifaFile[])this.m_Files.Clone();
			this.m_Files = new FifaFile[nFiles];
			if (nFiles < this.m_NFiles)
			{
				Array.Copy(array, 0, this.m_Files, 0, nFiles);
			}
			if (nFiles > this.m_NFiles)
			{
				Array.Copy(array, 0, this.m_Files, 0, this.m_NFiles);
			}
		}

		// Token: 0x06000AF9 RID: 2809 RVA: 0x00049FAC File Offset: 0x000481AC
		private int ComputeHeaderSize()
		{
			int num = 16;
			for (int i = 0; i < this.m_NFiles; i++)
			{
				num += this.m_Headers[i].Name.Length + 1;
				num += 8;
			}
			this.m_HeaderSize = num;
			if (this.m_EndSignature != null)
			{
				this.m_HeaderSize += this.m_EndSignature.Length;
			}
			return FifaUtil.RoundUp(num, this.m_Alignement);
		}

		// Token: 0x06000AFA RID: 2810 RVA: 0x0004A01C File Offset: 0x0004821C
		public void Save()
		{
			BinaryReader binaryReader = null;
			BinaryWriter binaryWriter;
			if (this.NFiles == 0)
			{
				binaryWriter = base.GetWriter();
				binaryWriter.Write(0);
			}
			else
			{
				binaryWriter = base.GetWriter();
				binaryReader = base.GetReader();
				this.ComputeHeaderSize();
				binaryWriter.BaseStream.Position = (long)this.m_HeaderSize;
				for (int i = 0; i < this.m_NFiles; i++)
				{
					if (this.m_Files[i] == null)
					{
						this.m_Files[i] = new FifaFile(this.m_Headers[i], binaryReader);
					}
					this.m_Headers[i].StartPosition = (int)binaryWriter.BaseStream.Position;
					this.m_Headers[i].Name = this.m_Files[i].Name;
					this.m_Files[i].Save(binaryWriter);
					if (this.m_Files[i].IsToCompress)
					{
						this.m_Headers[i].Size = this.m_Files[i].CompressedSize;
					}
					else
					{
						this.m_Headers[i].Size = this.m_Files[i].UncompressedSize;
					}
					int num = (int)binaryWriter.BaseStream.Position;
					num = FifaUtil.RoundUp(num, this.m_Alignement);
					binaryWriter.BaseStream.Position = (long)num;
				}
				this.m_TotalFileSize = (int)binaryWriter.BaseStream.Position;
				binaryWriter.Seek(0, SeekOrigin.Begin);
				binaryWriter.Write('B');
				binaryWriter.Write('I');
				binaryWriter.Write('G');
				binaryWriter.Write('4');
				binaryWriter.Write(this.m_TotalFileSize);
				binaryWriter.Write(FifaUtil.SwapEndian(this.m_NFiles));
				binaryWriter.Write(FifaUtil.SwapEndian(this.m_HeaderSize));
				for (int j = 0; j < this.m_NFiles; j++)
				{
					this.m_Headers[j].Save(binaryWriter);
				}
				if (this.m_EndSignature != null)
				{
					binaryWriter.Write(this.m_EndSignature);
				}
			}
			base.ReleaseReader(binaryReader);
			base.ReleaseWriter(binaryWriter);
			if (base.Archive == null)
			{
				if (base.IsInMemory)
				{
					if (File.Exists(base.PhysicalName))
					{
						FileAttributes attributes = File.GetAttributes(base.PhysicalName);
						if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
						{
							File.SetAttributes(base.PhysicalName, FileAttributes.Archive);
						}
					}
					FileStream fileStream = new FileStream(base.PhysicalName, FileMode.Create, FileAccess.Write);
					new BinaryWriter(fileStream);
					base.Save(fileStream);
					fileStream.Close();
					return;
				}
			}
			else
			{
				base.Archive.Save();
			}
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0004A278 File Offset: 0x00048478
		public void Sort()
		{
			string[] array = new string[this.m_NFiles];
			string[] array2 = new string[this.m_NFiles];
			for (int i = 0; i < this.m_NFiles; i++)
			{
				array[i] = this.Files[i].Name;
				array2[i] = this.Files[i].Name;
			}
			Array.Sort(array, this.m_Files, FifaBigFile.s_StringComparer);
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0004A2E0 File Offset: 0x000484E0
		public bool Delete(int index)
		{
			if (index >= this.m_NFiles)
			{
				return false;
			}
			this.m_NFiles--;
			for (int i = index; i < this.m_NFiles; i++)
			{
				this.m_Files[i] = this.m_Files[i + 1];
			}
			for (int j = index; j < this.m_NFiles; j++)
			{
				this.m_Headers[j] = this.m_Headers[j + 1];
			}
			return true;
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0004A350 File Offset: 0x00048550
		public bool Delete(string fileName)
		{
			int archivedFileIndex = this.GetArchivedFileIndex(fileName, true);
			return archivedFileIndex >= 0 && this.Delete(archivedFileIndex);
		}

		// Token: 0x06000AFE RID: 2814 RVA: 0x0004A374 File Offset: 0x00048574
		public bool Delete(FifaFile fifaFile)
		{
			string name = fifaFile.Name;
			return this.Delete(name);
		}

		// Token: 0x06000AFF RID: 2815 RVA: 0x0004A390 File Offset: 0x00048590
		public int Delete(string[] fileNames)
		{
			int num = 0;
			for (int i = 0; i < fileNames.Length; i++)
			{
				if (this.Delete(fileNames[i]))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000B00 RID: 2816 RVA: 0x0004A3C0 File Offset: 0x000485C0
		public void Rename(string originalName, string newName)
		{
			FifaFile archivedFile = this.GetArchivedFile(originalName, true);
			if (archivedFile != null)
			{
				archivedFile.Rename(newName);
			}
		}

		// Token: 0x06000B01 RID: 2817 RVA: 0x0004A3E0 File Offset: 0x000485E0
		public FifaFile GetFirstDds()
		{
			for (int i = 0; i < this.m_NFiles; i++)
			{
				if (this.m_Files[i] == null)
				{
					this.LoadArchivedFiles();
					break;
				}
			}
			for (int j = 0; j < this.m_NFiles; j++)
			{
				if (this.m_Files[j].IsDds())
				{
					return this.m_Files[j];
				}
			}
			return null;
		}

		// Token: 0x04000F96 RID: 3990
		private int m_TotalFileSize;

		// Token: 0x04000F97 RID: 3991
		private int m_NFiles;

		// Token: 0x04000F98 RID: 3992
		private int m_HeaderSize;

		// Token: 0x04000F99 RID: 3993
		private FifaFileHeader[] m_Headers;

		// Token: 0x04000F9A RID: 3994
		private static FifaBigFile.StringComparer s_StringComparer = new FifaBigFile.StringComparer();

		// Token: 0x04000F9B RID: 3995
		private FifaFile[] m_Files;

		// Token: 0x04000F9C RID: 3996
		private byte[] m_EndSignature;

		// Token: 0x04000F9D RID: 3997
		private int m_Alignement = 16;

		// Token: 0x0200008E RID: 142
		public class StringComparer : IComparer
		{
			// Token: 0x06000B03 RID: 2819 RVA: 0x0004A448 File Offset: 0x00048648
			int IComparer.Compare(object x, object y)
			{
				string text = (string)x;
				string text2 = (string)y;
				return string.Compare(text, text2, StringComparison.Ordinal);
			}
		}
	}
}
