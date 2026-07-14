using System;

namespace FifaLibrary
{
	// Token: 0x02000025 RID: 37
	public class PlayerNames : IdArrayList
	{
		// Token: 0x06000287 RID: 647 RVA: 0x00012DC8 File Offset: 0x00010FC8
		public PlayerNames(DbFile fifaDbFile)
			: base(typeof(PlayerName))
		{
			this.Load(fifaDbFile);
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00012DE4 File Offset: 0x00010FE4
		public PlayerNames(Table playerNamesTable)
			: base(typeof(PlayerName))
		{
			int num = 0;
			int num2 = playerNamesTable.TableDescriptor.MaxValues[FI.playernames_nameid];
			if (num2 < 32767)
			{
				num2 = 32767;
			}
			this.Load(playerNamesTable, num, num2);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00012E2C File Offset: 0x0001102C
		public PlayerNames()
			: base(typeof(PlayerName))
		{
		}

		// Token: 0x0600028A RID: 650 RVA: 0x00012E40 File Offset: 0x00011040
		public void Load(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.playernames];
			int num = 0;
			int num2 = table.TableDescriptor.MaxValues[FI.playernames_nameid];
			if (num2 < 32767)
			{
				num2 = 32767;
			}
			this.Load(table, num, num2);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x00012E88 File Offset: 0x00011088
		public void Load(Table table, int minId, int maxId)
		{
			base.MinId = minId;
			base.MaxId = maxId;
			PlayerName[] array = new PlayerName[table.NRecords];
			this.Clear();
			for (int i = 0; i < table.NRecords; i++)
			{
				array[i] = new PlayerName(table.Records[i]);
				string text = PlayerNames.Normalize(array[i].Text);
				if (array[i].Text != text)
				{
					array[i].Text = text;
				}
			}
			this.AddRange(array);
			base.SortId();
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00012F0C File Offset: 0x0001110C
		public void Save(DbFile fifaDbFile)
		{
			Table table = fifaDbFile.Table[TI.playernames];
			table.ResizeRecords(this.Count);
			int num = 0;
			foreach (object obj in this)
			{
				PlayerName playerName = (PlayerName)obj;
				if (playerName.IsUsed)
				{
					Record record = table.Records[num];
					num++;
					playerName.SavePlayerName(record);
				}
			}
			table.ResizeRecords(num);
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00012FA0 File Offset: 0x000111A0
		public bool TryGetValue(int id, out string name, bool isUsed)
		{
			PlayerName playerName = (PlayerName)base.SearchId(id);
			if (playerName != null)
			{
				name = playerName.Text;
				playerName.IsUsed = isUsed;
				return true;
			}
			name = null;
			return false;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x00012FD4 File Offset: 0x000111D4
		public bool TryGetValue(int id, out string name, out int commentaryid, bool isUsed)
		{
			PlayerName playerName = (PlayerName)base.SearchId(id);
			if (playerName != null)
			{
				name = playerName.Text;
				commentaryid = playerName.CommentaryId;
				playerName.IsUsed = isUsed;
				return true;
			}
			name = null;
			commentaryid = 900000;
			return false;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00013018 File Offset: 0x00011218
		public void ClearUsedFlags()
		{
			foreach (object obj in this)
			{
				PlayerName playerName = (PlayerName)obj;
				playerName.IsUsed = false;
			}
		}

		// Token: 0x06000290 RID: 656 RVA: 0x0001306C File Offset: 0x0001126C
		public void SetUsedFlags()
		{
			foreach (object obj in this)
			{
				PlayerName playerName = (PlayerName)obj;
				playerName.IsUsed = true;
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000130C0 File Offset: 0x000112C0
		public int SearchName(string text)
		{
			string text2 = PlayerNames.Normalize(text);
			foreach (object obj in this)
			{
				PlayerName playerName = (PlayerName)obj;
				if (playerName.Text == text2)
				{
					return playerName.CommentaryId;
				}
			}
			return 900000;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00013138 File Offset: 0x00011338
		public int GetKey(string text)
		{
			string text2 = PlayerNames.Normalize(text);
			foreach (object obj in this)
			{
				PlayerName playerName = (PlayerName)obj;
				if (playerName.Text == text2)
				{
					playerName.IsUsed = true;
					return playerName.Id;
				}
			}
			int newId = this.GetNewId();
			if (newId >= 0)
			{
				PlayerName playerName2 = new PlayerName(newId, text2, true);
				base.InsertId(playerName2);
				return newId;
			}
			return 0;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000131D8 File Offset: 0x000113D8
		public static string Normalize(string text)
		{
			if (text == null)
			{
				return string.Empty;
			}
			if (text.Length <= 0)
			{
				return text;
			}
			string text2 = text;
			if (text2 == text2.ToUpper() && text2.IndexOfAny(PlayerNames.c_NoLetters) < 0 && text2.Length > 3)
			{
				text2 = text2.Substring(0, 1).ToUpper() + text2.Substring(1, text2.Length - 1).ToLower();
			}
			if (text2.Length == 0)
			{
				return string.Empty;
			}
			if (text2 == text2.ToLower())
			{
				text2 = text2.Substring(0, 1).ToUpper() + text2.Substring(1, text2.Length - 1);
			}
			return text2;
		}

		// Token: 0x0400013C RID: 316
		private static char[] c_NoLetters = new char[] { ' ', '.', '-', '\'' };
	}
}
