using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x020000A4 RID: 164
	public class PlayingRole : IdObject
	{
		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000C0D RID: 3085 RVA: 0x0004E874 File Offset: 0x0004CA74
		// (set) Token: 0x06000C0E RID: 3086 RVA: 0x0004E87C File Offset: 0x0004CA7C
		public Role Role
		{
			get
			{
				return this.m_Role;
			}
			set
			{
				this.m_Role = value;
				base.Id = this.m_Role.Id;
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000C0F RID: 3087 RVA: 0x0004E896 File Offset: 0x0004CA96
		// (set) Token: 0x06000C10 RID: 3088 RVA: 0x0004E89E File Offset: 0x0004CA9E
		public int OffsetX
		{
			get
			{
				return this.m_OffsetX;
			}
			set
			{
				this.m_OffsetX = value;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000C11 RID: 3089 RVA: 0x0004E8A7 File Offset: 0x0004CAA7
		// (set) Token: 0x06000C12 RID: 3090 RVA: 0x0004E8AF File Offset: 0x0004CAAF
		public int OffsetY
		{
			get
			{
				return this.m_OffsetY;
			}
			set
			{
				this.m_OffsetY = value;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000C13 RID: 3091 RVA: 0x0004E8B8 File Offset: 0x0004CAB8
		// (set) Token: 0x06000C14 RID: 3092 RVA: 0x0004E8C0 File Offset: 0x0004CAC0
		public EPlayingDirection OffDirection0
		{
			get
			{
				return this.m_OffDirection;
			}
			set
			{
				this.m_OffDirection = value;
			}
		}

		// Token: 0x17000287 RID: 647
		// (get) Token: 0x06000C15 RID: 3093 RVA: 0x0004E8C9 File Offset: 0x0004CAC9
		// (set) Token: 0x06000C16 RID: 3094 RVA: 0x0004E8D1 File Offset: 0x0004CAD1
		public EPlayingIntensity OffIntensity
		{
			get
			{
				return this.m_OffIntensity;
			}
			set
			{
				this.m_OffIntensity = value;
			}
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x06000C17 RID: 3095 RVA: 0x0004E8DA File Offset: 0x0004CADA
		// (set) Token: 0x06000C18 RID: 3096 RVA: 0x0004E8E2 File Offset: 0x0004CAE2
		public EPlayingDirection DefDirection0
		{
			get
			{
				return this.m_DefDirection;
			}
			set
			{
				this.m_DefDirection = value;
			}
		}

		// Token: 0x17000289 RID: 649
		// (get) Token: 0x06000C19 RID: 3097 RVA: 0x0004E8EB File Offset: 0x0004CAEB
		// (set) Token: 0x06000C1A RID: 3098 RVA: 0x0004E8F3 File Offset: 0x0004CAF3
		public EPlayingIntensity DefIntensity
		{
			get
			{
				return this.m_DefIntensity;
			}
			set
			{
				this.m_DefIntensity = value;
			}
		}

		// Token: 0x06000C1B RID: 3099 RVA: 0x0004E8FC File Offset: 0x0004CAFC
		public PlayingRole(Record r, int roleOrder, int fieldIndex)
			: base(r.GetAndCheckIntField(fieldIndex))
		{
			this.Load(r, roleOrder);
		}

		// Token: 0x06000C1C RID: 3100 RVA: 0x0004E914 File Offset: 0x0004CB14
		public PlayingRole(Role role)
			: base(role.Id)
		{
			Point center = role.GetCenter();
			this.m_Role = role;
			this.m_OffsetX = center.X;
			this.m_OffsetY = center.Y;
			this.m_OffDirection = EPlayingDirection.Standing;
			this.m_OffIntensity = EPlayingIntensity.Normal;
			this.m_DefDirection = EPlayingDirection.Standing;
			this.m_DefIntensity = EPlayingIntensity.Normal;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0004E974 File Offset: 0x0004CB74
		public bool ReInitialize(PlayingRole playingRole)
		{
			if (playingRole == null)
			{
				return false;
			}
			this.m_RoleId = playingRole.m_RoleId;
			this.m_OffsetX = playingRole.m_OffsetX;
			this.m_OffsetY = playingRole.m_OffsetY;
			this.m_OffDirection = playingRole.m_OffDirection;
			this.m_OffIntensity = playingRole.m_OffIntensity;
			this.m_DefDirection = playingRole.m_DefDirection;
			this.m_DefIntensity = playingRole.m_DefIntensity;
			return true;
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0004E9DB File Offset: 0x0004CBDB
		public override string ToString()
		{
			return this.Role.ToString();
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0004E9E8 File Offset: 0x0004CBE8
		public void LinkRole(RoleList roleList)
		{
			this.m_Role = (Role)roleList.SearchId(this.m_RoleId);
		}

		// Token: 0x06000C20 RID: 3104 RVA: 0x0004EA04 File Offset: 0x0004CC04
		public void Load(Record r, int i)
		{
			base.Id = i;
			switch (i)
			{
			case 0:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position0);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset0x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset0y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_0);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_0);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_0);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_0);
				break;
			case 1:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position1);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset1x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset1y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_1);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_1);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_1);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_1);
				break;
			case 2:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position2);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset2x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset2y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_2);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_2);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_2);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_2);
				break;
			case 3:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position3);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset3x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset3y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_3);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_3);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_3);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_3);
				break;
			case 4:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position4);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset4x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset4y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_4);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_4);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_4);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_4);
				break;
			case 5:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position5);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset5x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset5y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_5);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_5);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_5);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_5);
				break;
			case 6:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position6);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset6x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset6y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_6);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_6);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_6);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_6);
				break;
			case 7:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position7);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset7x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset7y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_7);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_7);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_7);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_7);
				break;
			case 8:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position8);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset8x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset8y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_8);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_8);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_8);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_8);
				break;
			case 9:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position9);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset9x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset9y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_9);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_9);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_9);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_9);
				break;
			case 10:
				this.m_RoleId = r.GetAndCheckIntField(FI.formations_position10);
				this.m_OffsetX = (int)(r.FloatField[FI.formations_offset10x] * 100f);
				this.m_OffsetY = (int)(r.FloatField[FI.formations_offset10y] * 100f);
				this.m_OffDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_attackingdirection_10);
				this.m_OffIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_attackingrole_10);
				this.m_DefDirection = (EPlayingDirection)r.GetAndCheckIntField(FI.formations_defensivedirection_10);
				this.m_DefIntensity = (EPlayingIntensity)r.GetAndCheckIntField(FI.formations_defensiverole_10);
				break;
			}
			this.LinkRole(FifaEnvironment.Roles);
		}

		// Token: 0x06000C21 RID: 3105 RVA: 0x0004F05C File Offset: 0x0004D25C
		public void Save(Record r, int i)
		{
			switch (i)
			{
			case 0:
				r.IntField[FI.formations_position0] = this.m_Role.Id;
				r.FloatField[FI.formations_offset0x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset0y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_0] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_0] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_0] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_0] = (int)this.m_DefIntensity;
				return;
			case 1:
				r.IntField[FI.formations_position1] = this.m_Role.Id;
				r.FloatField[FI.formations_offset1x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset1y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_1] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_1] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_1] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_1] = (int)this.m_DefIntensity;
				return;
			case 2:
				r.IntField[FI.formations_position2] = this.m_Role.Id;
				r.FloatField[FI.formations_offset2x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset2y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_2] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_2] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_2] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_2] = (int)this.m_DefIntensity;
				return;
			case 3:
				r.IntField[FI.formations_position3] = this.m_Role.Id;
				r.FloatField[FI.formations_offset3x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset3y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_3] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_3] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_3] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_3] = (int)this.m_DefIntensity;
				return;
			case 4:
				r.IntField[FI.formations_position4] = this.m_Role.Id;
				r.FloatField[FI.formations_offset4x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset4y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_4] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_4] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_4] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_4] = (int)this.m_DefIntensity;
				return;
			case 5:
				r.IntField[FI.formations_position5] = this.m_Role.Id;
				r.FloatField[FI.formations_offset5x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset5y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_5] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_5] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_5] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_5] = (int)this.m_DefIntensity;
				return;
			case 6:
				r.IntField[FI.formations_position6] = this.m_Role.Id;
				r.FloatField[FI.formations_offset6x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset6y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_6] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_6] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_6] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_6] = (int)this.m_DefIntensity;
				return;
			case 7:
				r.IntField[FI.formations_position7] = this.m_Role.Id;
				r.FloatField[FI.formations_offset7x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset7y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_7] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_7] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_7] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_7] = (int)this.m_DefIntensity;
				return;
			case 8:
				r.IntField[FI.formations_position8] = this.m_Role.Id;
				r.FloatField[FI.formations_offset8x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset8y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_8] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_8] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_8] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_8] = (int)this.m_DefIntensity;
				return;
			case 9:
				r.IntField[FI.formations_position9] = this.m_Role.Id;
				r.FloatField[FI.formations_offset9x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset9y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_9] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_9] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_9] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_9] = (int)this.m_DefIntensity;
				return;
			case 10:
				r.IntField[FI.formations_position10] = this.m_Role.Id;
				r.FloatField[FI.formations_offset10x] = (float)this.m_OffsetX / 100f;
				r.FloatField[FI.formations_offset10y] = (float)this.m_OffsetY / 100f;
				r.IntField[FI.formations_attackingdirection_10] = (int)this.m_OffDirection;
				r.IntField[FI.formations_defensivedirection_10] = (int)this.m_DefDirection;
				r.IntField[FI.formations_attackingrole_10] = (int)this.m_OffIntensity;
				r.IntField[FI.formations_defensiverole_10] = (int)this.m_DefIntensity;
				return;
			default:
				return;
			}
		}

		// Token: 0x0400104E RID: 4174
		private int m_RoleId;

		// Token: 0x0400104F RID: 4175
		private Role m_Role;

		// Token: 0x04001050 RID: 4176
		public int m_OffsetX;

		// Token: 0x04001051 RID: 4177
		public int m_OffsetY;

		// Token: 0x04001052 RID: 4178
		private EPlayingDirection m_OffDirection;

		// Token: 0x04001053 RID: 4179
		private EPlayingIntensity m_OffIntensity;

		// Token: 0x04001054 RID: 4180
		private EPlayingDirection m_DefDirection;

		// Token: 0x04001055 RID: 4181
		private EPlayingIntensity m_DefIntensity;
	}
}
