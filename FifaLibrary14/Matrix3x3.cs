using System;

namespace FifaLibrary
{
	// Token: 0x02000010 RID: 16
	public class Matrix3x3
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x06000122 RID: 290 RVA: 0x0000AD92 File Offset: 0x00008F92
		public float Determinant
		{
			get
			{
				return this.m_Determinant;
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000AD9C File Offset: 0x00008F9C
		public Matrix3x3(float c00, float c01, float c02, float c10, float c11, float c12, float c20, float c21, float c22)
		{
			this.a = c00;
			this.b = c01;
			this.c = c02;
			this.d = c10;
			this.e = c11;
			this.f = c12;
			this.g = c20;
			this.h = c21;
			this.i = c22;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000ADF4 File Offset: 0x00008FF4
		public Matrix3x3(int c00, int c01, int c02, int c10, int c11, int c12, int c20, int c21, int c22)
		{
			this.a = (float)c00;
			this.b = (float)c01;
			this.c = (float)c02;
			this.d = (float)c10;
			this.e = (float)c11;
			this.f = (float)c12;
			this.g = (float)c20;
			this.h = (float)c21;
			this.i = (float)c22;
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000AE58 File Offset: 0x00009058
		public float ComputeDeterminant()
		{
			this.m_Determinant = this.a * (this.e * this.i - this.f * this.h) - this.b * (this.i * this.d - this.f * this.g) + this.c * (this.d * this.h - this.e * this.g);
			return this.m_Determinant;
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000AEDC File Offset: 0x000090DC
		public Matrix3x3 Invert()
		{
			this.ComputeDeterminant();
			if (this.m_Determinant != 0f)
			{
				float num = (this.e * this.i - this.f * this.h) / this.m_Determinant;
				float num2 = (this.f * this.g - this.d * this.i) / this.m_Determinant;
				float num3 = (this.d * this.h - this.e * this.g) / this.m_Determinant;
				float num4 = (this.c * this.h - this.b * this.i) / this.m_Determinant;
				float num5 = (this.a * this.i - this.c * this.g) / this.m_Determinant;
				float num6 = (this.b * this.g - this.a * this.h) / this.m_Determinant;
				float num7 = (this.b * this.f - this.c * this.e) / this.m_Determinant;
				float num8 = (this.c * this.d - this.a * this.f) / this.m_Determinant;
				float num9 = (this.a * this.e - this.b * this.d) / this.m_Determinant;
				return new Matrix3x3(num, num2, num3, num4, num5, num6, num7, num8, num9);
			}
			return null;
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000B05C File Offset: 0x0000925C
		public Vector3x1 PostMultiply(Vector3x1 v)
		{
			float num = this.a * v.X + this.b * v.Y + this.c * v.Z;
			float num2 = this.d * v.X + this.e * v.Y + this.f * v.Z;
			float num3 = this.g * v.X + this.h * v.Y + this.i * v.Z;
			return new Vector3x1(num, num2, num3);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000B0F4 File Offset: 0x000092F4
		public Vector3x1 PreMultiply(Vector3x1 v)
		{
			float num = this.a * v.X + this.d * v.Y + this.g * v.Z;
			float num2 = this.b * v.X + this.e * v.Y + this.h * v.Z;
			float num3 = this.c * v.X + this.f * v.Y + this.i * v.Z;
			return new Vector3x1(num, num2, num3);
		}

		// Token: 0x040000A3 RID: 163
		private float a;

		// Token: 0x040000A4 RID: 164
		private float b;

		// Token: 0x040000A5 RID: 165
		private float c;

		// Token: 0x040000A6 RID: 166
		private float d;

		// Token: 0x040000A7 RID: 167
		private float e;

		// Token: 0x040000A8 RID: 168
		private float f;

		// Token: 0x040000A9 RID: 169
		private float g;

		// Token: 0x040000AA RID: 170
		private float h;

		// Token: 0x040000AB RID: 171
		private float i;

		// Token: 0x040000AC RID: 172
		private float m_Determinant;
	}
}
