using System;

namespace FifaLibrary
{
	// Token: 0x02000047 RID: 71
	public class TrophyList : IdArrayList
	{
		// Token: 0x060006ED RID: 1773 RVA: 0x00028543 File Offset: 0x00026743
		public TrophyList()
			: base(typeof(Trophy))
		{
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x00028558 File Offset: 0x00026758
		public void LinkLeague(LeagueList leagueList)
		{
			foreach (object obj in this)
			{
				Trophy trophy = (Trophy)obj;
				trophy.LinkLeague(leagueList);
			}
		}
	}
}
