using System;

namespace FifaLibrary
{
	// Token: 0x0200007E RID: 126
	public class NameFontList : IdArrayList
	{
		// Token: 0x06000A33 RID: 2611 RVA: 0x00046955 File Offset: 0x00044B55
		public NameFontList()
			: base(typeof(NameFont))
		{
		}

		// Token: 0x06000A34 RID: 2612 RVA: 0x00046967 File Offset: 0x00044B67
		public NameFontList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(NameFont))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000A35 RID: 2613 RVA: 0x00046984 File Offset: 0x00044B84
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.teamkits].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.teamkits_jerseynamefonttype];
			base.MaxId = tableDescriptor.MaxValues[FI.teamkits_jerseynamefonttype];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = NameFont.NameFontFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					NameFont nameFont = new NameFont(i);
					this.Add(nameFont);
				}
			}
		}
	}
}
