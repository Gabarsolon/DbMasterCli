using System;

namespace FifaLibrary
{
	// Token: 0x02000088 RID: 136
	public class GlovesList : IdArrayList
	{
		// Token: 0x06000A8C RID: 2700 RVA: 0x00047869 File Offset: 0x00045A69
		public GlovesList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(MowingPattern))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00047884 File Offset: 0x00045A84
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.players].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.players_gkglovetypecode];
			base.MaxId = tableDescriptor.MaxValues[FI.players_gkglovetypecode];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = Gloves.GlovesFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					Gloves gloves = new Gloves(i);
					this.Add(gloves);
				}
			}
		}
	}
}
