using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x02000021 RID: 33
	public class IdArrayList : ArrayList
	{
		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000247 RID: 583 RVA: 0x0001128E File Offset: 0x0000F48E
		// (set) Token: 0x06000248 RID: 584 RVA: 0x00011296 File Offset: 0x0000F496
		public int MinId
		{
			get
			{
				return this.m_MinId;
			}
			set
			{
				this.m_MinId = value;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x06000249 RID: 585 RVA: 0x0001129F File Offset: 0x0000F49F
		// (set) Token: 0x0600024A RID: 586 RVA: 0x000112A7 File Offset: 0x0000F4A7
		public int MaxId
		{
			get
			{
				return this.m_MaxId;
			}
			set
			{
				this.m_MaxId = value;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x0600024B RID: 587 RVA: 0x000112B0 File Offset: 0x0000F4B0
		// (set) Token: 0x0600024C RID: 588 RVA: 0x000112B8 File Offset: 0x0000F4B8
		public Type ObjectType
		{
			get
			{
				return this.m_Type;
			}
			set
			{
				this.m_Type = value;
			}
		}

		// Token: 0x0600024D RID: 589 RVA: 0x000112C1 File Offset: 0x0000F4C1
		public IdArrayList(Type type, int minId, int maxId)
		{
			this.m_Type = type;
			this.m_MinId = minId;
			this.m_MaxId = maxId;
		}

		// Token: 0x0600024E RID: 590 RVA: 0x000112E9 File Offset: 0x0000F4E9
		public IdArrayList(Type type)
		{
			this.m_Type = type;
			this.m_MinId = 0;
			this.m_MaxId = -1;
		}

		// Token: 0x0600024F RID: 591 RVA: 0x00011311 File Offset: 0x0000F511
		public IdArrayList(int minId, int maxId)
		{
			this.m_Type = typeof(IdObject);
			this.m_MinId = minId;
			this.m_MaxId = maxId;
		}

		// Token: 0x06000250 RID: 592 RVA: 0x00011342 File Offset: 0x0000F542
		public IdArrayList()
		{
			this.m_Type = typeof(IdObject);
			this.m_MinId = -1;
			this.m_MaxId = 0;
		}

		// Token: 0x06000251 RID: 593 RVA: 0x00011374 File Offset: 0x0000F574
		public bool InsertId(IdObject idObject)
		{
			if (idObject == null)
			{
				return false;
			}
			int num = this.BinarySearch(idObject, this.m_Comparer);
			if (num < 0)
			{
				num = ~num;
				this.Insert(num, idObject);
				return true;
			}
			return false;
		}

		// Token: 0x06000252 RID: 594 RVA: 0x000113A8 File Offset: 0x0000F5A8
		public bool RemoveId(IdObject idObject)
		{
			int num = this.BinarySearch(idObject, this.m_Comparer);
			if (num >= 0)
			{
				this.RemoveAt(num);
				return true;
			}
			return false;
		}

		// Token: 0x06000253 RID: 595 RVA: 0x000113D4 File Offset: 0x0000F5D4
		public bool RemoveId(int id)
		{
			IdObject idObject = new IdObject(id);
			return this.RemoveId(idObject);
		}

		// Token: 0x06000254 RID: 596 RVA: 0x000113EF File Offset: 0x0000F5EF
		public void SortId()
		{
			this.Sort(this.m_Comparer);
		}

		// Token: 0x06000255 RID: 597 RVA: 0x000113FD File Offset: 0x0000F5FD
		public bool DeleteId(IdObject idObject)
		{
			return this.RemoveId(idObject) && idObject.Delete();
		}

		// Token: 0x06000256 RID: 598 RVA: 0x00011410 File Offset: 0x0000F610
		public IdObject SearchId(int id)
		{
			IdObject idObject = new IdObject(id);
			return this.SearchId(idObject);
		}

		// Token: 0x06000257 RID: 599 RVA: 0x0001142C File Offset: 0x0000F62C
		public IdObject SearchId(IdObject idObject)
		{
			int num = this.BinarySearch(idObject, this.m_Comparer);
			if (num >= 0)
			{
				return (IdObject)this[num];
			}
			return null;
		}

		// Token: 0x06000258 RID: 600 RVA: 0x0001145C File Offset: 0x0000F65C
		public bool ChangeId(IdObject idObject, int newId)
		{
			int id = idObject.Id;
			if (!this.RemoveId(idObject))
			{
				return false;
			}
			idObject.Id = newId;
			if (!this.InsertId(idObject))
			{
				idObject.Id = id;
				this.InsertId(idObject);
				return false;
			}
			return true;
		}

		// Token: 0x06000259 RID: 601 RVA: 0x000114A0 File Offset: 0x0000F6A0
		public virtual int GetNewId()
		{
			int num = -1;
			for (int i = this.m_MinId; i <= this.m_MaxId; i++)
			{
				if (this.SearchId(i) == null)
				{
					num = i;
					break;
				}
			}
			return num;
		}

		// Token: 0x0600025A RID: 602 RVA: 0x000114D4 File Offset: 0x0000F6D4
		public virtual int GetNextId(int minId)
		{
			int num = -1;
			for (int i = minId; i <= this.m_MaxId; i++)
			{
				if (this.SearchId(i) == null)
				{
					num = i;
					break;
				}
			}
			return num;
		}

		// Token: 0x0600025B RID: 603 RVA: 0x00011504 File Offset: 0x0000F704
		public IdObject CreateNewId()
		{
			int newId = this.GetNewId();
			if (newId < 0)
			{
				return null;
			}
			IdObject idObject = IdObject.Create(this.m_Type, newId);
			this.InsertId(idObject);
			return idObject;
		}

		// Token: 0x0600025C RID: 604 RVA: 0x00011534 File Offset: 0x0000F734
		public IdObject CreateNewId(int newId)
		{
			if (this.SearchId(newId) != null)
			{
				return null;
			}
			IdObject idObject = IdObject.Create(this.m_Type, newId);
			this.InsertId(idObject);
			return idObject;
		}

		// Token: 0x0600025D RID: 605 RVA: 0x00011564 File Offset: 0x0000F764
		public IdObject CloneId(IdObject srcIdObject)
		{
			int newId = this.GetNewId();
			if (newId < 0)
			{
				return null;
			}
			IdObject idObject = srcIdObject.Clone(newId);
			this.InsertId(idObject);
			return idObject;
		}

		// Token: 0x0600025E RID: 606 RVA: 0x00011590 File Offset: 0x0000F790
		public IdObject CloneId(int srcId)
		{
			IdObject idObject = this.SearchId(srcId);
			if (idObject == null)
			{
				return null;
			}
			return this.CloneId(idObject);
		}

		// Token: 0x0600025F RID: 607 RVA: 0x000115B4 File Offset: 0x0000F7B4
		public IdObject CloneId(IdObject srcIdObject, int newId)
		{
			IdObject idObject = srcIdObject.Clone(newId);
			this.InsertId(idObject);
			return idObject;
		}

		// Token: 0x06000260 RID: 608 RVA: 0x000115D4 File Offset: 0x0000F7D4
		public IdObject CloneId(IdObject srcIdObject, IdObject newObject)
		{
			IdObject idObject = srcIdObject.Clone(newObject.Id);
			this.RemoveId(newObject);
			this.InsertId(idObject);
			return idObject;
		}

		// Token: 0x06000261 RID: 609 RVA: 0x000115FF File Offset: 0x0000F7FF
		public virtual IdArrayList Filter(IdObject filterValue)
		{
			return this;
		}

		// Token: 0x06000262 RID: 610 RVA: 0x00011602 File Offset: 0x0000F802
		public virtual IdArrayList Filter(IdObject filterValue, bool flag)
		{
			return this;
		}

		// Token: 0x04000117 RID: 279
		private int m_MinId;

		// Token: 0x04000118 RID: 280
		private int m_MaxId;

		// Token: 0x04000119 RID: 281
		private Type m_Type;

		// Token: 0x0400011A RID: 282
		private IdObjectComparer m_Comparer = new IdObjectComparer();
	}
}
