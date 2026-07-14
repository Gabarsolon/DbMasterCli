using System;

namespace FifaLibrary
{
	// Token: 0x020000A7 RID: 167
	public class CareerFormation : Formation
	{
		// Token: 0x17000297 RID: 663
		// (get) Token: 0x06000C61 RID: 3169 RVA: 0x000507AB File Offset: 0x0004E9AB
		// (set) Token: 0x06000C60 RID: 3168 RVA: 0x000507A2 File Offset: 0x0004E9A2
		public bool IsInCareer
		{
			get
			{
				return this.m_IsInCareer;
			}
			set
			{
				this.m_IsInCareer = value;
			}
		}

		// Token: 0x06000C62 RID: 3170 RVA: 0x000507B3 File Offset: 0x0004E9B3
		public CareerFormation(Record r)
			: base(r)
		{
		}

		// Token: 0x06000C63 RID: 3171 RVA: 0x000507BC File Offset: 0x0004E9BC
		public CareerFormation(int formationid)
			: base(formationid)
		{
		}

		// Token: 0x04001062 RID: 4194
		private bool m_IsInCareer;
	}
}
