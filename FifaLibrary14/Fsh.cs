using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000005 RID: 5
	public class Fsh
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600002C RID: 44 RVA: 0x000039A2 File Offset: 0x00001BA2
		// (set) Token: 0x0600002D RID: 45 RVA: 0x000039AA File Offset: 0x00001BAA
		public string FileName
		{
			get
			{
				return this.m_FileName;
			}
			set
			{
				this.m_FileName = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000039B3 File Offset: 0x00001BB3
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000039BB File Offset: 0x00001BBB
		public int FileSize
		{
			get
			{
				return this.m_FileSize;
			}
			set
			{
				this.m_FileSize = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000039C4 File Offset: 0x00001BC4
		// (set) Token: 0x06000031 RID: 49 RVA: 0x000039CC File Offset: 0x00001BCC
		public ImageDir[] ImageDir
		{
			get
			{
				return this.m_ImageDir;
			}
			set
			{
				this.m_ImageDir = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000032 RID: 50 RVA: 0x000039D5 File Offset: 0x00001BD5
		// (set) Token: 0x06000033 RID: 51 RVA: 0x000039DD File Offset: 0x00001BDD
		public FshImage[] FshImages
		{
			get
			{
				return this.m_FshImages;
			}
			set
			{
				this.m_FshImages = value;
			}
		}

		// Token: 0x06000034 RID: 52 RVA: 0x000039E6 File Offset: 0x00001BE6
		public Fsh(BinaryReader r)
		{
			this.Load(r);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x000039F8 File Offset: 0x00001BF8
		public Fsh(string filePath)
		{
			this.m_FileName = filePath;
			FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
			if (fileStream == null)
			{
				return;
			}
			BinaryReader binaryReader = new BinaryReader(fileStream);
			if (binaryReader == null)
			{
				return;
			}
			this.Load(binaryReader);
			binaryReader.Close();
			fileStream.Close();
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00003A40 File Offset: 0x00001C40
		public bool Load(BinaryReader r)
		{
			int num = (int)r.BaseStream.Length;
			if (num < 4)
			{
				return false;
			}
			this.m_Signature = new string(r.ReadChars(4));
			if (this.m_Signature != "SHPI")
			{
				return false;
			}
			this.m_FileSize = r.ReadInt32();
			this.m_NImages = r.ReadInt32();
			this.m_DirId = new string(r.ReadChars(4));
			this.m_ImageDir = new ImageDir[this.m_NImages];
			for (int i = 0; i < this.m_NImages; i++)
			{
				this.m_ImageDir[i] = new ImageDir(r);
			}
			int num2 = this.m_FileSize;
			for (int j = 0; j < this.m_NImages; j++)
			{
				if (this.m_ImageDir[j].Offset < num2)
				{
					num2 = this.m_ImageDir[j].Offset;
				}
			}
			int num3 = num2 - (16 + 8 * this.m_NImages);
			if (num3 > 0)
			{
				this.m_DirPad = r.ReadBytes(num3);
			}
			this.m_FshImages = new FshImage[this.m_NImages];
			for (int k = 0; k < this.m_NImages; k++)
			{
				int num4 = ((k + 1 < this.m_NImages) ? (this.m_ImageDir[k + 1].Offset - this.m_ImageDir[k].Offset) : (this.m_FileSize - this.m_ImageDir[k].Offset));
				this.m_FshImages[k] = new FshImage(this, r, num4);
			}
			return true;
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00003BB8 File Offset: 0x00001DB8
		public bool Save(BinaryWriter w)
		{
			w.Write('S');
			w.Write('H');
			w.Write('P');
			w.Write('I');
			w.Write(this.m_FileSize);
			w.Write(this.m_NImages);
			char[] array = this.m_DirId.ToCharArray();
			w.Write((byte)array[0]);
			w.Write((byte)array[1]);
			w.Write((byte)array[2]);
			w.Write((byte)array[3]);
			for (int i = 0; i < this.m_NImages; i++)
			{
				this.m_ImageDir[i].Save(w);
			}
			if (this.m_DirPad != null)
			{
				w.Write(this.m_DirPad);
			}
			for (int j = 0; j < this.m_NImages; j++)
			{
				this.m_FshImages[j].Save(w);
			}
			return true;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00003C84 File Offset: 0x00001E84
		public bool Save()
		{
			return this.Save(this.m_FileName);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00003C94 File Offset: 0x00001E94
		public bool Save(string fileName)
		{
			if (fileName == null)
			{
				return false;
			}
			FileStream fileStream = new FileStream(fileName, FileMode.Create);
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			bool flag = this.Save(binaryWriter);
			binaryWriter.Close();
			fileStream.Close();
			return flag;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00003CCC File Offset: 0x00001ECC
		public void Hash(string fileName)
		{
			for (int i = 0; i < this.m_NImages; i++)
			{
				this.m_FshImages[i].Hash(fileName);
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00003CF8 File Offset: 0x00001EF8
		public void ComputeImageDir()
		{
			int num = this.m_ImageDir[0].Offset;
			for (int i = 0; i < this.m_NImages; i++)
			{
				this.m_ImageDir[i].Offset = num;
				num += this.m_FshImages[i].ComputeLength();
			}
			this.m_FileSize = num;
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00003D4C File Offset: 0x00001F4C
		public void ReplaceBitmaps(Bitmap[] bitmaps)
		{
			int num = ((bitmaps.Length <= this.m_NImages) ? bitmaps.Length : this.m_NImages);
			for (int i = 0; i < num; i++)
			{
				this.m_FshImages[i].ReplaceBitmap(bitmaps[i]);
			}
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00003D8D File Offset: 0x00001F8D
		public bool ReplaceBitmap(Bitmap bitmap, int index)
		{
			return index < this.m_NImages && this.m_FshImages[index].ReplaceBitmap(bitmap);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003DA8 File Offset: 0x00001FA8
		public Bitmap GetBitmap(int index)
		{
			if (index < this.m_NImages)
			{
				return this.m_FshImages[index].Bitmap;
			}
			return null;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00003DC4 File Offset: 0x00001FC4
		public Bitmap[] GetBitmaps()
		{
			Bitmap[] array = new Bitmap[this.m_NImages];
			for (int i = 0; i < this.m_NImages; i++)
			{
				array[i] = this.m_FshImages[i].Bitmap;
			}
			return array;
		}

		// Token: 0x0400001C RID: 28
		private string m_FileName;

		// Token: 0x0400001D RID: 29
		private string m_DirId;

		// Token: 0x0400001E RID: 30
		private string m_Signature;

		// Token: 0x0400001F RID: 31
		private int m_FileSize;

		// Token: 0x04000020 RID: 32
		private int m_NImages;

		// Token: 0x04000021 RID: 33
		private ImageDir[] m_ImageDir;

		// Token: 0x04000022 RID: 34
		private byte[] m_DirPad;

		// Token: 0x04000023 RID: 35
		private FshImage[] m_FshImages;
	}
}
