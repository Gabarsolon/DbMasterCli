namespace FifaControls
{
	// Token: 0x02000016 RID: 22
	public partial class AdvanceRuleDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x060000D4 RID: 212 RVA: 0x0000C88D File Offset: 0x0000AA8D
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000C8AC File Offset: 0x0000AAAC
		private void InitializeComponent()
		{
			this.comboTrophy = new global::System.Windows.Forms.ComboBox();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonOk = new global::System.Windows.Forms.Button();
			this.comboStage = new global::System.Windows.Forms.ComboBox();
			this.comboGroup = new global::System.Windows.Forms.ComboBox();
			this.comboTeam = new global::System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.comboTrophy.FormattingEnabled = true;
			this.comboTrophy.Location = new global::System.Drawing.Point(12, 12);
			this.comboTrophy.Name = "comboTrophy";
			this.comboTrophy.Size = new global::System.Drawing.Size(351, 21);
			this.comboTrophy.TabIndex = 15;
			this.comboTrophy.SelectedIndexChanged += new global::System.EventHandler(this.comboTrophy_SelectedIndexChanged);
			this.panel1.Controls.Add(this.buttonCancel);
			this.panel1.Controls.Add(this.buttonOk);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new global::System.Drawing.Point(0, 134);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(375, 50);
			this.panel1.TabIndex = 17;
			this.buttonCancel.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.buttonCancel.Location = new global::System.Drawing.Point(236, 15);
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.Size = new global::System.Drawing.Size(75, 23);
			this.buttonCancel.TabIndex = 3;
			this.buttonCancel.Text = "Cancel";
			this.buttonCancel.UseVisualStyleBackColor = true;
			this.buttonOk.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOk.Location = new global::System.Drawing.Point(54, 15);
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOk.TabIndex = 2;
			this.buttonOk.Text = "OK";
			this.buttonOk.UseVisualStyleBackColor = true;
			this.comboStage.FormattingEnabled = true;
			this.comboStage.Location = new global::System.Drawing.Point(12, 39);
			this.comboStage.Name = "comboStage";
			this.comboStage.Size = new global::System.Drawing.Size(351, 21);
			this.comboStage.TabIndex = 18;
			this.comboStage.SelectedIndexChanged += new global::System.EventHandler(this.comboStage_SelectedIndexChanged);
			this.comboGroup.FormattingEnabled = true;
			this.comboGroup.Location = new global::System.Drawing.Point(12, 66);
			this.comboGroup.Name = "comboGroup";
			this.comboGroup.Size = new global::System.Drawing.Size(351, 21);
			this.comboGroup.TabIndex = 19;
			this.comboGroup.SelectedIndexChanged += new global::System.EventHandler(this.comboGroup_SelectedIndexChanged);
			this.comboTeam.FormattingEnabled = true;
			this.comboTeam.Location = new global::System.Drawing.Point(12, 93);
			this.comboTeam.Name = "comboTeam";
			this.comboTeam.Size = new global::System.Drawing.Size(351, 21);
			this.comboTeam.TabIndex = 20;
			this.comboTeam.SelectedIndexChanged += new global::System.EventHandler(this.comboTeam_SelectedIndexChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(375, 184);
			base.Controls.Add(this.comboTeam);
			base.Controls.Add(this.comboGroup);
			base.Controls.Add(this.comboStage);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.comboTrophy);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.FixedDialog;
			base.Name = "AdvanceRuleDialog";
			this.Text = "Advance Rule";
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x040000FD RID: 253
		private global::System.ComponentModel.IContainer components;

		// Token: 0x040000FE RID: 254
		private global::System.Windows.Forms.ComboBox comboTrophy;

		// Token: 0x040000FF RID: 255
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000100 RID: 256
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x04000101 RID: 257
		private global::System.Windows.Forms.Button buttonOk;

		// Token: 0x04000102 RID: 258
		private global::System.Windows.Forms.ComboBox comboStage;

		// Token: 0x04000103 RID: 259
		private global::System.Windows.Forms.ComboBox comboGroup;

		// Token: 0x04000104 RID: 260
		private global::System.Windows.Forms.ComboBox comboTeam;
	}
}
