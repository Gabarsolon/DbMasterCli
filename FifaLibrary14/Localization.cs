using System;
using System.Globalization;
using System.IO;
using System.Resources;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000002 RID: 2
	public class Localization
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public ResXResourceSet ResxSet
		{
			get
			{
				return this.m_ResxSet;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002058 File Offset: 0x00000258
		public Localization()
		{
			string currentDirectory = Environment.CurrentDirectory;
			string twoLetterISOLanguageName = CultureInfo.CurrentCulture.TwoLetterISOLanguageName;
			this.m_LanguageFileName = currentDirectory + "\\Language." + twoLetterISOLanguageName + ".resx";
			this.m_LanguageDefaultFileName = currentDirectory + "\\Language.resx";
			if (File.Exists(this.m_LanguageFileName))
			{
				this.m_ResxSet = new ResXResourceSet(this.m_LanguageFileName);
				return;
			}
			if (File.Exists(this.m_LanguageFileName))
			{
				this.m_ResxSet = new ResXResourceSet(this.m_LanguageDefaultFileName);
				return;
			}
			this.m_ResxSet = null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020EC File Offset: 0x000002EC
		public string GetString(string s)
		{
			if (this.m_ResxSet == null)
			{
				return s;
			}
			string text = "_" + s;
			return this.m_ResxSet.GetString(text);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000211C File Offset: 0x0000031C
		public void LocalizeControl(Control control)
		{
			string @string = this.GetString(control.Text);
			if (@string != null)
			{
				control.Text = @string;
			}
			Type type = control.GetType();
			if (type.Name == "ListView")
			{
				ListView listView = (ListView)control;
				foreach (object obj in listView.Columns)
				{
					ColumnHeader columnHeader = (ColumnHeader)obj;
					columnHeader.Text = this.GetString(columnHeader.Text);
				}
			}
			foreach (object obj2 in control.Controls)
			{
				Control control2 = (Control)obj2;
				this.LocalizeControl(control2);
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002210 File Offset: 0x00000410
		public void LocalizeMenu(MenuStrip menu)
		{
			foreach (object obj in menu.Items)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
				this.LocalizeMenuItem(toolStripMenuItem);
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000226C File Offset: 0x0000046C
		public void LocalizeMenuItem(ToolStripMenuItem menuItem)
		{
			string @string = this.GetString(menuItem.Text);
			if (@string != null)
			{
				menuItem.Text = @string;
			}
			foreach (object obj in menuItem.DropDownItems)
			{
				ToolStripMenuItem toolStripMenuItem = (ToolStripMenuItem)obj;
				this.LocalizeMenuItem(toolStripMenuItem);
			}
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000022DC File Offset: 0x000004DC
		public void LocalizeToolStrip(ToolStrip toolStrip)
		{
			foreach (object obj in toolStrip.Items)
			{
				ToolStripItem toolStripItem = (ToolStripItem)obj;
				this.LocalizeToolStripItem(toolStripItem);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x00002338 File Offset: 0x00000538
		public void LocalizeToolStripItem(ToolStripItem toolStripItem)
		{
			string text = this.GetString(toolStripItem.Text);
			if (text != null)
			{
				toolStripItem.Text = text;
			}
			text = this.GetString(toolStripItem.ToolTipText);
			if (text != null)
			{
				toolStripItem.ToolTipText = text;
			}
			try
			{
				ToolStripDropDownItem toolStripDropDownItem = (ToolStripDropDownItem)toolStripItem;
				foreach (object obj in toolStripDropDownItem.DropDownItems)
				{
					ToolStripItem toolStripItem2 = (ToolStripItem)obj;
					this.LocalizeToolStripItem(toolStripItem2);
				}
			}
			catch
			{
			}
		}

		// Token: 0x04000001 RID: 1
		private string m_LanguageFileName;

		// Token: 0x04000002 RID: 2
		private string m_LanguageDefaultFileName;

		// Token: 0x04000003 RID: 3
		private ResXResourceSet m_ResxSet;
	}
}
