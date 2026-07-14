namespace FifaControls
{
	// Token: 0x02000002 RID: 2
	public partial class RgbControl : global::System.Windows.Forms.Form
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000022DE File Offset: 0x000004DE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002300 File Offset: 0x00000500
		private void InitializeComponent()
		{
			this.trackBarRed = new global::System.Windows.Forms.TrackBar();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.trackBarGreen = new global::System.Windows.Forms.TrackBar();
			this.label3 = new global::System.Windows.Forms.Label();
			this.trackBarBlue = new global::System.Windows.Forms.TrackBar();
			this.buttonOk = new global::System.Windows.Forms.Button();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonReset = new global::System.Windows.Forms.Button();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarRed).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarGreen).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarBlue).BeginInit();
			base.SuspendLayout();
			this.trackBarRed.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackBarRed.LargeChange = 16;
			this.trackBarRed.Location = new global::System.Drawing.Point(36, 12);
			this.trackBarRed.Maximum = 64;
			this.trackBarRed.Minimum = -64;
			this.trackBarRed.Name = "trackBarRed";
			this.trackBarRed.Size = new global::System.Drawing.Size(268, 45);
			this.trackBarRed.TabIndex = 0;
			this.trackBarRed.TickFrequency = 8;
			this.trackBarRed.Scroll += new global::System.EventHandler(this.trackBarRed_Scroll);
			this.trackBarRed.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.trackBarRed_MouseDown);
			this.trackBarRed.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.trackBarRed_MouseUp);
			this.label1.AutoSize = true;
			this.label1.BackColor = global::System.Drawing.Color.Red;
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(3, 21);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(27, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Red";
			this.label2.AutoSize = true;
			this.label2.BackColor = global::System.Drawing.Color.FromArgb(0, 192, 0);
			this.label2.ForeColor = global::System.Drawing.Color.White;
			this.label2.Location = new global::System.Drawing.Point(3, 57);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(36, 13);
			this.label2.TabIndex = 3;
			this.label2.Text = "Green";
			this.trackBarGreen.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackBarGreen.LargeChange = 16;
			this.trackBarGreen.Location = new global::System.Drawing.Point(36, 48);
			this.trackBarGreen.Maximum = 64;
			this.trackBarGreen.Minimum = -64;
			this.trackBarGreen.Name = "trackBarGreen";
			this.trackBarGreen.Size = new global::System.Drawing.Size(268, 45);
			this.trackBarGreen.TabIndex = 2;
			this.trackBarGreen.TickFrequency = 8;
			this.trackBarGreen.Scroll += new global::System.EventHandler(this.trackBarRed_Scroll);
			this.trackBarGreen.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.trackBarRed_MouseDown);
			this.trackBarGreen.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.trackBarRed_MouseUp);
			this.label3.AutoSize = true;
			this.label3.BackColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(3, 95);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(28, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Blue";
			this.trackBarBlue.BackColor = global::System.Drawing.SystemColors.Control;
			this.trackBarBlue.LargeChange = 16;
			this.trackBarBlue.Location = new global::System.Drawing.Point(36, 86);
			this.trackBarBlue.Maximum = 64;
			this.trackBarBlue.Minimum = -64;
			this.trackBarBlue.Name = "trackBarBlue";
			this.trackBarBlue.Size = new global::System.Drawing.Size(268, 45);
			this.trackBarBlue.TabIndex = 4;
			this.trackBarBlue.TickFrequency = 8;
			this.trackBarBlue.Scroll += new global::System.EventHandler(this.trackBarRed_Scroll);
			this.trackBarBlue.MouseDown += new global::System.Windows.Forms.MouseEventHandler(this.trackBarRed_MouseDown);
			this.trackBarBlue.MouseUp += new global::System.Windows.Forms.MouseEventHandler(this.trackBarRed_MouseUp);
			this.buttonOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new global::System.Drawing.Point(58, 159);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 6;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.buttonOk.Click += new global::System.EventHandler(this.buttonOk_Click);
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(203, 159);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 7;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonCancel.Click += new global::System.EventHandler(this.buttonCancel_Click);
			this.buttonReset.Location = new global::System.Drawing.Point(131, 130);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.Size = new global::System.Drawing.Size(75, 23);
			this.buttonReset.TabIndex = 8;
			this.buttonReset.Text = "Reset";
			this.buttonReset.UseVisualStyleBackColor = true;
			this.buttonReset.Click += new global::System.EventHandler(this.buttonReset_Click);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(310, 194);
			base.Controls.Add(this.buttonReset);
			base.Controls.Add(this.buttonCancel);
			base.Controls.Add(this.buttonOk);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.trackBarBlue);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.trackBarGreen);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.trackBarRed);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			base.Name = "RgbControl";
			this.Text = "RgbControl";
			((global::System.ComponentModel.ISupportInitialize)this.trackBarRed).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarGreen).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.trackBarBlue).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000005 RID: 5
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.TrackBar trackBarRed;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.TrackBar trackBarGreen;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.TrackBar trackBarBlue;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Button buttonOk;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.Button buttonReset;
	}
}
