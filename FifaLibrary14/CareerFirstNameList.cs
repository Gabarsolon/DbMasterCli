using System;

namespace FifaLibrary
{
	// Token: 0x0200002F RID: 47
	public class CareerFirstNameList : IdArrayList
	{
		// Token: 0x0600048D RID: 1165 RVA: 0x0001BD07 File Offset: 0x00019F07
		public CareerFirstNameList(DbFile fifaDbFile)
			: base(typeof(CareerFirstName))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x0600048E RID: 1166 RVA: 0x0001BD20 File Offset: 0x00019F20
		public CareerFirstNameList(Table careerFirstNamesTable)
			: base(typeof(CareerFirstName))
		{
			this.Load(careerFirstNamesTable);
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x0001BD3C File Offset: 0x00019F3C
		public void Load(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_firstnames];
			this.Load(table);
		}

		// Token: 0x06000490 RID: 1168 RVA: 0x0001BD60 File Offset: 0x00019F60
		public void Load(Table table)
		{
			base.MinId = table.TableDescriptor.MinValues[FI.career_firstnames_firstnameid];
			base.MaxId = table.TableDescriptor.MaxValues[FI.career_firstnames_firstnameid];
			CareerFirstName[] array = new CareerFirstName[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new CareerFirstName(table.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x06000491 RID: 1169 RVA: 0x0001BDDC File Offset: 0x00019FDC
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_firstnames];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				CareerFirstName careerFirstName = (CareerFirstName)obj;
				Record record = table.Records[num];
				num++;
				careerFirstName.Save(record);
			}
		}
	}
}
