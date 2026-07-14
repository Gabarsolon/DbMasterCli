using System;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FifaLibrary;
using Microsoft.DirectX;
using Microsoft.DirectX.Direct3D;

namespace FifaControls
{
	// Token: 0x02000018 RID: 24
	public class Viewer3D : UserControl
	{
		// Token: 0x060000DF RID: 223 RVA: 0x0000D4E8 File Offset: 0x0000B6E8
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000D508 File Offset: 0x0000B708
		private void InitializeComponent()
		{
			base.SuspendLayout();
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Gray;
			base.BorderStyle = BorderStyle.Fixed3D;
			base.Name = "Viewer3D";
			base.Size = new Size(305, 284);
			base.DoubleClick += this.Viewer3D_DoubleClick;
			base.MouseDown += this.Viewer3D_MouseDown;
			base.MouseMove += this.Viewer3D_MouseMove;
			base.MouseUp += this.Viewer3D_MouseUp;
			base.ResumeLayout(false);
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000E1 RID: 225 RVA: 0x0000D5B8 File Offset: 0x0000B7B8
		// (set) Token: 0x060000E2 RID: 226 RVA: 0x0000D5C0 File Offset: 0x0000B7C0
		public bool[] ZbufferRenderState
		{
			get
			{
				return this.m_ZbufferRenderState;
			}
			set
			{
				this.m_ZbufferRenderState = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000E3 RID: 227 RVA: 0x0000D5C9 File Offset: 0x0000B7C9
		// (set) Token: 0x060000E4 RID: 228 RVA: 0x0000D5D1 File Offset: 0x0000B7D1
		public float RotationYCoeff
		{
			get
			{
				return this.m_RotationYCoeff;
			}
			set
			{
				this.m_RotationYCoeff = value;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000E5 RID: 229 RVA: 0x0000D5DA File Offset: 0x0000B7DA
		// (set) Token: 0x060000E6 RID: 230 RVA: 0x0000D5E2 File Offset: 0x0000B7E2
		public float ViewX
		{
			get
			{
				return this.m_StartViewX;
			}
			set
			{
				this.m_ViewX = value;
				this.m_StartViewX = value;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000E7 RID: 231 RVA: 0x0000D5F2 File Offset: 0x0000B7F2
		// (set) Token: 0x060000E8 RID: 232 RVA: 0x0000D5FA File Offset: 0x0000B7FA
		public float ViewY
		{
			get
			{
				return this.m_StartViewY;
			}
			set
			{
				this.m_ViewY = value;
				this.m_StartViewY = value;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000E9 RID: 233 RVA: 0x0000D60A File Offset: 0x0000B80A
		// (set) Token: 0x060000EA RID: 234 RVA: 0x0000D612 File Offset: 0x0000B812
		public float ViewZ
		{
			get
			{
				return this.m_StartViewZ;
			}
			set
			{
				this.m_ViewZ = value;
				this.m_StartViewZ = value;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000EB RID: 235 RVA: 0x0000D622 File Offset: 0x0000B822
		// (set) Token: 0x060000EC RID: 236 RVA: 0x0000D62A File Offset: 0x0000B82A
		public float RotationX
		{
			get
			{
				return this.m_StartRotationX;
			}
			set
			{
				this.m_RotationX = value;
				this.m_StartRotationX = value;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000ED RID: 237 RVA: 0x0000D63A File Offset: 0x0000B83A
		// (set) Token: 0x060000EE RID: 238 RVA: 0x0000D642 File Offset: 0x0000B842
		public float RotationY
		{
			get
			{
				return this.m_StartRotationY;
			}
			set
			{
				this.m_RotationY = value;
				this.m_StartRotationY = value;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000EF RID: 239 RVA: 0x0000D652 File Offset: 0x0000B852
		// (set) Token: 0x060000F0 RID: 240 RVA: 0x0000D65A File Offset: 0x0000B85A
		public float LightDirectionZ
		{
			get
			{
				return this.m_LightDirectionZ;
			}
			set
			{
				this.m_LightDirectionZ = value;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000F1 RID: 241 RVA: 0x0000D663 File Offset: 0x0000B863
		// (set) Token: 0x060000F2 RID: 242 RVA: 0x0000D66B File Offset: 0x0000B86B
		public float LightDirectionY
		{
			get
			{
				return this.m_LightDirectionY;
			}
			set
			{
				this.m_LightDirectionY = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000F3 RID: 243 RVA: 0x0000D674 File Offset: 0x0000B874
		// (set) Token: 0x060000F4 RID: 244 RVA: 0x0000D67C File Offset: 0x0000B87C
		public float LightDirectionX
		{
			get
			{
				return this.m_LightDirectionX;
			}
			set
			{
				this.m_LightDirectionX = value;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000F5 RID: 245 RVA: 0x0000D685 File Offset: 0x0000B885
		// (set) Token: 0x060000F6 RID: 246 RVA: 0x0000D68D File Offset: 0x0000B88D
		public float LightX
		{
			get
			{
				return this.m_LightX;
			}
			set
			{
				this.m_LightX = value;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000F7 RID: 247 RVA: 0x0000D696 File Offset: 0x0000B896
		// (set) Token: 0x060000F8 RID: 248 RVA: 0x0000D69E File Offset: 0x0000B89E
		public float LightY
		{
			get
			{
				return this.m_LightY;
			}
			set
			{
				this.m_LightY = value;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000F9 RID: 249 RVA: 0x0000D6A7 File Offset: 0x0000B8A7
		// (set) Token: 0x060000FA RID: 250 RVA: 0x0000D6AF File Offset: 0x0000B8AF
		public float LightZ
		{
			get
			{
				return this.m_LightZ;
			}
			set
			{
				this.m_LightZ = value;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000FB RID: 251 RVA: 0x0000D6B8 File Offset: 0x0000B8B8
		// (set) Token: 0x060000FC RID: 252 RVA: 0x0000D6C0 File Offset: 0x0000B8C0
		public Color AmbientColor
		{
			get
			{
				return this.m_AmbientColor;
			}
			set
			{
				this.m_AmbientColor = value;
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000D6CC File Offset: 0x0000B8CC
		public Viewer3D()
		{
			this.InitializeComponent();
			if (!this.InitializeHardwareGraphics())
			{
				this.InitializeSoftwareGraphics();
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0000D74C File Offset: 0x0000B94C
		public bool InitializeHardwareGraphics()
		{
			try
			{
				this.m_PresentParams.Windowed = true;
				this.m_PresentParams.SwapEffect = 1;
				this.m_PresentParams.EnableAutoDepthStencil = true;
				this.m_PresentParams.AutoDepthStencilFormat = 80;
				this.m_Device = new Device(0, 1, this, 64, new PresentParameters[] { this.m_PresentParams });
				this.m_Device.DeviceReset += this.OnResetDevice;
				this.OnResetDevice(this.m_Device, null);
				this.pause = false;
			}
			catch (DirectXException)
			{
				return false;
			}
			return true;
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000D7F0 File Offset: 0x0000B9F0
		public bool InitializeSoftwareGraphics()
		{
			try
			{
				this.m_PresentParams.Windowed = true;
				this.m_PresentParams.SwapEffect = 1;
				this.m_PresentParams.EnableAutoDepthStencil = true;
				this.m_PresentParams.AutoDepthStencilFormat = 80;
				this.m_Device = new Device(0, 1, this, 34, new PresentParameters[] { this.m_PresentParams });
				this.m_Device.DeviceReset += this.OnResetDevice;
				this.OnResetDevice(this.m_Device, null);
				this.pause = false;
			}
			catch (DirectXException)
			{
				return false;
			}
			return true;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000D894 File Offset: 0x0000BA94
		public void ShowEmpty()
		{
			this.m_Materials = null;
			this.Render();
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
		public void Show3D(string xFileName)
		{
			try
			{
				this.m_XFileName = Path.GetFileName(xFileName);
				this.m_XFilePath = Path.GetDirectoryName(xFileName);
				string currentDirectory = Environment.CurrentDirectory;
				Directory.SetCurrentDirectory(this.m_XFilePath);
				if (this.m_XFileMesh != null)
				{
					this.m_XFileMesh.Dispose();
				}
				if (this.m_ExtendedMaterials != null && this.m_Textures != null)
				{
					for (int i = 0; i < this.m_ExtendedMaterials.Length; i++)
					{
						if (this.m_Textures[i] != null)
						{
							this.m_Textures[i].Dispose();
						}
					}
				}
				this.m_XFileMesh = Mesh.FromFile(this.m_XFileName, 544, this.m_Device, ref this.m_ExtendedMaterials);
				this.m_Textures = new Texture[this.m_ExtendedMaterials.Length];
				this.m_Materials = new Material[this.m_ExtendedMaterials.Length];
				for (int j = 0; j < this.m_ExtendedMaterials.Length; j++)
				{
					this.m_Materials[j] = this.m_ExtendedMaterials[j].Material3D;
					this.m_Materials[j].Ambient = this.m_Materials[j].Diffuse;
					if (this.m_Textures[j] != null)
					{
						this.m_Textures[j].Dispose();
					}
					this.m_Textures[j] = TextureLoader.FromFile(this.m_Device, this.m_ExtendedMaterials[j].TextureFilename);
				}
				this.Render();
				Directory.SetCurrentDirectory(currentDirectory);
			}
			catch (DirectXException)
			{
				this.m_Materials = null;
				this.m_Textures = null;
				this.Render();
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000DA5C File Offset: 0x0000BC5C
		public void Show3D(Bitmap bitmap, int partIndex)
		{
			if (partIndex < 0 || partIndex >= this.m_Textures.Length)
			{
				return;
			}
			try
			{
				this.m_Textures[partIndex] = Texture.FromBitmap(this.m_Device, bitmap, 64, 0);
				this.m_Textures[partIndex].Dispose();
				this.Render();
			}
			catch (DirectXException)
			{
				this.m_Materials = null;
				this.m_Textures = null;
				this.Render();
			}
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000DACC File Offset: 0x0000BCCC
		public void Show3D(Bitmap bitmap)
		{
			try
			{
				Texture texture = new Texture(this.m_Device, bitmap, 1, 1);
				for (int i = 0; i < this.m_Textures.Length; i++)
				{
					this.m_Textures[i] = texture;
				}
				this.Render();
			}
			catch (DirectXException)
			{
				this.m_Materials = null;
				this.m_Textures = null;
				this.Render();
			}
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000DB34 File Offset: 0x0000BD34
		private void OnResetDevice(object sender, EventArgs e)
		{
			this.m_Device.RenderState.ZBufferEnable = true;
			this.m_Device.RenderState.ZBufferFunction = 2;
			this.m_Device.RenderState.ZBufferWriteEnable = true;
			this.m_Device.RenderState.AlphaBlendEnable = true;
			this.m_Device.RenderState.AlphaTestEnable = false;
			this.m_Device.RenderState.AlphaFunction = 8;
			this.m_Device.RenderState.BlendOperation = 1;
			this.m_Device.RenderState.SourceBlend = 5;
			this.m_Device.RenderState.DestinationBlend = 6;
			this.m_Device.RenderState.AlphaBlendOperation = 5;
			this.m_Device.RenderState.AlphaSourceBlend = 2;
			this.m_Device.RenderState.AlphaDestinationBlend = 2;
			this.m_Device.RenderState.StencilEnable = false;
			this.m_Device.RenderState.FillMode = 3;
			this.m_Device.RenderState.CullMode = 1;
			this.m_Device.RenderState.SpecularEnable = false;
			this.m_Device.RenderState.SpecularMaterialSource = 0;
			this.m_Device.RenderState.Ambient = this.m_AmbientColor;
			this.m_Device.Lights[0].Type = 3;
			this.m_Device.Lights[0].Position = new Vector3(this.m_LightX, this.m_LightY, this.m_LightZ);
			this.m_Device.Lights[0].Diffuse = Color.White;
			this.m_Device.Lights[0].Direction = new Vector3(this.m_LightDirectionX, this.m_LightDirectionY, this.m_LightDirectionZ);
			this.m_Device.Lights[0].Enabled = true;
			this.m_Device.RenderState.Lighting = true;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000DD2C File Offset: 0x0000BF2C
		private void SetupMatrices()
		{
			this.m_Device.Transform.World = Matrix.RotationYawPitchRoll(this.m_RotationY, this.m_RotationX, 0f);
			this.m_Device.Transform.View = Matrix.LookAtLH(new Vector3(this.m_ViewX, this.m_ViewY, this.m_ViewZ), new Vector3(this.m_ViewX, this.m_ViewY, 0f), new Vector3(0f, 1f, 0f));
			float num = (float)base.Width / (float)base.Height;
			this.m_Device.Transform.Projection = Matrix.PerspectiveFovLH(0.7853982f, num, 1f, 1000f);
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000DDEC File Offset: 0x0000BFEC
		public void Render()
		{
			if (this.m_Device == null)
			{
				return;
			}
			if (this.pause)
			{
				return;
			}
			try
			{
				this.m_Device.Clear(3, Color.Gray, 1f, 0);
				this.m_Device.Lights[0].Type = 3;
				this.m_Device.Lights[0].Position = new Vector3(this.m_LightX, this.m_LightY, this.m_LightZ);
				this.m_Device.Lights[0].Diffuse = Color.White;
				this.m_Device.Lights[0].Direction = new Vector3(this.m_LightDirectionX, this.m_LightDirectionY, this.m_LightDirectionZ);
				this.m_Device.Lights[0].Enabled = true;
				this.m_Device.RenderState.Ambient = this.m_AmbientColor;
				this.m_Device.BeginScene();
				this.SetupMatrices();
				if (this.m_XFileMesh != null && this.m_Materials != null)
				{
					this.m_Device.RenderState.ZBufferWriteEnable = true;
					for (int i = 0; i < this.m_Materials.Length; i++)
					{
						int num = i;
						this.m_Device.Material = this.m_Materials[num];
						this.m_Device.SetTexture(0, this.m_Textures[num]);
						if (this.m_Materials.Length == 6 && (i == 4 || i == 5))
						{
							this.m_Device.RenderState.ZBufferWriteEnable = false;
						}
						this.m_XFileMesh.DrawSubset(num);
					}
				}
				if (this.m_Meshes != null && this.m_Materials != null)
				{
					for (int j = 0; j < this.m_Meshes.Length; j++)
					{
						this.m_Device.RenderState.ZBufferWriteEnable = this.m_ZbufferRenderState[j];
						if (this.m_Meshes[j] != null)
						{
							this.m_Device.Material = this.m_Materials[j];
							this.m_Device.SetTexture(0, this.m_Textures[j]);
							this.m_Meshes[j].DrawSubset(0);
						}
					}
				}
				this.m_Device.EndScene();
				this.m_Device.Present();
			}
			catch (DirectXException)
			{
			}
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000E058 File Offset: 0x0000C258
		private void Viewer3D_MouseDown(object sender, MouseEventArgs e)
		{
			MouseButtons button = e.Button;
			if (button != MouseButtons.Left)
			{
				if (button != MouseButtons.Right)
				{
					if (button == MouseButtons.Middle)
					{
						this.m_MouseState = 4;
						this.m_MouseX = e.X;
						this.m_MouseY = e.Y;
					}
				}
				else
				{
					this.m_MouseState = 2;
					this.m_MouseX = e.X;
					this.m_MouseY = e.Y;
				}
			}
			else
			{
				this.m_MouseState = 1;
				this.m_MouseX = e.X;
				this.m_MouseY = e.Y;
			}
			this.Render();
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000E0ED File Offset: 0x0000C2ED
		private void Viewer3D_MouseUp(object sender, MouseEventArgs e)
		{
			this.m_MouseState = 0;
		}

		// Token: 0x06000109 RID: 265 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		private void Viewer3D_MouseMove(object sender, MouseEventArgs e)
		{
			if (this.m_MouseState == 0)
			{
				int delta = e.Delta;
				return;
			}
			bool flag = false;
			switch (this.m_MouseState)
			{
			case 0:
				return;
			case 1:
			{
				int num = e.X - this.m_MouseX;
				int num2 = e.Y - this.m_MouseY;
				this.m_RotationY -= (float)num * 0.01f;
				while (this.m_RotationY < 0f)
				{
					this.m_RotationY += 6.28f;
				}
				while (this.m_RotationY > 6.28f)
				{
					this.m_RotationY -= 6.28f;
				}
				this.m_RotationX += (float)num2 * this.m_RotationYCoeff;
				while (this.m_RotationX < 0f)
				{
					this.m_RotationX += 6.28f;
				}
				while (this.m_RotationX > 6.28f)
				{
					this.m_RotationX -= 6.28f;
				}
				flag = true;
				break;
			}
			case 2:
			{
				int num = e.X - this.m_MouseX;
				int num2 = e.Y - this.m_MouseY;
				this.m_ViewZ -= (float)num2 * 0.2f;
				if (this.m_ViewZ < -1000f)
				{
					this.m_ViewZ = -1000f;
				}
				if (this.m_ViewZ > 1000f)
				{
					this.m_ViewZ = 1000f;
				}
				flag = true;
				break;
			}
			case 4:
			{
				int num = e.X - this.m_MouseX;
				int num2 = e.Y - this.m_MouseY;
				this.m_ViewX += (float)num * 0.2f;
				if (this.m_ViewX < -1000f)
				{
					this.m_ViewX = -1000f;
				}
				if (this.m_ViewX > 1000f)
				{
					this.m_ViewX = 1000f;
				}
				this.m_ViewY += (float)num2 * 0.2f;
				if (this.m_ViewY < -1000f)
				{
					this.m_ViewY = -1000f;
				}
				if (this.m_ViewY > 1000f)
				{
					this.m_ViewY = 1000f;
				}
				flag = true;
				break;
			}
			}
			this.m_MouseX = e.X;
			this.m_MouseY = e.Y;
			if (flag)
			{
				this.Render();
			}
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000E344 File Offset: 0x0000C544
		private void Viewer3D_DoubleClick(object sender, EventArgs e)
		{
			this.m_RotationY = this.m_StartRotationY;
			this.m_RotationX = this.m_StartRotationX;
			this.m_ViewX = this.m_StartViewX;
			this.m_ViewY = this.m_StartViewY;
			this.m_ViewZ = this.m_StartViewZ;
			this.Render();
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000E394 File Offset: 0x0000C594
		public Bitmap Photo()
		{
			Bitmap bitmap2;
			try
			{
				Surface backBuffer = this.m_Device.GetBackBuffer(0, 0, 0);
				Bitmap bitmap = new Bitmap(SurfaceLoader.SaveToStream(0, backBuffer));
				backBuffer.Dispose();
				bitmap2 = bitmap;
			}
			catch
			{
				bitmap2 = null;
			}
			return bitmap2;
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000E3E0 File Offset: 0x0000C5E0
		public void Clean(int nMeshes)
		{
			if (this.m_XFileMesh != null)
			{
				this.m_XFileMesh.Dispose();
				this.m_XFileMesh = null;
			}
			if (this.m_Textures != null)
			{
				for (int i = 0; i < this.m_Textures.Length; i++)
				{
					if (this.m_Textures[i] != null)
					{
						this.m_Textures[i].Dispose();
					}
				}
				this.m_Textures = null;
			}
			if (this.m_Meshes != null)
			{
				for (int j = 0; j < this.m_Meshes.Length; j++)
				{
					if (this.m_Meshes[j] != null)
					{
						this.m_Meshes[j].Dispose();
					}
				}
			}
			this.m_Meshes = new Mesh[nMeshes];
			if (nMeshes != 0)
			{
				this.m_Textures = new Texture[nMeshes];
				this.m_Materials = new Material[nMeshes];
				this.m_ZbufferRenderState = new bool[nMeshes];
				for (int k = 0; k < nMeshes; k++)
				{
					this.m_ZbufferRenderState[k] = true;
					this.m_Materials[k].Ambient = Color.FromArgb(0, 255, 255, 255);
					this.m_Materials[k].Diffuse = Color.FromArgb(0, 255, 255, 255);
					this.m_Materials[k].Specular = Color.FromArgb(0, 255, 255, 255);
				}
			}
			this.CleanBoundingBox();
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000E54A File Offset: 0x0000C74A
		public void SetMesh(int meshIndex, Model3D model3D)
		{
			this.SetMesh(meshIndex, model3D, true);
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000E558 File Offset: 0x0000C758
		public void SetMesh(int meshIndex, Model3D model3D, bool zBufferState)
		{
			try
			{
				this.UpdateBoundingBox(model3D.Vertex);
				this.m_Meshes[meshIndex] = new Mesh(model3D.NFaces, model3D.NVertex, 544, 274, this.m_Device);
				this.m_Meshes[meshIndex].SetIndexBufferData(model3D.Index, 0);
				this.m_Meshes[meshIndex].SetVertexBufferData(model3D.Vertex, 0);
				Texture texture = Texture.FromBitmap(this.m_Device, model3D.TextureBitmap, 0, 1);
				this.m_Textures[meshIndex] = texture;
				this.m_ZbufferRenderState[meshIndex] = zBufferState;
			}
			catch
			{
			}
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000E600 File Offset: 0x0000C800
		private void UpdateBoundingBox(CustomVertex.PositionNormalTextured[] Vertex)
		{
			for (int i = 0; i < Vertex.Length; i++)
			{
				if (Vertex[i].X < this.m_MinX)
				{
					this.m_MinX = Vertex[i].X;
				}
				if (Vertex[i].X > this.m_MaxX)
				{
					this.m_MaxX = Vertex[i].X;
				}
				if (Vertex[i].Y < this.m_MinY)
				{
					this.m_MinY = Vertex[i].Y;
				}
				if (Vertex[i].Y > this.m_MaxY)
				{
					this.m_MaxY = Vertex[i].Y;
				}
				if (Vertex[i].Z < this.m_MinZ)
				{
					this.m_MinZ = Vertex[i].Z;
				}
				if (Vertex[i].Z > this.m_MaxZ)
				{
					this.m_MaxZ = Vertex[i].Z;
				}
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000E708 File Offset: 0x0000C908
		private void CleanBoundingBox()
		{
			this.m_MinX = float.MaxValue;
			this.m_MinY = float.MaxValue;
			this.m_MinZ = float.MaxValue;
			this.m_MaxX = float.MinValue;
			this.m_MaxY = float.MinValue;
			this.m_MaxZ = float.MinValue;
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000E758 File Offset: 0x0000C958
		private void AutoView()
		{
			this.m_ViewX = (this.m_MinX + this.m_MaxX) / 2f;
			this.m_ViewY = (this.m_MinY + this.m_MaxY) / 2f;
			this.m_ViewZ = this.m_MaxZ * 3f;
		}

		// Token: 0x0400010F RID: 271
		private IContainer components;

		// Token: 0x04000110 RID: 272
		private Device m_Device;

		// Token: 0x04000111 RID: 273
		private PresentParameters m_PresentParams = new PresentParameters();

		// Token: 0x04000112 RID: 274
		private Mesh m_XFileMesh;

		// Token: 0x04000113 RID: 275
		private Mesh[] m_Meshes;

		// Token: 0x04000114 RID: 276
		private Texture[] m_Textures;

		// Token: 0x04000115 RID: 277
		private Material[] m_Materials;

		// Token: 0x04000116 RID: 278
		private ExtendedMaterial[] m_ExtendedMaterials;

		// Token: 0x04000117 RID: 279
		private bool[] m_ZbufferRenderState;

		// Token: 0x04000118 RID: 280
		private bool pause;

		// Token: 0x04000119 RID: 281
		private int m_MouseState;

		// Token: 0x0400011A RID: 282
		private float m_RotationY;

		// Token: 0x0400011B RID: 283
		private float m_RotationX;

		// Token: 0x0400011C RID: 284
		private float m_ViewX;

		// Token: 0x0400011D RID: 285
		private float m_ViewY = 100f;

		// Token: 0x0400011E RID: 286
		private float m_ViewZ = 100f;

		// Token: 0x0400011F RID: 287
		private float m_LightDirectionX;

		// Token: 0x04000120 RID: 288
		private float m_LightDirectionY;

		// Token: 0x04000121 RID: 289
		private float m_LightDirectionZ;

		// Token: 0x04000122 RID: 290
		private float m_StartViewX;

		// Token: 0x04000123 RID: 291
		private float m_StartViewY = 100f;

		// Token: 0x04000124 RID: 292
		private float m_StartViewZ = 100f;

		// Token: 0x04000125 RID: 293
		private float m_StartRotationY;

		// Token: 0x04000126 RID: 294
		private float m_StartRotationX;

		// Token: 0x04000127 RID: 295
		private float m_LightX;

		// Token: 0x04000128 RID: 296
		private float m_LightY = 100f;

		// Token: 0x04000129 RID: 297
		private float m_LightZ = 100f;

		// Token: 0x0400012A RID: 298
		private float m_MinX;

		// Token: 0x0400012B RID: 299
		private float m_MinY;

		// Token: 0x0400012C RID: 300
		private float m_MinZ;

		// Token: 0x0400012D RID: 301
		private float m_MaxX;

		// Token: 0x0400012E RID: 302
		private float m_MaxY;

		// Token: 0x0400012F RID: 303
		private float m_MaxZ;

		// Token: 0x04000130 RID: 304
		private float m_RotationYCoeff = 0.01f;

		// Token: 0x04000131 RID: 305
		private string m_XFileName;

		// Token: 0x04000132 RID: 306
		private string m_XFilePath;

		// Token: 0x04000133 RID: 307
		private Color m_AmbientColor;

		// Token: 0x04000134 RID: 308
		private int m_MouseX;

		// Token: 0x04000135 RID: 309
		private int m_MouseY;
	}
}
