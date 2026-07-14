using System;

namespace FifaLibrary
{
	// Token: 0x02000030 RID: 48
	public class CareerLastNameList : IdArrayList
	{
		// Token: 0x06000492 RID: 1170 RVA: 0x0001BE60 File Offset: 0x0001A060
		public CareerLastNameList(DbFile fifaDbFile)
			: base(typeof(CareerLastName))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000493 RID: 1171 RVA: 0x0001BE79 File Offset: 0x0001A079
		public CareerLastNameList(Table careerLastNamesTable, PlayerNames playerNames)
			: base(typeof(CareerLastName))
		{
			this.Load(careerLastNamesTable);
		}

		// Token: 0x06000494 RID: 1172 RVA: 0x0001BE94 File Offset: 0x0001A094
		public void Load(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_lastnames];
			this.Load(table);
		}

		// Token: 0x06000495 RID: 1173 RVA: 0x0001BEB8 File Offset: 0x0001A0B8
		public void Load(Table table)
		{
			base.MinId = table.TableDescriptor.MinValues[FI.career_lastnames_lastnameid];
			base.MaxId = table.TableDescriptor.MaxValues[FI.career_lastnames_lastnameid];
			CareerLastName[] array = new CareerLastName[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new CareerLastName(table.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x06000496 RID: 1174 RVA: 0x0001BF34 File Offset: 0x0001A134
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_lastnames];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				CareerLastName careerLastName = (CareerLastName)obj;
				Record record = table.Records[num];
				num++;
				careerLastName.Save(record);
			}
		}
	}
}
