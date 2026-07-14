using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x02000058 RID: 88
	public class IdObjectComparer : IComparer
	{
		// Token: 0x060007D4 RID: 2004 RVA: 0x0002FB1C File Offset: 0x0002DD1C
		int IComparer.Compare(object x, object y)
		{
			return ((IdObject)x).Id - ((IdObject)y).Id;
		}
	}
}
