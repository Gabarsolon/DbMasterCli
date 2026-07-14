using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000096 RID: 150
	public class Rx3Image
	{
		// Token: 0x1700024D RID: 589
		// (get) Token: 0x06000B3E RID: 2878 RVA: 0x0004B142 File Offset: 0x00049342
		// (set) Token: 0x06000B3F RID: 2879 RVA: 0x0004B14A File Offset: 0x0004934A
		public Rx3ImageHeader Header
		{
			get
			{
				return this.m_Header;
			}
			set
			{
				this.m_Header = value;
			}
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x0004B153 File Offset: 0x00049353
		public Bitmap GetBitmap()
		{
			return this.m_MipMapImage[0].Bitmap;
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x0004B162 File Offset: 0x00049362
		public Bitmap GetBitmap(int mipMapLevel)
		{
			if (mipMapLevel >= this.m_MipMapImage.Length)
			{
				return null;
			}
			return this.m_MipMapImage[mipMapLevel].Bitmap;
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x0004B180 File Offset: 0x00049380
		public bool SetBitmap(Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			if (bitmap.Width != (int)this.m_Header.Width || bitmap.Width != (int)this.m_Header.Width)
			{
				return false;
			}
			Bitmap bitmap2 = bitmap;
			this.m_MipMapImage[0].Bitmap = bitmap2;
			for (int i = 1; i < (int)this.m_Header.NMipMaps; i++)
			{
				bitmap2 = GraphicUtil.ReduceBitmap(bitmap2);
				this.m_MipMapImage[i].Bitmap = bitmap2;
			}
			return true;
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x0004B1F6 File Offset: 0x000493F6
		public Rx3Image(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.m_Header = new Rx3ImageHeader(r, this.m_SwapEndian);
			this.Load(r);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x0004B220 File Offset: 0x00049420
		public bool Load(BinaryReader r)
		{
			this.m_MipMapImage = new MipMap[(int)this.m_Header.NMipMaps];
			int num = (int)this.m_Header.Width;
			int num2 = (int)this.m_Header.Height;
			for (int i = 0; i < (int)this.m_Header.NMipMaps; i++)
			{
				this.m_MipMapImage[i] = new MipMap(num, num2, this.m_Header.ImageType, this.m_SwapEndian);
				this.m_MipMapImage[i].Load(r);
				num /= 2;
				num2 /= 2;
			}
			return true;
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x0004B2AC File Offset: 0x000494AC
		public bool Save(BinaryWriter w)
		{
			this.m_Header.Save(w);
			for (int i = 0; i < (int)this.m_Header.NMipMaps; i++)
			{
				this.m_MipMapImage[i].Save(w);
			}
			return true;
		}

		// Token: 0x04000FC7 RID: 4039
		private Rx3ImageHeader m_Header;

		// Token: 0x04000FC8 RID: 4040
		private MipMap[] m_MipMapImage;

		// Token: 0x04000FC9 RID: 4041
		private bool m_SwapEndian;
	}
}
