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
	// Token: 0x02000017 RID: 23
	[HelpKeyword("vs.data.DataSet")]
	[XmlRoot("Messages")]
	[DesignerCategory("code")]
	[ToolboxItem(true)]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	[Serializable]
	public class Messages : DataSet
	{
		// Token: 0x0600017D RID: 381 RVA: 0x0000E3CC File Offset: 0x0000C5CC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public Messages()
		{
			base.BeginInit();
			this.InitClass();
			CollectionChangeEventHandler collectionChangeEventHandler = new CollectionChangeEventHandler(this.SchemaChanged);
			base.Tables.CollectionChanged += collectionChangeEventHandler;
			base.Relations.CollectionChanged += collectionChangeEventHandler;
			base.EndInit();
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0000E420 File Offset: 0x0000C620
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected Messages(SerializationInfo info, StreamingContext context)
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
				if (dataSet.Tables["DataTableMex"] != null)
				{
					base.Tables.Add(new Messages.DataTableMexDataTable(dataSet.Tables["DataTableMex"]));
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

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600017F RID: 383 RVA: 0x0000E57D File Offset: 0x0000C77D
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[Browsable(false)]
		public Messages.DataTableMexDataTable DataTableMex
		{
			get
			{
				return this.tableDataTableMex;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000180 RID: 384 RVA: 0x0000E585 File Offset: 0x0000C785
		// (set) Token: 0x06000181 RID: 385 RVA: 0x0000E58D File Offset: 0x0000C78D
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
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

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000182 RID: 386 RVA: 0x0000E596 File Offset: 0x0000C796
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000183 RID: 387 RVA: 0x0000E59E File Offset: 0x0000C79E
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		// Token: 0x06000184 RID: 388 RVA: 0x0000E5A6 File Offset: 0x0000C7A6
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			base.BeginInit();
			this.InitClass();
			base.EndInit();
		}

		// Token: 0x06000185 RID: 389 RVA: 0x0000E5BC File Offset: 0x0000C7BC
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			Messages messages = (Messages)base.Clone();
			messages.InitVars();
			messages.SchemaSerializationMode = this.SchemaSerializationMode;
			return messages;
		}

		// Token: 0x06000186 RID: 390 RVA: 0x0000E5E8 File Offset: 0x0000C7E8
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		// Token: 0x06000187 RID: 391 RVA: 0x0000E5EB File Offset: 0x0000C7EB
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		// Token: 0x06000188 RID: 392 RVA: 0x0000E5F0 File Offset: 0x0000C7F0
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (base.DetermineSchemaSerializationMode(reader) == SchemaSerializationMode.IncludeSchema)
			{
				this.Reset();
				DataSet dataSet = new DataSet();
				dataSet.ReadXml(reader);
				if (dataSet.Tables["DataTableMex"] != null)
				{
					base.Tables.Add(new Messages.DataTableMexDataTable(dataSet.Tables["DataTableMex"]));
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

		// Token: 0x06000189 RID: 393 RVA: 0x0000E6B8 File Offset: 0x0000C8B8
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream memoryStream = new MemoryStream();
			base.WriteXmlSchema(new XmlTextWriter(memoryStream, null));
			memoryStream.Position = 0L;
			return XmlSchema.Read(new XmlTextReader(memoryStream), null);
		}

		// Token: 0x0600018A RID: 394 RVA: 0x0000E6EC File Offset: 0x0000C8EC
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x0000E6F5 File Offset: 0x0000C8F5
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		internal void InitVars(bool initTable)
		{
			this.tableDataTableMex = (Messages.DataTableMexDataTable)base.Tables["DataTableMex"];
			if (initTable && this.tableDataTableMex != null)
			{
				this.tableDataTableMex.InitVars();
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000E728 File Offset: 0x0000C928
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			base.DataSetName = "Messages";
			base.Prefix = "";
			base.Namespace = "http://tempuri.org/Messages.xsd";
			base.Locale = new CultureInfo("");
			base.EnforceConstraints = true;
			this.SchemaSerializationMode = SchemaSerializationMode.IncludeSchema;
			this.tableDataTableMex = new Messages.DataTableMexDataTable();
			base.Tables.Add(this.tableDataTableMex);
		}

		// Token: 0x0600018D RID: 397 RVA: 0x0000E790 File Offset: 0x0000C990
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeDataTableMex()
		{
			return false;
		}

		// Token: 0x0600018E RID: 398 RVA: 0x0000E793 File Offset: 0x0000C993
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[DebuggerNonUserCode]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		// Token: 0x0600018F RID: 399 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			Messages messages = new Messages();
			XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
			XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
			XmlSchemaAny xmlSchemaAny = new XmlSchemaAny();
			xmlSchemaAny.Namespace = messages.Namespace;
			xmlSchemaSequence.Items.Add(xmlSchemaAny);
			xmlSchemaComplexType.Particle = xmlSchemaSequence;
			XmlSchema schemaSerializable = messages.GetSchemaSerializable();
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

		// Token: 0x040000C3 RID: 195
		private Messages.DataTableMexDataTable tableDataTableMex;

		// Token: 0x040000C4 RID: 196
		private SchemaSerializationMode _schemaSerializationMode = SchemaSerializationMode.IncludeSchema;

		// Token: 0x02000018 RID: 24
		// (Invoke) Token: 0x06000191 RID: 401
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void DataTableMexRowChangeEventHandler(object sender, Messages.DataTableMexRowChangeEvent e);

		// Token: 0x02000019 RID: 25
		[XmlSchemaProvider("GetTypedTableSchema")]
		[Serializable]
		public class DataTableMexDataTable : TypedTableBase<Messages.DataTableMexRow>
		{
			// Token: 0x06000194 RID: 404 RVA: 0x0000E8EC File Offset: 0x0000CAEC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTableMexDataTable()
			{
				base.TableName = "DataTableMex";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			// Token: 0x06000195 RID: 405 RVA: 0x0000E914 File Offset: 0x0000CB14
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal DataTableMexDataTable(DataTable table)
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

			// Token: 0x06000196 RID: 406 RVA: 0x0000E9BC File Offset: 0x0000CBBC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected DataTableMexDataTable(SerializationInfo info, StreamingContext context)
				: base(info, context)
			{
				this.InitVars();
			}

			// Token: 0x17000054 RID: 84
			// (get) Token: 0x06000197 RID: 407 RVA: 0x0000E9CC File Offset: 0x0000CBCC
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn MexIdColumn
			{
				get
				{
					return this.columnMexId;
				}
			}

			// Token: 0x17000055 RID: 85
			// (get) Token: 0x06000198 RID: 408 RVA: 0x0000E9D4 File Offset: 0x0000CBD4
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn MexTextColumn
			{
				get
				{
					return this.columnMexText;
				}
			}

			// Token: 0x17000056 RID: 86
			// (get) Token: 0x06000199 RID: 409 RVA: 0x0000E9DC File Offset: 0x0000CBDC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataColumn MexSuppressedColumn
			{
				get
				{
					return this.columnMexSuppressed;
				}
			}

			// Token: 0x17000057 RID: 87
			// (get) Token: 0x0600019A RID: 410 RVA: 0x0000E9E4 File Offset: 0x0000CBE4
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			[Browsable(false)]
			public int Count
			{
				get
				{
					return base.Rows.Count;
				}
			}

			// Token: 0x17000058 RID: 88
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Messages.DataTableMexRow this[int index]
			{
				get
				{
					return (Messages.DataTableMexRow)base.Rows[index];
				}
			}

			// Token: 0x14000001 RID: 1
			// (add) Token: 0x0600019C RID: 412 RVA: 0x0000EA04 File Offset: 0x0000CC04
			// (remove) Token: 0x0600019D RID: 413 RVA: 0x0000EA3C File Offset: 0x0000CC3C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Messages.DataTableMexRowChangeEventHandler DataTableMexRowChanging;

			// Token: 0x14000002 RID: 2
			// (add) Token: 0x0600019E RID: 414 RVA: 0x0000EA74 File Offset: 0x0000CC74
			// (remove) Token: 0x0600019F RID: 415 RVA: 0x0000EAAC File Offset: 0x0000CCAC
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Messages.DataTableMexRowChangeEventHandler DataTableMexRowChanged;

			// Token: 0x14000003 RID: 3
			// (add) Token: 0x060001A0 RID: 416 RVA: 0x0000EAE4 File Offset: 0x0000CCE4
			// (remove) Token: 0x060001A1 RID: 417 RVA: 0x0000EB1C File Offset: 0x0000CD1C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Messages.DataTableMexRowChangeEventHandler DataTableMexRowDeleting;

			// Token: 0x14000004 RID: 4
			// (add) Token: 0x060001A2 RID: 418 RVA: 0x0000EB54 File Offset: 0x0000CD54
			// (remove) Token: 0x060001A3 RID: 419 RVA: 0x0000EB8C File Offset: 0x0000CD8C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event Messages.DataTableMexRowChangeEventHandler DataTableMexRowDeleted;

			// Token: 0x060001A4 RID: 420 RVA: 0x0000EBC1 File Offset: 0x0000CDC1
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddDataTableMexRow(Messages.DataTableMexRow row)
			{
				base.Rows.Add(row);
			}

			// Token: 0x060001A5 RID: 421 RVA: 0x0000EBD0 File Offset: 0x0000CDD0
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Messages.DataTableMexRow AddDataTableMexRow(int MexId, string MexText, bool MexSuppressed)
			{
				Messages.DataTableMexRow dataTableMexRow = (Messages.DataTableMexRow)base.NewRow();
				object[] array = new object[] { MexId, MexText, MexSuppressed };
				dataTableMexRow.ItemArray = array;
				base.Rows.Add(dataTableMexRow);
				return dataTableMexRow;
			}

			// Token: 0x060001A6 RID: 422 RVA: 0x0000EC1C File Offset: 0x0000CE1C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public override DataTable Clone()
			{
				Messages.DataTableMexDataTable dataTableMexDataTable = (Messages.DataTableMexDataTable)base.Clone();
				dataTableMexDataTable.InitVars();
				return dataTableMexDataTable;
			}

			// Token: 0x060001A7 RID: 423 RVA: 0x0000EC3C File Offset: 0x0000CE3C
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new Messages.DataTableMexDataTable();
			}

			// Token: 0x060001A8 RID: 424 RVA: 0x0000EC44 File Offset: 0x0000CE44
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal void InitVars()
			{
				this.columnMexId = base.Columns["MexId"];
				this.columnMexText = base.Columns["MexText"];
				this.columnMexSuppressed = base.Columns["MexSuppressed"];
			}

			// Token: 0x060001A9 RID: 425 RVA: 0x0000EC94 File Offset: 0x0000CE94
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnMexId = new DataColumn("MexId", typeof(int), null, MappingType.Element);
				base.Columns.Add(this.columnMexId);
				this.columnMexText = new DataColumn("MexText", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnMexText);
				this.columnMexSuppressed = new DataColumn("MexSuppressed", typeof(bool), null, MappingType.Element);
				base.Columns.Add(this.columnMexSuppressed);
				this.columnMexId.AllowDBNull = false;
				this.columnMexText.AllowDBNull = false;
				this.columnMexSuppressed.AllowDBNull = false;
			}

			// Token: 0x060001AA RID: 426 RVA: 0x0000ED4C File Offset: 0x0000CF4C
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public Messages.DataTableMexRow NewDataTableMexRow()
			{
				return (Messages.DataTableMexRow)base.NewRow();
			}

			// Token: 0x060001AB RID: 427 RVA: 0x0000ED59 File Offset: 0x0000CF59
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new Messages.DataTableMexRow(builder);
			}

			// Token: 0x060001AC RID: 428 RVA: 0x0000ED61 File Offset: 0x0000CF61
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override Type GetRowType()
			{
				return typeof(Messages.DataTableMexRow);
			}

			// Token: 0x060001AD RID: 429 RVA: 0x0000ED6D File Offset: 0x0000CF6D
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.DataTableMexRowChanged != null)
				{
					this.DataTableMexRowChanged(this, new Messages.DataTableMexRowChangeEvent((Messages.DataTableMexRow)e.Row, e.Action));
				}
			}

			// Token: 0x060001AE RID: 430 RVA: 0x0000EDA0 File Offset: 0x0000CFA0
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.DataTableMexRowChanging != null)
				{
					this.DataTableMexRowChanging(this, new Messages.DataTableMexRowChangeEvent((Messages.DataTableMexRow)e.Row, e.Action));
				}
			}

			// Token: 0x060001AF RID: 431 RVA: 0x0000EDD3 File Offset: 0x0000CFD3
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.DataTableMexRowDeleted != null)
				{
					this.DataTableMexRowDeleted(this, new Messages.DataTableMexRowChangeEvent((Messages.DataTableMexRow)e.Row, e.Action));
				}
			}

			// Token: 0x060001B0 RID: 432 RVA: 0x0000EE06 File Offset: 0x0000D006
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.DataTableMexRowDeleting != null)
				{
					this.DataTableMexRowDeleting(this, new Messages.DataTableMexRowChangeEvent((Messages.DataTableMexRow)e.Row, e.Action));
				}
			}

			// Token: 0x060001B1 RID: 433 RVA: 0x0000EE39 File Offset: 0x0000D039
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveDataTableMexRow(Messages.DataTableMexRow row)
			{
				base.Rows.Remove(row);
			}

			// Token: 0x060001B2 RID: 434 RVA: 0x0000EE48 File Offset: 0x0000D048
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType xmlSchemaComplexType = new XmlSchemaComplexType();
				XmlSchemaSequence xmlSchemaSequence = new XmlSchemaSequence();
				Messages messages = new Messages();
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
				xmlSchemaAttribute.FixedValue = messages.Namespace;
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute);
				XmlSchemaAttribute xmlSchemaAttribute2 = new XmlSchemaAttribute();
				xmlSchemaAttribute2.Name = "tableTypeName";
				xmlSchemaAttribute2.FixedValue = "DataTableMexDataTable";
				xmlSchemaComplexType.Attributes.Add(xmlSchemaAttribute2);
				xmlSchemaComplexType.Particle = xmlSchemaSequence;
				XmlSchema schemaSerializable = messages.GetSchemaSerializable();
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

			// Token: 0x040000C5 RID: 197
			private DataColumn columnMexId;

			// Token: 0x040000C6 RID: 198
			private DataColumn columnMexText;

			// Token: 0x040000C7 RID: 199
			private DataColumn columnMexSuppressed;
		}

		// Token: 0x0200001A RID: 26
		public class DataTableMexRow : DataRow
		{
			// Token: 0x060001B3 RID: 435 RVA: 0x0000F040 File Offset: 0x0000D240
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			internal DataTableMexRow(DataRowBuilder rb)
				: base(rb)
			{
				this.tableDataTableMex = (Messages.DataTableMexDataTable)base.Table;
			}

			// Token: 0x17000059 RID: 89
			// (get) Token: 0x060001B4 RID: 436 RVA: 0x0000F05A File Offset: 0x0000D25A
			// (set) Token: 0x060001B5 RID: 437 RVA: 0x0000F072 File Offset: 0x0000D272
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public int MexId
			{
				get
				{
					return (int)base[this.tableDataTableMex.MexIdColumn];
				}
				set
				{
					base[this.tableDataTableMex.MexIdColumn] = value;
				}
			}

			// Token: 0x1700005A RID: 90
			// (get) Token: 0x060001B6 RID: 438 RVA: 0x0000F08B File Offset: 0x0000D28B
			// (set) Token: 0x060001B7 RID: 439 RVA: 0x0000F0A3 File Offset: 0x0000D2A3
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string MexText
			{
				get
				{
					return (string)base[this.tableDataTableMex.MexTextColumn];
				}
				set
				{
					base[this.tableDataTableMex.MexTextColumn] = value;
				}
			}

			// Token: 0x1700005B RID: 91
			// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000F0B7 File Offset: 0x0000D2B7
			// (set) Token: 0x060001B9 RID: 441 RVA: 0x0000F0CF File Offset: 0x0000D2CF
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool MexSuppressed
			{
				get
				{
					return (bool)base[this.tableDataTableMex.MexSuppressedColumn];
				}
				set
				{
					base[this.tableDataTableMex.MexSuppressedColumn] = value;
				}
			}

			// Token: 0x040000CC RID: 204
			private Messages.DataTableMexDataTable tableDataTableMex;
		}

		// Token: 0x0200001B RID: 27
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class DataTableMexRowChangeEvent : EventArgs
		{
			// Token: 0x060001BA RID: 442 RVA: 0x0000F0E8 File Offset: 0x0000D2E8
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataTableMexRowChangeEvent(Messages.DataTableMexRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}

			// Token: 0x1700005C RID: 92
			// (get) Token: 0x060001BB RID: 443 RVA: 0x0000F0FE File Offset: 0x0000D2FE
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public Messages.DataTableMexRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			// Token: 0x1700005D RID: 93
			// (get) Token: 0x060001BC RID: 444 RVA: 0x0000F106 File Offset: 0x0000D306
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			[DebuggerNonUserCode]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			// Token: 0x040000CD RID: 205
			private Messages.DataTableMexRow eventRow;

			// Token: 0x040000CE RID: 206
			private DataRowAction eventAction;
		}
	}
}
