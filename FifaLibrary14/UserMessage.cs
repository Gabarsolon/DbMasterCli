using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x0200001C RID: 28
	public partial class UserMessage : Form
	{
		// Token: 0x060001BF RID: 447 RVA: 0x0000F544 File Offset: 0x0000D744
		public UserMessage()
		{
			this.InitializeComponent();
			string currentDirectory = Environment.CurrentDirectory;
			CultureInfo currentUICulture = CultureInfo.CurrentUICulture;
			string text = currentUICulture.Name.Substring(0, 2);
			string text2 = currentDirectory + "\\" + text;
			this.m_XmlFileName = null;
			if (Directory.Exists(text2))
			{
				string text3 = text2 + "\\Messages.xml";
				if (File.Exists(text3))
				{
					this.m_XmlFileName = text3;
				}
			}
			if (this.m_XmlFileName == null)
			{
				this.m_XmlFileName = currentDirectory + "\\Messages.xml";
			}
			if (File.Exists(this.m_XmlFileName))
			{
				this.setMessages.ReadXml(this.m_XmlFileName);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000F5EC File Offset: 0x0000D7EC
		public DialogResult ShowMessage(int id)
		{
			string text = null;
			bool flag = true;
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (id == this.setMessages.DataTableMex[i].MexId)
				{
					text = this.setMessages.DataTableMex[i].MexText;
					flag = !this.setMessages.DataTableMex[i].MexSuppressed;
					this.m_CurrentIndex = i;
					break;
				}
			}
			this.textMessage.Text = text;
			if (flag)
			{
				this.SetUpLook(id);
				return base.ShowDialog();
			}
			return DialogResult.OK;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000F68C File Offset: 0x0000D88C
		public DialogResult ShowMessage(int id, int reference)
		{
			string text = null;
			bool flag = true;
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (id == this.setMessages.DataTableMex[i].MexId)
				{
					text = this.setMessages.DataTableMex[i].MexText;
					flag = !this.setMessages.DataTableMex[i].MexSuppressed;
					this.m_CurrentIndex = i;
					break;
				}
			}
			this.textMessage.Text = text + " Reference: " + reference.ToString();
			if (flag)
			{
				this.SetUpLook(id);
				return base.ShowDialog();
			}
			return DialogResult.OK;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000F73C File Offset: 0x0000D93C
		private void SetUpLook(int id)
		{
			if (id < 1000)
			{
				this.textErrorNumber.Text = "Please select your choice";
				this.pictureBox.Image = this.imageList.Images[3];
			}
			else if (id < 3000)
			{
				this.textErrorNumber.Text = "Warning: " + id.ToString();
				this.pictureBox.Image = this.imageList.Images[1];
			}
			else if (id < 5000)
			{
				this.textErrorNumber.Text = "Info: " + id.ToString();
				this.pictureBox.Image = this.imageList.Images[2];
			}
			else if (id < 15000)
			{
				this.textErrorNumber.Text = "Error: " + id.ToString();
				this.pictureBox.Image = this.imageList.Images[0];
			}
			else
			{
				this.textErrorNumber.Text = "Info";
				this.pictureBox.Image = this.imageList.Images[2];
			}
			this.checkSuppressMessage.Visible = id < 10000;
			this.checkSuppressMessage.Checked = false;
			this.buttonOK.Visible = id >= 1000;
			this.buttonNo.Visible = id < 1000;
			this.buttonYes.Visible = id < 1000;
			this.buttonCancel.Visible = id < 1000;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		public DialogResult ShowMessage(int id, string messageText)
		{
			bool flag = true;
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (id == this.setMessages.DataTableMex[i].MexId)
				{
					string mexText = this.setMessages.DataTableMex[i].MexText;
					flag = !this.setMessages.DataTableMex[i].MexSuppressed;
					this.m_CurrentIndex = i;
					break;
				}
			}
			this.textMessage.Text = messageText;
			if (flag)
			{
				this.SetUpLook(id);
				return base.ShowDialog();
			}
			return DialogResult.OK;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x0000F984 File Offset: 0x0000DB84
		public DialogResult ShowMessage(int id, string messageText, bool merge)
		{
			if (!merge)
			{
				return this.ShowMessage(id, messageText);
			}
			string text = null;
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (id == this.setMessages.DataTableMex[i].MexId)
				{
					text = this.setMessages.DataTableMex[i].MexText;
					this.m_CurrentIndex = i;
					break;
				}
			}
			return this.ShowMessage(id, text + "\r\n" + messageText);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000FA08 File Offset: 0x0000DC08
		public void EnableMessages(bool enable)
		{
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (this.setMessages.DataTableMex[i].MexId < 10000)
				{
					this.setMessages.DataTableMex[i].MexSuppressed = !enable;
				}
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000FA78 File Offset: 0x0000DC78
		public void EnableWarnings(bool enable)
		{
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (this.setMessages.DataTableMex[i].MexId < 5000)
				{
					this.setMessages.DataTableMex[i].MexSuppressed = !enable;
				}
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000FAE8 File Offset: 0x0000DCE8
		public void EnableErrors(bool enable)
		{
			for (int i = 0; i < this.setMessages.DataTableMex.Count; i++)
			{
				if (this.setMessages.DataTableMex[i].MexId >= 5000 && this.setMessages.DataTableMex[i].MexId < 10000)
				{
					this.setMessages.DataTableMex[i].MexSuppressed = !enable;
				}
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000FB75 File Offset: 0x0000DD75
		private void checkSuppressMessage_CheckedChanged(object sender, EventArgs e)
		{
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000FB77 File Offset: 0x0000DD77
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.checkSuppressMessage.Checked)
			{
				this.setMessages.DataTableMex[this.m_CurrentIndex].MexSuppressed = true;
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x060001CA RID: 458 RVA: 0x0000FBB3 File Offset: 0x0000DDB3
		private void buttonYes_Click(object sender, EventArgs e)
		{
			if (this.checkSuppressMessage.Checked)
			{
				this.setMessages.DataTableMex[this.m_CurrentIndex].MexSuppressed = true;
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x060001CB RID: 459 RVA: 0x0000FBEF File Offset: 0x0000DDEF
		private void buttonNo_Click(object sender, EventArgs e)
		{
			if (this.checkSuppressMessage.Checked)
			{
				this.setMessages.DataTableMex[this.m_CurrentIndex].MexSuppressed = true;
			}
			this.setMessages.WriteXml(this.m_XmlFileName);
		}

		// Token: 0x040000DA RID: 218
		private int m_CurrentIndex;

		// Token: 0x040000DB RID: 219
		private string m_XmlFileName;
	}
}
