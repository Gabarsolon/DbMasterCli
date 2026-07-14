using System;

namespace FifaLibrary
{
	// Token: 0x0200007C RID: 124
	public class NumberFontList : IdArrayList
	{
		// Token: 0x06000A1F RID: 2591 RVA: 0x00046422 File Offset: 0x00044622
		public NumberFontList()
			: base(typeof(NumberFont))
		{
		}

		// Token: 0x06000A20 RID: 2592 RVA: 0x00046434 File Offset: 0x00044634
		public NumberFontList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(NumberFont))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000A21 RID: 2593 RVA: 0x00046450 File Offset: 0x00044650
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.teamkits].TableDescriptor;
			int num = 1;
			int num2 = tableDescriptor.MaxValues[FI.teamkits_numberfonttype];
			int num3 = 0;
			int num4 = 19;
			base.MinId = num * (num4 + 1) + num3;
			base.MaxId = num2 * (num4 + 1) + num4;
			this.Clear();
			for (int i = num; i <= num2; i++)
			{
				for (int j = num3; j <= num4; j++)
				{
					string text = NumberFont.NumberFontFileName(i, j);
					if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
					{
						int num5 = i * (num4 + 1) + j;
						NumberFont numberFont = new NumberFont(num5);
						this.Add(numberFont);
					}
				}
			}
		}

		// Token: 0x06000A22 RID: 2594 RVA: 0x00046508 File Offset: 0x00044708
		public new NumberFont CreateNewId(int color)
		{
			int num = -1;
			for (int i = 20 + color % 20; i <= base.MaxId; i += 20)
			{
				if (base.SearchId(i) == null)
				{
					num = i;
					break;
				}
			}
			if (num < 0)
			{
				return null;
			}
			NumberFont numberFont = new NumberFont(num);
			base.InsertId(numberFont);
			return numberFont;
		}
	}
}
