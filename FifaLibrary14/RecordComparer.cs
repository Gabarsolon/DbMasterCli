using System;
using System.Collections;

namespace FifaLibrary
{
	// Token: 0x02000064 RID: 100
	public class RecordComparer : IComparer
	{
		// Token: 0x060008C4 RID: 2244 RVA: 0x00033F14 File Offset: 0x00032114
		int IComparer.Compare(object x, object y)
		{
			Record record = (Record)x;
			Record record2 = (Record)y;
			TableDescriptor tableDescriptor = record.TableDescriptor;
			int i = 0;
			while (i < tableDescriptor.NKeyFields)
			{
				int num = tableDescriptor.KeyIndex[i];
				if (record.IntField[num] != record2.IntField[num])
				{
					if (record.IntField[num] <= record2.IntField[num])
					{
						return -1;
					}
					return 1;
				}
				else
				{
					i++;
				}
			}
			return 0;
		}
	}
}
