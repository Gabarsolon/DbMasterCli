using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000019 RID: 25
	public partial class NewKitCreator : Form
	{
		// Token: 0x06000114 RID: 276 RVA: 0x0000EC28 File Offset: 0x0000CE28
		public NewKitCreator()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000115 RID: 277 RVA: 0x0000EC3D File Offset: 0x0000CE3D
		public Kit NewKit
		{
			get
			{
				return this.m_NewKit;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000116 RID: 278 RVA: 0x0000EC45 File Offset: 0x0000CE45
		public int NewId
		{
			get
			{
				return this.m_NewId;
			}
		}

		// Token: 0x17000038 RID: 56
		// (set) Token: 0x06000117 RID: 279 RVA: 0x0000EC50 File Offset: 0x0000CE50
		public Kit SourceKit
		{
			set
			{
				this.m_SourceKit = value;
				this.m_Team = this.m_SourceKit.Team;
				this.m_KitType = this.m_SourceKit.kittype;
				this.comboTeams.SelectedItem = this.Team;
				this.comboKitTypes.SelectedIndex = this.m_KitType;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000ECA8 File Offset: 0x0000CEA8
		public Team Team
		{
			get
			{
				return this.m_Team;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000119 RID: 281 RVA: 0x0000ECB0 File Offset: 0x0000CEB0
		public int KitType
		{
			get
			{
				return this.m_KitType;
			}
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000ECB8 File Offset: 0x0000CEB8
		public void SetTeams(TeamList teamList)
		{
			this.comboTeams.Items.Clear();
			this.comboTeams.Items.AddRange(teamList.ToArray());
		}

		// Token: 0x1700003B RID: 59
		// (set) Token: 0x0600011B RID: 283 RVA: 0x0000ECE0 File Offset: 0x0000CEE0
		public KitList KitList
		{
			set
			{
				this.m_KitList = value;
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		private void buttonOK_Click(object sender, EventArgs e)
		{
			if (this.m_KitList == null)
			{
				this.m_NewKit = null;
				return;
			}
			if (this.m_KitList.Exists(this.m_Team.Id, this.m_KitType))
			{
				this.m_NewKit = null;
				return;
			}
			this.m_NewKit = (Kit)this.m_KitList.CloneId(this.m_SourceKit);
			if (this.m_NewKit != null)
			{
				this.m_NewKit.Team = this.m_Team;
				this.m_NewKit.kittype = this.m_KitType;
				this.m_SourceKit.CloneTextures(this.m_NewKit);
				if (this.m_SourceKit.Positions != null)
				{
					for (int i = 0; i < this.m_SourceKit.Positions.Length; i++)
					{
						this.m_NewKit.Positions[i] = this.m_SourceKit.Positions[i];
					}
				}
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000EDC6 File Offset: 0x0000CFC6
		private void comboTeams_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTeams.SelectedItem != null)
			{
				this.m_Team = (Team)this.comboTeams.SelectedItem;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000EDEB File Offset: 0x0000CFEB
		private void comboKitTypes_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboKitTypes.SelectedIndex >= 0)
			{
				this.m_KitType = this.comboKitTypes.SelectedIndex;
			}
		}

		// Token: 0x0400013D RID: 317
		private Kit m_NewKit;

		// Token: 0x0400013E RID: 318
		private int m_NewId = -1;

		// Token: 0x0400013F RID: 319
		private Kit m_SourceKit;

		// Token: 0x04000140 RID: 320
		private Team m_Team;

		// Token: 0x04000141 RID: 321
		private int m_KitType;

		// Token: 0x04000142 RID: 322
		private KitList m_KitList;
	}
}
