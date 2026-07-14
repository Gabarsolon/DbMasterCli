using System;

namespace FifaLibrary
{
	// Token: 0x02000082 RID: 130
	public class ShoesList : IdArrayList
	{
		// Token: 0x06000A49 RID: 2633 RVA: 0x00046C92 File Offset: 0x00044E92
		public ShoesList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(Shoes))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000A4A RID: 2634 RVA: 0x00046CAC File Offset: 0x00044EAC
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			Table table = fifaDb.Table[TI.playerboots];
			TableDescriptor tableDescriptor = table.TableDescriptor;
			int num = tableDescriptor.MinValues[FI.playerboots_shoetype];
			int num2 = tableDescriptor.MaxValues[FI.playerboots_shoetype];
			this.Load(table, num, num2);
		}

		// Token: 0x06000A4B RID: 2635 RVA: 0x00046CF0 File Offset: 0x00044EF0
		public void Load(Table table, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.m_HasGenericShoes = false;
			Shoes[] array = new Shoes[table.NRecords];
			this.Clear();
			int num = 0;
			for (int i = 0; i < table.NRecords; i++)
			{
				Shoes shoes = new Shoes(table.Records[i]);
				if (shoes.Id != 0 || !this.m_HasGenericShoes)
				{
					array[num++] = shoes;
					if (shoes.Id == 0)
					{
						this.m_HasGenericShoes = true;
					}
				}
			}
			Shoes[] array2 = new Shoes[num];
			for (int j = 0; j < num; j++)
			{
				array2[j] = array[j];
			}
			this.AddRange(array2);
			base.SortId();
		}

		// Token: 0x06000A4C RID: 2636 RVA: 0x00046D9C File Offset: 0x00044F9C
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.playerboots];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				Shoes shoes = (Shoes)obj;
				Record record = table.Records[num];
				num++;
				shoes.SaveShoes(record);
			}
		}

		// Token: 0x04000F5D RID: 3933
		private bool m_HasGenericShoes;
	}
}
