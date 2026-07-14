using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x02000065 RID: 101
	public class FieldComparer : IComparer
	{
		// Token: 0x060008C6 RID: 2246 RVA: 0x00033F8C File Offset: 0x0003218C
		int IComparer.Compare(object x, object y)
		{
			FieldDescriptor fieldDescriptor = (FieldDescriptor)x;
			FieldDescriptor fieldDescriptor2 = (FieldDescriptor)y;
			if (fieldDescriptor.BitOffset == fieldDescriptor2.BitOffset)
			{
				return 0;
			}
			if (fieldDescriptor.BitOffset <= fieldDescriptor2.BitOffset)
			{
				return -1;
			}
			return 1;
		}
	}
}
