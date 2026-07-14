using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000007 RID: 7
	public class WeatherSelector : UserControl
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000044 RID: 68 RVA: 0x00004103 File Offset: 0x00002303
		// (set) Token: 0x06000045 RID: 69 RVA: 0x00004110 File Offset: 0x00002310
		[Description("Header")]
		[Category("User")]
		public string Header
		{
			get
			{
				return this.labelText.Text;
			}
			set
			{
				this.labelText.Text = value;
				if (this.labelText.Text == "Jan")
				{
					this.month = 0;
					return;
				}
				if (this.labelText.Text == "Feb")
				{
					this.month = 1;
					return;
				}
				if (this.labelText.Text == "Mar")
				{
					this.month = 2;
					return;
				}
				if (this.labelText.Text == "Apr")
				{
					this.month = 3;
					return;
				}
				if (this.labelText.Text == "May")
				{
					this.month = 4;
					return;
				}
				if (this.labelText.Text == "Jun")
				{
					this.month = 5;
					return;
				}
				if (this.labelText.Text == "Jul")
				{
					this.month = 6;
					return;
				}
				if (this.labelText.Text == "Aug")
				{
					this.month = 7;
					return;
				}
				if (this.labelText.Text == "Sep")
				{
					this.month = 8;
					return;
				}
				if (this.labelText.Text == "Oct")
				{
					this.month = 9;
					return;
				}
				if (this.labelText.Text == "Nov")
				{
					this.month = 10;
					return;
				}
				if (this.labelText.Text == "Dec")
				{
					this.month = 11;
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x0000429F File Offset: 0x0000249F
		public WeatherSelector()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x000042B4 File Offset: 0x000024B4
		private void label1_Click(object sender, EventArgs e)
		{
			MouseEventArgs mouseEventArgs = (MouseEventArgs)e;
			if (mouseEventArgs.Button == MouseButtons.Left)
			{
				if (this.labelPicture.ImageIndex < 4)
				{
					this.labelPicture.ImageIndex++;
				}
				else
				{
					this.labelPicture.ImageIndex = 0;
				}
			}
			else if (this.labelPicture.ImageIndex > 0)
			{
				this.labelPicture.ImageIndex--;
			}
			else
			{
				this.labelPicture.ImageIndex = 4;
			}
			if (this.ValueChanged != null)
			{
				this.ValueChanged(this, this.Value, this.month);
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000048 RID: 72 RVA: 0x00004355 File Offset: 0x00002555
		// (set) Token: 0x06000049 RID: 73 RVA: 0x00004362 File Offset: 0x00002562
		public int Value
		{
			get
			{
				return this.labelPicture.ImageIndex;
			}
			set
			{
				if (value < 0)
				{
					this.labelPicture.ImageIndex = 0;
					return;
				}
				if (value > 4)
				{
					this.labelPicture.ImageIndex = 4;
					return;
				}
				this.labelPicture.ImageIndex = value;
			}
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00004392 File Offset: 0x00002592
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x000043B4 File Offset: 0x000025B4
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(WeatherSelector));
			this.labelPicture = new Label();
			this.imageListWeather = new ImageList(this.components);
			this.labelText = new Label();
			base.SuspendLayout();
			this.labelPicture.BorderStyle = BorderStyle.Fixed3D;
			this.labelPicture.Dock = DockStyle.Bottom;
			this.labelPicture.ImageIndex = 0;
			this.labelPicture.ImageList = this.imageListWeather;
			this.labelPicture.Location = new Point(0, 15);
			this.labelPicture.Name = "labelPicture";
			this.labelPicture.Size = new Size(40, 30);
			this.labelPicture.TabIndex = 2;
			this.labelPicture.Click += this.label1_Click;
			this.imageListWeather.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageListWeather.ImageStream");
			this.imageListWeather.TransparentColor = Color.Transparent;
			this.imageListWeather.Images.SetKeyName(0, "Weather_0.PNG");
			this.imageListWeather.Images.SetKeyName(1, "Weather_1.PNG");
			this.imageListWeather.Images.SetKeyName(2, "Weather_2.PNG");
			this.imageListWeather.Images.SetKeyName(3, "Weather_3.PNG");
			this.imageListWeather.Images.SetKeyName(4, "Weather_4.PNG");
			this.labelText.BorderStyle = BorderStyle.FixedSingle;
			this.labelText.Dock = DockStyle.Top;
			this.labelText.Location = new Point(0, 0);
			this.labelText.Name = "labelText";
			this.labelText.Size = new Size(40, 15);
			this.labelText.TabIndex = 3;
			this.labelText.Text = "TEX";
			this.labelText.TextAlign = ContentAlignment.MiddleCenter;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.labelPicture);
			base.Controls.Add(this.labelText);
			base.Name = "WeatherSelector";
			base.Size = new Size(40, 45);
			base.ResumeLayout(false);
		}

		// Token: 0x04000047 RID: 71
		private int month = -1;

		// Token: 0x04000048 RID: 72
		public WeatherSelector.WeatherEventHandler ValueChanged;

		// Token: 0x04000049 RID: 73
		private IContainer components;

		// Token: 0x0400004A RID: 74
		private Label labelPicture;

		// Token: 0x0400004B RID: 75
		private ImageList imageListWeather;

		// Token: 0x0400004C RID: 76
		public Label labelText;

		// Token: 0x02000008 RID: 8
		// (Invoke) Token: 0x0600004D RID: 77
		public delegate void WeatherEventHandler(object sender, int value, int month);
	}
}
