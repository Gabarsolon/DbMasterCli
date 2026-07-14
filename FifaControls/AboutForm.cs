using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000017 RID: 23
	public partial class AboutForm : Form
	{
		// Token: 0x060000D8 RID: 216 RVA: 0x0000D439 File Offset: 0x0000B639
		public AboutForm()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x0000D448 File Offset: 0x0000B648
		private void linkFifaMaster_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.VisitLink();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000D470 File Offset: 0x0000B670
		private void VisitLink()
		{
			Process.Start("http://www.fifa-master.com");
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000D47D File Offset: 0x0000B67D
		private void VisitAbio()
		{
			Process.Start("http://www.abio.org");
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000D48A File Offset: 0x0000B68A
		private void VisitUnicef()
		{
			Process.Start("http://www.unicef.org");
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000D498 File Offset: 0x0000B698
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.VisitAbio();
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			try
			{
				this.VisitUnicef();
			}
			catch (Exception)
			{
			}
		}
	}
}
