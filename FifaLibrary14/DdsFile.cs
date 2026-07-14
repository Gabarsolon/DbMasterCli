using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000075 RID: 117
	public class DdsFile
	{
		// Token: 0x060009C3 RID: 2499 RVA: 0x00045468 File Offset: 0x00043668
		public DdsFile()
		{
		}

		// Token: 0x060009C4 RID: 2500 RVA: 0x00045470 File Offset: 0x00043670
		public DdsFile(string fileName)
		{
			this.Load(fileName);
		}

		// Token: 0x060009C5 RID: 2501 RVA: 0x00045480 File Offset: 0x00043680
		public DdsFile(FifaFile fifaFile)
		{
			this.Load(fifaFile);
		}

		// Token: 0x060009C6 RID: 2502 RVA: 0x00045490 File Offset: 0x00043690
		public DdsFile(BinaryReader r)
		{
			this.Load(r);
		}

		// Token: 0x060009C7 RID: 2503 RVA: 0x000454A0 File Offset: 0x000436A0
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

		// Token: 0x060009C8 RID: 2504 RVA: 0x000454D4 File Offset: 0x000436D4
		public bool Load(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryReader binaryReader = new BinaryReader(fileStream);
			bool flag = this.Load(binaryReader);
			fileStream.Close();
			binaryReader.Close();
			return flag;
		}

		// Token: 0x060009C9 RID: 2505 RVA: 0x00045508 File Offset: 0x00043708
		public bool Load(BinaryReader r)
		{
			this.m_Signature = new string(r.ReadChars(4));
			if (this.m_Signature != "DDS ")
			{
				return false;
			}
			this.m_HeaderSize = r.ReadUInt32();
			this.m_HeaderFlags = r.ReadUInt32();
			this.m_Height = r.ReadInt32();
			this.m_Width = r.ReadInt32();
			this.m_PitchOrLinearSize = r.ReadInt32();
			this.m_Depth = r.ReadInt32();
			this.m_MipMapCount = r.ReadInt32();
			for (int i = 0; i < 11; i++)
			{
				r.ReadInt32();
			}
			this.m_PixelFormatSize = r.ReadInt32();
			this.m_PixelFormatFlag = r.ReadInt32();
			this.m_FourCC = r.ReadInt32();
			int fourCC = this.m_FourCC;
			if (fourCC <= 827611204)
			{
				if (fourCC != 0)
				{
					if (fourCC == 827611204)
					{
						this.m_ImageType = EImageType.DXT1;
					}
				}
				else
				{
					this.m_ImageType = EImageType.A8R8G8B8;
				}
			}
			else if (fourCC != 861165636)
			{
				if (fourCC == 894720068)
				{
					this.m_ImageType = EImageType.DXT5;
				}
			}
			else
			{
				this.m_ImageType = EImageType.DXT3;
			}
			this.m_RGBBitCount = r.ReadInt32();
			this.m_RBitMask = r.ReadInt32();
			this.m_GBitMask = r.ReadInt32();
			this.m_BBitMask = r.ReadInt32();
			this.m_ABitMask = r.ReadInt32();
			this.m_SurfaceFlags = r.ReadInt32();
			this.m_CubemapFlags = r.ReadInt32();
			for (int j = 0; j < 3; j++)
			{
				r.ReadInt32();
			}
			if (this.m_MipMapCount > 0)
			{
				int num = this.m_Width / 4 * this.m_Height / 4 * 16;
				int num2 = this.m_Width;
				int num3 = this.m_Height;
				this.m_RawImages = new RawImage[this.m_MipMapCount + 1];
				for (int k = 0; k <= this.m_MipMapCount; k++)
				{
					this.m_RawImages[k] = new RawImage(num2, num3, this.m_ImageType, num);
					this.m_RawImages[k].Load(r);
					num /= 4;
					num2 /= 2;
					num3 /= 2;
				}
			}
			else
			{
				int num4 = (int)(r.BaseStream.Length - r.BaseStream.Position);
				this.m_RawImages = new RawImage[1];
				this.m_RawImages[0] = new RawImage(this.m_Width, this.m_Height, this.m_ImageType, num4);
				this.m_RawImages[0].Load(r);
			}
			return true;
		}

		// Token: 0x060009CA RID: 2506 RVA: 0x0004576C File Offset: 0x0004396C
		public bool Save(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.ReadWrite);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			bool flag = this.Save(binaryWriter);
			fileStream.Close();
			binaryWriter.Close();
			return flag;
		}

		// Token: 0x060009CB RID: 2507 RVA: 0x000457A0 File Offset: 0x000439A0
		public bool Save(BinaryWriter w)
		{
			w.Write('D');
			w.Write('D');
			w.Write('S');
			w.Write(' ');
			w.Write(this.m_HeaderSize);
			w.Write(this.m_HeaderFlags);
			w.Write(this.m_Height);
			w.Write(this.m_Width);
			w.Write(this.m_PitchOrLinearSize);
			w.Write(this.m_Depth);
			w.Write(this.m_MipMapCount);
			for (int i = 0; i < 11; i++)
			{
				w.Write(0);
			}
			w.Write(this.m_PixelFormatSize);
			w.Write(this.m_PixelFormatFlag);
			w.Write(this.m_FourCC);
			w.Write(this.m_RGBBitCount);
			w.Write(this.m_RBitMask);
			w.Write(this.m_GBitMask);
			w.Write(this.m_BBitMask);
			w.Write(this.m_ABitMask);
			w.Write(this.m_SurfaceFlags);
			w.Write(this.m_CubemapFlags);
			for (int j = 0; j < 3; j++)
			{
				w.Write(0);
			}
			if (this.m_MipMapCount > 0)
			{
				for (int k = 0; k < this.m_MipMapCount + 1; k++)
				{
					this.m_RawImages[k].Save(w);
				}
			}
			else
			{
				this.m_RawImages[0].Save(w);
			}
			return true;
		}

		// Token: 0x060009CC RID: 2508 RVA: 0x000458FD File Offset: 0x00043AFD
		public Bitmap GetBitmap()
		{
			return this.m_RawImages[0].Bitmap;
		}

		// Token: 0x060009CD RID: 2509 RVA: 0x0004590C File Offset: 0x00043B0C
		public void ReplaceBitmap(Bitmap bitmap)
		{
			if (this.m_MipMapCount > 0)
			{
				Bitmap bitmap2 = bitmap;
				this.m_RawImages[0].Bitmap = bitmap;
				for (int i = 1; i < this.m_MipMapCount + 1; i++)
				{
					bitmap2 = GraphicUtil.ReduceBitmap(bitmap2);
					this.m_RawImages[i].Bitmap = bitmap2;
				}
				return;
			}
			this.m_RawImages[0].Bitmap = bitmap;
		}

		// Token: 0x04000F3F RID: 3903
		private string m_Signature;

		// Token: 0x04000F40 RID: 3904
		private uint m_HeaderSize;

		// Token: 0x04000F41 RID: 3905
		private uint m_HeaderFlags;

		// Token: 0x04000F42 RID: 3906
		private int m_Width;

		// Token: 0x04000F43 RID: 3907
		private int m_Height;

		// Token: 0x04000F44 RID: 3908
		private int m_PitchOrLinearSize;

		// Token: 0x04000F45 RID: 3909
		private int m_Depth;

		// Token: 0x04000F46 RID: 3910
		private int m_MipMapCount;

		// Token: 0x04000F47 RID: 3911
		private int m_PixelFormatSize;

		// Token: 0x04000F48 RID: 3912
		private int m_PixelFormatFlag;

		// Token: 0x04000F49 RID: 3913
		private int m_FourCC;

		// Token: 0x04000F4A RID: 3914
		private EImageType m_ImageType;

		// Token: 0x04000F4B RID: 3915
		private int m_RGBBitCount;

		// Token: 0x04000F4C RID: 3916
		private int m_RBitMask;

		// Token: 0x04000F4D RID: 3917
		private int m_GBitMask;

		// Token: 0x04000F4E RID: 3918
		private int m_BBitMask;

		// Token: 0x04000F4F RID: 3919
		private int m_ABitMask;

		// Token: 0x04000F50 RID: 3920
		private int m_SurfaceFlags;

		// Token: 0x04000F51 RID: 3921
		private int m_CubemapFlags;

		// Token: 0x04000F52 RID: 3922
		private RawImage[] m_RawImages;
	}
}
