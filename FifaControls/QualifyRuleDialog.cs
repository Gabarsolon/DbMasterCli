using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using FifaLibrary;

namespace FifaControls
{
	// Token: 0x0200000D RID: 13
	public partial class QualifyRuleDialog : Form
	{
		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000060A7 File Offset: 0x000042A7
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000060AF File Offset: 0x000042AF
		public Task QualifyRule
		{
			get
			{
				return this.m_QualifyRule;
			}
			set
			{
				this.m_QualifyRule = value;
				this.LoadToPanel();
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000060C0 File Offset: 0x000042C0
		private void LoadToPanel()
		{
			this.Preset();
			this.m_Rule = this.m_QualifyRule.Rule;
			switch (this.m_Rule)
			{
			case EQualifyingRule.FillFromLeague:
				this.m_League = this.m_QualifyRule.League;
				this.comboLeague.SelectedItem = this.m_League;
				this.radioRule4.Checked = true;
				break;
			case EQualifyingRule.FillFromCompTable:
				this.m_Trophy1 = this.m_QualifyRule.Trophy1;
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.m_Number = this.m_QualifyRule.Parameter2;
				this.numericN.Value = this.m_Number;
				this.radioRule1.Checked = true;
				break;
			case EQualifyingRule.FillFromCompTableBackup:
				this.m_Trophy1 = this.m_QualifyRule.Trophy1;
				this.m_Trophy2 = this.m_QualifyRule.Trophy2;
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.comboTrophy2.SelectedItem = this.m_Trophy2;
				this.radioRule2.Checked = true;
				break;
			case EQualifyingRule.FillFromCompTableBackupLeague:
				this.m_Trophy1 = this.m_QualifyRule.Trophy1;
				this.m_League = this.m_QualifyRule.League;
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.comboLeague.SelectedItem = this.m_League;
				this.radioRule3.Checked = true;
				break;
			case EQualifyingRule.FillFromLeagueMaxFromCountry:
				this.m_League = this.m_QualifyRule.League;
				this.comboLeague.SelectedItem = this.m_League;
				this.m_Number = this.m_QualifyRule.Parameter2;
				this.m_CountryLimitation = (uint)this.m_QualifyRule.Parameter3;
				this.numericN.Value = this.m_Number;
				this.numericCountryLimitation.Value = this.m_CountryLimitation;
				this.radioRule5.Checked = true;
				break;
			case EQualifyingRule.FillFromSpecialTeams:
				this.m_Number = this.m_QualifyRule.Parameter1;
				this.numericN.Value = this.m_Number;
				this.radioRule6.Checked = true;
				break;
			case EQualifyingRule.FillWithTeam:
				this.m_Team = this.m_QualifyRule.Team;
				this.comboTeam.SelectedItem = this.m_Team;
				this.m_Number = this.m_QualifyRule.Parameter1;
				this.numericN.Value = this.m_Number;
				this.radioRule7.Checked = true;
				break;
			}
			this.EnableRule();
		}

		// Token: 0x06000077 RID: 119 RVA: 0x00006360 File Offset: 0x00004560
		public void Preset()
		{
			if (this.comboTrophy1.Items.Count != FifaEnvironment.CompetitionObjects.Trophies.Count)
			{
				this.comboTrophy1.Items.Clear();
				this.comboTrophy1.Items.AddRange(FifaEnvironment.CompetitionObjects.Trophies.ToArray());
			}
			if (this.comboTrophy2.Items.Count != FifaEnvironment.CompetitionObjects.Trophies.Count)
			{
				this.comboTrophy2.Items.Clear();
				this.comboTrophy2.Items.AddRange(FifaEnvironment.CompetitionObjects.Trophies.ToArray());
			}
			if (this.comboLeague.Items.Count != FifaEnvironment.Leagues.Count)
			{
				this.comboLeague.Items.Clear();
				this.comboLeague.Items.AddRange(FifaEnvironment.Leagues.ToArray());
			}
			if (this.comboTeam.Items.Count != FifaEnvironment.Teams.Count)
			{
				this.comboTeam.Items.Clear();
				this.comboTeam.Items.AddRange(FifaEnvironment.Teams.ToArray());
			}
		}

		// Token: 0x06000078 RID: 120 RVA: 0x00006499 File Offset: 0x00004699
		public QualifyRuleDialog()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000079 RID: 121 RVA: 0x000064A7 File Offset: 0x000046A7
		private void radioRule1_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromCompTable;
			this.EnableRule();
		}

		// Token: 0x0600007A RID: 122 RVA: 0x000064B6 File Offset: 0x000046B6
		private void radioRule2_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromCompTableBackup;
			this.EnableRule();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x000064C5 File Offset: 0x000046C5
		private void radioRule3_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromCompTableBackupLeague;
			this.EnableRule();
		}

		// Token: 0x0600007C RID: 124 RVA: 0x000064D4 File Offset: 0x000046D4
		private void radioRule4_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromLeague;
			this.EnableRule();
		}

		// Token: 0x0600007D RID: 125 RVA: 0x000064E3 File Offset: 0x000046E3
		private void radioRule5_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromLeagueMaxFromCountry;
			this.EnableRule();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x000064F2 File Offset: 0x000046F2
		private void radioRule6_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromSpecialTeams;
			this.EnableRule();
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00006501 File Offset: 0x00004701
		private void radioRule7_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillWithTeam;
			this.EnableRule();
		}

		// Token: 0x06000080 RID: 128 RVA: 0x00006510 File Offset: 0x00004710
		private void radioRule8_CheckedChanged(object sender, EventArgs e)
		{
			this.m_Rule = EQualifyingRule.FillFromLeagueInOrder;
			this.EnableRule();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x00006520 File Offset: 0x00004720
		private void EnableRule()
		{
			switch (this.m_Rule)
			{
			case EQualifyingRule.FillFromLeague:
				this.comboLeague.SelectedItem = this.m_League;
				this.comboTrophy1.Visible = false;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = true;
				this.comboTeam.Visible = false;
				this.numericN.Visible = false;
				this.numericCountryLimitation.Visible = false;
				return;
			case EQualifyingRule.FillFromLeagueInOrder:
				this.comboLeague.SelectedItem = this.m_League;
				this.comboTrophy1.Visible = false;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = true;
				this.comboTeam.Visible = false;
				this.numericN.Visible = false;
				this.numericCountryLimitation.Visible = false;
				return;
			case EQualifyingRule.FillFromCompTable:
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.numericN.Value = this.m_Number;
				this.comboTrophy1.Visible = true;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = false;
				this.comboTeam.Visible = false;
				this.numericN.Visible = true;
				this.numericCountryLimitation.Visible = false;
				this.m_Trophy1 = (Trophy)this.comboTrophy1.SelectedItem;
				return;
			case EQualifyingRule.FillFromCompTableBackup:
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.comboTrophy2.SelectedItem = this.m_Trophy2;
				this.comboTrophy1.Visible = true;
				this.comboTrophy2.Visible = true;
				this.comboLeague.Visible = false;
				this.comboTeam.Visible = false;
				this.numericN.Visible = false;
				this.numericCountryLimitation.Visible = false;
				return;
			case EQualifyingRule.FillFromCompTableBackupLeague:
				this.comboTrophy1.SelectedItem = this.m_Trophy1;
				this.comboLeague.SelectedItem = this.m_League;
				this.comboTrophy1.Visible = true;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = true;
				this.comboTeam.Visible = false;
				this.numericN.Visible = false;
				this.numericCountryLimitation.Visible = false;
				return;
			case EQualifyingRule.FillFromLeagueMaxFromCountry:
				this.comboLeague.SelectedItem = this.m_League;
				this.numericCountryLimitation.Value = this.m_CountryLimitation;
				this.numericN.Value = this.m_Number;
				this.comboTrophy1.Visible = false;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = true;
				this.comboTeam.Visible = false;
				this.numericN.Visible = true;
				this.numericCountryLimitation.Visible = true;
				return;
			case EQualifyingRule.FillFromSpecialTeams:
				this.numericN.Value = this.m_Number;
				this.comboTrophy1.Visible = false;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = false;
				this.comboTeam.Visible = false;
				this.numericN.Visible = true;
				this.numericCountryLimitation.Visible = false;
				return;
			case EQualifyingRule.FillWithTeam:
				this.comboTeam.SelectedItem = this.m_Team;
				this.numericN.Value = this.m_Number;
				this.comboTrophy1.Visible = false;
				this.comboTrophy2.Visible = false;
				this.comboLeague.Visible = false;
				this.comboTeam.Visible = true;
				this.numericN.Visible = true;
				this.numericCountryLimitation.Visible = false;
				return;
			default:
				return;
			}
		}

		// Token: 0x06000082 RID: 130 RVA: 0x000068BF File Offset: 0x00004ABF
		private void comboTeam_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTeam.SelectedItem != null)
			{
				this.m_Team = (Team)this.comboTeam.SelectedItem;
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x000068E4 File Offset: 0x00004AE4
		private void numericN_ValueChanged(object sender, EventArgs e)
		{
			this.m_Number = (int)this.numericN.Value;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x000068FC File Offset: 0x00004AFC
		private void comboTrophy1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTrophy1.SelectedItem != null)
			{
				this.m_Trophy1 = (Trophy)this.comboTrophy1.SelectedItem;
			}
		}

		// Token: 0x06000085 RID: 133 RVA: 0x00006921 File Offset: 0x00004B21
		private void comboLeague_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboLeague.SelectedItem != null)
			{
				this.m_League = (League)this.comboLeague.SelectedItem;
			}
		}

		// Token: 0x06000086 RID: 134 RVA: 0x00006946 File Offset: 0x00004B46
		private void comboTrophy2_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboTrophy2.SelectedItem != null)
			{
				this.m_Trophy2 = (Trophy)this.comboTrophy2.SelectedItem;
			}
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000696C File Offset: 0x00004B6C
		private void buttonOk_Click(object sender, EventArgs e)
		{
			this.m_QualifyRule.Rule = this.m_Rule;
			switch (this.m_Rule)
			{
			case EQualifyingRule.FillFromLeague:
				if (this.m_League != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_League.Id;
					this.m_QualifyRule.League = this.m_League;
					this.m_QualifyRule.Parameter2 = 0;
					this.m_QualifyRule.Parameter3 = 0;
					return;
				}
				break;
			case EQualifyingRule.FillFromLeagueInOrder:
				break;
			case EQualifyingRule.FillFromCompTable:
				if (this.m_Trophy1 != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_Trophy1.Id;
					this.m_QualifyRule.Trophy1 = this.m_Trophy1;
					this.m_QualifyRule.Parameter2 = this.m_Number;
					this.m_QualifyRule.Parameter3 = 0;
					return;
				}
				break;
			case EQualifyingRule.FillFromCompTableBackup:
				if (this.m_Trophy2 != null && this.m_Trophy1 != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_Trophy1.Id;
					this.m_QualifyRule.Trophy1 = this.m_Trophy1;
					this.m_QualifyRule.Parameter2 = this.m_Trophy2.Id;
					this.m_QualifyRule.Trophy2 = this.m_Trophy2;
					this.m_QualifyRule.Parameter3 = 1;
					return;
				}
				break;
			case EQualifyingRule.FillFromCompTableBackupLeague:
				if (this.m_League != null && this.m_Trophy1 != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_Trophy1.Id;
					this.m_QualifyRule.Trophy1 = this.m_Trophy1;
					this.m_QualifyRule.Parameter2 = this.m_League.Id;
					this.m_QualifyRule.League = this.m_League;
					this.m_QualifyRule.Parameter3 = 1;
					return;
				}
				break;
			case EQualifyingRule.FillFromLeagueMaxFromCountry:
				if (this.m_League != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_League.Id;
					this.m_QualifyRule.League = this.m_League;
					this.m_QualifyRule.Parameter2 = this.m_Number;
					this.m_QualifyRule.Parameter3 = (int)this.m_CountryLimitation;
					return;
				}
				break;
			case EQualifyingRule.FillFromSpecialTeams:
				this.m_QualifyRule.Parameter1 = this.m_Number;
				this.m_QualifyRule.Parameter2 = 0;
				this.m_QualifyRule.Parameter3 = 0;
				return;
			case EQualifyingRule.FillWithTeam:
				if (this.m_Team != null)
				{
					this.m_QualifyRule.Parameter1 = this.m_Number;
					this.m_QualifyRule.Parameter2 = this.m_Team.Id;
					this.m_QualifyRule.Team = this.m_Team;
					this.m_QualifyRule.Parameter3 = 0;
				}
				break;
			default:
				return;
			}
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00006C00 File Offset: 0x00004E00
		private void numericCountryLimitation_ValueChanged(object sender, EventArgs e)
		{
			this.m_CountryLimitation = (uint)this.numericCountryLimitation.Value;
		}

		// Token: 0x04000077 RID: 119
		private Task m_QualifyRule;

		// Token: 0x04000078 RID: 120
		private EQualifyingRule m_Rule;

		// Token: 0x04000079 RID: 121
		private Trophy m_Trophy1;

		// Token: 0x0400007A RID: 122
		private Trophy m_Trophy2;

		// Token: 0x0400007B RID: 123
		private League m_League;

		// Token: 0x0400007C RID: 124
		private Team m_Team;

		// Token: 0x0400007D RID: 125
		private int m_Number;

		// Token: 0x0400007E RID: 126
		private uint m_CountryLimitation;
	}
}
