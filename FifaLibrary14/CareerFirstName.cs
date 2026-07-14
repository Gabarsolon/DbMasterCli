using System;

namespace FifaLibrary
{
	// Token: 0x0200002C RID: 44
	public class CareerFirstName : IdObject
	{
		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000468 RID: 1128 RVA: 0x0001B8B7 File Offset: 0x00019AB7
		// (set) Token: 0x06000469 RID: 1129 RVA: 0x0001B8BF File Offset: 0x00019ABF
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

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x0600046A RID: 1130 RVA: 0x0001B8C8 File Offset: 0x00019AC8
		// (set) Token: 0x0600046B RID: 1131 RVA: 0x0001B8D0 File Offset: 0x00019AD0
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

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x0600046C RID: 1132 RVA: 0x0001B8D9 File Offset: 0x00019AD9
		// (set) Token: 0x0600046D RID: 1133 RVA: 0x0001B8E1 File Offset: 0x00019AE1
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

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x0600046E RID: 1134 RVA: 0x0001B8EA File Offset: 0x00019AEA
		// (set) Token: 0x0600046F RID: 1135 RVA: 0x0001B8F1 File Offset: 0x00019AF1
		public static PlayerNames PlayerNames
		{
			get
			{
				return CareerFirstName.s_PlayerNames;
			}
			set
			{
				CareerFirstName.s_PlayerNames = value;
			}
		}

		// Token: 0x06000470 RID: 1136 RVA: 0x0001B8F9 File Offset: 0x00019AF9
		public CareerFirstName(Record r)
			: base(r.IntField[FI.career_firstnames_firstnameid])
		{
			this.Load(r);
		}

		// Token: 0x06000471 RID: 1137 RVA: 0x0001B914 File Offset: 0x00019B14
		public void Load(Record r)
		{
			this.m_firstname = r.IntField[FI.career_firstnames_firstname];
			this.m_groupid = r.IntField[FI.career_firstnames_groupid];
			if (CareerFirstName.s_PlayerNames == null || !CareerFirstName.s_PlayerNames.TryGetValue(this.m_firstname, out this.m_Text, true))
			{
				this.m_Text = string.Empty;
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001B970 File Offset: 0x00019B70
		public void Save(Record r)
		{
			string text = null;
			CareerFirstName.s_PlayerNames.TryGetValue(this.m_firstname, out text, true);
			if (text != this.m_Text)
			{
				this.m_firstname = CareerFirstName.s_PlayerNames.GetKey(this.m_Text);
			}
			r.IntField[FI.career_firstnames_firstnameid] = base.Id;
			r.IntField[FI.career_firstnames_firstname] = this.m_firstname;
			r.IntField[FI.career_firstnames_groupid] = this.m_groupid;
		}

		// Token: 0x0400020B RID: 523
		private string m_Text;

		// Token: 0x0400020C RID: 524
		private int m_firstname;

		// Token: 0x0400020D RID: 525
		private int m_groupid;

		// Token: 0x0400020E RID: 526
		private static PlayerNames s_PlayerNames;
	}
}
