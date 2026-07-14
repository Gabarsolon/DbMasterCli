using System;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000039 RID: 57
	public class Rx3File
	{
		// Token: 0x1700013F RID: 319
		// (get) Token: 0x0600054A RID: 1354 RVA: 0x0001E138 File Offset: 0x0001C338
		// (set) Token: 0x0600054B RID: 1355 RVA: 0x0001E140 File Offset: 0x0001C340
		public float[] Positions
		{
			get
			{
				return this.m_Positions;
			}
			set
			{
				this.m_Positions = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x0600054C RID: 1356 RVA: 0x0001E149 File Offset: 0x0001C349
		public bool SwapEndian
		{
			get
			{
				return this.m_SwapEndian;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x0600054D RID: 1357 RVA: 0x0001E151 File Offset: 0x0001C351
		public bool IsFifa12
		{
			get
			{
				return this.m_IsFifa12;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x0600054E RID: 1358 RVA: 0x0001E159 File Offset: 0x0001C359
		public bool IsFifa11
		{
			get
			{
				return !this.m_IsFifa12;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x0600054F RID: 1359 RVA: 0x0001E164 File Offset: 0x0001C364
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x06000550 RID: 1360 RVA: 0x0001E16C File Offset: 0x0001C36C
		public int HairAlfaFlag
		{
			get
			{
				return this.m_AlfaFlag;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x06000551 RID: 1361 RVA: 0x0001E174 File Offset: 0x0001C374
		// (set) Token: 0x06000552 RID: 1362 RVA: 0x0001E17C File Offset: 0x0001C37C
		public Rx3Signatures Signatures
		{
			get
			{
				return this.m_Rx3Signatures;
			}
			set
			{
				this.m_Rx3Signatures = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x06000553 RID: 1363 RVA: 0x0001E185 File Offset: 0x0001C385
		// (set) Token: 0x06000554 RID: 1364 RVA: 0x0001E18D File Offset: 0x0001C38D
		public Rx3ImageDirectory Rx3ImageDirectory
		{
			get
			{
				return this.m_Rx3ImageDirectory;
			}
			set
			{
				this.m_Rx3ImageDirectory = value;
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x06000555 RID: 1365 RVA: 0x0001E196 File Offset: 0x0001C396
		// (set) Token: 0x06000556 RID: 1366 RVA: 0x0001E19E File Offset: 0x0001C39E
		public Rx3ModelDirectory Rx3ModelDirectory
		{
			get
			{
				return this.m_Rx3ModelDirectory;
			}
			set
			{
				this.m_Rx3ModelDirectory = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x06000557 RID: 1367 RVA: 0x0001E1A7 File Offset: 0x0001C3A7
		// (set) Token: 0x06000558 RID: 1368 RVA: 0x0001E1AF File Offset: 0x0001C3AF
		public Rx3Image[] Images
		{
			get
			{
				return this.m_Rx3Images;
			}
			set
			{
				this.m_Rx3Images = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x06000559 RID: 1369 RVA: 0x0001E1B8 File Offset: 0x0001C3B8
		public Rx3IndexArray[] Rx3IndexArrays
		{
			get
			{
				return this.m_Rx3IndexArrays;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x0600055A RID: 1370 RVA: 0x0001E1C0 File Offset: 0x0001C3C0
		public Rx3VertexArray[] Rx3VertexArrays
		{
			get
			{
				return this.m_Rx3VertexArrays;
			}
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x0001E1C8 File Offset: 0x0001C3C8
		public bool Load(FifaFile fifaFile)
		{
			if (fifaFile.IsCompressed)
			{
				fifaFile.Decompress();
			}
			BinaryReader reader = fifaFile.GetReader();
			bool flag = this.Load(reader);
			fifaFile.ReleaseReader(reader);
			return flag;
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x0001E1FC File Offset: 0x0001C3FC
		public bool Load(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			bool flag = this.Load(binaryReader);
			fileStream.Close();
			binaryReader.Close();
			this.m_FileName = fileName;
			return flag;
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x0001E238 File Offset: 0x0001C438
		public bool Save(string fileName, bool saveBitmaps, bool saveVertex)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			bool flag = this.Save(binaryWriter, saveBitmaps, saveVertex);
			fileStream.Close();
			binaryWriter.Close();
			this.m_FileName = fileName;
			return flag;
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x0001E278 File Offset: 0x0001C478
		public virtual bool Load(BinaryReader r)
		{
			string text = new string(r.ReadChars(4));
			if (text == "RX3b")
			{
				this.m_IsFifa12 = true;
				this.m_SwapEndian = true;
				r.BaseStream.Position -= 4L;
			}
			else if (text == "RX3l")
			{
				this.m_IsFifa12 = true;
				this.m_SwapEndian = false;
				r.BaseStream.Position -= 4L;
			}
			else
			{
				this.m_IsFifa12 = false;
				this.m_SwapEndian = true;
				r.BaseStream.Position = 68L;
				this.m_Rx3bPosition = FifaUtil.SwapEndian(r.ReadInt32());
				r.BaseStream.Position = (long)this.m_Rx3bPosition;
			}
			this.m_Rx3Header = new Rx3Header(r, this.m_SwapEndian);
			if (this.m_Rx3Header.NFiles == 0)
			{
				return false;
			}
			this.m_Rx3FileDescriptors = new Rx3FileDescriptor[this.m_Rx3Header.NFiles];
			for (int i = 0; i < this.m_Rx3Header.NFiles; i++)
			{
				this.m_Rx3FileDescriptors[i] = new Rx3FileDescriptor(r, this.m_SwapEndian);
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			for (int j = 0; j < this.m_Rx3Header.NFiles; j++)
			{
				r.BaseStream.Position = (long)this.m_Rx3FileDescriptors[j].Offset;
				uint signature = this.m_Rx3FileDescriptors[j].Signature;
				if (signature <= 1285267122U)
				{
					if (signature <= 230948820U)
					{
						if (signature <= 5798561U)
						{
							if (signature != 5798132U)
							{
								if (signature != 5798561U)
								{
									return false;
								}
								this.m_Rx3VertexArrays[num3++] = new Rx3VertexArray(r, this.m_SwapEndian);
							}
							else
							{
								this.m_Rx3IndexArrays[num2++] = new Rx3IndexArray(r, this.m_SwapEndian);
							}
						}
						else if (signature != 123459928U && signature != 230948820U)
						{
							return false;
						}
					}
					else if (signature <= 582139446U)
					{
						if (signature != 255353250U)
						{
							if (signature != 582139446U)
							{
								return false;
							}
							this.m_Rx3ModelDirectory = new Rx3ModelDirectory(r, this.m_SwapEndian);
							this.m_Rx3IndexArrays = new Rx3IndexArray[this.m_Rx3ModelDirectory.NFiles];
							this.m_Rx3VertexArrays = new Rx3VertexArray[this.m_Rx3ModelDirectory.NFiles];
						}
					}
					else if (signature != 685399266U)
					{
						if (signature != 1285267122U)
						{
							return false;
						}
						r.ReadBytes(20);
						this.m_AlfaFlag = (int)r.ReadByte();
					}
				}
				else if (signature <= 3263271920U)
				{
					if (signature <= 2047566042U)
					{
						if (signature != 1808827868U)
						{
							if (signature != 2047566042U)
							{
								return false;
							}
							this.m_Rx3Images[num] = new Rx3Image(r, this.m_SwapEndian);
							num++;
						}
						else
						{
							this.m_Rx3ImageDirectory = new Rx3ImageDirectory(r, this.m_SwapEndian);
							this.m_Rx3Images = new Rx3Image[this.m_Rx3ImageDirectory.NFiles];
						}
					}
					else if (signature != 2116321516U && signature != 3263271920U)
					{
						return false;
					}
				}
				else if (signature <= 3751472158U)
				{
					if (signature != 3566041216U && signature != 3751472158U)
					{
						return false;
					}
				}
				else if (signature != 4116388378U)
				{
					if (signature != 4185470741U)
					{
						return false;
					}
				}
				else
				{
					this.LoadPositions(r);
				}
			}
			return true;
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x0001E5F0 File Offset: 0x0001C7F0
		private void LoadPositions(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				r.ReadBytes(29);
				this.m_Positions[0] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[1] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[2] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[3] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(11);
				this.m_Positions[4] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[5] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[6] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[7] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(12);
				this.m_Positions[8] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[9] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[10] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[11] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(5);
				this.m_Positions[12] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[13] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[14] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[15] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(15);
				this.m_Positions[16] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[17] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[18] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[19] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(16);
				this.m_Positions[20] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[21] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[22] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[23] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(13);
				this.m_Positions[24] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[25] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[26] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[27] = FifaUtil.SwapAndConvertToFloat(r);
				r.ReadBytes(7);
				this.m_Positions[28] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[29] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[30] = FifaUtil.SwapAndConvertToFloat(r);
				this.m_Positions[31] = FifaUtil.SwapAndConvertToFloat(r);
				return;
			}
			r.ReadBytes(29);
			this.m_Positions[0] = r.ReadSingle();
			this.m_Positions[1] = r.ReadSingle();
			this.m_Positions[2] = r.ReadSingle();
			this.m_Positions[3] = r.ReadSingle();
			r.ReadBytes(11);
			this.m_Positions[4] = r.ReadSingle();
			this.m_Positions[5] = r.ReadSingle();
			this.m_Positions[6] = r.ReadSingle();
			this.m_Positions[7] = r.ReadSingle();
			r.ReadBytes(12);
			this.m_Positions[8] = r.ReadSingle();
			this.m_Positions[9] = r.ReadSingle();
			this.m_Positions[10] = r.ReadSingle();
			this.m_Positions[11] = r.ReadSingle();
			r.ReadBytes(5);
			this.m_Positions[12] = r.ReadSingle();
			this.m_Positions[13] = r.ReadSingle();
			this.m_Positions[14] = r.ReadSingle();
			this.m_Positions[15] = r.ReadSingle();
			r.ReadBytes(15);
			this.m_Positions[16] = r.ReadSingle();
			this.m_Positions[17] = r.ReadSingle();
			this.m_Positions[18] = r.ReadSingle();
			this.m_Positions[19] = r.ReadSingle();
			r.ReadBytes(16);
			this.m_Positions[20] = r.ReadSingle();
			this.m_Positions[21] = r.ReadSingle();
			this.m_Positions[22] = r.ReadSingle();
			this.m_Positions[23] = r.ReadSingle();
			r.ReadBytes(13);
			this.m_Positions[24] = r.ReadSingle();
			this.m_Positions[25] = r.ReadSingle();
			this.m_Positions[26] = r.ReadSingle();
			this.m_Positions[27] = r.ReadSingle();
			r.ReadBytes(7);
			this.m_Positions[28] = r.ReadSingle();
			this.m_Positions[29] = r.ReadSingle();
			this.m_Positions[30] = r.ReadSingle();
			this.m_Positions[31] = r.ReadSingle();
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x0001EA44 File Offset: 0x0001CC44
		private void SavePositions(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Seek(29, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[0]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[1]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[2]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[3]);
				w.Seek(11, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[4]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[5]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[6]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[7]);
				w.Seek(12, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[8]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[9]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[10]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[11]);
				w.Seek(5, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[12]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[13]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[14]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[15]);
				w.Seek(15, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[16]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[17]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[18]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[19]);
				w.Seek(16, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[20]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[21]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[22]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[23]);
				w.Seek(13, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[24]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[25]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[26]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[27]);
				w.Seek(7, SeekOrigin.Current);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[28]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[29]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[30]);
				FifaUtil.SwapAndWriteFloat(w, this.m_Positions[31]);
				return;
			}
			w.Seek(29, SeekOrigin.Current);
			w.Write(this.m_Positions[0]);
			w.Write(this.m_Positions[1]);
			w.Write(this.m_Positions[2]);
			w.Write(this.m_Positions[3]);
			w.Seek(11, SeekOrigin.Current);
			w.Write(this.m_Positions[4]);
			w.Write(this.m_Positions[5]);
			w.Write(this.m_Positions[6]);
			w.Write(this.m_Positions[7]);
			w.Seek(12, SeekOrigin.Current);
			w.Write(this.m_Positions[8]);
			w.Write(this.m_Positions[9]);
			w.Write(this.m_Positions[10]);
			w.Write(this.m_Positions[11]);
			w.Seek(5, SeekOrigin.Current);
			w.Write(this.m_Positions[12]);
			w.Write(this.m_Positions[13]);
			w.Write(this.m_Positions[14]);
			w.Write(this.m_Positions[15]);
			w.Seek(15, SeekOrigin.Current);
			w.Write(this.m_Positions[16]);
			w.Write(this.m_Positions[17]);
			w.Write(this.m_Positions[18]);
			w.Write(this.m_Positions[19]);
			w.Seek(16, SeekOrigin.Current);
			w.Write(this.m_Positions[20]);
			w.Write(this.m_Positions[21]);
			w.Write(this.m_Positions[22]);
			w.Write(this.m_Positions[23]);
			w.Seek(13, SeekOrigin.Current);
			w.Write(this.m_Positions[24]);
			w.Write(this.m_Positions[25]);
			w.Write(this.m_Positions[26]);
			w.Write(this.m_Positions[27]);
			w.Seek(7, SeekOrigin.Current);
			w.Write(this.m_Positions[28]);
			w.Write(this.m_Positions[29]);
			w.Write(this.m_Positions[30]);
			w.Write(this.m_Positions[31]);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x0001EEA8 File Offset: 0x0001D0A8
		public virtual bool Save(BinaryWriter w, bool saveBitmaps, bool saveVertex)
		{
			if (this.m_Rx3Signatures != null)
			{
				this.m_Rx3Signatures.Save(w);
			}
			w.BaseStream.Position = (long)this.m_Rx3bPosition;
			this.m_Rx3Header.Save(w);
			for (int i = 0; i < this.m_Rx3Header.NFiles; i++)
			{
				this.m_Rx3FileDescriptors[i].Save(w);
			}
			int num = 0;
			int num2 = 0;
			for (int j = 0; j < this.m_Rx3Header.NFiles; j++)
			{
				w.BaseStream.Position = (long)this.m_Rx3FileDescriptors[j].Offset;
				uint signature = this.m_Rx3FileDescriptors[j].Signature;
				if (signature <= 255353250U)
				{
					if (signature != 5798132U)
					{
						if (signature != 5798561U)
						{
							if (signature != 255353250U)
							{
							}
						}
						else if (saveVertex)
						{
							this.m_Rx3VertexArrays[num2++].Save(w);
						}
					}
				}
				else if (signature <= 1808827868U)
				{
					if (signature != 582139446U && signature != 1808827868U)
					{
					}
				}
				else if (signature != 2047566042U)
				{
					if (signature == 4116388378U)
					{
						this.SavePositions(w);
					}
				}
				else if (saveBitmaps)
				{
					this.m_Rx3Images[num].Save(w);
					num++;
				}
			}
			return true;
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x0001EFE8 File Offset: 0x0001D1E8
		public Bitmap[] GetBitmaps()
		{
			Bitmap[] array = new Bitmap[this.m_Rx3Images.Length];
			for (int i = 0; i < this.m_Rx3Images.Length; i++)
			{
				array[i] = this.m_Rx3Images[i].GetBitmap();
			}
			return array;
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x0001F028 File Offset: 0x0001D228
		public bool ReplaceBitmaps(Bitmap[] bitmaps)
		{
			bool flag = true;
			for (int i = 0; i < this.m_Rx3Images.Length; i++)
			{
				bool flag2 = this.m_Rx3Images[i].SetBitmap(bitmaps[i]);
				flag = flag && flag2;
			}
			return flag;
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x0001F064 File Offset: 0x0001D264
		public bool CreateXFiles(string baseFileName)
		{
			if (this.m_Rx3IndexArrays.Length == 0)
			{
				return false;
			}
			for (int i = 0; i < this.m_Rx3IndexArrays.Length; i++)
			{
				Model3D model3D = new Model3D();
				model3D.Initialize(this.m_Rx3IndexArrays[i], this.m_Rx3VertexArrays[i]);
				string text = baseFileName + i.ToString() + ".X";
				Application.CurrentCulture = new CultureInfo("en-us");
				FileStream fileStream = new FileStream(text, FileMode.Create, FileAccess.Write);
				StreamWriter streamWriter = new StreamWriter(fileStream);
				streamWriter.WriteLine("xof 0303txt 0032");
				model3D.SaveXFile(streamWriter);
				streamWriter.Close();
				fileStream.Close();
			}
			return true;
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x0001F101 File Offset: 0x0001D301
		public bool ConvertKitFrom11(Rx3File sourceRx3File)
		{
			return !this.IsFifa11 && !sourceRx3File.IsFifa12;
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0001F118 File Offset: 0x0001D318
		public bool ConvertKitFrom12(Rx3File sourceRx3File)
		{
			return !this.IsFifa12 && !sourceRx3File.IsFifa11;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x0001F12F File Offset: 0x0001D32F
		public bool ConvertKit(Rx3File sourceRx3File)
		{
			if (this.IsFifa12)
			{
				return this.ConvertKitFrom11(sourceRx3File);
			}
			return this.ConvertKitFrom12(sourceRx3File);
		}

		// Token: 0x04000230 RID: 560
		private float[] m_Positions = new float[32];

		// Token: 0x04000231 RID: 561
		private int m_Rx3bPosition;

		// Token: 0x04000232 RID: 562
		private Rx3Header m_Rx3Header;

		// Token: 0x04000233 RID: 563
		private bool m_SwapEndian;

		// Token: 0x04000234 RID: 564
		private bool m_IsFifa12;

		// Token: 0x04000235 RID: 565
		private string m_FileName;

		// Token: 0x04000236 RID: 566
		private int m_AlfaFlag;

		// Token: 0x04000237 RID: 567
		private Rx3FileDescriptor[] m_Rx3FileDescriptors;

		// Token: 0x04000238 RID: 568
		private Rx3Signatures m_Rx3Signatures;

		// Token: 0x04000239 RID: 569
		private Rx3ImageDirectory m_Rx3ImageDirectory;

		// Token: 0x0400023A RID: 570
		private Rx3ModelDirectory m_Rx3ModelDirectory;

		// Token: 0x0400023B RID: 571
		private Rx3Image[] m_Rx3Images;

		// Token: 0x0400023C RID: 572
		private Rx3IndexArray[] m_Rx3IndexArrays;

		// Token: 0x0400023D RID: 573
		private Rx3VertexArray[] m_Rx3VertexArrays;
	}
}
