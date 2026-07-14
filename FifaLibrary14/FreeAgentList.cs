using System;

namespace FifaLibrary
{
	// Token: 0x020000AC RID: 172
	public class FreeAgentList : IdArrayList
	{
		// Token: 0x06000DD1 RID: 3537 RVA: 0x000545FB File Offset: 0x000527FB
		public FreeAgentList()
			: base(typeof(FreeAgent))
		{
			this.Clear();
			this.Add(new FreeAgent());
		}
	}
}
