using System;

namespace FifaLibrary
{
	// Token: 0x020000A5 RID: 165
	public class Formation : IdObject
	{
		// Token: 0x1700028A RID: 650
		// (get) Token: 0x06000C22 RID: 3106 RVA: 0x0004F6E3 File Offset: 0x0004D8E3
		// (set) Token: 0x06000C23 RID: 3107 RVA: 0x0004F6EB File Offset: 0x0004D8EB
		public PlayingRole[] PlayingRoles
		{
			get
			{
				return this.m_PlayingRoles;
			}
			set
			{
				this.m_PlayingRoles = value;
			}
		}

		// Token: 0x1700028B RID: 651
		// (get) Token: 0x06000C24 RID: 3108 RVA: 0x0004F6F4 File Offset: 0x0004D8F4
		// (set) Token: 0x06000C25 RID: 3109 RVA: 0x0004F6FC File Offset: 0x0004D8FC
		public Team Team
		{
			get
			{
				return this.m_Team;
			}
			set
			{
				this.m_Team = value;
				if (this.m_Team != null)
				{
					this.m_teamid = this.m_Team.Id;
					return;
				}
				this.m_teamid = -1;
			}
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x06000C26 RID: 3110 RVA: 0x0004F726 File Offset: 0x0004D926
		// (set) Token: 0x06000C27 RID: 3111 RVA: 0x0004F72E File Offset: 0x0004D92E
		public string formationname
		{
			get
			{
				return this.m_formationname;
			}
			set
			{
				this.m_formationname = value;
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x06000C28 RID: 3112 RVA: 0x0004F737 File Offset: 0x0004D937
		// (set) Token: 0x06000C29 RID: 3113 RVA: 0x0004F73F File Offset: 0x0004D93F
		public string formationfullname
		{
			get
			{
				return this.m_formationfullname;
			}
			set
			{
				this.m_formationfullname = value;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x06000C2A RID: 3114 RVA: 0x0004F748 File Offset: 0x0004D948
		// (set) Token: 0x06000C2B RID: 3115 RVA: 0x0004F750 File Offset: 0x0004D950
		public int teamid
		{
			get
			{
				return this.m_teamid;
			}
			set
			{
				this.m_teamid = value;
			}
		}

		// Token: 0x1700028F RID: 655
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0004F759 File Offset: 0x0004D959
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x0004F761 File Offset: 0x0004D961
		public int relativeformationid
		{
			get
			{
				return this.m_relativeformationid;
			}
			set
			{
				this.m_relativeformationid = value;
			}
		}

		// Token: 0x17000290 RID: 656
		// (get) Token: 0x06000C2E RID: 3118 RVA: 0x0004F76A File Offset: 0x0004D96A
		// (set) Token: 0x06000C2F RID: 3119 RVA: 0x0004F772 File Offset: 0x0004D972
		public int formations_issweeper
		{
			get
			{
				return this.m_formations_issweeper;
			}
			set
			{
				this.m_formations_issweeper = value;
			}
		}

		// Token: 0x17000291 RID: 657
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0004F77B File Offset: 0x0004D97B
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x0004F783 File Offset: 0x0004D983
		public int offensiverating
		{
			get
			{
				return this.m_offensiverating;
			}
			set
			{
				this.m_offensiverating = value;
			}
		}

		// Token: 0x17000292 RID: 658
		// (get) Token: 0x06000C32 RID: 3122 RVA: 0x0004F78C File Offset: 0x0004D98C
		// (set) Token: 0x06000C33 RID: 3123 RVA: 0x0004F794 File Offset: 0x0004D994
		public int formationfullnameid
		{
			get
			{
				return this.m_formationfullnameid;
			}
			set
			{
				this.m_formationfullnameid = value;
			}
		}

		// Token: 0x17000293 RID: 659
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0004F79D File Offset: 0x0004D99D
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x0004F7A5 File Offset: 0x0004D9A5
		public float defenders
		{
			get
			{
				return this.m_defenders;
			}
			set
			{
				this.m_defenders = value;
			}
		}

		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000C36 RID: 3126 RVA: 0x0004F7AE File Offset: 0x0004D9AE
		// (set) Token: 0x06000C37 RID: 3127 RVA: 0x0004F7B6 File Offset: 0x0004D9B6
		public float midfielders
		{
			get
			{
				return this.m_midfielders;
			}
			set
			{
				this.m_midfielders = value;
			}
		}

		// Token: 0x17000295 RID: 661
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0004F7BF File Offset: 0x0004D9BF
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x0004F7C7 File Offset: 0x0004D9C7
		public float attackers
		{
			get
			{
				return this.m_attackers;
			}
			set
			{
				this.m_attackers = value;
			}
		}

		// Token: 0x06000C3A RID: 3130 RVA: 0x0004F7D0 File Offset: 0x0004D9D0
		public bool IsGeneric()
		{
			return this.m_teamid == -1;
		}

		// Token: 0x17000296 RID: 662
		// (get) Token: 0x06000C3B RID: 3131 RVA: 0x0004F7DB File Offset: 0x0004D9DB
		// (set) Token: 0x06000C3C RID: 3132 RVA: 0x0004F7E3 File Offset: 0x0004D9E3
		public string Name
		{
			get
			{
				return this.m_formationname;
			}
			set
			{
				if (value != null)
				{
					this.m_formationname = value;
					return;
				}
				this.m_formationname = string.Empty;
			}
		}

		// Token: 0x06000C3D RID: 3133 RVA: 0x0004F7FB File Offset: 0x0004D9FB
		public override string ToString()
		{
			if (this.m_teamid > 0 && this.m_Team != null)
			{
				return this.m_Team.DatabaseName + " " + this.m_formationfullname;
			}
			return this.m_formationfullname;
		}

		// Token: 0x06000C3E RID: 3134 RVA: 0x0004F830 File Offset: 0x0004DA30
		public string DatabaseString()
		{
			return this.ToString();
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0004F838 File Offset: 0x0004DA38
		public Formation(int formationid)
			: base(formationid)
		{
			base.Id = formationid;
			this.InitNewFormation();
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0004F85C File Offset: 0x0004DA5C
		public bool ReInitialize(Formation formation)
		{
			if (formation == null)
			{
				return false;
			}
			this.m_formationname = formation.m_formationname;
			this.m_formationfullname = formation.m_formationfullname;
			this.m_relativeformationid = formation.m_relativeformationid;
			this.m_formations_issweeper = formation.m_formations_issweeper;
			this.m_offensiverating = formation.m_offensiverating;
			this.m_formationfullnameid = formation.m_formationfullnameid;
			this.m_defenders = formation.m_defenders;
			this.m_midfielders = formation.m_midfielders;
			this.m_attackers = formation.m_attackers;
			for (int i = 0; i < 11; i++)
			{
				this.m_PlayingRoles[i].ReInitialize(formation.m_PlayingRoles[i]);
			}
			return true;
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0004F8FE File Offset: 0x0004DAFE
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			this.m_Team = (Team)teamList.SearchId(this.m_teamid);
		}

		// Token: 0x06000C42 RID: 3138 RVA: 0x0004F91C File Offset: 0x0004DB1C
		private void InitNewFormation()
		{
			this.m_formationname = "4-4-2";
			this.m_formationfullname = string.Empty;
			this.m_teamid = -1;
			this.m_relativeformationid = 24;
			this.m_formations_issweeper = 0;
			this.m_offensiverating = 1;
			this.m_formationfullnameid = -1;
			this.m_defenders = 4f;
			this.m_midfielders = 4f;
			this.m_attackers = 2f;
			this.m_PlayingRoles[0] = new PlayingRole((Role)FifaEnvironment.Roles[0]);
			this.m_PlayingRoles[1] = new PlayingRole((Role)FifaEnvironment.Roles[3]);
			this.m_PlayingRoles[2] = new PlayingRole((Role)FifaEnvironment.Roles[4]);
			this.m_PlayingRoles[3] = new PlayingRole((Role)FifaEnvironment.Roles[6]);
			this.m_PlayingRoles[4] = new PlayingRole((Role)FifaEnvironment.Roles[7]);
			this.m_PlayingRoles[5] = new PlayingRole((Role)FifaEnvironment.Roles[12]);
			this.m_PlayingRoles[6] = new PlayingRole((Role)FifaEnvironment.Roles[13]);
			this.m_PlayingRoles[7] = new PlayingRole((Role)FifaEnvironment.Roles[15]);
			this.m_PlayingRoles[8] = new PlayingRole((Role)FifaEnvironment.Roles[16]);
			this.m_PlayingRoles[9] = new PlayingRole((Role)FifaEnvironment.Roles[24]);
			this.m_PlayingRoles[10] = new PlayingRole((Role)FifaEnvironment.Roles[26]);
		}

		// Token: 0x06000C43 RID: 3139 RVA: 0x0004FACB File Offset: 0x0004DCCB
		public Formation(Record r)
			: base(r.IntField[FI.formations_formationid])
		{
			this.Load(r);
		}

		// Token: 0x06000C44 RID: 3140 RVA: 0x0004FAF4 File Offset: 0x0004DCF4
		public override IdObject Clone(int newId)
		{
			Formation formation = (Formation)base.Clone(newId);
			formation.m_PlayingRoles = new PlayingRole[11];
			for (int i = 0; i < 11; i++)
			{
				int id = this.m_PlayingRoles[i].Id;
				PlayingRole playingRole = (PlayingRole)this.m_PlayingRoles[i].Clone(id);
				formation.m_PlayingRoles[i] = playingRole;
			}
			formation.m_formationname = "=" + formation.m_formationname;
			formation.m_Team = null;
			return formation;
		}

		// Token: 0x06000C45 RID: 3141 RVA: 0x0004FB74 File Offset: 0x0004DD74
		public void Load(Record r)
		{
			this.m_formationname = r.StringField[FI.formations_formationname];
			this.m_teamid = r.IntField[FI.formations_teamid];
			this.m_relativeformationid = r.IntField[FI.formations_relativeformationid];
			this.m_formations_issweeper = r.IntField[FI.formations_issweeper];
			this.m_offensiverating = r.IntField[FI.formations_offensiverating];
			this.m_formationfullnameid = r.IntField[FI.formations_formationfullnameid];
			this.m_defenders = r.FloatField[FI.formations_defenders];
			this.m_midfielders = r.FloatField[FI.formations_midfielders];
			this.m_attackers = r.FloatField[FI.formations_attackers];
			this.m_PlayingRoles[0] = new PlayingRole(r, 0, FI.formations_position0);
			this.m_PlayingRoles[1] = new PlayingRole(r, 1, FI.formations_position1);
			this.m_PlayingRoles[2] = new PlayingRole(r, 2, FI.formations_position2);
			this.m_PlayingRoles[3] = new PlayingRole(r, 3, FI.formations_position3);
			this.m_PlayingRoles[4] = new PlayingRole(r, 4, FI.formations_position4);
			this.m_PlayingRoles[5] = new PlayingRole(r, 5, FI.formations_position5);
			this.m_PlayingRoles[6] = new PlayingRole(r, 6, FI.formations_position6);
			this.m_PlayingRoles[7] = new PlayingRole(r, 7, FI.formations_position7);
			this.m_PlayingRoles[8] = new PlayingRole(r, 8, FI.formations_position8);
			this.m_PlayingRoles[9] = new PlayingRole(r, 9, FI.formations_position9);
			this.m_PlayingRoles[10] = new PlayingRole(r, 10, FI.formations_position10);
			if (this.m_formationfullnameid != -1 && FifaEnvironment.Language != null)
			{
				this.m_formationfullname = FifaEnvironment.Language.GetFormationString(this.m_formationfullnameid);
			}
			if (this.m_formationfullname == null || this.m_formationfullname == string.Empty)
			{
				this.m_formationfullname = this.m_formationname;
			}
		}

		// Token: 0x06000C46 RID: 3142 RVA: 0x0004FD50 File Offset: 0x0004DF50
		public void Save(Record r)
		{
			r.IntField[FI.formations_formationid] = base.Id;
			r.StringField[FI.formations_formationname] = this.m_formationname;
			r.IntField[FI.formations_formationfullnameid] = this.m_formationfullnameid;
			if (this.m_Team != null)
			{
				r.IntField[FI.formations_teamid] = this.m_Team.Id;
			}
			else
			{
				r.IntField[FI.formations_teamid] = -1;
			}
			r.IntField[FI.formations_relativeformationid] = this.m_relativeformationid;
			r.IntField[FI.formations_issweeper] = this.m_formations_issweeper;
			r.IntField[FI.formations_offensiverating] = this.m_offensiverating;
			r.FloatField[FI.formations_defenders] = this.m_defenders;
			r.FloatField[FI.formations_midfielders] = this.m_midfielders;
			r.FloatField[FI.formations_attackers] = this.m_attackers;
			r.IntField[FI.formations_attackingrole_0] = 3;
			r.IntField[FI.formations_attackingrole_1] = 3;
			r.IntField[FI.formations_attackingrole_2] = 3;
			r.IntField[FI.formations_attackingrole_3] = 3;
			r.IntField[FI.formations_attackingrole_4] = 3;
			r.IntField[FI.formations_attackingrole_5] = 3;
			r.IntField[FI.formations_attackingrole_6] = 3;
			r.IntField[FI.formations_attackingrole_7] = 3;
			r.IntField[FI.formations_attackingrole_8] = 3;
			r.IntField[FI.formations_attackingrole_9] = 3;
			r.IntField[FI.formations_attackingrole_10] = 3;
			r.IntField[FI.formations_defensiverole_0] = 3;
			r.IntField[FI.formations_defensiverole_1] = 3;
			r.IntField[FI.formations_defensiverole_2] = 3;
			r.IntField[FI.formations_defensiverole_3] = 3;
			r.IntField[FI.formations_defensiverole_4] = 3;
			r.IntField[FI.formations_defensiverole_5] = 3;
			r.IntField[FI.formations_defensiverole_6] = 3;
			r.IntField[FI.formations_defensiverole_7] = 3;
			r.IntField[FI.formations_defensiverole_8] = 3;
			r.IntField[FI.formations_defensiverole_9] = 3;
			r.IntField[FI.formations_defensiverole_10] = 3;
			for (int i = 0; i < 11; i++)
			{
				this.m_PlayingRoles[i].Save(r, i);
			}
			this.SaveLanguage();
		}

		// Token: 0x06000C47 RID: 3143 RVA: 0x0004FF6D File Offset: 0x0004E16D
		public void SaveLanguage()
		{
			if (this.m_formationfullnameid != -1 && FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetFormationString(this.m_formationfullnameid, this.m_formationfullname);
			}
		}

		// Token: 0x06000C48 RID: 3144 RVA: 0x0004FF95 File Offset: 0x0004E195
		public static string RoleToString(ERole role)
		{
			if (FifaEnvironment.Language != null)
			{
				return FifaEnvironment.Language.GetRoleLongString((int)role);
			}
			return string.Empty;
		}

		// Token: 0x06000C49 RID: 3145 RVA: 0x0004FFB0 File Offset: 0x0004E1B0
		public int ComputeDistance(Formation formation)
		{
			int num = 0;
			for (int i = 0; i < 11; i++)
			{
				num += Math.Abs(this.m_PlayingRoles[i].Role.RoleId - formation.PlayingRoles[i].Role.RoleId);
			}
			return num;
		}

		// Token: 0x06000C4A RID: 3146 RVA: 0x0004FFFC File Offset: 0x0004E1FC
		public int ComputeSimilarity(Formation formation)
		{
			int num = 0;
			int[] array = new int[11];
			bool[] array2 = new bool[11];
			for (int i = 0; i < 11; i++)
			{
				array[i] = 1;
				array2[i] = false;
			}
			for (int j = 0; j < 11; j++)
			{
				array[j] = 1;
				for (int k = 0; k < 11; k++)
				{
					if (this.m_PlayingRoles[j].Role.RoleId == formation.PlayingRoles[k].Role.RoleId)
					{
						array[j] = 0;
						array2[k] = true;
						break;
					}
				}
			}
			for (int l = 0; l < 11; l++)
			{
				if (array[l] != 0)
				{
					for (int m = 0; m < 11; m++)
					{
						if (!array2[m])
						{
							array2[m] = true;
							num += Math.Abs(this.m_PlayingRoles[l].Role.RoleId - formation.PlayingRoles[m].Role.RoleId);
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06000C4B RID: 3147 RVA: 0x000500EE File Offset: 0x0004E2EE
		public void LinkTeam(Team team)
		{
			if (team != null && base.Id <= 800)
			{
				this.m_Team = team;
				this.Name = team.TeamNameFull;
			}
		}

		// Token: 0x06000C4C RID: 3148 RVA: 0x00050114 File Offset: 0x0004E314
		public void LinkRoles(RoleList roleList)
		{
			for (int i = 0; i < 11; i++)
			{
				this.m_PlayingRoles[i].LinkRole(roleList);
			}
		}

		// Token: 0x06000C4D RID: 3149 RVA: 0x0005013C File Offset: 0x0004E33C
		public bool IsRoleUsed(ERole eRole)
		{
			for (int i = 0; i < 11; i++)
			{
				if (this.m_PlayingRoles[i].Role.RoleId == eRole)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04001056 RID: 4182
		private PlayingRole[] m_PlayingRoles = new PlayingRole[11];

		// Token: 0x04001057 RID: 4183
		private Team m_Team;

		// Token: 0x04001058 RID: 4184
		private string m_formationname;

		// Token: 0x04001059 RID: 4185
		private string m_formationfullname;

		// Token: 0x0400105A RID: 4186
		private int m_teamid;

		// Token: 0x0400105B RID: 4187
		private int m_relativeformationid;

		// Token: 0x0400105C RID: 4188
		private int m_formations_issweeper;

		// Token: 0x0400105D RID: 4189
		private int m_offensiverating;

		// Token: 0x0400105E RID: 4190
		private int m_formationfullnameid;

		// Token: 0x0400105F RID: 4191
		private float m_defenders;

		// Token: 0x04001060 RID: 4192
		private float m_midfielders;

		// Token: 0x04001061 RID: 4193
		private float m_attackers;
	}
}
