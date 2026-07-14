using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000029 RID: 41
	public partial class ColorSelector : Form
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00011A54 File Offset: 0x0000FC54
		public Color SelectedColor
		{
			get
			{
				return this.m_SelectedColor;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000196 RID: 406 RVA: 0x00011A5C File Offset: 0x0000FC5C
		public int SelectedIndex
		{
			get
			{
				return this.m_SelectedIndex;
			}
		}

		// Token: 0x06000197 RID: 407 RVA: 0x00011A64 File Offset: 0x0000FC64
		public ColorSelector(Color[] palette, int selectedIndex)
		{
			this.InitializeComponent();
			this.m_Palette = palette;
			if (selectedIndex < 0 || selectedIndex >= palette.Length)
			{
				selectedIndex = 0;
			}
			this.m_SelectedColor = this.m_Palette[selectedIndex];
			this.pictureSelectedColor.BackColor = this.m_SelectedColor;
			base.Height = 20 * ((palette.Length - 1) / 8) + 92;
			this.buttonOK.Location = new Point(16, base.Height - 56);
			this.buttonCancel.Location = new Point(104, base.Height - 56);
			int num = 32;
			int num2 = 8;
			this.m_RadioButtons = new RadioButton[palette.Length];
			for (int i = 0; i < palette.Length; i++)
			{
				this.m_RadioButtons[i] = new RadioButton();
				this.m_RadioButtons[i].Location = new Point(num, num2);
				num += 20;
				if ((i + 1) % 8 == 0)
				{
					num = 32;
					num2 += 20;
				}
				this.m_RadioButtons[i].BackColor = palette[i];
				if (palette[i] == Color.Transparent)
				{
					this.m_RadioButtons[i].BackgroundImage = this.pictureBoxHidden.BackgroundImage;
				}
				if (i == selectedIndex)
				{
					this.m_RadioButtons[i].Checked = true;
				}
				this.m_RadioButtons[i].Appearance = Appearance.Button;
				this.m_RadioButtons[i].Text = string.Empty;
				this.m_RadioButtons[i].Width = (this.m_RadioButtons[i].Height = 18);
				this.m_RadioButtons[i].Visible = true;
				this.m_RadioButtons[i].CheckedChanged += this.radio_CheckedChanged;
				base.Controls.Add(this.m_RadioButtons[i]);
			}
		}

		// Token: 0x0600019A RID: 410 RVA: 0x00011E2C File Offset: 0x0001002C
		private void radio_CheckedChanged(object sender, EventArgs e)
		{
			RadioButton radioButton = (RadioButton)sender;
			if (radioButton.Checked)
			{
				this.pictureSelectedColor.BackColor = radioButton.BackColor;
				this.m_SelectedColor = radioButton.BackColor;
				if (this.m_SelectedColor == Color.Transparent)
				{
					this.pictureSelectedColor.BackgroundImage = this.pictureBoxHidden.BackgroundImage;
				}
				else
				{
					this.pictureSelectedColor.BackgroundImage = null;
				}
				for (int i = 0; i < this.m_Palette.Length; i++)
				{
					if (this.pictureSelectedColor.BackColor == this.m_RadioButtons[i].BackColor)
					{
						this.m_SelectedIndex = i;
						return;
					}
				}
			}
		}

		// Token: 0x0400019B RID: 411
		private Color m_SelectedColor;

		// Token: 0x0400019C RID: 412
		private Color[] m_Palette;

		// Token: 0x0400019D RID: 413
		private int m_SelectedIndex;

		// Token: 0x0400019F RID: 415
		private RadioButton[] m_RadioButtons;
	}
}
