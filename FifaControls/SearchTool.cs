using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace FifaControls
{
	// Token: 0x0200001E RID: 30
	public class SearchTool : UserControl
	{
		// Token: 0x0600012F RID: 303 RVA: 0x0000F2CE File Offset: 0x0000D4CE
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000130 RID: 304 RVA: 0x0000F2F0 File Offset: 0x0000D4F0
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(SearchTool));
			this.toolStrip = new ToolStrip();
			this.textBox = new ToolStripTextBox();
			this.buttonCaseSensitive = new ToolStripButton();
			this.buttonSearchContain = new ToolStripButton();
			this.buttonSearchStart = new ToolStripButton();
			this.buttonSearchExact = new ToolStripButton();
			this.toolStrip.SuspendLayout();
			base.SuspendLayout();
			this.toolStrip.GripStyle = ToolStripGripStyle.Hidden;
			this.toolStrip.Items.AddRange(new ToolStripItem[] { this.buttonCaseSensitive, this.textBox, this.buttonSearchExact, this.buttonSearchStart, this.buttonSearchContain });
			this.toolStrip.Location = new Point(0, 0);
			this.toolStrip.Name = "toolStrip";
			this.toolStrip.Size = new Size(345, 25);
			this.toolStrip.TabIndex = 0;
			this.toolStrip.Text = "toolStrip";
			this.textBox.Name = "textBox";
			this.textBox.Size = new Size(200, 25);
			this.textBox.ToolTipText = "Type the string to search";
			this.textBox.KeyDown += this.textBox_KeyDown;
			this.buttonCaseSensitive.CheckOnClick = true;
			this.buttonCaseSensitive.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonCaseSensitive.Image = (Image)componentResourceManager.GetObject("buttonCaseSensitive.Image");
			this.buttonCaseSensitive.ImageTransparentColor = Color.Magenta;
			this.buttonCaseSensitive.Name = "buttonCaseSensitive";
			this.buttonCaseSensitive.RightToLeft = RightToLeft.No;
			this.buttonCaseSensitive.Size = new Size(23, 22);
			this.buttonCaseSensitive.ToolTipText = "case sensitive search";
			this.buttonCaseSensitive.Click += this.buttonCaseSensitive_Click;
			this.buttonSearchContain.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchContain.Image = (Image)componentResourceManager.GetObject("buttonSearchContain.Image");
			this.buttonSearchContain.ImageTransparentColor = Color.Magenta;
			this.buttonSearchContain.Name = "buttonSearchContain";
			this.buttonSearchContain.Size = new Size(23, 22);
			this.buttonSearchContain.Text = "Search if contains";
			this.buttonSearchContain.Click += this.buttonSearchContain_Click;
			this.buttonSearchStart.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchStart.Image = (Image)componentResourceManager.GetObject("buttonSearchStart.Image");
			this.buttonSearchStart.ImageTransparentColor = Color.Magenta;
			this.buttonSearchStart.Name = "buttonSearchStart";
			this.buttonSearchStart.Size = new Size(23, 22);
			this.buttonSearchStart.Text = "Search if starts with";
			this.buttonSearchStart.Click += this.buttonSearchStart_Click;
			this.buttonSearchExact.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.buttonSearchExact.Image = (Image)componentResourceManager.GetObject("buttonSearchExact.Image");
			this.buttonSearchExact.ImageTransparentColor = Color.Magenta;
			this.buttonSearchExact.Name = "buttonSearchExact";
			this.buttonSearchExact.Size = new Size(23, 22);
			this.buttonSearchExact.Text = "Search exactly";
			this.buttonSearchExact.Click += this.buttonSearchExact_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.AutoSize = true;
			base.Controls.Add(this.toolStrip);
			base.Name = "SearchTool";
			base.Size = new Size(345, 25);
			this.toolStrip.ResumeLayout(false);
			this.toolStrip.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000131 RID: 305 RVA: 0x0000F6E9 File Offset: 0x0000D8E9
		// (set) Token: 0x06000132 RID: 306 RVA: 0x0000F6F6 File Offset: 0x0000D8F6
		[Description("Width of the text box.")]
		[Category("User")]
		public int TextWidth
		{
			get
			{
				return this.textBox.Width;
			}
			set
			{
				this.textBox.Size = new Size(value, this.textBox.Height);
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x06000133 RID: 307 RVA: 0x0000F714 File Offset: 0x0000D914
		// (set) Token: 0x06000134 RID: 308 RVA: 0x0000F71C File Offset: 0x0000D91C
		public ArrayList ObjectList
		{
			get
			{
				return this.m_ObjectList;
			}
			set
			{
				this.m_ObjectList = value;
			}
		}

		// Token: 0x1700003E RID: 62
		// (get) Token: 0x06000135 RID: 309 RVA: 0x0000F725 File Offset: 0x0000D925
		public object FoundObject
		{
			get
			{
				return this.m_FoundObject;
			}
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000F72D File Offset: 0x0000D92D
		public bool HasFound
		{
			get
			{
				return this.m_HasFound;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000137 RID: 311 RVA: 0x0000F735 File Offset: 0x0000D935
		public bool IsCaseSensitive
		{
			get
			{
				return this.m_CaseSensitive;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000F73D File Offset: 0x0000D93D
		// (set) Token: 0x06000139 RID: 313 RVA: 0x0000F745 File Offset: 0x0000D945
		public int CurrentIndex
		{
			get
			{
				return this.m_CurrentIndex;
			}
			set
			{
				this.m_CurrentIndex = value;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000F74E File Offset: 0x0000D94E
		public SearchTool()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0000F763 File Offset: 0x0000D963
		private void textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyValue == 13)
			{
				this.Search();
			}
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0000F776 File Offset: 0x0000D976
		private void buttonSearchExact_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = SearchTool.SearchMode.SearchExact;
			this.Search();
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0000F786 File Offset: 0x0000D986
		private void buttonSearchStart_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = SearchTool.SearchMode.SearchStarting;
			this.Search();
		}

		// Token: 0x0600013E RID: 318 RVA: 0x0000F796 File Offset: 0x0000D996
		private void buttonSearchContain_Click(object sender, EventArgs e)
		{
			this.m_SearchMode = SearchTool.SearchMode.SearchContaining;
			this.Search();
		}

		// Token: 0x0600013F RID: 319 RVA: 0x0000F7A8 File Offset: 0x0000D9A8
		public bool Search()
		{
			this.m_Pattern = this.textBox.Text;
			if (!this.IsCaseSensitive)
			{
				this.m_Pattern = this.m_Pattern.ToLower();
			}
			int num = this.m_CurrentIndex;
			num++;
			if (num == this.m_ObjectList.Count)
			{
				num = 0;
			}
			for (;;)
			{
				string text = this.m_ObjectList[num].ToString();
				if (!this.IsCaseSensitive)
				{
					text = text.ToLower();
				}
				switch (this.m_SearchMode)
				{
				case SearchTool.SearchMode.SearchExact:
					this.m_HasFound = text.ToString().Equals(this.m_Pattern);
					break;
				case SearchTool.SearchMode.SearchStarting:
					this.m_HasFound = text.ToString().StartsWith(this.m_Pattern);
					break;
				case SearchTool.SearchMode.SearchContaining:
					this.m_HasFound = text.Contains(this.m_Pattern);
					break;
				}
				if (this.m_HasFound)
				{
					break;
				}
				if (num == this.m_CurrentIndex)
				{
					goto IL_0127;
				}
				num++;
				if (num == this.m_ObjectList.Count)
				{
					num = 0;
				}
			}
			this.m_FoundObject = this.m_ObjectList[num];
			this.m_CurrentIndex = num;
			if (this.CallBack != null)
			{
				this.CallBack(this, this.m_FoundObject);
			}
			return true;
			IL_0127:
			this.m_FoundObject = null;
			this.CallBack(this, null);
			return false;
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0000F8F1 File Offset: 0x0000DAF1
		private void buttonCaseSensitive_Click(object sender, EventArgs e)
		{
			this.m_CaseSensitive = this.buttonCaseSensitive.Checked;
		}

		// Token: 0x0400014A RID: 330
		private IContainer components;

		// Token: 0x0400014B RID: 331
		private ToolStrip toolStrip;

		// Token: 0x0400014C RID: 332
		public ToolStripTextBox textBox;

		// Token: 0x0400014D RID: 333
		public ToolStripButton buttonSearchExact;

		// Token: 0x0400014E RID: 334
		public ToolStripButton buttonSearchStart;

		// Token: 0x0400014F RID: 335
		public ToolStripButton buttonSearchContain;

		// Token: 0x04000150 RID: 336
		public ToolStripButton buttonCaseSensitive;

		// Token: 0x04000151 RID: 337
		private ArrayList m_ObjectList;

		// Token: 0x04000152 RID: 338
		private object m_FoundObject;

		// Token: 0x04000153 RID: 339
		private bool m_HasFound;

		// Token: 0x04000154 RID: 340
		private bool m_CaseSensitive;

		// Token: 0x04000155 RID: 341
		private int m_CurrentIndex;

		// Token: 0x04000156 RID: 342
		private string m_Pattern;

		// Token: 0x04000157 RID: 343
		private SearchTool.SearchMode m_SearchMode = SearchTool.SearchMode.SearchContaining;

		// Token: 0x04000158 RID: 344
		[Description("Search done.")]
		[Category("Event")]
		public SearchTool.SearchEventHandler CallBack;

		// Token: 0x0200001F RID: 31
		private enum SearchMode
		{
			// Token: 0x0400015A RID: 346
			SearchExact,
			// Token: 0x0400015B RID: 347
			SearchStarting,
			// Token: 0x0400015C RID: 348
			SearchContaining
		}

		// Token: 0x02000020 RID: 32
		// (Invoke) Token: 0x06000142 RID: 322
		public delegate void SearchEventHandler(object sender, object obj);
	}
}
