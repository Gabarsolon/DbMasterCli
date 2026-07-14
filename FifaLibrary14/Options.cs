using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace FifaLibrary
{
	// Token: 0x02000034 RID: 52
	[XmlRoot("Options")]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class Options : DataSet
	{
		// Token: 0x0600050A RID: 1290 RVA: 0x0001D408 File Offset: 0x0001B608
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Options()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			base.Relations.CollectionChanged += collectionChangeEventHandler;
			base.EndInit();
		}

		// Token: 0x0600050B RID: 1291 RVA: 0x0001D45C File Offset: 0x0001B65C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected Options(SerializationInfo info, StreamingContext context)
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
				if (dataSet.Tables["DataTableOpt"] != null)
				{
					base.Tables.Add(new Options.DataTableOptDataTable(dataSet.Tables["DataTableOpt"]));
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x0001D5B9 File Offset: 0x0001B7B9
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[Browsable(false)]
		public Options.DataTableOptDataTable DataTableOpt
		{
			get
			{
				return this.tableDataTableOpt;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x0600050D RID: 1293 RVA: 0x0001D5C1 File Offset: 0x0001B7C1
		// (set) Token: 0x0600050E RID: 1294 RVA: 0x0001D5C9 File Offset: 0x0001B7C9
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

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x0600050F RID: 1295 RVA: 0x0001D5D2 File Offset: 0x0001B7D2
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x06000510 RID: 1296 RVA: 0x0001D5DA File Offset: 0x0001B7DA
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001D5E2 File Offset: 0x0001B7E2
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x0001D5F8 File Offset: 0x0001B7F8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			Options options = (Options)base.Clone();
			options.InitVars();
			options.SchemaSerializationMode = this.SchemaSerializationMode;
			return options;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x0001D624 File Offset: 0x0001B824
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001D627 File Offset: 0x0001B827
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x0001D62C File Offset: 0x0001B82C
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["DataTableOpt"] != null)
				{
					base.Tables.Add(new Options.DataTableOptDataTable(dataSet.Tables["DataTableOpt"]));
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

		// Token: 0x06000516 RID: 1302 RVA: 0x0001D6F4 File Offset: 0x0001B8F4
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x0001D728 File Offset: 0x0001B928
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001D731 File Offset: 0x0001B931
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableDataTableOpt = (Options.DataTableOptDataTable)base.Tables["DataTableOpt"];
			if (initTable && this.tableDataTableOpt != null)
			{
				this.tableDataTableOpt.InitVars();
			}
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x0001D764 File Offset: 0x0001B964
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void InitClass()
		{
			base.DataSetName = "Options";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/Options.xsd";
			base.Locale = new CultureInfo("");
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableDataTableOpt = new Options.DataTableOptDataTable();
			base.Tables.Add(this.tableDataTableOpt);
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x0001D7CC File Offset: 0x0001B9CC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeDataTableOpt()
		{
			return false;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x0001D7CF File Offset: 0x0001B9CF
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x0001D7E0 File Offset: 0x0001B9E0
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			Options options = new Options();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = options.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = options.GetSchemaSerializable();
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

		// Token: 0x04000224 RID: 548
		private Options.DataTableOptDataTable tableDataTableOpt;

		// Token: 0x04000225 RID: 549
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x02000035 RID: 53
		// (Invoke) Token: 0x0600051E RID: 1310
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTableOptRowChangeEventHandler(object sender, Options.DataTableOptRowChangeEvent e);

		// Token: 0x02000036 RID: 54
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTableOptDataTable : TypedTableBase<Options.DataTableOptRow>
		{
			// Token: 0x06000521 RID: 1313 RVA: 0x0001D928 File Offset: 0x0001BB28
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTableOptDataTable()
			{
				base.TableName = "DataTableOpt";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x0001D950 File Offset: 0x0001BB50
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTableOptDataTable(DataTable table)
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

			// Token: 0x06000523 RID: 1315 RVA: 0x0001D9F8 File Offset: 0x0001BBF8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected DataTableOptDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000135 RID: 309
			// (get) Token: 0x06000524 RID: 1316 RVA: 0x0001DA08 File Offset: 0x0001BC08
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn OptionColumn
			{
				get
				{
					return this.columnOption;
				}
			}

			// Token: 0x17000136 RID: 310
			// (get) Token: 0x06000525 RID: 1317 RVA: 0x0001DA10 File Offset: 0x0001BC10
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn ValueColumn
			{
				get
				{
					return this.columnValue;
				}
			}

			// Token: 0x17000137 RID: 311
			// (get) Token: 0x06000526 RID: 1318 RVA: 0x0001DA18 File Offset: 0x0001BC18
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn DefaultColumn
			{
				get
				{
					return this.columnDefault;
				}
			}

			// Token: 0x17000138 RID: 312
			// (get) Token: 0x06000527 RID: 1319 RVA: 0x0001DA20 File Offset: 0x0001BC20
			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000139 RID: 313
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Options.DataTableOptRow this[int index]
			{
				get
				{
					return (Options.DataTableOptRow)base.Rows[index];
				}
			}

			// Token: 0x14000005 RID: 5
			// (add) Token: 0x06000529 RID: 1321 RVA: 0x0001DA40 File Offset: 0x0001BC40
			// (remove) Token: 0x0600052A RID: 1322 RVA: 0x0001DA78 File Offset: 0x0001BC78
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Options.DataTableOptRowChangeEventHandler DataTableOptRowChanging;

			// Token: 0x14000006 RID: 6
			// (add) Token: 0x0600052B RID: 1323 RVA: 0x0001DAB0 File Offset: 0x0001BCB0
			// (remove) Token: 0x0600052C RID: 1324 RVA: 0x0001DAE8 File Offset: 0x0001BCE8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Options.DataTableOptRowChangeEventHandler DataTableOptRowChanged;

			// Token: 0x14000007 RID: 7
			// (add) Token: 0x0600052D RID: 1325 RVA: 0x0001DB20 File Offset: 0x0001BD20
			// (remove) Token: 0x0600052E RID: 1326 RVA: 0x0001DB58 File Offset: 0x0001BD58
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Options.DataTableOptRowChangeEventHandler DataTableOptRowDeleting;

			// Token: 0x14000008 RID: 8
			// (add) Token: 0x0600052F RID: 1327 RVA: 0x0001DB90 File Offset: 0x0001BD90
			// (remove) Token: 0x06000530 RID: 1328 RVA: 0x0001DBC8 File Offset: 0x0001BDC8
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Options.DataTableOptRowChangeEventHandler DataTableOptRowDeleted;

			// Token: 0x06000531 RID: 1329 RVA: 0x0001DBFD File Offset: 0x0001BDFD
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddDataTableOptRow(Options.DataTableOptRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x06000532 RID: 1330 RVA: 0x0001DC0C File Offset: 0x0001BE0C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Options.DataTableOptRow AddDataTableOptRow(string Option, string Value, string Default)
			{
				Options.DataTableOptRow dataTableOptRow = (Options.DataTableOptRow)base.NewRow();
				object[] array = new object[] { Option, Value, Default };
				dataTableOptRow.ItemArray = array;
				base.Rows.Add(dataTableOptRow);
				return dataTableOptRow;
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x0001DC50 File Offset: 0x0001BE50
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				Options.DataTableOptDataTable dataTableOptDataTable = (Options.DataTableOptDataTable)base.Clone();
				dataTableOptDataTable.InitVars();
				return dataTableOptDataTable;
			}

			// Token: 0x06000534 RID: 1332 RVA: 0x0001DC70 File Offset: 0x0001BE70
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Options.DataTableOptDataTable();
			}

			// Token: 0x06000535 RID: 1333 RVA: 0x0001DC78 File Offset: 0x0001BE78
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnOption = base.Columns["Option"];
				this.columnValue = base.Columns["Value"];
				this.columnDefault = base.Columns["Default"];
			}

			// Token: 0x06000536 RID: 1334 RVA: 0x0001DCC8 File Offset: 0x0001BEC8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnOption = new DataColumn("Option", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnOption);
				this.columnValue = new DataColumn("Value", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnValue);
				this.columnDefault = new DataColumn("Default", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnDefault);
				this.columnOption.AllowDBNull = false;
				this.columnValue.AllowDBNull = false;
				this.columnDefault.AllowDBNull = false;
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x0001DD80 File Offset: 0x0001BF80
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Options.DataTableOptRow NewDataTableOptRow()
			{
				return (Options.DataTableOptRow)base.NewRow();
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x0001DD8D File Offset: 0x0001BF8D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Options.DataTableOptRow(builder);
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x0001DD95 File Offset: 0x0001BF95
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Options.DataTableOptRow);
			}

			// Token: 0x0600053A RID: 1338 RVA: 0x0001DDA1 File Offset: 0x0001BFA1
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.DataTableOptRowChanged != null)
				{
					this.DataTableOptRowChanged(this, new Options.DataTableOptRowChangeEvent((Options.DataTableOptRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600053B RID: 1339 RVA: 0x0001DDD4 File Offset: 0x0001BFD4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.DataTableOptRowChanging != null)
				{
					this.DataTableOptRowChanging(this, new Options.DataTableOptRowChangeEvent((Options.DataTableOptRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600053C RID: 1340 RVA: 0x0001DE07 File Offset: 0x0001C007
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.DataTableOptRowDeleted != null)
				{
					this.DataTableOptRowDeleted(this, new Options.DataTableOptRowChangeEvent((Options.DataTableOptRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600053D RID: 1341 RVA: 0x0001DE3A File Offset: 0x0001C03A
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.DataTableOptRowDeleting != null)
				{
					this.DataTableOptRowDeleting(this, new Options.DataTableOptRowChangeEvent((Options.DataTableOptRow)e.Row, e.Action));
				}
			}

			// Token: 0x0600053E RID: 1342 RVA: 0x0001DE6D File Offset: 0x0001C06D
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public void RemoveDataTableOptRow(Options.DataTableOptRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x0600053F RID: 1343 RVA: 0x0001DE7C File Offset: 0x0001C07C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Options options = new Options();
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
				xmlSchemaAttribute.FixedValue = options.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTableOptDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = options.GetSchemaSerializable();
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

			// Token: 0x04000226 RID: 550
			private DataColumn columnOption;

			// Token: 0x04000227 RID: 551
			private DataColumn columnValue;

			// Token: 0x04000228 RID: 552
			private DataColumn columnDefault;
		}

		// Token: 0x02000037 RID: 55
		public class DataTableOptRow : DataRow
		{
			// Token: 0x06000540 RID: 1344 RVA: 0x0001E074 File Offset: 0x0001C274
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTableOptRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tableDataTableOpt = (Options.DataTableOptDataTable)base.Table;
			}

			// Token: 0x1700013A RID: 314
			// (get) Token: 0x06000541 RID: 1345 RVA: 0x0001E08E File Offset: 0x0001C28E
			// (set) Token: 0x06000542 RID: 1346 RVA: 0x0001E0A6 File Offset: 0x0001C2A6
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string Option
			{
				get
				{
					return (string)base[this.tableDataTableOpt.OptionColumn];
				}
				set
				{
					base[this.tableDataTableOpt.OptionColumn] = value;
				}
			}

			// Token: 0x1700013B RID: 315
			// (get) Token: 0x06000543 RID: 1347 RVA: 0x0001E0BA File Offset: 0x0001C2BA
			// (set) Token: 0x06000544 RID: 1348 RVA: 0x0001E0D2 File Offset: 0x0001C2D2
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Value
			{
				get
				{
					return (string)base[this.tableDataTableOpt.ValueColumn];
				}
				set
				{
					base[this.tableDataTableOpt.ValueColumn] = value;
				}
			}

			// Token: 0x1700013C RID: 316
			// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001E0E6 File Offset: 0x0001C2E6
			// (set) Token: 0x06000546 RID: 1350 RVA: 0x0001E0FE File Offset: 0x0001C2FE
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public string Default
			{
				get
				{
					return (string)base[this.tableDataTableOpt.DefaultColumn];
				}
				set
				{
					base[this.tableDataTableOpt.DefaultColumn] = value;
				}
			}

			// Token: 0x0400022D RID: 557
			private Options.DataTableOptDataTable tableDataTableOpt;
		}

		// Token: 0x02000038 RID: 56
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTableOptRowChangeEvent : EventArgs
		{
			// Token: 0x06000547 RID: 1351 RVA: 0x0001E112 File Offset: 0x0001C312
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTableOptRowChangeEvent(Options.DataTableOptRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x1700013D RID: 317
			// (get) Token: 0x06000548 RID: 1352 RVA: 0x0001E128 File Offset: 0x0001C328
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Options.DataTableOptRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x1700013E RID: 318
			// (get) Token: 0x06000549 RID: 1353 RVA: 0x0001E130 File Offset: 0x0001C330
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x0400022E RID: 558
			private Options.DataTableOptRow eventRow;

			// Token: 0x0400022F RID: 559
			private DataRowAction eventAction;
		}
	}
}
