using System;

namespace FifaLibrary
{
	// Token: 0x02000031 RID: 49
	public class CareerCommonNameList : IdArrayList
	{
		// Token: 0x06000497 RID: 1175 RVA: 0x0001BFB8 File Offset: 0x0001A1B8
		public CareerCommonNameList(DbFile fifaDbFile)
			: base(typeof(CareerCommonName))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000498 RID: 1176 RVA: 0x0001BFD1 File Offset: 0x0001A1D1
		public CareerCommonNameList(Table careerCommonNamesTable)
			: base(typeof(CareerCommonName))
		{
			this.Load(careerCommonNamesTable);
		}

		// Token: 0x06000499 RID: 1177 RVA: 0x0001BFEC File Offset: 0x0001A1EC
		public void Load(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_commonnames];
			this.Load(table);
		}

		// Token: 0x0600049A RID: 1178 RVA: 0x0001C010 File Offset: 0x0001A210
		public void Load(Table table)
		{
			base.MinId = table.TableDescriptor.MinValues[FI.career_commonnames_commonnameid];
			base.MaxId = table.TableDescriptor.MaxValues[FI.career_commonnames_commonnameid];
			CareerCommonName[] array = new CareerCommonName[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new CareerCommonName(table.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x0600049B RID: 1179 RVA: 0x0001C08C File Offset: 0x0001A28C
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.career_commonnames];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				CareerCommonName careerCommonName = (CareerCommonName)obj;
				Record record = table.Records[num];
				num++;
				careerCommonName.Save(record);
			}
		}
	}
}
