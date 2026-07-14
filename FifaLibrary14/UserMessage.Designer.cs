namespace FifaLibrary
{
	// Token: 0x0200001C RID: 28
	public partial class UserMessage : global::System.Windows.Forms.Form
	{
		// Token: 0x060001BD RID: 445 RVA: 0x0000F10E File Offset: 0x0000D30E
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x0000F130 File Offset: 0x0000D330
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FifaLibrary.UserMessage));
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.textMessage = new global::System.Windows.Forms.TextBox();
			this.checkSuppressMessage = new global::System.Windows.Forms.CheckBox();
			this.textErrorNumber = new global::System.Windows.Forms.TextBox();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonNo = new global::System.Windows.Forms.Button();
			this.buttonYes = new global::System.Windows.Forms.Button();
			this.pictureBox = new global::System.Windows.Forms.PictureBox();
			this.imageList = new global::System.Windows.Forms.ImageList(this.components);
			this.setMessages = new global::FifaLibrary.Messages();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.setMessages).BeginInit();
			base.SuspendLayout();
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			componentResourceManager.ApplyResources(this.buttonOK, "buttonOK");
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.textMessage.BorderStyle = global::System.Windows.Forms.BorderStyle.None;
			componentResourceManager.ApplyResources(this.textMessage, "textMessage");
			this.textMessage.Name = "textMessage";
			this.textMessage.ReadOnly = true;
			componentResourceManager.ApplyResources(this.checkSuppressMessage, "checkSuppressMessage");
			this.checkSuppressMessage.Name = "checkSuppressMessage";
			this.checkSuppressMessage.UseVisualStyleBackColor = true;
			this.checkSuppressMessage.CheckedChanged += new global::System.EventHandler(this.checkSuppressMessage_CheckedChanged);
			componentResourceManager.ApplyResources(this.textErrorNumber, "textErrorNumber");
			this.textErrorNumber.Name = "textErrorNumber";
			this.textErrorNumber.ReadOnly = true;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			componentResourceManager.ApplyResources(this.buttonCancel, "buttonCancel");
			this.buttonCancel.Name = "buttonCancel";
			this.buttonNo.DialogResult = global::System.Windows.Forms.DialogResult.No;
			componentResourceManager.ApplyResources(this.buttonNo, "buttonNo");
			this.buttonNo.Name = "buttonNo";
			this.buttonNo.Click += new global::System.EventHandler(this.buttonNo_Click);
			this.buttonYes.DialogResult = global::System.Windows.Forms.DialogResult.Yes;
			componentResourceManager.ApplyResources(this.buttonYes, "buttonYes");
			this.buttonYes.Name = "buttonYes";
			this.buttonYes.Click += new global::System.EventHandler(this.buttonYes_Click);
			componentResourceManager.ApplyResources(this.pictureBox, "pictureBox");
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.TabStop = false;
			this.imageList.ImageStream = (global::System.Windows.Forms.ImageListStreamer)componentResourceManager.GetObject("imageList.ImageStream");
			this.imageList.TransparentColor = global::System.Drawing.Color.Fuchsia;
			this.imageList.Images.SetKeyName(0, "Error_16.PNG");
			this.imageList.Images.SetKeyName(1, "Warning_16.PNG");
			this.imageList.Images.SetKeyName(2, "Info_16.PNG");
			this.imageList.Images.SetKeyName(3, "Help.PNG");
			this.setMessages.DataSetName = "Messages";
			this.setMessages.Locale = new global::System.Globalization.CultureInfo("");
			this.setMessages.SchemaSerializationMode = global::System.Data.SchemaSerializationMode.IncludeSchema;
			componentResourceManager.ApplyResources(this, "$this");
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.Controls.Add(this.pictureBox);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonNo);
			base.Controls.Add(this.buttonYes);
			base.Controls.Add(this.textErrorNumber);
			base.Controls.Add(this.checkSuppressMessage);
			base.Controls.Add(this.textMessage);
			base.Controls.Add(this.buttonOK);
			base.Name = "UserMessage";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.setMessages).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000CF RID: 207
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000D0 RID: 208
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x040000D1 RID: 209
		private global::System.Windows.Forms.TextBox textMessage;

		// Token: 0x040000D2 RID: 210
		private global::System.Windows.Forms.CheckBox checkSuppressMessage;

		// Token: 0x040000D3 RID: 211
		private global::System.Windows.Forms.TextBox textErrorNumber;

		// Token: 0x040000D4 RID: 212
		private global::FifaLibrary.Messages setMessages;

		// Token: 0x040000D5 RID: 213
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x040000D6 RID: 214
		private global::System.Windows.Forms.Button buttonNo;

		// Token: 0x040000D7 RID: 215
		private global::System.Windows.Forms.Button buttonYes;

		// Token: 0x040000D8 RID: 216
		private global::System.Windows.Forms.PictureBox pictureBox;

		// Token: 0x040000D9 RID: 217
		private global::System.Windows.Forms.ImageList imageList;
	}
}
