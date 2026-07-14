using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace FifaLibrary
{
	// Token: 0x02000003 RID: 3
	public class Model3D
	{
		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000023E5 File Offset: 0x000005E5
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000023DC File Offset: 0x000005DC
		public string TextureFileName
		{
			get
			{
				return this.m_TextureFileName;
			}
			set
			{
				this.m_TextureFileName = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x000023F6 File Offset: 0x000005F6
		// (set) Token: 0x0600000B RID: 11 RVA: 0x000023ED File Offset: 0x000005ED
		public Bitmap TextureBitmap
		{
			get
			{
				return this.m_TextureBitmap;
			}
			set
			{
				this.m_TextureBitmap = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600000D RID: 13 RVA: 0x000023FE File Offset: 0x000005FE
		public int NVertex
		{
			get
			{
				return this.m_NVertex;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600000E RID: 14 RVA: 0x00002406 File Offset: 0x00000606
		public int NIndex
		{
			get
			{
				return this.m_NIndex;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000F RID: 15 RVA: 0x0000240E File Offset: 0x0000060E
		public CustomVertex.PositionNormalTextured[] Vertex
		{
			get
			{
				return this.m_Vertex;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000010 RID: 16 RVA: 0x00002416 File Offset: 0x00000616
		public short[] Index
		{
			get
			{
				return this.m_Index;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000011 RID: 17 RVA: 0x0000241E File Offset: 0x0000061E
		public int NFaces
		{
			get
			{
				return this.m_NFaces;
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002426 File Offset: 0x00000626
		public Model3D()
		{
		}

		// Token: 0x06000013 RID: 19 RVA: 0x0000242E File Offset: 0x0000062E
		public Model3D(Rx3IndexArray indexArray, Rx3VertexArray vertexArray)
		{
			this.Initialize(indexArray, vertexArray);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x0000243E File Offset: 0x0000063E
		public Model3D(Rx3IndexArray indexArray, Rx3VertexArray vertexArray, Bitmap textureBitmap)
		{
			this.Initialize(indexArray, vertexArray);
			this.m_TextureBitmap = textureBitmap;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002455 File Offset: 0x00000655
		public void Initialize(Rx3IndexArray indexArray, Rx3VertexArray vertexArray)
		{
			this.SetVertexArray(vertexArray);
			this.SetIndexArray(indexArray);
			this.ComputeNormals();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x0000246C File Offset: 0x0000066C
		private void SetIndexArray(Rx3IndexArray indexArray)
		{
			this.m_NIndex = indexArray.NIndex;
			this.m_NOriginalIndex = this.m_NIndex;
			this.m_IndexStream = indexArray.IndexStream;
			this.m_NFaces = indexArray.nFaces;
			this.m_IsTriangleList = indexArray.IsTriangleList;
			if (!this.m_IsTriangleList)
			{
				this.m_Index = new short[this.m_NIndex];
				for (int i = 0; i < this.m_NIndex; i += 3)
				{
					this.m_Index[i] = this.m_IndexStream[i];
					this.m_Index[i + 1] = this.m_IndexStream[i + 1];
					this.m_Index[i + 2] = this.m_IndexStream[i + 2];
				}
				return;
			}
			this.m_Index = new short[this.m_NFaces * 3];
			int num = 0;
			int num2 = ((Rx3IndexArray.TriangleListType == Rx3IndexArray.ETriangleListType.InvertOdd) ? 1 : 0);
			for (int j = 0; j < this.m_NIndex - 2; j++)
			{
				short num3 = this.m_IndexStream[j];
				short num4 = this.m_IndexStream[j + 1];
				short num5 = this.m_IndexStream[j + 2];
				if ((int)num3 > this.m_NVertex || (int)num4 > this.m_NVertex || (int)num5 > this.m_NVertex || num3 < 0 || num4 < 0 || num5 < 0)
				{
					break;
				}
				if (num3 != num4 && num4 != num5 && num3 != num5)
				{
					if ((j & 1) == num2)
					{
						this.m_Index[num++] = num3;
						this.m_Index[num++] = num4;
						this.m_Index[num++] = num5;
					}
					else
					{
						this.m_Index[num++] = num3;
						this.m_Index[num++] = num5;
						this.m_Index[num++] = num4;
					}
				}
			}
			this.m_NIndex = this.m_NFaces * 3;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002630 File Offset: 0x00000830
		private void SetVertexArray(Rx3VertexArray vertexArray)
		{
			this.m_NVertex = vertexArray.nVertex;
			this.m_NOriginalVertex = this.m_NVertex;
			this.m_Vertex = new CustomVertex.PositionNormalTextured[this.m_NVertex];
			for (int i = 0; i < this.m_NVertex; i++)
			{
				this.m_Vertex[i].X = vertexArray.Vertexes[i].X;
				this.m_Vertex[i].Y = vertexArray.Vertexes[i].Y;
				this.m_Vertex[i].Z = vertexArray.Vertexes[i].Z;
				this.m_Vertex[i].Tu = vertexArray.Vertexes[i].U;
				this.m_Vertex[i].Tv = vertexArray.Vertexes[i].V;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002714 File Offset: 0x00000914
		public Model3D Clone()
		{
			Model3D model3D = (Model3D)base.MemberwiseClone();
			model3D.m_Index = (short[])this.m_Index.Clone();
			model3D.m_IndexStream = (short[])this.m_IndexStream.Clone();
			model3D.m_Unknown = (int[])this.m_Unknown.Clone();
			model3D.m_Vertex = (CustomVertex.PositionNormalTextured[])this.m_Vertex.Clone();
			return model3D;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002788 File Offset: 0x00000988
		private void ComputeNormals()
		{
			Vector3[] array = new Vector3[this.m_NVertex];
			int[] array2 = new int[this.m_NVertex];
			for (int i = 0; i < this.m_NFaces; i++)
			{
				int num = (int)this.m_Index[i * 3];
				int num2 = (int)this.m_Index[i * 3 + 1];
				int num3 = (int)this.m_Index[i * 3 + 2];
				Vector3 vector = new Vector3(this.m_Vertex[num].X, this.m_Vertex[num].Y, this.m_Vertex[num].Z);
				Vector3 vector2 = new Vector3(this.m_Vertex[num2].X, this.m_Vertex[num2].Y, this.m_Vertex[num2].Z);
				Vector3 vector3 = new Vector3(this.m_Vertex[num3].X, this.m_Vertex[num3].Y, this.m_Vertex[num3].Z);
				Vector3 vector4 = Vector3.Subtract(vector2, vector);
				Vector3 vector5 = Vector3.Subtract(vector3, vector);
				Vector3 vector6 = Vector3.Normalize(Vector3.Cross(vector5, vector4));
				array[num] = Vector3.Add(array[num], vector6);
				array[num2] = Vector3.Add(array[num2], vector6);
				array[num3] = Vector3.Add(array[num3], vector6);
				array2[num]++;
				array2[num2]++;
				array2[num3]++;
			}
			for (int j = 0; j < this.m_NVertex; j++)
			{
				Vector3 vector7 = Vector3.Scale(array[j], 1f / (float)array2[j]);
				this.m_Vertex[j].Nx = vector7.X;
				this.m_Vertex[j].Ny = vector7.Y;
				this.m_Vertex[j].Nz = vector7.Z;
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000029E3 File Offset: 0x00000BE3
		public bool CanMerge(Model3D model)
		{
			return model == null || (this.m_NOriginalVertex >= model.NVertex && this.m_NOriginalIndex >= model.NIndex);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002A0B File Offset: 0x00000C0B
		public static bool CanMorphing(Model3D model1, Model3D model2)
		{
			return model1 != null && model2 != null && model1.NVertex == model2.NVertex;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002A26 File Offset: 0x00000C26
		public bool CanMorphing(Model3D model2)
		{
			return Model3D.CanMorphing(this, model2);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002A30 File Offset: 0x00000C30
		public bool Merge(Model3D model)
		{
			if (!this.CanMerge(model))
			{
				return false;
			}
			int num = 0;
			int num2 = 0;
			int num3 = 0;
			if (model != null)
			{
				num = model.NVertex;
				num2 = model.NIndex;
				num3 = model.NFaces;
			}
			for (int i = num; i < this.m_NVertex; i++)
			{
				this.m_Vertex[i].X = 0f;
				this.m_Vertex[i].Y = 0f;
				this.m_Vertex[i].Z = 0f;
				this.m_Vertex[i].Nx = 0f;
				this.m_Vertex[i].Ny = 0f;
				this.m_Vertex[i].Nz = 0f;
				this.m_Vertex[i].Tu = 0f;
				this.m_Vertex[i].Tv = 0f;
			}
			this.m_NVertex = num;
			for (int j = 0; j < this.m_NVertex; j++)
			{
				this.m_Vertex[j].X = model.Vertex[j].X;
				this.m_Vertex[j].Y = model.Vertex[j].Y;
				this.m_Vertex[j].Z = model.Vertex[j].Z;
				this.m_Vertex[j].Nx = model.Vertex[j].Nx;
				this.m_Vertex[j].Ny = model.Vertex[j].Ny;
				this.m_Vertex[j].Nz = model.Vertex[j].Nz;
				this.m_Vertex[j].Tu = model.Vertex[j].Tu;
				this.m_Vertex[j].Tv = model.Vertex[j].Tv;
			}
			for (int k = num2; k < this.m_NIndex; k++)
			{
				this.m_IndexStream[k] = 0;
			}
			this.m_NIndex = num2;
			for (int l = 0; l < this.m_NIndex; l++)
			{
				this.m_IndexStream[l] = model.m_IndexStream[l];
			}
			if (num3 < this.m_NFaces)
			{
				for (int m = num3 * 3; m < this.m_NFaces * 3; m++)
				{
					this.m_Index[m] = 0;
				}
			}
			else
			{
				Array.Resize<short>(ref this.m_Index, num3 * 3);
			}
			this.m_NFaces = num3;
			for (int n = 0; n < this.m_NFaces * 3; n++)
			{
				this.m_Index[n] = model.m_Index[n];
			}
			return true;
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00002D2C File Offset: 0x00000F2C
		public bool Morphing(Model3D model, float percent)
		{
			if (!this.CanMorphing(model))
			{
				return false;
			}
			float num = 1f - percent;
			this.m_NVertex = model.NVertex;
			for (int i = 0; i < this.m_NVertex; i++)
			{
				this.m_Vertex[i].X = this.m_Vertex[i].X * num + model.Vertex[i].X * percent;
				this.m_Vertex[i].Y = this.m_Vertex[i].Y * num + model.Vertex[i].Y * percent;
				this.m_Vertex[i].Z = this.m_Vertex[i].Z * num + model.Vertex[i].Z * percent;
				this.m_Vertex[i].Tu = this.m_Vertex[i].Tu * num + model.Vertex[i].Tu * percent;
				this.m_Vertex[i].Tv = this.m_Vertex[i].Tv * num + model.Vertex[i].Tv * percent;
			}
			return true;
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002E88 File Offset: 0x00001088
		public bool Morphing(Model3D model1, Model3D model2, float percent)
		{
			if (!Model3D.CanMorphing(model1, model2))
			{
				return false;
			}
			if (!this.CanMorphing(model1))
			{
				return false;
			}
			float num = 1f - percent;
			int num2 = this.m_NVertex;
			if (model1.NVertex < num2)
			{
				num2 = model1.NVertex;
			}
			if (model2.NVertex < num2)
			{
				num2 = model2.NVertex;
			}
			this.m_NVertex = num2;
			for (int i = 0; i < num2; i++)
			{
				this.m_Vertex[i].X = model1.m_Vertex[i].X * num + model2.Vertex[i].X * percent;
				this.m_Vertex[i].Y = model1.m_Vertex[i].Y * num + model2.Vertex[i].Y * percent;
				this.m_Vertex[i].Z = model1.m_Vertex[i].Z * num + model2.Vertex[i].Z * percent;
				this.m_Vertex[i].Tu = model1.m_Vertex[i].Tu * num + model2.Vertex[i].Tu * percent;
				this.m_Vertex[i].Tv = model1.m_Vertex[i].Tv * num + model2.Vertex[i].Tv * percent;
			}
			return true;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000300C File Offset: 0x0000120C
		public void MoveForward()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].Z = vertex[num].Z + 0.1f;
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003048 File Offset: 0x00001248
		public void MoveBack()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].Z = vertex[num].Z - 0.1f;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003084 File Offset: 0x00001284
		public void MoveUp()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].Y = vertex[num].Y + 0.1f;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x000030C0 File Offset: 0x000012C0
		public void MoveDown()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].Y = vertex[num].Y - 0.1f;
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000030FC File Offset: 0x000012FC
		public void MoveLeft()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].X = vertex[num].X + 0.1f;
			}
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003138 File Offset: 0x00001338
		public void MoveRight()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].X = vertex[num].X - 0.1f;
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00003174 File Offset: 0x00001374
		public void MakeCloser()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				if (this.m_Vertex[i].X > 0f)
				{
					CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
					int num = i;
					vertex[num].X = vertex[num].X - 0.1f;
				}
				else if (this.m_Vertex[i].X < 0f)
				{
					CustomVertex.PositionNormalTextured[] vertex2 = this.m_Vertex;
					int num2 = i;
					vertex2[num2].X = vertex2[num2].X + 0.1f;
				}
			}
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003200 File Offset: 0x00001400
		public void MakeWider()
		{
			for (int i = 0; i < this.m_NVertex; i++)
			{
				if (this.m_Vertex[i].X > 0f)
				{
					CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
					int num = i;
					vertex[num].X = vertex[num].X + 0.1f;
				}
				else if (this.m_Vertex[i].X < 0f)
				{
					CustomVertex.PositionNormalTextured[] vertex2 = this.m_Vertex;
					int num2 = i;
					vertex2[num2].X = vertex2[num2].X - 0.1f;
				}
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000328C File Offset: 0x0000148C
		public void SaveXFile(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
			StreamWriter streamWriter = new StreamWriter(fileStream);
			this.SaveXFile(streamWriter);
			streamWriter.Close();
			fileStream.Close();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000032BC File Offset: 0x000014BC
		public void SaveXFile(StreamWriter w)
		{
			if (this.m_NVertex <= 0)
			{
				return;
			}
			w.WriteLine("xof 0303txt 0032");
			w.WriteLine("Mesh {");
			w.WriteLine(" {0};", this.m_NVertex);
			for (int i = 0; i < this.m_NVertex - 1; i++)
			{
				w.WriteLine(" {0:F6};{1:F6};{2:F6};,", this.m_Vertex[i].X, this.m_Vertex[i].Y, this.m_Vertex[i].Z);
			}
			w.WriteLine(" {0:F6};{1:F6};{2:F6};;", this.m_Vertex[this.m_NVertex - 1].X, this.m_Vertex[this.m_NVertex - 1].Y, this.m_Vertex[this.m_NVertex - 1].Z);
			w.WriteLine(" {0};", this.m_NFaces);
			for (int j = 0; j < this.m_NFaces - 1; j++)
			{
				w.WriteLine(" 3;{0},{1},{2};,", this.m_Index[j * 3], this.m_Index[j * 3 + 1], this.m_Index[j * 3 + 2]);
			}
			w.WriteLine(" 3;{0},{1},{2};;", this.m_Index[(this.m_NFaces - 1) * 3], this.m_Index[(this.m_NFaces - 1) * 3 + 1], this.m_Index[(this.m_NFaces - 1) * 3 + 2]);
			w.WriteLine(" MeshNormals {");
			w.WriteLine("  {0};", this.m_NVertex);
			for (int k = 0; k < this.m_NVertex - 1; k++)
			{
				w.WriteLine("  {0:F6};{1:F6};{2:F6};,", this.m_Vertex[k].Nx, this.m_Vertex[k].Ny, this.m_Vertex[k].Nz);
			}
			w.WriteLine("  {0:F6};{1:F6};{2:F6};;", this.m_Vertex[this.m_NVertex - 1].Nx, this.m_Vertex[this.m_NVertex - 1].Ny, this.m_Vertex[this.m_NVertex - 1].Nz);
			w.WriteLine(" {0};", this.m_NFaces);
			for (int l = 0; l < this.m_NFaces - 1; l++)
			{
				w.WriteLine("  3;{0},{1},{2};,", this.m_Index[l * 3], this.m_Index[l * 3 + 1], this.m_Index[l * 3 + 2]);
			}
			w.WriteLine("  3;{0},{1},{2};;", this.m_Index[(this.m_NFaces - 1) * 3], this.m_Index[(this.m_NFaces - 1) * 3 + 1], this.m_Index[(this.m_NFaces - 1) * 3 + 2]);
			w.WriteLine(" }");
			w.WriteLine(" MeshTextureCoords {");
			w.WriteLine("  {0};", this.m_NVertex);
			for (int m = 0; m < this.m_NVertex - 1; m++)
			{
				w.WriteLine("  {0:F6};{1:F6};,", this.m_Vertex[m].Tu, this.m_Vertex[m].Tv);
			}
			w.WriteLine("  {0:F6};{1:F6};;", this.m_Vertex[this.m_NVertex - 1].Tu, this.m_Vertex[this.m_NVertex - 1].Tv);
			w.WriteLine(" }");
			w.WriteLine(" MeshMaterialList {");
			w.WriteLine("  1;");
			w.WriteLine("  {0};", this.m_NFaces);
			for (int n = 0; n < this.m_NFaces - 1; n++)
			{
				w.WriteLine("  0,");
			}
			w.WriteLine("  0;");
			w.WriteLine("  Material {");
			w.WriteLine("   1.000000;1.000000;1.000000;0.000000;;");
			w.WriteLine("   0.000000;");
			w.WriteLine("   0.000000;0.000000;0.000000;;");
			w.WriteLine("   0.000000;0.000000;0.000000;;");
			w.WriteLine("   TextureFilename {");
			w.WriteLine("   \"" + this.m_TextureFileName + "\";");
			w.WriteLine("   }");
			w.WriteLine("  }");
			w.WriteLine(" }");
			w.WriteLine("}");
			this.m_TextureBitmap.Save(this.m_TextureFileName, ImageFormat.Png);
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000037D4 File Offset: 0x000019D4
		public void OffsetVertex(int offsetX, int offsetY, int offsetZ)
		{
			if (this.m_Vertex == null)
			{
				return;
			}
			if (this.m_Vertex.Length < this.m_NOriginalVertex)
			{
				return;
			}
			for (int i = 0; i < this.m_NOriginalVertex; i++)
			{
				CustomVertex.PositionNormalTextured[] vertex = this.m_Vertex;
				int num = i;
				vertex[num].X = vertex[num].X - (float)offsetX;
				CustomVertex.PositionNormalTextured[] vertex2 = this.m_Vertex;
				int num2 = i;
				vertex2[num2].Y = vertex2[num2].Y - (float)offsetY;
				CustomVertex.PositionNormalTextured[] vertex3 = this.m_Vertex;
				int num3 = i;
				vertex3[num3].Z = vertex3[num3].Z - (float)offsetZ;
			}
		}

		// Token: 0x0600002B RID: 43 RVA: 0x0000385C File Offset: 0x00001A5C
		public void Morphing(int[] points, Vector3 symmetryPoint, Vector3 delta)
		{
			foreach (int num in points)
			{
				if (num >= 0 && num < this.NVertex)
				{
					if (this.Vertex[num].X < symmetryPoint.X)
					{
						CustomVertex.PositionNormalTextured[] vertex = this.Vertex;
						int num2 = num;
						vertex[num2].X = vertex[num2].X - delta.X;
					}
					else
					{
						CustomVertex.PositionNormalTextured[] vertex2 = this.Vertex;
						int num3 = num;
						vertex2[num3].X = vertex2[num3].X + delta.X;
					}
					if (this.Vertex[num].Y < symmetryPoint.Y)
					{
						CustomVertex.PositionNormalTextured[] vertex3 = this.Vertex;
						int num4 = num;
						vertex3[num4].Y = vertex3[num4].Y - delta.Y;
					}
					else
					{
						CustomVertex.PositionNormalTextured[] vertex4 = this.Vertex;
						int num5 = num;
						vertex4[num5].Y = vertex4[num5].Y + delta.Y;
					}
					if (this.Vertex[num].Z < symmetryPoint.Z)
					{
						CustomVertex.PositionNormalTextured[] vertex5 = this.Vertex;
						int num6 = num;
						vertex5[num6].Z = vertex5[num6].Z - delta.Z;
					}
					else
					{
						CustomVertex.PositionNormalTextured[] vertex6 = this.Vertex;
						int num7 = num;
						vertex6[num7].Z = vertex6[num7].Z + delta.Z;
					}
				}
			}
		}

		// Token: 0x04000004 RID: 4
		private string m_TextureFileName;

		// Token: 0x04000005 RID: 5
		private Bitmap m_TextureBitmap;

		// Token: 0x04000006 RID: 6
		private int m_NVertex;

		// Token: 0x04000007 RID: 7
		private int m_NOriginalVertex;

		// Token: 0x04000008 RID: 8
		private int m_NIndex;

		// Token: 0x04000009 RID: 9
		private int m_NOriginalIndex;

		// Token: 0x0400000A RID: 10
		private bool m_IsTriangleList;

		// Token: 0x0400000B RID: 11
		private CustomVertex.PositionNormalTextured[] m_Vertex;

		// Token: 0x0400000C RID: 12
		private int[] m_Unknown;

		// Token: 0x0400000D RID: 13
		private short[] m_Index;

		// Token: 0x0400000E RID: 14
		private short[] m_IndexStream;

		// Token: 0x0400000F RID: 15
		private int m_NFaces;
	}
}
