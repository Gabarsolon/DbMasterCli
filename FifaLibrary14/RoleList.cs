using System;

namespace FifaLibrary
{
	// Token: 0x020000A3 RID: 163
	public class RoleList : IdArrayList
	{
		// Token: 0x06000C07 RID: 3079 RVA: 0x0004E73F File Offset: 0x0004C93F
		public RoleList()
			: base(typeof(Role))
		{
		}

		// Token: 0x06000C08 RID: 3080 RVA: 0x0004E751 File Offset: 0x0004C951
		public RoleList(DbFile fifaDbFile)
			: base(typeof(Role))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000C09 RID: 3081 RVA: 0x0004E76A File Offset: 0x0004C96A
		public RoleList(Table boundingBoxTable)
			: base(typeof(Role))
		{
			this.Load(boundingBoxTable);
		}

		// Token: 0x06000C0A RID: 3082 RVA: 0x0004E784 File Offset: 0x0004C984
		public void Load(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.fieldpositionboundingboxes];
			this.Load(table);
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0004E7AC File Offset: 0x0004C9AC
		public void Load(Table boundingBoxTable)
		{
			base.MinId = 0;
			base.MaxId = 32;
			this.Clear();
			for (int i = 0; i < boundingBoxTable.NRecords; i++)
			{
				Record record = boundingBoxTable.Records[i];
				Role role = new Role(record);
				this.Add(role);
			}
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0004E7F8 File Offset: 0x0004C9F8
		public void Save(DbFile fifaDbFile)
		{
			Table table = FifaEnvironment.FifaDb.Table[TI.fieldpositionboundingboxes];
			int num = 0;
			foreach (object obj in this)
			{
				Role role = (Role)obj;
				Record record = table.Records[num];
				num++;
				role.Save(record);
			}
		}
	}
}
