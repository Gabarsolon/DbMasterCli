using System;

namespace FifaLibrary
{
	// Token: 0x02000045 RID: 69
	public class NationList : IdArrayList
	{
		// Token: 0x060006A6 RID: 1702 RVA: 0x000273C7 File Offset: 0x000255C7
		public NationList()
			: base(typeof(Nation))
		{
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x000273DC File Offset: 0x000255DC
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				Nation nation = (Nation)obj;
				nation.LinkCountry(countryList);
			}
		}
	}
}
