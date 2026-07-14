using System;

namespace FifaLibrary
{
	// Token: 0x0200002D RID: 45
	public class CareerLastName : IdObject
	{
		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0001B9ED File Offset: 0x00019BED
		// (set) Token: 0x06000474 RID: 1140 RVA: 0x0001B9F5 File Offset: 0x00019BF5
		public string Text
		{
			get
			{
				return this.m_Text;
			}
			set
			{
				this.m_Text = value;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000475 RID: 1141 RVA: 0x0001B9FE File Offset: 0x00019BFE
		// (set) Token: 0x06000476 RID: 1142 RVA: 0x0001BA06 File Offset: 0x00019C06
		public int lastname
		{
			get
			{
				return this.m_lastname;
			}
			set
			{
				this.m_lastname = value;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000477 RID: 1143 RVA: 0x0001BA0F File Offset: 0x00019C0F
		// (set) Token: 0x06000478 RID: 1144 RVA: 0x0001BA17 File Offset: 0x00019C17
		public int groupid
		{
			get
			{
				return this.m_groupid;
			}
			set
			{
				this.m_groupid = value;
			}
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000479 RID: 1145 RVA: 0x0001BA20 File Offset: 0x00019C20
		// (set) Token: 0x0600047A RID: 1146 RVA: 0x0001BA27 File Offset: 0x00019C27
		public static PlayerNames PlayerNames
		{
			get
			{
				return CareerLastName.s_PlayerNames;
			}
			set
			{
				CareerLastName.s_PlayerNames = value;
			}
		}

		// Token: 0x0600047B RID: 1147 RVA: 0x0001BA2F File Offset: 0x00019C2F
		public CareerLastName(Record r)
			: base(r.IntField[FI.career_lastnames_lastnameid])
		{
			this.Load(r);
		}

		// Token: 0x0600047C RID: 1148 RVA: 0x0001BA4C File Offset: 0x00019C4C
		public void Load(Record r)
		{
			this.m_lastname = r.IntField[FI.career_lastnames_lastname];
			this.m_groupid = r.IntField[FI.career_firstnames_groupid];
			if (CareerLastName.s_PlayerNames == null || !CareerLastName.s_PlayerNames.TryGetValue(this.m_lastname, out this.m_Text, true))
			{
				this.m_Text = string.Empty;
			}
		}

		// Token: 0x0600047D RID: 1149 RVA: 0x0001BAA8 File Offset: 0x00019CA8
		public void Save(Record r)
		{
			string text = null;
			CareerLastName.s_PlayerNames.TryGetValue(this.m_lastname, out text, true);
			if (text != this.m_Text)
			{
				this.m_lastname = CareerLastName.s_PlayerNames.GetKey(this.m_Text);
			}
			r.IntField[FI.career_lastnames_lastnameid] = base.Id;
			r.IntField[FI.career_lastnames_lastname] = this.m_lastname;
			r.IntField[FI.career_lastnames_groupid] = this.m_groupid;
		}

		// Token: 0x0400020F RID: 527
		private string m_Text;

		// Token: 0x04000210 RID: 528
		private int m_lastname;

		// Token: 0x04000211 RID: 529
		private int m_groupid;

		// Token: 0x04000212 RID: 530
		private static PlayerNames s_PlayerNames;
	}
}
