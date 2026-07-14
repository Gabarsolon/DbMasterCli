using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000028 RID: 40
	public partial class CmsBrowser : Form
	{
		// Token: 0x1700004E RID: 78
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00011884 File Offset: 0x0000FA84
		public int NewId
		{
			get
			{
				return this.m_NewId;
			}
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000190 RID: 400 RVA: 0x0001188C File Offset: 0x0000FA8C
		public string NewName
		{
			get
			{
				return this.m_NewName;
			}
		}

		// Token: 0x17000050 RID: 80
		// (set) Token: 0x06000191 RID: 401 RVA: 0x00011894 File Offset: 0x0000FA94
		public string CmsFileName
		{
			set
			{
				this.m_CmsFileName = value;
				if (File.Exists(this.m_CmsFileName))
				{
					this.m_CmsDataSet.Tables.Clear();
					this.m_CmsDataSet.Relations.Clear();
					this.m_CmsDataSet.ReadXml(this.m_CmsFileName);
					this.treeViewCms.Nodes.Clear();
					string text = string.Empty;
					TreeNode treeNode = null;
					foreach (object obj in this.m_CmsDataSet.Tables["CmsDataTable"].Rows)
					{
						DataRow dataRow = (DataRow)obj;
						if (dataRow["Group"].ToString() != text)
						{
							text = dataRow["Group"].ToString();
							treeNode = this.treeViewCms.Nodes.Add(text);
						}
						TreeNode treeNode2 = treeNode.Nodes.Add(dataRow["Name"].ToString());
						treeNode2.Tag = dataRow["Id"];
					}
				}
			}
		}

		// Token: 0x06000192 RID: 402 RVA: 0x000119CC File Offset: 0x0000FBCC
		public CmsBrowser()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000193 RID: 403 RVA: 0x000119EC File Offset: 0x0000FBEC
		private void treeViewCms_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode selectedNode = this.treeViewCms.SelectedNode;
			if (selectedNode == null)
			{
				this.m_NewId = -1;
				this.m_NewName = null;
				return;
			}
			if (selectedNode.Level == 1)
			{
				this.m_NewId = Convert.ToInt32(this.treeViewCms.SelectedNode.Tag);
				this.m_NewName = selectedNode.Text;
			}
		}

		// Token: 0x06000194 RID: 404 RVA: 0x00011A47 File Offset: 0x0000FC47
		private void treeViewCms_DoubleClick(object sender, EventArgs e)
		{
			this.buttonOK.PerformClick();
		}

		// Token: 0x04000193 RID: 403
		private int m_NewId = -1;

		// Token: 0x04000194 RID: 404
		public string m_NewName;

		// Token: 0x04000195 RID: 405
		private string m_CmsFileName;

		// Token: 0x04000196 RID: 406
		private CmsDataSet m_CmsDataSet = new CmsDataSet();
	}
}
