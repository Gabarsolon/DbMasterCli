using System;

namespace FifaLibrary
{
	// Token: 0x02000011 RID: 17
	public class Vector3x1
	{
		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600012A RID: 298 RVA: 0x0000B192 File Offset: 0x00009392
		// (set) Token: 0x06000129 RID: 297 RVA: 0x0000B189 File Offset: 0x00009389
		public float X
		{
			get
			{
				return this.x;
			}
			set
			{
				this.x = value;
			}
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000B1A3 File Offset: 0x000093A3
		// (set) Token: 0x0600012B RID: 299 RVA: 0x0000B19A File Offset: 0x0000939A
		public float Y
		{
			get
			{
				return this.y;
			}
			set
			{
				this.y = value;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600012E RID: 302 RVA: 0x0000B1B4 File Offset: 0x000093B4
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000B1AB File Offset: 0x000093AB
		public float Z
		{
			get
			{
				return this.z;
			}
			set
			{
				this.z = value;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000B1BC File Offset: 0x000093BC
		public Vector3x1(float c0, float c1, float c2)
		{
			this.x = c0;
			this.y = c1;
			this.z = c2;
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000B1D9 File Offset: 0x000093D9
		public Vector3x1(int c0, int c1, int c2)
		{
			this.x = (float)c0;
			this.y = (float)c1;
			this.z = (float)c2;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000B1F9 File Offset: 0x000093F9
		public Vector3x1()
		{
			this.x = 0f;
			this.y = 0f;
			this.z = 0f;
		}

		// Token: 0x040000AD RID: 173
		private float x;

		// Token: 0x040000AE RID: 174
		private float y;

		// Token: 0x040000AF RID: 175
		private float z;
	}
}
