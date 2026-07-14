namespace FifaControls
{
	// Token: 0x02000019 RID: 25
	public partial class NewKitCreator : global::System.Windows.Forms.Form
	{
		// Token: 0x06000112 RID: 274 RVA: 0x0000E7A9 File Offset: 0x0000C9A9
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000E7C8 File Offset: 0x0000C9C8
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::FifaControls.NewKitCreator));
			this.button1 = new global::System.Windows.Forms.Button();
			this.buttonOK = new global::System.Windows.Forms.Button();
			this.labelTeam = new global::System.Windows.Forms.Label();
			this.labelKitType = new global::System.Windows.Forms.Label();
			this.comboKitTypes = new global::System.Windows.Forms.ComboBox();
			this.comboTeams = new global::System.Windows.Forms.ComboBox();
			base.SuspendLayout();
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.Cancel;
			this.button1.Location = new global::System.Drawing.Point(174, 121);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(75, 23);
			this.button1.TabIndex = 8;
			this.button1.Text = "Cancel";
			this.button1.UseVisualStyleBackColor = true;
			this.buttonOK.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.buttonOK.Location = new global::System.Drawing.Point(49, 121);
			this.buttonOK.Name = "buttonOK";
			this.buttonOK.Size = new global::System.Drawing.Size(75, 23);
			this.buttonOK.TabIndex = 7;
			this.buttonOK.Text = "OK";
			this.buttonOK.UseVisualStyleBackColor = true;
			this.buttonOK.Click += new global::System.EventHandler(this.buttonOK_Click);
			this.labelTeam.AutoSize = true;
			this.labelTeam.BackColor = global::System.Drawing.Color.Transparent;
			this.labelTeam.Location = new global::System.Drawing.Point(23, 31);
			this.labelTeam.Name = "labelTeam";
			this.labelTeam.Size = new global::System.Drawing.Size(34, 13);
			this.labelTeam.TabIndex = 9;
			this.labelTeam.Text = "Team";
			this.labelKitType.AutoSize = true;
			this.labelKitType.BackColor = global::System.Drawing.Color.Transparent;
			this.labelKitType.Location = new global::System.Drawing.Point(23, 63);
			this.labelKitType.Name = "labelKitType";
			this.labelKitType.Size = new global::System.Drawing.Size(42, 13);
			this.labelKitType.TabIndex = 10;
			this.labelKitType.Text = "Kit type";
			this.comboKitTypes.FormattingEnabled = true;
			this.comboKitTypes.Items.AddRange(new object[]
			{
				"Home", "Away", "Goalkeeper", "3rd Kit", "4th Kit", "Referee", "6th Kit", "7th Kit", "8th Kit", "9th Kit",
				"10th Kit"
			});
			this.comboKitTypes.Location = new global::System.Drawing.Point(91, 60);
			this.comboKitTypes.Name = "comboKitTypes";
			this.comboKitTypes.Size = new global::System.Drawing.Size(178, 21);
			this.comboKitTypes.TabIndex = 11;
			this.comboKitTypes.SelectedIndexChanged += new global::System.EventHandler(this.comboKitTypes_SelectedIndexChanged);
			this.comboTeams.FormattingEnabled = true;
			this.comboTeams.Location = new global::System.Drawing.Point(91, 28);
			this.comboTeams.Name = "comboTeams";
			this.comboTeams.Size = new global::System.Drawing.Size(178, 21);
			this.comboTeams.TabIndex = 12;
			this.comboTeams.SelectedIndexChanged += new global::System.EventHandler(this.comboTeams_SelectedIndexChanged);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			this.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.Stretch;
			base.ClientSize = new global::System.Drawing.Size(292, 169);
			base.Controls.Add(this.comboTeams);
			base.Controls.Add(this.comboKitTypes);
			base.Controls.Add(this.labelKitType);
			base.Controls.Add(this.labelTeam);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.buttonOK);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			base.Name = "NewKitCreator";
			this.Text = "NewKitSelector";
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000136 RID: 310
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000137 RID: 311
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000138 RID: 312
		private global::System.Windows.Forms.Button buttonOK;

		// Token: 0x04000139 RID: 313
		private global::System.Windows.Forms.Label labelTeam;

		// Token: 0x0400013A RID: 314
		private global::System.Windows.Forms.Label labelKitType;

		// Token: 0x0400013B RID: 315
		private global::System.Windows.Forms.ComboBox comboKitTypes;

		// Token: 0x0400013C RID: 316
		private global::System.Windows.Forms.ComboBox comboTeams;
	}
}
