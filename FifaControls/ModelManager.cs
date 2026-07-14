using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x0200001A RID: 26
	public class ModelManager : UserControl
	{
		// Token: 0x0600011F RID: 287 RVA: 0x0000EE0C File Offset: 0x0000D00C
		public ModelManager()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000EE1A File Offset: 0x0000D01A
		private void buttonShow_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000EE1C File Offset: 0x0000D01C
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000EE3C File Offset: 0x0000D03C
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(ModelManager));
			this.toolStrip1 = new ToolStrip();
			this.buttonShow = new ToolStripButton();
			this.buttonImport = new ToolStripButton();
			this.buttonExport = new ToolStripButton();
			this.buttonRemove = new ToolStripButton();
			this.viewer = new Viewer3D();
			this.toolStrip1.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip1.Dock = DockStyle.Bottom;
			this.toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip1.Items.AddRange(new ToolStripItem[] { this.buttonShow, this.buttonImport, this.buttonExport, this.buttonRemove });
			this.toolStrip1.Location = new Point(0, 285);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new Size(324, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip";
			this.buttonShow.Checked = true;
			this.buttonShow.CheckOnClick = true;
			this.buttonShow.CheckState = CheckState.Checked;
			this.buttonShow.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonShow.Image = (Image)componentResourceManager.GetObject("buttonShow.Image");
			this.buttonShow.ImageTransparentColor = Color.Magenta;
			this.buttonShow.Name = "buttonShow";
			this.buttonShow.Size = new Size(23, 22);
			this.buttonShow.Text = "Show / Hide";
			this.buttonShow.Click += this.buttonShow_Click;
			this.buttonImport.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonImport.Image = (Image)componentResourceManager.GetObject("buttonImport.Image");
			this.buttonImport.ImageTransparentColor = Color.Magenta;
			this.buttonImport.Name = "buttonImport";
			this.buttonImport.Size = new Size(23, 22);
			this.buttonImport.Text = "Import 3D Model";
			this.buttonExport.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonExport.Image = (Image)componentResourceManager.GetObject("buttonExport.Image");
			this.buttonExport.ImageTransparentColor = Color.Magenta;
			this.buttonExport.Name = "buttonExport";
			this.buttonExport.Size = new Size(23, 22);
			this.buttonExport.Text = "Export 3D Model";
			this.buttonRemove.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonRemove.Image = (Image)componentResourceManager.GetObject("buttonRemove.Image");
			this.buttonRemove.ImageTransparentColor = Color.Magenta;
			this.buttonRemove.Name = "buttonRemove";
			this.buttonRemove.Size = new Size(23, 22);
			this.buttonRemove.Text = "Remove 3D Model";
			this.viewer.BackColor = Color.Gray;
			this.viewer.BorderStyle = BorderStyle.Fixed3D;
			this.viewer.Dock = DockStyle.Fill;
			this.viewer.LightDirectionZ = 0f;
			this.viewer.LightX = 0f;
			this.viewer.LightY = 100f;
			this.viewer.LightZ = 100f;
			this.viewer.Location = new Point(0, 0);
			this.viewer.Name = "viewer";
			this.viewer.RotationX = 0f;
			this.viewer.RotationY = 0f;
			this.viewer.Size = new Size(324, 285);
			this.viewer.TabIndex = 1;
			this.viewer.ViewX = 0f;
			this.viewer.ViewY = 100f;
			this.viewer.ViewZ = 100f;
			this.viewer.ZbufferRenderState = null;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.viewer);
			base.Controls.Add(this.toolStrip1);
			base.Name = "ModelManager";
			base.Size = new Size(324, 310);
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000143 RID: 323
		private IContainer components;

		// Token: 0x04000144 RID: 324
		private ToolStrip toolStrip1;

		// Token: 0x04000145 RID: 325
		public Viewer3D viewer;

		// Token: 0x04000146 RID: 326
		public ToolStripButton buttonShow;

		// Token: 0x04000147 RID: 327
		public ToolStripButton buttonImport;

		// Token: 0x04000148 RID: 328
		public ToolStripButton buttonExport;

		// Token: 0x04000149 RID: 329
		public ToolStripButton buttonRemove;

		// Token: 0x0200001B RID: 27
		// (Invoke) Token: 0x06000124 RID: 292
		public delegate bool ModelExportHandler(object sender, string rx3FileName);

		// Token: 0x0200001C RID: 28
		// (Invoke) Token: 0x06000128 RID: 296
		public delegate bool ModelImportHandler(object sender, string rx3FileName);

		// Token: 0x0200001D RID: 29
		// (Invoke) Token: 0x0600012C RID: 300
		public delegate bool ModelDeleteHandler(object sender, string rx3FileName);
	}
}
