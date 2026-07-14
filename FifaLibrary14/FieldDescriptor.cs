using System;
using System.Data;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200005F RID: 95
	public class FieldDescriptor
	{
		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000849 RID: 2121 RVA: 0x00031BDD File Offset: 0x0002FDDD
		// (set) Token: 0x0600084A RID: 2122 RVA: 0x00031BE5 File Offset: 0x0002FDE5
		public TableDescriptor TableDescriptor
		{
			get
			{
				return this.m_TableDescriptor;
			}
			set
			{
				this.m_TableDescriptor = value;
			}
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x0600084B RID: 2123 RVA: 0x00031BEE File Offset: 0x0002FDEE
		// (set) Token: 0x0600084C RID: 2124 RVA: 0x00031BF6 File Offset: 0x0002FDF6
		public FieldDescriptor.EFieldTypes FieldType
		{
			get
			{
				return this.m_FieldType;
			}
			set
			{
				this.m_FieldType = value;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x0600084D RID: 2125 RVA: 0x00031BFF File Offset: 0x0002FDFF
		// (set) Token: 0x0600084E RID: 2126 RVA: 0x00031C07 File Offset: 0x0002FE07
		public int BitOffset
		{
			get
			{
				return this.m_BitOffset;
			}
			set
			{
				this.m_BitOffset = value;
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00031C10 File Offset: 0x0002FE10
		public FieldDescriptor(TableDescriptor tableDescriptor)
		{
			this.m_TableDescriptor = tableDescriptor;
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000850 RID: 2128 RVA: 0x00031C1F File Offset: 0x0002FE1F
		// (set) Token: 0x06000851 RID: 2129 RVA: 0x00031C27 File Offset: 0x0002FE27
		public int Depth
		{
			get
			{
				return this.m_Depth;
			}
			set
			{
				this.m_Depth = value;
				this.m_Mask = (int)((1L << this.m_Depth) - 1L);
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00031C46 File Offset: 0x0002FE46
		public int Mask
		{
			get
			{
				return this.m_Mask;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x06000853 RID: 2131 RVA: 0x00031C4E File Offset: 0x0002FE4E
		// (set) Token: 0x06000854 RID: 2132 RVA: 0x00031C56 File Offset: 0x0002FE56
		public string FieldShortName
		{
			get
			{
				return this.m_FieldShortName;
			}
			set
			{
				this.m_FieldShortName = value;
			}
		}

		// Token: 0x170001D2 RID: 466
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x00031C5F File Offset: 0x0002FE5F
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x00031C67 File Offset: 0x0002FE67
		public string FieldName
		{
			get
			{
				return this.m_FieldName;
			}
			set
			{
				this.m_FieldName = value;
			}
		}

		// Token: 0x170001D3 RID: 467
		// (get) Token: 0x06000857 RID: 2135 RVA: 0x00031C70 File Offset: 0x0002FE70
		// (set) Token: 0x06000858 RID: 2136 RVA: 0x00031C78 File Offset: 0x0002FE78
		public int RangeLow
		{
			get
			{
				return this.m_RangeLow;
			}
			set
			{
				this.m_RangeLow = value;
			}
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000859 RID: 2137 RVA: 0x00031C81 File Offset: 0x0002FE81
		public int RangeHigh
		{
			get
			{
				return this.m_RangeHigh;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x0600085A RID: 2138 RVA: 0x00031C89 File Offset: 0x0002FE89
		// (set) Token: 0x0600085B RID: 2139 RVA: 0x00031C91 File Offset: 0x0002FE91
		public int TypeIndex
		{
			get
			{
				return this.m_TypeIndex;
			}
			set
			{
				this.m_TypeIndex = value;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x0600085C RID: 2140 RVA: 0x00031C9A File Offset: 0x0002FE9A
		// (set) Token: 0x0600085D RID: 2141 RVA: 0x00031CA2 File Offset: 0x0002FEA2
		public int OrderInTheTable
		{
			get
			{
				return this.m_OrderInTheTable;
			}
			set
			{
				this.m_OrderInTheTable = value;
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00031CAC File Offset: 0x0002FEAC
		public void Load(DbReader r)
		{
			this.m_FieldType = (FieldDescriptor.EFieldTypes)r.ReadInt32();
			this.m_BitOffset = r.ReadInt32();
			this.m_ShortName = r.ReadBytes(4);
			this.m_Depth = r.ReadInt32();
			this.m_FieldShortName = FifaUtil.ConvertBytesToString(this.m_ShortName);
			this.m_FieldName = this.m_FieldShortName;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x00031D07 File Offset: 0x0002FF07
		public void Save(BinaryWriter w)
		{
			w.Write((int)this.m_FieldType);
			w.Write(this.m_BitOffset);
			w.Write(this.m_ShortName);
			w.Write(this.m_Depth);
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00031D3C File Offset: 0x0002FF3C
		public void AssignXmlDescriptor(DataSet descriptorDataSet)
		{
			if (descriptorDataSet != null)
			{
				int count = descriptorDataSet.Tables["field"].Rows.Count;
				for (int i = 0; i < count; i++)
				{
					DataRow dataRow = descriptorDataSet.Tables["field"].Rows[i];
					if (this.m_FieldShortName == (string)dataRow["shortname"])
					{
						int num = (int)dataRow["fields_Id"];
						DataRow dataRow2 = descriptorDataSet.Tables["fields"].Rows[num];
						int num2 = (int)dataRow2["table_Id"];
						DataRow dataRow3 = descriptorDataSet.Tables["table"].Rows[num2];
						if ((string)dataRow3["shortname"] == this.m_TableDescriptor.TableShortName)
						{
							this.m_FieldName = (string)dataRow["name"];
							this.m_RangeLow = Convert.ToInt32((string)dataRow["rangelow"]);
							this.m_RangeHigh = Convert.ToInt32((string)dataRow["rangehigh"]);
							this.m_XmlDataRow = dataRow;
							return;
						}
					}
				}
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x00031E90 File Offset: 0x00030090
		public bool Expand(int depth)
		{
			if (depth < this.m_Depth)
			{
				return false;
			}
			if (depth > this.m_Depth)
			{
				this.m_Depth = depth;
				this.m_XmlDataRow["depth"] = this.m_Depth.ToString();
			}
			int num = 1 << this.m_Depth;
			this.m_RangeHigh = this.m_RangeLow + num - 1;
			this.m_XmlDataRow["rangehigh"] = this.m_RangeHigh.ToString();
			return true;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00031F0B File Offset: 0x0003010B
		public bool Expand(int depth, int minValue)
		{
			this.m_RangeLow = minValue;
			this.m_XmlDataRow["rangelow"] = this.m_RangeLow.ToString();
			return this.Expand(depth);
		}

		// Token: 0x04000366 RID: 870
		private DataRow m_XmlDataRow;

		// Token: 0x04000367 RID: 871
		private TableDescriptor m_TableDescriptor;

		// Token: 0x04000368 RID: 872
		private FieldDescriptor.EFieldTypes m_FieldType;

		// Token: 0x04000369 RID: 873
		private int m_BitOffset;

		// Token: 0x0400036A RID: 874
		private byte[] m_ShortName;

		// Token: 0x0400036B RID: 875
		private int m_Depth;

		// Token: 0x0400036C RID: 876
		private int m_Mask;

		// Token: 0x0400036D RID: 877
		private string m_FieldShortName;

		// Token: 0x0400036E RID: 878
		private string m_FieldName;

		// Token: 0x0400036F RID: 879
		private int m_RangeLow;

		// Token: 0x04000370 RID: 880
		private int m_RangeHigh;

		// Token: 0x04000371 RID: 881
		private int m_TypeIndex;

		// Token: 0x04000372 RID: 882
		private int m_OrderInTheTable;

		// Token: 0x02000060 RID: 96
		public enum EFieldTypes
		{
			// Token: 0x04000374 RID: 884
			String,
			// Token: 0x04000375 RID: 885
			Integer = 3,
			// Token: 0x04000376 RID: 886
			Float,
			// Token: 0x04000377 RID: 887
			ShortCompressedString = 13,
			// Token: 0x04000378 RID: 888
			LongCompressedString
		}
	}
}
