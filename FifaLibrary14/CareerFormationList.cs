using System;

namespace FifaLibrary
{
	// Token: 0x020000A8 RID: 168
	public class CareerFormationList : FormationList
	{
		// Token: 0x06000C64 RID: 3172 RVA: 0x000507C5 File Offset: 0x0004E9C5
		public CareerFormationList(CareerFile careerFile)
			: base(typeof(CareerFormation))
		{
			this.Load(careerFile);
		}

		// Token: 0x06000C65 RID: 3173 RVA: 0x000507DE File Offset: 0x0004E9DE
		public void Load(CareerFile careerFile)
		{
		}

		// Token: 0x06000C66 RID: 3174 RVA: 0x000507E0 File Offset: 0x0004E9E0
		private void Load(Table formationsTable, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			this.Clear();
			for (int i = 0; i < formationsTable.NRecords; i++)
			{
				Record record = formationsTable.Records[i];
				CareerFormation careerFormation = new CareerFormation(record);
				this.Add(careerFormation);
			}
		}

		// Token: 0x06000C67 RID: 3175 RVA: 0x0005082C File Offset: 0x0004EA2C
		private void AdditionalLoad(Table formationsTable)
		{
			for (int i = 0; i < formationsTable.NRecords; i++)
			{
				Record record = formationsTable.Records[i];
				CareerFormation careerFormation = new CareerFormation(record);
				careerFormation.IsInCareer = true;
				CareerFormation careerFormation2 = (CareerFormation)base.SearchId(careerFormation);
				if (careerFormation2 != null)
				{
					base.RemoveId(careerFormation2);
				}
				base.InsertId(careerFormation);
			}
		}

		// Token: 0x06000C68 RID: 3176 RVA: 0x00050881 File Offset: 0x0004EA81
		public void Save(DbFile dbFile, CareerFile careerFile)
		{
		}
	}
}
