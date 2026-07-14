using System;

namespace FifaLibrary
{
	// Token: 0x02000053 RID: 83
	public class InitTeamList : IdArrayList
	{
		// Token: 0x0600079A RID: 1946 RVA: 0x0002C3C1 File Offset: 0x0002A5C1
		public InitTeamList()
			: base(typeof(InitTeam))
		{
		}

		// Token: 0x0600079B RID: 1947 RVA: 0x0002C3D4 File Offset: 0x0002A5D4
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				InitTeam initTeam = (InitTeam)obj;
				initTeam.LinkTeam(teamList);
			}
		}
	}
}
