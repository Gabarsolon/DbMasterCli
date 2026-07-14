using System;

namespace FifaLibrary
{
	// Token: 0x02000059 RID: 89
	public class IdString : IdObject
	{
		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0002FB3D File Offset: 0x0002DD3D
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x0002FB45 File Offset: 0x0002DD45
		public string String
		{
			get
			{
				return this.String;
			}
			set
			{
				this.String = value;
			}
		}

		// Token: 0x060007D8 RID: 2008 RVA: 0x0002FB4E File Offset: 0x0002DD4E
		public IdString(int id)
			: base(id)
		{
		}

		// Token: 0x060007D9 RID: 2009 RVA: 0x0002FB57 File Offset: 0x0002DD57
		public IdString(int id, string value)
			: base(id)
		{
			this.m_String = value;
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0002FB67 File Offset: 0x0002DD67
		public override string ToString()
		{
			return this.m_String;
		}

		// Token: 0x0400033A RID: 826
		private string m_String;
	}
}
