using System;

namespace FifaLibrary
{
	// Token: 0x0200006B RID: 107
	public class CountryList : IdArrayList
	{
		// Token: 0x0600092F RID: 2351 RVA: 0x00043696 File Offset: 0x00041896
		public CountryList()
			: base(typeof(Country))
		{
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000436A8 File Offset: 0x000418A8
		public CountryList(DbFile fifaDbFile)
			: base(typeof(Country))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000436C4 File Offset: 0x000418C4
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.nations];
			int num = table.TableDescriptor.MinValues[FI.nations_nationid];
			int num2 = table.TableDescriptor.MaxValues[FI.nations_nationid];
			Table table2 = FifaEnvironment.FifaDb.Table[TI.nations];
			this.Load(table2, num, num2);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x00043720 File Offset: 0x00041920
		public void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			Country[] array = new Country[t.NRecords];
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				array[i] = new Country(t.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x0004377B File Offset: 0x0004197B
		public void DeleteCountry(Country country)
		{
			base.RemoveId(country);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00043785 File Offset: 0x00041985
		public Country SearchCountry(int countryid)
		{
			return (Country)base.SearchId(countryid);
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00043794 File Offset: 0x00041994
		public Country SearchNationalTeamId(int nationalTeamId)
		{
			if (nationalTeamId == 3145)
			{
				return (Country)base.SearchId(34);
			}
			if (nationalTeamId == 1800)
			{
				return null;
			}
			for (int i = 0; i < this.Count; i++)
			{
				Country country = (Country)this[i];
				if (nationalTeamId == country.NationalTeamId)
				{
					return country;
				}
			}
			return null;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x000437F0 File Offset: 0x000419F0
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.nations];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				Country country = (Country)obj;
				Record record = table.Records[num];
				country.SaveCountry(record);
				country.SaveLangTable();
				num++;
			}
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x0004387C File Offset: 0x00041A7C
		public void FillFromAudionation(Table t)
		{
			for (int i = 0; i < t.NRecords; i++)
			{
				Record record = t.Records[i];
				int num = record.IntField[FI.audionation_nationid];
				Country country = (Country)base.SearchId(num);
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x000438C0 File Offset: 0x00041AC0
		public Country FitCountry(string name, int id)
		{
			string text = name.ToLower();
			foreach (object obj in this)
			{
				Country country = (Country)obj;
				if (country.Fit(text, id))
				{
					return country;
				}
			}
			return null;
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00043928 File Offset: 0x00041B28
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				Country country = (Country)obj;
				country.LinkTeam(teamList);
			}
		}
	}
}
