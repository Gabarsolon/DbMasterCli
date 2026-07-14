using System;

namespace FifaLibrary
{
	// Token: 0x02000042 RID: 66
	public class Confederation : Compobj
	{
		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000687 RID: 1671 RVA: 0x00026E9B File Offset: 0x0002509B
		// (set) Token: 0x06000688 RID: 1672 RVA: 0x00026EA3 File Offset: 0x000250A3
		public World World
		{
			get
			{
				return this.m_World;
			}
			set
			{
				this.m_World = value;
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x00026EAC File Offset: 0x000250AC
		public Confederation(int id, string typeString, string description, Compobj parentObj)
			: base(id, 1, typeString, description, parentObj)
		{
			this.m_Nations = new NationList();
			this.m_Trophies = new TrophyList();
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x00026ED0 File Offset: 0x000250D0
		public bool AddTrophy(int assetId)
		{
			if (assetId >= 1000)
			{
				return false;
			}
			int count = base.Trophies.Count;
			string text = "C" + assetId.ToString();
			string text2 = "TrophyName_Abbr15_" + assetId.ToString();
			int newId = FifaEnvironment.CompetitionObjects.GetNewId();
			Trophy trophy = new Trophy(newId, text, text2, this);
			if (trophy == null)
			{
				return false;
			}
			base.Trophies.Add(trophy);
			FifaEnvironment.CompetitionObjects.Add(trophy);
			trophy.AddStage();
			return true;
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x00026F54 File Offset: 0x00025154
		public bool RemoveTrophy(int trophyId)
		{
			if (this.m_Trophies.Count < 1)
			{
				return false;
			}
			Trophy trophy = (Trophy)FifaEnvironment.CompetitionObjects.SearchId(trophyId);
			if (trophy == null)
			{
				return false;
			}
			this.m_Trophies.Remove(trophy);
			FifaEnvironment.CompetitionObjects.Remove(trophy);
			trophy.RemoveAllStages();
			return true;
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x00026FA8 File Offset: 0x000251A8
		public bool AddNation(Country country)
		{
			int count = base.Nations.Count;
			string text = country.DatabaseName.Substring(0, 4);
			string text2 = "NationName_" + country.Id.ToString();
			int newId = FifaEnvironment.CompetitionObjects.GetNewId();
			Nation nation = new Nation(newId, text, text2, this);
			if (nation == null)
			{
				return false;
			}
			base.Nations.Add(nation);
			FifaEnvironment.CompetitionObjects.Add(nation);
			return true;
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x00027020 File Offset: 0x00025220
		public bool RemoveNation()
		{
			if (this.m_Nations.Count < 1)
			{
				return false;
			}
			Nation nation = (Nation)this.m_Nations[this.m_Nations.Count - 1];
			this.m_Nations.Remove(nation);
			FifaEnvironment.CompetitionObjects.Remove(nation);
			nation.RemoveAllTrophies();
			return true;
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0002707C File Offset: 0x0002527C
		public bool RemoveAllNations()
		{
			int count = this.m_Nations.Count;
			for (int i = 0; i < count; i++)
			{
				this.RemoveNation();
			}
			return true;
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x000270A9 File Offset: 0x000252A9
		public override void Normalize()
		{
		}

		// Token: 0x04000283 RID: 643
		private World m_World;
	}
}
