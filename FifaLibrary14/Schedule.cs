using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200004E RID: 78
	public class Schedule
	{
		// Token: 0x1700018F RID: 399
		// (get) Token: 0x06000747 RID: 1863 RVA: 0x0002A2F5 File Offset: 0x000284F5
		// (set) Token: 0x06000748 RID: 1864 RVA: 0x0002A2FD File Offset: 0x000284FD
		public int Leg
		{
			get
			{
				return this.m_Leg;
			}
			set
			{
				this.m_Leg = value;
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x06000749 RID: 1865 RVA: 0x0002A306 File Offset: 0x00028506
		// (set) Token: 0x0600074A RID: 1866 RVA: 0x0002A30E File Offset: 0x0002850E
		public int MinGames
		{
			get
			{
				return this.m_MinGames;
			}
			set
			{
				this.m_MinGames = value;
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x0600074B RID: 1867 RVA: 0x0002A317 File Offset: 0x00028517
		// (set) Token: 0x0600074C RID: 1868 RVA: 0x0002A31F File Offset: 0x0002851F
		public int MaxGames
		{
			get
			{
				return this.m_MaxGames;
			}
			set
			{
				this.m_MaxGames = value;
			}
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x0600074D RID: 1869 RVA: 0x0002A328 File Offset: 0x00028528
		// (set) Token: 0x0600074E RID: 1870 RVA: 0x0002A330 File Offset: 0x00028530
		public int Time
		{
			get
			{
				return this.m_Time;
			}
			set
			{
				this.m_Time = value;
			}
		}

		// Token: 0x17000193 RID: 403
		// (get) Token: 0x0600074F RID: 1871 RVA: 0x0002A33C File Offset: 0x0002853C
		// (set) Token: 0x06000750 RID: 1872 RVA: 0x0002A368 File Offset: 0x00028568
		public int TimeIndex
		{
			get
			{
				int num = (this.m_Time / 100 - 12) * 4;
				return num + this.m_Time % 100 / 15;
			}
			set
			{
				this.m_Time = value / 4 * 100 + 1200;
				this.m_Time += value % 4 * 15;
			}
		}

		// Token: 0x17000194 RID: 404
		// (get) Token: 0x06000751 RID: 1873 RVA: 0x0002A38F File Offset: 0x0002858F
		// (set) Token: 0x06000752 RID: 1874 RVA: 0x0002A397 File Offset: 0x00028597
		public int Day
		{
			get
			{
				return this.m_Day;
			}
			set
			{
				this.m_Day = value;
			}
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000753 RID: 1875 RVA: 0x0002A3A0 File Offset: 0x000285A0
		public int Year
		{
			get
			{
				return this.m_Year;
			}
		}

		// Token: 0x17000196 RID: 406
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0002A3A8 File Offset: 0x000285A8
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x0002A418 File Offset: 0x00028618
		public DateTime Date
		{
			get
			{
				TimeSpan timeSpan = new TimeSpan(this.m_Day, this.m_Time / 100, this.m_Time % 100, 0);
				if (this.m_Day < 0)
				{
					return Schedule.s_BaseDate;
				}
				DateTime dateTime = Schedule.s_BaseDate.Add(timeSpan);
				dateTime.AddHours((double)(this.m_Time / 100));
				dateTime.AddMinutes((double)(this.m_Time % 100));
				return dateTime;
			}
			set
			{
				this.m_Day = (value - Schedule.s_BaseDate).Days;
			}
		}

		// Token: 0x06000756 RID: 1878 RVA: 0x0002A440 File Offset: 0x00028640
		public DateTime ConvertToDate(int gregorian)
		{
			DateTime dateTime = Schedule.s_BaseDate;
			if (gregorian < 0)
			{
				return dateTime;
			}
			return dateTime.AddDays((double)gregorian);
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0002A464 File Offset: 0x00028664
		public int ConvertFromDate(DateTime date)
		{
			DateTime dateTime = Schedule.s_BaseDate;
			return (date - dateTime).Days;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0002A488 File Offset: 0x00028688
		public Schedule(Stage stage, int day, int leg, int minGames, int maxGames, int time)
		{
			this.m_Stage = stage;
			this.m_Leg = leg;
			this.m_MinGames = minGames;
			this.m_MaxGames = maxGames;
			this.m_Time = time;
			this.m_Day = day;
			this.m_Year = 2012;
			bool flag;
			string property = stage.Settings.GetProperty("schedule_year_start", 0, out flag);
			if (property != null)
			{
				this.m_Year = Convert.ToInt32(property);
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0002A4F8 File Offset: 0x000286F8
		public Schedule(Group group, int day, int leg, int minGames, int maxGames, int time)
		{
			this.m_Group = group;
			this.m_Leg = leg;
			this.m_MinGames = minGames;
			this.m_MaxGames = maxGames;
			this.m_Time = time;
			this.m_Day = day;
			this.m_Year = 2012;
			bool flag;
			string property = group.Settings.GetProperty("schedule_year_start", 0, out flag);
			if (property != null)
			{
				this.m_Year = Convert.ToInt32(property);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0002A568 File Offset: 0x00028768
		public Schedule(Schedule srcSchedule)
		{
			this.m_Day = srcSchedule.m_Day;
			this.m_Leg = srcSchedule.m_Leg;
			this.m_MinGames = srcSchedule.m_MinGames;
			this.m_MaxGames = srcSchedule.m_MaxGames;
			this.m_Time = srcSchedule.m_Time;
			this.m_Group = srcSchedule.m_Group;
			this.m_Stage = srcSchedule.m_Stage;
			this.m_Year = srcSchedule.m_Year;
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0002A5DC File Offset: 0x000287DC
		public bool SaveToSchedule(StreamWriter w)
		{
			if (w == null)
			{
				return false;
			}
			string text;
			if (this.m_Group != null)
			{
				text = this.m_Group.Id.ToString() + ",";
			}
			else
			{
				if (this.m_Stage == null)
				{
					return false;
				}
				text = this.m_Stage.Id.ToString() + ",";
			}
			string text2 = text;
			text = string.Concat(new string[]
			{
				text2,
				this.m_Day.ToString(),
				",",
				this.m_Leg.ToString(),
				",",
				this.m_MinGames.ToString(),
				",",
				this.m_MaxGames.ToString(),
				",",
				this.m_Time.ToString()
			});
			w.WriteLine(text);
			return true;
		}

		// Token: 0x040002A7 RID: 679
		private Stage m_Stage;

		// Token: 0x040002A8 RID: 680
		private Group m_Group;

		// Token: 0x040002A9 RID: 681
		private int m_Leg;

		// Token: 0x040002AA RID: 682
		private int m_MinGames;

		// Token: 0x040002AB RID: 683
		private int m_MaxGames;

		// Token: 0x040002AC RID: 684
		private int m_Time;

		// Token: 0x040002AD RID: 685
		private int m_Day;

		// Token: 0x040002AE RID: 686
		private int m_Year;

		// Token: 0x040002AF RID: 687
		private static DateTime s_BaseDate = new DateTime(2012, 12, 30, 0, 0, 0);
	}
}
