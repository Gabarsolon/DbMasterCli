using System;

namespace FifaLibrary
{
	// Token: 0x02000077 RID: 119
	public class GkGlovesList : IdArrayList
	{
		// Token: 0x060009DB RID: 2523 RVA: 0x00045B14 File Offset: 0x00043D14
		public GkGlovesList()
			: base(typeof(GkGloves))
		{
		}

		// Token: 0x060009DC RID: 2524 RVA: 0x00045B26 File Offset: 0x00043D26
		public GkGlovesList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(GkGloves))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x060009DD RID: 2525 RVA: 0x00045B40 File Offset: 0x00043D40
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.players].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.players_gkglovetypecode];
			base.MaxId = tableDescriptor.MaxValues[FI.players_gkglovetypecode];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = GkGloves.GkGlovesTextureFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					GkGloves gkGloves = new GkGloves(i);
					base.InsertId(gkGloves);
				}
			}
		}
	}
}
