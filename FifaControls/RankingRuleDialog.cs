using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x0200000C RID: 12
	public partial class RankingRuleDialog : Form
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00004D1E File Offset: 0x00002F1E
		public RankingRuleDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000068 RID: 104 RVA: 0x00004D2C File Offset: 0x00002F2C
		// (set) Token: 0x06000069 RID: 105 RVA: 0x00004D34 File Offset: 0x00002F34
		public Rank Rank
		{
			get
			{
				return this.m_Rank;
			}
			set
			{
				this.m_Rank = value;
				this.LoadToPanel();
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00004D44 File Offset: 0x00002F44
		public void Preset()
		{
			if (this.comboTrophy.Items.Count != FifaEnvironment.CompetitionObjects.Trophies.Count)
			{
				this.comboTrophy.Items.Clear();
				this.comboTrophy.Items.AddRange(FifaEnvironment.CompetitionObjects.Trophies.ToArray());
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00004DA4 File Offset: 0x00002FA4
		private void LoadToPanel()
		{
			this.Preset();
			Group group = null;
			group = this.m_Rank.Group;
			if (group == null)
			{
				return;
			}
			this.m_Trophy = group.ParentTrophy;
			if (this.m_Trophy == null)
			{
				return;
			}
			this.comboTrophy.SelectedItem = this.m_Trophy;
			this.comboStage.Items.Clear();
			foreach (object obj in this.m_Trophy.Stages)
			{
				Stage stage = (Stage)obj;
				this.comboStage.Items.Add(stage);
			}
			this.m_Stage = this.m_Rank.Group.ParentStage;
			this.comboStage.SelectedItem = this.m_Stage;
			this.comboGroup.Items.Clear();
			foreach (object obj2 in this.m_Stage.Groups)
			{
				Group group2 = (Group)obj2;
				this.comboGroup.Items.Add(group2);
			}
			this.m_Group = group;
			this.comboGroup.SelectedItem = this.m_Group;
			this.comboTeam.Items.Clear();
			for (int i = 1; i < this.m_Group.Ranks.Count; i++)
			{
				this.comboTeam.Items.Add(this.m_Group.Ranks[i]);
			}
			this.comboTeam.SelectedItem = this.m_Rank;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00004F70 File Offset: 0x00003170
		private void comboTrophy_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTrophy.SelectedItem != this.m_Trophy)
			{
				this.m_Trophy = (Trophy)this.comboTrophy.SelectedItem;
				this.comboStage.Items.Clear();
				foreach (object obj in this.m_Trophy.Stages)
				{
					Stage stage = (Stage)obj;
					this.comboStage.Items.Add(stage);
				}
				this.comboStage.SelectedIndex = 0;
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00005020 File Offset: 0x00003220
		private void comboStage_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboStage.SelectedItem != this.m_Stage)
			{
				this.m_Stage = (Stage)this.comboStage.SelectedItem;
				this.comboGroup.Items.Clear();
				foreach (object obj in this.m_Stage.Groups)
				{
					Group group = (Group)obj;
					this.comboGroup.Items.Add(group);
				}
				this.comboGroup.SelectedIndex = 0;
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x000050D0 File Offset: 0x000032D0
		private void comboGroup_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboGroup.SelectedItem != this.m_Group)
			{
				this.m_Group = (Group)this.comboGroup.SelectedItem;
				this.comboTeam.Items.Clear();
				foreach (object obj in this.m_Group.Ranks)
				{
					Rank rank = (Rank)obj;
					this.comboTeam.Items.Add(rank);
				}
				this.comboTeam.SelectedIndex = 0;
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00005180 File Offset: 0x00003380
		private void comboTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.m_Rank = (Rank)this.comboTeam.SelectedItem;
		}

		// Token: 0x0400005A RID: 90
		private Rank m_Rank;

		// Token: 0x0400005B RID: 91
		private Trophy m_Trophy;

		// Token: 0x0400005C RID: 92
		private Stage m_Stage;

		// Token: 0x0400005D RID: 93
		private Group m_Group;
	}
}
