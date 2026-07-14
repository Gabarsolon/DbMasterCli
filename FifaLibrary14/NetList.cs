using System;

namespace FifaLibrary
{
	// Token: 0x02000080 RID: 128
	public class NetList : IdArrayList
	{
		// Token: 0x06000A3E RID: 2622 RVA: 0x00046AEF File Offset: 0x00044CEF
		public NetList()
			: base(typeof(Net))
		{
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x00046B01 File Offset: 0x00044D01
		public NetList(DbFile fifaDb, FifaFat fatFile)
			: base(typeof(Net))
		{
			this.Load(fifaDb, fatFile);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x00046B1C File Offset: 0x00044D1C
		public void Load(DbFile fifaDb, FifaFat fatFile)
		{
			TableDescriptor tableDescriptor = fifaDb.Table[TI.stadiums].TableDescriptor;
			base.MinId = tableDescriptor.MinValues[FI.stadiums_stadiumgoalnetstyle];
			base.MaxId = tableDescriptor.MaxValues[FI.stadiums_stadiumgoalnetstyle];
			this.Clear();
			for (int i = base.MinId; i <= base.MaxId; i++)
			{
				string text = Net.NetFileName(i);
				if (fatFile.IsArchivedFilePresent(text) || fatFile.IsPhisycalFilePresent(text))
				{
					Net net = new Net(i);
					this.Add(net);
				}
			}
		}
	}
}
