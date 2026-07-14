using System;
using System.Collections;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x02000040 RID: 64
	public class CompobjList : IdArrayList
	{
		// Token: 0x06000656 RID: 1622 RVA: 0x000257C6 File Offset: 0x000239C6
		public CompobjList()
			: base(typeof(Compobj))
		{
			base.MinId = 0;
			base.MaxId = 99999;
		}

		// Token: 0x06000657 RID: 1623 RVA: 0x000257EA File Offset: 0x000239EA
		public CompobjList(string path, DbFile dbFile)
			: base(typeof(Compobj))
		{
			base.MinId = 0;
			base.MaxId = 99999;
			this.Load(path, dbFile);
		}

		// Token: 0x06000658 RID: 1624 RVA: 0x00025818 File Offset: 0x00023A18
		public static string[] GetFileNames()
		{
			CompobjList.s_FileNames[0] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/compobj.txt";
			CompobjList.s_FileNames[1] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/settings.txt";
			CompobjList.s_FileNames[2] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/standings.txt";
			CompobjList.s_FileNames[3] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/advancement.txt";
			CompobjList.s_FileNames[4] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/schedule.txt";
			CompobjList.s_FileNames[5] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/weather.txt";
			CompobjList.s_FileNames[6] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/tasks.txt";
			CompobjList.s_FileNames[7] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/initteams.txt";
			CompobjList.s_FileNames[8] = "dlc/dlc_footballcompeng/dlc/footballcompeng/data/compdata/compids.txt";
			return CompobjList.s_FileNames;
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x06000659 RID: 1625 RVA: 0x00025898 File Offset: 0x00023A98
		public TrophyList Trophies
		{
			get
			{
				TrophyList trophyList = new TrophyList();
				foreach (object obj in this)
				{
					Compobj compobj = (Compobj)obj;
					if (compobj.IsTrophy())
					{
						trophyList.Add(compobj);
					}
				}
				return trophyList;
			}
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x000258FC File Offset: 0x00023AFC
		public void Load(string path, DbFile fifaDbFile)
		{
			this.Clear();
			if (!File.Exists(path + CompobjList.s_FileNames[0]))
			{
				FifaEnvironment.FifaFat.RestoreFile(CompobjList.s_FileNames[0]);
				FifaEnvironment.FifaFat.ExtractFile(CompobjList.s_FileNames[0]);
			}
			this.LoadFromCompobj(path + CompobjList.s_FileNames[0]);
			if (!File.Exists(path + CompobjList.s_FileNames[1]))
			{
				FifaEnvironment.FifaFat.RestoreFile(CompobjList.s_FileNames[1]);
				FifaEnvironment.FifaFat.ExtractFile(CompobjList.s_FileNames[1]);
			}
			this.LoadFromSettings(path + CompobjList.s_FileNames[1]);
			if (!File.Exists(path + CompobjList.s_FileNames[2]))
			{
				FifaEnvironment.FifaFat.RestoreFile(CompobjList.s_FileNames[2]);
				FifaEnvironment.FifaFat.ExtractFile(CompobjList.s_FileNames[2]);
			}
			this.LoadFromStandings(path + CompobjList.s_FileNames[2]);
			if (!File.Exists(path + CompobjList.s_FileNames[3]))
			{
				FifaEnvironment.FifaFat.RestoreFile(CompobjList.s_FileNames[3]);
				FifaEnvironment.FifaFat.ExtractFile(CompobjList.s_FileNames[3]);
			}
			this.LoadFromAdvancement(path + CompobjList.s_FileNames[3]);
			if (!File.Exists(path + CompobjList.s_FileNames[4]))
			{
				FifaEnvironment.FifaFat.RestoreFile(CompobjList.s_FileNames[4]);
				FifaEnvironment.FifaFat.ExtractFile(CompobjList.s_FileNames[4]);
			}
			this.LoadFromSchedule(path + CompobjList.s_FileNames[4]);
			if (!File.Exists(path + CompobjList.s_FileNames[5]))
			{
				FifaEnvironment.FifaFat.RestoreFile(CompobjList.s_FileNames[5]);
				FifaEnvironment.FifaFat.ExtractFile(CompobjList.s_FileNames[5]);
			}
			this.LoadFromWeather(path + CompobjList.s_FileNames[5]);
			if (!File.Exists(path + CompobjList.s_FileNames[6]))
			{
				FifaEnvironment.FifaFat.RestoreFile(CompobjList.s_FileNames[6]);
				FifaEnvironment.FifaFat.ExtractFile(CompobjList.s_FileNames[6]);
			}
			this.LoadFromTasks(path + CompobjList.s_FileNames[6]);
			if (!File.Exists(path + CompobjList.s_FileNames[7]))
			{
				FifaEnvironment.FifaFat.RestoreFile(CompobjList.s_FileNames[7]);
				FifaEnvironment.FifaFat.ExtractFile(CompobjList.s_FileNames[7]);
			}
			this.LoadFromInitteams(path + CompobjList.s_FileNames[7]);
			this.FillFromLanguage();
			Table table = fifaDbFile.Table[TI.competition];
			this.FillFromCompetition(table);
			this.Normalize();
			this.CollectDescriptions();
		}

		// Token: 0x0600065B RID: 1627 RVA: 0x00025B98 File Offset: 0x00023D98
		private bool LoadFromCompobj(string fileName)
		{
			if (!File.Exists(fileName))
			{
				return false;
			}
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 5)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					string text2 = array2[2];
					string text3 = array2[3];
					int num3 = Convert.ToInt32(array2[4]);
					Compobj compobj = null;
					if (num3 >= 0)
					{
						compobj = (Compobj)base.SearchId(num3);
						if (compobj == null)
						{
							continue;
						}
					}
					Compobj compobj2 = null;
					switch (num2)
					{
					case 0:
					{
						World world = new World(num, text2, text3);
						base.InsertId(world);
						break;
					}
					case 1:
						compobj2 = new Confederation(num, text2, text3, compobj);
						base.InsertId(compobj2);
						break;
					case 2:
						compobj2 = new Nation(num, text2, text3, compobj);
						base.InsertId(compobj2);
						break;
					case 3:
						compobj2 = new Trophy(num, text2, text3, compobj);
						base.InsertId(compobj2);
						break;
					case 4:
						compobj2 = new Stage(num, text2, text3, compobj);
						base.InsertId(compobj2);
						break;
					case 5:
						compobj2 = new Group(num, text2, text3, compobj);
						base.InsertId(compobj2);
						break;
					}
					if (compobj != null)
					{
						compobj.AddChild(compobj2);
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x0600065C RID: 1628 RVA: 0x00025D10 File Offset: 0x00023F10
		private bool LoadFromSettings(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[1];
			char[] array2 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
			array[0] = ',';
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array3 = text.Split(array);
				if (array3.Length == 3)
				{
					int num = Convert.ToInt32(array3[0]);
					string text2 = array3[1];
					string text3 = array3[2];
					text3.IndexOfAny(array2);
					Compobj compobj = (Compobj)base.SearchId(num);
					if (compobj != null)
					{
						compobj.SetProperty(array3[1], array3[2]);
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x0600065D RID: 1629 RVA: 0x00025DA8 File Offset: 0x00023FA8
		private bool LoadFromStandings(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 2)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					Group group = (Group)base.SearchId(num);
					if (group != null)
					{
						Rank rank = new Rank(group, num2 + 1);
						group.Ranks.Add(rank);
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x0600065E RID: 1630 RVA: 0x00025E34 File Offset: 0x00024034
		private bool LoadFromSchedule(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 6)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					int num3 = Convert.ToInt32(array2[2]);
					int num4 = Convert.ToInt32(array2[3]);
					int num5 = Convert.ToInt32(array2[4]);
					int num6 = Convert.ToInt32(array2[5]);
					Compobj compobj = (Compobj)base.SearchId(num);
					if (compobj != null)
					{
						if (compobj.IsStage())
						{
							Stage stage = (Stage)base.SearchId(num);
							if (stage != null)
							{
								Schedule schedule = new Schedule(stage, num2, num3, num4, num5, num6);
								stage.AddSchedule(schedule);
							}
						}
						else if (compobj.IsGroup())
						{
							Group group = (Group)base.SearchId(num);
							if (group != null)
							{
								Schedule schedule2 = new Schedule(group, num2, num3, num4, num5, num6);
								group.AddSchedule(schedule2);
							}
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00025F48 File Offset: 0x00024148
		private bool LoadFromWeather(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 8)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					int num3 = Convert.ToInt32(array2[2]);
					int num4 = Convert.ToInt32(array2[3]);
					int num5 = Convert.ToInt32(array2[4]);
					int num6 = Convert.ToInt32(array2[5]);
					int num7 = Convert.ToInt32(array2[6]);
					int num8 = Convert.ToInt32(array2[7]);
					Compobj compobj = (Compobj)base.SearchId(num);
					if (compobj.IsNation())
					{
						Nation nation = (Nation)base.SearchId(num);
						if (nation != null && num2 >= 1 && num2 <= 12)
						{
							num2--;
							nation.DryProb[num2] = num3;
							nation.RainProb[num2] = num4;
							nation.SnowProb[num2] = num5;
							nation.OvercastProb[num2] = num6;
							nation.SunsetTime[num2] = num7;
							nation.DarkTime[num2] = num8;
						}
					}
					else if (compobj.IsWorld())
					{
						World world = (World)base.SearchId(num);
						if (world != null && num2 >= 1 && num2 <= 12)
						{
							num2--;
							world.DryProb[num2] = num3;
							world.RainProb[num2] = num4;
							world.SnowProb[num2] = num5;
							world.OvercastProb[num2] = num6;
							world.SunsetTime[num2] = num7;
							world.DarkTime[num2] = num8;
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x000260F0 File Offset: 0x000242F0
		private bool LoadFromTasks(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 7)
				{
					int num = Convert.ToInt32(array2[0]);
					string text2 = array2[1];
					string text3 = array2[2];
					int num2 = Convert.ToInt32(array2[3]);
					int num3 = Convert.ToInt32(array2[4]);
					int num4 = Convert.ToInt32(array2[5]);
					int num5 = Convert.ToInt32(array2[6]);
					Trophy trophy = (Trophy)base.SearchId(num);
					if (trophy != null)
					{
						Task task = new Task(text2, text3, num2, num3, num4, num5);
						Compobj compobj = (Compobj)base.SearchId(num2);
						if (compobj.IsGroup())
						{
							Group group = (Group)compobj;
							group.AddTask(task);
						}
						else if (compobj.IsStage())
						{
							Stage stage = (Stage)compobj;
							stage.AddTask(task);
						}
						else if (compobj.IsTrophy())
						{
							trophy = (Trophy)compobj;
							if (trophy != null)
							{
								trophy.AddTask(task);
							}
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00026218 File Offset: 0x00024418
		private bool LoadFromInitteams(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 3)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					int num3 = Convert.ToInt32(array2[2]);
					Trophy trophy = (Trophy)base.SearchId(num);
					if (trophy != null)
					{
						InitTeam initTeam = new InitTeam(num2, num3);
						trophy.InitTeamArray[num2] = initTeam;
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000662 RID: 1634 RVA: 0x000262A8 File Offset: 0x000244A8
		private bool LoadFromAdvancement(string fileName)
		{
			StreamReader streamReader = new StreamReader(fileName);
			if (streamReader == null)
			{
				return false;
			}
			char[] array = new char[] { ',' };
			string text;
			while ((text = streamReader.ReadLine()) != null)
			{
				string[] array2 = text.Split(array);
				if (array2.Length == 4)
				{
					int num = Convert.ToInt32(array2[0]);
					int num2 = Convert.ToInt32(array2[1]);
					int num3 = Convert.ToInt32(array2[2]);
					int num4 = Convert.ToInt32(array2[3]);
					Group group = (Group)base.SearchId(num);
					Group group2 = (Group)base.SearchId(num3);
					if (group != null && group2 != null)
					{
						Rank rank = (Rank)group.Ranks.SearchId(num2);
						Rank rank2 = (Rank)group2.Ranks.SearchId(num4);
						if (rank != null && rank2 != null)
						{
							if (rank.Id != 0)
							{
								rank.MoveTo = rank2;
							}
							rank2.MoveFrom = rank;
						}
					}
				}
			}
			streamReader.Close();
			return true;
		}

		// Token: 0x06000663 RID: 1635 RVA: 0x00026394 File Offset: 0x00024594
		private bool FillFromLanguage()
		{
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				compobj.FillFromLanguage();
			}
			return true;
		}

		// Token: 0x06000664 RID: 1636 RVA: 0x000263EC File Offset: 0x000245EC
		public bool FillFromCompetition(Table t)
		{
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				if (compobj.IsTrophy())
				{
					Trophy trophy = (Trophy)compobj;
					trophy.FillFromCompetition(t);
				}
			}
			return true;
		}

		// Token: 0x06000665 RID: 1637 RVA: 0x00026450 File Offset: 0x00024650
		private bool SaveToLanguage()
		{
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				compobj.SaveToLanguage();
			}
			return true;
		}

		// Token: 0x06000666 RID: 1638 RVA: 0x000264A8 File Offset: 0x000246A8
		private bool SaveToCompetition(Table t)
		{
			int num = 0;
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				if (compobj.IsTrophy())
				{
					Trophy trophy = (Trophy)compobj;
					if (trophy.ballid >= 0)
					{
						num++;
					}
				}
			}
			t.ResizeRecords(num);
			num = 0;
			foreach (object obj2 in this)
			{
				Compobj compobj2 = (Compobj)obj2;
				if (compobj2.IsTrophy())
				{
					Trophy trophy2 = (Trophy)compobj2;
					if (trophy2.ballid >= 0)
					{
						Record record = t.Records[num];
						trophy2.SaveCompetition(record);
						num++;
					}
				}
			}
			t.SortByKeys();
			return true;
		}

		// Token: 0x06000667 RID: 1639 RVA: 0x000265A0 File Offset: 0x000247A0
		public string[] GetFceDescriptors()
		{
			int num = 0;
			string[] array = new string[256];
			if (FifaEnvironment.LangDb == null)
			{
				return null;
			}
			Table table = FifaEnvironment.LangDb.Table[0];
			if (table == null)
			{
				return null;
			}
			for (int i = 0; i < table.NRecords; i++)
			{
				Record record = table.Records[i];
				string text = record.CompressedString[FI.language_stringid];
				if (text.StartsWith("FCE_") && num < array.Length)
				{
					array[num++] = text;
				}
			}
			string[] array2 = new string[num];
			for (int j = 0; j < num; j++)
			{
				array2[j] = array[j];
			}
			return array2;
		}

		// Token: 0x06000668 RID: 1640 RVA: 0x00026640 File Offset: 0x00024840
		private void CollectDescriptions()
		{
			CompobjList.s_Descriptions.Clear();
			string[] fceDescriptors = this.GetFceDescriptors();
			CompobjList.s_Descriptions.AddRange(fceDescriptors);
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				if (compobj.IsStage() && !compobj.Description.StartsWith("FCE_") && !CompobjList.s_Descriptions.Contains(compobj.Description))
				{
					CompobjList.s_Descriptions.Add(compobj.Description);
				}
			}
			CompobjList.s_Descriptions.Sort();
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x06000669 RID: 1641 RVA: 0x000266F0 File Offset: 0x000248F0
		public World World
		{
			get
			{
				foreach (object obj in this)
				{
					Compobj compobj = (Compobj)obj;
					if (compobj.IsWorld())
					{
						return (World)compobj;
					}
				}
				return null;
			}
		}

		// Token: 0x0600066A RID: 1642 RVA: 0x00026754 File Offset: 0x00024954
		public void Save(string path, DbFile fifaDbFile)
		{
			this.Renumber();
			this.SaveToCompobj(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\compobj.txt");
			this.SaveToCompids(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\compids.txt");
			this.SaveToSettings(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\settings.txt");
			this.SaveToStandings(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\standings.txt");
			this.SaveToAdvancement(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\advancement.txt");
			this.SaveToSchedule(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\schedule.txt");
			this.SaveToWeather(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\weather.txt");
			this.SaveToTasks(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\tasks.txt");
			this.SaveToInitteams(path + "\\dlc\\dlc_FootballCompEng\\dlc\\FootballCompEng\\data\\compdata\\initteams.txt");
			this.SaveToLanguage();
			Table table = fifaDbFile.Table[TI.competition];
			this.SaveToCompetition(table);
		}

		// Token: 0x0600066B RID: 1643 RVA: 0x00026828 File Offset: 0x00024A28
		public int Renumber()
		{
			if (this.World != null)
			{
				return this.World.Renumber(0);
			}
			return 0;
		}

		// Token: 0x0600066C RID: 1644 RVA: 0x00026850 File Offset: 0x00024A50
		private bool SaveToCompobj(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToCompobj(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x0600066D RID: 1645 RVA: 0x0002689C File Offset: 0x00024A9C
		private bool SaveToCompids(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToCompids(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x0600066E RID: 1646 RVA: 0x000268E8 File Offset: 0x00024AE8
		private bool SaveToSettings(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToSettings(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00026934 File Offset: 0x00024B34
		private bool SaveToStandings(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToStandings(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00026980 File Offset: 0x00024B80
		private bool SaveToAdvancement(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToAdvancement(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x000269CC File Offset: 0x00024BCC
		private bool SaveToSchedule(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToSchedule(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000672 RID: 1650 RVA: 0x00026A18 File Offset: 0x00024C18
		private bool SaveToWeather(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToWeather(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000673 RID: 1651 RVA: 0x00026A64 File Offset: 0x00024C64
		private bool SaveToInitteams(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToInitteams(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x00026AB0 File Offset: 0x00024CB0
		private bool SaveToTasks(string fileName)
		{
			if (this.World == null)
			{
				return false;
			}
			File.Copy(fileName, fileName + ".bak", true);
			StreamWriter streamWriter = new StreamWriter(fileName, false);
			if (streamWriter == null)
			{
				return false;
			}
			this.World.SaveRecursivelyToTasks(streamWriter);
			streamWriter.Close();
			return true;
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x00026AFC File Offset: 0x00024CFC
		public void Link()
		{
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				if (compobj.IsTrophy())
				{
					compobj.LinkLeague(FifaEnvironment.Leagues);
					compobj.LinkTeam(FifaEnvironment.Teams);
					compobj.LinkCompetitions();
				}
				if (compobj.IsNation())
				{
					compobj.LinkCountry(FifaEnvironment.Countries);
				}
				if (compobj.IsStage())
				{
					compobj.LinkStadium(FifaEnvironment.Stadiums);
					compobj.LinkCompetitions();
				}
				if (compobj.IsGroup())
				{
					compobj.LinkCompetitions();
				}
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x00026BA8 File Offset: 0x00024DA8
		private void Normalize()
		{
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				compobj.Normalize();
			}
		}

		// Token: 0x06000677 RID: 1655 RVA: 0x00026BFC File Offset: 0x00024DFC
		public Trophy SearchTrophy(int assetId)
		{
			foreach (object obj in this)
			{
				Compobj compobj = (Compobj)obj;
				if (compobj.IsTrophy() && compobj.Settings.m_asset_id == assetId)
				{
					return (Trophy)compobj;
				}
			}
			return null;
		}

		// Token: 0x0400027B RID: 635
		private static string[] s_FileNames = new string[9];

		// Token: 0x0400027C RID: 636
		public static ArrayList s_Descriptions = new ArrayList();
	}
}
