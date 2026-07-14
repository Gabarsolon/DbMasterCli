using System;

namespace FifaLibrary
{
	// Token: 0x020000AE RID: 174
	public class MultiClubList : IdArrayList
	{
		// Token: 0x06000DD4 RID: 3540 RVA: 0x0005462E File Offset: 0x0005282E
		public MultiClubList()
			: base(typeof(MultiClub))
		{
			this.Clear();
			this.Add(new MultiClub());
		}
	}
}
