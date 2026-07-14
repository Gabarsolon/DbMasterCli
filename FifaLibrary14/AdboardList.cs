using System;

namespace FifaLibrary
{
	// Token: 0x0200007A RID: 122
	public class AdboardList : IdArrayList
	{
		// Token: 0x06000A11 RID: 2577 RVA: 0x0004625A File Offset: 0x0004445A
		public AdboardList()
			: base(typeof(Adboard))
		{
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0004626C File Offset: 0x0004446C
		public AdboardList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(Adboard))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000A13 RID: 2579 RVA: 0x00046288 File Offset: 0x00044488
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.teams].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.teams_adboardid];
			base.MaxId = tableDescriptor.MaxValues[FI.teams_adboardid];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = Adboard.AdboardFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					Adboard adboard = new Adboard(i);
					this.Add(adboard);
				}
			}
		}
	}
}
