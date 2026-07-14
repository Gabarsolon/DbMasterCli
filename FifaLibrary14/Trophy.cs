using System;
using System.Drawing;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000046 RID: 70
	public class Trophy : Compobj
	{
		// Token: 0x060006A8 RID: 1704 RVA: 0x00027430 File Offset: 0x00025630
		public override string ToString()
		{
			if (this.m_LongName != null && this.m_LongName != string.Empty)
			{
				return this.m_LongName;
			}
			if (this.m_ShortName != null && this.m_ShortName != string.Empty)
			{
				return this.m_ShortName;
			}
			return "Trophy n. " + base.Settings.m_asset_id.ToString();
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x060006A9 RID: 1705 RVA: 0x00027499 File Offset: 0x00025699
		// (set) Token: 0x060006AA RID: 1706 RVA: 0x000274A1 File Offset: 0x000256A1
		public int ballid
		{
			get
			{
				return this.m_ballid;
			}
			set
			{
				this.m_ballid = value;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x060006AB RID: 1707 RVA: 0x000274AA File Offset: 0x000256AA
		public Nation Nation
		{
			get
			{
				if (base.ParentObj.TypeNumber == 2)
				{
					return (Nation)base.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x060006AC RID: 1708 RVA: 0x000274C7 File Offset: 0x000256C7
		public Confederation Confederation
		{
			get
			{
				if (base.ParentObj.TypeNumber == 1)
				{
					return (Confederation)base.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x000274E4 File Offset: 0x000256E4
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x000274EC File Offset: 0x000256EC
		public string ShortName
		{
			get
			{
				return this.m_ShortName;
			}
			set
			{
				this.m_ShortName = value;
			}
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x000274F5 File Offset: 0x000256F5
		public bool SetLanguageName(string languageName)
		{
			if (FifaEnvironment.Language != null && base.Description != null)
			{
				FifaEnvironment.Language.SetString(base.Description, languageName);
				return true;
			}
			return false;
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x060006B0 RID: 1712 RVA: 0x0002751A File Offset: 0x0002571A
		// (set) Token: 0x060006B1 RID: 1713 RVA: 0x00027522 File Offset: 0x00025722
		public string LongName
		{
			get
			{
				return this.m_LongName;
			}
			set
			{
				this.m_LongName = value;
			}
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0002752C File Offset: 0x0002572C
		public override void LinkLeague(LeagueList leagueList)
		{
			if (leagueList == null)
			{
				return;
			}
			if (base.Settings.m_info_league_promo >= 0)
			{
				base.Settings.LeaguePromo = (League)leagueList.SearchId(base.Settings.m_info_league_promo);
			}
			else
			{
				base.Settings.LeaguePromo = null;
			}
			if (base.Settings.m_info_league_releg >= 0)
			{
				base.Settings.LeagueReleg = (League)leagueList.SearchId(base.Settings.m_info_league_releg);
				return;
			}
			base.Settings.LeagueReleg = null;
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x000275B8 File Offset: 0x000257B8
		public override void LinkTeam(TeamList teamList)
		{
			for (int i = 0; i < this.m_InitTeamArray.Length; i++)
			{
				if (this.m_InitTeamArray[i] != null)
				{
					this.m_InitTeamArray[i].LinkTeam(teamList);
				}
			}
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x060006B4 RID: 1716 RVA: 0x000275F0 File Offset: 0x000257F0
		// (set) Token: 0x060006B5 RID: 1717 RVA: 0x000275F8 File Offset: 0x000257F8
		public InitTeam[] InitTeamArray
		{
			get
			{
				return this.m_InitTeamArray;
			}
			set
			{
				this.m_InitTeamArray = value;
			}
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x00027604 File Offset: 0x00025804
		public Trophy(int id, string typeString, string description, Compobj parentObj)
			: base(id, 3, typeString, description, parentObj)
		{
			this.m_Stages = new StageList();
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x00027658 File Offset: 0x00025858
		public void FillFromCompetition(Table t)
		{
			this.m_ballid = -1;
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int andCheckIntField = record.GetAndCheckIntField(FI.competition_competitionid);
				if (andCheckIntField == base.Settings.m_asset_id)
				{
					this.m_ballid = record.GetAndCheckIntField(FI.competition_ballid);
					return;
				}
			}
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x000276B2 File Offset: 0x000258B2
		public void SaveCompetition(Record r)
		{
			if (this.m_ballid >= 0)
			{
				r.IntField[FI.competition_competitionid] = base.Settings.m_asset_id;
				r.IntField[FI.competition_ballid] = this.m_ballid;
			}
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x000276E8 File Offset: 0x000258E8
		public override bool SaveToInitteams(StreamWriter w)
		{
			for (int i = 0; i < this.m_NEndTasks; i++)
			{
				Task task = this.m_EndTask[i];
				if (task.Action == "UpdateTable")
				{
					int num = task.Parameter3 - 1;
					InitTeam initTeam = this.m_InitTeamArray[num];
					if (initTeam != null)
					{
						string text;
						if (initTeam.teamid >= 0)
						{
							text = string.Concat(new string[]
							{
								base.Id.ToString(),
								",",
								num.ToString(),
								",",
								initTeam.teamid.ToString()
							});
						}
						else
						{
							text = base.Id.ToString() + "," + num.ToString() + ",-1";
						}
						w.WriteLine(text);
					}
				}
			}
			return true;
		}

		// Token: 0x060006BA RID: 1722 RVA: 0x000277D4 File Offset: 0x000259D4
		public override bool SaveToCompids(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			string text = base.Id.ToString();
			w.WriteLine(text);
			return true;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x00027800 File Offset: 0x00025A00
		public override bool SaveToTasks(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				Task task = this.m_StartTask[i];
				task.SaveToTasks(w);
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				Task task2 = this.m_EndTask[j];
				task2.SaveToTasks(w);
			}
			return true;
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x00027858 File Offset: 0x00025A58
		public static int AutoAsset()
		{
			for (int i = 1; i < 9999; i++)
			{
				bool flag = false;
				foreach (object obj in FifaEnvironment.CompetitionObjects)
				{
					Compobj compobj = (Compobj)obj;
					if (compobj.Settings.m_asset_id == i)
					{
						flag = true;
						break;
					}
				}
				if (!flag)
				{
					foreach (object obj2 in FifaEnvironment.Leagues)
					{
						League league = (League)obj2;
						if (league.Id == i)
						{
							flag = true;
							break;
						}
					}
					if (!flag)
					{
						return i;
					}
				}
			}
			return 0;
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x00027938 File Offset: 0x00025B38
		public override bool FillFromLanguage()
		{
			if (FifaEnvironment.Language != null)
			{
				this.m_ShortName = FifaEnvironment.Language.GetTournamentString(base.Settings.m_asset_id, Language.ETournamentStringType.Abbr15);
				this.m_LongName = FifaEnvironment.Language.GetTournamentString(base.Settings.m_asset_id, Language.ETournamentStringType.Full);
				if (this.m_LongName == null && this.m_ShortName == null)
				{
					this.m_ShortName = FifaEnvironment.Language.GetString(base.Description);
				}
				if (this.m_LongName == null)
				{
					this.m_LongName = string.Empty;
				}
				if (this.m_ShortName == null)
				{
					this.m_ShortName = string.Empty;
				}
				if (this.m_LongName == string.Empty)
				{
					this.m_LongName = this.m_ShortName;
				}
				if (this.m_ShortName == string.Empty)
				{
					if (this.m_LongName.Length > 15)
					{
						this.m_ShortName = this.m_LongName.Substring(0, 15);
					}
					else
					{
						this.m_ShortName = this.m_LongName;
					}
				}
			}
			else
			{
				this.m_ShortName = string.Empty;
				this.m_LongName = string.Empty;
			}
			return true;
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x00027A50 File Offset: 0x00025C50
		public override bool SaveToLanguage()
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetTournamentString(base.Settings.m_asset_id, Language.ETournamentStringType.Abbr15, this.m_ShortName);
				FifaEnvironment.Language.SetTournamentString(base.Settings.m_asset_id, Language.ETournamentStringType.Full, this.m_LongName);
				return true;
			}
			return false;
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x00027AA0 File Offset: 0x00025CA0
		public bool InsertStage(int stageIndex)
		{
			if (stageIndex > base.Stages.Count)
			{
				return false;
			}
			string text = "S" + (stageIndex + 1).ToString();
			int newId = FifaEnvironment.CompetitionObjects.GetNewId();
			Stage stage = new Stage(newId, text, "FCE_Setup_Stage", this);
			if (stage == null)
			{
				return false;
			}
			stage.Settings.m_match_stagetype = "SETUP";
			base.Stages.Insert(stageIndex, stage);
			FifaEnvironment.CompetitionObjects.Add(stage);
			for (int i = 0; i < base.Stages.Count; i++)
			{
				text = "S" + (i + 1).ToString();
				Stage stage2 = (Stage)base.Stages[i];
				stage2.TypeString = text;
			}
			return true;
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x00027B64 File Offset: 0x00025D64
		public bool RemoveStage(Stage stage)
		{
			int num = base.Stages.IndexOf(stage);
			if (num < 0)
			{
				return false;
			}
			this.RemoveStage(num);
			return true;
		}

		// Token: 0x060006C1 RID: 1729 RVA: 0x00027B90 File Offset: 0x00025D90
		public bool RemoveStage(int stageIndex)
		{
			if (stageIndex > base.Stages.Count)
			{
				return false;
			}
			Stage stage = (Stage)base.Stages[stageIndex];
			base.Stages.RemoveAt(stageIndex);
			FifaEnvironment.CompetitionObjects.RemoveId(stage);
			for (int i = 0; i < base.Stages.Count; i++)
			{
				string text = "S" + (i + 1).ToString();
				Stage stage2 = (Stage)base.Stages[i];
				stage2.TypeString = text;
			}
			return true;
		}

		// Token: 0x060006C2 RID: 1730 RVA: 0x00027C20 File Offset: 0x00025E20
		public bool AddStage()
		{
			string text = "S" + (base.Stages.Count + 1).ToString();
			int newId = FifaEnvironment.CompetitionObjects.GetNewId();
			Stage stage = new Stage(newId, text, string.Empty, this);
			if (stage == null)
			{
				return false;
			}
			base.Stages.Add(stage);
			FifaEnvironment.CompetitionObjects.Add(stage);
			return true;
		}

		// Token: 0x060006C3 RID: 1731 RVA: 0x00027C88 File Offset: 0x00025E88
		public bool RemoveStage()
		{
			if (base.Stages.Count < 1)
			{
				return false;
			}
			Stage stage = (Stage)base.Stages[base.Stages.Count - 1];
			base.Stages.Remove(stage);
			FifaEnvironment.CompetitionObjects.Remove(stage);
			stage.RemoveAllGroups();
			return true;
		}

		// Token: 0x060006C4 RID: 1732 RVA: 0x00027CE4 File Offset: 0x00025EE4
		public bool RemoveAllStages()
		{
			int count = base.Stages.Count;
			for (int i = 0; i < count; i++)
			{
				this.RemoveStage();
			}
			return true;
		}

		// Token: 0x060006C5 RID: 1733 RVA: 0x00027D14 File Offset: 0x00025F14
		public override void Normalize()
		{
			if (base.Settings.m_match_matchsituation != null)
			{
				foreach (object obj in this.m_Stages)
				{
					Stage stage = (Stage)obj;
					if (stage.Settings.m_match_stagetype != "SETUP" && stage.Settings.m_match_matchsituation == null)
					{
						stage.Settings.m_match_matchsituation = base.Settings.m_match_matchsituation;
					}
				}
				base.Settings.m_match_matchsituation = null;
			}
			if (base.Settings.m_N_endruleko1leg != 0)
			{
				foreach (object obj2 in this.m_Stages)
				{
					Stage stage2 = (Stage)obj2;
					if (stage2.Settings.m_match_stagetype != "SETUP")
					{
						for (int i = 0; i < base.Settings.m_N_endruleko1leg; i++)
						{
							if (base.Settings.m_match_endruleko1leg[i] != null && stage2.Settings.m_match_endruleko1leg[i] == null)
							{
								stage2.Settings.m_match_endruleko1leg[i] = base.Settings.m_match_endruleko1leg[i];
							}
						}
					}
				}
				for (int j = 0; j < base.Settings.m_N_endruleko1leg; j++)
				{
					base.Settings.m_match_endruleko1leg[j] = null;
				}
				base.Settings.m_N_endruleko1leg = 0;
			}
		}

		// Token: 0x060006C6 RID: 1734 RVA: 0x00027EB0 File Offset: 0x000260B0
		public void LinkTaskGroup()
		{
		}

		// Token: 0x060006C7 RID: 1735 RVA: 0x00027EB4 File Offset: 0x000260B4
		public override void LinkCompetitions()
		{
			Trophy trophyCompdependency = base.Settings.TrophyCompdependency;
			Trophy trophyForcecomp = base.Settings.TrophyForcecomp;
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				this.m_StartTask[i].LinkTrophy(this);
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				this.m_EndTask[j].LinkTrophy(this);
			}
		}

		// Token: 0x060006C8 RID: 1736 RVA: 0x00027F18 File Offset: 0x00026118
		public bool AddTask(Task action)
		{
			if (action.When == "start")
			{
				if (this.m_NStartTasks == 0)
				{
					this.m_StartTask = new Task[24];
				}
				if (this.m_NStartTasks < this.m_StartTask.Length)
				{
					this.m_StartTask[this.m_NStartTasks] = action;
					this.m_NStartTasks++;
					return true;
				}
			}
			else if (action.When == "end")
			{
				if (this.m_NEndTasks == 0)
				{
					this.m_EndTask = new Task[24];
				}
				if (this.m_NEndTasks < this.m_EndTask.Length)
				{
					this.m_EndTask[this.m_NEndTasks] = action;
					this.m_NEndTasks++;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060006C9 RID: 1737 RVA: 0x00027FD0 File Offset: 0x000261D0
		public bool RemoveLastTask(string when)
		{
			if (when == "start")
			{
				if (this.m_NStartTasks > 0)
				{
					this.m_NStartTasks--;
					this.m_StartTask[this.m_NStartTasks] = null;
					return true;
				}
				return false;
			}
			else
			{
				if (!(when == "end"))
				{
					return false;
				}
				if (this.m_NEndTasks > 0)
				{
					this.m_NEndTasks--;
					this.m_EndTask[this.m_NEndTasks] = null;
					return true;
				}
				return false;
			}
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0002804C File Offset: 0x0002624C
		public int SearchTaskIndex(string when, string action, int par1, int par2, int par3)
		{
			if (when == "start")
			{
				for (int i = 0; i < this.m_NStartTasks; i++)
				{
					if ((action == null || this.m_StartTask[i].Action == action) && (par1 < 0 || this.m_StartTask[i].Parameter1 == par1) && (par2 < 0 || this.m_StartTask[i].Parameter2 == par2) && (par3 < 0 || this.m_StartTask[i].Parameter3 == par3))
					{
						return i;
					}
				}
			}
			else if (when == "end")
			{
				for (int j = 0; j < this.m_NEndTasks; j++)
				{
					if ((action == null || this.m_EndTask[j].Action == action) && (par1 < 0 || this.m_EndTask[j].Parameter1 == par1) && (par2 < 0 || this.m_EndTask[j].Parameter2 == par2) && (par3 < 0 || this.m_EndTask[j].Parameter3 == par3))
					{
						return j;
					}
				}
			}
			return -1;
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0002814C File Offset: 0x0002634C
		public Task SearchTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			if (num >= 0)
			{
				return this.GetTask(when, num);
			}
			return null;
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x00028178 File Offset: 0x00026378
		public bool RemoveTask(string when, int index)
		{
			if (when == "start")
			{
				if (index < this.m_NStartTasks)
				{
					this.m_NStartTasks--;
					for (int i = index; i < this.m_NStartTasks; i++)
					{
						this.m_StartTask[i] = this.m_StartTask[i + 1];
					}
					return true;
				}
			}
			else if (index < this.m_NEndTasks)
			{
				this.m_NEndTasks--;
				for (int j = index; j < this.m_NEndTasks; j++)
				{
					this.m_EndTask[j] = this.m_EndTask[j + 1];
				}
				return true;
			}
			return false;
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0002820C File Offset: 0x0002640C
		public bool RemoveTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			return num >= 0 && this.RemoveTask(when, num);
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x00028235 File Offset: 0x00026435
		public bool RemoveTask(Task task)
		{
			return this.RemoveTask(task.When, task.Action, task.Parameter1, task.Parameter2, task.Parameter3);
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0002825B File Offset: 0x0002645B
		public bool ReplaceTask(Task task, int index)
		{
			if (task.When == "start")
			{
				if (index < this.m_NStartTasks)
				{
					this.m_StartTask[index] = task;
					return true;
				}
			}
			else if (index < this.m_NEndTasks)
			{
				this.m_EndTask[index] = task;
				return true;
			}
			return false;
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x00028298 File Offset: 0x00026498
		public bool ReplaceTask(Task currentTask, Task newTask)
		{
			int num = this.SearchTaskIndex(currentTask.When, currentTask.Action, currentTask.Parameter1, currentTask.Parameter2, currentTask.Parameter3);
			return num >= 0 && this.ReplaceTask(newTask, num);
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x000282D8 File Offset: 0x000264D8
		public Task GetTask(string when, int index)
		{
			if (when == "start")
			{
				if (index < this.m_NStartTasks)
				{
					return this.m_StartTask[index];
				}
			}
			else if (index < this.m_NEndTasks)
			{
				return this.m_EndTask[index];
			}
			return null;
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0002830C File Offset: 0x0002650C
		public void CopyTasks(Trophy newTrophy, League targetLeague)
		{
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				newTrophy.AddTask(this.m_StartTask[i].CopyTask(newTrophy, targetLeague));
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				newTrophy.AddTask(this.m_EndTask[j].CopyTask(newTrophy, targetLeague));
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x00028367 File Offset: 0x00026567
		public static string TrophyDdsFileName(int id)
		{
			return "data/ui/imgassets/trophy256x256/t" + id.ToString() + ".dds";
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0002837F File Offset: 0x0002657F
		public string TrophyTemplateFileName()
		{
			return "data/ui/imgassets/trophy256x256/t#.dds";
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x00028386 File Offset: 0x00026586
		public string TrophyDdsFileName()
		{
			return Trophy.TrophyDdsFileName(base.Settings.m_asset_id);
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x00028398 File Offset: 0x00026598
		public Bitmap GetTrophy()
		{
			return FifaEnvironment.GetDdsArtasset(this.TrophyDdsFileName());
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x000283A5 File Offset: 0x000265A5
		public bool SetTrophy(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.TrophyTemplateFileName(), base.Settings.m_asset_id, bitmap);
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x000283C3 File Offset: 0x000265C3
		public bool DeleteTrophy()
		{
			return FifaEnvironment.DeleteFromZdata(this.TrophyDdsFileName());
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x000283D0 File Offset: 0x000265D0
		public static string TrophySmallDdsFileName(int id)
		{
			return "data/ui/imgassets/trophy128x128/t" + id.ToString() + ".dds";
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x000283E8 File Offset: 0x000265E8
		public string TrophySmallTemplateFileName()
		{
			return "data/ui/imgassets/trophy128x128/t#.dds";
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x000283EF File Offset: 0x000265EF
		public string TrophySmallDdsFileName()
		{
			return Trophy.TrophySmallDdsFileName(base.Settings.m_asset_id);
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x00028401 File Offset: 0x00026601
		public Bitmap GetTrophySmall()
		{
			return FifaEnvironment.GetDdsArtasset(this.TrophySmallDdsFileName());
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0002840E File Offset: 0x0002660E
		public bool SetTrophySmall(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.TrophySmallTemplateFileName(), base.Settings.m_asset_id, bitmap);
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0002842C File Offset: 0x0002662C
		public bool DeleteTrophySmall()
		{
			return FifaEnvironment.DeleteFromZdata(this.TrophySmallDdsFileName());
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x00028439 File Offset: 0x00026639
		public static string TexturesFileName(int id)
		{
			return "data/sceneassets/trophy/trophy_" + id.ToString() + "_textures.rx3";
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x00028451 File Offset: 0x00026651
		public string TexturesFileName()
		{
			return Trophy.TexturesFileName(base.Settings.m_asset_id);
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x00028463 File Offset: 0x00026663
		public string TexturesTemplateFileName()
		{
			return "data/sceneassets/trophy/trophy_#_textures.rx3";
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0002846A File Offset: 0x0002666A
		public Bitmap[] GetTextures()
		{
			return FifaEnvironment.GetBmpsFromRx3(this.TexturesFileName());
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x00028477 File Offset: 0x00026677
		public bool SetTextures(Bitmap[] bitmaps)
		{
			return bitmaps != null && FifaEnvironment.ImportBmpsIntoZdata(this.TexturesTemplateFileName(), base.Settings.m_asset_id, bitmaps, ECompressionMode.Chunkzip2);
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x00028496 File Offset: 0x00026696
		public bool SetTextures(string rx3FileName)
		{
			return rx3FileName != null && FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.TexturesFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x000284AB File Offset: 0x000266AB
		public bool DeleteContainer(int timeofday)
		{
			return FifaEnvironment.DeleteFromZdata(this.TexturesFileName());
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x000284B8 File Offset: 0x000266B8
		public static string ModelFileName(int trophyId)
		{
			return "data/sceneassets/trophy/trophy_" + trophyId.ToString() + ".rx3";
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x000284D0 File Offset: 0x000266D0
		public string ModelFileName()
		{
			return Trophy.ModelFileName(base.Settings.m_asset_id);
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x000284E2 File Offset: 0x000266E2
		public string ModelTemplateFileName()
		{
			return "data/sceneassets/trophy/trophy_#.rx3";
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x000284E9 File Offset: 0x000266E9
		public Rx3File GetModel()
		{
			return FifaEnvironment.GetRx3FromZdata(this.ModelFileName());
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x000284F6 File Offset: 0x000266F6
		public string ExportModelFile()
		{
			if (FifaEnvironment.ExportFileFromZdata(this.ModelFileName(), FifaEnvironment.ExportFolder))
			{
				return FifaEnvironment.ExportFolder + "\\" + this.ModelFileName();
			}
			return null;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x00028521 File Offset: 0x00026721
		public bool SetModel(string rx3FileName)
		{
			return rx3FileName != null && FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.ModelFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00028536 File Offset: 0x00026736
		public bool DeleteModel()
		{
			return FifaEnvironment.DeleteFromZdata(this.ModelFileName());
		}

		// Token: 0x0400028B RID: 651
		private int m_ballid = -1;

		// Token: 0x0400028C RID: 652
		private string m_ShortName;

		// Token: 0x0400028D RID: 653
		private string m_LongName;

		// Token: 0x0400028E RID: 654
		private InitTeam[] m_InitTeamArray = new InitTeam[24];

		// Token: 0x0400028F RID: 655
		public Task[] m_StartTask = new Task[24];

		// Token: 0x04000290 RID: 656
		public int m_NStartTasks;

		// Token: 0x04000291 RID: 657
		public Task[] m_EndTask = new Task[24];

		// Token: 0x04000292 RID: 658
		public int m_NEndTasks;
	}
}
