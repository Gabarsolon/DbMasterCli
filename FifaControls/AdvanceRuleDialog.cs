using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x02000016 RID: 22
	public partial class AdvanceRuleDialog : Form
	{
		// Token: 0x060000CB RID: 203 RVA: 0x0000C393 File Offset: 0x0000A593
		public AdvanceRuleDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000CC RID: 204 RVA: 0x0000C3A1 File Offset: 0x0000A5A1
		// (set) Token: 0x060000CD RID: 205 RVA: 0x0000C3A9 File Offset: 0x0000A5A9
		public Rank Rule
		{
			get
			{
				return this.m_Rule;
			}
			set
			{
				this.m_Rule = value;
				this.LoadToPanel();
			}
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000C3B8 File Offset: 0x0000A5B8
		public void Preset()
		{
			if (this.comboTrophy.Items.Count != FifaEnvironment.CompetitionObjects.Trophies.Count)
			{
				this.comboTrophy.Items.Clear();
				this.comboTrophy.Items.AddRange(FifaEnvironment.CompetitionObjects.Trophies.ToArray());
			}
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000C418 File Offset: 0x0000A618
		private void LoadToPanel()
		{
			this.Preset();
			Group group = null;
			if (this.m_Rule.MoveFrom != null)
			{
				group = this.m_Rule.MoveFrom.Group;
				if (group != null)
				{
					this.m_Trophy = group.ParentTrophy;
				}
			}
			if (group == null)
			{
				group = this.m_Rule.Group;
			}
			if (this.m_Trophy == null)
			{
				this.m_Trophy = this.m_Rule.Group.ParentTrophy;
			}
			this.comboTrophy.SelectedItem = this.m_Trophy;
			this.comboStage.Items.Clear();
			foreach (object obj in this.m_Trophy.Stages)
			{
				Stage stage = (Stage)obj;
				this.comboStage.Items.Add(stage);
			}
			if (group != null)
			{
				this.m_Stage = group.ParentStage;
			}
			else
			{
				this.m_Stage = this.m_Rule.Group.ParentStage;
			}
			this.comboStage.SelectedItem = this.m_Stage;
			this.comboGroup.Items.Clear();
			foreach (object obj2 in this.m_Stage.Groups)
			{
				Group group2 = (Group)obj2;
				this.comboGroup.Items.Add(group2);
			}
			this.m_Group = group;
			this.comboGroup.SelectedItem = group;
			this.comboTeam.Items.Clear();
			foreach (object obj3 in this.m_Group.Ranks)
			{
				Rank rank = (Rank)obj3;
				this.comboTeam.Items.Add(rank);
			}
			this.comboTeam.SelectedItem = this.m_Rule.MoveFrom;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000C64C File Offset: 0x0000A84C
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

		// Token: 0x060000D1 RID: 209 RVA: 0x0000C6FC File Offset: 0x0000A8FC
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
				if (this.m_Stage.Groups.Count >= 1)
				{
					this.comboGroup.SelectedIndex = 0;
				}
			}
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000C7C0 File Offset: 0x0000A9C0
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

		// Token: 0x060000D3 RID: 211 RVA: 0x0000C870 File Offset: 0x0000AA70
		private void comboTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.m_Rule.MoveFrom = (Rank)this.comboTeam.SelectedItem;
		}

		// Token: 0x040000F9 RID: 249
		private Rank m_Rule;

		// Token: 0x040000FA RID: 250
		private Trophy m_Trophy;

		// Token: 0x040000FB RID: 251
		private Stage m_Stage;

		// Token: 0x040000FC RID: 252
		private Group m_Group;
	}
}
