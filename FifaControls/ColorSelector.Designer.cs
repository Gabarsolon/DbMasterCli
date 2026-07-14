namespace FifaControls
{
	// Token: 0x02000029 RID: 41
	public partial class ColorSelector : global::System.Windows.Forms.Form
	{
		// Token: 0x06000198 RID: 408 RVA: 0x00011C32 File Offset: 0x0000FE32
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000199 RID: 409 RVA: 0x00011C54 File Offset: 0x0000FE54
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FifaControls.ColorSelector));
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.pictureSelectedColor = new global::System.Windows.Forms.PictureBox();
			this.pictureBoxHidden = new global::System.Windows.Forms.PictureBox();
			((global::System.ComponentModel.ISupportInitialize)this.pictureSelectedColor).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxHidden).BeginInit();
			base.SuspendLayout();
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			componentResourceManager.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.Name = "buttonOK";
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.ForeColor = global::System.Drawing.SystemColors.ControlText;
			componentResourceManager.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.Name = "buttonCancel";
			this.pictureSelectedColor.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			componentResourceManager.ApplyResources(this.pictureSelectedColor, "pictureSelectedColor");
			this.pictureSelectedColor.Name = "pictureSelectedColor";
			this.pictureSelectedColor.TabStop = false;
			componentResourceManager.ApplyResources(this.pictureBoxHidden, "pictureBoxHidden");
			this.pictureBoxHidden.BorderStyle = global::System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBoxHidden.Name = "pictureBoxHidden";
			this.pictureBoxHidden.TabStop = false;
			base.AcceptButton = this.buttonOK;
			componentResourceManager.ApplyResources(this, "$this");
			base.CancelButton = this.buttonCancel;
			base.Controls.Add(this.pictureBoxHidden);
			base.Controls.Add(this.pictureSelectedColor);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOK);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "ColorSelector";
			((global::System.ComponentModel.ISupportInitialize)this.pictureSelectedColor).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBoxHidden).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x04000197 RID: 407
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x04000198 RID: 408
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x04000199 RID: 409
		private global::System.Windows.Forms.PictureBox pictureSelectedColor;

		// Token: 0x0400019A RID: 410
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400019E RID: 414
		private global::System.Windows.Forms.PictureBox pictureBoxHidden;
	}
}
