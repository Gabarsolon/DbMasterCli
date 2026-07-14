using System;

namespace FifaLibrary
{
	// Token: 0x02000084 RID: 132
	public class MowingPatternList : IdArrayList
	{
		// Token: 0x06000A7B RID: 2683 RVA: 0x00047670 File Offset: 0x00045870
		public MowingPatternList()
			: base(typeof(MowingPattern))
		{
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x00047682 File Offset: 0x00045882
		public MowingPatternList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(MowingPattern))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0004769C File Offset: 0x0004589C
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.stadiums].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.stadiums_stadiummowpattern_code];
			base.MaxId = tableDescriptor.MaxValues[FI.stadiums_stadiummowpattern_code];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = MowingPattern.MowingPatternFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					MowingPattern mowingPattern = new MowingPattern(i);
					this.Add(mowingPattern);
				}
			}
		}
	}
}
