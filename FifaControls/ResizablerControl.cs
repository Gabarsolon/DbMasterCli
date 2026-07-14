using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x02000021 RID: 33
	public class ResizablerControl : UserControl
	{
		// Token: 0x06000145 RID: 325 RVA: 0x0000F904 File Offset: 0x0000DB04
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000F923 File Offset: 0x0000DB23
		private void InitializeComponent()
		{
			this.components = new Container();
			base.AutoScaleMode = AutoScaleMode.Font;
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0000F937 File Offset: 0x0000DB37
		public ResizablerControl()
		{
			this.InitializeComponent();
		}

		// Token: 0x0400015D RID: 349
		private IContainer components;
	}
}
