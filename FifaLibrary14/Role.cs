using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x020000A2 RID: 162
	public class Role : IdObject
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0004E209 File Offset: 0x0004C409
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x0004E211 File Offset: 0x0004C411
		public ERole RoleId
		{
			get
			{
				return (ERole)base.Id;
			}
			set
			{
				base.Id = (int)value;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06000BF5 RID: 3061 RVA: 0x0004E21A File Offset: 0x0004C41A
		// (set) Token: 0x06000BF6 RID: 3062 RVA: 0x0004E222 File Offset: 0x0004C422
		public int Xmin
		{
			get
			{
				return this.m_Xmin;
			}
			set
			{
				this.m_Xmin = value;
			}
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000BF7 RID: 3063 RVA: 0x0004E22B File Offset: 0x0004C42B
		// (set) Token: 0x06000BF8 RID: 3064 RVA: 0x0004E233 File Offset: 0x0004C433
		public int Xmax
		{
			get
			{
				return this.m_Xmax;
			}
			set
			{
				this.m_Xmax = value;
			}
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x06000BF9 RID: 3065 RVA: 0x0004E23C File Offset: 0x0004C43C
		// (set) Token: 0x06000BFA RID: 3066 RVA: 0x0004E244 File Offset: 0x0004C444
		public int Ymin
		{
			get
			{
				return this.m_Ymin;
			}
			set
			{
				this.m_Ymin = value;
			}
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000BFB RID: 3067 RVA: 0x0004E24D File Offset: 0x0004C44D
		// (set) Token: 0x06000BFC RID: 3068 RVA: 0x0004E255 File Offset: 0x0004C455
		public int Ymax
		{
			get
			{
				return this.m_Ymax;
			}
			set
			{
				this.m_Ymax = value;
			}
		}

		// Token: 0x06000BFD RID: 3069 RVA: 0x0004E25E File Offset: 0x0004C45E
		public Role(ERole eRole)
			: base((int)eRole)
		{
		}

		// Token: 0x06000BFE RID: 3070 RVA: 0x0004E267 File Offset: 0x0004C467
		public Role(int roleId)
			: base(roleId)
		{
		}

		// Token: 0x06000BFF RID: 3071 RVA: 0x0004E270 File Offset: 0x0004C470
		public override string ToString()
		{
			string text = string.Empty;
			if (FifaEnvironment.Language != null)
			{
				text = FifaEnvironment.Language.GetRoleShortString(base.Id) + " - ";
			}
			switch (this.RoleId)
			{
			case ERole.Goalkeeper:
				return text + "Goalkeeper";
			case ERole.Sweeper:
				return text + "Sweeper";
			case ERole.Right_Wing_Back:
				return text + "Right Wing Back";
			case ERole.Right_Back:
				return text + "Right Back";
			case ERole.Right_Central_Back:
				return text + "Right Central Back";
			case ERole.Central_Back:
				return text + "Central Back";
			case ERole.Left_Central_Back:
				return text + "Left Central Back";
			case ERole.Left_Back:
				return text + "Left Back";
			case ERole.Left_Wing_Back:
				return text + "Left Wing Back";
			case ERole.Right_Defensive_Midfielder:
				return text + "Right Defensive Midfielder";
			case ERole.Central_Defensive_Midfielder:
				return text + "Central Defensive Midfielder";
			case ERole.Left_Defensive_Midfielder:
				return text + "Left Defensive Midfielder";
			case ERole.Right_Midfielder:
				return text + "Right Midfielder";
			case ERole.Right_Central_Midfielder:
				return text + "Right Central Midfielder";
			case ERole.Central_Midfielder:
				return text + "Central Midfielder";
			case ERole.Left_Central_Midfielder:
				return text + "Left Central Midfielder";
			case ERole.Left_Midfielder:
				return text + "Left Midfielder";
			case ERole.Right_Advanced_Midfielder:
				return text + "Right Advanced Midfielder";
			case ERole.Central_Advanced_Midfielder:
				return text + "Central Advanced Midfielder";
			case ERole.Left_Advanced_Midfielder:
				return text + "Left Advanced Midfielder";
			case ERole.Right_Forward:
				return text + "Right Forward";
			case ERole.Central_Forward:
				return text + "Central Forward";
			case ERole.Left_Forward:
				return text + "Left Forward";
			case ERole.Right_Wing:
				return text + "Right Wing";
			case ERole.Right_Striker:
				return text + "Right Striker";
			case ERole.Central_Striker:
				return text + "Central Striker";
			case ERole.Left_Striker:
				return text + "Left Striker";
			case ERole.Left_Wing:
				return text + "Left Wing";
			case ERole.Substitute:
				return text + "Substitute";
			case ERole.Tribune:
				return text + "Tribune";
			default:
				return string.Empty;
			}
		}

		// Token: 0x06000C00 RID: 3072 RVA: 0x0004E49C File Offset: 0x0004C69C
		public string ToShortString()
		{
			if (FifaEnvironment.Language != null)
			{
				return FifaEnvironment.Language.GetRoleShortString(base.Id);
			}
			return string.Empty;
		}

		// Token: 0x06000C01 RID: 3073 RVA: 0x0004E4BB File Offset: 0x0004C6BB
		public string ToLongString()
		{
			if (FifaEnvironment.Language != null)
			{
				return FifaEnvironment.Language.GetRoleLongString(base.Id);
			}
			return string.Empty;
		}

		// Token: 0x06000C02 RID: 3074 RVA: 0x0004E4DA File Offset: 0x0004C6DA
		public void SetShortString(string shortName)
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetRoleShortString(base.Id, shortName);
			}
		}

		// Token: 0x06000C03 RID: 3075 RVA: 0x0004E4F4 File Offset: 0x0004C6F4
		public Role(Record r)
			: base(r.IntField[FI.fieldpositionboundingboxes_positionid])
		{
			this.Load(r);
		}

		// Token: 0x06000C04 RID: 3076 RVA: 0x0004E510 File Offset: 0x0004C710
		public void Load(Record r)
		{
			float num = r.FloatField[FI.fieldpositionboundingboxes_pointx0];
			float num2 = r.FloatField[FI.fieldpositionboundingboxes_pointx1];
			float num3 = r.FloatField[FI.fieldpositionboundingboxes_pointx2];
			float num4 = r.FloatField[FI.fieldpositionboundingboxes_pointx3];
			float num5 = r.FloatField[FI.fieldpositionboundingboxes_pointy0];
			float num6 = r.FloatField[FI.fieldpositionboundingboxes_pointy1];
			float num7 = r.FloatField[FI.fieldpositionboundingboxes_pointy2];
			float num8 = r.FloatField[FI.fieldpositionboundingboxes_pointy3];
			this.m_Xmin = Convert.ToInt32(Math.Min(Math.Min(num, num2), Math.Min(num3, num4)) * 100f);
			this.m_Xmax = Convert.ToInt32(Math.Max(Math.Max(num, num2), Math.Max(num3, num4)) * 100f);
			this.m_Ymin = Convert.ToInt32(Math.Min(Math.Min(num5, num6), Math.Min(num7, num8)) * 100f);
			this.m_Ymax = Convert.ToInt32(Math.Max(Math.Max(num5, num6), Math.Max(num7, num8)) * 100f);
		}

		// Token: 0x06000C05 RID: 3077 RVA: 0x0004E624 File Offset: 0x0004C824
		public void Save(Record r)
		{
			r.IntField[FI.fieldpositionboundingboxes_positionid] = base.Id;
			r.FloatField[FI.fieldpositionboundingboxes_pointx0] = (float)this.m_Xmin / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointy0] = (float)this.m_Ymin / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointx1] = (float)this.m_Xmin / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointy1] = (float)this.m_Ymax / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointx2] = (float)this.m_Xmax / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointy2] = (float)this.m_Ymax / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointx3] = (float)this.m_Xmax / 100f;
			r.FloatField[FI.fieldpositionboundingboxes_pointy3] = (float)this.m_Ymin / 100f;
		}

		// Token: 0x06000C06 RID: 3078 RVA: 0x0004E70C File Offset: 0x0004C90C
		public Point GetCenter()
		{
			Point point = new Point((this.m_Xmax + this.m_Xmin) / 2, (this.m_Ymax + this.m_Ymin) / 2);
			return point;
		}

		// Token: 0x0400104A RID: 4170
		private int m_Xmin;

		// Token: 0x0400104B RID: 4171
		private int m_Xmax;

		// Token: 0x0400104C RID: 4172
		private int m_Ymin;

		// Token: 0x0400104D RID: 4173
		private int m_Ymax;
	}
}
