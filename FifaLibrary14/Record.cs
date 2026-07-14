using System;
using System.Data;
using System.Globalization;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000063 RID: 99
	public class Record
	{
		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000898 RID: 2200 RVA: 0x00032E50 File Offset: 0x00031050
		// (set) Token: 0x06000899 RID: 2201 RVA: 0x00032E58 File Offset: 0x00031058
		public int[] CompressedStringOffset
		{
			get
			{
				return this.m_CompressedStringOffset;
			}
			set
			{
				this.m_CompressedStringOffset = value;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600089A RID: 2202 RVA: 0x00032E61 File Offset: 0x00031061
		// (set) Token: 0x0600089B RID: 2203 RVA: 0x00032E69 File Offset: 0x00031069
		public int[] CompressedStringFieldIndex
		{
			get
			{
				return this.m_CompressedStringFieldIndex;
			}
			set
			{
				this.m_CompressedStringFieldIndex = value;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600089C RID: 2204 RVA: 0x00032E72 File Offset: 0x00031072
		// (set) Token: 0x0600089D RID: 2205 RVA: 0x00032E7A File Offset: 0x0003107A
		public string[] CompressedString
		{
			get
			{
				return this.m_CompressedString;
			}
			set
			{
				this.m_CompressedString = value;
			}
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600089E RID: 2206 RVA: 0x00032E83 File Offset: 0x00031083
		// (set) Token: 0x0600089F RID: 2207 RVA: 0x00032E8A File Offset: 0x0003108A
		public static int HuffmannTreeSize
		{
			get
			{
				return Record.m_HuffmannTreeSize;
			}
			set
			{
				Record.m_HuffmannTreeSize = value;
			}
		}

		// Token: 0x060008A0 RID: 2208 RVA: 0x00032E94 File Offset: 0x00031094
		public int GetIntField(string fieldName)
		{
			for (int i = 0; i < this.TableDescriptor.NFields; i++)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					return this.m_IntField[this.TableDescriptor.FieldDescriptors[i].TypeIndex];
				}
			}
			return 0;
		}

		// Token: 0x060008A1 RID: 2209 RVA: 0x00032EEC File Offset: 0x000310EC
		public bool SetField(string fieldName, int value)
		{
			for (int i = 0; i < this.TableDescriptor.NFields; i++)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					this.m_IntField[this.TableDescriptor.FieldDescriptors[i].TypeIndex] = value;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060008A2 RID: 2210 RVA: 0x00032F48 File Offset: 0x00031148
		public float GetFloatField(string fieldName)
		{
			for (int i = 0; i < this.TableDescriptor.NFields; i++)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					return this.m_FloatField[this.TableDescriptor.FieldDescriptors[i].TypeIndex];
				}
			}
			return float.NaN;
		}

		// Token: 0x060008A3 RID: 2211 RVA: 0x00032FA4 File Offset: 0x000311A4
		public bool SetField(string fieldName, float value)
		{
			for (int i = 0; i < this.TableDescriptor.NFields; i++)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					this.m_FloatField[this.TableDescriptor.FieldDescriptors[i].TypeIndex] = value;
					return true;
				}
			}
			return false;
		}

		// Token: 0x060008A4 RID: 2212 RVA: 0x00033000 File Offset: 0x00031200
		public string GetStringField(string fieldName)
		{
			int i = 0;
			while (i < this.TableDescriptor.NFields)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					if (this.TableDescriptor.FieldDescriptors[i].FieldType == FieldDescriptor.EFieldTypes.String)
					{
						return this.m_StringField[this.TableDescriptor.FieldDescriptors[i].TypeIndex];
					}
					return this.m_CompressedString[this.TableDescriptor.FieldDescriptors[i].TypeIndex];
				}
				else
				{
					i++;
				}
			}
			return string.Empty;
		}

		// Token: 0x060008A5 RID: 2213 RVA: 0x0003308C File Offset: 0x0003128C
		public bool SetField(string fieldName, string value)
		{
			for (int i = 0; i < this.TableDescriptor.NFields; i++)
			{
				if (this.TableDescriptor.FieldDescriptors[i].FieldName == fieldName)
				{
					if (this.TableDescriptor.FieldDescriptors[i].FieldType == FieldDescriptor.EFieldTypes.String)
					{
						this.m_StringField[this.TableDescriptor.FieldDescriptors[i].TypeIndex] = value;
					}
					else
					{
						this.m_CompressedString[this.TableDescriptor.FieldDescriptors[i].TypeIndex] = value;
					}
					return true;
				}
			}
			return false;
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x060008A6 RID: 2214 RVA: 0x00033116 File Offset: 0x00031316
		// (set) Token: 0x060008A7 RID: 2215 RVA: 0x0003311E File Offset: 0x0003131E
		public int[] KeyField
		{
			get
			{
				return this.m_KeyField;
			}
			set
			{
				this.m_KeyField = value;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x060008A8 RID: 2216 RVA: 0x00033127 File Offset: 0x00031327
		// (set) Token: 0x060008A9 RID: 2217 RVA: 0x0003312F File Offset: 0x0003132F
		public float[] FloatField
		{
			get
			{
				return this.m_FloatField;
			}
			set
			{
				this.m_FloatField = value;
			}
		}

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x060008AA RID: 2218 RVA: 0x00033138 File Offset: 0x00031338
		// (set) Token: 0x060008AB RID: 2219 RVA: 0x00033140 File Offset: 0x00031340
		public int[] PtrToStringField
		{
			get
			{
				return this.m_PtrToStringField;
			}
			set
			{
				this.m_PtrToStringField = value;
			}
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x060008AC RID: 2220 RVA: 0x00033149 File Offset: 0x00031349
		// (set) Token: 0x060008AD RID: 2221 RVA: 0x00033151 File Offset: 0x00031351
		public int[] IntField
		{
			get
			{
				return this.m_IntField;
			}
			set
			{
				this.m_IntField = value;
			}
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x060008AE RID: 2222 RVA: 0x0003315A File Offset: 0x0003135A
		// (set) Token: 0x060008AF RID: 2223 RVA: 0x00033162 File Offset: 0x00031362
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

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x060008B0 RID: 2224 RVA: 0x0003316B File Offset: 0x0003136B
		// (set) Token: 0x060008B1 RID: 2225 RVA: 0x00033173 File Offset: 0x00031373
		public string[] StringField
		{
			get
			{
				return this.m_StringField;
			}
			set
			{
				this.m_StringField = value;
			}
		}

		// Token: 0x060008B2 RID: 2226 RVA: 0x0003317C File Offset: 0x0003137C
		public Record(TableDescriptor tableDescriptor)
		{
			this.m_TableDescriptor = tableDescriptor;
			if (this.m_TableDescriptor.NKeyFields > 0)
			{
				this.m_KeyField = new int[this.m_TableDescriptor.NKeyFields];
			}
			if (this.m_TableDescriptor.NFloatFields > 0)
			{
				this.m_FloatField = new float[this.m_TableDescriptor.NFloatFields];
			}
			if (this.m_TableDescriptor.NStringFields > 0)
			{
				this.m_PtrToStringField = new int[this.m_TableDescriptor.NStringFields];
				this.m_StringField = new string[this.m_TableDescriptor.NStringFields];
			}
			if (this.m_TableDescriptor.NCompressedStringFields > 0)
			{
				this.m_CompressedStringOffset = new int[this.m_TableDescriptor.NCompressedStringFields];
				this.m_CompressedString = new string[this.m_TableDescriptor.NCompressedStringFields];
				this.m_CompressedStringFieldIndex = new int[this.m_TableDescriptor.NCompressedStringFields];
			}
			if (this.m_TableDescriptor.NIntFields > 0)
			{
				this.m_IntField = new int[this.m_TableDescriptor.NIntFields];
			}
		}

		// Token: 0x060008B3 RID: 2227 RVA: 0x0003328C File Offset: 0x0003148C
		public void LoadKeyFields(DbReader r)
		{
			if (this.m_TableDescriptor.NKeyFields > 0)
			{
				for (int i = 0; i < this.m_TableDescriptor.NKeyFields; i++)
				{
					this.m_KeyField[i] = r.ReadInt32();
				}
			}
		}

		// Token: 0x060008B4 RID: 2228 RVA: 0x000332CC File Offset: 0x000314CC
		public void LoadFloatFields(DbReader r)
		{
			if (this.m_TableDescriptor.NFloatFields > 0)
			{
				for (int i = 0; i < this.m_TableDescriptor.NFloatFields; i++)
				{
					this.m_FloatField[i] = r.ReadSingle();
				}
			}
		}

		// Token: 0x060008B5 RID: 2229 RVA: 0x0003330C File Offset: 0x0003150C
		public void LoadStringFields(DbReader r)
		{
			if (this.m_TableDescriptor.NStringFields > 0)
			{
				for (int i = 0; i < this.m_TableDescriptor.NStringFields; i++)
				{
					this.m_PtrToStringField[i] = r.ReadInt32();
					this.m_StringField[i] = FifaUtil.ReadString(r, this.m_PtrToStringField[i]);
				}
			}
		}

		// Token: 0x060008B6 RID: 2230 RVA: 0x00033364 File Offset: 0x00031564
		public bool LoadIntFields(DbReader r)
		{
			int num = 0;
			byte b = 0;
			bool flag = true;
			int num2 = 0;
			for (int i = 0; i < this.m_TableDescriptor.NIntFields; i++)
			{
				uint num3 = (uint)(this.m_TableDescriptor.MaxValues[i] - this.m_TableDescriptor.MinValues[i]);
				int num4 = FifaUtil.ComputeBitUsed(num3);
				if (num4 == 32)
				{
					this.m_IntField[i] = r.ReadInt32();
				}
				else
				{
					int num5 = 0;
					uint num6 = 0U;
					while ((ulong)num6 < (ulong)((long)num4))
					{
						if (num == 0)
						{
							b = r.ReadByte();
							num = 8;
							num2++;
						}
						num5 *= 2;
						if (((int)b & (1 << num - 1)) != 0)
						{
							num5++;
						}
						num--;
						num6 += 1U;
					}
					this.m_IntField[i] = num5 + this.m_TableDescriptor.MinValues[i];
					bool flag2 = this.m_IntField[i] <= this.m_TableDescriptor.MaxValues[i];
				}
			}
			return flag;
		}

		// Token: 0x060008B7 RID: 2231 RVA: 0x00033458 File Offset: 0x00031658
		public bool LoadCompressedStrings(DbReader r)
		{
			long position = r.BaseStream.Position;
			for (int i = 0; i < this.m_TableDescriptor.NCompressedStringFields; i++)
			{
				int num = this.m_CompressedStringFieldIndex[i];
				short num2 = 0;
				if (this.m_CompressedStringOffset[i] != -1)
				{
					r.BaseStream.Position = position + (long)this.m_CompressedStringOffset[i];
					switch (this.m_TableDescriptor.FieldDescriptors[num].FieldType)
					{
					case FieldDescriptor.EFieldTypes.ShortCompressedString:
						num2 = (short)r.ReadByte();
						break;
					case FieldDescriptor.EFieldTypes.LongCompressedString:
						num2 = r.ReadInt16();
						num2 = FifaUtil.SwapEndian(num2);
						break;
					}
				}
				this.m_CompressedString[i] = this.m_TableDescriptor.HuffmannTree.ReadString(r, (int)num2);
			}
			return true;
		}

		// Token: 0x060008B8 RID: 2232 RVA: 0x00033518 File Offset: 0x00031718
		public bool Load(DbReader r)
		{
			long position = r.BaseStream.Position;
			int recordSize = this.m_TableDescriptor.RecordSize;
			for (int i = 0; i < this.m_TableDescriptor.NFields; i++)
			{
				int num = this.m_TableDescriptor.FieldDescriptors[i].BitOffset / 8;
				int typeIndex = this.m_TableDescriptor.FieldDescriptors[i].TypeIndex;
				FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
				{
					r.Align(position + (long)num);
					int num2 = this.m_TableDescriptor.FieldDescriptors[i].Depth / 8;
					this.m_StringField[typeIndex] = FifaUtil.ReadNullPaddedString(r, num2);
					break;
				}
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
					this.m_IntField[typeIndex] = r.PopInteger(this.m_TableDescriptor.FieldDescriptors[i]);
					break;
				case FieldDescriptor.EFieldTypes.Float:
					r.Align(position + (long)num);
					this.m_FloatField[typeIndex] = r.ReadSingle();
					break;
				default:
					switch (fieldType)
					{
					case FieldDescriptor.EFieldTypes.ShortCompressedString:
					case FieldDescriptor.EFieldTypes.LongCompressedString:
					{
						r.Align(position + (long)num);
						int num3 = this.m_TableDescriptor.FieldDescriptors[i].Depth / 8;
						int num4 = r.ReadInt32();
						this.m_CompressedStringOffset[typeIndex] = num4;
						this.m_CompressedStringFieldIndex[typeIndex] = i;
						if (num4 != -1 && num4 < Record.m_HuffmannTreeSize)
						{
							Record.m_HuffmannTreeSize = num4;
						}
						if (i < this.m_TableDescriptor.NFields - 1 && this.m_TableDescriptor.FieldDescriptors[i + 1].BitOffset != 32)
						{
							r.Align(position + (long)(this.m_TableDescriptor.FieldDescriptors[i + 1].BitOffset / 8));
						}
						break;
					}
					}
					break;
				}
			}
			r.Align(position + (long)recordSize);
			return true;
		}

		// Token: 0x060008B9 RID: 2233 RVA: 0x000336E0 File Offset: 0x000318E0
		public void Fill(DbWriter w)
		{
			for (int i = 0; i < this.m_TableDescriptor.RecordSize; i++)
			{
				w.Write(205);
			}
		}

		// Token: 0x060008BA RID: 2234 RVA: 0x00033710 File Offset: 0x00031910
		public int Save(DbWriter w, long compressedStringBasePosition, int compressedStringOffset)
		{
			long position = w.BaseStream.Position;
			long num = position + (long)this.m_TableDescriptor.RecordSize;
			int recordSize = this.m_TableDescriptor.RecordSize;
			for (int i = 0; i < this.m_TableDescriptor.NFields; i++)
			{
				int num2 = this.m_TableDescriptor.FieldDescriptors[i].BitOffset / 8;
				int typeIndex = this.m_TableDescriptor.FieldDescriptors[i].TypeIndex;
				FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
				{
					w.WritePendingByte();
					w.BaseStream.Position = position + (long)num2;
					int num3 = this.m_TableDescriptor.FieldDescriptors[i].Depth / 8;
					FifaUtil.WriteNullPaddedString(w, this.m_StringField[typeIndex], num3);
					break;
				}
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
					w.PushInteger(this.m_IntField[typeIndex], this.m_TableDescriptor.FieldDescriptors[i]);
					break;
				case FieldDescriptor.EFieldTypes.Float:
					w.WritePendingByte();
					w.BaseStream.Position = position + (long)num2;
					w.Write(this.m_FloatField[typeIndex]);
					break;
				default:
					switch (fieldType)
					{
					case FieldDescriptor.EFieldTypes.ShortCompressedString:
						w.WritePendingByte();
						w.BaseStream.Position = position + (long)num2;
						if (this.m_CompressedString[typeIndex] == string.Empty)
						{
							w.Write(-1);
						}
						else
						{
							w.Write(compressedStringOffset);
						}
						w.BaseStream.Position = compressedStringBasePosition + (long)compressedStringOffset;
						compressedStringOffset += this.m_TableDescriptor.HuffmannTree.WriteString(w, this.m_CompressedString[typeIndex], false);
						w.BaseStream.Position = position + (long)num2 + 4L;
						break;
					case FieldDescriptor.EFieldTypes.LongCompressedString:
						w.WritePendingByte();
						w.BaseStream.Position = position + (long)num2;
						if (this.m_CompressedString[typeIndex] == string.Empty)
						{
							w.Write(-1);
						}
						else
						{
							w.Write(compressedStringOffset);
						}
						w.BaseStream.Position = compressedStringBasePosition + (long)compressedStringOffset;
						compressedStringOffset += this.m_TableDescriptor.HuffmannTree.WriteString(w, this.m_CompressedString[typeIndex], true);
						w.BaseStream.Position = position + (long)num2 + 4L;
						break;
					}
					break;
				}
			}
			w.WritePendingByte();
			w.Align(num);
			return compressedStringOffset;
		}

		// Token: 0x060008BB RID: 2235 RVA: 0x00033960 File Offset: 0x00031B60
		public void SaveKeyFields(BinaryWriter w)
		{
			if (this.m_TableDescriptor.NKeyFields > 0)
			{
				for (int i = 0; i < this.m_TableDescriptor.NKeyFields; i++)
				{
					w.Write(this.m_KeyField[i]);
				}
			}
		}

		// Token: 0x060008BC RID: 2236 RVA: 0x000339A0 File Offset: 0x00031BA0
		public void SaveFloatFields(BinaryWriter w)
		{
			if (this.m_TableDescriptor.NFloatFields > 0)
			{
				for (int i = 0; i < this.m_TableDescriptor.NFloatFields; i++)
				{
					w.Write(this.m_FloatField[i]);
				}
			}
		}

		// Token: 0x060008BD RID: 2237 RVA: 0x000339E0 File Offset: 0x00031BE0
		public void SaveIntFields(BinaryWriter w)
		{
			if (this.m_TableDescriptor.NIntFields > 0)
			{
				int num = 8;
				byte b = 0;
				for (int i = 0; i < this.m_TableDescriptor.NIntFields; i++)
				{
					uint num2 = (uint)(this.m_TableDescriptor.MaxValues[i] - this.m_TableDescriptor.MinValues[i]);
					int num3 = FifaUtil.ComputeBitUsed(num2);
					if (num3 == 32)
					{
						w.Write(this.m_IntField[i]);
					}
					else
					{
						int num4 = this.m_IntField[i] - this.m_TableDescriptor.MinValues[i];
						for (int j = num3 - 1; j >= 0; j--)
						{
							b *= 2;
							if ((num4 & (1 << j)) != 0)
							{
								b += 1;
							}
							num--;
							if (num == 0)
							{
								w.Write(b);
								num = 8;
								b = 0;
							}
						}
					}
				}
				if (num != 8)
				{
					b = (byte)(b << num);
					w.Write(b);
				}
			}
		}

		// Token: 0x060008BE RID: 2238 RVA: 0x00033AC0 File Offset: 0x00031CC0
		public object[] ConvertToDataRow()
		{
			object[] array = new object[this.m_TableDescriptor.NFields];
			for (int i = 0; i < this.m_TableDescriptor.NFields; i++)
			{
				int typeIndex = this.m_TableDescriptor.FieldDescriptors[i].TypeIndex;
				FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
					array[i] = this.m_StringField[typeIndex];
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
					array[i] = this.m_IntField[typeIndex];
					break;
				case FieldDescriptor.EFieldTypes.Float:
					array[i] = this.m_FloatField[typeIndex];
					break;
				default:
					switch (fieldType)
					{
					case FieldDescriptor.EFieldTypes.ShortCompressedString:
					case FieldDescriptor.EFieldTypes.LongCompressedString:
						array[i] = this.m_CompressedString[typeIndex];
						break;
					}
					break;
				}
			}
			return array;
		}

		// Token: 0x060008BF RID: 2239 RVA: 0x00033B8C File Offset: 0x00031D8C
		public void ConvertFromDataRow(DataRow dataRow)
		{
			for (int i = 0; i < this.m_TableDescriptor.NFields; i++)
			{
				int typeIndex = this.m_TableDescriptor.FieldDescriptors[i].TypeIndex;
				FieldDescriptor.EFieldTypes fieldType = this.m_TableDescriptor.FieldDescriptors[i].FieldType;
				switch (fieldType)
				{
				case FieldDescriptor.EFieldTypes.String:
					this.m_StringField[typeIndex] = Convert.ToString(dataRow.ItemArray[i]);
					break;
				case (FieldDescriptor.EFieldTypes)1:
				case (FieldDescriptor.EFieldTypes)2:
					break;
				case FieldDescriptor.EFieldTypes.Integer:
				{
					int num = Convert.ToInt32(dataRow.ItemArray[i]);
					this.m_IntField[typeIndex] = num;
					break;
				}
				case FieldDescriptor.EFieldTypes.Float:
					this.m_FloatField[typeIndex] = Convert.ToSingle(dataRow.ItemArray[i], NumberFormatInfo.InvariantInfo);
					break;
				default:
					switch (fieldType)
					{
					case FieldDescriptor.EFieldTypes.ShortCompressedString:
					case FieldDescriptor.EFieldTypes.LongCompressedString:
						this.m_CompressedString[typeIndex] = Convert.ToString(dataRow.ItemArray[i]);
						break;
					}
					break;
				}
			}
		}

		// Token: 0x060008C0 RID: 2240 RVA: 0x00033C6C File Offset: 0x00031E6C
		public bool IsEmptyDataRow(DataRow dataRow)
		{
			int nkeyFields = this.m_TableDescriptor.NKeyFields;
			int nstringFields = this.m_TableDescriptor.NStringFields;
			int nfloatFields = this.m_TableDescriptor.NFloatFields;
			int nintFields = this.m_TableDescriptor.NIntFields;
			int num = nkeyFields + nstringFields + nfloatFields + nintFields;
			int num2 = 0;
			for (int i = 0; i < nkeyFields; i++)
			{
				this.m_KeyField[i] = Convert.ToInt32(dataRow.ItemArray[num2++]);
				if (this.m_KeyField[i] != 0)
				{
					return false;
				}
			}
			for (int j = 0; j < nfloatFields; j++)
			{
				this.m_FloatField[j] = (float)Convert.ToDouble(dataRow.ItemArray[num2++]);
				if ((double)this.m_FloatField[j] != 0.0)
				{
					return false;
				}
			}
			for (int k = 0; k < nstringFields; k++)
			{
				if (dataRow.ItemArray[num2] == DBNull.Value)
				{
					this.m_StringField[k] = string.Empty;
					num2++;
				}
				else
				{
					this.m_StringField[k] = (string)dataRow.ItemArray[num2++];
				}
				if (!string.IsNullOrEmpty(this.m_StringField[k]))
				{
					return false;
				}
			}
			for (int l = 0; l < nintFields; l++)
			{
				if (num2 < dataRow.ItemArray.Length)
				{
					this.m_IntField[l] = Convert.ToInt32(dataRow.ItemArray[num2++]);
					if (this.m_IntField[l] != 0)
					{
						return false;
					}
				}
			}
			return true;
		}

		// Token: 0x060008C1 RID: 2241 RVA: 0x00033DDC File Offset: 0x00031FDC
		public int GetAndCheckIntField(int index)
		{
			if (index < 0 || index >= this.m_IntField.Length)
			{
				return 0;
			}
			int num = this.m_IntField[index];
			if (this.m_TableDescriptor.MinValues[index] > this.m_TableDescriptor.MaxValues[index])
			{
				return num;
			}
			if (num < this.m_TableDescriptor.MinValues[index])
			{
				return this.m_TableDescriptor.MinValues[index];
			}
			if (num > this.m_TableDescriptor.MaxValues[index])
			{
				return this.m_TableDescriptor.MaxValues[index];
			}
			return num;
		}

		// Token: 0x060008C2 RID: 2242 RVA: 0x00033E60 File Offset: 0x00032060
		public string GetAndCheckStringField(int index)
		{
			if (index < 0 || index >= this.m_StringField.Length)
			{
				return null;
			}
			return this.m_StringField[index];
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x00033E88 File Offset: 0x00032088
		public int GetAndCheckExtendedIntField(int index)
		{
			if (index < 0 || index >= this.m_IntField.Length)
			{
				return 0;
			}
			int num = this.m_IntField[index];
			if (this.m_TableDescriptor.MinValues[index] > this.m_TableDescriptor.MaxValues[index])
			{
				return num;
			}
			int num2 = this.m_TableDescriptor.MinValues[index];
			int num3 = this.m_TableDescriptor.MaxValues[index];
			uint num4 = (uint)(num3 - num2);
			if (num4 != 0U)
			{
				int num5 = FifaUtil.ComputeBitUsed(num4);
				num3 = num2 + (1 << num5) - 1;
			}
			if (num < num2)
			{
				return num2;
			}
			if (num > num3)
			{
				return num3;
			}
			return num;
		}

		// Token: 0x0400038B RID: 907
		private int[] m_CompressedStringOffset;

		// Token: 0x0400038C RID: 908
		private int[] m_CompressedStringFieldIndex;

		// Token: 0x0400038D RID: 909
		private string[] m_CompressedString;

		// Token: 0x0400038E RID: 910
		private static int m_HuffmannTreeSize;

		// Token: 0x0400038F RID: 911
		private int[] m_KeyField;

		// Token: 0x04000390 RID: 912
		private float[] m_FloatField;

		// Token: 0x04000391 RID: 913
		private int[] m_PtrToStringField;

		// Token: 0x04000392 RID: 914
		private int[] m_IntField;

		// Token: 0x04000393 RID: 915
		private TableDescriptor m_TableDescriptor;

		// Token: 0x04000394 RID: 916
		private string[] m_StringField;
	}
}
