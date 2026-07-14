using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000022 RID: 34
	public partial class NewIdCreator : Form
	{
		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600014A RID: 330 RVA: 0x0001000A File Offset: 0x0000E20A
		public int NewId
		{
			get
			{
				return this.m_NewId;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600014B RID: 331 RVA: 0x00010012 File Offset: 0x0000E212
		public IdObject NewObject
		{
			get
			{
				return this.m_NewObject;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600014C RID: 332 RVA: 0x0001001A File Offset: 0x0000E21A
		public string NewName
		{
			get
			{
				return this.m_NewName;
			}
		}

		// Token: 0x17000045 RID: 69
		// (set) Token: 0x0600014D RID: 333 RVA: 0x00010024 File Offset: 0x0000E224
		public IdArrayList IdList
		{
			set
			{
				this.m_IdArrayList = value;
				if (this.m_IdArrayList != null)
				{
					this.numericSpecificId.Minimum = this.m_IdArrayList.MinId;
					this.numericSpecificId.Maximum = this.m_IdArrayList.MaxId;
					this.labelMinMax.Text = this.m_IdArrayList.MinId.ToString() + " - " + this.m_IdArrayList.MaxId.ToString();
					if (this.numericSpecificId.Value < this.numericSpecificId.Minimum)
					{
						this.numericSpecificId.Value = this.numericSpecificId.Minimum;
						return;
					}
					if (this.numericSpecificId.Value > this.numericSpecificId.Maximum)
					{
						this.numericSpecificId.Value = this.numericSpecificId.Maximum;
						return;
					}
				}
				else
				{
					this.numericSpecificId.Minimum = -1m;
					this.numericSpecificId.Maximum = -1m;
					this.numericSpecificId.Value = -1m;
				}
			}
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0001014F File Offset: 0x0000E34F
		public NewIdCreator()
		{
			this.InitializeComponent();
			this.numericSpecificId.Enabled = this.radioSpacificId.Checked;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00010188 File Offset: 0x0000E388
		private void radioSpacificId_CheckedChanged(object sender, EventArgs e)
		{
			this.numericSpecificId.Enabled = this.radioSpacificId.Checked;
			if (this.radioSpacificId.Checked)
			{
				this.m_NewId = (int)this.numericSpecificId.Value;
				this.m_NewName = null;
			}
		}

		// Token: 0x06000150 RID: 336 RVA: 0x000101D5 File Offset: 0x0000E3D5
		private void radioAuto_CheckedChanged(object sender, EventArgs e)
		{
			if (this.radioAuto.Checked)
			{
				this.m_NewId = -1;
				this.m_NewName = null;
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000101F2 File Offset: 0x0000E3F2
		private void numericSpecificId_ValueChanged(object sender, EventArgs e)
		{
			if (this.radioSpacificId.Checked)
			{
				this.m_NewId = (int)this.numericSpecificId.Value;
				this.m_NewName = null;
			}
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0001021E File Offset: 0x0000E41E
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.m_IdArrayList == null)
			{
				this.m_NewObject = null;
				return;
			}
			this.m_NewObject = ((this.m_NewId < 0) ? this.m_IdArrayList.CreateNewId() : this.m_IdArrayList.CreateNewId(this.m_NewId));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0001025D File Offset: 0x0000E45D
		private void button1_Click(object sender, EventArgs e)
		{
			this.m_NewObject = null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00010268 File Offset: 0x0000E468
		private void radioCms_CheckedChanged(object sender, EventArgs e)
		{
			this.textCms.Enabled = this.radioCms.Checked;
			this.treeViewCms.Enabled = this.radioCms.Checked;
			if (this.radioCms.Checked)
			{
				this.treeViewCms_AfterSelect(null, null);
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000102B8 File Offset: 0x0000E4B8
		private void treeViewCms_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode selectedNode = this.treeViewCms.SelectedNode;
			if (selectedNode == null)
			{
				this.m_NewId = -1;
				this.textCms.Text = string.Empty;
				this.m_NewName = null;
				return;
			}
			if (selectedNode.Level == 1)
			{
				this.m_NewId = Convert.ToInt32(this.treeViewCms.SelectedNode.Tag);
				this.textCms.Text = selectedNode.Text;
				this.m_NewName = this.textCms.Text;
			}
		}

		// Token: 0x04000168 RID: 360
		private int m_NewId = -1;

		// Token: 0x04000169 RID: 361
		private IdObject m_NewObject;

		// Token: 0x0400016A RID: 362
		public string m_NewName;

		// Token: 0x0400016B RID: 363
		private string m_CmsFileName;

		// Token: 0x0400016C RID: 364
		private CmsDataSet m_CmsDataSet = new CmsDataSet();

		// Token: 0x0400016D RID: 365
		private IdArrayList m_IdArrayList;
	}
}
