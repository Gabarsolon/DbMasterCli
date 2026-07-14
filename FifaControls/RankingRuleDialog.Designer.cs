namespace FifaControls
{
	// Token: 0x0200000C RID: 12
	public partial class RankingRuleDialog : global::System.Windows.Forms.Form
	{
		// Token: 0x06000070 RID: 112 RVA: 0x00005198 File Offset: 0x00003398
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000051B8 File Offset: 0x000033B8
		private void InitializeComponent()
		{
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.buttonCancel = new global::System.Windows.Forms.Button();
			this.buttonOk = new global::System.Windows.Forms.Button();
			this.comboTeam = new global::System.Windows.Forms.ComboBox();
			this.comboGroup = new global::System.Windows.Forms.ComboBox();
			this.comboStage = new global::System.Windows.Forms.ComboBox();
			this.comboTrophy = new global::System.Windows.Forms.ComboBox();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Controls.Add(this.buttonCancel);
			this.panel1.Controls.Add(this.buttonOk);
			this.panel1.Dock = global::System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new global::System.Drawing.Point(0, 130);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(380, 50);
			this.panel1.TabIndex = 18;
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
			this.comboTeam.FormattingEnabled = true;
			this.comboTeam.Location = new global::System.Drawing.Point(12, 93);
			this.comboTeam.Name = "comboTeam";
			this.comboTeam.Size = new global::System.Drawing.Size(351, 21);
			this.comboTeam.TabIndex = 24;
			this.comboTeam.SelectedIndexChanged += new global::System.EventHandler(this.comboTeam_SelectedIndexChanged);
			this.comboGroup.FormattingEnabled = true;
			this.comboGroup.Location = new global::System.Drawing.Point(12, 66);
			this.comboGroup.Name = "comboGroup";
			this.comboGroup.Size = new global::System.Drawing.Size(351, 21);
			this.comboGroup.TabIndex = 23;
			this.comboGroup.SelectedIndexChanged += new global::System.EventHandler(this.comboGroup_SelectedIndexChanged);
			this.comboStage.FormattingEnabled = true;
			this.comboStage.Location = new global::System.Drawing.Point(12, 39);
			this.comboStage.Name = "comboStage";
			this.comboStage.Size = new global::System.Drawing.Size(351, 21);
			this.comboStage.TabIndex = 22;
			this.comboStage.SelectedIndexChanged += new global::System.EventHandler(this.comboStage_SelectedIndexChanged);
			this.comboTrophy.FormattingEnabled = true;
			this.comboTrophy.Location = new global::System.Drawing.Point(12, 12);
			this.comboTrophy.Name = "comboTrophy";
			this.comboTrophy.Size = new global::System.Drawing.Size(351, 21);
			this.comboTrophy.TabIndex = 21;
			this.comboTrophy.SelectedIndexChanged += new global::System.EventHandler(this.comboTrophy_SelectedIndexChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(380, 180);
			base.Controls.Add(this.comboTeam);
			base.Controls.Add(this.comboGroup);
			base.Controls.Add(this.comboStage);
			base.Controls.Add(this.comboTrophy);
			base.Controls.Add(this.panel1);
			base.Name = "RankingRuleDialog";
			this.Text = "Ranking Rule";
			this.panel1.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x0400005E RID: 94
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400005F RID: 95
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000060 RID: 96
		private global::System.Windows.Forms.Button buttonCancel;

		// Token: 0x04000061 RID: 97
		private global::System.Windows.Forms.Button buttonOk;

		// Token: 0x04000062 RID: 98
		private global::System.Windows.Forms.ComboBox comboTeam;

		// Token: 0x04000063 RID: 99
		private global::System.Windows.Forms.ComboBox comboGroup;

		// Token: 0x04000064 RID: 100
		private global::System.Windows.Forms.ComboBox comboStage;

		// Token: 0x04000065 RID: 101
		private global::System.Windows.Forms.ComboBox comboTrophy;
	}
}
