using System;
using System.Reflection;

namespace FifaLibrary
{
	// Token: 0x0200001D RID: 29
	public class IdObject
	{
		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000FC2B File Offset: 0x0000DE2B
		// (set) Token: 0x060001CD RID: 461 RVA: 0x0000FC33 File Offset: 0x0000DE33
		public int Id
		{
			get
			{
				return this.m_Id;
			}
			set
			{
				this.m_Id = value;
			}
		}

		// Token: 0x060001CE RID: 462 RVA: 0x0000FC3C File Offset: 0x0000DE3C
		public IdObject()
		{
			this.m_Id = -1;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x0000FC4B File Offset: 0x0000DE4B
		public IdObject(int id)
		{
			this.m_Id = id;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x0000FC5C File Offset: 0x0000DE5C
		public virtual IdObject Clone(int newId)
		{
			IdObject idObject = (IdObject)base.MemberwiseClone();
			idObject.Id = newId;
			return idObject;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x0000FC7D File Offset: 0x0000DE7D
		public virtual bool Delete()
		{
			return true;
		}

		// Token: 0x060001D2 RID: 466 RVA: 0x0000FC80 File Offset: 0x0000DE80
		public static IdObject Create(Type type, int newId)
		{
			Type[] array = new Type[] { typeof(int) };
			object[] array2 = new object[] { newId };
			ConstructorInfo constructor = type.GetConstructor(array);
			if (constructor == null)
			{
				return null;
			}
			return (IdObject)constructor.Invoke(array2);
		}

		// Token: 0x040000DC RID: 220
		private int m_Id;
	}
}
