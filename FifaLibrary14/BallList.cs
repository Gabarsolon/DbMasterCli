using System;

namespace FifaLibrary
{
	// Token: 0x02000078 RID: 120
	public class BallList : IdArrayList
	{
		// Token: 0x060009DE RID: 2526 RVA: 0x00045BC7 File Offset: 0x00043DC7
		public BallList()
			: base(typeof(Ball))
		{
		}

		// Token: 0x060009DF RID: 2527 RVA: 0x00045BD9 File Offset: 0x00043DD9
		public BallList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(Ball))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x060009E0 RID: 2528 RVA: 0x00045BF4 File Offset: 0x00043DF4
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			Table table = fifaDb.Table[TI.teamballs];
			TableDescriptor tableDescriptor = table.TableDescriptor;
			int num = tableDescriptor.MinValues[FI.teamballs_ballid];
			int num2 = tableDescriptor.MaxValues[FI.teamballs_ballid];
			this.Load(table, num, num2);
		}

		// Token: 0x060009E1 RID: 2529 RVA: 0x00045C38 File Offset: 0x00043E38
		public void Load(Table table, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			Ball[] array = new Ball[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new Ball(table.Records[i]);
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x060009E2 RID: 2530 RVA: 0x00045C94 File Offset: 0x00043E94
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.teamballs];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				Ball ball = (Ball)obj;
				Record record = table.Records[num];
				num++;
				ball.SaveBall(record);
			}
		}
	}
}
