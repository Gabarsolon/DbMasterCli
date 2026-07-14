using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x0200004F RID: 79
	public class ScheduleComparer : IComparer
	{
		// Token: 0x0600075D RID: 1885 RVA: 0x0002A6E8 File Offset: 0x000288E8
		int IComparer.Compare(object x, object y)
		{
			Schedule schedule = (Schedule)x;
			Schedule schedule2 = (Schedule)y;
			if (schedule.Day != schedule2.Day)
			{
				return schedule.Day - schedule2.Day;
			}
			return schedule.Time - schedule2.Time;
		}
	}
}
