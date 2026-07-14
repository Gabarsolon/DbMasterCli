using System;
using System.Collections.Generic;
using System.Text;

namespace FifaLibrary
{
	// Token: 0x02000024 RID: 36
	public class NameDictionary : Dictionary<int, string>
	{
		// Token: 0x06000281 RID: 641 RVA: 0x00012B30 File Offset: 0x00010D30
		public NameDictionary(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.commentarynames];
			this.Load(table);
			Table table2 = fifaDbFile.Table[TI.playernames];
			this.FillFromPlayernames(table2);
		}

		// Token: 0x06000282 RID: 642 RVA: 0x00012B6B File Offset: 0x00010D6B
		public NameDictionary(Table commentaryNamesTable)
		{
			this.Load(commentaryNamesTable);
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00012B7C File Offset: 0x00010D7C
		public void Load(Table commentaryNamesTable)
		{
			base.Clear();
			for (int i = 0; i < commentaryNamesTable.NRecords; i++)
			{
				Record record = commentaryNamesTable.Records[i];
				int num = record.IntField[FI.commentarynames_commentaryid];
				if (!base.ContainsKey(num))
				{
					string text = record.CompressedString[FI.commentarynames_commentarystring];
					string @string = Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(text));
					char c;
					if (@string.Length > 0)
					{
						c = @string.ToUpper()[0];
					}
					else
					{
						c = 'A';
					}
					if (c >= 'A')
					{
					}
					base.Add(num, text);
				}
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00012C20 File Offset: 0x00010E20
		public void FillFromPlayernames(Table playernamesTable)
		{
			for (int i = 0; i < playernamesTable.NRecords; i++)
			{
				Record record = playernamesTable.Records[i];
				int num = record.IntField[FI.playernames_commentaryid];
				if (num != 900000 && !base.ContainsKey(num))
				{
					string text = record.CompressedString[FI.playernames_name];
					string @string = Encoding.ASCII.GetString(Encoding.GetEncoding("Cyrillic").GetBytes(text));
					char c;
					if (@string.Length > 0)
					{
						c = @string.ToUpper()[0];
					}
					else
					{
						c = 'A';
					}
					if (c >= 'A')
					{
					}
					base.Add(num, text);
				}
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00012CC8 File Offset: 0x00010EC8
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.commentarynames];
			this.Save(table);
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00012CEC File Offset: 0x00010EEC
		public void Save(Table commentaryNamesTable)
		{
			commentaryNamesTable.ResizeRecords(base.Count);
			commentaryNamesTable.NValidRecords = base.Count;
			int num = 0;
			foreach (KeyValuePair<int, string> keyValuePair in this)
			{
				Record record = commentaryNamesTable.Records[num];
				num++;
				string value = keyValuePair.Value;
				char c = value.ToUpper()[0];
				if (c < 'A' || c > 'Z')
				{
					c = 'Z';
				}
				record.IntField[FI.commentarynames_commentarystartingletter] = (int)(c - 'A' + '\u0001');
				record.IntField[FI.commentarynames_commentaryid] = keyValuePair.Key;
				record.IntField[FI.commentarynames_commentarypreview] = 1;
				record.CompressedString[FI.commentarynames_commentarystring] = value;
			}
		}
	}
}
