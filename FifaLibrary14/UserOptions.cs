using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000023 RID: 35
	public partial class UserOptions : Form
	{
		// Token: 0x0600026D RID: 621 RVA: 0x000118F4 File Offset: 0x0000FAF4
		public UserOptions()
		{
			this.InitializeComponent();
			string currentDirectory = Environment.CurrentDirectory;
			this.m_XmlFileName = currentDirectory + "\\Options.xml";
			if (!File.Exists(this.m_XmlFileName))
			{
				return;
			}
			this.optionsSet.ReadXml(this.m_XmlFileName);
			this.LoadOptions();
		}

		// Token: 0x0600026E RID: 622 RVA: 0x0001197B File Offset: 0x0000FB7B
		public DialogResult ShowOptions()
		{
			this.LoadOptions();
			return base.ShowDialog();
		}

		// Token: 0x0600026F RID: 623 RVA: 0x0001198C File Offset: 0x0000FB8C
		private void LoadOptions()
		{
			for (int i = 0; i < this.optionsSet.DataTableOpt.Count; i++)
			{
				string option = this.optionsSet.DataTableOpt[i].Option;
				string value = this.optionsSet.DataTableOpt[i].Value;
				int num;
				try
				{
					num = Convert.ToInt32(value);
				}
				catch
				{
					num = 0;
				}
				bool flag = num != 0;
				string @default = this.optionsSet.DataTableOpt[i].Default;
				if (option == "ExportFolderAuto")
				{
					this.checkAutoExportFolder.Checked = flag;
					this.m_AutoExportFolder = flag;
					this.textExportFolder.Enabled = !flag;
					this.buttonBrowseExportFolder.Enabled = !flag;
				}
				else if (option == "ExportFolder")
				{
					this.textExportFolder.Text = value;
					this.m_ExportFolder = value;
				}
				else if (option == "DatabaseEditing")
				{
					this.checkSaveDb.Checked = flag;
					this.m_SaveDatabase = flag;
				}
				else if (option == "ZdataEditing")
				{
					this.checkSaveZdata.Checked = flag;
					this.m_SaveZdata = flag;
				}
				else if (option == "GuiEditing")
				{
					this.checkSaveGui.Checked = flag;
					this.m_SaveGui = flag;
				}
				else if (option == "AutoZdata")
				{
					this.radioAutoZdata.Checked = flag;
					this.m_AutoZdata = flag;
					if (this.m_AutoZdata)
					{
						this.m_SpecificZdata = false;
						this.m_SaveZdataInFolder = false;
					}
					this.numericZdata.Enabled = this.m_SpecificZdata;
				}
				else if (option == "SpecificZdata")
				{
					this.radioSpecificZdata.Checked = flag;
					this.m_SpecificZdata = flag;
					if (this.m_SpecificZdata)
					{
						this.m_AutoZdata = false;
						this.m_SaveZdataInFolder = false;
					}
					this.numericZdata.Enabled = this.m_SpecificZdata;
				}
				else if (option == "SaveZdataInFolder")
				{
					this.radioZdataSaveFolder.Checked = flag;
					this.m_SaveZdataInFolder = flag;
					if (this.m_SaveZdataInFolder)
					{
						this.m_AutoZdata = false;
						this.m_SpecificZdata = false;
					}
					this.numericZdata.Enabled = this.m_SpecificZdata;
				}
				else if (option == "ZdataNumber")
				{
					this.numericZdata.Value = num;
					this.m_ZdataNumber = num;
				}
				else if (option == "SaveGuiInArchive")
				{
					this.radioGuiSaveArchive.Checked = flag;
					this.m_SaveGuiInArchive = flag;
					this.m_SaveGuiInFolder = !flag;
				}
				else if (option == "SaveGuiInFolder")
				{
					this.radioGuiSaveFolder.Checked = flag;
					this.m_SaveGuiInArchive = !flag;
					this.m_SaveGuiInFolder = flag;
				}
			}
		}

		// Token: 0x06000270 RID: 624 RVA: 0x00011C74 File Offset: 0x0000FE74
		private void buttonBrowseExportFolder_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.Description = "Select the export folder";
			folderBrowserDialog.ShowNewFolderButton = true;
			if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				folderBrowserDialog.Dispose();
				return;
			}
			this.textExportFolder.Text = folderBrowserDialog.SelectedPath;
			this.m_ExportFolder = this.textExportFolder.Text;
			folderBrowserDialog.Dispose();
		}

		// Token: 0x06000271 RID: 625 RVA: 0x00011CD1 File Offset: 0x0000FED1
		private void checkEditDb_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveDatabase = this.checkSaveDb.Checked;
		}

		// Token: 0x06000272 RID: 626 RVA: 0x00011CE4 File Offset: 0x0000FEE4
		private void textExportFolder_TextChanged(object sender, EventArgs e)
		{
			this.m_ExportFolder = this.textExportFolder.Text;
		}

		// Token: 0x06000273 RID: 627 RVA: 0x00011CF7 File Offset: 0x0000FEF7
		private void checkEditZdata_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveZdata = this.checkSaveZdata.Checked;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x00011D0A File Offset: 0x0000FF0A
		private void checkEditGui_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveGui = this.checkSaveGui.Checked;
		}

		// Token: 0x06000275 RID: 629 RVA: 0x00011D1D File Offset: 0x0000FF1D
		private void radioAutoZdata_CheckedChanged(object sender, EventArgs e)
		{
			this.m_AutoZdata = this.radioAutoZdata.Checked;
		}

		// Token: 0x06000276 RID: 630 RVA: 0x00011D30 File Offset: 0x0000FF30
		private void radioSpecificZdata_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SpecificZdata = this.radioSpecificZdata.Checked;
			this.numericZdata.Enabled = this.radioSpecificZdata.Checked;
		}

		// Token: 0x06000277 RID: 631 RVA: 0x00011D59 File Offset: 0x0000FF59
		private void numericZdata_ValueChanged(object sender, EventArgs e)
		{
			this.m_ZdataNumber = (int)this.numericZdata.Value;
		}

		// Token: 0x06000278 RID: 632 RVA: 0x00011D71 File Offset: 0x0000FF71
		private void radioGuiSaveArchive_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveGuiInArchive = this.radioGuiSaveArchive.Checked;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x00011D84 File Offset: 0x0000FF84
		private void radioGuiSaveFolder_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveGuiInFolder = this.radioGuiSaveFolder.Checked;
		}

		// Token: 0x0600027A RID: 634 RVA: 0x00011D98 File Offset: 0x0000FF98
		private void SaveOptions()
		{
			for (int i = 0; i < this.optionsSet.DataTableOpt.Count; i++)
			{
				string option = this.optionsSet.DataTableOpt[i].Option;
				if (option == "ExportFolderAuto")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_AutoExportFolder ? "1" : "0");
				}
				else if (option == "ExportFolder")
				{
					this.optionsSet.DataTableOpt[i].Value = this.m_ExportFolder;
				}
				else if (option == "DatabaseEditing")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveDatabase ? "1" : "0");
				}
				else if (option == "ZdataEditing")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveZdata ? "1" : "0");
				}
				else if (option == "GuiEditing")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveGui ? "1" : "0");
				}
				else if (option == "AutoZdata")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_AutoZdata ? "1" : "0");
				}
				else if (option == "SpecificZdata")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SpecificZdata ? "1" : "0");
				}
				else if (option == "ZdataNumber")
				{
					this.optionsSet.DataTableOpt[i].Value = this.m_ZdataNumber.ToString();
				}
				else if (option == "SaveZdataInFolder")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveZdataInFolder ? "1" : "0");
				}
				else if (option == "SaveGuiInArchive")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveGuiInArchive ? "1" : "0");
				}
				else if (option == "SaveGuiInFolder")
				{
					this.optionsSet.DataTableOpt[i].Value = (this.m_SaveGuiInFolder ? "1" : "0");
				}
			}
			this.optionsSet.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x0600027B RID: 635 RVA: 0x00012060 File Offset: 0x00010260
		private void buttonOK_Click(object sender, EventArgs e)
		{
			this.SaveOptions();
		}

		// Token: 0x0600027C RID: 636 RVA: 0x00012068 File Offset: 0x00010268
		private void checkAutoExportFolder_CheckedChanged(object sender, EventArgs e)
		{
			this.m_AutoExportFolder = this.checkAutoExportFolder.Checked;
			this.textExportFolder.Enabled = !this.checkAutoExportFolder.Checked;
			this.buttonBrowseExportFolder.Enabled = !this.checkAutoExportFolder.Checked;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x000120B8 File Offset: 0x000102B8
		private void UserOptions_FormClosing(object sender, FormClosingEventArgs e)
		{
			this.SaveOptions();
		}

		// Token: 0x0600027E RID: 638 RVA: 0x000120C0 File Offset: 0x000102C0
		private void radioZdataSaveFolder_CheckedChanged(object sender, EventArgs e)
		{
			this.m_SaveZdataInFolder = this.radioZdataSaveFolder.Checked;
		}

		// Token: 0x0400011B RID: 283
		private string m_XmlFileName;

		// Token: 0x0400011C RID: 284
		public bool m_AutoExportFolder = true;

		// Token: 0x0400011D RID: 285
		public string m_ExportFolder;

		// Token: 0x0400011E RID: 286
		public bool m_SaveDatabase = true;

		// Token: 0x0400011F RID: 287
		public bool m_SaveGui = true;

		// Token: 0x04000120 RID: 288
		public bool m_SaveZdata = true;

		// Token: 0x04000121 RID: 289
		public bool m_AutoZdata = true;

		// Token: 0x04000122 RID: 290
		public bool m_SpecificZdata;

		// Token: 0x04000123 RID: 291
		public bool m_SaveZdataInFolder = true;

		// Token: 0x04000124 RID: 292
		public int m_ZdataNumber;

		// Token: 0x04000125 RID: 293
		public bool m_SaveGuiInArchive;

		// Token: 0x04000126 RID: 294
		public bool m_SaveGuiInFolder = true;
	}
}
