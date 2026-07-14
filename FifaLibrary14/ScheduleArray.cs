using System;
using System.Collections;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000050 RID: 80
	public class ScheduleArray : ArrayList
	{
		// Token: 0x17000197 RID: 407
		// (get) Token: 0x0600075F RID: 1887 RVA: 0x0002A734 File Offset: 0x00028934
		// (set) Token: 0x06000760 RID: 1888 RVA: 0x0002A73C File Offset: 0x0002893C
		public Schedule[] Schedules
		{
			get
			{
				return this.m_Schedules;
			}
			set
			{
				this.m_Schedules = value;
			}
		}

		// Token: 0x17000198 RID: 408
		// (get) Token: 0x06000761 RID: 1889 RVA: 0x0002A745 File Offset: 0x00028945
		// (set) Token: 0x06000762 RID: 1890 RVA: 0x0002A74D File Offset: 0x0002894D
		public int NSchedules
		{
			get
			{
				return this.m_NSchedules;
			}
			set
			{
				this.m_NSchedules = value;
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0002A756 File Offset: 0x00028956
		public ScheduleArray(int length)
		{
			this.m_NSchedules = 0;
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0002A768 File Offset: 0x00028968
		public Schedule[] GetLegSchedule(int legId)
		{
			int num = 0;
			foreach (object obj in this)
			{
				Schedule schedule = (Schedule)obj;
				if (schedule.Leg == legId)
				{
					num++;
				}
			}
			if (num == 0)
			{
				return null;
			}
			Schedule[] array = new Schedule[num];
			num = 0;
			foreach (object obj2 in this)
			{
				Schedule schedule2 = (Schedule)obj2;
				if (schedule2.Leg == legId)
				{
					array[num++] = schedule2;
				}
			}
			return array;
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0002A830 File Offset: 0x00028A30
		public void RenumberLegs()
		{
			this.Sort(ScheduleArray.m_Comparer);
			int num = 0;
			int num2 = 0;
			foreach (object obj in this)
			{
				Schedule schedule = (Schedule)obj;
				int leg = schedule.Leg;
				if (num2 != leg)
				{
					num2 = leg;
					num++;
				}
				schedule.Leg = num;
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0002A8AC File Offset: 0x00028AAC
		public Schedule DuplicatetLeg(int legId, int dayDelay)
		{
			Schedule[] legSchedule = this.GetLegSchedule(legId);
			if (legSchedule == null)
			{
				return null;
			}
			int num = -1;
			int num2 = 0;
			for (int i = 0; i < this.Count; i++)
			{
				Schedule schedule = (Schedule)this[i];
				if (schedule.Leg == legId)
				{
					if (num < 0)
					{
						num = i;
					}
					num2++;
				}
			}
			if (num2 == 0)
			{
				return null;
			}
			num += num2;
			Schedule schedule2 = null;
			for (int j = legSchedule.Length - 1; j >= 0; j--)
			{
				schedule2 = new Schedule(legSchedule[j]);
				schedule2.Day += dayDelay;
				this.Insert(num, schedule2);
			}
			for (int k = num; k < this.Count; k++)
			{
				Schedule schedule3 = (Schedule)this[k];
				schedule3.Leg++;
			}
			return schedule2;
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0002A978 File Offset: 0x00028B78
		public bool RemoveLeg(int legId)
		{
			int num = -1;
			int num2 = 0;
			for (int i = 0; i < this.Count; i++)
			{
				Schedule schedule = (Schedule)this[i];
				if (schedule.Leg == legId)
				{
					if (num < 0)
					{
						num = i;
					}
					num2++;
				}
			}
			if (num2 > 0)
			{
				this.RemoveRange(num, num2);
				for (int i = num; i < this.Count; i++)
				{
					Schedule schedule2 = (Schedule)this[i];
					schedule2.Leg--;
				}
				return true;
			}
			return false;
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0002A9F8 File Offset: 0x00028BF8
		public bool AddScheduleToLeg(Schedule schedule)
		{
			int num = -1;
			int num2 = 0;
			for (int i = 0; i < this.Count; i++)
			{
				Schedule schedule2 = (Schedule)this[i];
				if (schedule2.Leg == schedule.Leg)
				{
					if (num < 0)
					{
						num = i;
					}
					num2++;
				}
			}
			if (num2 > 0)
			{
				this.Insert(num + num2, schedule);
				return true;
			}
			return false;
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0002AA50 File Offset: 0x00028C50
		public bool DeleteSchedule(Schedule schedule)
		{
			for (int i = 0; i < this.Count; i++)
			{
				Schedule schedule2 = (Schedule)this[i];
				if (schedule2.Leg == schedule.Leg && schedule2.Day == schedule.Day && schedule2.Time == schedule.Time && schedule2.MinGames == schedule.MinGames && schedule2.MaxGames == schedule.MaxGames)
				{
					this.RemoveAt(i);
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0002AACB File Offset: 0x00028CCB
		public void AddSchedule(Schedule schedule)
		{
			this.Add(schedule);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0002AAD8 File Offset: 0x00028CD8
		public Schedule[] GetLastLegSchedule()
		{
			if (this.Count <= 0)
			{
				return null;
			}
			Schedule schedule = (Schedule)this[this.Count - 1];
			int leg = schedule.Leg;
			return this.GetLegSchedule(leg);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0002AB14 File Offset: 0x00028D14
		public bool RemoveLastLeg()
		{
			if (this.Count <= 0)
			{
				return false;
			}
			Schedule schedule = (Schedule)this[this.Count - 1];
			int leg = schedule.Leg;
			return this.RemoveLeg(leg);
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0002AB50 File Offset: 0x00028D50
		public Schedule AppendLeg(Compobj compobj, int dayDelay)
		{
			if (this.Count > 0)
			{
				Schedule[] lastLegSchedule = this.GetLastLegSchedule();
				Schedule schedule = null;
				for (int i = 0; i < lastLegSchedule.Length; i++)
				{
					schedule = new Schedule(lastLegSchedule[i]);
					schedule.Leg++;
					schedule.Day += dayDelay;
					this.AddSchedule(schedule);
				}
				return schedule;
			}
			if (compobj.IsGroup())
			{
				Group group = (Group)compobj;
				Schedule schedule2 = new Schedule(group, 215, 1, 1, 1, 1500);
				this.AddSchedule(schedule2);
				return schedule2;
			}
			if (compobj.IsStage())
			{
				Stage stage = (Stage)compobj;
				Schedule schedule3 = new Schedule(stage, 215, 1, 1, 1, 1500);
				this.AddSchedule(schedule3);
				return schedule3;
			}
			return null;
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0002AC14 File Offset: 0x00028E14
		public void CloneSchedule(Schedule originalSchedule, int timeDelay)
		{
			Schedule schedule = new Schedule(originalSchedule);
			schedule.Time += timeDelay;
			this.AddScheduleToLeg(schedule);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0002AC40 File Offset: 0x00028E40
		public bool SaveToSchedule(StreamWriter w)
		{
			foreach (object obj in this)
			{
				Schedule schedule = (Schedule)obj;
				schedule.SaveToSchedule(w);
			}
			return true;
		}

		// Token: 0x040002B0 RID: 688
		private Schedule[] m_Schedules;

		// Token: 0x040002B1 RID: 689
		private int m_NSchedules;

		// Token: 0x040002B2 RID: 690
		private static ScheduleComparer m_Comparer = new ScheduleComparer();
	}
}
