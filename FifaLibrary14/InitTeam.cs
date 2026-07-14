using System;

namespace FifaLibrary
{
	// Token: 0x02000052 RID: 82
	public class InitTeam : IdObject
	{
		// Token: 0x170001A7 RID: 423
		// (get) Token: 0x06000795 RID: 1941 RVA: 0x0002C359 File Offset: 0x0002A559
		public int teamid
		{
			get
			{
				return this.m_teamid;
			}
		}

		// Token: 0x170001A8 RID: 424
		// (get) Token: 0x06000796 RID: 1942 RVA: 0x0002C361 File Offset: 0x0002A561
		// (set) Token: 0x06000797 RID: 1943 RVA: 0x0002C369 File Offset: 0x0002A569
		public Team Team
		{
			get
			{
				return this.m_Team;
			}
			set
			{
				this.m_Team = value;
				this.m_teamid = ((this.m_Team != null) ? this.m_Team.Id : (-1));
			}
		}

		// Token: 0x06000798 RID: 1944 RVA: 0x0002C38E File Offset: 0x0002A58E
		public InitTeam(int orderId, int teamId)
		{
			base.Id = orderId;
			this.m_teamid = teamId;
		}

		// Token: 0x06000799 RID: 1945 RVA: 0x0002C3A4 File Offset: 0x0002A5A4
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			this.m_Team = (Team)teamList.SearchId(this.m_teamid);
		}

		// Token: 0x040002C1 RID: 705
		private int m_teamid;

		// Token: 0x040002C2 RID: 706
		private Team m_Team;
	}
}
