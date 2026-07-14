using System;

namespace FifaLibrary
{
	// Token: 0x020000AF RID: 175
	public class TeamPlayer
	{
		// Token: 0x17000302 RID: 770
		// (get) Token: 0x06000DD5 RID: 3541 RVA: 0x00054652 File Offset: 0x00052852
		// (set) Token: 0x06000DD6 RID: 3542 RVA: 0x0005465A File Offset: 0x0005285A
		public int jerseynumber
		{
			get
			{
				return this.m_jerseynumber;
			}
			set
			{
				this.m_jerseynumber = value;
			}
		}

		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000DD7 RID: 3543 RVA: 0x00054663 File Offset: 0x00052863
		// (set) Token: 0x06000DD8 RID: 3544 RVA: 0x0005466B File Offset: 0x0005286B
		public int position
		{
			get
			{
				return this.m_position;
			}
			set
			{
				this.m_position = value;
			}
		}

		// Token: 0x17000304 RID: 772
		// (get) Token: 0x06000DD9 RID: 3545 RVA: 0x00054674 File Offset: 0x00052874
		// (set) Token: 0x06000DDA RID: 3546 RVA: 0x0005467C File Offset: 0x0005287C
		public Player Player
		{
			get
			{
				return this.m_Player;
			}
			set
			{
				this.m_Player = value;
			}
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06000DDB RID: 3547 RVA: 0x00054685 File Offset: 0x00052885
		// (set) Token: 0x06000DDC RID: 3548 RVA: 0x0005468D File Offset: 0x0005288D
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

		// Token: 0x06000DDD RID: 3549 RVA: 0x00054698 File Offset: 0x00052898
		public TeamPlayer(Record r, Player player, Team team)
		{
			this.m_jerseynumber = r.GetAndCheckIntField(FI.teamplayerlinks_jerseynumber);
			this.m_position = r.GetAndCheckIntField(FI.teamplayerlinks_position);
			this.m_Player = player;
			this.m_Team = team;
			this.m_leaguegoals = r.GetAndCheckIntField(FI.teamplayerlinks_leaguegoals);
			this.m_leagueappearances = r.GetAndCheckIntField(FI.teamplayerlinks_leagueappearances);
			this.m_prevform = r.GetAndCheckIntField(FI.teamplayerlinks_prevform);
			this.m_form = r.GetAndCheckIntField(FI.teamplayerlinks_form);
			this.m_isamongtopscorers = r.GetAndCheckIntField(FI.teamplayerlinks_isamongtopscorers) != 0;
			this.m_isamongtopscorersinteam = r.GetAndCheckIntField(FI.teamplayerlinks_isamongtopscorersinteam) != 0;
			this.m_istopscorer = r.GetAndCheckIntField(FI.teamplayerlinks_istopscorer) != 0;
			this.m_injury = r.GetAndCheckIntField(FI.teamplayerlinks_injury);
			this.m_yellows = r.GetAndCheckIntField(FI.teamplayerlinks_yellows);
			this.m_reds = r.GetAndCheckIntField(FI.teamplayerlinks_reds);
		}

		// Token: 0x06000DDE RID: 3550 RVA: 0x00054798 File Offset: 0x00052998
		public TeamPlayer(Player player)
		{
			this.m_jerseynumber = 99;
			this.m_position = player.preferredposition1;
			this.m_Player = player;
			this.m_leaguegoals = 0;
			this.m_isamongtopscorers = false;
			this.m_isamongtopscorersinteam = false;
			this.m_istopscorer = false;
			this.m_yellows = 0;
			this.m_reds = 0;
			this.m_injury = 0;
			this.m_leagueappearances = 0;
			this.m_form = 3;
			this.m_prevform = 3;
		}

		// Token: 0x06000DDF RID: 3551 RVA: 0x0005480C File Offset: 0x00052A0C
		public TeamPlayer(ERole role)
		{
			this.m_jerseynumber = 0;
			this.m_position = (int)role;
			this.m_Player = null;
			this.m_Team = null;
			this.m_leaguegoals = 0;
			this.m_isamongtopscorers = false;
			this.m_isamongtopscorersinteam = false;
			this.m_istopscorer = false;
			this.m_yellows = 0;
			this.m_reds = 0;
			this.m_injury = 0;
			this.m_leagueappearances = 0;
			this.m_form = 3;
			this.m_prevform = 3;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00054884 File Offset: 0x00052A84
		public void Save(Record r, int artificialkey)
		{
			if (this.m_Player == null)
			{
				return;
			}
			if (this.m_Team == null)
			{
				return;
			}
			r.IntField[FI.teamplayerlinks_artificialkey] = artificialkey;
			r.IntField[FI.teamplayerlinks_teamid] = this.m_Team.Id;
			r.IntField[FI.teamplayerlinks_playerid] = this.m_Player.Id;
			r.IntField[FI.teamplayerlinks_jerseynumber] = this.m_jerseynumber;
			r.IntField[FI.teamplayerlinks_position] = this.m_position;
			r.IntField[FI.teamplayerlinks_leaguegoals] = (this.m_leaguegoals = r.GetAndCheckIntField(FI.teamplayerlinks_leaguegoals));
			r.IntField[FI.teamplayerlinks_leagueappearances] = (this.m_leagueappearances = r.GetAndCheckIntField(FI.teamplayerlinks_leagueappearances));
			r.IntField[FI.teamplayerlinks_prevform] = (this.m_prevform = r.GetAndCheckIntField(FI.teamplayerlinks_prevform));
			r.IntField[FI.teamplayerlinks_form] = (this.m_form = r.GetAndCheckIntField(FI.teamplayerlinks_form));
			r.IntField[FI.teamplayerlinks_isamongtopscorers] = (this.m_isamongtopscorers ? 1 : 0);
			r.IntField[FI.teamplayerlinks_isamongtopscorersinteam] = (this.m_isamongtopscorersinteam ? 1 : 0);
			r.IntField[FI.teamplayerlinks_istopscorer] = (this.m_istopscorer ? 1 : 0);
			r.IntField[FI.teamplayerlinks_injury] = this.m_injury;
			r.IntField[FI.teamplayerlinks_yellows] = this.m_yellows;
			r.IntField[FI.teamplayerlinks_reds] = this.m_reds;
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00054A00 File Offset: 0x00052C00
		public override string ToString()
		{
			return this.m_jerseynumber.ToString() + " " + ((this.m_Player != null) ? this.m_Player.ToString() : string.Empty);
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x00054A34 File Offset: 0x00052C34
		public int AssignFreeNumber(int guessNumber)
		{
			int jerseynumber = this.m_jerseynumber;
			int num = ((guessNumber > jerseynumber) ? 1 : (-1));
			this.m_jerseynumber = this.RecursiveNumber(jerseynumber, num);
			return this.m_jerseynumber;
		}

		// Token: 0x06000DE3 RID: 3555 RVA: 0x00054A65 File Offset: 0x00052C65
		private int RecursiveNumber(int number, int step)
		{
			if (!this.m_Team.Roster.IsNumberFree(number))
			{
				if (number == 99)
				{
					number = 1;
				}
				else if (number == 1)
				{
					number = 99;
				}
				else
				{
					number += step;
				}
				return this.RecursiveNumber(number, step);
			}
			return number;
		}

		// Token: 0x040010ED RID: 4333
		public int m_jerseynumber;

		// Token: 0x040010EE RID: 4334
		private int m_position;

		// Token: 0x040010EF RID: 4335
		private Player m_Player;

		// Token: 0x040010F0 RID: 4336
		private Team m_Team;

		// Token: 0x040010F1 RID: 4337
		private int m_leaguegoals;

		// Token: 0x040010F2 RID: 4338
		private bool m_isamongtopscorers;

		// Token: 0x040010F3 RID: 4339
		private int m_yellows;

		// Token: 0x040010F4 RID: 4340
		private int m_reds;

		// Token: 0x040010F5 RID: 4341
		private bool m_isamongtopscorersinteam;

		// Token: 0x040010F6 RID: 4342
		private int m_injury;

		// Token: 0x040010F7 RID: 4343
		private int m_leagueappearances;

		// Token: 0x040010F8 RID: 4344
		private bool m_istopscorer;

		// Token: 0x040010F9 RID: 4345
		private int m_form;

		// Token: 0x040010FA RID: 4346
		private int m_prevform;
	}
}
