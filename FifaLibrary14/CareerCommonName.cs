using System;

namespace FifaLibrary
{
	// Token: 0x0200002E RID: 46
	public class CareerCommonName : IdObject
	{
		// Token: 0x17000120 RID: 288
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0001BB25 File Offset: 0x00019D25
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x0001BB2D File Offset: 0x00019D2D
		public string Text1
		{
			get
			{
				return this.m_Text1;
			}
			set
			{
				this.m_Text1 = value;
			}
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x06000480 RID: 1152 RVA: 0x0001BB36 File Offset: 0x00019D36
		// (set) Token: 0x06000481 RID: 1153 RVA: 0x0001BB3E File Offset: 0x00019D3E
		public string Text2
		{
			get
			{
				return this.m_Text2;
			}
			set
			{
				this.m_Text2 = value;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x0001BB47 File Offset: 0x00019D47
		// (set) Token: 0x06000483 RID: 1155 RVA: 0x0001BB4F File Offset: 0x00019D4F
		public int firstname
		{
			get
			{
				return this.m_firstname;
			}
			set
			{
				this.m_firstname = value;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x06000484 RID: 1156 RVA: 0x0001BB58 File Offset: 0x00019D58
		// (set) Token: 0x06000485 RID: 1157 RVA: 0x0001BB60 File Offset: 0x00019D60
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

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x06000486 RID: 1158 RVA: 0x0001BB69 File Offset: 0x00019D69
		// (set) Token: 0x06000487 RID: 1159 RVA: 0x0001BB71 File Offset: 0x00019D71
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

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x06000488 RID: 1160 RVA: 0x0001BB7A File Offset: 0x00019D7A
		// (set) Token: 0x06000489 RID: 1161 RVA: 0x0001BB81 File Offset: 0x00019D81
		public static PlayerNames PlayerNames
		{
			get
			{
				return CareerCommonName.s_PlayerNames;
			}
			set
			{
				CareerCommonName.s_PlayerNames = value;
			}
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001BB89 File Offset: 0x00019D89
		public CareerCommonName(Record r)
			: base(r.IntField[FI.career_commonnames_commonnameid])
		{
			this.Load(r);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		public void Load(Record r)
		{
			this.m_firstname = r.IntField[FI.career_commonnames_firstname];
			this.m_lastname = r.IntField[FI.career_commonnames_lastname];
			this.m_groupid = r.IntField[FI.career_commonnames_groupid];
			if (CareerCommonName.s_PlayerNames == null || !CareerCommonName.s_PlayerNames.TryGetValue(this.m_firstname, out this.m_Text1, true))
			{
				this.m_Text1 = string.Empty;
			}
			if (CareerCommonName.s_PlayerNames == null || !CareerCommonName.s_PlayerNames.TryGetValue(this.m_lastname, out this.m_Text2, true))
			{
				this.m_Text2 = string.Empty;
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x0001BC40 File Offset: 0x00019E40
		public void Save(Record r)
		{
			string text = null;
			CareerCommonName.s_PlayerNames.TryGetValue(this.m_firstname, out text, true);
			if (text != this.m_Text1)
			{
				this.m_firstname = CareerCommonName.s_PlayerNames.GetKey(this.m_Text1);
			}
			CareerCommonName.s_PlayerNames.TryGetValue(this.m_lastname, out text, true);
			if (text != this.m_Text2)
			{
				this.m_lastname = CareerCommonName.s_PlayerNames.GetKey(this.m_Text2);
			}
			r.IntField[FI.career_commonnames_commonnameid] = base.Id;
			r.IntField[FI.career_commonnames_firstname] = this.m_firstname;
			r.IntField[FI.career_commonnames_lastname] = this.m_lastname;
			r.IntField[FI.career_commonnames_groupid] = this.m_groupid;
		}

		// Token: 0x04000213 RID: 531
		private string m_Text1;

		// Token: 0x04000214 RID: 532
		private string m_Text2;

		// Token: 0x04000215 RID: 533
		private int m_firstname;

		// Token: 0x04000216 RID: 534
		private int m_lastname;

		// Token: 0x04000217 RID: 535
		private int m_groupid;

		// Token: 0x04000218 RID: 536
		private static PlayerNames s_PlayerNames;
	}
}
