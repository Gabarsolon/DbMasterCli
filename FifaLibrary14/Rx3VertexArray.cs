using System;
using System.IO;
using Microsoft.DirectX.Direct3D;

namespace FifaLibrary
{
	// Token: 0x02000099 RID: 153
	public class Rx3VertexArray
	{
		// Token: 0x17000253 RID: 595
		// (get) Token: 0x06000B4F RID: 2895 RVA: 0x0004B5CD File Offset: 0x000497CD
		public int nVertex
		{
			get
			{
				return this.m_nVertex;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x06000B50 RID: 2896 RVA: 0x0004B5D5 File Offset: 0x000497D5
		public Rx3Vertex[] Vertexes
		{
			get
			{
				return this.m_Vertex;
			}
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x0004B5DD File Offset: 0x000497DD
		public Rx3VertexArray(BinaryReader r, bool swapEndian)
		{
			this.m_SwapEndian = swapEndian;
			this.Load(r);
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x0004B5F4 File Offset: 0x000497F4
		public bool Load(BinaryReader r)
		{
			if (this.m_SwapEndian)
			{
				this.m_Size = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_nVertex = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_VertexSize = FifaUtil.SwapEndian(r.ReadInt32());
				this.m_Unknown = r.ReadInt32();
				this.m_Vertex = new Rx3Vertex[this.m_nVertex];
				for (int i = 0; i < this.m_nVertex; i++)
				{
					this.m_Vertex[i] = new Rx3Vertex(r, this.m_VertexSize);
				}
			}
			else
			{
				this.m_Size = r.ReadInt32();
				this.m_nVertex = r.ReadInt32();
				this.m_VertexSize = r.ReadInt32();
				this.m_Unknown = r.ReadInt32();
				this.m_Vertex = new Rx3Vertex[this.m_nVertex];
				for (int j = 0; j < this.m_nVertex; j++)
				{
					this.m_Vertex[j] = new Rx3Vertex(r, this.m_VertexSize);
				}
			}
			return true;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x0004B6E8 File Offset: 0x000498E8
		public bool Save(BinaryWriter w)
		{
			if (this.m_SwapEndian)
			{
				w.Write(FifaUtil.SwapEndian(this.m_Size));
				w.Write(FifaUtil.SwapEndian(this.m_nVertex));
				w.Write(FifaUtil.SwapEndian(this.m_VertexSize));
				w.Write(this.m_Unknown);
				for (int i = 0; i < this.m_nVertex; i++)
				{
					this.m_Vertex[i].Save(w);
				}
			}
			else
			{
				w.Write(this.m_Size);
				w.Write(this.m_nVertex);
				w.Write(this.m_VertexSize);
				w.Write(this.m_Unknown);
				for (int j = 0; j < this.m_nVertex; j++)
				{
					this.m_Vertex[j].Save(w);
				}
			}
			return true;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x0004B7B0 File Offset: 0x000499B0
		public bool SetVertex(CustomVertex.PositionNormalTextured[] newVertexes)
		{
			if (this.m_nVertex != newVertexes.Length)
			{
				return false;
			}
			for (int i = 0; i < this.m_nVertex; i++)
			{
				this.m_Vertex[i].X = newVertexes[i].X;
				this.m_Vertex[i].Y = newVertexes[i].Y;
				this.m_Vertex[i].Z = newVertexes[i].Z;
			}
			return true;
		}

		// Token: 0x04000FD6 RID: 4054
		private int m_Size;

		// Token: 0x04000FD7 RID: 4055
		private int m_nVertex;

		// Token: 0x04000FD8 RID: 4056
		private int m_VertexSize;

		// Token: 0x04000FD9 RID: 4057
		private int m_Unknown;

		// Token: 0x04000FDA RID: 4058
		private Rx3Vertex[] m_Vertex;

		// Token: 0x04000FDB RID: 4059
		private bool m_SwapEndian;
	}
}
