namespace FifaControls
{
	// Token: 0x02000017 RID: 23
	public partial class AboutForm : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D6 RID: 214 RVA: 0x0000CCD6 File Offset: 0x0000AED6
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000CCF8 File Offset: 0x0000AEF8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FifaControls.AboutForm));
			this.pictureBox = new global::System.Windows.Forms.PictureBox();
			this.labelProduct = new global::System.Windows.Forms.Label();
			this.labelRelease = new global::System.Windows.Forms.Label();
			this.linkFifaMaster = new global::System.Windows.Forms.LinkLabel();
			this.buttonCountinue = new global::System.Windows.Forms.Button();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.linkLabel2 = new global::System.Windows.Forms.LinkLabel();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).BeginInit();
			base.SuspendLayout();
			this.pictureBox.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox.BackgroundImage");
			this.pictureBox.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Center;
			this.pictureBox.Dock = global::System.Windows.Forms.DockStyle.Top;
			this.pictureBox.Location = new global::System.Drawing.Point(0, 0);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new global::System.Drawing.Size(502, 97);
			this.pictureBox.TabIndex = 0;
			this.pictureBox.TabStop = false;
			this.labelProduct.AutoSize = true;
			this.labelProduct.BackColor = global::System.Drawing.Color.Transparent;
			this.labelProduct.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelProduct.Location = new global::System.Drawing.Point(11, 118);
			this.labelProduct.Name = "labelProduct";
			this.labelProduct.Size = new global::System.Drawing.Size(110, 20);
			this.labelProduct.TabIndex = 1;
			this.labelProduct.Text = "Product Name";
			this.labelRelease.AutoSize = true;
			this.labelRelease.BackColor = global::System.Drawing.Color.Transparent;
			this.labelRelease.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelRelease.Location = new global::System.Drawing.Point(12, 148);
			this.labelRelease.Name = "labelRelease";
			this.labelRelease.Size = new global::System.Drawing.Size(68, 20);
			this.labelRelease.TabIndex = 2;
			this.labelRelease.Text = "Release";
			this.linkFifaMaster.AutoSize = true;
			this.linkFifaMaster.BackColor = global::System.Drawing.Color.Transparent;
			this.linkFifaMaster.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkFifaMaster.Location = new global::System.Drawing.Point(164, 370);
			this.linkFifaMaster.Name = "linkFifaMaster";
			this.linkFifaMaster.Size = new global::System.Drawing.Size(177, 20);
			this.linkFifaMaster.TabIndex = 3;
			this.linkFifaMaster.TabStop = true;
			this.linkFifaMaster.Text = "Fifa Master Home Page";
			this.linkFifaMaster.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkFifaMaster_LinkClicked);
			this.buttonCountinue.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonCountinue.Location = new global::System.Drawing.Point(211, 403);
			this.buttonCountinue.Name = "buttonCountinue";
			this.buttonCountinue.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCountinue.TabIndex = 4;
			this.buttonCountinue.Text = "Continue";
			this.buttonCountinue.UseVisualStyleBackColor = true;
			this.label2.BackColor = global::System.Drawing.Color.Transparent;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Teal;
			this.label2.Location = new global::System.Drawing.Point(13, 180);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(478, 84);
			this.label2.TabIndex = 6;
			this.label2.Text = componentResourceManager.GetString("label2.Text");
			this.label1.BackColor = global::System.Drawing.Color.Transparent;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Teal;
			this.label1.Location = new global::System.Drawing.Point(13, 296);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(478, 74);
			this.label1.TabIndex = 7;
			this.label1.Text = componentResourceManager.GetString("label1.Text");
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.BackColor = global::System.Drawing.Color.Transparent;
			this.linkLabel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabel1.Location = new global::System.Drawing.Point(87, 264);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(48, 20);
			this.linkLabel1.TabIndex = 8;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "ABIO";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.BackColor = global::System.Drawing.Color.Transparent;
			this.linkLabel2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabel2.Location = new global::System.Drawing.Point(327, 264);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new global::System.Drawing.Size(69, 20);
			this.linkLabel2.TabIndex = 9;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "UNICEF";
			this.linkLabel2.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(502, 438);
			base.Controls.Add(this.linkLabel2);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.buttonCountinue);
			base.Controls.Add(this.linkFifaMaster);
			base.Controls.Add(this.labelRelease);
			base.Controls.Add(this.labelProduct);
			base.Controls.Add(this.pictureBox);
			base.Controls.Add(this.label1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedSingle;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.MinimizeBox = false;
			base.Name = "AboutForm";
			this.Text = " About Info";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000105 RID: 261
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000106 RID: 262
		public global::System.Windows.Forms.PictureBox pictureBox;

		// Token: 0x04000107 RID: 263
		public global::System.Windows.Forms.Label labelProduct;

		// Token: 0x04000108 RID: 264
		public global::System.Windows.Forms.Label labelRelease;

		// Token: 0x04000109 RID: 265
		private global::System.Windows.Forms.LinkLabel linkFifaMaster;

		// Token: 0x0400010A RID: 266
		private global::System.Windows.Forms.Button buttonCountinue;

		// Token: 0x0400010B RID: 267
		public global::System.Windows.Forms.Label label2;

		// Token: 0x0400010C RID: 268
		public global::System.Windows.Forms.Label label1;

		// Token: 0x0400010D RID: 269
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x0400010E RID: 270
		private global::System.Windows.Forms.LinkLabel linkLabel2;
	}
}
