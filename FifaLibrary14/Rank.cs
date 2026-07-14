using System;

namespace FifaLibrary
{
	// Token: 0x0200004C RID: 76
	public class Rank : IdObject
	{
		// Token: 0x1700018C RID: 396
		// (get) Token: 0x0600073C RID: 1852 RVA: 0x00029D15 File Offset: 0x00027F15
		// (set) Token: 0x0600073D RID: 1853 RVA: 0x00029D1D File Offset: 0x00027F1D
		public Group Group
		{
			get
			{
				return this.m_Group;
			}
			set
			{
				this.m_Group = value;
			}
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600073E RID: 1854 RVA: 0x00029D26 File Offset: 0x00027F26
		// (set) Token: 0x0600073F RID: 1855 RVA: 0x00029D2E File Offset: 0x00027F2E
		public Rank MoveFrom
		{
			get
			{
				return this.m_MoveFrom;
			}
			set
			{
				this.m_MoveFrom = value;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x06000740 RID: 1856 RVA: 0x00029D37 File Offset: 0x00027F37
		// (set) Token: 0x06000741 RID: 1857 RVA: 0x00029D3F File Offset: 0x00027F3F
		public Rank MoveTo
		{
			get
			{
				return this.m_MoveTo;
			}
			set
			{
				this.m_MoveTo = value;
			}
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x00029D48 File Offset: 0x00027F48
		public Rank(Group group, int orderId)
		{
			base.Id = orderId;
			this.m_Group = group;
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x00029D60 File Offset: 0x00027F60
		public override string ToString()
		{
			Stage parentStage = this.m_Group.ParentStage;
			Trophy trophy = parentStage.Trophy;
			string text;
			if (base.Id != 0)
			{
				text = string.Concat(new string[]
				{
					"Team n.",
					base.Id.ToString(),
					" of ",
					parentStage.ToString(),
					" / ",
					this.m_Group.ToString(),
					" of ",
					trophy.ToString()
				});
			}
			else
			{
				text = string.Concat(new string[]
				{
					"A team from ",
					parentStage.ToString(),
					" / ",
					this.m_Group.ToString(),
					" of ",
					trophy.ToString()
				});
			}
			return text;
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x00029E3C File Offset: 0x0002803C
		public string GetFromRankString()
		{
			if (this.m_MoveFrom == null || this.m_MoveFrom.Group == null)
			{
				return "To be defined";
			}
			if (!FifaEnvironment.CompetitionObjects.Contains(this.m_MoveFrom.Group))
			{
				this.m_MoveFrom = null;
				return "To be defined";
			}
			if (this.m_MoveTo != null && !FifaEnvironment.CompetitionObjects.Contains(this.m_MoveTo.Group))
			{
				this.m_MoveTo = null;
			}
			Trophy trophy = this.m_Group.ParentStage.Trophy;
			Trophy trophy2 = this.m_MoveFrom.Group.ParentStage.Trophy;
			string text;
			if (trophy.Id != trophy2.Id)
			{
				if (this.m_MoveFrom.Id != 0)
				{
					text = string.Concat(new string[]
					{
						"Team n.",
						this.m_MoveFrom.Id.ToString(),
						" of ",
						this.m_MoveFrom.Group.ParentStage.ToString(),
						" / ",
						this.m_MoveFrom.Group.ToString(),
						" of ",
						this.m_MoveFrom.Group.ParentStage.Trophy.ToString()
					});
				}
				else
				{
					text = string.Concat(new string[]
					{
						"A team from ",
						this.m_MoveFrom.Group.ParentStage.ToString(),
						" / ",
						this.m_MoveFrom.Group.ToString(),
						" of ",
						this.m_MoveFrom.Group.ParentStage.Trophy.ToString()
					});
				}
			}
			else if (this.m_MoveFrom.Id != 0)
			{
				text = string.Concat(new string[]
				{
					"Team n.",
					this.m_MoveFrom.Id.ToString(),
					" of ",
					this.m_MoveFrom.Group.ParentStage.ToString(),
					" / ",
					this.m_MoveFrom.Group.ToString()
				});
			}
			else
			{
				text = "A team from " + this.m_MoveFrom.Group.ParentStage.ToString() + " / " + this.m_MoveFrom.Group.ToString();
			}
			return text;
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0002A0BC File Offset: 0x000282BC
		public string GetToRankString()
		{
			if (this.m_MoveTo == null)
			{
				return "Undefined";
			}
			Trophy trophy = this.m_Group.ParentStage.Trophy;
			Trophy trophy2 = this.m_MoveTo.Group.ParentStage.Trophy;
			string text;
			if (trophy.Id != trophy2.Id)
			{
				if (this.m_MoveFrom.Id != 0)
				{
					text = string.Concat(new string[]
					{
						"Team n.",
						this.m_MoveTo.Id.ToString(),
						" fof ",
						this.m_MoveTo.Group.ParentStage.ToString(),
						" / ",
						this.m_MoveTo.Group.ToString(),
						" of ",
						this.m_MoveFrom.Group.ParentStage.Trophy.ToString()
					});
				}
				else
				{
					text = string.Concat(new string[]
					{
						"A team from ",
						this.m_MoveTo.Group.ParentStage.ToString(),
						" / ",
						this.m_MoveTo.Group.ToString(),
						" of ",
						this.m_MoveTo.Group.ParentStage.Trophy.ToString()
					});
				}
			}
			else if (this.m_MoveFrom.Id != 0)
			{
				text = string.Concat(new string[]
				{
					"Team n.",
					this.m_MoveTo.Id.ToString(),
					" of ",
					this.m_MoveTo.Group.ParentStage.ToString(),
					" / ",
					this.m_MoveTo.Group.ToString()
				});
			}
			else
			{
				text = "A team from " + this.m_MoveTo.Group.ParentStage.ToString() + " / " + this.m_MoveTo.Group.ToString();
			}
			return text;
		}

		// Token: 0x040002A4 RID: 676
		private Group m_Group;

		// Token: 0x040002A5 RID: 677
		private Rank m_MoveFrom;

		// Token: 0x040002A6 RID: 678
		private Rank m_MoveTo;
	}
}
