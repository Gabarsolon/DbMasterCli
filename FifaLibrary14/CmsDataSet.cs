using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FifaLibrary
{
	// Token: 0x02000070 RID: 112
	[XmlRoot("CmsDataSet")]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class CmsDataSet : DataSet
	{
		// Token: 0x0600097D RID: 2429 RVA: 0x0004465C File Offset: 0x0004285C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public CmsDataSet()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			base.Relations.CollectionChanged += collectionChangeEventHandler;
			base.EndInit();
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x000446B0 File Offset: 0x000428B0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected CmsDataSet(SerializationInfo info, StreamingContext context)
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
				if (dataSet.Tables["CmsDataTable"] != null)
				{
					base.Tables.Add(new CmsDataSet.CmsDataTableDataTable(dataSet.Tables["CmsDataTable"]));
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

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x0600097F RID: 2431 RVA: 0x0004480D File Offset: 0x00042A0D
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public CmsDataSet.CmsDataTableDataTable CmsDataTable
		{
			get
			{
				return this.tableCmsDataTable;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000980 RID: 2432 RVA: 0x00044815 File Offset: 0x00042A15
		// (set) Token: 0x06000981 RID: 2433 RVA: 0x0004481D File Offset: 0x00042A1D
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(true)]
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

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x06000982 RID: 2434 RVA: 0x00044826 File Offset: 0x00042A26
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

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000983 RID: 2435 RVA: 0x0004482E File Offset: 0x00042A2E
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

		// Token: 0x06000984 RID: 2436 RVA: 0x00044836 File Offset: 0x00042A36
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x0004484C File Offset: 0x00042A4C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public override DataSet Clone()
		{
			CmsDataSet cmsDataSet = (CmsDataSet)base.Clone();
			cmsDataSet.InitVars();
			cmsDataSet.SchemaSerializationMode = this.SchemaSerializationMode;
			return cmsDataSet;
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x00044878 File Offset: 0x00042A78
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x0004487B File Offset: 0x00042A7B
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00044880 File Offset: 0x00042A80
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["CmsDataTable"] != null)
				{
					base.Tables.Add(new CmsDataSet.CmsDataTableDataTable(dataSet.Tables["CmsDataTable"]));
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

		// Token: 0x06000989 RID: 2441 RVA: 0x00044948 File Offset: 0x00042B48
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x0004497C File Offset: 0x00042B7C
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00044985 File Offset: 0x00042B85
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableCmsDataTable = (CmsDataSet.CmsDataTableDataTable)base.Tables["CmsDataTable"];
			if (initTable && this.tableCmsDataTable != null)
			{
				this.tableCmsDataTable.InitVars();
			}
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x000449B8 File Offset: 0x00042BB8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "CmsDataSet";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/CmsDataSet.xsd";
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableCmsDataTable = new CmsDataSet.CmsDataTableDataTable();
			base.Tables.Add(this.tableCmsDataTable);
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00044A10 File Offset: 0x00042C10
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeCmsDataTable()
		{
			return false;
		}

		// Token: 0x0600098E RID: 2446 RVA: 0x00044A13 File Offset: 0x00042C13
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x0600098F RID: 2447 RVA: 0x00044A24 File Offset: 0x00042C24
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			CmsDataSet cmsDataSet = new CmsDataSet();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = cmsDataSet.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = cmsDataSet.GetSchemaSerializable();
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

		// Token: 0x04000F33 RID: 3891
		private CmsDataSet.CmsDataTableDataTable tableCmsDataTable;

		// Token: 0x04000F34 RID: 3892
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x02000071 RID: 113
		// (Invoke) Token: 0x06000991 RID: 2449
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void CmsDataTableRowChangeEventHandler(object sender, CmsDataSet.CmsDataTableRowChangeEvent e);

		// Token: 0x02000072 RID: 114
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class CmsDataTableDataTable : TypedTableBase<CmsDataSet.CmsDataTableRow>
		{
			// Token: 0x06000994 RID: 2452 RVA: 0x00044B6C File Offset: 0x00042D6C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public CmsDataTableDataTable()
			{
				base.TableName = "CmsDataTable";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000995 RID: 2453 RVA: 0x00044B94 File Offset: 0x00042D94
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal CmsDataTableDataTable(DataTable table)
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

			// Token: 0x06000996 RID: 2454 RVA: 0x00044C3C File Offset: 0x00042E3C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected CmsDataTableDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x1700020A RID: 522
			// (get) Token: 0x06000997 RID: 2455 RVA: 0x00044C4C File Offset: 0x00042E4C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn GroupColumn
			{
				get
				{
					return this.columnGroup;
				}
			}

			// Token: 0x1700020B RID: 523
			// (get) Token: 0x06000998 RID: 2456 RVA: 0x00044C54 File Offset: 0x00042E54
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn NameColumn
			{
				get
				{
					return this.columnName;
				}
			}

			// Token: 0x1700020C RID: 524
			// (get) Token: 0x06000999 RID: 2457 RVA: 0x00044C5C File Offset: 0x00042E5C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn IdColumn
			{
				get
				{
					return this.columnId;
				}
			}

			// Token: 0x1700020D RID: 525
			// (get) Token: 0x0600099A RID: 2458 RVA: 0x00044C64 File Offset: 0x00042E64
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

			// Token: 0x1700020E RID: 526
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CmsDataSet.CmsDataTableRow this[int index]
			{
				get
				{
					return (CmsDataSet.CmsDataTableRow)base.Rows[index];
				}
			}

			// Token: 0x14000009 RID: 9
			// (add) Token: 0x0600099C RID: 2460 RVA: 0x00044C84 File Offset: 0x00042E84
			// (remove) Token: 0x0600099D RID: 2461 RVA: 0x00044CBC File Offset: 0x00042EBC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CmsDataSet.CmsDataTableRowChangeEventHandler CmsDataTableRowChanging;

			// Token: 0x1400000A RID: 10
			// (add) Token: 0x0600099E RID: 2462 RVA: 0x00044CF4 File Offset: 0x00042EF4
			// (remove) Token: 0x0600099F RID: 2463 RVA: 0x00044D2C File Offset: 0x00042F2C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CmsDataSet.CmsDataTableRowChangeEventHandler CmsDataTableRowChanged;

			// Token: 0x1400000B RID: 11
			// (add) Token: 0x060009A0 RID: 2464 RVA: 0x00044D64 File Offset: 0x00042F64
			// (remove) Token: 0x060009A1 RID: 2465 RVA: 0x00044D9C File Offset: 0x00042F9C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CmsDataSet.CmsDataTableRowChangeEventHandler CmsDataTableRowDeleting;

			// Token: 0x1400000C RID: 12
			// (add) Token: 0x060009A2 RID: 2466 RVA: 0x00044DD4 File Offset: 0x00042FD4
			// (remove) Token: 0x060009A3 RID: 2467 RVA: 0x00044E0C File Offset: 0x0004300C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CmsDataSet.CmsDataTableRowChangeEventHandler CmsDataTableRowDeleted;

			// Token: 0x060009A4 RID: 2468 RVA: 0x00044E41 File Offset: 0x00043041
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void AddCmsDataTableRow(CmsDataSet.CmsDataTableRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060009A5 RID: 2469 RVA: 0x00044E50 File Offset: 0x00043050
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CmsDataSet.CmsDataTableRow AddCmsDataTableRow(string Group, string Name, int Id)
			{
				CmsDataSet.CmsDataTableRow cmsDataTableRow = (CmsDataSet.CmsDataTableRow)base.NewRow();
				object[] array = new object[] { Group, Name, Id };
				cmsDataTableRow.ItemArray = array;
				base.Rows.Add(cmsDataTableRow);
				return cmsDataTableRow;
			}

			// Token: 0x060009A6 RID: 2470 RVA: 0x00044E98 File Offset: 0x00043098
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				CmsDataSet.CmsDataTableDataTable cmsDataTableDataTable = (CmsDataSet.CmsDataTableDataTable)base.Clone();
				cmsDataTableDataTable.InitVars();
				return cmsDataTableDataTable;
			}

			// Token: 0x060009A7 RID: 2471 RVA: 0x00044EB8 File Offset: 0x000430B8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override DataTable CreateInstance()
			{
				return new CmsDataSet.CmsDataTableDataTable();
			}

			// Token: 0x060009A8 RID: 2472 RVA: 0x00044EC0 File Offset: 0x000430C0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnGroup = base.Columns["Group"];
				this.columnName = base.Columns["Name"];
				this.columnId = base.Columns["Id"];
			}

			// Token: 0x060009A9 RID: 2473 RVA: 0x00044F10 File Offset: 0x00043110
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnGroup = new DataColumn("Group", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnGroup);
				this.columnName = new DataColumn("Name", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnName);
				this.columnId = new DataColumn("Id", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnId);
			}

			// Token: 0x060009AA RID: 2474 RVA: 0x00044FA4 File Offset: 0x000431A4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public CmsDataSet.CmsDataTableRow NewCmsDataTableRow()
			{
				return (CmsDataSet.CmsDataTableRow)base.NewRow();
			}

			// Token: 0x060009AB RID: 2475 RVA: 0x00044FB1 File Offset: 0x000431B1
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CmsDataSet.CmsDataTableRow(builder);
			}

			// Token: 0x060009AC RID: 2476 RVA: 0x00044FB9 File Offset: 0x000431B9
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(CmsDataSet.CmsDataTableRow);
			}

			// Token: 0x060009AD RID: 2477 RVA: 0x00044FC5 File Offset: 0x000431C5
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.CmsDataTableRowChanged != null)
				{
					this.CmsDataTableRowChanged(this, new CmsDataSet.CmsDataTableRowChangeEvent((CmsDataSet.CmsDataTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x060009AE RID: 2478 RVA: 0x00044FF8 File Offset: 0x000431F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.CmsDataTableRowChanging != null)
				{
					this.CmsDataTableRowChanging(this, new CmsDataSet.CmsDataTableRowChangeEvent((CmsDataSet.CmsDataTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x060009AF RID: 2479 RVA: 0x0004502B File Offset: 0x0004322B
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.CmsDataTableRowDeleted != null)
				{
					this.CmsDataTableRowDeleted(this, new CmsDataSet.CmsDataTableRowChangeEvent((CmsDataSet.CmsDataTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x060009B0 RID: 2480 RVA: 0x0004505E File Offset: 0x0004325E
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.CmsDataTableRowDeleting != null)
				{
					this.CmsDataTableRowDeleting(this, new CmsDataSet.CmsDataTableRowChangeEvent((CmsDataSet.CmsDataTableRow)e.Row, e.Action));
				}
			}

			// Token: 0x060009B1 RID: 2481 RVA: 0x00045091 File Offset: 0x00043291
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemoveCmsDataTableRow(CmsDataSet.CmsDataTableRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x060009B2 RID: 2482 RVA: 0x000450A0 File Offset: 0x000432A0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				CmsDataSet cmsDataSet = new CmsDataSet();
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
				xmlSchemaAttribute.FixedValue = cmsDataSet.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "CmsDataTableDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = cmsDataSet.GetSchemaSerializable();
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

			// Token: 0x04000F35 RID: 3893
			private DataColumn columnGroup;

			// Token: 0x04000F36 RID: 3894
			private DataColumn columnName;

			// Token: 0x04000F37 RID: 3895
			private DataColumn columnId;
		}

		// Token: 0x02000073 RID: 115
		public class CmsDataTableRow : DataRow
		{
			// Token: 0x060009B3 RID: 2483 RVA: 0x00045298 File Offset: 0x00043498
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal CmsDataTableRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tableCmsDataTable = (CmsDataSet.CmsDataTableDataTable)base.Table;
			}

			// Token: 0x1700020F RID: 527
			// (get) Token: 0x060009B4 RID: 2484 RVA: 0x000452B4 File Offset: 0x000434B4
			// (set) Token: 0x060009B5 RID: 2485 RVA: 0x000452F8 File Offset: 0x000434F8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Group
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableCmsDataTable.GroupColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Group' in table 'CmsDataTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableCmsDataTable.GroupColumn] = value;
				}
			}

			// Token: 0x17000210 RID: 528
			// (get) Token: 0x060009B6 RID: 2486 RVA: 0x0004530C File Offset: 0x0004350C
			// (set) Token: 0x060009B7 RID: 2487 RVA: 0x00045350 File Offset: 0x00043550
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Name
			{
				get
				{
					string text;
					try
					{
						text = (string)base[this.tableCmsDataTable.NameColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Name' in table 'CmsDataTable' is DBNull.", ex);
					}
					return text;
				}
				set
				{
					base[this.tableCmsDataTable.NameColumn] = value;
				}
			}

			// Token: 0x17000211 RID: 529
			// (get) Token: 0x060009B8 RID: 2488 RVA: 0x00045364 File Offset: 0x00043564
			// (set) Token: 0x060009B9 RID: 2489 RVA: 0x000453A8 File Offset: 0x000435A8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Id
			{
				get
				{
					int num;
					try
					{
						num = (int)base[this.tableCmsDataTable.IdColumn];
					}
					catch (InvalidCastException ex)
					{
						throw new StrongTypingException("The value for column 'Id' in table 'CmsDataTable' is DBNull.", ex);
					}
					return num;
				}
				set
				{
					base[this.tableCmsDataTable.IdColumn] = value;
				}
			}

			// Token: 0x060009BA RID: 2490 RVA: 0x000453C1 File Offset: 0x000435C1
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsGroupNull()
			{
				return base.IsNull(this.tableCmsDataTable.GroupColumn);
			}

			// Token: 0x060009BB RID: 2491 RVA: 0x000453D4 File Offset: 0x000435D4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetGroupNull()
			{
				base[this.tableCmsDataTable.GroupColumn] = Convert.DBNull;
			}

			// Token: 0x060009BC RID: 2492 RVA: 0x000453EC File Offset: 0x000435EC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsNameNull()
			{
				return base.IsNull(this.tableCmsDataTable.NameColumn);
			}

			// Token: 0x060009BD RID: 2493 RVA: 0x000453FF File Offset: 0x000435FF
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void SetNameNull()
			{
				base[this.tableCmsDataTable.NameColumn] = Convert.DBNull;
			}

			// Token: 0x060009BE RID: 2494 RVA: 0x00045417 File Offset: 0x00043617
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public bool IsIdNull()
			{
				return base.IsNull(this.tableCmsDataTable.IdColumn);
			}

			// Token: 0x060009BF RID: 2495 RVA: 0x0004542A File Offset: 0x0004362A
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetIdNull()
			{
				base[this.tableCmsDataTable.IdColumn] = Convert.DBNull;
			}

			// Token: 0x04000F3C RID: 3900
			private CmsDataSet.CmsDataTableDataTable tableCmsDataTable;
		}

		// Token: 0x02000074 RID: 116
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class CmsDataTableRowChangeEvent : EventArgs
		{
			// Token: 0x060009C0 RID: 2496 RVA: 0x00045442 File Offset: 0x00043642
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CmsDataTableRowChangeEvent(CmsDataSet.CmsDataTableRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x17000212 RID: 530
			// (get) Token: 0x060009C1 RID: 2497 RVA: 0x00045458 File Offset: 0x00043658
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public CmsDataSet.CmsDataTableRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x17000213 RID: 531
			// (get) Token: 0x060009C2 RID: 2498 RVA: 0x00045460 File Offset: 0x00043660
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x04000F3D RID: 3901
			private CmsDataSet.CmsDataTableRow eventRow;

			// Token: 0x04000F3E RID: 3902
			private DataRowAction eventAction;
		}
	}
}
