using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200009A RID: 154
	public class Rx3Vertex
	{
		// Token: 0x17000255 RID: 597
		// (get) Token: 0x06000B55 RID: 2901 RVA: 0x0004B827 File Offset: 0x00049A27
		// (set) Token: 0x06000B56 RID: 2902 RVA: 0x0004B82E File Offset: 0x00049A2E
		public static Rx3Vertex.EFloatType FloatType
		{
			get
			{
				return Rx3Vertex.s_FloatType;
			}
			set
			{
				Rx3Vertex.s_FloatType = value;
			}
		}

		// Token: 0x17000256 RID: 598
		// (get) Token: 0x06000B57 RID: 2903 RVA: 0x0004B836 File Offset: 0x00049A36
		// (set) Token: 0x06000B58 RID: 2904 RVA: 0x0004B83E File Offset: 0x00049A3E
		public float X
		{
			get
			{
				return this.m_X;
			}
			set
			{
				this.m_X = value;
			}
		}

		// Token: 0x17000257 RID: 599
		// (get) Token: 0x06000B59 RID: 2905 RVA: 0x0004B847 File Offset: 0x00049A47
		// (set) Token: 0x06000B5A RID: 2906 RVA: 0x0004B84F File Offset: 0x00049A4F
		public float Y
		{
			get
			{
				return this.m_Y;
			}
			set
			{
				this.m_Y = value;
			}
		}

		// Token: 0x17000258 RID: 600
		// (get) Token: 0x06000B5B RID: 2907 RVA: 0x0004B858 File Offset: 0x00049A58
		// (set) Token: 0x06000B5C RID: 2908 RVA: 0x0004B860 File Offset: 0x00049A60
		public float Z
		{
			get
			{
				return this.m_Z;
			}
			set
			{
				this.m_Z = value;
			}
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x06000B5D RID: 2909 RVA: 0x0004B869 File Offset: 0x00049A69
		public float U
		{
			get
			{
				return this.m_U;
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0004B871 File Offset: 0x00049A71
		public float V
		{
			get
			{
				return this.m_V;
			}
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x0004B87C File Offset: 0x00049A7C
		public Rx3Vertex(BinaryReader r, int vertexSize)
		{
			this.m_VertexSize = vertexSize;
			if (this.m_VertexSize == 20)
			{
				this.Load20_ShortFloat(r);
			}
			if (this.m_VertexSize == 32)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Load32_ShortFloat(r);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Load32_LongFloat(r);
				}
			}
			if (this.m_VertexSize == 36)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Load36_ShortFloat(r);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Load36_LongFloat(r);
				}
			}
			if (this.m_VertexSize == 40)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Load40_ShortFloat(r);
					return;
				}
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Load40_LongFloat(r);
				}
			}
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x0004B938 File Offset: 0x00049B38
		public bool Load20_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x0004B9FC File Offset: 0x00049BFC
		public bool Load32_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x0004BB34 File Offset: 0x00049D34
		public bool Load32_LongFloat(BinaryReader r)
		{
			this.m_X = -r.ReadSingle();
			this.m_Y = r.ReadSingle();
			this.m_Z = r.ReadSingle();
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[7] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x0004BC24 File Offset: 0x00049E24
		public bool Load36_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x0004BD80 File Offset: 0x00049F80
		public bool Load36_LongFloat(BinaryReader r)
		{
			this.m_X = -r.ReadSingle();
			this.m_Y = r.ReadSingle();
			this.m_Z = r.ReadSingle();
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = r.ReadSingle();
			this.m_Unknown[5] = r.ReadSingle();
			this.m_Unknown[6] = r.ReadSingle();
			return true;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0004BE4C File Offset: 0x0004A04C
		public bool Load40_ShortFloat(BinaryReader r)
		{
			this.m_X = -FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Y = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Z = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[5] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[6] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[7] = FifaUtil.ConvertToFloat(r.ReadInt16());
			return true;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0004BFD0 File Offset: 0x0004A1D0
		public bool Load40_LongFloat(BinaryReader r)
		{
			this.m_X = -r.ReadSingle();
			this.m_Y = r.ReadSingle();
			this.m_Z = r.ReadSingle();
			this.m_Unknown[0] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[1] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[2] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[3] = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_U = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_V = FifaUtil.ConvertToFloat(r.ReadInt16());
			this.m_Unknown[4] = r.ReadSingle();
			this.m_Unknown[5] = r.ReadSingle();
			this.m_Unknown[6] = r.ReadSingle();
			this.m_Unknown[7] = r.ReadSingle();
			return true;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0004C0AC File Offset: 0x0004A2AC
		public bool Save(BinaryWriter w)
		{
			if (this.m_VertexSize == 20)
			{
				this.Save20_ShortFloat(w);
			}
			if (this.m_VertexSize == 32)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Save32_ShortFloat(w);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Save32_LongFloat(w);
				}
			}
			if (this.m_VertexSize == 36)
			{
				if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float16)
				{
					this.Save36_ShortFloat(w);
				}
				else if (Rx3Vertex.s_FloatType == Rx3Vertex.EFloatType.Float32)
				{
					this.Save36_LongFloat(w);
				}
			}
			return true;
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0004C122 File Offset: 0x0004A322
		public bool Save20_ShortFloat(BinaryWriter w)
		{
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_X));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Y));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Z));
			w.Seek(14, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0004C162 File Offset: 0x0004A362
		public bool Save32_ShortFloat(BinaryWriter w)
		{
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_X));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Y));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Z));
			w.Seek(26, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000B6A RID: 2922 RVA: 0x0004C1A2 File Offset: 0x0004A3A2
		public bool Save32_LongFloat(BinaryWriter w)
		{
			w.Write(this.m_X);
			w.Write(this.m_Y);
			w.Write(this.m_Z);
			w.Seek(20, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0004C1D3 File Offset: 0x0004A3D3
		public bool Save36_ShortFloat(BinaryWriter w)
		{
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_X));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Y));
			w.Write(FifaUtil.ConvertFloat16ToShort(this.m_Z));
			w.Seek(30, SeekOrigin.Current);
			return true;
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0004C213 File Offset: 0x0004A413
		public bool Save36_LongFloat(BinaryWriter w)
		{
			w.Write(this.m_X);
			w.Write(this.m_Y);
			w.Write(this.m_Z);
			w.Seek(24, SeekOrigin.Current);
			return true;
		}

		// Token: 0x04000FDC RID: 4060
		private static Rx3Vertex.EFloatType s_FloatType;

		// Token: 0x04000FDD RID: 4061
		private int m_VertexSize;

		// Token: 0x04000FDE RID: 4062
		private float m_X;

		// Token: 0x04000FDF RID: 4063
		private float m_Y;

		// Token: 0x04000FE0 RID: 4064
		private float m_Z;

		// Token: 0x04000FE1 RID: 4065
		private float m_U;

		// Token: 0x04000FE2 RID: 4066
		private float m_V;

		// Token: 0x04000FE3 RID: 4067
		private float[] m_Unknown = new float[9];

		// Token: 0x0200009B RID: 155
		public enum EFloatType
		{
			// Token: 0x04000FE5 RID: 4069
			Float16,
			// Token: 0x04000FE6 RID: 4070
			Float32
		}
	}
}
