using System;
using System.IO;
using zlib;

namespace FifaLibrary
{
	// Token: 0x0200008C RID: 140
	public class FifaFile
	{
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000A9F RID: 2719 RVA: 0x00047A76 File Offset: 0x00045C76
		// (set) Token: 0x06000AA0 RID: 2720 RVA: 0x00047A7E File Offset: 0x00045C7E
		public string Name
		{
			get
			{
				return this.m_Name;
			}
			set
			{
				this.m_Name = value;
			}
		}

		// Token: 0x06000AA1 RID: 2721 RVA: 0x00047A87 File Offset: 0x00045C87
		public override string ToString()
		{
			return this.m_Name;
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x00047A8F File Offset: 0x00045C8F
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x00047A97 File Offset: 0x00045C97
		public string PhysicalName
		{
			get
			{
				return this.m_PhysicalName;
			}
			set
			{
				this.m_PhysicalName = value;
			}
		}

		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x00047AA0 File Offset: 0x00045CA0
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x00047AA8 File Offset: 0x00045CA8
		public long StartPosition
		{
			get
			{
				return this.m_StartPosition;
			}
			set
			{
				this.m_StartPosition = value;
			}
		}

		// Token: 0x1700022F RID: 559
		// (get) Token: 0x06000AA6 RID: 2726 RVA: 0x00047AB1 File Offset: 0x00045CB1
		public int CompressedSize
		{
			get
			{
				return this.m_CompressedSize;
			}
		}

		// Token: 0x17000230 RID: 560
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x00047AB9 File Offset: 0x00045CB9
		public int UncompressedSize
		{
			get
			{
				return this.m_UncompressedSize;
			}
		}

		// Token: 0x17000231 RID: 561
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x00047AC1 File Offset: 0x00045CC1
		public int BlockInflatedSize
		{
			get
			{
				return this.m_MaxBlockUncompressedSize;
			}
		}

		// Token: 0x17000232 RID: 562
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x00047AC9 File Offset: 0x00045CC9
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x00047AD1 File Offset: 0x00045CD1
		public ECompressionMode CompressionMode
		{
			get
			{
				return this.m_RequiredCompression;
			}
			set
			{
				this.m_RequiredCompression = value;
			}
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x00047ADA File Offset: 0x00045CDA
		public bool IsToCompress
		{
			get
			{
				return this.m_RequiredCompression != ECompressionMode.None;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x06000AAC RID: 2732 RVA: 0x00047AE8 File Offset: 0x00045CE8
		public bool IsCompressed
		{
			get
			{
				return this.m_CurrentCompression != ECompressionMode.None;
			}
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000AAD RID: 2733 RVA: 0x00047AF6 File Offset: 0x00045CF6
		public bool IsArchived
		{
			get
			{
				return this.m_IsArchived;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06000AAE RID: 2734 RVA: 0x00047AFE File Offset: 0x00045CFE
		public FifaBigFile Archive
		{
			get
			{
				return this.m_Archive;
			}
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06000AAF RID: 2735 RVA: 0x00047B06 File Offset: 0x00045D06
		public bool IsInMemory
		{
			get
			{
				return this.m_IsInMemory;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06000AB0 RID: 2736 RVA: 0x00047B0E File Offset: 0x00045D0E
		public bool IsAnArchive
		{
			get
			{
				return this.m_IsAnArchive;
			}
		}

		// Token: 0x06000AB1 RID: 2737 RVA: 0x00047B16 File Offset: 0x00045D16
		public FifaFile(FifaBigFile archive, byte[] buffer, string name, ECompressionMode compressionMode)
		{
			this.Load(archive, buffer, name, compressionMode);
		}

		// Token: 0x06000AB2 RID: 2738 RVA: 0x00047B2C File Offset: 0x00045D2C
		private void Load(FifaBigFile archive, byte[] buffer, string name, ECompressionMode compressionMode)
		{
			this.m_Archive = archive;
			this.m_IsArchived = false;
			this.m_IsInMemory = true;
			this.m_ReadMemoryStream = new MemoryStream(buffer);
			this.m_PhysicalName = null;
			this.m_StartPosition = 0L;
			this.m_Name = name;
			string extension = Path.GetExtension(name);
			extension.ToLower();
			if (extension == ".big")
			{
				this.m_IsAnArchive = true;
			}
			else
			{
				this.m_IsAnArchive = false;
			}
			this.m_RequiredCompression = compressionMode;
			this.m_CurrentCompression = ECompressionMode.None;
			this.m_UncompressedSize = buffer.Length;
			if (this.IsToCompress)
			{
				this.m_CompressedSize = -1;
				return;
			}
			this.m_CompressedSize = this.m_UncompressedSize;
		}

		// Token: 0x06000AB3 RID: 2739 RVA: 0x00047BCF File Offset: 0x00045DCF
		public FifaFile(FifaFile fifaFile)
		{
			this.Load(fifaFile);
		}

		// Token: 0x06000AB4 RID: 2740 RVA: 0x00047BE0 File Offset: 0x00045DE0
		private void Load(FifaFile fifaFile)
		{
			this.m_Name = fifaFile.Name;
			this.m_Archive = fifaFile.Archive;
			this.m_IsArchived = fifaFile.IsArchived;
			this.m_IsInMemory = fifaFile.IsInMemory;
			this.m_PhysicalName = fifaFile.PhysicalName;
			this.m_StartPosition = fifaFile.StartPosition;
			this.m_IsAnArchive = true;
			this.m_RequiredCompression = fifaFile.m_RequiredCompression;
			this.m_CurrentCompression = fifaFile.m_CurrentCompression;
			this.m_CompressedSize = fifaFile.CompressedSize;
			this.m_UncompressedSize = fifaFile.UncompressedSize;
			this.m_ReadMemoryStream = fifaFile.m_ReadMemoryStream;
			this.m_WriteMemoryStream = fifaFile.m_WriteMemoryStream;
		}

		// Token: 0x06000AB5 RID: 2741 RVA: 0x00047C84 File Offset: 0x00045E84
		public FifaFile(string path, bool isAnArchive)
		{
			this.Load(path, isAnArchive);
		}

		// Token: 0x06000AB6 RID: 2742 RVA: 0x00047C94 File Offset: 0x00045E94
		private void Load(string path, bool isAnArchive)
		{
			this.m_Archive = null;
			this.m_IsArchived = false;
			this.m_IsInMemory = false;
			this.m_PhysicalName = path;
			this.m_StartPosition = 0L;
			this.m_Name = Path.GetFileName(path);
			this.m_IsAnArchive = isAnArchive;
			BinaryReader reader = this.GetReader();
			int num = (int)reader.BaseStream.Length;
			this.m_CompressedSize = (this.m_UncompressedSize = num);
			this.m_CurrentCompression = (this.m_RequiredCompression = ECompressionMode.None);
			this.CheckCompressionMode(reader);
			this.ReleaseReader(reader);
		}

		// Token: 0x06000AB7 RID: 2743 RVA: 0x00047D1B File Offset: 0x00045F1B
		public FifaFile(FifaFileHeader header, BinaryReader r)
		{
			this.Load(header.BigFile, header.StartPosition, header.Size, header.Name, false, r);
		}

		// Token: 0x06000AB8 RID: 2744 RVA: 0x00047D44 File Offset: 0x00045F44
		private void Load(FifaBigFile archive, int startPosition, int size, string name, bool isAnArchive, BinaryReader r)
		{
			this.m_Name = name;
			this.m_Archive = archive;
			this.m_IsArchived = true;
			this.m_IsInMemory = archive.IsInMemory;
			this.m_PhysicalName = this.m_Archive.PhysicalName;
			this.m_StartPosition = (long)startPosition;
			this.m_IsAnArchive = isAnArchive;
			this.m_UncompressedSize = size;
			this.m_CompressedSize = size;
			this.m_CurrentCompression = (this.m_RequiredCompression = ECompressionMode.Unknown);
			if (size == 0)
			{
				this.m_CurrentCompression = (this.m_RequiredCompression = ECompressionMode.None);
				return;
			}
			if (r == null)
			{
				r = this.m_Archive.GetReader();
				r.BaseStream.Position += (long)startPosition;
				this.CheckCompressionMode(r);
				this.ReleaseReader(r);
				return;
			}
			if (this.m_Archive != null)
			{
				r.BaseStream.Position = this.m_Archive.StartPosition + (long)startPosition;
			}
			else
			{
				r.BaseStream.Position = (long)startPosition;
			}
			this.CheckCompressionMode(r);
		}

		// Token: 0x06000AB9 RID: 2745 RVA: 0x00047E3C File Offset: 0x0004603C
		public void Save(Stream outputStream)
		{
			long position = outputStream.Position;
			if (this.IsToCompress && !this.IsCompressed)
			{
				this.Compress(outputStream);
			}
			else if (!this.IsToCompress && this.IsCompressed)
			{
				this.Decompress(outputStream);
			}
			else
			{
				BinaryReader reader = this.GetReader();
				int i = (this.IsCompressed ? this.m_CompressedSize : this.m_UncompressedSize);
				int num = 1048576;
				while (i > num)
				{
					outputStream.Write(reader.ReadBytes(num), 0, num);
					i -= num;
				}
				outputStream.Write(reader.ReadBytes(i), 0, i);
				this.ReleaseReader(reader);
			}
			if (this.m_Archive != null)
			{
				this.m_PhysicalName = this.m_Archive.PhysicalName;
				this.m_IsArchived = true;
			}
			this.m_StartPosition = position;
			this.m_ReadMemoryStream = null;
			this.m_WriteMemoryStream = null;
			this.m_IsInMemory = false;
		}

		// Token: 0x06000ABA RID: 2746 RVA: 0x00047F14 File Offset: 0x00046114
		public void Save(BinaryWriter w)
		{
			Stream baseStream = w.BaseStream;
			this.Save(baseStream);
		}

		// Token: 0x06000ABB RID: 2747 RVA: 0x00047F30 File Offset: 0x00046130
		private ECompressionMode CheckCompressionMode(BinaryReader r)
		{
			if (r.BaseStream.Length < 8L)
			{
				return ECompressionMode.None;
			}
			long position = r.BaseStream.Position;
			byte[] array = r.ReadBytes(8);
			if (array[0] == 16 && array[1] == 251)
			{
				this.m_CurrentCompression = ECompressionMode.Compressed_10FB;
				this.m_RequiredCompression = this.m_CurrentCompression;
				this.m_UncompressedSize = ((int)array[2] << 16) + ((int)array[3] << 8) + (int)array[4];
			}
			else
			{
				char[] array2 = new char[8];
				for (int i = 0; i < 8; i++)
				{
					array2[i] = (char)array[i];
				}
				string text = new string(array2);
				if (text.StartsWith("EASF"))
				{
					this.m_CompressedSize = ((int)array[4] << 24) + ((int)array[5] << 16) + ((int)array[6] << 8) + (int)array[7];
					r.ReadBytes(8);
					this.m_CurrentCompression = ECompressionMode.EASF;
					this.m_RequiredCompression = this.m_CurrentCompression;
				}
				else if (text == "chunkzip")
				{
					this.m_UncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
					this.m_CurrentCompression = ECompressionMode.Chunkzip;
					if (this.m_UncompressedSize == 2)
					{
						this.m_UncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						FifaUtil.SwapEndian(r.ReadInt32());
						r.ReadInt32();
						this.m_CurrentCompression = ECompressionMode.Chunkzip2;
						this.m_RequiredCompression = this.m_CurrentCompression;
					}
					else
					{
						this.m_MaxBlockUncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
						this.m_RequiredCompression = this.m_CurrentCompression;
					}
				}
				else if (text == "chunkref")
				{
					this.m_UncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
					if (this.m_UncompressedSize == 2)
					{
						this.m_UncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						r.ReadInt32();
						this.m_MaxBlockUncompressedSize = FifaUtil.SwapEndian(r.ReadInt32());
						r.ReadInt32();
						this.m_CurrentCompression = ECompressionMode.Chunkref2;
					}
					else
					{
						FifaUtil.SwapEndian(r.ReadInt32());
						FifaUtil.SwapEndian(r.ReadInt32());
						array = r.ReadBytes(8);
						if (array[0] == 16 && array[1] == 251)
						{
							this.m_CurrentCompression = ECompressionMode.Chunkref;
							this.m_RequiredCompression = this.m_CurrentCompression;
							this.m_UncompressedSize = ((int)array[2] << 16) + ((int)array[3] << 8) + (int)array[4];
						}
						else
						{
							this.m_CurrentCompression = ECompressionMode.Unknown;
						}
					}
					this.m_RequiredCompression = this.m_CurrentCompression;
				}
				else
				{
					this.m_CurrentCompression = ECompressionMode.None;
					this.m_RequiredCompression = this.m_CurrentCompression;
				}
			}
			r.BaseStream.Position = position;
			return this.m_CurrentCompression;
		}

		// Token: 0x06000ABC RID: 2748 RVA: 0x000481E4 File Offset: 0x000463E4
		public bool IsDds()
		{
			string extension = Path.GetExtension(this.m_Name);
			if (extension == string.Empty)
			{
				BinaryReader reader = this.GetReader();
				if (this.CompressedSize >= 16)
				{
					byte[] array = reader.ReadBytes(16);
					if ((array[6] == 68 && array[7] == 68 && array[8] == 83) || (array[0] == 68 && array[1] == 68 && array[2] == 83))
					{
						return true;
					}
				}
				this.ReleaseReader(reader);
			}
			return false;
		}

		// Token: 0x06000ABD RID: 2749 RVA: 0x00048258 File Offset: 0x00046458
		public bool Decompress(Stream outputStream)
		{
			if (this.m_CurrentCompression == ECompressionMode.None || this.m_CurrentCompression == ECompressionMode.EASF || this.m_CurrentCompression == ECompressionMode.Unknown)
			{
				outputStream.Write(this.Read(), 0, this.m_CompressedSize);
				return false;
			}
			if (this.m_IsArchived)
			{
				this.m_Archive.Decompress();
			}
			switch (this.m_CurrentCompression)
			{
			case ECompressionMode.Compressed_10FB:
				this.Uncompress_10FB(outputStream);
				break;
			case ECompressionMode.Chunkzip:
				this.UnChunkzip(outputStream);
				break;
			case ECompressionMode.Chunkzip2:
				this.UnChunkZip2(outputStream);
				break;
			case ECompressionMode.Chunkref:
				this.UnChunkref(outputStream);
				break;
			case ECompressionMode.Chunkref2:
				this.UnChunkref2(outputStream);
				break;
			case ECompressionMode.EASF:
				this.UnEASF(outputStream);
				break;
			}
			return true;
		}

		// Token: 0x06000ABE RID: 2750 RVA: 0x0004830C File Offset: 0x0004650C
		public bool Decompress()
		{
			if (this.m_CurrentCompression == ECompressionMode.None)
			{
				return false;
			}
			this.m_ReadMemoryStream = new MemoryStream(this.m_UncompressedSize);
			bool flag = this.Decompress(this.m_ReadMemoryStream);
			if (flag)
			{
				this.m_CurrentCompression = ECompressionMode.None;
				this.m_IsArchived = false;
				this.m_IsInMemory = true;
				this.m_StartPosition = 0L;
			}
			return flag;
		}

		// Token: 0x06000ABF RID: 2751 RVA: 0x00048364 File Offset: 0x00046564
		public bool Compress(Stream outputStream)
		{
			if (this.m_CurrentCompression != ECompressionMode.None)
			{
				outputStream.Write(this.Read(), 0, this.m_CompressedSize);
				return true;
			}
			if (this.m_CurrentCompression == this.m_RequiredCompression)
			{
				outputStream.Write(this.Read(), 0, this.m_CompressedSize);
				return true;
			}
			switch (this.m_RequiredCompression)
			{
			case ECompressionMode.Compressed_10FB:
				this.Compress_10FB(outputStream);
				break;
			case ECompressionMode.Chunkzip:
				this.Chunkzip(outputStream);
				break;
			case ECompressionMode.Chunkref:
				this.Chunkref(outputStream, this.m_UncompressedSize);
				break;
			}
			return true;
		}

		// Token: 0x06000AC0 RID: 2752 RVA: 0x000483F8 File Offset: 0x000465F8
		public BinaryReader GetReader()
		{
			BinaryReader binaryReader;
			if (this.m_IsInMemory)
			{
				if (this.m_ReadMemoryStream != null)
				{
					binaryReader = new BinaryReader(this.m_ReadMemoryStream);
					binaryReader.BaseStream.Position = this.m_StartPosition;
				}
				else
				{
					if (this.m_Archive == null)
					{
						return null;
					}
					binaryReader = this.m_Archive.GetReader();
					binaryReader.BaseStream.Position = this.m_StartPosition;
				}
			}
			else
			{
				FileStream fileStream = new FileStream(this.m_PhysicalName, FileMode.Open, FileAccess.Read);
				binaryReader = new BinaryReader(fileStream);
				binaryReader.BaseStream.Position = this.m_StartPosition;
				if (this.m_Archive != null)
				{
					binaryReader.BaseStream.Position += this.m_Archive.StartPosition;
				}
			}
			return binaryReader;
		}

		// Token: 0x06000AC1 RID: 2753 RVA: 0x000484A9 File Offset: 0x000466A9
		public void ReleaseReader(BinaryReader r)
		{
			if (!this.m_IsInMemory)
			{
				r.BaseStream.Close();
				r.Close();
			}
		}

		// Token: 0x06000AC2 RID: 2754 RVA: 0x000484C4 File Offset: 0x000466C4
		public StreamReader GetStreamReader()
		{
			if (this.m_ReadMemoryStream != null)
			{
				return new StreamReader(this.m_ReadMemoryStream);
			}
			StreamReader streamReader;
			if (this.m_Archive != null)
			{
				streamReader = this.m_Archive.GetStreamReader();
			}
			else
			{
				streamReader = new StreamReader(this.m_PhysicalName);
			}
			streamReader.BaseStream.Position += this.m_StartPosition;
			if (this.IsCompressed)
			{
				this.m_ReadMemoryStream = new MemoryStream();
				this.Decompress(this.m_ReadMemoryStream);
				this.m_ReadMemoryStream.Seek(0L, SeekOrigin.Begin);
				this.m_StartPosition = 0L;
				this.m_IsInMemory = true;
				return new StreamReader(this.m_ReadMemoryStream);
			}
			return streamReader;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0004856E File Offset: 0x0004676E
		public void ReleaseStreamReader(StreamReader r)
		{
			if (!this.m_IsInMemory)
			{
				r.BaseStream.Close();
				r.Close();
			}
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0004858C File Offset: 0x0004678C
		protected StreamWriter GetStreamWriter(ECompressionMode compressionMode)
		{
			this.m_WriteMemoryStream = new MemoryStream();
			StreamWriter streamWriter = new StreamWriter(this.m_WriteMemoryStream);
			this.m_IsInMemory = true;
			this.m_IsArchived = false;
			this.m_CurrentCompression = compressionMode;
			return streamWriter;
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x000485C8 File Offset: 0x000467C8
		protected bool ReleaseStreamWriter(StreamWriter w)
		{
			w.Flush();
			this.m_CompressedSize = (this.m_UncompressedSize = (int)this.m_WriteMemoryStream.Length);
			if (this.m_IsInMemory)
			{
				if (!this.IsCompressed)
				{
					if (this.IsToCompress)
					{
						byte[] array = this.Compress_10FB(this.m_WriteMemoryStream.GetBuffer());
						if (array == null)
						{
							this.m_CurrentCompression = ECompressionMode.None;
							this.m_RequiredCompression = ECompressionMode.None;
							this.m_CompressedSize = this.m_UncompressedSize;
							return false;
						}
						this.m_RequiredCompression = ECompressionMode.Compressed_10FB;
						this.m_CompressedSize = array.Length;
					}
				}
				else if (!this.IsToCompress)
				{
					byte[] array2 = FifaFile.Uncompress_10FB(this.m_WriteMemoryStream.GetBuffer());
					if (array2 == null)
					{
						this.m_CurrentCompression = ECompressionMode.None;
						this.m_RequiredCompression = ECompressionMode.None;
						this.m_UncompressedSize = this.m_CompressedSize;
						return false;
					}
					this.m_RequiredCompression = ECompressionMode.None;
					this.m_UncompressedSize = array2.Length;
				}
				this.m_ReadMemoryStream = this.m_WriteMemoryStream;
				this.m_StartPosition = 0L;
			}
			else
			{
				w.Close();
				if (File.Exists(this.PhysicalName + ".tmp"))
				{
					File.Delete(this.PhysicalName);
					File.Move(this.PhysicalName + ".tmp", this.PhysicalName);
				}
			}
			return true;
		}

		// Token: 0x06000AC6 RID: 2758 RVA: 0x000486FC File Offset: 0x000468FC
		private byte[] Read()
		{
			BinaryReader reader = this.GetReader();
			int num = (this.IsCompressed ? this.m_CompressedSize : this.m_UncompressedSize);
			byte[] array = reader.ReadBytes(num);
			this.ReleaseReader(reader);
			return array;
		}

		// Token: 0x06000AC7 RID: 2759 RVA: 0x00048738 File Offset: 0x00046938
		protected BinaryWriter GetWriter(int size, ECompressionMode compressionMode)
		{
			this.m_WriteMemoryStream = new MemoryStream(size);
			BinaryWriter binaryWriter = new BinaryWriter(this.m_WriteMemoryStream);
			this.m_IsInMemory = true;
			this.m_IsArchived = false;
			this.m_CurrentCompression = compressionMode;
			if (this.m_CurrentCompression != ECompressionMode.None)
			{
				this.m_CompressedSize = size;
				this.m_UncompressedSize = -1;
			}
			else
			{
				this.m_UncompressedSize = size;
				this.m_CompressedSize = -1;
			}
			return binaryWriter;
		}

		// Token: 0x06000AC8 RID: 2760 RVA: 0x0004879C File Offset: 0x0004699C
		public BinaryWriter GetWriter()
		{
			BinaryWriter binaryWriter;
			if (this.m_Archive == null && this.m_PhysicalName != null)
			{
				FileStream fileStream = new FileStream(this.m_PhysicalName + ".temp", FileMode.Create);
				binaryWriter = new BinaryWriter(fileStream);
				this.m_IsInMemory = false;
				this.m_IsArchived = false;
				return binaryWriter;
			}
			this.m_WriteMemoryStream = new MemoryStream();
			binaryWriter = new BinaryWriter(this.m_WriteMemoryStream);
			this.m_IsInMemory = true;
			this.m_IsArchived = false;
			return binaryWriter;
		}

		// Token: 0x06000AC9 RID: 2761 RVA: 0x00048810 File Offset: 0x00046A10
		public bool ReleaseWriter(BinaryWriter w)
		{
			if (this.m_IsInMemory)
			{
				if (!this.IsCompressed)
				{
					this.m_CompressedSize = -1;
					this.m_UncompressedSize = (int)this.m_WriteMemoryStream.Length;
				}
				else
				{
					this.m_UncompressedSize = -1;
					this.m_CompressedSize = (int)this.m_WriteMemoryStream.Length;
				}
				this.m_ReadMemoryStream = this.m_WriteMemoryStream;
				this.m_StartPosition = 0L;
			}
			else
			{
				w.Close();
				FileAttributes attributes = File.GetAttributes(this.PhysicalName);
				if ((attributes & FileAttributes.ReadOnly) == FileAttributes.ReadOnly)
				{
					File.SetAttributes(this.PhysicalName, FileAttributes.Archive);
				}
				File.Delete(this.m_PhysicalName);
				File.Move(this.m_PhysicalName + ".temp", this.m_PhysicalName);
			}
			return true;
		}

		// Token: 0x06000ACA RID: 2762 RVA: 0x000488C4 File Offset: 0x00046AC4
		public bool Export(string exportDir)
		{
			if (this.m_Name.StartsWith("C:"))
			{
				return false;
			}
			string text = exportDir + "\\" + this.m_Name;
			string directoryName = Path.GetDirectoryName(text);
			Path.GetExtension(text);
			if (!Directory.Exists(directoryName))
			{
				Directory.CreateDirectory(directoryName);
			}
			FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			if (this.IsCompressed)
			{
				this.Decompress();
			}
			BinaryReader reader = this.GetReader();
			int num = (this.IsCompressed ? this.m_CompressedSize : this.m_UncompressedSize);
			binaryWriter.Write(reader.ReadBytes(num));
			binaryWriter.Close();
			fileStream.Close();
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x06000ACB RID: 2763 RVA: 0x00048978 File Offset: 0x00046B78
		public void Rename(string name)
		{
			this.m_Name = name;
			if (this.Archive == null)
			{
				string text = Path.GetDirectoryName(this.m_PhysicalName) + "\\" + name;
				File.Move(this.m_PhysicalName, text);
				this.m_PhysicalName = text;
			}
		}

		// Token: 0x06000ACC RID: 2764 RVA: 0x000489BE File Offset: 0x00046BBE
		public bool SetCompressionMode(ECompressionMode compressionMode)
		{
			if (this.m_CurrentCompression == compressionMode)
			{
				return true;
			}
			if (this.m_CurrentCompression != ECompressionMode.None && compressionMode != ECompressionMode.None)
			{
				return false;
			}
			if (this.m_CurrentCompression == ECompressionMode.None && compressionMode != ECompressionMode.None)
			{
				this.m_RequiredCompression = compressionMode;
				this.m_CompressedSize = -1;
				return true;
			}
			return false;
		}

		// Token: 0x06000ACD RID: 2765 RVA: 0x000489F4 File Offset: 0x00046BF4
		private bool Uncompress_10FB(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			byte[] array = FifaFile.Uncompress_10FB(this.Read());
			if (array != null)
			{
				outputStream.Write(array, 0, this.m_UncompressedSize);
				this.m_UncompressedSize = array.Length;
				return true;
			}
			return false;
		}

		// Token: 0x06000ACE RID: 2766 RVA: 0x00048A38 File Offset: 0x00046C38
		private bool UnChunkref(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			BinaryReader reader = this.GetReader();
			string text = new string(reader.ReadChars(8));
			if (text != "chunkref")
			{
				return false;
			}
			this.m_UncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			FifaUtil.SwapEndian(reader.ReadInt32());
			int num = 20;
			do
			{
				int num2 = FifaUtil.SwapEndian(reader.ReadInt32());
				num += 4 + num2;
				byte[] array = FifaFile.Uncompress_10FB(reader.ReadBytes(num2));
				outputStream.Write(array, 0, array.Length);
			}
			while (num < this.m_CompressedSize);
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x06000ACF RID: 2767 RVA: 0x00048AD4 File Offset: 0x00046CD4
		private bool UnChunkref2(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			BinaryReader reader = this.GetReader();
			string text = new string(reader.ReadChars(8));
			if (text != "chunkref")
			{
				return false;
			}
			reader.ReadInt32();
			this.m_UncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			int num = FifaUtil.SwapEndian(reader.ReadInt32());
			reader.ReadInt32();
			byte[] array = FifaFile.Uncompress_10FB(reader.ReadBytes(num));
			outputStream.Write(array, 0, array.Length);
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x06000AD0 RID: 2768 RVA: 0x00048B84 File Offset: 0x00046D84
		private bool UnChunkZip2(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			BinaryReader reader = this.GetReader();
			string text = new string(reader.ReadChars(8));
			if (text != "chunkzip")
			{
				return false;
			}
			reader.ReadInt32();
			this.m_UncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			this.m_MaxBlockUncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			FifaUtil.SwapEndian(reader.ReadInt32());
			FifaUtil.SwapEndian(reader.ReadInt32());
			reader.ReadInt32();
			reader.ReadInt32();
			reader.ReadInt32();
			int num = 40;
			do
			{
				num += 8;
				int num2 = FifaUtil.RoundUp(num, 16);
				int num3 = num2 - num;
				if (num3 > 0)
				{
					reader.ReadBytes(num3);
					num += num3;
				}
				int num4 = FifaUtil.SwapEndian(reader.ReadInt32());
				reader.ReadInt32();
				num += num4;
				this.InflateBlock2(reader.BaseStream, outputStream, num4);
			}
			while (num < this.m_CompressedSize);
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x06000AD1 RID: 2769 RVA: 0x00048C78 File Offset: 0x00046E78
		private bool UnChunkzip(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			BinaryReader reader = this.GetReader();
			string text = new string(reader.ReadChars(8));
			if (text != "chunkzip")
			{
				return false;
			}
			this.m_UncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			this.m_MaxBlockUncompressedSize = FifaUtil.SwapEndian(reader.ReadInt32());
			int num = 16;
			do
			{
				int num2 = FifaUtil.SwapEndian(reader.ReadInt32());
				num += 4 + num2;
				this.InflateBlock(reader.BaseStream, outputStream, num2);
			}
			while (num < this.m_CompressedSize);
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x06000AD2 RID: 2770 RVA: 0x00048D0C File Offset: 0x00046F0C
		private bool UnEASF(Stream outputStream)
		{
			if (this.m_CompressedSize == -1)
			{
				return false;
			}
			BinaryReader reader = this.GetReader();
			string text = new string(reader.ReadChars(4));
			if (text != "EASF")
			{
				return false;
			}
			FifaUtil.SwapEndian(reader.ReadInt32());
			reader.ReadBytes(8);
			this.ReleaseReader(reader);
			return true;
		}

		// Token: 0x06000AD3 RID: 2771 RVA: 0x00048D64 File Offset: 0x00046F64
		private void Compress_10FB(Stream outputStream)
		{
			byte[] array = this.Read();
			byte[] array2 = this.Compress_10FB(array);
			this.m_CompressedSize = array2.Length;
			this.m_CurrentCompression = ECompressionMode.Compressed_10FB;
			outputStream.Write(array2, 0, array2.Length);
		}

		// Token: 0x06000AD4 RID: 2772 RVA: 0x00048D9B File Offset: 0x00046F9B
		private void Chunkzip(Stream outputStream)
		{
			this.Chunkzip(outputStream, this.m_UncompressedSize);
		}

		// Token: 0x06000AD5 RID: 2773 RVA: 0x00048DAC File Offset: 0x00046FAC
		private void Chunkzip(Stream outputStream, int uncompressedSize)
		{
			BinaryReader reader = this.GetReader();
			this.m_UncompressedSize = uncompressedSize;
			this.m_MaxBlockUncompressedSize = 184320;
			BinaryWriter binaryWriter = new BinaryWriter(outputStream);
			long position = outputStream.Position;
			binaryWriter.Write('c');
			binaryWriter.Write('h');
			binaryWriter.Write('u');
			binaryWriter.Write('n');
			binaryWriter.Write('k');
			binaryWriter.Write('z');
			binaryWriter.Write('i');
			binaryWriter.Write('p');
			binaryWriter.Write(FifaUtil.SwapEndian(this.m_UncompressedSize));
			binaryWriter.Write(FifaUtil.SwapEndian(this.m_MaxBlockUncompressedSize));
			int num = 0;
			do
			{
				int num2 = (int)outputStream.Position;
				binaryWriter.Write(-1);
				int num3 = this.m_MaxBlockUncompressedSize;
				if (this.m_UncompressedSize - num < this.m_MaxBlockUncompressedSize)
				{
					num3 = this.m_UncompressedSize - num;
				}
				num += num3;
				int num4 = this.DeflateBlock(reader.BaseStream, outputStream, num3);
				int num5 = (int)outputStream.Position;
				outputStream.Position = (long)num2;
				binaryWriter.Write(FifaUtil.SwapEndian(num4));
				outputStream.Position = (long)num5;
			}
			while (num < this.m_UncompressedSize);
			this.ReleaseReader(reader);
			this.m_CompressedSize = (int)(outputStream.Position - position);
		}

		// Token: 0x06000AD6 RID: 2774 RVA: 0x00048ED3 File Offset: 0x000470D3
		private void Chunkref2(Stream outputStream, int uncompressedSize)
		{
		}

		// Token: 0x06000AD7 RID: 2775 RVA: 0x00048ED5 File Offset: 0x000470D5
		private void Chunkref(Stream outputStream)
		{
			this.Chunkref(outputStream, this.m_UncompressedSize);
		}

		// Token: 0x06000AD8 RID: 2776 RVA: 0x00048EE4 File Offset: 0x000470E4
		private void Chunkref(Stream outputStream, int uncompressedSize)
		{
			BinaryReader reader = this.GetReader();
			BinaryWriter binaryWriter = new BinaryWriter(outputStream);
			this.m_UncompressedSize = uncompressedSize;
			this.m_MaxBlockUncompressedSize = 235520;
			long position = outputStream.Position;
			binaryWriter.Write('c');
			binaryWriter.Write('h');
			binaryWriter.Write('u');
			binaryWriter.Write('n');
			binaryWriter.Write('k');
			binaryWriter.Write('r');
			binaryWriter.Write('e');
			binaryWriter.Write('f');
			binaryWriter.Write(FifaUtil.SwapEndian(this.m_UncompressedSize));
			binaryWriter.Write(FifaUtil.SwapEndian(this.m_MaxBlockUncompressedSize));
			int num = 0;
			do
			{
				int num2 = (int)outputStream.Position;
				binaryWriter.Write(-1);
				int num3 = this.m_MaxBlockUncompressedSize;
				if (this.m_UncompressedSize - num < this.m_MaxBlockUncompressedSize)
				{
					num3 = this.m_UncompressedSize - num;
				}
				num += num3;
				byte[] array = reader.ReadBytes(num3);
				byte[] array2 = this.Compress_10FB(array);
				int num4 = array2.Length;
				outputStream.Write(array2, 0, num4);
				long position2 = outputStream.Position;
				outputStream.Position = (long)num2;
				binaryWriter.Write(FifaUtil.SwapEndian(num4));
				outputStream.Position = position2;
			}
			while (num < this.m_UncompressedSize);
			this.ReleaseReader(reader);
			this.m_CompressedSize = (int)(outputStream.Position - position);
			this.m_CurrentCompression = ECompressionMode.Chunkref;
		}

		// Token: 0x06000AD9 RID: 2777 RVA: 0x00049028 File Offset: 0x00047228
		private void InflateBlock(Stream inputStream, Stream outputStream, int blockCompressedSize)
		{
			ZOutputStream zoutputStream = new ZOutputStream(outputStream);
			FifaFile.CopyStream(inputStream, zoutputStream, blockCompressedSize);
		}

		// Token: 0x06000ADA RID: 2778 RVA: 0x00049044 File Offset: 0x00047244
		private void InflateBlock2(Stream inputStream, Stream outputStream, int blockCompressedSize)
		{
			ZOutputStream zoutputStream = new ZOutputStream(outputStream);
			FifaFile.CopyStream2(inputStream, zoutputStream, blockCompressedSize);
		}

		// Token: 0x06000ADB RID: 2779 RVA: 0x00049060 File Offset: 0x00047260
		private int DeflateBlock(Stream inputStream, Stream outputStream, int blockUncompressedSize)
		{
			ZOutputStream zoutputStream = new ZOutputStream(outputStream, -1);
			long position = outputStream.Position;
			FifaFile.CopyStream(inputStream, zoutputStream, blockUncompressedSize);
			long position2 = outputStream.Position;
			return (int)(position2 - position);
		}

		// Token: 0x06000ADC RID: 2780 RVA: 0x00049090 File Offset: 0x00047290
		private int Uncompress_10FB_Block(Stream inputStream, Stream outputStream, int blockCompressedSize)
		{
			if (blockCompressedSize == 0)
			{
				return 0;
			}
			byte[] array = new byte[blockCompressedSize];
			inputStream.Read(array, 0, blockCompressedSize);
			byte[] array2 = FifaFile.Uncompress_10FB(array);
			outputStream.Write(array2, 0, array2.Length);
			return array2.Length;
		}

		// Token: 0x06000ADD RID: 2781 RVA: 0x000490C8 File Offset: 0x000472C8
		private int Compress_10FB_Block(Stream inputStream, Stream outputStream, int blockUncompressedSize)
		{
			if (blockUncompressedSize == 0)
			{
				return 0;
			}
			byte[] array = new byte[blockUncompressedSize];
			inputStream.Read(array, 0, blockUncompressedSize);
			byte[] array2 = this.Compress_10FB(array);
			outputStream.Write(array2, 0, array2.Length);
			return array2.Length;
		}

		// Token: 0x06000ADE RID: 2782 RVA: 0x00049104 File Offset: 0x00047304
		private static byte[] Uncompress_10FB(byte[] inputBuffer)
		{
			int num = 0;
			int num2 = 0;
			int num3 = inputBuffer.Length;
			if (num3 < 8)
			{
				return null;
			}
			int num4 = ((int)inputBuffer[2] << 16) + ((int)inputBuffer[3] << 8) + (int)inputBuffer[4];
			if (num4 > num3 * 128)
			{
				return null;
			}
			byte[] array = new byte[num4];
			int num5;
			if ((inputBuffer[0] & 1) == 1)
			{
				num5 = 8;
			}
			else
			{
				num5 = 5;
			}
			int num6 = 0;
			while (num5 < num3 && inputBuffer[num5] < 252)
			{
				byte b = inputBuffer[num5++];
				int num7;
				int num8;
				if ((b & 128) == 0)
				{
					if (num5 + 1 >= num3)
					{
						num2 = 3;
						break;
					}
					num7 = (int)(b & 3);
					num8 = ((b & 28) >> 2) + 3;
					num = (b >> 5 << 8) + (int)inputBuffer[num5++] + 1;
				}
				else if ((b & 64) == 0)
				{
					if (num5 + 2 >= num3)
					{
						num2 = 4;
						break;
					}
					byte b2 = inputBuffer[num5++];
					num7 = (b2 >> 6) & 3;
					num8 = (int)((b & 63) + 4);
					num = (int)(b2 & 63) * 256 + (int)inputBuffer[num5++] + 1;
				}
				else if ((b & 32) == 0)
				{
					if (num5 + 3 >= num3)
					{
						num2 = 5;
						break;
					}
					num7 = (int)(b & 3);
					byte b3 = inputBuffer[num5++];
					num = ((int)(b & 16) << 12) + 256 * (int)b3 + (int)inputBuffer[num5++] + 1;
					num8 = ((b >> 2) & 3) * 256 + (int)inputBuffer[num5++] + 5;
				}
				else
				{
					num7 = (int)((b & 31) * 4 + 4);
					num8 = 0;
				}
				if (num5 + num7 >= num3)
				{
					num2 = 6;
					break;
				}
				if (num6 + num7 + num8 > num4)
				{
					num2 = 7;
					break;
				}
				if (num6 + num7 - num < 0)
				{
					num2 = 8;
					break;
				}
				for (int i = 0; i < num7; i++)
				{
					array[num6++] = inputBuffer[num5++];
				}
				for (int j = 0; j < num8; j++)
				{
					array[num6] = array[num6 - num];
					num6++;
				}
			}
			if (num5 < num3 && num6 < num4)
			{
				int num9 = (int)(inputBuffer[num5] & 3);
				if (num5 + num9 >= num3)
				{
					num2 = 9;
					num9 = 0;
				}
				if (num6 + num9 > num4)
				{
					num2 = 10;
					num9 = 0;
				}
				for (int k = 0; k < num9; k++)
				{
					num5++;
					array[num6] = inputBuffer[num5];
					num6++;
				}
			}
			if (num2 != 0 || num6 != num4)
			{
				return null;
			}
			return array;
		}

		// Token: 0x06000ADF RID: 2783 RVA: 0x00049350 File Offset: 0x00047550
		private byte[] Compress_10FB(byte[] inputBuffer)
		{
			int num = 0;
			int[] array = new int[131072];
			for (int i = 0; i < 131072; i++)
			{
				array[i] = -1;
			}
			int[,] array2 = new int[256, 256];
			for (int j = 0; j < 256; j++)
			{
				for (int k = 0; k < 256; k++)
				{
					array2[j, k] = -1;
				}
			}
			int num2 = inputBuffer.Length;
			byte[] array3 = new byte[num2 + 1000];
			array3[0] = 16;
			array3[1] = 251;
			array3[2] = (byte)(num2 >> 16);
			array3[3] = (byte)((num2 >> 8) & 255);
			array3[4] = (byte)(num2 & 255);
			int num3 = 5;
			int l = 0;
			int num4 = 0;
			int num9;
			while (l < num2 - 1)
			{
				byte b = inputBuffer[l];
				byte b2 = inputBuffer[l + 1];
				int num5 = array2[(int)b, (int)b2];
				array[l & 131071] = num5;
				array2[(int)b, (int)b2] = l;
				if (l >= num)
				{
					int num6 = 0;
					int num7 = 0;
					int num8 = 0;
					while (num5 >= 0 && l - num5 < 131072 && num8++ < 100)
					{
						num9 = 2;
						int num10 = num4 + 2;
						if (num10 >= num2)
						{
							break;
						}
						int num11 = num5 + 2;
						bool flag = false;
						while (inputBuffer[num10++] == inputBuffer[num11++] && num9 < 1028)
						{
							num9++;
							if (num10 == num2)
							{
								flag = true;
								break;
							}
						}
						if (num9 > num6)
						{
							num6 = num9;
							num7 = l - num5;
						}
						if (flag || num9 == 1028)
						{
							break;
						}
						num5 = array[num5 & 131071];
					}
					if (num6 > num2 - l)
					{
						num6 = l - num2;
					}
					if (num6 <= 2)
					{
						num6 = 0;
					}
					if (num6 == 3 && num7 > 1024)
					{
						num6 = 0;
					}
					if (num6 == 4 && num7 > 16384)
					{
						num6 = 0;
					}
					if (num6 != 0)
					{
						while (l - num >= 4)
						{
							num9 = (l - num) / 4 - 1;
							if (num9 > 27)
							{
								num9 = 27;
							}
							array3[num3++] = (byte)(224 + num9);
							num9 = 4 * num9 + 4;
							for (int m = 0; m < num9; m++)
							{
								array3[num3 + m] = inputBuffer[num + m];
							}
							num += num9;
							num3 += num9;
						}
						num9 = l - num;
						if (num6 <= 10 && num7 <= 1024)
						{
							array3[num3++] = (byte)((num7 - 1 >> 8 << 5) + (num6 - 3 << 2) + num9);
							array3[num3++] = (byte)((num7 - 1) & 255);
							while (num9-- != 0)
							{
								array3[num3++] = inputBuffer[num++];
							}
							num += num6;
						}
						else if (num6 <= 67 && num7 <= 16384)
						{
							array3[num3++] = (byte)(128 + (num6 - 4));
							array3[num3++] = (byte)((num9 << 6) + (num7 - 1 >> 8));
							array3[num3++] = (byte)((num7 - 1) & 255);
							while (num9-- != 0)
							{
								array3[num3++] = inputBuffer[num++];
							}
							num += num6;
						}
						else if (num6 <= 1028 && num7 < 131072)
						{
							num7--;
							array3[num3++] = (byte)(192 + (num7 >> 16 << 4) + (num6 - 5 >> 8 << 2) + num9);
							array3[num3++] = (byte)((num7 >> 8) & 255);
							array3[num3++] = (byte)(num7 & 255);
							array3[num3++] = (byte)((num6 - 5) & 255);
							while (num9-- != 0)
							{
								array3[num3++] = inputBuffer[num++];
							}
							num += num6;
						}
					}
				}
				l++;
				num4++;
			}
			l = num2;
			while (l - num >= 4)
			{
				num9 = (l - num) / 4 - 1;
				if (num9 > 27)
				{
					num9 = 27;
				}
				array3[num3++] = (byte)(224 + num9);
				num9 = 4 * num9 + 4;
				for (int n = 0; n < num9; n++)
				{
					array3[num3 + n] = inputBuffer[num + n];
				}
				num += num9;
				num3 += num9;
			}
			num9 = l - num;
			array3[num3++] = (byte)(252 + num9);
			while (num9-- != 0)
			{
				array3[num3++] = inputBuffer[num++];
			}
			if (num != num2)
			{
				return null;
			}
			byte[] array4 = new byte[num3];
			for (int num12 = 0; num12 < num3; num12++)
			{
				array4[num12] = array3[num12];
			}
			return array4;
		}

		// Token: 0x06000AE0 RID: 2784 RVA: 0x000497D4 File Offset: 0x000479D4
		private static void CopyStream(Stream inputStream, ZOutputStream outputStream, int size)
		{
			int num = 0;
			byte[] array = new byte[size + num];
			inputStream.Read(array, num, size);
			outputStream.Write(array, 0, size + num);
			outputStream.finish();
			outputStream.Flush();
		}

		// Token: 0x06000AE1 RID: 2785 RVA: 0x00049810 File Offset: 0x00047A10
		private static void CopyStream2(Stream inputStream, ZOutputStream outputStream, int size)
		{
			int num = 2;
			byte[] array = new byte[size + num];
			array[0] = 120;
			array[1] = 218;
			inputStream.Read(array, num, size);
			outputStream.Write(array, 0, size + num);
			outputStream.Flush();
		}

		// Token: 0x04000F88 RID: 3976
		private string m_Name;

		// Token: 0x04000F89 RID: 3977
		private string m_PhysicalName;

		// Token: 0x04000F8A RID: 3978
		private long m_StartPosition;

		// Token: 0x04000F8B RID: 3979
		private MemoryStream m_ReadMemoryStream;

		// Token: 0x04000F8C RID: 3980
		private MemoryStream m_WriteMemoryStream;

		// Token: 0x04000F8D RID: 3981
		private int m_CompressedSize;

		// Token: 0x04000F8E RID: 3982
		private int m_UncompressedSize;

		// Token: 0x04000F8F RID: 3983
		private int m_MaxBlockUncompressedSize;

		// Token: 0x04000F90 RID: 3984
		private ECompressionMode m_RequiredCompression;

		// Token: 0x04000F91 RID: 3985
		private ECompressionMode m_CurrentCompression;

		// Token: 0x04000F92 RID: 3986
		private bool m_IsArchived;

		// Token: 0x04000F93 RID: 3987
		private FifaBigFile m_Archive;

		// Token: 0x04000F94 RID: 3988
		private bool m_IsInMemory;

		// Token: 0x04000F95 RID: 3989
		private bool m_IsAnArchive;
	}
}
