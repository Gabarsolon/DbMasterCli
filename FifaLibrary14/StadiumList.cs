using System;

namespace FifaLibrary
{
	// Token: 0x02000022 RID: 34
	public class StadiumList : IdArrayList
	{
		// Token: 0x06000263 RID: 611 RVA: 0x00011605 File Offset: 0x0000F805
		public StadiumList()
			: base(typeof(Stadium))
		{
		}

		// Token: 0x06000264 RID: 612 RVA: 0x00011617 File Offset: 0x0000F817
		public StadiumList(DbFile fifaDbFile)
			: base(typeof(Stadium))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000265 RID: 613 RVA: 0x00011630 File Offset: 0x0000F830
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.teamstadiumlinks];
			int num = table.TableDescriptor.MinValues[FI.teamstadiumlinks_stadiumid];
			int num2 = table.TableDescriptor.MaxValues[FI.teamstadiumlinks_stadiumid];
			table = FifaEnvironment.FifaDb.Table[TI.stadiums];
			this.Load(table, num, num2);
		}

		// Token: 0x06000266 RID: 614 RVA: 0x0001168C File Offset: 0x0000F88C
		public void Load(Table t, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < t.NRecords; i++)
			{
				Stadium stadium = new Stadium(t.Records[i]);
				this.Add(stadium);
			}
			base.SortId();
		}

		// Token: 0x06000267 RID: 615 RVA: 0x000116DC File Offset: 0x0000F8DC
		public void LinkTeam(TeamList teamList)
		{
			foreach (object obj in this)
			{
				Stadium stadium = (Stadium)obj;
				stadium.LinkTeam(teamList);
			}
		}

		// Token: 0x06000268 RID: 616 RVA: 0x00011730 File Offset: 0x0000F930
		public void LinkCountry(CountryList countryList)
		{
			foreach (object obj in this)
			{
				Stadium stadium = (Stadium)obj;
				stadium.LinkCountry(countryList);
			}
		}

		// Token: 0x06000269 RID: 617 RVA: 0x00011784 File Offset: 0x0000F984
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.stadiums];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				Stadium stadium = (Stadium)obj;
				Record record = table.Records[num];
				num++;
				stadium.SaveStadium(record);
				stadium.SaveLangTable();
			}
		}

		// Token: 0x0600026A RID: 618 RVA: 0x00011810 File Offset: 0x0000FA10
		public void DeleteStadium(Stadium stadium)
		{
			base.RemoveId(stadium);
		}

		// Token: 0x0600026B RID: 619 RVA: 0x0001181C File Offset: 0x0000FA1C
		public Stadium FitStadium(string name, int id)
		{
			foreach (object obj in this)
			{
				Stadium stadium = (Stadium)obj;
				if (stadium.name == name || stadium.LocalName == name)
				{
					return stadium;
				}
			}
			return null;
		}

		// Token: 0x0600026C RID: 620 RVA: 0x0001188C File Offset: 0x0000FA8C
		public override IdArrayList Filter(IdObject filter)
		{
			StadiumList stadiumList = new StadiumList();
			if (filter == null)
			{
				return this;
			}
			if (filter.GetType().Name == "Country")
			{
				Country country = (Country)filter;
				for (int i = 0; i < this.Count; i++)
				{
					Stadium stadium = (Stadium)this[i];
					if (stadium.Country == country)
					{
						stadiumList.Add(stadium);
					}
				}
				return stadiumList;
			}
			return this;
		}
	}
}
