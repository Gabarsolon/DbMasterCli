using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200004A RID: 74
	public class Group : Compobj
	{
		// Token: 0x06000714 RID: 1812 RVA: 0x0002905C File Offset: 0x0002725C
		public override string ToString()
		{
			if (this.m_LanguageName != null && this.m_LanguageName != string.Empty)
			{
				return this.m_LanguageName;
			}
			if (base.Description != null && base.Description != string.Empty && base.Description != " ")
			{
				return base.Description.StartsWith("FCE_") ? base.Description.Substring(4).Replace('_', ' ') : base.Description.Replace('_', ' ');
			}
			return base.TypeString;
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000715 RID: 1813 RVA: 0x000290F8 File Offset: 0x000272F8
		public Stage ParentStage
		{
			get
			{
				if (base.ParentObj.IsStage())
				{
					return (Stage)base.ParentObj;
				}
				if (base.ParentObj.IsGroup() && base.ParentObj.ParentObj.IsStage())
				{
					return (Stage)base.ParentObj.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x0002914F File Offset: 0x0002734F
		public Trophy ParentTrophy
		{
			get
			{
				if (this.ParentStage.ParentObj.IsTrophy())
				{
					return (Trophy)this.ParentStage.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000717 RID: 1815 RVA: 0x00029175 File Offset: 0x00027375
		public GroupList SubGroups
		{
			get
			{
				return this.m_SubGroups;
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0002917D File Offset: 0x0002737D
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00029185 File Offset: 0x00027385
		public ScheduleArray Schedules
		{
			get
			{
				return this.m_Schedule;
			}
			set
			{
				this.m_Schedule = value;
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0002918E File Offset: 0x0002738E
		public int NSchedule
		{
			get
			{
				return this.m_Schedule.Count;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x0002919B File Offset: 0x0002739B
		public RankList Ranks
		{
			get
			{
				return this.m_Ranks;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x0600071C RID: 1820 RVA: 0x000291A3 File Offset: 0x000273A3
		// (set) Token: 0x0600071D RID: 1821 RVA: 0x000291AB File Offset: 0x000273AB
		public string LanguageName
		{
			get
			{
				return this.m_LanguageName;
			}
			set
			{
				this.m_LanguageName = value;
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x000291B4 File Offset: 0x000273B4
		public Group(int id, string typeString, string description, Compobj parentObj)
			: base(id, 5, typeString, description, parentObj)
		{
			this.m_ConventionalDescription = description;
			this.m_Ranks = new RankList();
			Rank rank = new Rank(this, 0);
			this.m_Ranks.Add(rank);
			this.m_Groups = new GroupList();
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000291FF File Offset: 0x000273FF
		public void AddSchedule(Schedule schedule)
		{
			if (this.m_Schedule == null)
			{
				this.m_Schedule = new ScheduleArray(256);
				this.m_NSchedule = 0;
			}
			this.m_Schedule.AddSchedule(schedule);
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x0002922C File Offset: 0x0002742C
		public Schedule[] GetLegSchedule(int legId)
		{
			if (this.m_Schedule == null)
			{
				return null;
			}
			return this.m_Schedule.GetLegSchedule(legId);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00029244 File Offset: 0x00027444
		public Schedule[] GetLastLegSchedule()
		{
			if (this.m_Schedule == null)
			{
				return null;
			}
			return this.m_Schedule.GetLastLegSchedule();
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x0002925B File Offset: 0x0002745B
		public bool RemoveLastLeg()
		{
			return this.m_Schedule != null && this.m_Schedule.RemoveLastLeg();
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00029272 File Offset: 0x00027472
		public Schedule AppendLeg(int dayDelay)
		{
			if (this.m_Schedule == null)
			{
				this.m_Schedule = new ScheduleArray(8);
			}
			return this.m_Schedule.AppendLeg(this, dayDelay);
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00029295 File Offset: 0x00027495
		public void CloneSchedule(Schedule originalSchedule, int timeDelay)
		{
			if (this.m_Schedule == null)
			{
				return;
			}
			this.m_Schedule.CloneSchedule(originalSchedule, timeDelay);
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x000292AD File Offset: 0x000274AD
		public void DeleteSchedule(Schedule originalSchedule)
		{
			if (this.m_Schedule == null)
			{
				return;
			}
			this.m_Schedule.DeleteSchedule(originalSchedule);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x000292C8 File Offset: 0x000274C8
		public override bool SaveToStandings(StreamWriter w)
		{
			for (int i = 1; i < this.m_Ranks.Count; i++)
			{
				Rank rank = (Rank)this.m_Ranks[i];
				string text = base.Id.ToString() + "," + (rank.Id - 1).ToString();
				w.WriteLine(text);
			}
			return true;
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00029330 File Offset: 0x00027530
		public override bool SaveToAdvancement(StreamWriter w)
		{
			for (int i = 1; i < this.m_Ranks.Count; i++)
			{
				Rank rank = (Rank)this.m_Ranks[i];
				if (rank.MoveFrom != null)
				{
					string text = string.Concat(new string[]
					{
						rank.MoveFrom.Group.Id.ToString(),
						",",
						rank.MoveFrom.Id.ToString(),
						",",
						base.Id.ToString(),
						",",
						rank.Id.ToString()
					});
					w.WriteLine(text);
				}
			}
			return true;
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x000293FB File Offset: 0x000275FB
		public override bool SaveToSchedule(StreamWriter w)
		{
			return this.m_Schedule != null && this.m_Schedule.SaveToSchedule(w);
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x00029414 File Offset: 0x00027614
		public override void LinkCompetitions()
		{
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				this.m_StartTask[i].LinkGroup(this);
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				this.m_EndTask[j].LinkGroup(this);
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00029460 File Offset: 0x00027660
		public override bool SaveToTasks(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			if (this.ParentTrophy == null)
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

		// Token: 0x0600072B RID: 1835 RVA: 0x000294C8 File Offset: 0x000276C8
		public override bool FillFromLanguage()
		{
			if (FifaEnvironment.Language != null)
			{
				if (this.m_ConventionalDescription != null && this.m_ConventionalDescription != string.Empty && this.m_ConventionalDescription != " ")
				{
					this.m_LanguageName = FifaEnvironment.Language.GetString(this.m_ConventionalDescription);
					if (this.m_LanguageName == null)
					{
						this.m_LanguageName = this.m_ConventionalDescription;
					}
				}
			}
			else
			{
				this.m_LanguageName = string.Empty;
			}
			return true;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00029540 File Offset: 0x00027740
		public override bool SaveToLanguage()
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetString(this.m_ConventionalDescription, this.m_LanguageName);
				return true;
			}
			return false;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00029564 File Offset: 0x00027764
		public bool AddRank()
		{
			int count = this.m_Ranks.Count;
			Rank rank = new Rank(this, count);
			if (rank == null)
			{
				return false;
			}
			this.m_Ranks.Add(rank);
			return true;
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x00029598 File Offset: 0x00027798
		public bool RemoveRank()
		{
			if (this.m_Ranks.Count < 1)
			{
				return false;
			}
			Rank rank = (Rank)this.m_Ranks[this.m_Ranks.Count - 1];
			this.m_Ranks.Remove(rank);
			return true;
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000295E0 File Offset: 0x000277E0
		public bool RemoveAllRanks()
		{
			int count = this.m_Ranks.Count;
			for (int i = 0; i < count; i++)
			{
				this.RemoveRank();
			}
			return true;
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00029610 File Offset: 0x00027810
		public override void Normalize()
		{
			Stage stage = null;
			if (base.Settings.m_advance_pointskeep != -1)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.m_advance_pointskeep == -1)
				{
					stage.Settings.m_advance_pointskeep = base.Settings.m_advance_pointskeep;
				}
				base.Settings.m_advance_pointskeep = -1;
			}
			if (base.Settings.m_advance_pointskeeppercentage != -1)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.m_advance_pointskeeppercentage == -1)
				{
					stage.Settings.m_advance_pointskeeppercentage = base.Settings.m_advance_pointskeeppercentage;
				}
				base.Settings.m_advance_pointskeeppercentage = -1;
			}
			if (base.Settings.Advance_standingsrank != -1)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.Advance_standingsrank == -1)
				{
					stage.Settings.Advance_standingsrank = base.Settings.Advance_standingsrank;
				}
				base.Settings.Advance_standingsrank = -1;
			}
			if (base.Settings.m_info_prize_money != -1)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.m_info_prize_money == -1)
				{
					stage.Settings.m_info_prize_money = base.Settings.m_info_prize_money;
				}
				base.Settings.m_info_prize_money = -1;
			}
			if (base.Settings.m_match_stadium != null && base.Settings.m_match_stadium.Length > 0)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.m_match_stadium.Length == 0)
				{
					stage.Settings.m_match_stadium = new int[12];
					for (int i = 0; i < stage.Settings.m_match_stadium.Length; i++)
					{
						stage.Settings.m_match_stadium[i] = -1;
					}
					for (int j = 0; j < base.Settings.m_match_stadium.Length; j++)
					{
						stage.Settings.m_match_stadium[j] = base.Settings.m_match_stadium[j];
					}
				}
				base.Settings.m_info_prize_money = -1;
			}
			if (base.Settings.m_StandingsSort != -1)
			{
				if (base.ParentObj.IsStage())
				{
					stage = (Stage)base.ParentObj;
				}
				if (stage.Settings.m_StandingsSort == -1)
				{
					stage.Settings.m_StandingsSort = base.Settings.m_StandingsSort;
				}
				base.Settings.m_StandingsSort = -1;
			}
			if (base.ParentObj.IsStage())
			{
				stage = (Stage)base.ParentObj;
				for (int k = 0; k < this.m_NEndTasks; k++)
				{
					if (this.m_EndTask[k].Action == "UpdateLeagueTable")
					{
						stage.AddTask(this.m_EndTask[k]);
						this.RemoveTask(this.m_EndTask[k].When, k);
						return;
					}
				}
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x000298FB File Offset: 0x00027AFB
		public bool RemoveAllSchedules()
		{
			if (this.m_Schedule == null)
			{
				return false;
			}
			this.m_Schedule.Clear();
			return true;
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00029914 File Offset: 0x00027B14
		public bool AddTask(Task action)
		{
			if (action.When == "start")
			{
				if (this.m_NStartTasks == 0)
				{
					this.m_StartTask = new Task[32];
				}
				if (this.m_NStartTasks < this.m_StartTask.Length)
				{
					this.m_StartTask[this.m_NStartTasks] = action;
					this.m_NStartTasks++;
					return true;
				}
				return false;
			}
			else
			{
				if (!(action.When == "end"))
				{
					return false;
				}
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
				return false;
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000299D0 File Offset: 0x00027BD0
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

		// Token: 0x06000734 RID: 1844 RVA: 0x00029A4C File Offset: 0x00027C4C
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

		// Token: 0x06000735 RID: 1845 RVA: 0x00029B4C File Offset: 0x00027D4C
		public Task SearchTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			if (num >= 0)
			{
				return this.GetTask(when, num);
			}
			return null;
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00029B78 File Offset: 0x00027D78
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

		// Token: 0x06000737 RID: 1847 RVA: 0x00029C0C File Offset: 0x00027E0C
		public bool RemoveTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			return num >= 0 && this.RemoveTask(when, num);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x00029C35 File Offset: 0x00027E35
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

		// Token: 0x06000739 RID: 1849 RVA: 0x00029C72 File Offset: 0x00027E72
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

		// Token: 0x0600073A RID: 1850 RVA: 0x00029CA8 File Offset: 0x00027EA8
		public void CopyTasks(Group newGroup, League targetLeague)
		{
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				newGroup.AddTask(this.m_StartTask[i].CopyTask(newGroup, targetLeague));
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				newGroup.AddTask(this.m_EndTask[j].CopyTask(newGroup, targetLeague));
			}
		}

		// Token: 0x0400029A RID: 666
		private GroupList m_SubGroups;

		// Token: 0x0400029B RID: 667
		private ScheduleArray m_Schedule;

		// Token: 0x0400029C RID: 668
		private int m_NSchedule;

		// Token: 0x0400029D RID: 669
		private RankList m_Ranks;

		// Token: 0x0400029E RID: 670
		private string m_ConventionalDescription;

		// Token: 0x0400029F RID: 671
		private string m_LanguageName;

		// Token: 0x040002A0 RID: 672
		public Task[] m_StartTask;

		// Token: 0x040002A1 RID: 673
		public int m_NStartTasks;

		// Token: 0x040002A2 RID: 674
		public Task[] m_EndTask;

		// Token: 0x040002A3 RID: 675
		public int m_NEndTasks;
	}
}
