using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000013 RID: 19
	public class NumericStars : UserControl
	{
		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000BD41 File Offset: 0x00009F41
		// (set) Token: 0x060000BD RID: 189 RVA: 0x0000BD53 File Offset: 0x00009F53
		[Description("Value")]
		[Category("User")]
		public int Value
		{
			get
			{
				return (int)this.numericUpDown.Value;
			}
			set
			{
				this.numericUpDown.Value = value;
			}
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000BD66 File Offset: 0x00009F66
		public NumericStars()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000BD74 File Offset: 0x00009F74
		private void numericUpDown_ValueChanged(object sender, EventArgs e)
		{
			int num = (int)this.numericUpDown.Value;
			int num2 = ((num >= 2) ? ((num - 2) / 2) : 0);
			this.label.ImageIndex = num2;
			if (this.ValueChanged != null)
			{
				this.ValueChanged(this, num);
			}
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000BDC0 File Offset: 0x00009FC0
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000BDE0 File Offset: 0x00009FE0
		private void InitializeComponent()
		{
			this.components = new Container();
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(NumericStars));
			this.numericUpDown = new NumericUpDown();
			this.label = new Label();
			this.imageList = new ImageList(this.components);
			((ISupportInitialize)this.numericUpDown).BeginInit();
			base.SuspendLayout();
			this.numericUpDown.Location = new Point(0, 0);
			NumericUpDown numericUpDown = this.numericUpDown;
			int[] array = new int[4];
			array[0] = 20;
			numericUpDown.Maximum = new decimal(array);
			this.numericUpDown.Name = "numericUpDown";
			this.numericUpDown.Size = new Size(66, 20);
			this.numericUpDown.TabIndex = 0;
			this.numericUpDown.TextAlign = HorizontalAlignment.Center;
			this.numericUpDown.ValueChanged += this.numericUpDown_ValueChanged;
			this.label.ImageIndex = 0;
			this.label.ImageList = this.imageList;
			this.label.Location = new Point(70, 2);
			this.label.Name = "label";
			this.label.Size = new Size(93, 17);
			this.label.TabIndex = 1;
			this.imageList.ImageStream = (ImageListStreamer)componentResourceManager.GetObject("imageList.ImageStream");
			this.imageList.TransparentColor = Color.Fuchsia;
			this.imageList.Images.SetKeyName(0, "Stars_0_5.PNG");
			this.imageList.Images.SetKeyName(1, "Stars_1.PNG");
			this.imageList.Images.SetKeyName(2, "Stars_1_5.PNG");
			this.imageList.Images.SetKeyName(3, "Stars_2.PNG");
			this.imageList.Images.SetKeyName(4, "Stars_2_5.PNG");
			this.imageList.Images.SetKeyName(5, "Stars_3.PNG");
			this.imageList.Images.SetKeyName(6, "Stars_3_5.PNG");
			this.imageList.Images.SetKeyName(7, "Stars_4.PNG");
			this.imageList.Images.SetKeyName(8, "Stars_4_5.PNG");
			this.imageList.Images.SetKeyName(9, "Stars_5.PNG");
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.Transparent;
			base.Controls.Add(this.label);
			base.Controls.Add(this.numericUpDown);
			base.Name = "NumericStars";
			base.Size = new Size(167, 20);
			((ISupportInitialize)this.numericUpDown).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x040000F0 RID: 240
		public NumericStars.StarsEventHandler ValueChanged;

		// Token: 0x040000F1 RID: 241
		private IContainer components;

		// Token: 0x040000F2 RID: 242
		private Label label;

		// Token: 0x040000F3 RID: 243
		private ImageList imageList;

		// Token: 0x040000F4 RID: 244
		public NumericUpDown numericUpDown;

		// Token: 0x02000014 RID: 20
		// (Invoke) Token: 0x060000C3 RID: 195
		public delegate void StarsEventHandler(object sender, int value);
	}
}
