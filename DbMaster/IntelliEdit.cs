using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using FifaLibrary;

namespace DbMaster
{
	// Token: 0x02000003 RID: 3
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[XmlRoot("IntelliEdit")]
	[ToolboxItem(true)]
	[Serializable]
	public class IntelliEdit : DataSet
	{
		// Token: 0x06000002 RID: 2 RVA: 0x00002068 File Offset: 0x00000268
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public IntelliEdit()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			base.Relations.CollectionChanged += collectionChangeEventHandler;
			base.EndInit();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x000020BC File Offset: 0x000002BC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected IntelliEdit(SerializationInfo info, StreamingContext context)
			: base(info, context, false)
		{
			if (base.IsBinarySerialized(info, context))
			{
				this.InitVars(false);
				CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
				this.Tables.CollectionChanged += collectionChangeEventHandler;
				this.Relations.CollectionChanged += collectionChangeEventHandler;
				return;
			}
			string text = (string)info.GetValue("XmlSchema", typeof(string));
			if (base.DetermineSchemaSerializationMode(info, context) == SchemaSerializationMode.IncludeSchema)
			{
				DataSet dataSet = new DataSet();
				dataSet.ReadXmlSchema(new XmlTextReader(new StringReader(text)));
				if (dataSet.Tables["CrossTable"] != null)
				{
					base.Tables.Add(new IntelliEdit.CrossTableDataTable(dataSet.Tables["CrossTable"]));
				}
				if (dataSet.Tables["DomainList"] != null)
				{
					base.Tables.Add(new IntelliEdit.DomainListDataTable(dataSet.Tables["DomainList"]));
				}
				if (dataSet.Tables["UseDomain"] != null)
				{
					base.Tables.Add(new IntelliEdit.UseDomainDataTable(dataSet.Tables["UseDomain"]));
				}
				if (dataSet.Tables["DoubleCrossTable"] != null)
				{
					base.Tables.Add(new IntelliEdit.DoubleCrossTableDataTable(dataSet.Tables["DoubleCrossTable"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
			}
			else
			{
				base.ReadXmlSchema(new XmlTextReader(new StringReader(text)));
			}
			base.GetSerializationData(info, context);
			CollectionChangeEventHandler collectionChangeEventHandler2 = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler2;
			this.Relations.CollectionChanged += collectionChangeEventHandler2;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000004 RID: 4 RVA: 0x000022AF File Offset: 0x000004AF
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		public IntelliEdit.CrossTableDataTable CrossTable
		{
			get
			{
				return this.tableCrossTable;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000005 RID: 5 RVA: 0x000022B7 File Offset: 0x000004B7
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public IntelliEdit.DomainListDataTable DomainList
		{
			get
			{
				return this.tableDomainList;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000006 RID: 6 RVA: 0x000022BF File Offset: 0x000004BF
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		public IntelliEdit.UseDomainDataTable UseDomain
		{
			get
			{
				return this.tableUseDomain;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000007 RID: 7 RVA: 0x000022C7 File Offset: 0x000004C7
		[Browsable(false)]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public IntelliEdit.DoubleCrossTableDataTable DoubleCrossTable
		{
			get
			{
				return this.tableDoubleCrossTable;
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000008 RID: 8 RVA: 0x000022CF File Offset: 0x000004CF
		// (set) Token: 0x06000009 RID: 9 RVA: 0x000022D7 File Offset: 0x000004D7
		[Browsable(true)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600000A RID: 10 RVA: 0x000022E0 File Offset: 0x000004E0
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600000B RID: 11 RVA: 0x000022E8 File Offset: 0x000004E8
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000022F0 File Offset: 0x000004F0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002304 File Offset: 0x00000504
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			IntelliEdit intelliEdit = (IntelliEdit)base.Clone();
			intelliEdit.InitVars();
			intelliEdit.SchemaSerializationMode = this.SchemaSerializationMode;
			return intelliEdit;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002330 File Offset: 0x00000530
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002333 File Offset: 0x00000533
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002338 File Offset: 0x00000538
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["CrossTable"] != null)
				{
					base.Tables.Add(new IntelliEdit.CrossTableDataTable(dataSet.Tables["CrossTable"]));
				}
				if (dataSet.Tables["DomainList"] != null)
				{
					base.Tables.Add(new IntelliEdit.DomainListDataTable(dataSet.Tables["DomainList"]));
				}
				if (dataSet.Tables["UseDomain"] != null)
				{
					base.Tables.Add(new IntelliEdit.UseDomainDataTable(dataSet.Tables["UseDomain"]));
				}
				if (dataSet.Tables["DoubleCrossTable"] != null)
				{
					base.Tables.Add(new IntelliEdit.DoubleCrossTableDataTable(dataSet.Tables["DoubleCrossTable"]));
				}
				base.DataSetName = dataSet.DataSetName;
				base.Prefix = dataSet.Prefix;
				base.Namespace = dataSet.Namespace;
				base.Locale = dataSet.Locale;
				base.CaseSensitive = dataSet.CaseSensitive;
				base.EnforceConstraints = dataSet.EnforceConstraints;
				base.Merge(dataSet, false, MissingSchemaAction.Add);
				this.InitVars();
				return;
			}
			base.ReadXml(reader);
			this.InitVars();
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002494 File Offset: 0x00000694
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000024C8 File Offset: 0x000006C8
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000024D4 File Offset: 0x000006D4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableCrossTable = (IntelliEdit.CrossTableDataTable)base.Tables["CrossTable"];
			if (initTable && this.tableCrossTable != null)
			{
				this.tableCrossTable.InitVars();
			}
			this.tableDomainList = (IntelliEdit.DomainListDataTable)base.Tables["DomainList"];
			if (initTable && this.tableDomainList != null)
			{
				this.tableDomainList.InitVars();
			}
			this.tableUseDomain = (IntelliEdit.UseDomainDataTable)base.Tables["UseDomain"];
			if (initTable && this.tableUseDomain != null)
			{
				this.tableUseDomain.InitVars();
			}
			this.tableDoubleCrossTable = (IntelliEdit.DoubleCrossTableDataTable)base.Tables["DoubleCrossTable"];
			if (initTable && this.tableDoubleCrossTable != null)
			{
				this.tableDoubleCrossTable.InitVars();
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000025A8 File Offset: 0x000007A8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "IntelliEdit";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/IntelliEdit.xsd";
			base.Locale = new CultureInfo("it-IT");
			base.EnforceConstraints = false;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableCrossTable = new IntelliEdit.CrossTableDataTable();
			base.Tables.Add(this.tableCrossTable);
			this.tableDomainList = new IntelliEdit.DomainListDataTable();
			base.Tables.Add(this.tableDomainList);
			this.tableUseDomain = new IntelliEdit.UseDomainDataTable();
			base.Tables.Add(this.tableUseDomain);
			this.tableDoubleCrossTable = new IntelliEdit.DoubleCrossTableDataTable();
			base.Tables.Add(this.tableDoubleCrossTable);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002664 File Offset: 0x00000864
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeCrossTable()
		{
			return false;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002667 File Offset: 0x00000867
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private bool ShouldSerializeDomainList()
		{
			return false;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000266A File Offset: 0x0000086A
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeUseDomain()
		{
			return false;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000266D File Offset: 0x0000086D
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeDoubleCrossTable()
		{
			return false;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002670 File Offset: 0x00000870
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002684 File Offset: 0x00000884
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			IntelliEdit intelliEdit = new IntelliEdit();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = intelliEdit.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = intelliEdit.GetSchemaSerializable();
			if (xs.Contains(schemaSerializable.TargetNamespace))
			{
				MemoryStream memoryStream = new MemoryStream();
				MemoryStream memoryStream2 = new MemoryStream();
				try
				{
					schemaSerializable.Write(memoryStream);
					foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
					{
						XmlSchema xmlSchema = (XmlSchema)obj;
						memoryStream2.SetLength(0L);
						xmlSchema.Write(memoryStream2);
						if (memoryStream.Length == memoryStream2.Length)
						{
							memoryStream.Position = 0L;
							memoryStream2.Position = 0L;
							while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
							{
							}
							if (memoryStream.Position == memoryStream.Length)
							{
								return xmlSchemaComplexType;
							}
						}
					}
				}
				finally
				{
					if (memoryStream != null)
					{
						memoryStream.Close();
					}
					if (memoryStream2 != null)
					{
						memoryStream2.Close();
					}
				}
			}
			xs.Add(schemaSerializable);
			return xmlSchemaComplexType;
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001B RID: 27 RVA: 0x000027CC File Offset: 0x000009CC
		public string RelatedTableName
		{
			get
			{
				return this.m_RelatedTableName;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001C RID: 28 RVA: 0x000027D4 File Offset: 0x000009D4
		public string IntermediateTableName
		{
			get
			{
				return this.m_IntermediateTableName;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x000027DC File Offset: 0x000009DC
		// (set) Token: 0x0600001E RID: 30 RVA: 0x000027E4 File Offset: 0x000009E4
		public string[] RelatedKey
		{
			get
			{
				return this.m_RelatedKey;
			}
			set
			{
				this.m_RelatedKey = value;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001F RID: 31 RVA: 0x000027ED File Offset: 0x000009ED
		// (set) Token: 0x06000020 RID: 32 RVA: 0x000027F5 File Offset: 0x000009F5
		public string[] RelatedDisplay
		{
			get
			{
				return this.m_RelatedDisplay;
			}
			set
			{
				this.m_RelatedDisplay = value;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000021 RID: 33 RVA: 0x000027FE File Offset: 0x000009FE
		// (set) Token: 0x06000022 RID: 34 RVA: 0x00002806 File Offset: 0x00000A06
		public bool IsValid
		{
			get
			{
				return this.m_IsValid;
			}
			set
			{
				this.m_IsValid = value;
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002810 File Offset: 0x00000A10
		public IntelliEdit(string sourceTable, string sourceColumn, string relatedTable, string keyColumn, string displayColumn)
		{
			this.m_SourceTableName = sourceTable;
			this.m_SourceColumnName = sourceColumn;
			this.m_RelatedTableName = relatedTable;
			this.m_KeyColumnName = keyColumn;
			this.m_DisplayColumnName = displayColumn;
			this.m_IntermediateTableName = null;
			this.m_IntermediateJumpColumnName = null;
			this.m_IntermediateKeyColumnName = null;
			this.m_DomainList = null;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000286B File Offset: 0x00000A6B
		public IntelliEdit(string sourceTable, string sourceColumn, string[] domainList)
		{
			this.m_SourceTableName = sourceTable;
			this.m_SourceColumnName = sourceColumn;
			this.m_DomainList = domainList;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002890 File Offset: 0x00000A90
		public IntelliEdit(string sourceTable, string sourceColumn, string intermediateTable, string intermediateKeyColumn, string intermediateJumpColumn, string relatedTable, string keyColumn, string displayColumn)
		{
			this.m_SourceTableName = sourceTable;
			this.m_SourceColumnName = sourceColumn;
			this.m_IntermediateTableName = intermediateTable;
			this.m_IntermediateKeyColumnName = intermediateKeyColumn;
			this.m_IntermediateJumpColumnName = intermediateJumpColumn;
			this.m_RelatedTableName = relatedTable;
			this.m_KeyColumnName = keyColumn;
			this.m_DisplayColumnName = displayColumn;
			this.m_DomainList = null;
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000028F0 File Offset: 0x00000AF0
		public bool Apply(DataSet dataSet)
		{
			int num = 0;
			int num2 = 0;
			int num3 = -1;
			int num4 = -1;
			int num5 = -1;
			int num6 = -1;
			int num7 = -1;
			int num8 = -1;
			if (this.m_DomainList != null)
			{
				this.m_IsValid = this.m_DomainList.Length > 0;
				return true;
			}
			for (int i = 0; i < dataSet.Tables.Count; i++)
			{
				if (dataSet.Tables[i].TableName == this.m_IntermediateTableName)
				{
					num3 = i;
					num = dataSet.Tables[i].Rows.Count;
					for (int j = 0; j < dataSet.Tables[i].Columns.Count; j++)
					{
						if (dataSet.Tables[num3].Columns[j].ColumnName == this.m_IntermediateKeyColumnName)
						{
							num4 = j;
						}
						if (dataSet.Tables[num3].Columns[j].ColumnName == this.m_IntermediateJumpColumnName)
						{
							num5 = j;
						}
					}
				}
				if (dataSet.Tables[i].TableName == this.m_RelatedTableName)
				{
					num6 = i;
					num2 = dataSet.Tables[i].Rows.Count;
					for (int k = 0; k < dataSet.Tables[i].Columns.Count; k++)
					{
						if (dataSet.Tables[num6].Columns[k].ColumnName == this.m_KeyColumnName)
						{
							num7 = k;
						}
						if (dataSet.Tables[num6].Columns[k].ColumnName == this.m_DisplayColumnName)
						{
							num8 = k;
						}
					}
				}
			}
			if (num7 == -1 || num8 == -1)
			{
				this.m_IsValid = false;
				return this.m_IsValid;
			}
			if (num3 != -1)
			{
				if (num4 == -1 || num5 == -1)
				{
					this.m_IsValid = false;
					return this.m_IsValid;
				}
				this.m_RelatedKey = new string[num];
				for (int l = 0; l < this.m_RelatedKey.Length; l++)
				{
					this.m_RelatedKey[l] = dataSet.Tables[num3].Rows[l].ItemArray[num4].ToString();
				}
			}
			else
			{
				this.m_RelatedKey = new string[num2];
				for (int m = 0; m < this.m_RelatedKey.Length; m++)
				{
					this.m_RelatedKey[m] = dataSet.Tables[num6].Rows[m].ItemArray[num7].ToString();
				}
			}
			this.m_RelatedDisplay = new string[this.m_RelatedKey.Length];
			for (int n = 0; n < this.m_RelatedKey.Length; n++)
			{
				this.m_RelatedDisplay[n] = string.Empty;
			}
			for (int num9 = 0; num9 < this.m_RelatedKey.Length; num9++)
			{
				int num10 = num9;
				if (num3 != -1)
				{
					num10 = (int)dataSet.Tables[num3].Rows[num9].ItemArray[num5];
					for (int num11 = ((num10 < dataSet.Tables[num6].Rows.Count) ? num10 : (dataSet.Tables[num6].Rows.Count - 1)); num11 >= 0; num11--)
					{
						if (num10 == (int)dataSet.Tables[num6].Rows[num11].ItemArray[num7])
						{
							this.m_RelatedDisplay[num9] = dataSet.Tables[num6].Rows[num11].ItemArray[num8].ToString() + " (" + this.m_RelatedKey[num9] + ")";
							break;
						}
					}
				}
				else if (num10 < dataSet.Tables[num6].Rows.Count)
				{
					this.m_RelatedDisplay[num9] = dataSet.Tables[num6].Rows[num10].ItemArray[num8].ToString();
				}
			}
			this.m_IsValid = true;
			return this.m_IsValid;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002D3D File Offset: 0x00000F3D
		public void InitShow(ComboBox combo, DateTimePicker dateTimePicker)
		{
			combo.Items.Clear();
			if (this.m_RelatedDisplay != null)
			{
				combo.Items.AddRange(this.m_RelatedDisplay);
				return;
			}
			if (this.m_DomainList != null)
			{
				combo.Items.AddRange(this.m_DomainList);
			}
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002D80 File Offset: 0x00000F80
		public void Show(ComboBox combo, DateTimePicker dateTimePicker, string key, int minValue)
		{
			if (string.IsNullOrEmpty(key))
			{
				return;
			}
			if (this.m_DomainList != null && this.m_DomainList[0] != "date")
			{
				key = (Convert.ToInt32(key) - minValue).ToString();
			}
			this.Show(combo, dateTimePicker, key);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002DD0 File Offset: 0x00000FD0
		public void Show(ComboBox combo, DateTimePicker dateTimePicker, string key)
		{
			if (this.m_RelatedDisplay != null)
			{
				combo.Visible = true;
				dateTimePicker.Visible = false;
				int i;
				for (i = 0; i < this.m_RelatedKey.Length; i++)
				{
					if (this.m_RelatedKey[i] == key)
					{
						combo.SelectedIndex = i;
						break;
					}
				}
				if (i == this.m_RelatedKey.Length)
				{
					combo.SelectedIndex = -1;
					combo.Text = "not found";
					return;
				}
			}
			else if (this.m_DomainList != null)
			{
				if (this.m_DomainList[0] == "date")
				{
					combo.Visible = false;
					dateTimePicker.Visible = true;
					DateTime dateTime = FifaUtil.ConvertToDate(Convert.ToInt32(key));
					dateTimePicker.Value = dateTime;
					return;
				}
				combo.Visible = true;
				dateTimePicker.Visible = false;
				int i = Convert.ToInt32(key);
				if (i >= 0 && i < combo.Items.Count)
				{
					combo.SelectedIndex = i;
					return;
				}
				combo.SelectedIndex = -1;
				combo.Text = "not found";
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002EBF File Offset: 0x000010BF
		public object GetRelatedKey(int comboIndex)
		{
			if (this.m_RelatedKey != null)
			{
				return this.m_RelatedKey[comboIndex];
			}
			if (this.m_DomainList != null)
			{
				return comboIndex;
			}
			return null;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002EE4 File Offset: 0x000010E4
		public object GetRelatedKey(int comboIndex, int minValue)
		{
			if (this.m_RelatedKey != null)
			{
				return this.m_RelatedKey[comboIndex];
			}
			if (this.m_DomainList != null)
			{
				int num = comboIndex + minValue;
				return num;
			}
			return null;
		}

		// Token: 0x0600002C RID: 44 RVA: 0x00002F16 File Offset: 0x00001116
		public bool AreYou(string tableName, string columnName)
		{
			return this.m_SourceTableName == tableName && this.m_SourceColumnName == columnName && this.m_IsValid;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00002F3C File Offset: 0x0000113C
		public bool IsUsed(string tableName)
		{
			return this.m_SourceTableName == tableName;
		}

		// Token: 0x04000001 RID: 1
		private IntelliEdit.CrossTableDataTable tableCrossTable;

		// Token: 0x04000002 RID: 2
		private IntelliEdit.DomainListDataTable tableDomainList;

		// Token: 0x04000003 RID: 3
		private IntelliEdit.UseDomainDataTable tableUseDomain;

		// Token: 0x04000004 RID: 4
		private IntelliEdit.DoubleCrossTableDataTable tableDoubleCrossTable;

		// Token: 0x04000005 RID: 5
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x04000006 RID: 6
		private string m_SourceTableName;

		// Token: 0x04000007 RID: 7
		private string m_SourceColumnName;

		// Token: 0x04000008 RID: 8
		private string m_RelatedTableName;

		// Token: 0x04000009 RID: 9
		private string m_KeyColumnName;

		// Token: 0x0400000A RID: 10
		private string m_DisplayColumnName;

		// Token: 0x0400000B RID: 11
		private string m_IntermediateTableName;

		// Token: 0x0400000C RID: 12
		private string m_IntermediateJumpColumnName;

		// Token: 0x0400000D RID: 13
		private string m_IntermediateKeyColumnName;

		// Token: 0x0400000E RID: 14
		private string[] m_RelatedKey;

		// Token: 0x0400000F RID: 15
		private string[] m_RelatedDisplay;

		// Token: 0x04000010 RID: 16
		private string[] m_DomainList;

		// Token: 0x04000011 RID: 17
		private bool m_IsValid;

		// Token: 0x02000004 RID: 4
		// (Invoke) Token: 0x0600002F RID: 47
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void CrossTableRowChangeEventHandler(object sender, IntelliEdit.CrossTableRowChangeEvent e);

		// Token: 0x02000005 RID: 5
		// (Invoke) Token: 0x06000033 RID: 51
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DomainListRowChangeEventHandler(object sender, IntelliEdit.DomainListRowChangeEvent e);

		// Token: 0x02000006 RID: 6
		// (Invoke) Token: 0x06000037 RID: 55
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void UseDomainRowChangeEventHandler(object sender, IntelliEdit.UseDomainRowChangeEvent e);

		// Token: 0x02000007 RID: 7
		// (Invoke) Token: 0x0600003B RID: 59
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DoubleCrossTableRowChangeEventHandler(object sender, IntelliEdit.DoubleCrossTableRowChangeEvent e);

		// Token: 0x02000008 RID: 8
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CrossTableDataTable : TypedTableBase<IntelliEdit.CrossTableRow>
		{
			// Token: 0x0600003E RID: 62 RVA: 0x00002F4A File Offset: 0x0000114A
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public CrossTableDataTable()
			{
				base.TableName = "CrossTable";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x0600003F RID: 63 RVA: 0x00002F70 File Offset: 0x00001170
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal CrossTableDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000040 RID: 64 RVA: 0x00003018 File Offset: 0x00001218
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected CrossTableDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700000D RID: 13
			// (get) Token: 0x06000041 RID: 65 RVA: 0x00003028 File Offset: 0x00001228
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SourceTableColumn
			{
				get
				{
					return this.columnSourceTable;
				}
			}

			// Token: 0x1700000E RID: 14
			// (get) Token: 0x06000042 RID: 66 RVA: 0x00003030 File Offset: 0x00001230
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SourceColumnColumn
			{
				get
				{
					return this.columnSourceColumn;
				}
			}

			// Token: 0x1700000F RID: 15
			// (get) Token: 0x06000043 RID: 67 RVA: 0x00003038 File Offset: 0x00001238
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ReferredTableColumn
			{
				get
				{
					return this.columnReferredTable;
				}
			}

			// Token: 0x17000010 RID: 16
			// (get) Token: 0x06000044 RID: 68 RVA: 0x00003040 File Offset: 0x00001240
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn KeyColumnColumn
			{
				get
				{
					return this.columnKeyColumn;
				}
			}

			// Token: 0x17000011 RID: 17
			// (get) Token: 0x06000045 RID: 69 RVA: 0x00003048 File Offset: 0x00001248
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DisplayColumnColumn
			{
				get
				{
					return this.columnDisplayColumn;
				}
			}

			// Token: 0x17000012 RID: 18
			// (get) Token: 0x06000046 RID: 70 RVA: 0x00003050 File Offset: 0x00001250
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			[DebuggerNonUserCode]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000013 RID: 19
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public IntelliEdit.CrossTableRow this[int index]
			{
				get
				{
					return (IntelliEdit.CrossTableRow)base.Rows[index];
				}
			}

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x06000048 RID: 72 RVA: 0x00003070 File Offset: 0x00001270
			// (remove) Token: 0x06000049 RID: 73 RVA: 0x000030A8 File Offset: 0x000012A8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.CrossTableRowChangeEventHandler CrossTableRowChanging;

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x0600004A RID: 74 RVA: 0x000030E0 File Offset: 0x000012E0
			// (remove) Token: 0x0600004B RID: 75 RVA: 0x00003118 File Offset: 0x00001318
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.CrossTableRowChangeEventHandler CrossTableRowChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x0600004C RID: 76 RVA: 0x00003150 File Offset: 0x00001350
			// (remove) Token: 0x0600004D RID: 77 RVA: 0x00003188 File Offset: 0x00001388
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.CrossTableRowChangeEventHandler CrossTableRowDeleting;

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x0600004E RID: 78 RVA: 0x000031C0 File Offset: 0x000013C0
			// (remove) Token: 0x0600004F RID: 79 RVA: 0x000031F8 File Offset: 0x000013F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.CrossTableRowChangeEventHandler CrossTableRowDeleted;

			// Token: 0x06000050 RID: 80 RVA: 0x0000322D File Offset: 0x0000142D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddCrossTableRow(IntelliEdit.CrossTableRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000051 RID: 81 RVA: 0x0000323C File Offset: 0x0000143C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public IntelliEdit.CrossTableRow AddCrossTableRow(string SourceTable, string SourceColumn, string ReferredTable, string KeyColumn, string DisplayColumn)
			{
				IntelliEdit.CrossTableRow crossTableRow = (IntelliEdit.CrossTableRow)base.NewRow();
				object[] array = new object[] { SourceTable, SourceColumn, ReferredTable, KeyColumn, DisplayColumn };
				crossTableRow.ItemArray = array;
				base.Rows.Add(crossTableRow);
				return crossTableRow;
			}

			// Token: 0x06000052 RID: 82 RVA: 0x00003288 File Offset: 0x00001488
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				IntelliEdit.CrossTableDataTable crossTableDataTable = (IntelliEdit.CrossTableDataTable)base.Clone();
				crossTableDataTable.InitVars();
				return crossTableDataTable;
			}

			// Token: 0x06000053 RID: 83 RVA: 0x000032A8 File Offset: 0x000014A8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new IntelliEdit.CrossTableDataTable();
			}

			// Token: 0x06000054 RID: 84 RVA: 0x000032B0 File Offset: 0x000014B0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnSourceTable = base.Columns["SourceTable"];
				this.columnSourceColumn = base.Columns["SourceColumn"];
				this.columnReferredTable = base.Columns["ReferredTable"];
				this.columnKeyColumn = base.Columns["KeyColumn"];
				this.columnDisplayColumn = base.Columns["DisplayColumn"];
			}

			// Token: 0x06000055 RID: 85 RVA: 0x0000332C File Offset: 0x0000152C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnSourceTable = new DataColumn("SourceTable", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSourceTable);
				this.columnSourceColumn = new DataColumn("SourceColumn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSourceColumn);
				this.columnReferredTable = new DataColumn("ReferredTable", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnReferredTable);
				this.columnKeyColumn = new DataColumn("KeyColumn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKeyColumn);
				this.columnDisplayColumn = new DataColumn("DisplayColumn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDisplayColumn);
			}

			// Token: 0x06000056 RID: 86 RVA: 0x0000341A File Offset: 0x0000161A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public IntelliEdit.CrossTableRow NewCrossTableRow()
			{
				return (IntelliEdit.CrossTableRow)base.NewRow();
			}

			// Token: 0x06000057 RID: 87 RVA: 0x00003427 File Offset: 0x00001627
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new IntelliEdit.CrossTableRow(builder);
			}

			// Token: 0x06000058 RID: 88 RVA: 0x0000342F File Offset: 0x0000162F
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(IntelliEdit.CrossTableRow);
			}

			// Token: 0x06000059 RID: 89 RVA: 0x0000343B File Offset: 0x0000163B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CrossTableRowChanged != null)
				{
					this.CrossTableRowChanged(this, new IntelliEdit.CrossTableRowChangeEvent((IntelliEdit.CrossTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600005A RID: 90 RVA: 0x0000346E File Offset: 0x0000166E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CrossTableRowChanging != null)
				{
					this.CrossTableRowChanging(this, new IntelliEdit.CrossTableRowChangeEvent((IntelliEdit.CrossTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600005B RID: 91 RVA: 0x000034A1 File Offset: 0x000016A1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CrossTableRowDeleted != null)
				{
					this.CrossTableRowDeleted(this, new IntelliEdit.CrossTableRowChangeEvent((IntelliEdit.CrossTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600005C RID: 92 RVA: 0x000034D4 File Offset: 0x000016D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CrossTableRowDeleting != null)
				{
					this.CrossTableRowDeleting(this, new IntelliEdit.CrossTableRowChangeEvent((IntelliEdit.CrossTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600005D RID: 93 RVA: 0x00003507 File Offset: 0x00001707
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemoveCrossTableRow(IntelliEdit.CrossTableRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x0600005E RID: 94 RVA: 0x00003518 File Offset: 0x00001718
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				IntelliEdit intelliEdit = new IntelliEdit();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = intelliEdit.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CrossTableDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = intelliEdit.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000012 RID: 18
			private DataColumn columnSourceTable;

			// Token: 0x04000013 RID: 19
			private DataColumn columnSourceColumn;

			// Token: 0x04000014 RID: 20
			private DataColumn columnReferredTable;

			// Token: 0x04000015 RID: 21
			private DataColumn columnKeyColumn;

			// Token: 0x04000016 RID: 22
			private DataColumn columnDisplayColumn;
		}

		// Token: 0x02000009 RID: 9
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DomainListDataTable : TypedTableBase<IntelliEdit.DomainListRow>
		{
			// Token: 0x0600005F RID: 95 RVA: 0x00003710 File Offset: 0x00001910
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DomainListDataTable()
			{
				base.TableName = "DomainList";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000060 RID: 96 RVA: 0x00003738 File Offset: 0x00001938
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DomainListDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x06000061 RID: 97 RVA: 0x000037E0 File Offset: 0x000019E0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected DomainListDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000014 RID: 20
			// (get) Token: 0x06000062 RID: 98 RVA: 0x000037F0 File Offset: 0x000019F0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x17000015 RID: 21
			// (get) Token: 0x06000063 RID: 99 RVA: 0x000037F8 File Offset: 0x000019F8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn TotalValuesColumn
			{
				get
				{
					return this.columnTotalValues;
				}
			}

			// Token: 0x17000016 RID: 22
			// (get) Token: 0x06000064 RID: 100 RVA: 0x00003800 File Offset: 0x00001A00
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value0Column
			{
				get
				{
					return this.columnValue0;
				}
			}

			// Token: 0x17000017 RID: 23
			// (get) Token: 0x06000065 RID: 101 RVA: 0x00003808 File Offset: 0x00001A08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value1Column
			{
				get
				{
					return this.columnValue1;
				}
			}

			// Token: 0x17000018 RID: 24
			// (get) Token: 0x06000066 RID: 102 RVA: 0x00003810 File Offset: 0x00001A10
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value2Column
			{
				get
				{
					return this.columnValue2;
				}
			}

			// Token: 0x17000019 RID: 25
			// (get) Token: 0x06000067 RID: 103 RVA: 0x00003818 File Offset: 0x00001A18
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value3Column
			{
				get
				{
					return this.columnValue3;
				}
			}

			// Token: 0x1700001A RID: 26
			// (get) Token: 0x06000068 RID: 104 RVA: 0x00003820 File Offset: 0x00001A20
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value4Column
			{
				get
				{
					return this.columnValue4;
				}
			}

			// Token: 0x1700001B RID: 27
			// (get) Token: 0x06000069 RID: 105 RVA: 0x00003828 File Offset: 0x00001A28
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value5Column
			{
				get
				{
					return this.columnValue5;
				}
			}

			// Token: 0x1700001C RID: 28
			// (get) Token: 0x0600006A RID: 106 RVA: 0x00003830 File Offset: 0x00001A30
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value6Column
			{
				get
				{
					return this.columnValue6;
				}
			}

			// Token: 0x1700001D RID: 29
			// (get) Token: 0x0600006B RID: 107 RVA: 0x00003838 File Offset: 0x00001A38
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value7Column
			{
				get
				{
					return this.columnValue7;
				}
			}

			// Token: 0x1700001E RID: 30
			// (get) Token: 0x0600006C RID: 108 RVA: 0x00003840 File Offset: 0x00001A40
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value8Column
			{
				get
				{
					return this.columnValue8;
				}
			}

			// Token: 0x1700001F RID: 31
			// (get) Token: 0x0600006D RID: 109 RVA: 0x00003848 File Offset: 0x00001A48
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value9Column
			{
				get
				{
					return this.columnValue9;
				}
			}

			// Token: 0x17000020 RID: 32
			// (get) Token: 0x0600006E RID: 110 RVA: 0x00003850 File Offset: 0x00001A50
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value10Column
			{
				get
				{
					return this.columnValue10;
				}
			}

			// Token: 0x17000021 RID: 33
			// (get) Token: 0x0600006F RID: 111 RVA: 0x00003858 File Offset: 0x00001A58
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value11Column
			{
				get
				{
					return this.columnValue11;
				}
			}

			// Token: 0x17000022 RID: 34
			// (get) Token: 0x06000070 RID: 112 RVA: 0x00003860 File Offset: 0x00001A60
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value12Column
			{
				get
				{
					return this.columnValue12;
				}
			}

			// Token: 0x17000023 RID: 35
			// (get) Token: 0x06000071 RID: 113 RVA: 0x00003868 File Offset: 0x00001A68
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value13Column
			{
				get
				{
					return this.columnValue13;
				}
			}

			// Token: 0x17000024 RID: 36
			// (get) Token: 0x06000072 RID: 114 RVA: 0x00003870 File Offset: 0x00001A70
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value14Column
			{
				get
				{
					return this.columnValue14;
				}
			}

			// Token: 0x17000025 RID: 37
			// (get) Token: 0x06000073 RID: 115 RVA: 0x00003878 File Offset: 0x00001A78
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value15Column
			{
				get
				{
					return this.columnValue15;
				}
			}

			// Token: 0x17000026 RID: 38
			// (get) Token: 0x06000074 RID: 116 RVA: 0x00003880 File Offset: 0x00001A80
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value16Column
			{
				get
				{
					return this.columnValue16;
				}
			}

			// Token: 0x17000027 RID: 39
			// (get) Token: 0x06000075 RID: 117 RVA: 0x00003888 File Offset: 0x00001A88
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value17Column
			{
				get
				{
					return this.columnValue17;
				}
			}

			// Token: 0x17000028 RID: 40
			// (get) Token: 0x06000076 RID: 118 RVA: 0x00003890 File Offset: 0x00001A90
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value18Column
			{
				get
				{
					return this.columnValue18;
				}
			}

			// Token: 0x17000029 RID: 41
			// (get) Token: 0x06000077 RID: 119 RVA: 0x00003898 File Offset: 0x00001A98
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value19Column
			{
				get
				{
					return this.columnValue19;
				}
			}

			// Token: 0x1700002A RID: 42
			// (get) Token: 0x06000078 RID: 120 RVA: 0x000038A0 File Offset: 0x00001AA0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value20Column
			{
				get
				{
					return this.columnValue20;
				}
			}

			// Token: 0x1700002B RID: 43
			// (get) Token: 0x06000079 RID: 121 RVA: 0x000038A8 File Offset: 0x00001AA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value21Column
			{
				get
				{
					return this.columnValue21;
				}
			}

			// Token: 0x1700002C RID: 44
			// (get) Token: 0x0600007A RID: 122 RVA: 0x000038B0 File Offset: 0x00001AB0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value22Column
			{
				get
				{
					return this.columnValue22;
				}
			}

			// Token: 0x1700002D RID: 45
			// (get) Token: 0x0600007B RID: 123 RVA: 0x000038B8 File Offset: 0x00001AB8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value23Column
			{
				get
				{
					return this.columnValue23;
				}
			}

			// Token: 0x1700002E RID: 46
			// (get) Token: 0x0600007C RID: 124 RVA: 0x000038C0 File Offset: 0x00001AC0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value24Column
			{
				get
				{
					return this.columnValue24;
				}
			}

			// Token: 0x1700002F RID: 47
			// (get) Token: 0x0600007D RID: 125 RVA: 0x000038C8 File Offset: 0x00001AC8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value25Column
			{
				get
				{
					return this.columnValue25;
				}
			}

			// Token: 0x17000030 RID: 48
			// (get) Token: 0x0600007E RID: 126 RVA: 0x000038D0 File Offset: 0x00001AD0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value26Column
			{
				get
				{
					return this.columnValue26;
				}
			}

			// Token: 0x17000031 RID: 49
			// (get) Token: 0x0600007F RID: 127 RVA: 0x000038D8 File Offset: 0x00001AD8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value27Column
			{
				get
				{
					return this.columnValue27;
				}
			}

			// Token: 0x17000032 RID: 50
			// (get) Token: 0x06000080 RID: 128 RVA: 0x000038E0 File Offset: 0x00001AE0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value28Column
			{
				get
				{
					return this.columnValue28;
				}
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x06000081 RID: 129 RVA: 0x000038E8 File Offset: 0x00001AE8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value29Column
			{
				get
				{
					return this.columnValue29;
				}
			}

			// Token: 0x17000034 RID: 52
			// (get) Token: 0x06000082 RID: 130 RVA: 0x000038F0 File Offset: 0x00001AF0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value30Column
			{
				get
				{
					return this.columnValue30;
				}
			}

			// Token: 0x17000035 RID: 53
			// (get) Token: 0x06000083 RID: 131 RVA: 0x000038F8 File Offset: 0x00001AF8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value31Column
			{
				get
				{
					return this.columnValue31;
				}
			}

			// Token: 0x17000036 RID: 54
			// (get) Token: 0x06000084 RID: 132 RVA: 0x00003900 File Offset: 0x00001B00
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value32Column
			{
				get
				{
					return this.columnValue32;
				}
			}

			// Token: 0x17000037 RID: 55
			// (get) Token: 0x06000085 RID: 133 RVA: 0x00003908 File Offset: 0x00001B08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value33Column
			{
				get
				{
					return this.columnValue33;
				}
			}

			// Token: 0x17000038 RID: 56
			// (get) Token: 0x06000086 RID: 134 RVA: 0x00003910 File Offset: 0x00001B10
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value34Column
			{
				get
				{
					return this.columnValue34;
				}
			}

			// Token: 0x17000039 RID: 57
			// (get) Token: 0x06000087 RID: 135 RVA: 0x00003918 File Offset: 0x00001B18
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value35Column
			{
				get
				{
					return this.columnValue35;
				}
			}

			// Token: 0x1700003A RID: 58
			// (get) Token: 0x06000088 RID: 136 RVA: 0x00003920 File Offset: 0x00001B20
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value36Column
			{
				get
				{
					return this.columnValue36;
				}
			}

			// Token: 0x1700003B RID: 59
			// (get) Token: 0x06000089 RID: 137 RVA: 0x00003928 File Offset: 0x00001B28
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value37Column
			{
				get
				{
					return this.columnValue37;
				}
			}

			// Token: 0x1700003C RID: 60
			// (get) Token: 0x0600008A RID: 138 RVA: 0x00003930 File Offset: 0x00001B30
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value38Column
			{
				get
				{
					return this.columnValue38;
				}
			}

			// Token: 0x1700003D RID: 61
			// (get) Token: 0x0600008B RID: 139 RVA: 0x00003938 File Offset: 0x00001B38
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value39Column
			{
				get
				{
					return this.columnValue39;
				}
			}

			// Token: 0x1700003E RID: 62
			// (get) Token: 0x0600008C RID: 140 RVA: 0x00003940 File Offset: 0x00001B40
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value40Column
			{
				get
				{
					return this.columnValue40;
				}
			}

			// Token: 0x1700003F RID: 63
			// (get) Token: 0x0600008D RID: 141 RVA: 0x00003948 File Offset: 0x00001B48
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value41Column
			{
				get
				{
					return this.columnValue41;
				}
			}

			// Token: 0x17000040 RID: 64
			// (get) Token: 0x0600008E RID: 142 RVA: 0x00003950 File Offset: 0x00001B50
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value42Column
			{
				get
				{
					return this.columnValue42;
				}
			}

			// Token: 0x17000041 RID: 65
			// (get) Token: 0x0600008F RID: 143 RVA: 0x00003958 File Offset: 0x00001B58
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value43Column
			{
				get
				{
					return this.columnValue43;
				}
			}

			// Token: 0x17000042 RID: 66
			// (get) Token: 0x06000090 RID: 144 RVA: 0x00003960 File Offset: 0x00001B60
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value44Column
			{
				get
				{
					return this.columnValue44;
				}
			}

			// Token: 0x17000043 RID: 67
			// (get) Token: 0x06000091 RID: 145 RVA: 0x00003968 File Offset: 0x00001B68
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value45Column
			{
				get
				{
					return this.columnValue45;
				}
			}

			// Token: 0x17000044 RID: 68
			// (get) Token: 0x06000092 RID: 146 RVA: 0x00003970 File Offset: 0x00001B70
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value46Column
			{
				get
				{
					return this.columnValue46;
				}
			}

			// Token: 0x17000045 RID: 69
			// (get) Token: 0x06000093 RID: 147 RVA: 0x00003978 File Offset: 0x00001B78
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value47Column
			{
				get
				{
					return this.columnValue47;
				}
			}

			// Token: 0x17000046 RID: 70
			// (get) Token: 0x06000094 RID: 148 RVA: 0x00003980 File Offset: 0x00001B80
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value48Column
			{
				get
				{
					return this.columnValue48;
				}
			}

			// Token: 0x17000047 RID: 71
			// (get) Token: 0x06000095 RID: 149 RVA: 0x00003988 File Offset: 0x00001B88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value49Column
			{
				get
				{
					return this.columnValue49;
				}
			}

			// Token: 0x17000048 RID: 72
			// (get) Token: 0x06000096 RID: 150 RVA: 0x00003990 File Offset: 0x00001B90
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value50Column
			{
				get
				{
					return this.columnValue50;
				}
			}

			// Token: 0x17000049 RID: 73
			// (get) Token: 0x06000097 RID: 151 RVA: 0x00003998 File Offset: 0x00001B98
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value51Column
			{
				get
				{
					return this.columnValue51;
				}
			}

			// Token: 0x1700004A RID: 74
			// (get) Token: 0x06000098 RID: 152 RVA: 0x000039A0 File Offset: 0x00001BA0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value52Column
			{
				get
				{
					return this.columnValue52;
				}
			}

			// Token: 0x1700004B RID: 75
			// (get) Token: 0x06000099 RID: 153 RVA: 0x000039A8 File Offset: 0x00001BA8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value53Column
			{
				get
				{
					return this.columnValue53;
				}
			}

			// Token: 0x1700004C RID: 76
			// (get) Token: 0x0600009A RID: 154 RVA: 0x000039B0 File Offset: 0x00001BB0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value54Column
			{
				get
				{
					return this.columnValue54;
				}
			}

			// Token: 0x1700004D RID: 77
			// (get) Token: 0x0600009B RID: 155 RVA: 0x000039B8 File Offset: 0x00001BB8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value55Column
			{
				get
				{
					return this.columnValue55;
				}
			}

			// Token: 0x1700004E RID: 78
			// (get) Token: 0x0600009C RID: 156 RVA: 0x000039C0 File Offset: 0x00001BC0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value56Column
			{
				get
				{
					return this.columnValue56;
				}
			}

			// Token: 0x1700004F RID: 79
			// (get) Token: 0x0600009D RID: 157 RVA: 0x000039C8 File Offset: 0x00001BC8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value57Column
			{
				get
				{
					return this.columnValue57;
				}
			}

			// Token: 0x17000050 RID: 80
			// (get) Token: 0x0600009E RID: 158 RVA: 0x000039D0 File Offset: 0x00001BD0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value58Column
			{
				get
				{
					return this.columnValue58;
				}
			}

			// Token: 0x17000051 RID: 81
			// (get) Token: 0x0600009F RID: 159 RVA: 0x000039D8 File Offset: 0x00001BD8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value59Column
			{
				get
				{
					return this.columnValue59;
				}
			}

			// Token: 0x17000052 RID: 82
			// (get) Token: 0x060000A0 RID: 160 RVA: 0x000039E0 File Offset: 0x00001BE0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value60Column
			{
				get
				{
					return this.columnValue60;
				}
			}

			// Token: 0x17000053 RID: 83
			// (get) Token: 0x060000A1 RID: 161 RVA: 0x000039E8 File Offset: 0x00001BE8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn Value61Column
			{
				get
				{
					return this.columnValue61;
				}
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x060000A2 RID: 162 RVA: 0x000039F0 File Offset: 0x00001BF0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value62Column
			{
				get
				{
					return this.columnValue62;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x060000A3 RID: 163 RVA: 0x000039F8 File Offset: 0x00001BF8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value63Column
			{
				get
				{
					return this.columnValue63;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003A00 File Offset: 0x00001C00
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn Value64Column
			{
				get
				{
					return this.columnValue64;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x060000A5 RID: 165 RVA: 0x00003A08 File Offset: 0x00001C08
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000058 RID: 88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public IntelliEdit.DomainListRow this[int index]
			{
				get
				{
					return (IntelliEdit.DomainListRow)base.Rows[index];
				}
			}

			// Token: 0x14000005 RID: 5
			// (add) Token: 0x060000A7 RID: 167 RVA: 0x00003A28 File Offset: 0x00001C28
			// (remove) Token: 0x060000A8 RID: 168 RVA: 0x00003A60 File Offset: 0x00001C60
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.DomainListRowChangeEventHandler DomainListRowChanging;

			// Token: 0x14000006 RID: 6
			// (add) Token: 0x060000A9 RID: 169 RVA: 0x00003A98 File Offset: 0x00001C98
			// (remove) Token: 0x060000AA RID: 170 RVA: 0x00003AD0 File Offset: 0x00001CD0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.DomainListRowChangeEventHandler DomainListRowChanged;

			// Token: 0x14000007 RID: 7
			// (add) Token: 0x060000AB RID: 171 RVA: 0x00003B08 File Offset: 0x00001D08
			// (remove) Token: 0x060000AC RID: 172 RVA: 0x00003B40 File Offset: 0x00001D40
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.DomainListRowChangeEventHandler DomainListRowDeleting;

			// Token: 0x14000008 RID: 8
			// (add) Token: 0x060000AD RID: 173 RVA: 0x00003B78 File Offset: 0x00001D78
			// (remove) Token: 0x060000AE RID: 174 RVA: 0x00003BB0 File Offset: 0x00001DB0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.DomainListRowChangeEventHandler DomainListRowDeleted;

			// Token: 0x060000AF RID: 175 RVA: 0x00003BE5 File Offset: 0x00001DE5
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddDomainListRow(IntelliEdit.DomainListRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060000B0 RID: 176 RVA: 0x00003BF4 File Offset: 0x00001DF4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public IntelliEdit.DomainListRow AddDomainListRow(string Name, int TotalValues, string Value0, string Value1, string Value2, string Value3, string Value4, string Value5, string Value6, string Value7, string Value8, string Value9, string Value10, string Value11, string Value12, string Value13, string Value14, string Value15, string Value16, string Value17, string Value18, string Value19, string Value20, string Value21, string Value22, string Value23, string Value24, string Value25, string Value26, string Value27, string Value28, string Value29, string Value30, string Value31, string Value32, string Value33, string Value34, string Value35, string Value36, string Value37, string Value38, string Value39, string Value40, string Value41, string Value42, string Value43, string Value44, string Value45, string Value46, string Value47, string Value48, string Value49, string Value50, string Value51, string Value52, string Value53, string Value54, string Value55, string Value56, string Value57, string Value58, string Value59, string Value60, string Value61, string Value62, string Value63, string Value64)
			{
				IntelliEdit.DomainListRow domainListRow = (IntelliEdit.DomainListRow)base.NewRow();
				object[] array = new object[]
				{
					Name, TotalValues, Value0, Value1, Value2, Value3, Value4, Value5, Value6, Value7,
					Value8, Value9, Value10, Value11, Value12, Value13, Value14, Value15, Value16, Value17,
					Value18, Value19, Value20, Value21, Value22, Value23, Value24, Value25, Value26, Value27,
					Value28, Value29, Value30, Value31, Value32, Value33, Value34, Value35, Value36, Value37,
					Value38, Value39, Value40, Value41, Value42, Value43, Value44, Value45, Value46, Value47,
					Value48, Value49, Value50, Value51, Value52, Value53, Value54, Value55, Value56, Value57,
					Value58, Value59, Value60, Value61, Value62, Value63, Value64
				};
				domainListRow.ItemArray = array;
				base.Rows.Add(domainListRow);
				return domainListRow;
			}

			// Token: 0x060000B1 RID: 177 RVA: 0x00003DB8 File Offset: 0x00001FB8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				IntelliEdit.DomainListDataTable domainListDataTable = (IntelliEdit.DomainListDataTable)base.Clone();
				domainListDataTable.InitVars();
				return domainListDataTable;
			}

			// Token: 0x060000B2 RID: 178 RVA: 0x00003DD8 File Offset: 0x00001FD8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new IntelliEdit.DomainListDataTable();
			}

			// Token: 0x060000B3 RID: 179 RVA: 0x00003DE0 File Offset: 0x00001FE0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnName = base.Columns["Name"];
				this.columnTotalValues = base.Columns["TotalValues"];
				this.columnValue0 = base.Columns["Value0"];
				this.columnValue1 = base.Columns["Value1"];
				this.columnValue2 = base.Columns["Value2"];
				this.columnValue3 = base.Columns["Value3"];
				this.columnValue4 = base.Columns["Value4"];
				this.columnValue5 = base.Columns["Value5"];
				this.columnValue6 = base.Columns["Value6"];
				this.columnValue7 = base.Columns["Value7"];
				this.columnValue8 = base.Columns["Value8"];
				this.columnValue9 = base.Columns["Value9"];
				this.columnValue10 = base.Columns["Value10"];
				this.columnValue11 = base.Columns["Value11"];
				this.columnValue12 = base.Columns["Value12"];
				this.columnValue13 = base.Columns["Value13"];
				this.columnValue14 = base.Columns["Value14"];
				this.columnValue15 = base.Columns["Value15"];
				this.columnValue16 = base.Columns["Value16"];
				this.columnValue17 = base.Columns["Value17"];
				this.columnValue18 = base.Columns["Value18"];
				this.columnValue19 = base.Columns["Value19"];
				this.columnValue20 = base.Columns["Value20"];
				this.columnValue21 = base.Columns["Value21"];
				this.columnValue22 = base.Columns["Value22"];
				this.columnValue23 = base.Columns["Value23"];
				this.columnValue24 = base.Columns["Value24"];
				this.columnValue25 = base.Columns["Value25"];
				this.columnValue26 = base.Columns["Value26"];
				this.columnValue27 = base.Columns["Value27"];
				this.columnValue28 = base.Columns["Value28"];
				this.columnValue29 = base.Columns["Value29"];
				this.columnValue30 = base.Columns["Value30"];
				this.columnValue31 = base.Columns["Value31"];
				this.columnValue32 = base.Columns["Value32"];
				this.columnValue33 = base.Columns["Value33"];
				this.columnValue34 = base.Columns["Value34"];
				this.columnValue35 = base.Columns["Value35"];
				this.columnValue36 = base.Columns["Value36"];
				this.columnValue37 = base.Columns["Value37"];
				this.columnValue38 = base.Columns["Value38"];
				this.columnValue39 = base.Columns["Value39"];
				this.columnValue40 = base.Columns["Value40"];
				this.columnValue41 = base.Columns["Value41"];
				this.columnValue42 = base.Columns["Value42"];
				this.columnValue43 = base.Columns["Value43"];
				this.columnValue44 = base.Columns["Value44"];
				this.columnValue45 = base.Columns["Value45"];
				this.columnValue46 = base.Columns["Value46"];
				this.columnValue47 = base.Columns["Value47"];
				this.columnValue48 = base.Columns["Value48"];
				this.columnValue49 = base.Columns["Value49"];
				this.columnValue50 = base.Columns["Value50"];
				this.columnValue51 = base.Columns["Value51"];
				this.columnValue52 = base.Columns["Value52"];
				this.columnValue53 = base.Columns["Value53"];
				this.columnValue54 = base.Columns["Value54"];
				this.columnValue55 = base.Columns["Value55"];
				this.columnValue56 = base.Columns["Value56"];
				this.columnValue57 = base.Columns["Value57"];
				this.columnValue58 = base.Columns["Value58"];
				this.columnValue59 = base.Columns["Value59"];
				this.columnValue60 = base.Columns["Value60"];
				this.columnValue61 = base.Columns["Value61"];
				this.columnValue62 = base.Columns["Value62"];
				this.columnValue63 = base.Columns["Value63"];
				this.columnValue64 = base.Columns["Value64"];
			}

			// Token: 0x060000B4 RID: 180 RVA: 0x000043B0 File Offset: 0x000025B0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnTotalValues = new DataColumn("TotalValues", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnTotalValues);
				this.columnValue0 = new DataColumn("Value0", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue0);
				this.columnValue1 = new DataColumn("Value1", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue1);
				this.columnValue2 = new DataColumn("Value2", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue2);
				this.columnValue3 = new DataColumn("Value3", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue3);
				this.columnValue4 = new DataColumn("Value4", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue4);
				this.columnValue5 = new DataColumn("Value5", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue5);
				this.columnValue6 = new DataColumn("Value6", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue6);
				this.columnValue7 = new DataColumn("Value7", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue7);
				this.columnValue8 = new DataColumn("Value8", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue8);
				this.columnValue9 = new DataColumn("Value9", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue9);
				this.columnValue10 = new DataColumn("Value10", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue10);
				this.columnValue11 = new DataColumn("Value11", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue11);
				this.columnValue12 = new DataColumn("Value12", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue12);
				this.columnValue13 = new DataColumn("Value13", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue13);
				this.columnValue14 = new DataColumn("Value14", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue14);
				this.columnValue15 = new DataColumn("Value15", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue15);
				this.columnValue16 = new DataColumn("Value16", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue16);
				this.columnValue17 = new DataColumn("Value17", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue17);
				this.columnValue18 = new DataColumn("Value18", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue18);
				this.columnValue19 = new DataColumn("Value19", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue19);
				this.columnValue20 = new DataColumn("Value20", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue20);
				this.columnValue21 = new DataColumn("Value21", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue21);
				this.columnValue22 = new DataColumn("Value22", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue22);
				this.columnValue23 = new DataColumn("Value23", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue23);
				this.columnValue24 = new DataColumn("Value24", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue24);
				this.columnValue25 = new DataColumn("Value25", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue25);
				this.columnValue26 = new DataColumn("Value26", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue26);
				this.columnValue27 = new DataColumn("Value27", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue27);
				this.columnValue28 = new DataColumn("Value28", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue28);
				this.columnValue29 = new DataColumn("Value29", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue29);
				this.columnValue30 = new DataColumn("Value30", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue30);
				this.columnValue31 = new DataColumn("Value31", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue31);
				this.columnValue32 = new DataColumn("Value32", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue32);
				this.columnValue33 = new DataColumn("Value33", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue33);
				this.columnValue34 = new DataColumn("Value34", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue34);
				this.columnValue35 = new DataColumn("Value35", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue35);
				this.columnValue36 = new DataColumn("Value36", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue36);
				this.columnValue37 = new DataColumn("Value37", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue37);
				this.columnValue38 = new DataColumn("Value38", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue38);
				this.columnValue39 = new DataColumn("Value39", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue39);
				this.columnValue40 = new DataColumn("Value40", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue40);
				this.columnValue41 = new DataColumn("Value41", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue41);
				this.columnValue42 = new DataColumn("Value42", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue42);
				this.columnValue43 = new DataColumn("Value43", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue43);
				this.columnValue44 = new DataColumn("Value44", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue44);
				this.columnValue45 = new DataColumn("Value45", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue45);
				this.columnValue46 = new DataColumn("Value46", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue46);
				this.columnValue47 = new DataColumn("Value47", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue47);
				this.columnValue48 = new DataColumn("Value48", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue48);
				this.columnValue49 = new DataColumn("Value49", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue49);
				this.columnValue50 = new DataColumn("Value50", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue50);
				this.columnValue51 = new DataColumn("Value51", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue51);
				this.columnValue52 = new DataColumn("Value52", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue52);
				this.columnValue53 = new DataColumn("Value53", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue53);
				this.columnValue54 = new DataColumn("Value54", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue54);
				this.columnValue55 = new DataColumn("Value55", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue55);
				this.columnValue56 = new DataColumn("Value56", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue56);
				this.columnValue57 = new DataColumn("Value57", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue57);
				this.columnValue58 = new DataColumn("Value58", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue58);
				this.columnValue59 = new DataColumn("Value59", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue59);
				this.columnValue60 = new DataColumn("Value60", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue60);
				this.columnValue61 = new DataColumn("Value61", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue61);
				this.columnValue62 = new DataColumn("Value62", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue62);
				this.columnValue63 = new DataColumn("Value63", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue63);
				this.columnValue64 = new DataColumn("Value64", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue64);
			}

			// Token: 0x060000B5 RID: 181 RVA: 0x00004F84 File Offset: 0x00003184
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public IntelliEdit.DomainListRow NewDomainListRow()
			{
				return (IntelliEdit.DomainListRow)base.NewRow();
			}

			// Token: 0x060000B6 RID: 182 RVA: 0x00004F91 File Offset: 0x00003191
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new IntelliEdit.DomainListRow(builder);
			}

			// Token: 0x060000B7 RID: 183 RVA: 0x00004F99 File Offset: 0x00003199
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(IntelliEdit.DomainListRow);
			}

			// Token: 0x060000B8 RID: 184 RVA: 0x00004FA5 File Offset: 0x000031A5
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.DomainListRowChanged != null)
				{
					this.DomainListRowChanged(this, new IntelliEdit.DomainListRowChangeEvent((IntelliEdit.DomainListRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000B9 RID: 185 RVA: 0x00004FD8 File Offset: 0x000031D8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.DomainListRowChanging != null)
				{
					this.DomainListRowChanging(this, new IntelliEdit.DomainListRowChangeEvent((IntelliEdit.DomainListRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000BA RID: 186 RVA: 0x0000500B File Offset: 0x0000320B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.DomainListRowDeleted != null)
				{
					this.DomainListRowDeleted(this, new IntelliEdit.DomainListRowChangeEvent((IntelliEdit.DomainListRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000BB RID: 187 RVA: 0x0000503E File Offset: 0x0000323E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.DomainListRowDeleting != null)
				{
					this.DomainListRowDeleting(this, new IntelliEdit.DomainListRowChangeEvent((IntelliEdit.DomainListRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000BC RID: 188 RVA: 0x00005071 File Offset: 0x00003271
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemoveDomainListRow(IntelliEdit.DomainListRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x060000BD RID: 189 RVA: 0x00005080 File Offset: 0x00003280
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				IntelliEdit intelliEdit = new IntelliEdit();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = intelliEdit.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DomainListDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = intelliEdit.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x0400001B RID: 27
			private DataColumn columnName;

			// Token: 0x0400001C RID: 28
			private DataColumn columnTotalValues;

			// Token: 0x0400001D RID: 29
			private DataColumn columnValue0;

			// Token: 0x0400001E RID: 30
			private DataColumn columnValue1;

			// Token: 0x0400001F RID: 31
			private DataColumn columnValue2;

			// Token: 0x04000020 RID: 32
			private DataColumn columnValue3;

			// Token: 0x04000021 RID: 33
			private DataColumn columnValue4;

			// Token: 0x04000022 RID: 34
			private DataColumn columnValue5;

			// Token: 0x04000023 RID: 35
			private DataColumn columnValue6;

			// Token: 0x04000024 RID: 36
			private DataColumn columnValue7;

			// Token: 0x04000025 RID: 37
			private DataColumn columnValue8;

			// Token: 0x04000026 RID: 38
			private DataColumn columnValue9;

			// Token: 0x04000027 RID: 39
			private DataColumn columnValue10;

			// Token: 0x04000028 RID: 40
			private DataColumn columnValue11;

			// Token: 0x04000029 RID: 41
			private DataColumn columnValue12;

			// Token: 0x0400002A RID: 42
			private DataColumn columnValue13;

			// Token: 0x0400002B RID: 43
			private DataColumn columnValue14;

			// Token: 0x0400002C RID: 44
			private DataColumn columnValue15;

			// Token: 0x0400002D RID: 45
			private DataColumn columnValue16;

			// Token: 0x0400002E RID: 46
			private DataColumn columnValue17;

			// Token: 0x0400002F RID: 47
			private DataColumn columnValue18;

			// Token: 0x04000030 RID: 48
			private DataColumn columnValue19;

			// Token: 0x04000031 RID: 49
			private DataColumn columnValue20;

			// Token: 0x04000032 RID: 50
			private DataColumn columnValue21;

			// Token: 0x04000033 RID: 51
			private DataColumn columnValue22;

			// Token: 0x04000034 RID: 52
			private DataColumn columnValue23;

			// Token: 0x04000035 RID: 53
			private DataColumn columnValue24;

			// Token: 0x04000036 RID: 54
			private DataColumn columnValue25;

			// Token: 0x04000037 RID: 55
			private DataColumn columnValue26;

			// Token: 0x04000038 RID: 56
			private DataColumn columnValue27;

			// Token: 0x04000039 RID: 57
			private DataColumn columnValue28;

			// Token: 0x0400003A RID: 58
			private DataColumn columnValue29;

			// Token: 0x0400003B RID: 59
			private DataColumn columnValue30;

			// Token: 0x0400003C RID: 60
			private DataColumn columnValue31;

			// Token: 0x0400003D RID: 61
			private DataColumn columnValue32;

			// Token: 0x0400003E RID: 62
			private DataColumn columnValue33;

			// Token: 0x0400003F RID: 63
			private DataColumn columnValue34;

			// Token: 0x04000040 RID: 64
			private DataColumn columnValue35;

			// Token: 0x04000041 RID: 65
			private DataColumn columnValue36;

			// Token: 0x04000042 RID: 66
			private DataColumn columnValue37;

			// Token: 0x04000043 RID: 67
			private DataColumn columnValue38;

			// Token: 0x04000044 RID: 68
			private DataColumn columnValue39;

			// Token: 0x04000045 RID: 69
			private DataColumn columnValue40;

			// Token: 0x04000046 RID: 70
			private DataColumn columnValue41;

			// Token: 0x04000047 RID: 71
			private DataColumn columnValue42;

			// Token: 0x04000048 RID: 72
			private DataColumn columnValue43;

			// Token: 0x04000049 RID: 73
			private DataColumn columnValue44;

			// Token: 0x0400004A RID: 74
			private DataColumn columnValue45;

			// Token: 0x0400004B RID: 75
			private DataColumn columnValue46;

			// Token: 0x0400004C RID: 76
			private DataColumn columnValue47;

			// Token: 0x0400004D RID: 77
			private DataColumn columnValue48;

			// Token: 0x0400004E RID: 78
			private DataColumn columnValue49;

			// Token: 0x0400004F RID: 79
			private DataColumn columnValue50;

			// Token: 0x04000050 RID: 80
			private DataColumn columnValue51;

			// Token: 0x04000051 RID: 81
			private DataColumn columnValue52;

			// Token: 0x04000052 RID: 82
			private DataColumn columnValue53;

			// Token: 0x04000053 RID: 83
			private DataColumn columnValue54;

			// Token: 0x04000054 RID: 84
			private DataColumn columnValue55;

			// Token: 0x04000055 RID: 85
			private DataColumn columnValue56;

			// Token: 0x04000056 RID: 86
			private DataColumn columnValue57;

			// Token: 0x04000057 RID: 87
			private DataColumn columnValue58;

			// Token: 0x04000058 RID: 88
			private DataColumn columnValue59;

			// Token: 0x04000059 RID: 89
			private DataColumn columnValue60;

			// Token: 0x0400005A RID: 90
			private DataColumn columnValue61;

			// Token: 0x0400005B RID: 91
			private DataColumn columnValue62;

			// Token: 0x0400005C RID: 92
			private DataColumn columnValue63;

			// Token: 0x0400005D RID: 93
			private DataColumn columnValue64;
		}

		// Token: 0x0200000A RID: 10
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class UseDomainDataTable : TypedTableBase<IntelliEdit.UseDomainRow>
		{
			// Token: 0x060000BE RID: 190 RVA: 0x00005278 File Offset: 0x00003478
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public UseDomainDataTable()
			{
				base.TableName = "UseDomain";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060000BF RID: 191 RVA: 0x000052A0 File Offset: 0x000034A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal UseDomainDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060000C0 RID: 192 RVA: 0x00005348 File Offset: 0x00003548
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected UseDomainDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060000C1 RID: 193 RVA: 0x00005358 File Offset: 0x00003558
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SourceTableColumn
			{
				get
				{
					return this.columnSourceTable;
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060000C2 RID: 194 RVA: 0x00005360 File Offset: 0x00003560
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SourceColumnColumn
			{
				get
				{
					return this.columnSourceColumn;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060000C3 RID: 195 RVA: 0x00005368 File Offset: 0x00003568
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn DomainNameColumn
			{
				get
				{
					return this.columnDomainName;
				}
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060000C4 RID: 196 RVA: 0x00005370 File Offset: 0x00003570
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x1700005D RID: 93
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public IntelliEdit.UseDomainRow this[int index]
			{
				get
				{
					return (IntelliEdit.UseDomainRow)base.Rows[index];
				}
			}

			// Token: 0x14000009 RID: 9
			// (add) Token: 0x060000C6 RID: 198 RVA: 0x00005390 File Offset: 0x00003590
			// (remove) Token: 0x060000C7 RID: 199 RVA: 0x000053C8 File Offset: 0x000035C8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.UseDomainRowChangeEventHandler UseDomainRowChanging;

			// Token: 0x1400000A RID: 10
			// (add) Token: 0x060000C8 RID: 200 RVA: 0x00005400 File Offset: 0x00003600
			// (remove) Token: 0x060000C9 RID: 201 RVA: 0x00005438 File Offset: 0x00003638
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.UseDomainRowChangeEventHandler UseDomainRowChanged;

			// Token: 0x1400000B RID: 11
			// (add) Token: 0x060000CA RID: 202 RVA: 0x00005470 File Offset: 0x00003670
			// (remove) Token: 0x060000CB RID: 203 RVA: 0x000054A8 File Offset: 0x000036A8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.UseDomainRowChangeEventHandler UseDomainRowDeleting;

			// Token: 0x1400000C RID: 12
			// (add) Token: 0x060000CC RID: 204 RVA: 0x000054E0 File Offset: 0x000036E0
			// (remove) Token: 0x060000CD RID: 205 RVA: 0x00005518 File Offset: 0x00003718
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.UseDomainRowChangeEventHandler UseDomainRowDeleted;

			// Token: 0x060000CE RID: 206 RVA: 0x0000554D File Offset: 0x0000374D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddUseDomainRow(IntelliEdit.UseDomainRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060000CF RID: 207 RVA: 0x0000555C File Offset: 0x0000375C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public IntelliEdit.UseDomainRow AddUseDomainRow(string SourceTable, string SourceColumn, string DomainName)
			{
				IntelliEdit.UseDomainRow useDomainRow = (IntelliEdit.UseDomainRow)base.NewRow();
				object[] array = new object[] { SourceTable, SourceColumn, DomainName };
				useDomainRow.ItemArray = array;
				base.Rows.Add(useDomainRow);
				return useDomainRow;
			}

			// Token: 0x060000D0 RID: 208 RVA: 0x000055A0 File Offset: 0x000037A0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				IntelliEdit.UseDomainDataTable useDomainDataTable = (IntelliEdit.UseDomainDataTable)base.Clone();
				useDomainDataTable.InitVars();
				return useDomainDataTable;
			}

			// Token: 0x060000D1 RID: 209 RVA: 0x000055C0 File Offset: 0x000037C0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new IntelliEdit.UseDomainDataTable();
			}

			// Token: 0x060000D2 RID: 210 RVA: 0x000055C8 File Offset: 0x000037C8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnSourceTable = base.Columns["SourceTable"];
				this.columnSourceColumn = base.Columns["SourceColumn"];
				this.columnDomainName = base.Columns["DomainName"];
			}

			// Token: 0x060000D3 RID: 211 RVA: 0x00005618 File Offset: 0x00003818
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			private void InitClass()
			{
				this.columnSourceTable = new DataColumn("SourceTable", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSourceTable);
				this.columnSourceColumn = new DataColumn("SourceColumn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSourceColumn);
				this.columnDomainName = new DataColumn("DomainName", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDomainName);
			}

			// Token: 0x060000D4 RID: 212 RVA: 0x000056AC File Offset: 0x000038AC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public IntelliEdit.UseDomainRow NewUseDomainRow()
			{
				return (IntelliEdit.UseDomainRow)base.NewRow();
			}

			// Token: 0x060000D5 RID: 213 RVA: 0x000056B9 File Offset: 0x000038B9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new IntelliEdit.UseDomainRow(builder);
			}

			// Token: 0x060000D6 RID: 214 RVA: 0x000056C1 File Offset: 0x000038C1
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(IntelliEdit.UseDomainRow);
			}

			// Token: 0x060000D7 RID: 215 RVA: 0x000056CD File Offset: 0x000038CD
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.UseDomainRowChanged != null)
				{
					this.UseDomainRowChanged(this, new IntelliEdit.UseDomainRowChangeEvent((IntelliEdit.UseDomainRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000D8 RID: 216 RVA: 0x00005700 File Offset: 0x00003900
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.UseDomainRowChanging != null)
				{
					this.UseDomainRowChanging(this, new IntelliEdit.UseDomainRowChangeEvent((IntelliEdit.UseDomainRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000D9 RID: 217 RVA: 0x00005733 File Offset: 0x00003933
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.UseDomainRowDeleted != null)
				{
					this.UseDomainRowDeleted(this, new IntelliEdit.UseDomainRowChangeEvent((IntelliEdit.UseDomainRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000DA RID: 218 RVA: 0x00005766 File Offset: 0x00003966
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.UseDomainRowDeleting != null)
				{
					this.UseDomainRowDeleting(this, new IntelliEdit.UseDomainRowChangeEvent((IntelliEdit.UseDomainRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000DB RID: 219 RVA: 0x00005799 File Offset: 0x00003999
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveUseDomainRow(IntelliEdit.UseDomainRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x060000DC RID: 220 RVA: 0x000057A8 File Offset: 0x000039A8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				IntelliEdit intelliEdit = new IntelliEdit();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = intelliEdit.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "UseDomainDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = intelliEdit.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000062 RID: 98
			private DataColumn columnSourceTable;

			// Token: 0x04000063 RID: 99
			private DataColumn columnSourceColumn;

			// Token: 0x04000064 RID: 100
			private DataColumn columnDomainName;
		}

		// Token: 0x0200000B RID: 11
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DoubleCrossTableDataTable : TypedTableBase<IntelliEdit.DoubleCrossTableRow>
		{
			// Token: 0x060000DD RID: 221 RVA: 0x000059A0 File Offset: 0x00003BA0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DoubleCrossTableDataTable()
			{
				base.TableName = "DoubleCrossTable";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x060000DE RID: 222 RVA: 0x000059C8 File Offset: 0x00003BC8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DoubleCrossTableDataTable(DataTable table)
			{
				base.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					base.CaseSensitive = table.CaseSensitive;
				}
				if (table.Locale.ToString() != table.DataSet.Locale.ToString())
				{
					base.Locale = table.Locale;
				}
				if (table.Namespace != table.DataSet.Namespace)
				{
					base.Namespace = table.Namespace;
				}
				base.Prefix = table.Prefix;
				base.MinimumCapacity = table.MinimumCapacity;
			}

			// Token: 0x060000DF RID: 223 RVA: 0x00005A70 File Offset: 0x00003C70
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected DoubleCrossTableDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700005E RID: 94
			// (get) Token: 0x060000E0 RID: 224 RVA: 0x00005A80 File Offset: 0x00003C80
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn SourceTableColumn
			{
				get
				{
					return this.columnSourceTable;
				}
			}

			// Token: 0x1700005F RID: 95
			// (get) Token: 0x060000E1 RID: 225 RVA: 0x00005A88 File Offset: 0x00003C88
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn SourceColumnColumn
			{
				get
				{
					return this.columnSourceColumn;
				}
			}

			// Token: 0x17000060 RID: 96
			// (get) Token: 0x060000E2 RID: 226 RVA: 0x00005A90 File Offset: 0x00003C90
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IntermediateTableColumn
			{
				get
				{
					return this.columnIntermediateTable;
				}
			}

			// Token: 0x17000061 RID: 97
			// (get) Token: 0x060000E3 RID: 227 RVA: 0x00005A98 File Offset: 0x00003C98
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn IntermediateKeyColumnColumn
			{
				get
				{
					return this.columnIntermediateKeyColumn;
				}
			}

			// Token: 0x17000062 RID: 98
			// (get) Token: 0x060000E4 RID: 228 RVA: 0x00005AA0 File Offset: 0x00003CA0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IntermediateJumpColumnColumn
			{
				get
				{
					return this.columnIntermediateJumpColumn;
				}
			}

			// Token: 0x17000063 RID: 99
			// (get) Token: 0x060000E5 RID: 229 RVA: 0x00005AA8 File Offset: 0x00003CA8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ReferredTableColumn
			{
				get
				{
					return this.columnReferredTable;
				}
			}

			// Token: 0x17000064 RID: 100
			// (get) Token: 0x060000E6 RID: 230 RVA: 0x00005AB0 File Offset: 0x00003CB0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn KeyColumnColumn
			{
				get
				{
					return this.columnKeyColumn;
				}
			}

			// Token: 0x17000065 RID: 101
			// (get) Token: 0x060000E7 RID: 231 RVA: 0x00005AB8 File Offset: 0x00003CB8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DisplayColumnColumn
			{
				get
				{
					return this.columnDisplayColumn;
				}
			}

			// Token: 0x17000066 RID: 102
			// (get) Token: 0x060000E8 RID: 232 RVA: 0x00005AC0 File Offset: 0x00003CC0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000067 RID: 103
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public IntelliEdit.DoubleCrossTableRow this[int index]
			{
				get
				{
					return (IntelliEdit.DoubleCrossTableRow)base.Rows[index];
				}
			}

			// Token: 0x1400000D RID: 13
			// (add) Token: 0x060000EA RID: 234 RVA: 0x00005AE0 File Offset: 0x00003CE0
			// (remove) Token: 0x060000EB RID: 235 RVA: 0x00005B18 File Offset: 0x00003D18
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.DoubleCrossTableRowChangeEventHandler DoubleCrossTableRowChanging;

			// Token: 0x1400000E RID: 14
			// (add) Token: 0x060000EC RID: 236 RVA: 0x00005B50 File Offset: 0x00003D50
			// (remove) Token: 0x060000ED RID: 237 RVA: 0x00005B88 File Offset: 0x00003D88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.DoubleCrossTableRowChangeEventHandler DoubleCrossTableRowChanged;

			// Token: 0x1400000F RID: 15
			// (add) Token: 0x060000EE RID: 238 RVA: 0x00005BC0 File Offset: 0x00003DC0
			// (remove) Token: 0x060000EF RID: 239 RVA: 0x00005BF8 File Offset: 0x00003DF8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.DoubleCrossTableRowChangeEventHandler DoubleCrossTableRowDeleting;

			// Token: 0x14000010 RID: 16
			// (add) Token: 0x060000F0 RID: 240 RVA: 0x00005C30 File Offset: 0x00003E30
			// (remove) Token: 0x060000F1 RID: 241 RVA: 0x00005C68 File Offset: 0x00003E68
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event IntelliEdit.DoubleCrossTableRowChangeEventHandler DoubleCrossTableRowDeleted;

			// Token: 0x060000F2 RID: 242 RVA: 0x00005C9D File Offset: 0x00003E9D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddDoubleCrossTableRow(IntelliEdit.DoubleCrossTableRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060000F3 RID: 243 RVA: 0x00005CAC File Offset: 0x00003EAC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public IntelliEdit.DoubleCrossTableRow AddDoubleCrossTableRow(string SourceTable, string SourceColumn, string IntermediateTable, string IntermediateKeyColumn, string IntermediateJumpColumn, string ReferredTable, string KeyColumn, string DisplayColumn)
			{
				IntelliEdit.DoubleCrossTableRow doubleCrossTableRow = (IntelliEdit.DoubleCrossTableRow)base.NewRow();
				object[] array = new object[] { SourceTable, SourceColumn, IntermediateTable, IntermediateKeyColumn, IntermediateJumpColumn, ReferredTable, KeyColumn, DisplayColumn };
				doubleCrossTableRow.ItemArray = array;
				base.Rows.Add(doubleCrossTableRow);
				return doubleCrossTableRow;
			}

			// Token: 0x060000F4 RID: 244 RVA: 0x00005D08 File Offset: 0x00003F08
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				IntelliEdit.DoubleCrossTableDataTable doubleCrossTableDataTable = (IntelliEdit.DoubleCrossTableDataTable)base.Clone();
				doubleCrossTableDataTable.InitVars();
				return doubleCrossTableDataTable;
			}

			// Token: 0x060000F5 RID: 245 RVA: 0x00005D28 File Offset: 0x00003F28
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new IntelliEdit.DoubleCrossTableDataTable();
			}

			// Token: 0x060000F6 RID: 246 RVA: 0x00005D30 File Offset: 0x00003F30
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnSourceTable = base.Columns["SourceTable"];
				this.columnSourceColumn = base.Columns["SourceColumn"];
				this.columnIntermediateTable = base.Columns["IntermediateTable"];
				this.columnIntermediateKeyColumn = base.Columns["IntermediateKeyColumn"];
				this.columnIntermediateJumpColumn = base.Columns["IntermediateJumpColumn"];
				this.columnReferredTable = base.Columns["ReferredTable"];
				this.columnKeyColumn = base.Columns["KeyColumn"];
				this.columnDisplayColumn = base.Columns["DisplayColumn"];
			}

			// Token: 0x060000F7 RID: 247 RVA: 0x00005DF0 File Offset: 0x00003FF0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnSourceTable = new DataColumn("SourceTable", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSourceTable);
				this.columnSourceColumn = new DataColumn("SourceColumn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnSourceColumn);
				this.columnIntermediateTable = new DataColumn("IntermediateTable", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnIntermediateTable);
				this.columnIntermediateKeyColumn = new DataColumn("IntermediateKeyColumn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnIntermediateKeyColumn);
				this.columnIntermediateJumpColumn = new DataColumn("IntermediateJumpColumn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnIntermediateJumpColumn);
				this.columnReferredTable = new DataColumn("ReferredTable", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnReferredTable);
				this.columnKeyColumn = new DataColumn("KeyColumn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnKeyColumn);
				this.columnDisplayColumn = new DataColumn("DisplayColumn", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDisplayColumn);
			}

			// Token: 0x060000F8 RID: 248 RVA: 0x00005F65 File Offset: 0x00004165
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public IntelliEdit.DoubleCrossTableRow NewDoubleCrossTableRow()
			{
				return (IntelliEdit.DoubleCrossTableRow)base.NewRow();
			}

			// Token: 0x060000F9 RID: 249 RVA: 0x00005F72 File Offset: 0x00004172
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new IntelliEdit.DoubleCrossTableRow(builder);
			}

			// Token: 0x060000FA RID: 250 RVA: 0x00005F7A File Offset: 0x0000417A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(IntelliEdit.DoubleCrossTableRow);
			}

			// Token: 0x060000FB RID: 251 RVA: 0x00005F86 File Offset: 0x00004186
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.DoubleCrossTableRowChanged != null)
				{
					this.DoubleCrossTableRowChanged(this, new IntelliEdit.DoubleCrossTableRowChangeEvent((IntelliEdit.DoubleCrossTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000FC RID: 252 RVA: 0x00005FB9 File Offset: 0x000041B9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.DoubleCrossTableRowChanging != null)
				{
					this.DoubleCrossTableRowChanging(this, new IntelliEdit.DoubleCrossTableRowChangeEvent((IntelliEdit.DoubleCrossTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000FD RID: 253 RVA: 0x00005FEC File Offset: 0x000041EC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.DoubleCrossTableRowDeleted != null)
				{
					this.DoubleCrossTableRowDeleted(this, new IntelliEdit.DoubleCrossTableRowChangeEvent((IntelliEdit.DoubleCrossTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000FE RID: 254 RVA: 0x0000601F File Offset: 0x0000421F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.DoubleCrossTableRowDeleting != null)
				{
					this.DoubleCrossTableRowDeleting(this, new IntelliEdit.DoubleCrossTableRowChangeEvent((IntelliEdit.DoubleCrossTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x060000FF RID: 255 RVA: 0x00006052 File Offset: 0x00004252
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDoubleCrossTableRow(IntelliEdit.DoubleCrossTableRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x06000100 RID: 256 RVA: 0x00006060 File Offset: 0x00004260
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				IntelliEdit intelliEdit = new IntelliEdit();
				XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
				xmlSchemaAny.Namespace = "http://www.w3.org/2001/XMLSchema";
				xmlSchemaAny.MinOccurs = 0m;
				xmlSchemaAny.MaxOccurs = decimal.MaxValue;
				xmlSchemaAny.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny);
				XmlSchemaAny xmlSchemaAny2 = new XmlSchemaAny();
				xmlSchemaAny2.Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1";
				xmlSchemaAny2.MinOccurs = 1m;
				xmlSchemaAny2.ProcessContents = XmlSchemaContentProcessing.Lax;
				xmlSchemaSequence.Items.Add(xmlSchemaAny2);
				XmlSchemaAttribute xmlSchemaAttribute = new XmlSchemaAttribute();
				xmlSchemaAttribute.Name = "namespace";
				xmlSchemaAttribute.FixedValue = intelliEdit.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DoubleCrossTableDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = intelliEdit.GetSchemaSerializable();
				if (xs.Contains(schemaSerializable.TargetNamespace))
				{
					MemoryStream memoryStream = new MemoryStream();
					MemoryStream memoryStream2 = new MemoryStream();
					try
					{
						schemaSerializable.Write(memoryStream);
						foreach (object obj in xs.Schemas(schemaSerializable.TargetNamespace))
						{
							XmlSchema xmlSchema = (XmlSchema)obj;
							memoryStream2.SetLength(0L);
							xmlSchema.Write(memoryStream2);
							if (memoryStream.Length == memoryStream2.Length)
							{
								memoryStream.Position = 0L;
								memoryStream2.Position = 0L;
								while (memoryStream.Position != memoryStream.Length && memoryStream.ReadByte() == memoryStream2.ReadByte())
								{
								}
								if (memoryStream.Position == memoryStream.Length)
								{
									return xmlSchemaComplexType;
								}
							}
						}
					}
					finally
					{
						if (memoryStream != null)
						{
							memoryStream.Close();
						}
						if (memoryStream2 != null)
						{
							memoryStream2.Close();
						}
					}
				}
				xs.Add(schemaSerializable);
				return xmlSchemaComplexType;
			}

			// Token: 0x04000069 RID: 105
			private DataColumn columnSourceTable;

			// Token: 0x0400006A RID: 106
			private DataColumn columnSourceColumn;

			// Token: 0x0400006B RID: 107
			private DataColumn columnIntermediateTable;

			// Token: 0x0400006C RID: 108
			private DataColumn columnIntermediateKeyColumn;

			// Token: 0x0400006D RID: 109
			private DataColumn columnIntermediateJumpColumn;

			// Token: 0x0400006E RID: 110
			private DataColumn columnReferredTable;

			// Token: 0x0400006F RID: 111
			private DataColumn columnKeyColumn;

			// Token: 0x04000070 RID: 112
			private DataColumn columnDisplayColumn;
		}

		// Token: 0x0200000C RID: 12
		public class CrossTableRow : DataRow
		{
			// Token: 0x06000101 RID: 257 RVA: 0x00006258 File Offset: 0x00004458
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal CrossTableRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tableCrossTable = (IntelliEdit.CrossTableDataTable)base.Table;
			}

			// Token: 0x17000068 RID: 104
			// (get) Token: 0x06000102 RID: 258 RVA: 0x00006274 File Offset: 0x00004474
			// (set) Token: 0x06000103 RID: 259 RVA: 0x000062B8 File Offset: 0x000044B8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string SourceTable
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableCrossTable.SourceTableColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'SourceTable' in table 'CrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableCrossTable.SourceTableColumn] = value;
				}
			}

			// Token: 0x17000069 RID: 105
			// (get) Token: 0x06000104 RID: 260 RVA: 0x000062CC File Offset: 0x000044CC
			// (set) Token: 0x06000105 RID: 261 RVA: 0x00006310 File Offset: 0x00004510
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string SourceColumn
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableCrossTable.SourceColumnColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'SourceColumn' in table 'CrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableCrossTable.SourceColumnColumn] = value;
				}
			}

			// Token: 0x1700006A RID: 106
			// (get) Token: 0x06000106 RID: 262 RVA: 0x00006324 File Offset: 0x00004524
			// (set) Token: 0x06000107 RID: 263 RVA: 0x00006368 File Offset: 0x00004568
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string ReferredTable
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableCrossTable.ReferredTableColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'ReferredTable' in table 'CrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableCrossTable.ReferredTableColumn] = value;
				}
			}

			// Token: 0x1700006B RID: 107
			// (get) Token: 0x06000108 RID: 264 RVA: 0x0000637C File Offset: 0x0000457C
			// (set) Token: 0x06000109 RID: 265 RVA: 0x000063C0 File Offset: 0x000045C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string KeyColumn
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableCrossTable.KeyColumnColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'KeyColumn' in table 'CrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableCrossTable.KeyColumnColumn] = value;
				}
			}

			// Token: 0x1700006C RID: 108
			// (get) Token: 0x0600010A RID: 266 RVA: 0x000063D4 File Offset: 0x000045D4
			// (set) Token: 0x0600010B RID: 267 RVA: 0x00006418 File Offset: 0x00004618
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string DisplayColumn
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableCrossTable.DisplayColumnColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'DisplayColumn' in table 'CrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableCrossTable.DisplayColumnColumn] = value;
				}
			}

			// Token: 0x0600010C RID: 268 RVA: 0x0000642C File Offset: 0x0000462C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSourceTableNull()
			{
				return base.IsNull(this.tableCrossTable.SourceTableColumn);
			}

			// Token: 0x0600010D RID: 269 RVA: 0x0000643F File Offset: 0x0000463F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSourceTableNull()
			{
				base[this.tableCrossTable.SourceTableColumn] = Convert.DBNull;
			}

			// Token: 0x0600010E RID: 270 RVA: 0x00006457 File Offset: 0x00004657
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSourceColumnNull()
			{
				return base.IsNull(this.tableCrossTable.SourceColumnColumn);
			}

			// Token: 0x0600010F RID: 271 RVA: 0x0000646A File Offset: 0x0000466A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSourceColumnNull()
			{
				base[this.tableCrossTable.SourceColumnColumn] = Convert.DBNull;
			}

			// Token: 0x06000110 RID: 272 RVA: 0x00006482 File Offset: 0x00004682
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsReferredTableNull()
			{
				return base.IsNull(this.tableCrossTable.ReferredTableColumn);
			}

			// Token: 0x06000111 RID: 273 RVA: 0x00006495 File Offset: 0x00004695
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetReferredTableNull()
			{
				base[this.tableCrossTable.ReferredTableColumn] = Convert.DBNull;
			}

			// Token: 0x06000112 RID: 274 RVA: 0x000064AD File Offset: 0x000046AD
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsKeyColumnNull()
			{
				return base.IsNull(this.tableCrossTable.KeyColumnColumn);
			}

			// Token: 0x06000113 RID: 275 RVA: 0x000064C0 File Offset: 0x000046C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetKeyColumnNull()
			{
				base[this.tableCrossTable.KeyColumnColumn] = Convert.DBNull;
			}

			// Token: 0x06000114 RID: 276 RVA: 0x000064D8 File Offset: 0x000046D8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsDisplayColumnNull()
			{
				return base.IsNull(this.tableCrossTable.DisplayColumnColumn);
			}

			// Token: 0x06000115 RID: 277 RVA: 0x000064EB File Offset: 0x000046EB
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetDisplayColumnNull()
			{
				base[this.tableCrossTable.DisplayColumnColumn] = Convert.DBNull;
			}

			// Token: 0x04000075 RID: 117
			private IntelliEdit.CrossTableDataTable tableCrossTable;
		}

		// Token: 0x0200000D RID: 13
		public class DomainListRow : DataRow
		{
			// Token: 0x06000116 RID: 278 RVA: 0x00006503 File Offset: 0x00004703
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DomainListRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tableDomainList = (IntelliEdit.DomainListDataTable)base.Table;
			}

			// Token: 0x1700006D RID: 109
			// (get) Token: 0x06000117 RID: 279 RVA: 0x00006520 File Offset: 0x00004720
			// (set) Token: 0x06000118 RID: 280 RVA: 0x00006564 File Offset: 0x00004764
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Name
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.NameColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.NameColumn] = value;
				}
			}

			// Token: 0x1700006E RID: 110
			// (get) Token: 0x06000119 RID: 281 RVA: 0x00006578 File Offset: 0x00004778
			// (set) Token: 0x0600011A RID: 282 RVA: 0x000065BC File Offset: 0x000047BC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int TotalValues
			{
				get
				{
					int num;
					try
					{
						num = (int)base[this.tableDomainList.TotalValuesColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'TotalValues' in table 'DomainList' is DBNull.", ex);
					}
					return num;
				}
				set
				{
					base[this.tableDomainList.TotalValuesColumn] = value;
				}
			}

			// Token: 0x1700006F RID: 111
			// (get) Token: 0x0600011B RID: 283 RVA: 0x000065D8 File Offset: 0x000047D8
			// (set) Token: 0x0600011C RID: 284 RVA: 0x0000661C File Offset: 0x0000481C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value0
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value0Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value0' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value0Column] = value;
				}
			}

			// Token: 0x17000070 RID: 112
			// (get) Token: 0x0600011D RID: 285 RVA: 0x00006630 File Offset: 0x00004830
			// (set) Token: 0x0600011E RID: 286 RVA: 0x00006674 File Offset: 0x00004874
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value1
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value1Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value1' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value1Column] = value;
				}
			}

			// Token: 0x17000071 RID: 113
			// (get) Token: 0x0600011F RID: 287 RVA: 0x00006688 File Offset: 0x00004888
			// (set) Token: 0x06000120 RID: 288 RVA: 0x000066CC File Offset: 0x000048CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value2
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value2Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value2' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value2Column] = value;
				}
			}

			// Token: 0x17000072 RID: 114
			// (get) Token: 0x06000121 RID: 289 RVA: 0x000066E0 File Offset: 0x000048E0
			// (set) Token: 0x06000122 RID: 290 RVA: 0x00006724 File Offset: 0x00004924
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value3
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value3Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value3' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value3Column] = value;
				}
			}

			// Token: 0x17000073 RID: 115
			// (get) Token: 0x06000123 RID: 291 RVA: 0x00006738 File Offset: 0x00004938
			// (set) Token: 0x06000124 RID: 292 RVA: 0x0000677C File Offset: 0x0000497C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value4
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value4Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value4' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value4Column] = value;
				}
			}

			// Token: 0x17000074 RID: 116
			// (get) Token: 0x06000125 RID: 293 RVA: 0x00006790 File Offset: 0x00004990
			// (set) Token: 0x06000126 RID: 294 RVA: 0x000067D4 File Offset: 0x000049D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value5
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value5Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value5' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value5Column] = value;
				}
			}

			// Token: 0x17000075 RID: 117
			// (get) Token: 0x06000127 RID: 295 RVA: 0x000067E8 File Offset: 0x000049E8
			// (set) Token: 0x06000128 RID: 296 RVA: 0x0000682C File Offset: 0x00004A2C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value6
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value6Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value6' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value6Column] = value;
				}
			}

			// Token: 0x17000076 RID: 118
			// (get) Token: 0x06000129 RID: 297 RVA: 0x00006840 File Offset: 0x00004A40
			// (set) Token: 0x0600012A RID: 298 RVA: 0x00006884 File Offset: 0x00004A84
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value7
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value7Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value7' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value7Column] = value;
				}
			}

			// Token: 0x17000077 RID: 119
			// (get) Token: 0x0600012B RID: 299 RVA: 0x00006898 File Offset: 0x00004A98
			// (set) Token: 0x0600012C RID: 300 RVA: 0x000068DC File Offset: 0x00004ADC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value8
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value8Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value8' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value8Column] = value;
				}
			}

			// Token: 0x17000078 RID: 120
			// (get) Token: 0x0600012D RID: 301 RVA: 0x000068F0 File Offset: 0x00004AF0
			// (set) Token: 0x0600012E RID: 302 RVA: 0x00006934 File Offset: 0x00004B34
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value9
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value9Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value9' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value9Column] = value;
				}
			}

			// Token: 0x17000079 RID: 121
			// (get) Token: 0x0600012F RID: 303 RVA: 0x00006948 File Offset: 0x00004B48
			// (set) Token: 0x06000130 RID: 304 RVA: 0x0000698C File Offset: 0x00004B8C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value10
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value10Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value10' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value10Column] = value;
				}
			}

			// Token: 0x1700007A RID: 122
			// (get) Token: 0x06000131 RID: 305 RVA: 0x000069A0 File Offset: 0x00004BA0
			// (set) Token: 0x06000132 RID: 306 RVA: 0x000069E4 File Offset: 0x00004BE4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value11
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value11Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value11' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value11Column] = value;
				}
			}

			// Token: 0x1700007B RID: 123
			// (get) Token: 0x06000133 RID: 307 RVA: 0x000069F8 File Offset: 0x00004BF8
			// (set) Token: 0x06000134 RID: 308 RVA: 0x00006A3C File Offset: 0x00004C3C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value12
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value12Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value12' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value12Column] = value;
				}
			}

			// Token: 0x1700007C RID: 124
			// (get) Token: 0x06000135 RID: 309 RVA: 0x00006A50 File Offset: 0x00004C50
			// (set) Token: 0x06000136 RID: 310 RVA: 0x00006A94 File Offset: 0x00004C94
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value13
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value13Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value13' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value13Column] = value;
				}
			}

			// Token: 0x1700007D RID: 125
			// (get) Token: 0x06000137 RID: 311 RVA: 0x00006AA8 File Offset: 0x00004CA8
			// (set) Token: 0x06000138 RID: 312 RVA: 0x00006AEC File Offset: 0x00004CEC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value14
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value14Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value14' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value14Column] = value;
				}
			}

			// Token: 0x1700007E RID: 126
			// (get) Token: 0x06000139 RID: 313 RVA: 0x00006B00 File Offset: 0x00004D00
			// (set) Token: 0x0600013A RID: 314 RVA: 0x00006B44 File Offset: 0x00004D44
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value15
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value15Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value15' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value15Column] = value;
				}
			}

			// Token: 0x1700007F RID: 127
			// (get) Token: 0x0600013B RID: 315 RVA: 0x00006B58 File Offset: 0x00004D58
			// (set) Token: 0x0600013C RID: 316 RVA: 0x00006B9C File Offset: 0x00004D9C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value16
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value16Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value16' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value16Column] = value;
				}
			}

			// Token: 0x17000080 RID: 128
			// (get) Token: 0x0600013D RID: 317 RVA: 0x00006BB0 File Offset: 0x00004DB0
			// (set) Token: 0x0600013E RID: 318 RVA: 0x00006BF4 File Offset: 0x00004DF4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value17
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value17Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value17' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value17Column] = value;
				}
			}

			// Token: 0x17000081 RID: 129
			// (get) Token: 0x0600013F RID: 319 RVA: 0x00006C08 File Offset: 0x00004E08
			// (set) Token: 0x06000140 RID: 320 RVA: 0x00006C4C File Offset: 0x00004E4C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value18
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value18Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value18' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value18Column] = value;
				}
			}

			// Token: 0x17000082 RID: 130
			// (get) Token: 0x06000141 RID: 321 RVA: 0x00006C60 File Offset: 0x00004E60
			// (set) Token: 0x06000142 RID: 322 RVA: 0x00006CA4 File Offset: 0x00004EA4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value19
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value19Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value19' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value19Column] = value;
				}
			}

			// Token: 0x17000083 RID: 131
			// (get) Token: 0x06000143 RID: 323 RVA: 0x00006CB8 File Offset: 0x00004EB8
			// (set) Token: 0x06000144 RID: 324 RVA: 0x00006CFC File Offset: 0x00004EFC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value20
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value20Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value20' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value20Column] = value;
				}
			}

			// Token: 0x17000084 RID: 132
			// (get) Token: 0x06000145 RID: 325 RVA: 0x00006D10 File Offset: 0x00004F10
			// (set) Token: 0x06000146 RID: 326 RVA: 0x00006D54 File Offset: 0x00004F54
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value21
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value21Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value21' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value21Column] = value;
				}
			}

			// Token: 0x17000085 RID: 133
			// (get) Token: 0x06000147 RID: 327 RVA: 0x00006D68 File Offset: 0x00004F68
			// (set) Token: 0x06000148 RID: 328 RVA: 0x00006DAC File Offset: 0x00004FAC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value22
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value22Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value22' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value22Column] = value;
				}
			}

			// Token: 0x17000086 RID: 134
			// (get) Token: 0x06000149 RID: 329 RVA: 0x00006DC0 File Offset: 0x00004FC0
			// (set) Token: 0x0600014A RID: 330 RVA: 0x00006E04 File Offset: 0x00005004
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value23
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value23Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value23' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value23Column] = value;
				}
			}

			// Token: 0x17000087 RID: 135
			// (get) Token: 0x0600014B RID: 331 RVA: 0x00006E18 File Offset: 0x00005018
			// (set) Token: 0x0600014C RID: 332 RVA: 0x00006E5C File Offset: 0x0000505C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value24
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value24Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value24' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value24Column] = value;
				}
			}

			// Token: 0x17000088 RID: 136
			// (get) Token: 0x0600014D RID: 333 RVA: 0x00006E70 File Offset: 0x00005070
			// (set) Token: 0x0600014E RID: 334 RVA: 0x00006EB4 File Offset: 0x000050B4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value25
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value25Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value25' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value25Column] = value;
				}
			}

			// Token: 0x17000089 RID: 137
			// (get) Token: 0x0600014F RID: 335 RVA: 0x00006EC8 File Offset: 0x000050C8
			// (set) Token: 0x06000150 RID: 336 RVA: 0x00006F0C File Offset: 0x0000510C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value26
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value26Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value26' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value26Column] = value;
				}
			}

			// Token: 0x1700008A RID: 138
			// (get) Token: 0x06000151 RID: 337 RVA: 0x00006F20 File Offset: 0x00005120
			// (set) Token: 0x06000152 RID: 338 RVA: 0x00006F64 File Offset: 0x00005164
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value27
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value27Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value27' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value27Column] = value;
				}
			}

			// Token: 0x1700008B RID: 139
			// (get) Token: 0x06000153 RID: 339 RVA: 0x00006F78 File Offset: 0x00005178
			// (set) Token: 0x06000154 RID: 340 RVA: 0x00006FBC File Offset: 0x000051BC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value28
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value28Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value28' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value28Column] = value;
				}
			}

			// Token: 0x1700008C RID: 140
			// (get) Token: 0x06000155 RID: 341 RVA: 0x00006FD0 File Offset: 0x000051D0
			// (set) Token: 0x06000156 RID: 342 RVA: 0x00007014 File Offset: 0x00005214
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value29
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value29Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value29' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value29Column] = value;
				}
			}

			// Token: 0x1700008D RID: 141
			// (get) Token: 0x06000157 RID: 343 RVA: 0x00007028 File Offset: 0x00005228
			// (set) Token: 0x06000158 RID: 344 RVA: 0x0000706C File Offset: 0x0000526C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value30
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value30Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value30' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value30Column] = value;
				}
			}

			// Token: 0x1700008E RID: 142
			// (get) Token: 0x06000159 RID: 345 RVA: 0x00007080 File Offset: 0x00005280
			// (set) Token: 0x0600015A RID: 346 RVA: 0x000070C4 File Offset: 0x000052C4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value31
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value31Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value31' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value31Column] = value;
				}
			}

			// Token: 0x1700008F RID: 143
			// (get) Token: 0x0600015B RID: 347 RVA: 0x000070D8 File Offset: 0x000052D8
			// (set) Token: 0x0600015C RID: 348 RVA: 0x0000711C File Offset: 0x0000531C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value32
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value32Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value32' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value32Column] = value;
				}
			}

			// Token: 0x17000090 RID: 144
			// (get) Token: 0x0600015D RID: 349 RVA: 0x00007130 File Offset: 0x00005330
			// (set) Token: 0x0600015E RID: 350 RVA: 0x00007174 File Offset: 0x00005374
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value33
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value33Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value33' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value33Column] = value;
				}
			}

			// Token: 0x17000091 RID: 145
			// (get) Token: 0x0600015F RID: 351 RVA: 0x00007188 File Offset: 0x00005388
			// (set) Token: 0x06000160 RID: 352 RVA: 0x000071CC File Offset: 0x000053CC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value34
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value34Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value34' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value34Column] = value;
				}
			}

			// Token: 0x17000092 RID: 146
			// (get) Token: 0x06000161 RID: 353 RVA: 0x000071E0 File Offset: 0x000053E0
			// (set) Token: 0x06000162 RID: 354 RVA: 0x00007224 File Offset: 0x00005424
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value35
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value35Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value35' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value35Column] = value;
				}
			}

			// Token: 0x17000093 RID: 147
			// (get) Token: 0x06000163 RID: 355 RVA: 0x00007238 File Offset: 0x00005438
			// (set) Token: 0x06000164 RID: 356 RVA: 0x0000727C File Offset: 0x0000547C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value36
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value36Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value36' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value36Column] = value;
				}
			}

			// Token: 0x17000094 RID: 148
			// (get) Token: 0x06000165 RID: 357 RVA: 0x00007290 File Offset: 0x00005490
			// (set) Token: 0x06000166 RID: 358 RVA: 0x000072D4 File Offset: 0x000054D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value37
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value37Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value37' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value37Column] = value;
				}
			}

			// Token: 0x17000095 RID: 149
			// (get) Token: 0x06000167 RID: 359 RVA: 0x000072E8 File Offset: 0x000054E8
			// (set) Token: 0x06000168 RID: 360 RVA: 0x0000732C File Offset: 0x0000552C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value38
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value38Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value38' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value38Column] = value;
				}
			}

			// Token: 0x17000096 RID: 150
			// (get) Token: 0x06000169 RID: 361 RVA: 0x00007340 File Offset: 0x00005540
			// (set) Token: 0x0600016A RID: 362 RVA: 0x00007384 File Offset: 0x00005584
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value39
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value39Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value39' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value39Column] = value;
				}
			}

			// Token: 0x17000097 RID: 151
			// (get) Token: 0x0600016B RID: 363 RVA: 0x00007398 File Offset: 0x00005598
			// (set) Token: 0x0600016C RID: 364 RVA: 0x000073DC File Offset: 0x000055DC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value40
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value40Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value40' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value40Column] = value;
				}
			}

			// Token: 0x17000098 RID: 152
			// (get) Token: 0x0600016D RID: 365 RVA: 0x000073F0 File Offset: 0x000055F0
			// (set) Token: 0x0600016E RID: 366 RVA: 0x00007434 File Offset: 0x00005634
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value41
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value41Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value41' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value41Column] = value;
				}
			}

			// Token: 0x17000099 RID: 153
			// (get) Token: 0x0600016F RID: 367 RVA: 0x00007448 File Offset: 0x00005648
			// (set) Token: 0x06000170 RID: 368 RVA: 0x0000748C File Offset: 0x0000568C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value42
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value42Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value42' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value42Column] = value;
				}
			}

			// Token: 0x1700009A RID: 154
			// (get) Token: 0x06000171 RID: 369 RVA: 0x000074A0 File Offset: 0x000056A0
			// (set) Token: 0x06000172 RID: 370 RVA: 0x000074E4 File Offset: 0x000056E4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value43
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value43Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value43' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value43Column] = value;
				}
			}

			// Token: 0x1700009B RID: 155
			// (get) Token: 0x06000173 RID: 371 RVA: 0x000074F8 File Offset: 0x000056F8
			// (set) Token: 0x06000174 RID: 372 RVA: 0x0000753C File Offset: 0x0000573C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value44
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value44Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value44' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value44Column] = value;
				}
			}

			// Token: 0x1700009C RID: 156
			// (get) Token: 0x06000175 RID: 373 RVA: 0x00007550 File Offset: 0x00005750
			// (set) Token: 0x06000176 RID: 374 RVA: 0x00007594 File Offset: 0x00005794
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value45
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value45Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value45' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value45Column] = value;
				}
			}

			// Token: 0x1700009D RID: 157
			// (get) Token: 0x06000177 RID: 375 RVA: 0x000075A8 File Offset: 0x000057A8
			// (set) Token: 0x06000178 RID: 376 RVA: 0x000075EC File Offset: 0x000057EC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value46
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value46Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value46' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value46Column] = value;
				}
			}

			// Token: 0x1700009E RID: 158
			// (get) Token: 0x06000179 RID: 377 RVA: 0x00007600 File Offset: 0x00005800
			// (set) Token: 0x0600017A RID: 378 RVA: 0x00007644 File Offset: 0x00005844
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value47
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value47Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value47' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value47Column] = value;
				}
			}

			// Token: 0x1700009F RID: 159
			// (get) Token: 0x0600017B RID: 379 RVA: 0x00007658 File Offset: 0x00005858
			// (set) Token: 0x0600017C RID: 380 RVA: 0x0000769C File Offset: 0x0000589C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value48
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value48Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value48' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value48Column] = value;
				}
			}

			// Token: 0x170000A0 RID: 160
			// (get) Token: 0x0600017D RID: 381 RVA: 0x000076B0 File Offset: 0x000058B0
			// (set) Token: 0x0600017E RID: 382 RVA: 0x000076F4 File Offset: 0x000058F4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value49
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value49Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value49' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value49Column] = value;
				}
			}

			// Token: 0x170000A1 RID: 161
			// (get) Token: 0x0600017F RID: 383 RVA: 0x00007708 File Offset: 0x00005908
			// (set) Token: 0x06000180 RID: 384 RVA: 0x0000774C File Offset: 0x0000594C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value50
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value50Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value50' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value50Column] = value;
				}
			}

			// Token: 0x170000A2 RID: 162
			// (get) Token: 0x06000181 RID: 385 RVA: 0x00007760 File Offset: 0x00005960
			// (set) Token: 0x06000182 RID: 386 RVA: 0x000077A4 File Offset: 0x000059A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value51
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value51Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value51' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value51Column] = value;
				}
			}

			// Token: 0x170000A3 RID: 163
			// (get) Token: 0x06000183 RID: 387 RVA: 0x000077B8 File Offset: 0x000059B8
			// (set) Token: 0x06000184 RID: 388 RVA: 0x000077FC File Offset: 0x000059FC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value52
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value52Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value52' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value52Column] = value;
				}
			}

			// Token: 0x170000A4 RID: 164
			// (get) Token: 0x06000185 RID: 389 RVA: 0x00007810 File Offset: 0x00005A10
			// (set) Token: 0x06000186 RID: 390 RVA: 0x00007854 File Offset: 0x00005A54
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value53
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value53Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value53' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value53Column] = value;
				}
			}

			// Token: 0x170000A5 RID: 165
			// (get) Token: 0x06000187 RID: 391 RVA: 0x00007868 File Offset: 0x00005A68
			// (set) Token: 0x06000188 RID: 392 RVA: 0x000078AC File Offset: 0x00005AAC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value54
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value54Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value54' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value54Column] = value;
				}
			}

			// Token: 0x170000A6 RID: 166
			// (get) Token: 0x06000189 RID: 393 RVA: 0x000078C0 File Offset: 0x00005AC0
			// (set) Token: 0x0600018A RID: 394 RVA: 0x00007904 File Offset: 0x00005B04
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value55
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value55Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value55' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value55Column] = value;
				}
			}

			// Token: 0x170000A7 RID: 167
			// (get) Token: 0x0600018B RID: 395 RVA: 0x00007918 File Offset: 0x00005B18
			// (set) Token: 0x0600018C RID: 396 RVA: 0x0000795C File Offset: 0x00005B5C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value56
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value56Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value56' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value56Column] = value;
				}
			}

			// Token: 0x170000A8 RID: 168
			// (get) Token: 0x0600018D RID: 397 RVA: 0x00007970 File Offset: 0x00005B70
			// (set) Token: 0x0600018E RID: 398 RVA: 0x000079B4 File Offset: 0x00005BB4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value57
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value57Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value57' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value57Column] = value;
				}
			}

			// Token: 0x170000A9 RID: 169
			// (get) Token: 0x0600018F RID: 399 RVA: 0x000079C8 File Offset: 0x00005BC8
			// (set) Token: 0x06000190 RID: 400 RVA: 0x00007A0C File Offset: 0x00005C0C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value58
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value58Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value58' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value58Column] = value;
				}
			}

			// Token: 0x170000AA RID: 170
			// (get) Token: 0x06000191 RID: 401 RVA: 0x00007A20 File Offset: 0x00005C20
			// (set) Token: 0x06000192 RID: 402 RVA: 0x00007A64 File Offset: 0x00005C64
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value59
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value59Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value59' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value59Column] = value;
				}
			}

			// Token: 0x170000AB RID: 171
			// (get) Token: 0x06000193 RID: 403 RVA: 0x00007A78 File Offset: 0x00005C78
			// (set) Token: 0x06000194 RID: 404 RVA: 0x00007ABC File Offset: 0x00005CBC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value60
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value60Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value60' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value60Column] = value;
				}
			}

			// Token: 0x170000AC RID: 172
			// (get) Token: 0x06000195 RID: 405 RVA: 0x00007AD0 File Offset: 0x00005CD0
			// (set) Token: 0x06000196 RID: 406 RVA: 0x00007B14 File Offset: 0x00005D14
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value61
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value61Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value61' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value61Column] = value;
				}
			}

			// Token: 0x170000AD RID: 173
			// (get) Token: 0x06000197 RID: 407 RVA: 0x00007B28 File Offset: 0x00005D28
			// (set) Token: 0x06000198 RID: 408 RVA: 0x00007B6C File Offset: 0x00005D6C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value62
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value62Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value62' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value62Column] = value;
				}
			}

			// Token: 0x170000AE RID: 174
			// (get) Token: 0x06000199 RID: 409 RVA: 0x00007B80 File Offset: 0x00005D80
			// (set) Token: 0x0600019A RID: 410 RVA: 0x00007BC4 File Offset: 0x00005DC4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Value63
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value63Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value63' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value63Column] = value;
				}
			}

			// Token: 0x170000AF RID: 175
			// (get) Token: 0x0600019B RID: 411 RVA: 0x00007BD8 File Offset: 0x00005DD8
			// (set) Token: 0x0600019C RID: 412 RVA: 0x00007C1C File Offset: 0x00005E1C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value64
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDomainList.Value64Column];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Value64' in table 'DomainList' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDomainList.Value64Column] = value;
				}
			}

			// Token: 0x0600019D RID: 413 RVA: 0x00007C30 File Offset: 0x00005E30
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				return base.IsNull(this.tableDomainList.NameColumn);
			}

			// Token: 0x0600019E RID: 414 RVA: 0x00007C43 File Offset: 0x00005E43
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetNameNull()
			{
				base[this.tableDomainList.NameColumn] = Convert.DBNull;
			}

			// Token: 0x0600019F RID: 415 RVA: 0x00007C5B File Offset: 0x00005E5B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsTotalValuesNull()
			{
				return base.IsNull(this.tableDomainList.TotalValuesColumn);
			}

			// Token: 0x060001A0 RID: 416 RVA: 0x00007C6E File Offset: 0x00005E6E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetTotalValuesNull()
			{
				base[this.tableDomainList.TotalValuesColumn] = Convert.DBNull;
			}

			// Token: 0x060001A1 RID: 417 RVA: 0x00007C86 File Offset: 0x00005E86
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue0Null()
			{
				return base.IsNull(this.tableDomainList.Value0Column);
			}

			// Token: 0x060001A2 RID: 418 RVA: 0x00007C99 File Offset: 0x00005E99
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue0Null()
			{
				base[this.tableDomainList.Value0Column] = Convert.DBNull;
			}

			// Token: 0x060001A3 RID: 419 RVA: 0x00007CB1 File Offset: 0x00005EB1
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue1Null()
			{
				return base.IsNull(this.tableDomainList.Value1Column);
			}

			// Token: 0x060001A4 RID: 420 RVA: 0x00007CC4 File Offset: 0x00005EC4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue1Null()
			{
				base[this.tableDomainList.Value1Column] = Convert.DBNull;
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x00007CDC File Offset: 0x00005EDC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue2Null()
			{
				return base.IsNull(this.tableDomainList.Value2Column);
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x00007CEF File Offset: 0x00005EEF
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue2Null()
			{
				base[this.tableDomainList.Value2Column] = Convert.DBNull;
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x00007D07 File Offset: 0x00005F07
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue3Null()
			{
				return base.IsNull(this.tableDomainList.Value3Column);
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x00007D1A File Offset: 0x00005F1A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue3Null()
			{
				base[this.tableDomainList.Value3Column] = Convert.DBNull;
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x00007D32 File Offset: 0x00005F32
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue4Null()
			{
				return base.IsNull(this.tableDomainList.Value4Column);
			}

			// Token: 0x060001AA RID: 426 RVA: 0x00007D45 File Offset: 0x00005F45
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue4Null()
			{
				base[this.tableDomainList.Value4Column] = Convert.DBNull;
			}

			// Token: 0x060001AB RID: 427 RVA: 0x00007D5D File Offset: 0x00005F5D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue5Null()
			{
				return base.IsNull(this.tableDomainList.Value5Column);
			}

			// Token: 0x060001AC RID: 428 RVA: 0x00007D70 File Offset: 0x00005F70
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue5Null()
			{
				base[this.tableDomainList.Value5Column] = Convert.DBNull;
			}

			// Token: 0x060001AD RID: 429 RVA: 0x00007D88 File Offset: 0x00005F88
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue6Null()
			{
				return base.IsNull(this.tableDomainList.Value6Column);
			}

			// Token: 0x060001AE RID: 430 RVA: 0x00007D9B File Offset: 0x00005F9B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue6Null()
			{
				base[this.tableDomainList.Value6Column] = Convert.DBNull;
			}

			// Token: 0x060001AF RID: 431 RVA: 0x00007DB3 File Offset: 0x00005FB3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue7Null()
			{
				return base.IsNull(this.tableDomainList.Value7Column);
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x00007DC6 File Offset: 0x00005FC6
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue7Null()
			{
				base[this.tableDomainList.Value7Column] = Convert.DBNull;
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x00007DDE File Offset: 0x00005FDE
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue8Null()
			{
				return base.IsNull(this.tableDomainList.Value8Column);
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x00007DF1 File Offset: 0x00005FF1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue8Null()
			{
				base[this.tableDomainList.Value8Column] = Convert.DBNull;
			}

			// Token: 0x060001B3 RID: 435 RVA: 0x00007E09 File Offset: 0x00006009
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue9Null()
			{
				return base.IsNull(this.tableDomainList.Value9Column);
			}

			// Token: 0x060001B4 RID: 436 RVA: 0x00007E1C File Offset: 0x0000601C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue9Null()
			{
				base[this.tableDomainList.Value9Column] = Convert.DBNull;
			}

			// Token: 0x060001B5 RID: 437 RVA: 0x00007E34 File Offset: 0x00006034
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue10Null()
			{
				return base.IsNull(this.tableDomainList.Value10Column);
			}

			// Token: 0x060001B6 RID: 438 RVA: 0x00007E47 File Offset: 0x00006047
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue10Null()
			{
				base[this.tableDomainList.Value10Column] = Convert.DBNull;
			}

			// Token: 0x060001B7 RID: 439 RVA: 0x00007E5F File Offset: 0x0000605F
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue11Null()
			{
				return base.IsNull(this.tableDomainList.Value11Column);
			}

			// Token: 0x060001B8 RID: 440 RVA: 0x00007E72 File Offset: 0x00006072
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue11Null()
			{
				base[this.tableDomainList.Value11Column] = Convert.DBNull;
			}

			// Token: 0x060001B9 RID: 441 RVA: 0x00007E8A File Offset: 0x0000608A
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue12Null()
			{
				return base.IsNull(this.tableDomainList.Value12Column);
			}

			// Token: 0x060001BA RID: 442 RVA: 0x00007E9D File Offset: 0x0000609D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue12Null()
			{
				base[this.tableDomainList.Value12Column] = Convert.DBNull;
			}

			// Token: 0x060001BB RID: 443 RVA: 0x00007EB5 File Offset: 0x000060B5
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue13Null()
			{
				return base.IsNull(this.tableDomainList.Value13Column);
			}

			// Token: 0x060001BC RID: 444 RVA: 0x00007EC8 File Offset: 0x000060C8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue13Null()
			{
				base[this.tableDomainList.Value13Column] = Convert.DBNull;
			}

			// Token: 0x060001BD RID: 445 RVA: 0x00007EE0 File Offset: 0x000060E0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue14Null()
			{
				return base.IsNull(this.tableDomainList.Value14Column);
			}

			// Token: 0x060001BE RID: 446 RVA: 0x00007EF3 File Offset: 0x000060F3
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue14Null()
			{
				base[this.tableDomainList.Value14Column] = Convert.DBNull;
			}

			// Token: 0x060001BF RID: 447 RVA: 0x00007F0B File Offset: 0x0000610B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue15Null()
			{
				return base.IsNull(this.tableDomainList.Value15Column);
			}

			// Token: 0x060001C0 RID: 448 RVA: 0x00007F1E File Offset: 0x0000611E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue15Null()
			{
				base[this.tableDomainList.Value15Column] = Convert.DBNull;
			}

			// Token: 0x060001C1 RID: 449 RVA: 0x00007F36 File Offset: 0x00006136
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue16Null()
			{
				return base.IsNull(this.tableDomainList.Value16Column);
			}

			// Token: 0x060001C2 RID: 450 RVA: 0x00007F49 File Offset: 0x00006149
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue16Null()
			{
				base[this.tableDomainList.Value16Column] = Convert.DBNull;
			}

			// Token: 0x060001C3 RID: 451 RVA: 0x00007F61 File Offset: 0x00006161
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue17Null()
			{
				return base.IsNull(this.tableDomainList.Value17Column);
			}

			// Token: 0x060001C4 RID: 452 RVA: 0x00007F74 File Offset: 0x00006174
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue17Null()
			{
				base[this.tableDomainList.Value17Column] = Convert.DBNull;
			}

			// Token: 0x060001C5 RID: 453 RVA: 0x00007F8C File Offset: 0x0000618C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue18Null()
			{
				return base.IsNull(this.tableDomainList.Value18Column);
			}

			// Token: 0x060001C6 RID: 454 RVA: 0x00007F9F File Offset: 0x0000619F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue18Null()
			{
				base[this.tableDomainList.Value18Column] = Convert.DBNull;
			}

			// Token: 0x060001C7 RID: 455 RVA: 0x00007FB7 File Offset: 0x000061B7
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue19Null()
			{
				return base.IsNull(this.tableDomainList.Value19Column);
			}

			// Token: 0x060001C8 RID: 456 RVA: 0x00007FCA File Offset: 0x000061CA
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue19Null()
			{
				base[this.tableDomainList.Value19Column] = Convert.DBNull;
			}

			// Token: 0x060001C9 RID: 457 RVA: 0x00007FE2 File Offset: 0x000061E2
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue20Null()
			{
				return base.IsNull(this.tableDomainList.Value20Column);
			}

			// Token: 0x060001CA RID: 458 RVA: 0x00007FF5 File Offset: 0x000061F5
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue20Null()
			{
				base[this.tableDomainList.Value20Column] = Convert.DBNull;
			}

			// Token: 0x060001CB RID: 459 RVA: 0x0000800D File Offset: 0x0000620D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue21Null()
			{
				return base.IsNull(this.tableDomainList.Value21Column);
			}

			// Token: 0x060001CC RID: 460 RVA: 0x00008020 File Offset: 0x00006220
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue21Null()
			{
				base[this.tableDomainList.Value21Column] = Convert.DBNull;
			}

			// Token: 0x060001CD RID: 461 RVA: 0x00008038 File Offset: 0x00006238
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue22Null()
			{
				return base.IsNull(this.tableDomainList.Value22Column);
			}

			// Token: 0x060001CE RID: 462 RVA: 0x0000804B File Offset: 0x0000624B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue22Null()
			{
				base[this.tableDomainList.Value22Column] = Convert.DBNull;
			}

			// Token: 0x060001CF RID: 463 RVA: 0x00008063 File Offset: 0x00006263
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue23Null()
			{
				return base.IsNull(this.tableDomainList.Value23Column);
			}

			// Token: 0x060001D0 RID: 464 RVA: 0x00008076 File Offset: 0x00006276
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue23Null()
			{
				base[this.tableDomainList.Value23Column] = Convert.DBNull;
			}

			// Token: 0x060001D1 RID: 465 RVA: 0x0000808E File Offset: 0x0000628E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue24Null()
			{
				return base.IsNull(this.tableDomainList.Value24Column);
			}

			// Token: 0x060001D2 RID: 466 RVA: 0x000080A1 File Offset: 0x000062A1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue24Null()
			{
				base[this.tableDomainList.Value24Column] = Convert.DBNull;
			}

			// Token: 0x060001D3 RID: 467 RVA: 0x000080B9 File Offset: 0x000062B9
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue25Null()
			{
				return base.IsNull(this.tableDomainList.Value25Column);
			}

			// Token: 0x060001D4 RID: 468 RVA: 0x000080CC File Offset: 0x000062CC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue25Null()
			{
				base[this.tableDomainList.Value25Column] = Convert.DBNull;
			}

			// Token: 0x060001D5 RID: 469 RVA: 0x000080E4 File Offset: 0x000062E4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue26Null()
			{
				return base.IsNull(this.tableDomainList.Value26Column);
			}

			// Token: 0x060001D6 RID: 470 RVA: 0x000080F7 File Offset: 0x000062F7
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue26Null()
			{
				base[this.tableDomainList.Value26Column] = Convert.DBNull;
			}

			// Token: 0x060001D7 RID: 471 RVA: 0x0000810F File Offset: 0x0000630F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue27Null()
			{
				return base.IsNull(this.tableDomainList.Value27Column);
			}

			// Token: 0x060001D8 RID: 472 RVA: 0x00008122 File Offset: 0x00006322
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue27Null()
			{
				base[this.tableDomainList.Value27Column] = Convert.DBNull;
			}

			// Token: 0x060001D9 RID: 473 RVA: 0x0000813A File Offset: 0x0000633A
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue28Null()
			{
				return base.IsNull(this.tableDomainList.Value28Column);
			}

			// Token: 0x060001DA RID: 474 RVA: 0x0000814D File Offset: 0x0000634D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue28Null()
			{
				base[this.tableDomainList.Value28Column] = Convert.DBNull;
			}

			// Token: 0x060001DB RID: 475 RVA: 0x00008165 File Offset: 0x00006365
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue29Null()
			{
				return base.IsNull(this.tableDomainList.Value29Column);
			}

			// Token: 0x060001DC RID: 476 RVA: 0x00008178 File Offset: 0x00006378
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue29Null()
			{
				base[this.tableDomainList.Value29Column] = Convert.DBNull;
			}

			// Token: 0x060001DD RID: 477 RVA: 0x00008190 File Offset: 0x00006390
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue30Null()
			{
				return base.IsNull(this.tableDomainList.Value30Column);
			}

			// Token: 0x060001DE RID: 478 RVA: 0x000081A3 File Offset: 0x000063A3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue30Null()
			{
				base[this.tableDomainList.Value30Column] = Convert.DBNull;
			}

			// Token: 0x060001DF RID: 479 RVA: 0x000081BB File Offset: 0x000063BB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue31Null()
			{
				return base.IsNull(this.tableDomainList.Value31Column);
			}

			// Token: 0x060001E0 RID: 480 RVA: 0x000081CE File Offset: 0x000063CE
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue31Null()
			{
				base[this.tableDomainList.Value31Column] = Convert.DBNull;
			}

			// Token: 0x060001E1 RID: 481 RVA: 0x000081E6 File Offset: 0x000063E6
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue32Null()
			{
				return base.IsNull(this.tableDomainList.Value32Column);
			}

			// Token: 0x060001E2 RID: 482 RVA: 0x000081F9 File Offset: 0x000063F9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue32Null()
			{
				base[this.tableDomainList.Value32Column] = Convert.DBNull;
			}

			// Token: 0x060001E3 RID: 483 RVA: 0x00008211 File Offset: 0x00006411
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue33Null()
			{
				return base.IsNull(this.tableDomainList.Value33Column);
			}

			// Token: 0x060001E4 RID: 484 RVA: 0x00008224 File Offset: 0x00006424
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue33Null()
			{
				base[this.tableDomainList.Value33Column] = Convert.DBNull;
			}

			// Token: 0x060001E5 RID: 485 RVA: 0x0000823C File Offset: 0x0000643C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue34Null()
			{
				return base.IsNull(this.tableDomainList.Value34Column);
			}

			// Token: 0x060001E6 RID: 486 RVA: 0x0000824F File Offset: 0x0000644F
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue34Null()
			{
				base[this.tableDomainList.Value34Column] = Convert.DBNull;
			}

			// Token: 0x060001E7 RID: 487 RVA: 0x00008267 File Offset: 0x00006467
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue35Null()
			{
				return base.IsNull(this.tableDomainList.Value35Column);
			}

			// Token: 0x060001E8 RID: 488 RVA: 0x0000827A File Offset: 0x0000647A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue35Null()
			{
				base[this.tableDomainList.Value35Column] = Convert.DBNull;
			}

			// Token: 0x060001E9 RID: 489 RVA: 0x00008292 File Offset: 0x00006492
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue36Null()
			{
				return base.IsNull(this.tableDomainList.Value36Column);
			}

			// Token: 0x060001EA RID: 490 RVA: 0x000082A5 File Offset: 0x000064A5
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue36Null()
			{
				base[this.tableDomainList.Value36Column] = Convert.DBNull;
			}

			// Token: 0x060001EB RID: 491 RVA: 0x000082BD File Offset: 0x000064BD
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue37Null()
			{
				return base.IsNull(this.tableDomainList.Value37Column);
			}

			// Token: 0x060001EC RID: 492 RVA: 0x000082D0 File Offset: 0x000064D0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue37Null()
			{
				base[this.tableDomainList.Value37Column] = Convert.DBNull;
			}

			// Token: 0x060001ED RID: 493 RVA: 0x000082E8 File Offset: 0x000064E8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue38Null()
			{
				return base.IsNull(this.tableDomainList.Value38Column);
			}

			// Token: 0x060001EE RID: 494 RVA: 0x000082FB File Offset: 0x000064FB
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue38Null()
			{
				base[this.tableDomainList.Value38Column] = Convert.DBNull;
			}

			// Token: 0x060001EF RID: 495 RVA: 0x00008313 File Offset: 0x00006513
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue39Null()
			{
				return base.IsNull(this.tableDomainList.Value39Column);
			}

			// Token: 0x060001F0 RID: 496 RVA: 0x00008326 File Offset: 0x00006526
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue39Null()
			{
				base[this.tableDomainList.Value39Column] = Convert.DBNull;
			}

			// Token: 0x060001F1 RID: 497 RVA: 0x0000833E File Offset: 0x0000653E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue40Null()
			{
				return base.IsNull(this.tableDomainList.Value40Column);
			}

			// Token: 0x060001F2 RID: 498 RVA: 0x00008351 File Offset: 0x00006551
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue40Null()
			{
				base[this.tableDomainList.Value40Column] = Convert.DBNull;
			}

			// Token: 0x060001F3 RID: 499 RVA: 0x00008369 File Offset: 0x00006569
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue41Null()
			{
				return base.IsNull(this.tableDomainList.Value41Column);
			}

			// Token: 0x060001F4 RID: 500 RVA: 0x0000837C File Offset: 0x0000657C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue41Null()
			{
				base[this.tableDomainList.Value41Column] = Convert.DBNull;
			}

			// Token: 0x060001F5 RID: 501 RVA: 0x00008394 File Offset: 0x00006594
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue42Null()
			{
				return base.IsNull(this.tableDomainList.Value42Column);
			}

			// Token: 0x060001F6 RID: 502 RVA: 0x000083A7 File Offset: 0x000065A7
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue42Null()
			{
				base[this.tableDomainList.Value42Column] = Convert.DBNull;
			}

			// Token: 0x060001F7 RID: 503 RVA: 0x000083BF File Offset: 0x000065BF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue43Null()
			{
				return base.IsNull(this.tableDomainList.Value43Column);
			}

			// Token: 0x060001F8 RID: 504 RVA: 0x000083D2 File Offset: 0x000065D2
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue43Null()
			{
				base[this.tableDomainList.Value43Column] = Convert.DBNull;
			}

			// Token: 0x060001F9 RID: 505 RVA: 0x000083EA File Offset: 0x000065EA
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue44Null()
			{
				return base.IsNull(this.tableDomainList.Value44Column);
			}

			// Token: 0x060001FA RID: 506 RVA: 0x000083FD File Offset: 0x000065FD
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue44Null()
			{
				base[this.tableDomainList.Value44Column] = Convert.DBNull;
			}

			// Token: 0x060001FB RID: 507 RVA: 0x00008415 File Offset: 0x00006615
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue45Null()
			{
				return base.IsNull(this.tableDomainList.Value45Column);
			}

			// Token: 0x060001FC RID: 508 RVA: 0x00008428 File Offset: 0x00006628
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue45Null()
			{
				base[this.tableDomainList.Value45Column] = Convert.DBNull;
			}

			// Token: 0x060001FD RID: 509 RVA: 0x00008440 File Offset: 0x00006640
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue46Null()
			{
				return base.IsNull(this.tableDomainList.Value46Column);
			}

			// Token: 0x060001FE RID: 510 RVA: 0x00008453 File Offset: 0x00006653
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue46Null()
			{
				base[this.tableDomainList.Value46Column] = Convert.DBNull;
			}

			// Token: 0x060001FF RID: 511 RVA: 0x0000846B File Offset: 0x0000666B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue47Null()
			{
				return base.IsNull(this.tableDomainList.Value47Column);
			}

			// Token: 0x06000200 RID: 512 RVA: 0x0000847E File Offset: 0x0000667E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue47Null()
			{
				base[this.tableDomainList.Value47Column] = Convert.DBNull;
			}

			// Token: 0x06000201 RID: 513 RVA: 0x00008496 File Offset: 0x00006696
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue48Null()
			{
				return base.IsNull(this.tableDomainList.Value48Column);
			}

			// Token: 0x06000202 RID: 514 RVA: 0x000084A9 File Offset: 0x000066A9
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue48Null()
			{
				base[this.tableDomainList.Value48Column] = Convert.DBNull;
			}

			// Token: 0x06000203 RID: 515 RVA: 0x000084C1 File Offset: 0x000066C1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue49Null()
			{
				return base.IsNull(this.tableDomainList.Value49Column);
			}

			// Token: 0x06000204 RID: 516 RVA: 0x000084D4 File Offset: 0x000066D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue49Null()
			{
				base[this.tableDomainList.Value49Column] = Convert.DBNull;
			}

			// Token: 0x06000205 RID: 517 RVA: 0x000084EC File Offset: 0x000066EC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue50Null()
			{
				return base.IsNull(this.tableDomainList.Value50Column);
			}

			// Token: 0x06000206 RID: 518 RVA: 0x000084FF File Offset: 0x000066FF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue50Null()
			{
				base[this.tableDomainList.Value50Column] = Convert.DBNull;
			}

			// Token: 0x06000207 RID: 519 RVA: 0x00008517 File Offset: 0x00006717
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue51Null()
			{
				return base.IsNull(this.tableDomainList.Value51Column);
			}

			// Token: 0x06000208 RID: 520 RVA: 0x0000852A File Offset: 0x0000672A
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue51Null()
			{
				base[this.tableDomainList.Value51Column] = Convert.DBNull;
			}

			// Token: 0x06000209 RID: 521 RVA: 0x00008542 File Offset: 0x00006742
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue52Null()
			{
				return base.IsNull(this.tableDomainList.Value52Column);
			}

			// Token: 0x0600020A RID: 522 RVA: 0x00008555 File Offset: 0x00006755
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue52Null()
			{
				base[this.tableDomainList.Value52Column] = Convert.DBNull;
			}

			// Token: 0x0600020B RID: 523 RVA: 0x0000856D File Offset: 0x0000676D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue53Null()
			{
				return base.IsNull(this.tableDomainList.Value53Column);
			}

			// Token: 0x0600020C RID: 524 RVA: 0x00008580 File Offset: 0x00006780
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue53Null()
			{
				base[this.tableDomainList.Value53Column] = Convert.DBNull;
			}

			// Token: 0x0600020D RID: 525 RVA: 0x00008598 File Offset: 0x00006798
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue54Null()
			{
				return base.IsNull(this.tableDomainList.Value54Column);
			}

			// Token: 0x0600020E RID: 526 RVA: 0x000085AB File Offset: 0x000067AB
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue54Null()
			{
				base[this.tableDomainList.Value54Column] = Convert.DBNull;
			}

			// Token: 0x0600020F RID: 527 RVA: 0x000085C3 File Offset: 0x000067C3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue55Null()
			{
				return base.IsNull(this.tableDomainList.Value55Column);
			}

			// Token: 0x06000210 RID: 528 RVA: 0x000085D6 File Offset: 0x000067D6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue55Null()
			{
				base[this.tableDomainList.Value55Column] = Convert.DBNull;
			}

			// Token: 0x06000211 RID: 529 RVA: 0x000085EE File Offset: 0x000067EE
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue56Null()
			{
				return base.IsNull(this.tableDomainList.Value56Column);
			}

			// Token: 0x06000212 RID: 530 RVA: 0x00008601 File Offset: 0x00006801
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue56Null()
			{
				base[this.tableDomainList.Value56Column] = Convert.DBNull;
			}

			// Token: 0x06000213 RID: 531 RVA: 0x00008619 File Offset: 0x00006819
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue57Null()
			{
				return base.IsNull(this.tableDomainList.Value57Column);
			}

			// Token: 0x06000214 RID: 532 RVA: 0x0000862C File Offset: 0x0000682C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue57Null()
			{
				base[this.tableDomainList.Value57Column] = Convert.DBNull;
			}

			// Token: 0x06000215 RID: 533 RVA: 0x00008644 File Offset: 0x00006844
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue58Null()
			{
				return base.IsNull(this.tableDomainList.Value58Column);
			}

			// Token: 0x06000216 RID: 534 RVA: 0x00008657 File Offset: 0x00006857
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue58Null()
			{
				base[this.tableDomainList.Value58Column] = Convert.DBNull;
			}

			// Token: 0x06000217 RID: 535 RVA: 0x0000866F File Offset: 0x0000686F
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue59Null()
			{
				return base.IsNull(this.tableDomainList.Value59Column);
			}

			// Token: 0x06000218 RID: 536 RVA: 0x00008682 File Offset: 0x00006882
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue59Null()
			{
				base[this.tableDomainList.Value59Column] = Convert.DBNull;
			}

			// Token: 0x06000219 RID: 537 RVA: 0x0000869A File Offset: 0x0000689A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsValue60Null()
			{
				return base.IsNull(this.tableDomainList.Value60Column);
			}

			// Token: 0x0600021A RID: 538 RVA: 0x000086AD File Offset: 0x000068AD
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue60Null()
			{
				base[this.tableDomainList.Value60Column] = Convert.DBNull;
			}

			// Token: 0x0600021B RID: 539 RVA: 0x000086C5 File Offset: 0x000068C5
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue61Null()
			{
				return base.IsNull(this.tableDomainList.Value61Column);
			}

			// Token: 0x0600021C RID: 540 RVA: 0x000086D8 File Offset: 0x000068D8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue61Null()
			{
				base[this.tableDomainList.Value61Column] = Convert.DBNull;
			}

			// Token: 0x0600021D RID: 541 RVA: 0x000086F0 File Offset: 0x000068F0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue62Null()
			{
				return base.IsNull(this.tableDomainList.Value62Column);
			}

			// Token: 0x0600021E RID: 542 RVA: 0x00008703 File Offset: 0x00006903
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue62Null()
			{
				base[this.tableDomainList.Value62Column] = Convert.DBNull;
			}

			// Token: 0x0600021F RID: 543 RVA: 0x0000871B File Offset: 0x0000691B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue63Null()
			{
				return base.IsNull(this.tableDomainList.Value63Column);
			}

			// Token: 0x06000220 RID: 544 RVA: 0x0000872E File Offset: 0x0000692E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetValue63Null()
			{
				base[this.tableDomainList.Value63Column] = Convert.DBNull;
			}

			// Token: 0x06000221 RID: 545 RVA: 0x00008746 File Offset: 0x00006946
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsValue64Null()
			{
				return base.IsNull(this.tableDomainList.Value64Column);
			}

			// Token: 0x06000222 RID: 546 RVA: 0x00008759 File Offset: 0x00006959
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetValue64Null()
			{
				base[this.tableDomainList.Value64Column] = Convert.DBNull;
			}

			// Token: 0x04000076 RID: 118
			private IntelliEdit.DomainListDataTable tableDomainList;
		}

		// Token: 0x0200000E RID: 14
		public class UseDomainRow : DataRow
		{
			// Token: 0x06000223 RID: 547 RVA: 0x00008771 File Offset: 0x00006971
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal UseDomainRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tableUseDomain = (IntelliEdit.UseDomainDataTable)base.Table;
			}

			// Token: 0x170000B0 RID: 176
			// (get) Token: 0x06000224 RID: 548 RVA: 0x0000878C File Offset: 0x0000698C
			// (set) Token: 0x06000225 RID: 549 RVA: 0x000087D0 File Offset: 0x000069D0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string SourceTable
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableUseDomain.SourceTableColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'SourceTable' in table 'UseDomain' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableUseDomain.SourceTableColumn] = value;
				}
			}

			// Token: 0x170000B1 RID: 177
			// (get) Token: 0x06000226 RID: 550 RVA: 0x000087E4 File Offset: 0x000069E4
			// (set) Token: 0x06000227 RID: 551 RVA: 0x00008828 File Offset: 0x00006A28
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string SourceColumn
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableUseDomain.SourceColumnColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'SourceColumn' in table 'UseDomain' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableUseDomain.SourceColumnColumn] = value;
				}
			}

			// Token: 0x170000B2 RID: 178
			// (get) Token: 0x06000228 RID: 552 RVA: 0x0000883C File Offset: 0x00006A3C
			// (set) Token: 0x06000229 RID: 553 RVA: 0x00008880 File Offset: 0x00006A80
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string DomainName
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableUseDomain.DomainNameColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'DomainName' in table 'UseDomain' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableUseDomain.DomainNameColumn] = value;
				}
			}

			// Token: 0x0600022A RID: 554 RVA: 0x00008894 File Offset: 0x00006A94
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSourceTableNull()
			{
				return base.IsNull(this.tableUseDomain.SourceTableColumn);
			}

			// Token: 0x0600022B RID: 555 RVA: 0x000088A7 File Offset: 0x00006AA7
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetSourceTableNull()
			{
				base[this.tableUseDomain.SourceTableColumn] = Convert.DBNull;
			}

			// Token: 0x0600022C RID: 556 RVA: 0x000088BF File Offset: 0x00006ABF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsSourceColumnNull()
			{
				return base.IsNull(this.tableUseDomain.SourceColumnColumn);
			}

			// Token: 0x0600022D RID: 557 RVA: 0x000088D2 File Offset: 0x00006AD2
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSourceColumnNull()
			{
				base[this.tableUseDomain.SourceColumnColumn] = Convert.DBNull;
			}

			// Token: 0x0600022E RID: 558 RVA: 0x000088EA File Offset: 0x00006AEA
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsDomainNameNull()
			{
				return base.IsNull(this.tableUseDomain.DomainNameColumn);
			}

			// Token: 0x0600022F RID: 559 RVA: 0x000088FD File Offset: 0x00006AFD
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDomainNameNull()
			{
				base[this.tableUseDomain.DomainNameColumn] = Convert.DBNull;
			}

			// Token: 0x04000077 RID: 119
			private IntelliEdit.UseDomainDataTable tableUseDomain;
		}

		// Token: 0x0200000F RID: 15
		public class DoubleCrossTableRow : DataRow
		{
			// Token: 0x06000230 RID: 560 RVA: 0x00008915 File Offset: 0x00006B15
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DoubleCrossTableRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tableDoubleCrossTable = (IntelliEdit.DoubleCrossTableDataTable)base.Table;
			}

			// Token: 0x170000B3 RID: 179
			// (get) Token: 0x06000231 RID: 561 RVA: 0x00008930 File Offset: 0x00006B30
			// (set) Token: 0x06000232 RID: 562 RVA: 0x00008974 File Offset: 0x00006B74
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string SourceTable
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDoubleCrossTable.SourceTableColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'SourceTable' in table 'DoubleCrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDoubleCrossTable.SourceTableColumn] = value;
				}
			}

			// Token: 0x170000B4 RID: 180
			// (get) Token: 0x06000233 RID: 563 RVA: 0x00008988 File Offset: 0x00006B88
			// (set) Token: 0x06000234 RID: 564 RVA: 0x000089CC File Offset: 0x00006BCC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string SourceColumn
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDoubleCrossTable.SourceColumnColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'SourceColumn' in table 'DoubleCrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDoubleCrossTable.SourceColumnColumn] = value;
				}
			}

			// Token: 0x170000B5 RID: 181
			// (get) Token: 0x06000235 RID: 565 RVA: 0x000089E0 File Offset: 0x00006BE0
			// (set) Token: 0x06000236 RID: 566 RVA: 0x00008A24 File Offset: 0x00006C24
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string IntermediateTable
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDoubleCrossTable.IntermediateTableColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'IntermediateTable' in table 'DoubleCrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDoubleCrossTable.IntermediateTableColumn] = value;
				}
			}

			// Token: 0x170000B6 RID: 182
			// (get) Token: 0x06000237 RID: 567 RVA: 0x00008A38 File Offset: 0x00006C38
			// (set) Token: 0x06000238 RID: 568 RVA: 0x00008A7C File Offset: 0x00006C7C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string IntermediateKeyColumn
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDoubleCrossTable.IntermediateKeyColumnColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'IntermediateKeyColumn' in table 'DoubleCrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDoubleCrossTable.IntermediateKeyColumnColumn] = value;
				}
			}

			// Token: 0x170000B7 RID: 183
			// (get) Token: 0x06000239 RID: 569 RVA: 0x00008A90 File Offset: 0x00006C90
			// (set) Token: 0x0600023A RID: 570 RVA: 0x00008AD4 File Offset: 0x00006CD4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string IntermediateJumpColumn
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDoubleCrossTable.IntermediateJumpColumnColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'IntermediateJumpColumn' in table 'DoubleCrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDoubleCrossTable.IntermediateJumpColumnColumn] = value;
				}
			}

			// Token: 0x170000B8 RID: 184
			// (get) Token: 0x0600023B RID: 571 RVA: 0x00008AE8 File Offset: 0x00006CE8
			// (set) Token: 0x0600023C RID: 572 RVA: 0x00008B2C File Offset: 0x00006D2C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ReferredTable
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDoubleCrossTable.ReferredTableColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'ReferredTable' in table 'DoubleCrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDoubleCrossTable.ReferredTableColumn] = value;
				}
			}

			// Token: 0x170000B9 RID: 185
			// (get) Token: 0x0600023D RID: 573 RVA: 0x00008B40 File Offset: 0x00006D40
			// (set) Token: 0x0600023E RID: 574 RVA: 0x00008B84 File Offset: 0x00006D84
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string KeyColumn
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDoubleCrossTable.KeyColumnColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'KeyColumn' in table 'DoubleCrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDoubleCrossTable.KeyColumnColumn] = value;
				}
			}

			// Token: 0x170000BA RID: 186
			// (get) Token: 0x0600023F RID: 575 RVA: 0x00008B98 File Offset: 0x00006D98
			// (set) Token: 0x06000240 RID: 576 RVA: 0x00008BDC File Offset: 0x00006DDC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string DisplayColumn
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableDoubleCrossTable.DisplayColumnColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'DisplayColumn' in table 'DoubleCrossTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableDoubleCrossTable.DisplayColumnColumn] = value;
				}
			}

			// Token: 0x06000241 RID: 577 RVA: 0x00008BF0 File Offset: 0x00006DF0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSourceTableNull()
			{
				return base.IsNull(this.tableDoubleCrossTable.SourceTableColumn);
			}

			// Token: 0x06000242 RID: 578 RVA: 0x00008C03 File Offset: 0x00006E03
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetSourceTableNull()
			{
				base[this.tableDoubleCrossTable.SourceTableColumn] = Convert.DBNull;
			}

			// Token: 0x06000243 RID: 579 RVA: 0x00008C1B File Offset: 0x00006E1B
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsSourceColumnNull()
			{
				return base.IsNull(this.tableDoubleCrossTable.SourceColumnColumn);
			}

			// Token: 0x06000244 RID: 580 RVA: 0x00008C2E File Offset: 0x00006E2E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetSourceColumnNull()
			{
				base[this.tableDoubleCrossTable.SourceColumnColumn] = Convert.DBNull;
			}

			// Token: 0x06000245 RID: 581 RVA: 0x00008C46 File Offset: 0x00006E46
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIntermediateTableNull()
			{
				return base.IsNull(this.tableDoubleCrossTable.IntermediateTableColumn);
			}

			// Token: 0x06000246 RID: 582 RVA: 0x00008C59 File Offset: 0x00006E59
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetIntermediateTableNull()
			{
				base[this.tableDoubleCrossTable.IntermediateTableColumn] = Convert.DBNull;
			}

			// Token: 0x06000247 RID: 583 RVA: 0x00008C71 File Offset: 0x00006E71
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsIntermediateKeyColumnNull()
			{
				return base.IsNull(this.tableDoubleCrossTable.IntermediateKeyColumnColumn);
			}

			// Token: 0x06000248 RID: 584 RVA: 0x00008C84 File Offset: 0x00006E84
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetIntermediateKeyColumnNull()
			{
				base[this.tableDoubleCrossTable.IntermediateKeyColumnColumn] = Convert.DBNull;
			}

			// Token: 0x06000249 RID: 585 RVA: 0x00008C9C File Offset: 0x00006E9C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsIntermediateJumpColumnNull()
			{
				return base.IsNull(this.tableDoubleCrossTable.IntermediateJumpColumnColumn);
			}

			// Token: 0x0600024A RID: 586 RVA: 0x00008CAF File Offset: 0x00006EAF
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetIntermediateJumpColumnNull()
			{
				base[this.tableDoubleCrossTable.IntermediateJumpColumnColumn] = Convert.DBNull;
			}

			// Token: 0x0600024B RID: 587 RVA: 0x00008CC7 File Offset: 0x00006EC7
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsReferredTableNull()
			{
				return base.IsNull(this.tableDoubleCrossTable.ReferredTableColumn);
			}

			// Token: 0x0600024C RID: 588 RVA: 0x00008CDA File Offset: 0x00006EDA
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetReferredTableNull()
			{
				base[this.tableDoubleCrossTable.ReferredTableColumn] = Convert.DBNull;
			}

			// Token: 0x0600024D RID: 589 RVA: 0x00008CF2 File Offset: 0x00006EF2
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsKeyColumnNull()
			{
				return base.IsNull(this.tableDoubleCrossTable.KeyColumnColumn);
			}

			// Token: 0x0600024E RID: 590 RVA: 0x00008D05 File Offset: 0x00006F05
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetKeyColumnNull()
			{
				base[this.tableDoubleCrossTable.KeyColumnColumn] = Convert.DBNull;
			}

			// Token: 0x0600024F RID: 591 RVA: 0x00008D1D File Offset: 0x00006F1D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsDisplayColumnNull()
			{
				return base.IsNull(this.tableDoubleCrossTable.DisplayColumnColumn);
			}

			// Token: 0x06000250 RID: 592 RVA: 0x00008D30 File Offset: 0x00006F30
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetDisplayColumnNull()
			{
				base[this.tableDoubleCrossTable.DisplayColumnColumn] = Convert.DBNull;
			}

			// Token: 0x04000078 RID: 120
			private IntelliEdit.DoubleCrossTableDataTable tableDoubleCrossTable;
		}

		// Token: 0x02000010 RID: 16
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class CrossTableRowChangeEvent : EventArgs
		{
			// Token: 0x06000251 RID: 593 RVA: 0x00008D48 File Offset: 0x00006F48
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CrossTableRowChangeEvent(IntelliEdit.CrossTableRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000BB RID: 187
			// (get) Token: 0x06000252 RID: 594 RVA: 0x00008D5E File Offset: 0x00006F5E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public IntelliEdit.CrossTableRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000BC RID: 188
			// (get) Token: 0x06000253 RID: 595 RVA: 0x00008D66 File Offset: 0x00006F66
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000079 RID: 121
			private IntelliEdit.CrossTableRow eventRow;

			// Token: 0x0400007A RID: 122
			private DataRowAction eventAction;
		}

		// Token: 0x02000011 RID: 17
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DomainListRowChangeEvent : EventArgs
		{
			// Token: 0x06000254 RID: 596 RVA: 0x00008D6E File Offset: 0x00006F6E
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DomainListRowChangeEvent(IntelliEdit.DomainListRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000BD RID: 189
			// (get) Token: 0x06000255 RID: 597 RVA: 0x00008D84 File Offset: 0x00006F84
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public IntelliEdit.DomainListRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000BE RID: 190
			// (get) Token: 0x06000256 RID: 598 RVA: 0x00008D8C File Offset: 0x00006F8C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400007B RID: 123
			private IntelliEdit.DomainListRow eventRow;

			// Token: 0x0400007C RID: 124
			private DataRowAction eventAction;
		}

		// Token: 0x02000012 RID: 18
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class UseDomainRowChangeEvent : EventArgs
		{
			// Token: 0x06000257 RID: 599 RVA: 0x00008D94 File Offset: 0x00006F94
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public UseDomainRowChangeEvent(IntelliEdit.UseDomainRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000BF RID: 191
			// (get) Token: 0x06000258 RID: 600 RVA: 0x00008DAA File Offset: 0x00006FAA
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public IntelliEdit.UseDomainRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000C0 RID: 192
			// (get) Token: 0x06000259 RID: 601 RVA: 0x00008DB2 File Offset: 0x00006FB2
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400007D RID: 125
			private IntelliEdit.UseDomainRow eventRow;

			// Token: 0x0400007E RID: 126
			private DataRowAction eventAction;
		}

		// Token: 0x02000013 RID: 19
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DoubleCrossTableRowChangeEvent : EventArgs
		{
			// Token: 0x0600025A RID: 602 RVA: 0x00008DBA File Offset: 0x00006FBA
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DoubleCrossTableRowChangeEvent(IntelliEdit.DoubleCrossTableRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x170000C1 RID: 193
			// (get) Token: 0x0600025B RID: 603 RVA: 0x00008DD0 File Offset: 0x00006FD0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public IntelliEdit.DoubleCrossTableRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x170000C2 RID: 194
			// (get) Token: 0x0600025C RID: 604 RVA: 0x00008DD8 File Offset: 0x00006FD8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400007F RID: 127
			private IntelliEdit.DoubleCrossTableRow eventRow;

			// Token: 0x04000080 RID: 128
			private DataRowAction eventAction;
		}
	}
}
