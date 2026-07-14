using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000015 RID: 21
	public partial class FullSizeViewer : Form
	{
		// Token: 0x060000C8 RID: 200 RVA: 0x0000C351 File Offset: 0x0000A551
		public FullSizeViewer()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000C35F File Offset: 0x0000A55F
		public void SetImage(Image image)
		{
			base.Width = image.Width + 10;
			base.Height = image.Height + 50;
			this.pictureBox.BackgroundImage = image;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000C38B File Offset: 0x0000A58B
		private void toolStripButton1_Click(object sender, EventArgs e)
		{
			base.Close();
		}
	}
}
