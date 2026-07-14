namespace FifaControls
{
	// Token: 0x02000028 RID: 40
	public partial class CmsBrowser : global::System.Windows.Forms.Form
	{
		// Token: 0x0600018D RID: 397 RVA: 0x00011583 File Offset: 0x0000F783
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600018E RID: 398 RVA: 0x000115A4 File Offset: 0x0000F7A4
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FifaControls.CmsBrowser));
			this.panelBottom = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.treeViewCms = new global::System.Windows.Forms.TreeView();
			this.panelBottom.SuspendLayout();
			base.SuspendLayout();
			this.panelBottom.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("panelBottom.BackgroundImage");
			this.panelBottom.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			this.panelBottom.Controls.Add(this.button1);
			this.panelBottom.Controls.Add(this.buttonOK);
			this.panelBottom.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panelBottom.Location = new global::System.Drawing.Point(0, 337);
			this.panelBottom.Name = "panelBottom";
			this.panelBottom.Size = new global::System.Drawing.Size(285, 34);
			this.panelBottom.TabIndex = 6;
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new global::System.Drawing.Point(169, 8);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(39, 8);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 4;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.treeViewCms.Dock = global::System.Windows.Forms.DockStyle.Fill;
			this.treeViewCms.Location = new global::System.Drawing.Point(0, 0);
			this.treeViewCms.Name = "treeViewCms";
			this.treeViewCms.Size = new global::System.Drawing.Size(285, 337);
			this.treeViewCms.TabIndex = 7;
			this.treeViewCms.DoubleClick += new global::System.EventHandler(this.treeViewCms_DoubleClick);
			this.treeViewCms.AfterSelect += new global::System.Windows.Forms.TreeViewEventHandler(this.treeViewCms_AfterSelect);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(285, 371);
			base.Controls.Add(this.treeViewCms);
			base.Controls.Add(this.panelBottom);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Name = "CmsBrowser";
			this.Text = "CmsBrowser";
			this.panelBottom.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400018E RID: 398
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400018F RID: 399
		private global::System.Windows.Forms.Panel panelBottom;

		// Token: 0x04000190 RID: 400
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000191 RID: 401
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x04000192 RID: 402
		private global::System.Windows.Forms.TreeView treeViewCms;
	}
}
