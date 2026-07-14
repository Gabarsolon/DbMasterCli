using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000048 RID: 72
	public class Stage : Compobj
	{
		// Token: 0x060006EF RID: 1775 RVA: 0x000285AC File Offset: 0x000267AC
		public override string ToString()
		{
			string languageName = this.GetLanguageName();
			if (languageName != null && languageName != string.Empty)
			{
				return languageName;
			}
			if (base.Description != null && base.Description != string.Empty && base.Description != " ")
			{
				return base.Description.StartsWith("FCE_") ? base.Description.Substring(4).Replace('_', ' ') : base.Description.Replace('_', ' ');
			}
			return base.TypeString;
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x060006F0 RID: 1776 RVA: 0x0002863F File Offset: 0x0002683F
		public Trophy Trophy
		{
			get
			{
				if (base.ParentObj.TypeNumber == 3)
				{
					return (Trophy)base.ParentObj;
				}
				return null;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x060006F1 RID: 1777 RVA: 0x0002865C File Offset: 0x0002685C
		// (set) Token: 0x060006F2 RID: 1778 RVA: 0x00028664 File Offset: 0x00026864
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

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x060006F3 RID: 1779 RVA: 0x0002866D File Offset: 0x0002686D
		public int NSchedule
		{
			get
			{
				return this.m_Schedule.Count;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x060006F4 RID: 1780 RVA: 0x0002867A File Offset: 0x0002687A
		// (set) Token: 0x060006F5 RID: 1781 RVA: 0x00028682 File Offset: 0x00026882
		public string ConventionalDescription
		{
			get
			{
				return this.m_ConventionalDescription;
			}
			set
			{
				this.m_ConventionalDescription = value;
			}
		}

		// Token: 0x060006F6 RID: 1782 RVA: 0x0002868B File Offset: 0x0002688B
		public Stage(int id, string typeString, string description, Compobj parentObj)
			: base(id, 4, typeString, description, parentObj)
		{
			this.m_Groups = new GroupList();
		}

		// Token: 0x060006F7 RID: 1783 RVA: 0x000286A4 File Offset: 0x000268A4
		public override void LinkCompetitions()
		{
			base.Settings.UpdateStageReferenceUsingId();
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				this.m_StartTask[i].LinkStage(this);
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				this.m_EndTask[j].LinkStage(this);
			}
		}

		// Token: 0x060006F8 RID: 1784 RVA: 0x000286FA File Offset: 0x000268FA
		public void AddSchedule(Schedule schedule)
		{
			if (this.m_Schedule == null)
			{
				this.m_Schedule = new ScheduleArray(256);
			}
			this.m_Schedule.AddSchedule(schedule);
		}

		// Token: 0x060006F9 RID: 1785 RVA: 0x00028720 File Offset: 0x00026920
		public Schedule[] GetLegSchedule(int legId)
		{
			if (this.m_Schedule == null)
			{
				return null;
			}
			return this.m_Schedule.GetLegSchedule(legId);
		}

		// Token: 0x060006FA RID: 1786 RVA: 0x00028738 File Offset: 0x00026938
		public Schedule[] GetLastLegSchedule()
		{
			if (this.m_Schedule == null)
			{
				return null;
			}
			return this.m_Schedule.GetLastLegSchedule();
		}

		// Token: 0x060006FB RID: 1787 RVA: 0x0002874F File Offset: 0x0002694F
		public bool RemoveLastLeg()
		{
			return this.m_Schedule != null && this.m_Schedule.RemoveLastLeg();
		}

		// Token: 0x060006FC RID: 1788 RVA: 0x00028766 File Offset: 0x00026966
		public Schedule AppendLeg(int dayDelay)
		{
			if (this.m_Schedule == null)
			{
				this.m_Schedule = new ScheduleArray(48);
			}
			return this.m_Schedule.AppendLeg(this, dayDelay);
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x0002878A File Offset: 0x0002698A
		public void CloneSchedule(Schedule originalSchedule, int timeDelay)
		{
			if (this.m_Schedule == null)
			{
				return;
			}
			this.m_Schedule.CloneSchedule(originalSchedule, timeDelay);
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000287A2 File Offset: 0x000269A2
		public void DeleteSchedule(Schedule originalSchedule)
		{
			if (this.m_Schedule == null)
			{
				return;
			}
			this.m_Schedule.DeleteSchedule(originalSchedule);
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000287BA File Offset: 0x000269BA
		public override bool SaveToSchedule(StreamWriter w)
		{
			return this.m_Schedule != null && this.m_Schedule.SaveToSchedule(w);
		}

		// Token: 0x06000700 RID: 1792 RVA: 0x000287D4 File Offset: 0x000269D4
		public string GetLanguageName()
		{
			if (FifaEnvironment.Language != null && base.Description != null)
			{
				string text = FifaEnvironment.Language.GetString(base.Description);
				if (text == null)
				{
					text = string.Empty;
				}
				return text;
			}
			return string.Empty;
		}

		// Token: 0x06000701 RID: 1793 RVA: 0x00028811 File Offset: 0x00026A11
		public bool SetLanguageName(string languageName)
		{
			if (FifaEnvironment.Language != null && base.Description != null)
			{
				FifaEnvironment.Language.SetString(base.Description, languageName);
				return true;
			}
			return false;
		}

		// Token: 0x06000702 RID: 1794 RVA: 0x00028838 File Offset: 0x00026A38
		public bool InsertGroup(int groupIndex)
		{
			if (groupIndex > base.Groups.Count)
			{
				return false;
			}
			string text = "G" + (groupIndex + 1).ToString();
			int newId = FifaEnvironment.CompetitionObjects.GetNewId();
			Group group = new Group(newId, text, " ", this);
			if (group == null)
			{
				return false;
			}
			base.Groups.Insert(groupIndex, group);
			FifaEnvironment.CompetitionObjects.Add(group);
			for (int i = 0; i < base.Groups.Count; i++)
			{
				text = "G" + (i + 1).ToString();
				Group group2 = (Group)base.Groups[i];
				group2.TypeString = text;
			}
			return true;
		}

		// Token: 0x06000703 RID: 1795 RVA: 0x000288EC File Offset: 0x00026AEC
		public bool RemoveGroup(Group group)
		{
			int num = base.Groups.IndexOf(group);
			if (num < 0)
			{
				return false;
			}
			this.RemoveGroup(num);
			return true;
		}

		// Token: 0x06000704 RID: 1796 RVA: 0x00028918 File Offset: 0x00026B18
		public bool RemoveGroup(int groupIndex)
		{
			if (groupIndex > base.Groups.Count)
			{
				return false;
			}
			Group group = (Group)base.Groups[groupIndex];
			base.Groups.RemoveAt(groupIndex);
			FifaEnvironment.CompetitionObjects.RemoveId(group);
			for (int i = 0; i < base.Groups.Count; i++)
			{
				string text = "G" + (i + 1).ToString();
				Group group2 = (Group)base.Groups[i];
				group2.TypeString = text;
			}
			return true;
		}

		// Token: 0x06000705 RID: 1797 RVA: 0x000289A8 File Offset: 0x00026BA8
		public bool RemoveAllGroups()
		{
			int count = base.Groups.Count;
			for (int i = 0; i < count; i++)
			{
				this.RemoveGroup(0);
			}
			return true;
		}

		// Token: 0x06000706 RID: 1798 RVA: 0x000289D6 File Offset: 0x00026BD6
		public bool RemoveAllSchedules()
		{
			if (this.m_Schedule == null)
			{
				return false;
			}
			this.m_Schedule.Clear();
			return true;
		}

		// Token: 0x06000707 RID: 1799 RVA: 0x000289EE File Offset: 0x00026BEE
		public new void LinkStadium(StadiumList stadiumList)
		{
		}

		// Token: 0x06000708 RID: 1800 RVA: 0x000289F0 File Offset: 0x00026BF0
		public override void Normalize()
		{
			if (base.Settings.m_match_matchimportance != -1 && this.Trophy != null)
			{
				if (this.Trophy.Settings.m_match_matchimportance == -1)
				{
					this.Trophy.Settings.m_match_matchimportance = base.Settings.m_match_matchimportance;
				}
				base.Settings.m_match_matchimportance = -1;
			}
			if (base.Settings.m_N_info_color_slot_adv_group != 0 && base.Groups != null)
			{
				foreach (object obj in base.Groups)
				{
					Group group = (Group)obj;
					if (group.Settings.m_N_info_color_slot_adv_group == 0)
					{
						group.Settings.m_info_color_slot_adv_group = new int[8];
						for (int i = 0; i < base.Settings.m_N_info_color_slot_adv_group; i++)
						{
							group.Settings.m_info_color_slot_adv_group[i] = base.Settings.m_info_color_slot_adv_group[i];
						}
						group.Settings.m_N_info_color_slot_adv_group = base.Settings.m_N_info_color_slot_adv_group;
					}
				}
				base.Settings.m_N_info_color_slot_adv_group = 0;
			}
			if (base.Settings.m_match_stagetype == null)
			{
				base.Settings.m_match_stagetype = "LEAGUE";
			}
			if (base.Settings.m_match_stagetype != "SETUP" && base.Settings.m_match_matchsituation == null)
			{
				base.Settings.m_match_matchsituation = "LEAGUE";
			}
			if (base.Settings.m_num_games != -1)
			{
				foreach (object obj2 in base.Groups)
				{
					Group group2 = (Group)obj2;
					if (group2.Settings.m_num_games == -1)
					{
						group2.Settings.m_num_games = base.Settings.m_num_games;
					}
				}
				base.Settings.m_num_games = -1;
			}
		}

		// Token: 0x06000709 RID: 1801 RVA: 0x00028BF8 File Offset: 0x00026DF8
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

		// Token: 0x0600070A RID: 1802 RVA: 0x00028CB0 File Offset: 0x00026EB0
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

		// Token: 0x0600070B RID: 1803 RVA: 0x00028D2C File Offset: 0x00026F2C
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

		// Token: 0x0600070C RID: 1804 RVA: 0x00028E2C File Offset: 0x0002702C
		public Task SearchTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			if (num >= 0)
			{
				return this.GetTask(when, num);
			}
			return null;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x00028E58 File Offset: 0x00027058
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

		// Token: 0x0600070E RID: 1806 RVA: 0x00028EEC File Offset: 0x000270EC
		public bool RemoveTask(string when, string action, int par1, int par2, int par3)
		{
			int num = this.SearchTaskIndex(when, action, par1, par2, par3);
			return num >= 0 && this.RemoveTask(when, num);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x00028F15 File Offset: 0x00027115
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

		// Token: 0x06000710 RID: 1808 RVA: 0x00028F52 File Offset: 0x00027152
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

		// Token: 0x06000711 RID: 1809 RVA: 0x00028F88 File Offset: 0x00027188
		public void CopyTasks(Stage newStage, League targetLeague)
		{
			for (int i = 0; i < this.m_NStartTasks; i++)
			{
				newStage.AddTask(this.m_StartTask[i].CopyTask(newStage, targetLeague));
			}
			for (int j = 0; j < this.m_NEndTasks; j++)
			{
				newStage.AddTask(this.m_EndTask[j].CopyTask(newStage, targetLeague));
			}
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00028FE4 File Offset: 0x000271E4
		public override bool SaveToTasks(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			if (this.Trophy == null)
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

		// Token: 0x04000293 RID: 659
		private ScheduleArray m_Schedule;

		// Token: 0x04000294 RID: 660
		private int m_NSchedule;

		// Token: 0x04000295 RID: 661
		private string m_ConventionalDescription;

		// Token: 0x04000296 RID: 662
		private Task[] m_StartTask;

		// Token: 0x04000297 RID: 663
		private int m_NStartTasks;

		// Token: 0x04000298 RID: 664
		private Task[] m_EndTask;

		// Token: 0x04000299 RID: 665
		private int m_NEndTasks;
	}
}
