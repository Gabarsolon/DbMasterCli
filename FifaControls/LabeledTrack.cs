using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000009 RID: 9
	public class LabeledTrack : UserControl
	{
		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000050 RID: 80 RVA: 0x00004612 File Offset: 0x00002812
		// (set) Token: 0x06000051 RID: 81 RVA: 0x0000461C File Offset: 0x0000281C
		[Description("Label")]
		[Category("User")]
		public string LabelText
		{
			get
			{
				return this.m_LabelText;
			}
			set
			{
				this.m_LabelText = value;
				if (value.Contains(" "))
				{
					value.Replace(' ', '-');
				}
				this.label.Text = this.m_LabelText + " " + this.track.Value.ToString();
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00004676 File Offset: 0x00002876
		// (set) Token: 0x06000053 RID: 83 RVA: 0x00004683 File Offset: 0x00002883
		[Description("Value")]
		[Category("User")]
		public int Value
		{
			get
			{
				return this.track.Value;
			}
			set
			{
				this.track.Value = value;
			}
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00004691 File Offset: 0x00002891
		public LabeledTrack()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000055 RID: 85 RVA: 0x000046AC File Offset: 0x000028AC
		private void track_ValueChanged(object sender, EventArgs e)
		{
			this.label.Text = this.m_LabelText + " " + this.track.Value.ToString();
			if (this.ValueChanged != null)
			{
				this.ValueChanged(sender, this.track.Value);
			}
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00004706 File Offset: 0x00002906
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00004728 File Offset: 0x00002928
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(LabeledTrack));
			this.label = new Label();
			this.track = new TrackBar();
			((ISupportInitialize)this.track).BeginInit();
			base.SuspendLayout();
			this.label.BackColor = SystemColors.Control;
			this.label.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
			this.label.ForeColor = Color.Yellow;
			this.label.Image = (Image)componentResourceManager.GetObject("label.Image");
			this.label.ImeMode = ImeMode.NoControl;
			this.label.Location = new Point(1, -1);
			this.label.Name = "label";
			this.label.Size = new Size(100, 16);
			this.label.TabIndex = 90;
			this.label.Text = "Name";
			this.label.TextAlign = ContentAlignment.MiddleCenter;
			this.track.BackColor = SystemColors.Control;
			this.track.Cursor = Cursors.Default;
			this.track.ImeMode = ImeMode.NoControl;
			this.track.LargeChange = 10;
			this.track.Location = new Point(-7, 6);
			this.track.Maximum = 99;
			this.track.Minimum = 1;
			this.track.Name = "track";
			this.track.Size = new Size(116, 45);
			this.track.TabIndex = 89;
			this.track.TickFrequency = 10;
			this.track.Value = 99;
			this.track.ValueChanged += this.track_ValueChanged;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.Controls.Add(this.label);
			base.Controls.Add(this.track);
			base.Name = "LabeledTrack";
			base.Size = new Size(104, 45);
			((ISupportInitialize)this.track).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400004D RID: 77
		private string m_LabelText = string.Empty;

		// Token: 0x0400004E RID: 78
		public LabeledTrack.ValueChangedHandler ValueChanged;

		// Token: 0x0400004F RID: 79
		private IContainer components;

		// Token: 0x04000050 RID: 80
		private Label label;

		// Token: 0x04000051 RID: 81
		private TrackBar track;

		// Token: 0x0200000A RID: 10
		// (Invoke) Token: 0x06000059 RID: 89
		public delegate void ValueChangedHandler(object sender, int value);
	}
}
