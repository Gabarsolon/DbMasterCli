using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x0200000B RID: 11
	public class ViewCompetitionSetting : UserControl
	{
		// Token: 0x17000015 RID: 21
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00004965 File Offset: 0x00002B65
		// (set) Token: 0x0600005D RID: 93 RVA: 0x00004970 File Offset: 0x00002B70
		[Category("User")]
		[Description("Settings")]
		public CompetitionSettings Settings
		{
			get
			{
				return this.m_CompetitionSettings;
			}
			set
			{
				this.m_CompetitionSettings = value;
				if (this.m_CompetitionSettings != null)
				{
					this.textBox.Text = this.m_CompetitionSettings.GetProperty(this.m_Description, this.m_Index, out this.m_IsSpecific);
					this.check.Checked = this.m_IsSpecific;
					return;
				}
				this.textBox.Text = string.Empty;
				this.check.Checked = false;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600005E RID: 94 RVA: 0x000049E2 File Offset: 0x00002BE2
		// (set) Token: 0x0600005F RID: 95 RVA: 0x000049EA File Offset: 0x00002BEA
		[Description("Index")]
		[Category("User")]
		public int Index
		{
			get
			{
				return this.m_Index;
			}
			set
			{
				this.m_Index = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000060 RID: 96 RVA: 0x000049F3 File Offset: 0x00002BF3
		// (set) Token: 0x06000061 RID: 97 RVA: 0x000049FB File Offset: 0x00002BFB
		[Category("User")]
		[Description("Description")]
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = value;
				this.label.Text = this.m_Description;
			}
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00004A15 File Offset: 0x00002C15
		public ViewCompetitionSetting()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00004A24 File Offset: 0x00002C24
		private void check_CheckedChanged(object sender, EventArgs e)
		{
			if (this.check.Checked)
			{
				this.label.BackColor = Color.LightGreen;
				this.label.ForeColor = Color.Black;
				this.textBox.Enabled = true;
				return;
			}
			this.m_CompetitionSettings.UnsetProperty(this.m_Description);
			this.textBox.Text = this.m_CompetitionSettings.GetProperty(this.m_Description, this.m_Index, out this.m_IsSpecific);
			this.textBox.Enabled = false;
			this.label.BackColor = Color.Gray;
			this.label.BackColor = Color.DarkGray;
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00004AD0 File Offset: 0x00002CD0
		private void textBox_TextChanged(object sender, EventArgs e)
		{
			bool @checked = this.check.Checked;
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00004ADE File Offset: 0x00002CDE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00004B00 File Offset: 0x00002D00
		private void InitializeComponent()
		{
			this.check = new CheckBox();
			this.label = new Label();
			this.textBox = new TextBox();
			base.SuspendLayout();
			this.check.AutoSize = true;
			this.check.Dock = DockStyle.Left;
			this.check.Location = new Point(0, 0);
			this.check.Name = "check";
			this.check.Size = new Size(15, 20);
			this.check.TabIndex = 0;
			this.check.UseVisualStyleBackColor = true;
			this.check.CheckedChanged += this.check_CheckedChanged;
			this.label.BackColor = Color.Transparent;
			this.label.Dock = DockStyle.Fill;
			this.label.Location = new Point(15, 0);
			this.label.Name = "label";
			this.label.Size = new Size(368, 20);
			this.label.TabIndex = 1;
			this.label.Text = "Description";
			this.label.TextAlign = ContentAlignment.MiddleLeft;
			this.textBox.Dock = DockStyle.Right;
			this.textBox.Location = new Point(266, 0);
			this.textBox.Name = "textBox";
			this.textBox.Size = new Size(117, 20);
			this.textBox.TabIndex = 2;
			this.textBox.TextAlign = HorizontalAlignment.Center;
			this.textBox.TextChanged += this.textBox_TextChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.textBox);
			base.Controls.Add(this.label);
			base.Controls.Add(this.check);
			base.Name = "CompetitionSetting";
			base.Size = new Size(383, 20);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000052 RID: 82
		private CompetitionSettings m_CompetitionSettings;

		// Token: 0x04000053 RID: 83
		private string m_Description;

		// Token: 0x04000054 RID: 84
		private int m_Index;

		// Token: 0x04000055 RID: 85
		private bool m_IsSpecific;

		// Token: 0x04000056 RID: 86
		private IContainer components;

		// Token: 0x04000057 RID: 87
		private CheckBox check;

		// Token: 0x04000058 RID: 88
		public Label label;

		// Token: 0x04000059 RID: 89
		public TextBox textBox;
	}
}
