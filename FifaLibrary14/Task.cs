using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000051 RID: 81
	public class Task
	{
		// Token: 0x17000199 RID: 409
		// (get) Token: 0x06000771 RID: 1905 RVA: 0x0002ACA4 File Offset: 0x00028EA4
		// (set) Token: 0x06000772 RID: 1906 RVA: 0x0002ACAC File Offset: 0x00028EAC
		public string When
		{
			get
			{
				return this.m_When;
			}
			set
			{
				this.m_When = value;
			}
		}

		// Token: 0x1700019A RID: 410
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0002ACB5 File Offset: 0x00028EB5
		// (set) Token: 0x06000774 RID: 1908 RVA: 0x0002ACBD File Offset: 0x00028EBD
		public string Action
		{
			get
			{
				return this.m_Action;
			}
			set
			{
				this.m_Action = value;
			}
		}

		// Token: 0x1700019B RID: 411
		// (get) Token: 0x06000775 RID: 1909 RVA: 0x0002ACC6 File Offset: 0x00028EC6
		// (set) Token: 0x06000776 RID: 1910 RVA: 0x0002ACCE File Offset: 0x00028ECE
		public EQualifyingRule Rule
		{
			get
			{
				return this.m_Rule;
			}
			set
			{
				this.m_Rule = value;
				this.m_Action = this.m_Rule.ToString();
			}
		}

		// Token: 0x1700019C RID: 412
		// (get) Token: 0x06000777 RID: 1911 RVA: 0x0002ACED File Offset: 0x00028EED
		public int GroupId
		{
			get
			{
				return this.m_TargetCompObjId;
			}
		}

		// Token: 0x1700019D RID: 413
		// (get) Token: 0x06000778 RID: 1912 RVA: 0x0002ACF5 File Offset: 0x00028EF5
		// (set) Token: 0x06000779 RID: 1913 RVA: 0x0002ACFD File Offset: 0x00028EFD
		public int Parameter1
		{
			get
			{
				return this.m_Parameter1;
			}
			set
			{
				this.m_Parameter1 = value;
			}
		}

		// Token: 0x1700019E RID: 414
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0002AD06 File Offset: 0x00028F06
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0002AD0E File Offset: 0x00028F0E
		public int Parameter2
		{
			get
			{
				return this.m_Parameter2;
			}
			set
			{
				this.m_Parameter2 = value;
			}
		}

		// Token: 0x1700019F RID: 415
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0002AD17 File Offset: 0x00028F17
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0002AD1F File Offset: 0x00028F1F
		public int Parameter3
		{
			get
			{
				return this.m_Parameter3;
			}
			set
			{
				this.m_Parameter3 = value;
			}
		}

		// Token: 0x170001A0 RID: 416
		// (get) Token: 0x0600077E RID: 1918 RVA: 0x0002AD28 File Offset: 0x00028F28
		// (set) Token: 0x0600077F RID: 1919 RVA: 0x0002AD30 File Offset: 0x00028F30
		public Group Group
		{
			get
			{
				return this.m_Group;
			}
			set
			{
				this.m_Group = value;
				this.m_TargetCompObjId = this.m_Group.Id;
			}
		}

		// Token: 0x170001A1 RID: 417
		// (get) Token: 0x06000780 RID: 1920 RVA: 0x0002AD4A File Offset: 0x00028F4A
		// (set) Token: 0x06000781 RID: 1921 RVA: 0x0002AD52 File Offset: 0x00028F52
		public Stage Stage
		{
			get
			{
				return this.m_Stage;
			}
			set
			{
				this.m_Stage = value;
				this.m_TargetCompObjId = this.m_Stage.Id;
			}
		}

		// Token: 0x170001A2 RID: 418
		// (get) Token: 0x06000782 RID: 1922 RVA: 0x0002AD6C File Offset: 0x00028F6C
		// (set) Token: 0x06000783 RID: 1923 RVA: 0x0002AD74 File Offset: 0x00028F74
		public Trophy Trophy
		{
			get
			{
				return this.m_Trophy;
			}
			set
			{
				this.m_Trophy = value;
				this.m_TargetCompObjId = this.m_Trophy.Id;
			}
		}

		// Token: 0x170001A3 RID: 419
		// (get) Token: 0x06000784 RID: 1924 RVA: 0x0002AD8E File Offset: 0x00028F8E
		// (set) Token: 0x06000785 RID: 1925 RVA: 0x0002AD96 File Offset: 0x00028F96
		public Trophy Trophy1
		{
			get
			{
				return this.m_Trophy1;
			}
			set
			{
				this.m_Trophy1 = value;
			}
		}

		// Token: 0x170001A4 RID: 420
		// (get) Token: 0x06000786 RID: 1926 RVA: 0x0002AD9F File Offset: 0x00028F9F
		// (set) Token: 0x06000787 RID: 1927 RVA: 0x0002ADA7 File Offset: 0x00028FA7
		public Trophy Trophy2
		{
			get
			{
				return this.m_Trophy2;
			}
			set
			{
				this.m_Trophy2 = value;
			}
		}

		// Token: 0x170001A5 RID: 421
		// (get) Token: 0x06000788 RID: 1928 RVA: 0x0002ADB0 File Offset: 0x00028FB0
		// (set) Token: 0x06000789 RID: 1929 RVA: 0x0002ADB8 File Offset: 0x00028FB8
		public League League
		{
			get
			{
				return this.m_League;
			}
			set
			{
				this.m_League = value;
			}
		}

		// Token: 0x170001A6 RID: 422
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0002ADC1 File Offset: 0x00028FC1
		// (set) Token: 0x0600078B RID: 1931 RVA: 0x0002ADC9 File Offset: 0x00028FC9
		public Team Team
		{
			get
			{
				return this.m_Team;
			}
			set
			{
				this.m_Team = value;
			}
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0002ADD2 File Offset: 0x00028FD2
		public Task(string when, string action, int targetCompObjId, int par1, int par2, int par3)
		{
			this.m_When = when;
			this.m_Action = action;
			this.m_TargetCompObjId = targetCompObjId;
			this.m_Parameter1 = par1;
			this.m_Parameter2 = par2;
			this.m_Parameter3 = par3;
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0002AE08 File Offset: 0x00029008
		public Task(Task currentTask)
		{
			this.m_When = currentTask.m_When;
			this.m_Action = currentTask.m_Action;
			this.m_TargetCompObjId = currentTask.m_TargetCompObjId;
			this.m_Parameter1 = currentTask.m_Parameter1;
			this.m_Parameter2 = currentTask.m_Parameter2;
			this.m_Parameter3 = currentTask.m_Parameter3;
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0002AE63 File Offset: 0x00029063
		public void LinkCompetitions(Compobj ownerCompobj)
		{
			if (ownerCompobj.IsGroup())
			{
				this.LinkGroup((Group)ownerCompobj);
				return;
			}
			if (ownerCompobj.IsStage())
			{
				this.LinkStage((Stage)ownerCompobj);
				return;
			}
			if (ownerCompobj.IsTrophy())
			{
				this.LinkTrophy((Trophy)ownerCompobj);
			}
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0002AEA4 File Offset: 0x000290A4
		public void LinkGroup(Group ownerGroup)
		{
			this.m_Group = ownerGroup;
			this.m_TargetCompObjId = ownerGroup.Id;
			if (this.m_Action == "FillFromCompTable")
			{
				this.m_Rule = EQualifyingRule.FillFromCompTable;
				this.m_Trophy1 = (Trophy)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter1);
				this.m_Trophy2 = null;
				this.m_League = null;
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillFromCompTableBackup")
			{
				this.m_Rule = EQualifyingRule.FillFromCompTableBackup;
				this.m_Trophy1 = (Trophy)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter1);
				this.m_Trophy2 = (Trophy)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter2);
				this.m_League = null;
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillFromCompTableBackupLeague")
			{
				this.m_Rule = EQualifyingRule.FillFromCompTableBackupLeague;
				Compobj compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter1);
				if (compobj.IsTrophy())
				{
					this.m_Trophy1 = (Trophy)compobj;
				}
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter2);
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillFromLeague")
			{
				this.m_Rule = EQualifyingRule.FillFromLeague;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillFromLeagueMaxFromCountry")
			{
				this.m_Rule = EQualifyingRule.FillFromLeagueMaxFromCountry;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillFromSpecialTeams")
			{
				this.m_Rule = EQualifyingRule.FillFromSpecialTeams;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = null;
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "FillWithTeam")
			{
				this.m_Rule = EQualifyingRule.FillWithTeam;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = null;
				Team team = (Team)FifaEnvironment.Teams.SearchId(this.m_Parameter2);
				this.m_Team = team;
				return;
			}
			if (this.m_Action == "FillFromLeagueInOrder")
			{
				this.m_Rule = EQualifyingRule.FillFromLeagueInOrder;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
			}
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0002B138 File Offset: 0x00029338
		public void LinkStage(Stage ownerStage)
		{
			this.m_Stage = ownerStage;
			this.m_TargetCompObjId = ownerStage.Id;
			if (this.m_Action == "UpdateLeagueTable")
			{
				this.m_Rule = EQualifyingRule.NoRule;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "UpdateLeagueStats")
			{
				this.m_Rule = EQualifyingRule.NoRule;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
				return;
			}
			if (this.m_Action == "ClearLeagueStats")
			{
				this.m_Rule = EQualifyingRule.NoRule;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = (League)FifaEnvironment.Leagues.SearchId(this.m_Parameter1);
				this.m_Team = null;
			}
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0002B238 File Offset: 0x00029438
		public void LinkTrophy(Trophy ownerTrophy)
		{
			this.m_Trophy = ownerTrophy;
			this.m_TargetCompObjId = ownerTrophy.Id;
			if (this.m_Action == "UpdateTable")
			{
				this.m_Rule = EQualifyingRule.NoRule;
				this.m_Trophy1 = null;
				this.m_Trophy2 = null;
				this.m_League = null;
				this.m_Team = null;
				Compobj compobj = (Compobj)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter1);
				if (compobj != null && compobj.IsGroup())
				{
					this.m_Group = (Group)FifaEnvironment.CompetitionObjects.SearchId(this.m_Parameter1);
				}
			}
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0002B2CC File Offset: 0x000294CC
		public override string ToString()
		{
			string text = "To be defined";
			if (this.m_Action == "UpdateTable")
			{
				if (this.m_Group != null)
				{
					text = string.Concat(new string[]
					{
						"Team n.",
						this.m_Parameter2.ToString(),
						" of ",
						this.m_Group.ParentStage.ToString(),
						" - ",
						this.m_Group.ToString()
					});
				}
			}
			else if (this.m_Action == "ClearLeagueStats")
			{
				if (this.m_League != null)
				{
					text = "Clear Stats of league: " + this.m_League.ToString();
				}
			}
			else if (this.m_Action == "UpdateLeagueTable")
			{
				if (this.m_League != null)
				{
					text = "Update Table of league: " + this.m_League.ToString();
				}
			}
			else if (this.m_Action == "UpdateLeagueStats")
			{
				if (this.m_League != null)
				{
					text = "Update Stats of league: " + this.m_League.ToString();
				}
			}
			else
			{
				switch (this.m_Rule)
				{
				case EQualifyingRule.FillFromLeague:
					if (this.m_League != null)
					{
						text = "Get teams from league: " + this.m_League.ToString();
						this.m_Parameter1 = this.m_League.Id;
					}
					break;
				case EQualifyingRule.FillFromLeagueInOrder:
					if (this.m_League != null)
					{
						text = "Get teams in order from league: " + this.m_League.ToString();
						this.m_Parameter1 = this.m_League.Id;
					}
					break;
				case EQualifyingRule.FillFromCompTable:
					if (this.m_Trophy1 != null)
					{
						if (this.m_Parameter2 == 1)
						{
							text = "Get winner of " + this.m_Trophy1.ToString();
						}
						else
						{
							text = "Get best " + this.m_Parameter2.ToString() + " teams of " + this.m_Trophy1.ToString();
						}
						this.m_Parameter1 = this.m_Trophy1.Id;
					}
					break;
				case EQualifyingRule.FillFromCompTableBackup:
					if (this.m_Trophy1 != null && this.m_Trophy2 != null)
					{
						text = "Get winner of " + this.m_Trophy1.ToString() + " or a team from " + this.m_Trophy2.ToString();
						this.m_Parameter1 = this.m_Trophy1.Id;
						this.m_Parameter2 = this.m_Trophy2.Id;
					}
					break;
				case EQualifyingRule.FillFromCompTableBackupLeague:
					if (this.m_Trophy1 != null && this.m_League != null)
					{
						text = "Get winner of " + this.m_Trophy1.ToString() + " or a team from league: " + this.m_League.ToString();
						this.m_Parameter1 = this.m_Trophy1.Id;
						this.m_Parameter2 = this.m_League.Id;
					}
					break;
				case EQualifyingRule.FillFromLeagueMaxFromCountry:
					if (this.m_League != null)
					{
						text = string.Concat(new string[]
						{
							"Get up to ",
							this.m_Parameter2.ToString(),
							" team(s) from league: ",
							this.m_League.ToString(),
							" (max ",
							this.m_Parameter3.ToString(),
							")"
						});
						this.m_Parameter1 = this.m_League.Id;
					}
					break;
				case EQualifyingRule.FillFromSpecialTeams:
					text = "Get " + this.m_Parameter1.ToString() + " team(s) from Special Teams Group";
					break;
				case EQualifyingRule.FillWithTeam:
					if (this.m_Team != null)
					{
						text = "Get Specific Team: " + this.m_Team.ToString();
						if (this.m_Parameter1 != 0)
						{
							text = text + " at position " + this.m_Parameter1.ToString();
						}
						this.m_Parameter2 = this.m_Team.Id;
					}
					break;
				}
			}
			return text;
		}

		// Token: 0x06000793 RID: 1939 RVA: 0x0002B6B0 File Offset: 0x000298B0
		public bool SaveToTasks(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			string text = null;
			if (this.m_When == "start")
			{
				if (this.m_Group != null)
				{
					text = string.Concat(new string[]
					{
						this.m_Group.ParentTrophy.Id.ToString(),
						",start,",
						this.m_Action,
						",",
						this.m_Group.Id.ToString(),
						","
					});
				}
				else if (this.m_Stage != null)
				{
					text = string.Concat(new string[]
					{
						this.m_Stage.Trophy.Id.ToString(),
						",start,",
						this.m_Action,
						",",
						this.m_Stage.Id.ToString(),
						","
					});
				}
				if (this.m_Action == "FillFromCompTable")
				{
					string text2 = text;
					text = string.Concat(new string[]
					{
						text2,
						(this.m_Trophy1 != null) ? this.m_Trophy1.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromCompTableBackup")
				{
					string text3 = text;
					text = string.Concat(new string[]
					{
						text3,
						(this.m_Trophy1 != null) ? this.m_Trophy1.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						(this.m_Trophy2 != null) ? this.m_Trophy2.Id.ToString() : this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromCompTableBackupLeague")
				{
					string text4 = text;
					text = string.Concat(new string[]
					{
						text4,
						(this.m_Trophy1 != null) ? this.m_Trophy1.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						(this.m_League != null) ? this.m_League.Id.ToString() : this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromLeague")
				{
					string text5 = text;
					text = string.Concat(new string[]
					{
						text5,
						(this.m_League != null) ? this.m_League.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromLeagueMaxFromCountry")
				{
					string text6 = text;
					text = string.Concat(new string[]
					{
						text6,
						(this.m_League != null) ? this.m_League.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromSpecialTeams")
				{
					string text7 = text;
					text = string.Concat(new string[]
					{
						text7,
						this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillWithTeam")
				{
					string text8 = text;
					text = string.Concat(new string[]
					{
						text8,
						this.m_Parameter1.ToString(),
						",",
						(this.m_Team != null) ? this.m_Team.Id.ToString() : this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "FillFromLeagueInOrder")
				{
					string text9 = text;
					text = string.Concat(new string[]
					{
						text9,
						(this.m_League != null) ? this.m_League.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else if (this.m_Action == "ClearLeagueStats")
				{
					string text10 = text;
					text = string.Concat(new string[]
					{
						text10,
						(this.m_League != null) ? this.m_League.Id.ToString() : this.m_Parameter1.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
			}
			else if (this.m_Action == "UpdateTable")
			{
				if (this.m_Trophy != null && this.m_Group != null)
				{
					text = string.Concat(new string[]
					{
						this.m_Trophy.Id.ToString(),
						",end,",
						this.m_Action,
						",",
						this.m_Trophy.Id.ToString(),
						",",
						this.m_Group.Id.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else
				{
					FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Task::SaveToTasks()");
				}
			}
			else if (this.m_Action == "UpdateLeagueTable")
			{
				if (this.m_Stage != null)
				{
					if (this.m_League != null)
					{
						text = string.Concat(new string[]
						{
							this.m_Stage.Trophy.Id.ToString(),
							",end,",
							this.m_Action,
							",",
							this.m_Stage.Id.ToString(),
							",",
							this.m_League.Id.ToString(),
							",",
							this.m_Parameter2.ToString(),
							",",
							this.m_Parameter3.ToString()
						});
					}
					else
					{
						text = string.Concat(new string[]
						{
							this.m_Stage.Trophy.Id.ToString(),
							",end,",
							this.m_Action,
							",",
							this.m_Stage.Id.ToString(),
							",",
							this.m_Parameter1.ToString(),
							",",
							this.m_Parameter2.ToString(),
							",",
							this.m_Parameter3.ToString()
						});
					}
				}
				else if (this.m_Group != null && this.m_League != null)
				{
					text = string.Concat(new string[]
					{
						this.m_Group.ParentTrophy.Id.ToString(),
						",end,",
						this.m_Action,
						",",
						this.m_Group.ParentStage.Id.ToString(),
						",",
						this.m_League.Id.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else
				{
					FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Task::SaveToTasks()");
				}
			}
			else if (this.m_Action == "UpdateLeagueStats")
			{
				if (this.m_Stage != null && this.m_League != null)
				{
					text = string.Concat(new string[]
					{
						this.m_Stage.Trophy.Id.ToString(),
						",end,",
						this.m_Action,
						",",
						this.m_Stage.Id.ToString(),
						",",
						this.m_League.Id.ToString(),
						",",
						this.m_Parameter2.ToString(),
						",",
						this.m_Parameter3.ToString()
					});
				}
				else
				{
					FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Task::SaveToTasks()");
				}
			}
			else
			{
				FifaEnvironment.UserMessages.ShowMessage(14999, "Debug Trap: Task::SaveToTasks()");
			}
			w.WriteLine(text);
			return true;
		}

		// Token: 0x06000794 RID: 1940 RVA: 0x0002C168 File Offset: 0x0002A368
		public Task CopyTask(Compobj newTargetObj, League targetLeague)
		{
			Task task = new Task(this);
			task.m_TargetCompObjId = newTargetObj.Id;
			if (!(this.m_Action == "FillFromCompTable") && !(this.m_Action == "FillFromCompTableBackup"))
			{
				if (this.m_Action == "FillFromCompTableBackupLeague")
				{
					if (targetLeague != null)
					{
						task.Parameter2 = targetLeague.Id;
					}
				}
				else if (this.m_Action == "FillFromLeague")
				{
					if (targetLeague != null)
					{
						task.Parameter1 = targetLeague.Id;
					}
				}
				else if (this.m_Action == "FillFromLeagueMaxFromCountry")
				{
					if (targetLeague != null)
					{
						task.Parameter1 = targetLeague.Id;
					}
				}
				else if (!(this.m_Action == "FillFromSpecialTeams") && !(this.m_Action == "FillWithTeam"))
				{
					if (this.m_Action == "FillFromLeagueInOrder")
					{
						if (targetLeague != null)
						{
							task.Parameter1 = targetLeague.Id;
						}
					}
					else if (this.m_Action == "UpdateLeagueTable")
					{
						if (targetLeague != null)
						{
							task.Parameter1 = targetLeague.Id;
						}
					}
					else if (this.m_Action == "UpdateLeagueStats")
					{
						if (targetLeague != null)
						{
							task.Parameter1 = targetLeague.Id;
						}
					}
					else if (this.m_Action == "ClearLeagueStats")
					{
						if (targetLeague != null)
						{
							task.Parameter1 = targetLeague.Id;
						}
					}
					else if (this.m_Action == "UpdateTable")
					{
						task.Parameter1 = this.Parameter1 + task.m_TargetCompObjId - this.m_TargetCompObjId;
					}
				}
			}
			if (newTargetObj.IsTrophy())
			{
				task.LinkTrophy((Trophy)newTargetObj);
			}
			else if (newTargetObj.IsStage())
			{
				task.LinkStage((Stage)newTargetObj);
			}
			else if (newTargetObj.IsGroup())
			{
				task.LinkGroup((Group)newTargetObj);
			}
			return task;
		}

		// Token: 0x040002B3 RID: 691
		private string m_When;

		// Token: 0x040002B4 RID: 692
		private string m_Action;

		// Token: 0x040002B5 RID: 693
		private EQualifyingRule m_Rule;

		// Token: 0x040002B6 RID: 694
		private int m_TargetCompObjId;

		// Token: 0x040002B7 RID: 695
		private int m_Parameter1;

		// Token: 0x040002B8 RID: 696
		private int m_Parameter2;

		// Token: 0x040002B9 RID: 697
		private int m_Parameter3;

		// Token: 0x040002BA RID: 698
		private Group m_Group;

		// Token: 0x040002BB RID: 699
		private Stage m_Stage;

		// Token: 0x040002BC RID: 700
		private Trophy m_Trophy;

		// Token: 0x040002BD RID: 701
		private Trophy m_Trophy1;

		// Token: 0x040002BE RID: 702
		private Trophy m_Trophy2;

		// Token: 0x040002BF RID: 703
		private League m_League;

		// Token: 0x040002C0 RID: 704
		private Team m_Team;
	}
}
