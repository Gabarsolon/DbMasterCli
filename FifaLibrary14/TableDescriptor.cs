using System;
using System.Data;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200005E RID: 94
	public class TableDescriptor
	{
		// Token: 0x170001BB RID: 443
		// (get) Token: 0x06000822 RID: 2082 RVA: 0x0003146E File Offset: 0x0002F66E
		// (set) Token: 0x06000823 RID: 2083 RVA: 0x00031476 File Offset: 0x0002F676
		public char[] ShortName
		{
			get
			{
				return this.m_ShortName;
			}
			set
			{
				this.m_ShortName = value;
			}
		}

		// Token: 0x170001BC RID: 444
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0003147F File Offset: 0x0002F67F
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x00031487 File Offset: 0x0002F687
		public uint NBitRecords
		{
			get
			{
				return this.m_NBitRecords;
			}
			set
			{
				this.m_NBitRecords = value;
			}
		}

		// Token: 0x170001BD RID: 445
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00031490 File Offset: 0x0002F690
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x00031498 File Offset: 0x0002F698
		public int NFields
		{
			get
			{
				return this.m_NFields;
			}
			set
			{
				this.m_NFields = value;
			}
		}

		// Token: 0x170001BE RID: 446
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x000314A1 File Offset: 0x0002F6A1
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x000314A9 File Offset: 0x0002F6A9
		public FieldDescriptor[] FieldDescriptors
		{
			get
			{
				return this.m_FieldDescriptors;
			}
			set
			{
				this.m_FieldDescriptors = value;
			}
		}

		// Token: 0x170001BF RID: 447
		// (get) Token: 0x0600082A RID: 2090 RVA: 0x000314B2 File Offset: 0x0002F6B2
		// (set) Token: 0x0600082B RID: 2091 RVA: 0x000314BA File Offset: 0x0002F6BA
		public HuffmannTree HuffmannTree
		{
			get
			{
				return this.m_HuffmannTree;
			}
			set
			{
				this.m_HuffmannTree = value;
			}
		}

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x0600082C RID: 2092 RVA: 0x000314C3 File Offset: 0x0002F6C3
		// (set) Token: 0x0600082D RID: 2093 RVA: 0x000314CA File Offset: 0x0002F6CA
		public static DataSet DescriptorDataSet
		{
			get
			{
				return TableDescriptor.s_DescriptorDataSet;
			}
			set
			{
				TableDescriptor.s_DescriptorDataSet = value;
			}
		}

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x0600082E RID: 2094 RVA: 0x000314D2 File Offset: 0x0002F6D2
		// (set) Token: 0x0600082F RID: 2095 RVA: 0x000314DA File Offset: 0x0002F6DA
		public string TableName
		{
			get
			{
				return this.m_TableName;
			}
			set
			{
				this.m_TableName = value;
			}
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000830 RID: 2096 RVA: 0x000314E3 File Offset: 0x0002F6E3
		// (set) Token: 0x06000831 RID: 2097 RVA: 0x000314EB File Offset: 0x0002F6EB
		public string TableShortName
		{
			get
			{
				return this.m_TableShortName;
			}
			set
			{
				this.m_TableShortName = value;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000832 RID: 2098 RVA: 0x000314F4 File Offset: 0x0002F6F4
		// (set) Token: 0x06000833 RID: 2099 RVA: 0x000314FC File Offset: 0x0002F6FC
		public int RecordSize
		{
			get
			{
				return this.m_RecordSize;
			}
			set
			{
				this.m_RecordSize = value;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000834 RID: 2100 RVA: 0x00031505 File Offset: 0x0002F705
		// (set) Token: 0x06000835 RID: 2101 RVA: 0x0003150D File Offset: 0x0002F70D
		public int NKeyFields
		{
			get
			{
				return this.m_NKeyFields;
			}
			set
			{
				this.m_NKeyFields = value;
			}
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000836 RID: 2102 RVA: 0x00031516 File Offset: 0x0002F716
		// (set) Token: 0x06000837 RID: 2103 RVA: 0x0003151E File Offset: 0x0002F71E
		public int[] KeyIndex
		{
			get
			{
				return this.m_KeyIndex;
			}
			set
			{
				this.m_KeyIndex = value;
			}
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000838 RID: 2104 RVA: 0x00031527 File Offset: 0x0002F727
		public int NFloatFields
		{
			get
			{
				return this.m_NFloatFields;
			}
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000839 RID: 2105 RVA: 0x0003152F File Offset: 0x0002F72F
		public int NStringFields
		{
			get
			{
				return this.m_NStringFields;
			}
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x0600083A RID: 2106 RVA: 0x00031537 File Offset: 0x0002F737
		public int NCompressedStringFields
		{
			get
			{
				return this.m_NCompressedStringFields;
			}
		}

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x0600083B RID: 2107 RVA: 0x0003153F File Offset: 0x0002F73F
		public int NIntFields
		{
			get
			{
				return this.m_NIntFields;
			}
		}

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00031547 File Offset: 0x0002F747
		public int[] MinValues
		{
			get
			{
				return this.m_MinValues;
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x0003154F File Offset: 0x0002F74F
		public int[] MaxValues
		{
			get
			{
				return this.m_MaxValues;
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00031557 File Offset: 0x0002F757
		public void SortFields()
		{
			if (this.m_FieldDescriptors == null)
			{
				return;
			}
			if (this.m_FieldDescriptors.Length >= 2)
			{
				Array.Sort(this.m_FieldDescriptors, TableDescriptor.s_FieldComparer);
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0003157D File Offset: 0x0002F77D
		public void LoadTableName(DbReader r)
		{
			this.m_ShortName = r.ReadChars(4);
			this.m_TableShortName = new string(this.m_ShortName);
			this.AssignXmlTableName();
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x000315A4 File Offset: 0x0002F7A4
		public void LoadFieldDescriptors(DbReader r)
		{
			this.m_FieldDescriptors = new FieldDescriptor[this.m_NFields];
			this.m_NKeyFields = 0;
			this.m_NFloatFields = 0;
			this.m_NIntFields = 0;
			this.m_NStringFields = 0;
			this.m_NCompressedStringFields = 0;
			this.m_MinValues = new int[this.m_NFields];
			this.m_MaxValues = new int[this.m_NFields];
			this.m_KeyIndex = new int[4];
			for (int i = 0; i < this.m_NFields; i++)
			{
				this.m_FieldDescriptors[i] = new FieldDescriptor(this);
				this.m_FieldDescriptors[i].Load(r);
				this.m_FieldDescriptors[i].OrderInTheTable = i;
				this.m_FieldDescriptors[i].AssignXmlDescriptor(TableDescriptor.s_DescriptorDataSet);
				FieldDescriptor.EFieldTypes fieldType = this.m_FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
					this.m_FieldDescriptors[i].TypeIndex = this.m_NStringFields;
					this.m_NStringFields++;
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
					this.m_FieldDescriptors[i].TypeIndex = this.m_NIntFields;
					this.m_MinValues[this.m_NIntFields] = this.m_FieldDescriptors[i].RangeLow;
					this.m_MaxValues[this.m_NIntFields] = this.m_FieldDescriptors[i].RangeHigh;
					this.m_NIntFields++;
					break;
				case FieldDescriptor.EFieldTypes.Float:
					this.m_FieldDescriptors[i].TypeIndex = this.m_NFloatFields;
					this.m_NFloatFields++;
					break;
				default:
					switch (fieldType)
					{
					case FieldDescriptor.EFieldTypes.ShortCompressedString:
					case FieldDescriptor.EFieldTypes.LongCompressedString:
						this.m_FieldDescriptors[i].TypeIndex = this.m_NCompressedStringFields;
						this.m_NCompressedStringFields++;
						break;
					}
					break;
				}
			}
			this.AssignXmlTableIndex();
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0003176C File Offset: 0x0002F96C
		public void SaveFieldDescriptors(BinaryWriter w)
		{
			for (int i = 0; i < this.m_NFields; i++)
			{
				for (int j = 0; j < this.m_NFields; j++)
				{
					if (this.m_FieldDescriptors[j].OrderInTheTable == i)
					{
						this.m_FieldDescriptors[j].Save(w);
						break;
					}
				}
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x000317BC File Offset: 0x0002F9BC
		private void AssignXmlTableName()
		{
			if (TableDescriptor.s_DescriptorDataSet != null)
			{
				int count = TableDescriptor.s_DescriptorDataSet.Tables["table"].Rows.Count;
				for (int i = 0; i < count; i++)
				{
					DataRow dataRow = TableDescriptor.s_DescriptorDataSet.Tables["table"].Rows[i];
					if ((string)dataRow["shortname"] == this.m_TableShortName)
					{
						string text = (string)dataRow["name"];
						this.m_TableName = text;
						return;
					}
				}
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x00031854 File Offset: 0x0002FA54
		private void AssignXmlTableIndex()
		{
			if (TableDescriptor.s_DescriptorDataSet != null)
			{
				int count = TableDescriptor.s_DescriptorDataSet.Tables["index"].Rows.Count;
				int count2 = TableDescriptor.s_DescriptorDataSet.Tables["indexfield"].Rows.Count;
				for (int i = 0; i < count; i++)
				{
					DataRow dataRow = TableDescriptor.s_DescriptorDataSet.Tables["index"].Rows[i];
					if ((string)dataRow["tableshortname"] == this.m_TableShortName)
					{
						int num = (int)dataRow.ItemArray[0];
						for (int j = 0; j < count2; j++)
						{
							DataRow dataRow2 = TableDescriptor.s_DescriptorDataSet.Tables["indexfield"].Rows[j];
							if ((int)dataRow2[2] == num)
							{
								string text = (string)dataRow2[0];
								int num2 = 0;
								for (int k = 0; k < this.m_NFields; k++)
								{
									if (this.m_FieldDescriptors[k].FieldShortName == text)
									{
										this.m_KeyIndex[this.m_NKeyFields++] = num2;
										break;
									}
									if (this.m_FieldDescriptors[k].FieldType == FieldDescriptor.EFieldTypes.Integer)
									{
										num2++;
									}
								}
							}
						}
						return;
					}
				}
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x000319C8 File Offset: 0x0002FBC8
		public FieldDescriptor GetFieldDescriptor(string longName)
		{
			for (int i = 0; i < this.m_NFields; i++)
			{
				if (this.m_FieldDescriptors[i].FieldName == longName)
				{
					return this.m_FieldDescriptors[i];
				}
			}
			return null;
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00031A08 File Offset: 0x0002FC08
		public int GetFieldIndex(string fieldName)
		{
			for (int i = 0; i < this.m_NFields; i++)
			{
				if (fieldName == this.FieldDescriptors[i].FieldName)
				{
					return this.FieldDescriptors[i].TypeIndex;
				}
			}
			return -1;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00031A4C File Offset: 0x0002FC4C
		public void RecalculateFieldOffset()
		{
			int[] array = new int[this.NFields];
			int num = 0;
			uint num2 = 0U;
			do
			{
				uint num3 = this.m_NBitRecords;
				for (int i = 0; i < this.NFields; i++)
				{
					if ((long)this.FieldDescriptors[i].BitOffset >= (long)((ulong)num2) && (long)this.FieldDescriptors[i].BitOffset < (long)((ulong)num3))
					{
						array[num] = i;
						num3 = (uint)this.FieldDescriptors[i].BitOffset;
					}
				}
				num2 = num3 + 1U;
				num++;
			}
			while (num < this.NFields);
			num2 = 0U;
			int j = 0;
			while (j < this.NFields)
			{
				FieldDescriptor.EFieldTypes fieldType = this.FieldDescriptors[array[j]].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
					if (num2 % 8U != 0U)
					{
						num2 = (num2 + 7U) & 4294967288U;
					}
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
				case FieldDescriptor.EFieldTypes.Integer:
					break;
				case FieldDescriptor.EFieldTypes.Float:
					goto IL_00C4;
				default:
					switch (fieldType)
					{
					case FieldDescriptor.EFieldTypes.ShortCompressedString:
					case FieldDescriptor.EFieldTypes.LongCompressedString:
						goto IL_00C4;
					}
					break;
				}
				IL_00E0:
				this.FieldDescriptors[array[j]].BitOffset = (int)num2;
				FieldDescriptor.EFieldTypes fieldType2 = this.FieldDescriptors[array[j]].FieldType;
				switch (fieldType2)
				{
				case FieldDescriptor.EFieldTypes.String:
				case FieldDescriptor.EFieldTypes.Integer:
					num2 += (uint)this.FieldDescriptors[array[j]].Depth;
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Float:
					goto IL_0132;
				default:
					switch (fieldType2)
					{
					case FieldDescriptor.EFieldTypes.ShortCompressedString:
					case FieldDescriptor.EFieldTypes.LongCompressedString:
						goto IL_0132;
					}
					break;
				}
				IL_014C:
				j++;
				continue;
				IL_0132:
				num2 += 32U;
				goto IL_014C;
				IL_00C4:
				if (num2 % 32U != 0U)
				{
					num2 = (num2 + 31U) & 4294967264U;
					goto IL_00E0;
				}
				goto IL_00E0;
			}
			int num4 = (int)((num2 + 7U) / 8U);
			int recordSize = this.m_RecordSize;
		}

		// Token: 0x04000354 RID: 852
		private char[] m_ShortName;

		// Token: 0x04000355 RID: 853
		private uint m_NBitRecords;

		// Token: 0x04000356 RID: 854
		private int m_NFields;

		// Token: 0x04000357 RID: 855
		private FieldDescriptor[] m_FieldDescriptors;

		// Token: 0x04000358 RID: 856
		private HuffmannTree m_HuffmannTree;

		// Token: 0x04000359 RID: 857
		private static DataSet s_DescriptorDataSet;

		// Token: 0x0400035A RID: 858
		private string m_TableName;

		// Token: 0x0400035B RID: 859
		private string m_TableShortName;

		// Token: 0x0400035C RID: 860
		private int m_RecordSize;

		// Token: 0x0400035D RID: 861
		private int m_NKeyFields;

		// Token: 0x0400035E RID: 862
		private int[] m_KeyIndex;

		// Token: 0x0400035F RID: 863
		private int m_NFloatFields;

		// Token: 0x04000360 RID: 864
		private int m_NStringFields;

		// Token: 0x04000361 RID: 865
		private int m_NCompressedStringFields;

		// Token: 0x04000362 RID: 866
		private int m_NIntFields;

		// Token: 0x04000363 RID: 867
		private int[] m_MinValues;

		// Token: 0x04000364 RID: 868
		private int[] m_MaxValues;

		// Token: 0x04000365 RID: 869
		private static FieldComparer s_FieldComparer = new FieldComparer();
	}
}
