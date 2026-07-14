using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x02000014 RID: 20
	public class UgcFile
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600015C RID: 348 RVA: 0x0000BD0A File Offset: 0x00009F0A
		public int NFiles
		{
			get
			{
				return this.m_NFiles;
			}
		}

		// Token: 0x1700004D RID: 77
		// (get) Token: 0x0600015D RID: 349 RVA: 0x0000BD12 File Offset: 0x00009F12
		public UgcDirEntry[] UgcDir
		{
			get
			{
				return this.m_UgcDir;
			}
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000BD1A File Offset: 0x00009F1A
		public UgcFile(string fileName)
		{
			this.Load(fileName);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000BD34 File Offset: 0x00009F34
		public bool Load(string fileName)
		{
			FileStream fileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
			if (fileStream == null)
			{
				return false;
			}
			BinaryReader binaryReader = new BinaryReader(fileStream);
			this.m_BinaryReader = binaryReader;
			return binaryReader != null && this.Load(binaryReader);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000BD6C File Offset: 0x00009F6C
		public bool Load(BinaryReader r)
		{
			r.BaseStream.Position = 0L;
			r.ReadBytes(56);
			this.m_NFiles = r.ReadInt32() + 1;
			this.m_UgcDir = new UgcDirEntry[this.m_NFiles];
			r.ReadInt32();
			for (int i = 0; i < this.m_NFiles; i++)
			{
				this.m_UgcDir[i] = new UgcDirEntry(r);
			}
			return true;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000BDD8 File Offset: 0x00009FD8
		public bool Extract(int fileIndex, string outputFolder)
		{
			if (fileIndex < 0)
			{
				return false;
			}
			if (fileIndex >= this.m_NFiles)
			{
				return false;
			}
			this.m_BinaryReader.BaseStream.Position = (long)((ulong)(this.m_UgcDir[fileIndex].Offset + 44U));
			string text = outputFolder + "\\" + this.m_UgcDir[fileIndex].ToString();
			if (this.m_UgcDir[fileIndex].IsPng())
			{
				return this.ExtractPng(this.m_BinaryReader, text);
			}
			return this.ExtractDb(this.m_BinaryReader, text);
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000BE5C File Offset: 0x0000A05C
		public bool ExtractPng(BinaryReader r, string outputFileName)
		{
			byte[] array = new byte[8];
			int num = 0;
			array[0] = 73;
			array[1] = 69;
			array[2] = 78;
			array[3] = 68;
			array[4] = 174;
			array[5] = 66;
			array[6] = 96;
			array[7] = 130;
			FileStream fileStream = new FileStream(outputFileName, FileMode.Create, FileAccess.Write);
			if (fileStream == null)
			{
				return false;
			}
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			if (binaryWriter == null)
			{
				return false;
			}
			do
			{
				byte b = r.ReadByte();
				if (b == array[num])
				{
					num++;
				}
				else
				{
					num = 0;
				}
				binaryWriter.Write(b);
			}
			while (num != array.Length);
			fileStream.Close();
			binaryWriter.Close();
			return true;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x0000BEEC File Offset: 0x0000A0EC
		public bool ExtractDb(BinaryReader r, string outputFileName)
		{
			FileStream fileStream = new FileStream(outputFileName, FileMode.Create, FileAccess.Write);
			if (fileStream == null)
			{
				return false;
			}
			BinaryWriter binaryWriter = new BinaryWriter(fileStream);
			if (binaryWriter == null)
			{
				return false;
			}
			binaryWriter.Write(r.ReadBytes(8));
			int num = r.ReadInt32();
			binaryWriter.Write(num);
			num -= 12;
			for (int i = 0; i < num; i++)
			{
				byte b = r.ReadByte();
				binaryWriter.Write(b);
			}
			fileStream.Close();
			binaryWriter.Close();
			return true;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x0000BF5C File Offset: 0x0000A15C
		public void ImportKitGraphics(string xmlFileName, ToolStripStatusLabel statusBar)
		{
			string text = FifaEnvironment.TempFolder + "\\" + this.m_UgcDir[0].ToString();
			DbFile dbFile = new DbFile(text, xmlFileName);
			Table table = dbFile.GetTable("teams");
			dbFile.GetTable("cz_leagues");
			Table table2 = dbFile.GetTable("cz_teamkits");
			Table table3 = dbFile.GetTable("cz_teams");
			Team[] array = new Team[table.NValidRecords];
			for (int i = 0; i < table.NValidRecords; i++)
			{
				Record record = table.Records[i];
				record.GetAndCheckIntField(FI.teams_assetid);
				int andCheckIntField = record.GetAndCheckIntField(FI.teams_teamid);
				Team team = FifaEnvironment.Teams.FitTeam(record.StringField[FI.teams_teamname], 0);
				if (team != null)
				{
					if (statusBar != null)
					{
						statusBar.Text = "Importing Team: " + team.DatabaseName;
						statusBar.Owner.Refresh();
					}
					array[i] = team;
					Bitmap bitmap = null;
					Bitmap bitmap2 = null;
					int j = 0;
					while (j < table3.NValidRecords)
					{
						Record record2 = table3.Records[j];
						if (record2.GetAndCheckIntField(FI.cz_teams_teamid) == andCheckIntField)
						{
							int andCheckIntField2 = record2.GetAndCheckIntField(FI.cz_teams_hascrestimage);
							int andCheckIntField3 = record2.GetAndCheckIntField(FI.cz_teams_hassponsorimage);
							string text2 = FifaEnvironment.TempFolder + "\\" + andCheckIntField2.ToString() + ".png";
							if (File.Exists(text2))
							{
								bitmap = new Bitmap(text2);
							}
							text2 = FifaEnvironment.TempFolder + "\\" + andCheckIntField3.ToString() + ".png";
							if (File.Exists(text2))
							{
								bitmap2 = new Bitmap(text2);
								break;
							}
							break;
						}
						else
						{
							j++;
						}
					}
					int assetid = array[i].assetid;
					for (int k = 0; k < table2.NValidRecords; k++)
					{
						Record record3 = table2.Records[k];
						int andCheckIntField4 = record3.GetAndCheckIntField(FI.cz_teamkits_kitid);
						int andCheckIntField5 = record3.GetAndCheckIntField(FI.cz_teamkits_teamid);
						int andCheckIntField6 = record3.GetAndCheckIntField(FI.cz_teamkits_kittypeid);
						string text3 = Kit.KitTextureFileName(andCheckIntField4, 0, 0);
						if (andCheckIntField == andCheckIntField5)
						{
							Kit kit = FifaEnvironment.Kits.GetKit(team.Id, andCheckIntField6);
							if (kit == null)
							{
								int newId = FifaEnvironment.Kits.GetNewId();
								kit = new Kit(newId, team.Id, andCheckIntField6);
								FifaEnvironment.Kits.Add(kit);
								kit.LinkTeam(FifaEnvironment.Teams);
							}
							kit.jerseyBackName = record3.IntField[FI.cz_teamkits_jerseybacknameplacementcode] != 0;
							kit.jerseyNameFontCase = record3.IntField[FI.cz_teamkits_jerseybacknamefontcase];
							kit.jerseyNameFont = record3.IntField[FI.cz_teamkits_jerseynamefonttype];
							int num = record3.IntField[FI.cz_teamkits_jerseynamecolorr];
							int num2 = record3.IntField[FI.cz_teamkits_jerseynamecolorg];
							int num3 = record3.IntField[FI.cz_teamkits_jerseynamecolorb];
							kit.JerseyNameColor = Color.FromArgb(255, num, num2, num3);
							kit.jerseyNameLayout = record3.IntField[FI.cz_teamkits_jerseynamelayouttype];
							kit.jerseyNumberFont = record3.IntField[FI.cz_teamkits_numberfonttype];
							kit.jerseyNumberColor = record3.IntField[FI.cz_teamkits_numbercolor];
							kit.shortsNumberColor = record3.IntField[FI.cz_teamkits_shortsnumbercolor];
							kit.shortsNumberFont = record3.IntField[FI.cz_teamkits_shortsnumberfonttype];
							kit.shortsNumber = true;
							kit.jerseyCollar = 0;
							num = record3.IntField[FI.cz_teamkits_jerseycolorprimr];
							num2 = record3.IntField[FI.cz_teamkits_jerseycolorprimg];
							num3 = record3.IntField[FI.cz_teamkits_jerseycolorprimb];
							Color color = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_jerseycolorsecr];
							num2 = record3.IntField[FI.cz_teamkits_jerseycolorsecg];
							num3 = record3.IntField[FI.cz_teamkits_jerseycolorsecb];
							Color color2 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_jerseycolortertr];
							num2 = record3.IntField[FI.cz_teamkits_jerseycolortertg];
							num3 = record3.IntField[FI.cz_teamkits_jerseycolortertb];
							Color color3 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_shortcolorprimr];
							num2 = record3.IntField[FI.cz_teamkits_shortcolorprimg];
							num3 = record3.IntField[FI.cz_teamkits_shortcolorprimb];
							Color color4 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_shortcolorsecr];
							num2 = record3.IntField[FI.cz_teamkits_shortcolorsecg];
							num3 = record3.IntField[FI.cz_teamkits_shortcolorsecb];
							Color color5 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_shortcolortertr];
							num2 = record3.IntField[FI.cz_teamkits_shortcolortertg];
							num3 = record3.IntField[FI.cz_teamkits_shortcolortertb];
							Color color6 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_sockscolorprimr];
							num2 = record3.IntField[FI.cz_teamkits_sockscolorprimg];
							num3 = record3.IntField[FI.cz_teamkits_sockscolorprimb];
							Color color7 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_sockscolorsecr];
							num2 = record3.IntField[FI.cz_teamkits_sockscolorsecg];
							num3 = record3.IntField[FI.cz_teamkits_sockscolorsecb];
							Color color8 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_sockscolortertr];
							num2 = record3.IntField[FI.cz_teamkits_sockscolortertg];
							num3 = record3.IntField[FI.cz_teamkits_sockscolortertb];
							Color color9 = Color.FromArgb(255, num, num2, num3);
							num = record3.IntField[FI.cz_teamkits_sponsorcolourr];
							num2 = record3.IntField[FI.cz_teamkits_sponsorcolourg];
							num3 = record3.IntField[FI.cz_teamkits_sponsorcolourb];
							Color color10 = Color.FromArgb(255, num, num2, num3);
							float num4 = record3.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorl];
							float num5 = record3.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorr];
							float num6 = record3.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsort];
							float num7 = record3.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorb];
							Kit.KitTextureFileName(team.Id, andCheckIntField6, 0);
							Kit kit2 = FifaEnvironment.Kits.GetKit(andCheckIntField4, 0);
							if (kit2 != null)
							{
								kit.jerseyCollar = kit2.jerseyCollar;
							}
							if (kit2 != null)
							{
								Bitmap miniKit = kit2.GetMiniKit(0);
								string text4 = FifaEnvironment.TempFolder + "\\" + text3;
								FifaEnvironment.ExportFileFromZdata(text3, FifaEnvironment.TempFolder);
								kit.ImportKitTextures(text4);
								Bitmap[] kitTextures = kit.GetKitTextures();
								if (bitmap != null)
								{
									kitTextures[0] = (Bitmap)bitmap.Clone();
								}
								else
								{
									kitTextures[0] = null;
								}
								GraphicUtil.ColorizeRGB(kitTextures[1], color, color2, color3, 0, 1024);
								if (miniKit != null)
								{
									GraphicUtil.PrepareToColorize(miniKit, 25, 231);
									GraphicUtil.ColorizeRGB(miniKit, color, color2, color3, 25, 231);
								}
								if (bitmap2 != null && kitTextures[1] != null)
								{
									Bitmap bitmap3;
									if (color10.R != 225 || color10.G != 225 || color10.B != 225)
									{
										bitmap3 = GraphicUtil.ColorizeWhite(bitmap2, color10);
									}
									else
									{
										bitmap3 = bitmap2;
									}
									int num8 = (int)((double)num4 * 1024.0);
									int num9 = (int)((double)num6 * 1024.0);
									int num10 = (int)((double)num5 * 1024.0) - num8;
									int num11 = (int)((double)num7 * 1024.0) - num9;
									Rectangle rectangle = new Rectangle(num8, num9, num10, num11);
									kitTextures[1] = GraphicUtil.Overlap(kitTextures[1], bitmap3, rectangle);
								}
								GraphicUtil.ColorizeRGB(kitTextures[3], color7, color8, color9, 0, 194);
								GraphicUtil.ColorizeRGB(kitTextures[3], color4, color5, color6, 194, 512);
								kit.SetKitTextures(kitTextures);
								if (miniKit != null)
								{
									kit.SetMiniKit(miniKit);
								}
							}
						}
					}
				}
			}
			if (statusBar != null)
			{
				statusBar.Text = "Importing complete";
				statusBar.Owner.Refresh();
			}
		}

		// Token: 0x06000165 RID: 357 RVA: 0x0000C768 File Offset: 0x0000A968
		public void Import(string xmlFileName, bool useKitGraphics, ToolStripStatusLabel statusBar)
		{
			string text = FifaEnvironment.TempFolder + "\\" + this.m_UgcDir[0].ToString();
			DbFile dbFile = new DbFile(text, xmlFileName);
			Table table = dbFile.GetTable("leagueteamlinks");
			Table table2 = dbFile.GetTable("leagues");
			Table table3 = dbFile.GetTable("stadiumassignments");
			Table table4 = dbFile.GetTable("teamstadiumlinks");
			Table table5 = dbFile.GetTable("teamplayerlinks");
			Table table6 = dbFile.GetTable("formations");
			Table table7 = dbFile.GetTable("teams");
			Table table8 = dbFile.GetTable("editedplayernames");
			Table table9 = dbFile.GetTable("players");
			dbFile.GetTable("cz_leagues");
			Table table10 = dbFile.GetTable("cz_teamkits");
			Table table11 = dbFile.GetTable("cz_teams");
			Table table12 = dbFile.GetTable("cz_players");
			Table table13 = dbFile.GetTable("cz_assets");
			League[] array = new League[table2.NValidRecords];
			Team[] array2 = new Team[table7.NValidRecords];
			Player[] array3 = new Player[table9.NValidRecords];
			if (statusBar != null)
			{
				statusBar.Text = "Importing ...";
				statusBar.Owner.Refresh();
			}
			int[] array4 = new int[256];
			for (int i = 0; i < 256; i++)
			{
				array4[i] = 0;
			}
			for (int j = 0; j < table9.NValidRecords; j++)
			{
				Record record = table9.Records[j];
				array4[record.IntField[FI.players_nationality]]++;
			}
			int num = 0;
			int num2 = 216;
			for (int k = 0; k < 256; k++)
			{
				if (array4[k] > num)
				{
					num = array4[k];
					num2 = k;
				}
			}
			Country country = FifaEnvironment.Countries.SearchCountry(num2);
			int num3 = 400;
			for (int l = 0; l < table2.NValidRecords; l++)
			{
				League league = FifaEnvironment.Leagues.FitLeague(table2.Records[l].StringField[FI.leagues_leaguename], 0);
				if (league != null && country.Id != 216 && league.Country != country)
				{
					league = null;
				}
				bool flag;
				if (league == null)
				{
					num3 = FifaEnvironment.Leagues.GetNextId(num3);
					league = new League(table2.Records[l]);
					flag = false;
				}
				else
				{
					league.RemoveAllTeams();
					flag = true;
				}
				if (league.Id >= 385 && league.Id <= 389)
				{
					array[league.Id - 385] = league;
					league.Id = num3;
					if (league.leaguename.Length > 15)
					{
						league.ShortName = league.leaguename.Substring(0, 15);
					}
					else
					{
						league.ShortName = league.leaguename;
					}
					league.LongName = league.leaguename;
					league.Country = country;
					if (!flag)
					{
						FifaEnvironment.Leagues.InsertId(league);
					}
					for (int m = 0; m < table13.NValidRecords; m++)
					{
						Record record2 = table13.Records[m];
						if (record2.GetAndCheckIntField(FI.cz_assets_dbid) == 385 + l)
						{
							int andCheckIntField = record2.GetAndCheckIntField(FI.cz_assets_crestid);
							string text2 = FifaEnvironment.TempFolder + "\\" + andCheckIntField.ToString() + ".png";
							if (File.Exists(text2))
							{
								Bitmap bitmap = new Bitmap(text2);
								Bitmap bitmap2 = new Bitmap(256, 256, PixelFormat.Format32bppPArgb);
								Bitmap bitmap3 = new Bitmap(256, 256, PixelFormat.Format32bppPArgb);
								Bitmap bitmap4 = new Bitmap(256, 64, PixelFormat.Format32bppPArgb);
								Rectangle rectangle = new Rectangle(0, 0, 128, 128);
								Rectangle rectangle2 = new Rectangle(32, 32, 192, 192);
								Rectangle rectangle3 = new Rectangle(25, 0, 150, 150);
								Rectangle rectangle4 = new Rectangle(145, 4, 56, 56);
								GraphicUtil.RemapRectangle(bitmap, rectangle, bitmap2, rectangle2);
								GraphicUtil.RemapRectangle(bitmap, rectangle, bitmap3, rectangle3);
								GraphicUtil.RemapRectangle(bitmap, rectangle, bitmap4, rectangle4);
								array[l].SetAnimLogo(bitmap2);
								array[l].SetAnimLogoDark(bitmap2);
								array[l].SetSmallLogo(bitmap3);
								array[l].SetSmallLogoDark(bitmap3);
								array[l].SetTinyLogo(bitmap4);
								array[l].SetTinyLogoDark(bitmap4);
								break;
							}
						}
					}
				}
			}
			int num4 = 130010;
			for (int n = 0; n < table7.NValidRecords; n++)
			{
				Record record3 = table7.Records[n];
				int num5 = record3.GetAndCheckIntField(FI.teams_assetid);
				int andCheckIntField2 = record3.GetAndCheckIntField(FI.teams_teamid);
				Team team = null;
				bool flag2 = false;
				if (num5 != 33554432)
				{
					team = (Team)FifaEnvironment.Teams.SearchId(num5);
					if (team != null)
					{
						team.Roster.Clear();
						flag2 = true;
					}
				}
				if (team == null)
				{
					team = FifaEnvironment.Teams.FitTeam(record3.StringField[FI.teams_teamname], 0);
					if (team != null && country.Id != 216 && team.Country != country)
					{
						team = null;
					}
					if (team != null)
					{
						team.Roster.Clear();
					}
					flag2 = team != null;
				}
				if (team == null)
				{
					num4 = FifaEnvironment.Teams.GetNextId(num4);
					team = new Team(table7.Records[n]);
					team.Id = num4;
					team.Country = country;
					FifaEnvironment.Teams.InsertId(team);
				}
				if (statusBar != null)
				{
					statusBar.Text = "Importing Team: " + team.DatabaseName;
					statusBar.Owner.Refresh();
				}
				array2[n] = team;
				team.assetid = andCheckIntField2;
				team.TeamNameFull = team.DatabaseName;
				if (team.DatabaseName.Length > 15)
				{
					team.TeamNameAbbr15 = team.DatabaseName.Substring(0, 15);
				}
				else
				{
					team.TeamNameAbbr15 = team.DatabaseName;
				}
				if (team.DatabaseName.Length > 10)
				{
					team.TeamNameAbbr10 = team.DatabaseName.Substring(0, 10);
				}
				else
				{
					team.TeamNameAbbr10 = team.DatabaseName;
				}
				if (!flag2)
				{
					num5 = array2[n].assetid;
					Bitmap bitmap5 = null;
					Bitmap bitmap6 = null;
					int num6 = 0;
					while (num6 < table11.NValidRecords)
					{
						Record record4 = table11.Records[num6];
						if (record4.GetAndCheckIntField(FI.cz_teams_teamid) == num5)
						{
							int andCheckIntField3 = record4.GetAndCheckIntField(FI.cz_teams_hascrestimage);
							int andCheckIntField4 = record4.GetAndCheckIntField(FI.cz_teams_hassponsorimage);
							string text3 = FifaEnvironment.TempFolder + "\\" + andCheckIntField3.ToString() + ".png";
							if (File.Exists(text3))
							{
								bitmap5 = new Bitmap(text3);
								Rectangle rectangle5 = new Rectangle(0, 0, 128, 128);
								Bitmap bitmap7 = new Bitmap(256, 256, PixelFormat.Format32bppPArgb);
								Bitmap bitmap8 = new Bitmap(128, 128, PixelFormat.Format32bppPArgb);
								Bitmap bitmap9 = new Bitmap(256, 256, PixelFormat.Format32bppPArgb);
								Bitmap bitmap10 = new Bitmap(64, 64, PixelFormat.Format32bppPArgb);
								Bitmap bitmap11 = new Bitmap(32, 32, PixelFormat.Format32bppPArgb);
								Bitmap bitmap12 = new Bitmap(16, 16, PixelFormat.Format32bppPArgb);
								Rectangle rectangle6 = new Rectangle(0, 0, 150, 150);
								Rectangle rectangle7 = new Rectangle(0, 0, 102, 102);
								Rectangle rectangle8 = new Rectangle(0, 0, 256, 256);
								Rectangle rectangle9 = new Rectangle(0, 0, 50, 50);
								Rectangle rectangle10 = new Rectangle(0, 0, 32, 32);
								Rectangle rectangle11 = new Rectangle(0, 0, 16, 16);
								GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap7, rectangle6);
								GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap8, rectangle7);
								GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap9, rectangle8);
								GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap10, rectangle9);
								GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap11, rectangle10);
								GraphicUtil.RemapRectangle(bitmap5, rectangle5, bitmap12, rectangle11);
								array2[n].SetCrest(bitmap9);
								array2[n].SetCrest16(bitmap12);
								array2[n].SetCrest32(bitmap11);
								array2[n].SetCrest50(bitmap10);
								array2[n].SetCrestDark(bitmap9);
								array2[n].SetCrest16Dark(bitmap12);
								array2[n].SetCrest32Dark(bitmap11);
								array2[n].SetCrest50Dark(bitmap10);
							}
							text3 = FifaEnvironment.TempFolder + "\\" + andCheckIntField4.ToString() + ".png";
							if (File.Exists(text3))
							{
								bitmap6 = new Bitmap(text3);
								break;
							}
							break;
						}
						else
						{
							num6++;
						}
					}
					for (int num7 = 0; num7 < table10.NValidRecords; num7++)
					{
						Record record5 = table10.Records[num7];
						int andCheckIntField5 = record5.GetAndCheckIntField(FI.cz_teamkits_kitid);
						int andCheckIntField6 = record5.GetAndCheckIntField(FI.cz_teamkits_teamid);
						int andCheckIntField7 = record5.GetAndCheckIntField(FI.cz_teamkits_kittypeid);
						string text4 = Kit.KitTextureFileName(andCheckIntField5, 0, 0);
						if (team.assetid == andCheckIntField6)
						{
							int newId = FifaEnvironment.Kits.GetNewId();
							Kit kit = new Kit(newId, team.Id, andCheckIntField7);
							FifaEnvironment.Kits.Add(kit);
							kit.LinkTeam(FifaEnvironment.Teams);
							kit.jerseyBackName = record5.IntField[FI.cz_teamkits_jerseybacknameplacementcode] != 0;
							kit.jerseyNameFontCase = record5.IntField[FI.cz_teamkits_jerseybacknamefontcase];
							kit.jerseyNameFont = record5.IntField[FI.cz_teamkits_jerseynamefonttype];
							int num8 = record5.IntField[FI.cz_teamkits_jerseynamecolorr];
							int num9 = record5.IntField[FI.cz_teamkits_jerseynamecolorg];
							int num10 = record5.IntField[FI.cz_teamkits_jerseynamecolorb];
							kit.JerseyNameColor = Color.FromArgb(255, num8, num9, num10);
							kit.jerseyNameLayout = record5.IntField[FI.cz_teamkits_jerseynamelayouttype];
							kit.jerseyNumberFont = record5.IntField[FI.cz_teamkits_numberfonttype];
							kit.jerseyNumberColor = record5.IntField[FI.cz_teamkits_numbercolor];
							kit.shortsNumberColor = record5.IntField[FI.cz_teamkits_shortsnumbercolor];
							kit.shortsNumberFont = record5.IntField[FI.cz_teamkits_shortsnumberfonttype];
							kit.shortsNumber = true;
							kit.jerseyCollar = 0;
							num8 = record5.IntField[FI.cz_teamkits_jerseycolorprimr];
							num9 = record5.IntField[FI.cz_teamkits_jerseycolorprimg];
							num10 = record5.IntField[FI.cz_teamkits_jerseycolorprimb];
							Color color = Color.FromArgb(255, num8, num9, num10);
							kit.TeamColor1 = color;
							num8 = record5.IntField[FI.cz_teamkits_jerseycolorsecr];
							num9 = record5.IntField[FI.cz_teamkits_jerseycolorsecg];
							num10 = record5.IntField[FI.cz_teamkits_jerseycolorsecb];
							Color color2 = Color.FromArgb(255, num8, num9, num10);
							kit.TeamColor2 = color2;
							num8 = record5.IntField[FI.cz_teamkits_jerseycolortertr];
							num9 = record5.IntField[FI.cz_teamkits_jerseycolortertg];
							num10 = record5.IntField[FI.cz_teamkits_jerseycolortertb];
							Color color3 = Color.FromArgb(255, num8, num9, num10);
							kit.TeamColor3 = color3;
							num8 = record5.IntField[FI.cz_teamkits_shortcolorprimr];
							num9 = record5.IntField[FI.cz_teamkits_shortcolorprimg];
							num10 = record5.IntField[FI.cz_teamkits_shortcolorprimb];
							Color color4 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_shortcolorsecr];
							num9 = record5.IntField[FI.cz_teamkits_shortcolorsecg];
							num10 = record5.IntField[FI.cz_teamkits_shortcolorsecb];
							Color color5 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_shortcolortertr];
							num9 = record5.IntField[FI.cz_teamkits_shortcolortertg];
							num10 = record5.IntField[FI.cz_teamkits_shortcolortertb];
							Color color6 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_sockscolorprimr];
							num9 = record5.IntField[FI.cz_teamkits_sockscolorprimg];
							num10 = record5.IntField[FI.cz_teamkits_sockscolorprimb];
							Color color7 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_sockscolorsecr];
							num9 = record5.IntField[FI.cz_teamkits_sockscolorsecg];
							num10 = record5.IntField[FI.cz_teamkits_sockscolorsecb];
							Color color8 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_sockscolortertr];
							num9 = record5.IntField[FI.cz_teamkits_sockscolortertg];
							num10 = record5.IntField[FI.cz_teamkits_sockscolortertb];
							Color color9 = Color.FromArgb(255, num8, num9, num10);
							num8 = record5.IntField[FI.cz_teamkits_sponsorcolourr];
							num9 = record5.IntField[FI.cz_teamkits_sponsorcolourg];
							num10 = record5.IntField[FI.cz_teamkits_sponsorcolourb];
							Color color10 = Color.FromArgb(255, num8, num9, num10);
							float num11 = record5.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorl];
							float num12 = record5.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorr];
							float num13 = record5.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsort];
							float num14 = record5.FloatField[FI.cz_teamkits_hotspotjerseyfrontsponsorb];
							Kit.KitTextureFileName(team.Id, andCheckIntField7, 0);
							Kit kit2 = FifaEnvironment.Kits.GetKit(andCheckIntField5, 0);
							if (kit2 != null)
							{
								kit.jerseyCollar = kit2.jerseyCollar;
							}
							if (useKitGraphics && kit2 != null)
							{
								Bitmap miniKit = kit2.GetMiniKit(0);
								string text5 = FifaEnvironment.TempFolder + "\\" + text4;
								FifaEnvironment.ExportFileFromZdata(text4, FifaEnvironment.TempFolder);
								kit.ImportKitTextures(text5);
								Bitmap[] kitTextures = kit.GetKitTextures();
								if (bitmap5 != null)
								{
									kitTextures[0] = (Bitmap)bitmap5.Clone();
								}
								else
								{
									kitTextures[0] = null;
								}
								GraphicUtil.ColorizeRGB(kitTextures[1], color, color2, color3, 0, 1024);
								if (miniKit != null)
								{
									GraphicUtil.PrepareToColorize(miniKit, 25, 231);
									GraphicUtil.ColorizeRGB(miniKit, color, color2, color3, 25, 231);
								}
								if (bitmap6 != null && kitTextures[1] != null)
								{
									Bitmap bitmap13;
									if (color10.R != 225 || color10.G != 225 || color10.B != 225)
									{
										bitmap13 = GraphicUtil.ColorizeWhite(bitmap6, color10);
									}
									else
									{
										bitmap13 = bitmap6;
									}
									int num15 = (int)((double)num11 * 1024.0);
									int num16 = (int)((double)num13 * 1024.0);
									int num17 = (int)((double)num12 * 1024.0) - num15;
									int num18 = (int)((double)num14 * 1024.0) - num16;
									Rectangle rectangle12 = new Rectangle(num15, num16, num17, num18);
									kitTextures[1] = GraphicUtil.Overlap(kitTextures[1], bitmap13, rectangle12);
								}
								GraphicUtil.ColorizeRGB(kitTextures[3], color7, color8, color9, 0, 194);
								GraphicUtil.ColorizeRGB(kitTextures[3], color4, color5, color6, 194, 512);
								kit.SetKitTextures(kitTextures);
								if (miniKit != null)
								{
									kit.SetMiniKit(miniKit);
								}
							}
						}
					}
				}
			}
			for (int num19 = 0; num19 < array2.Length; num19++)
			{
				for (int num20 = 0; num20 < array2.Length; num20++)
				{
					if (array2[num19].rivalteam == array2[num20].assetid)
					{
						array2[num19].RivalTeam = array2[num20];
						break;
					}
				}
				if (array2[num19].RivalTeam == null)
				{
					array2[num19].RivalTeam = (Team)FifaEnvironment.Teams.SearchId(array2[num19].rivalteam);
				}
				if (array2[num19].RivalTeam == null)
				{
					array2[num19].RivalTeam = array2[0];
				}
			}
			for (int num21 = 0; num21 < table3.NValidRecords; num21++)
			{
				Record record6 = table3.Records[num21];
				int andCheckIntField8 = record6.GetAndCheckIntField(FI.stadiumassignments_teamid);
				for (int num22 = 0; num22 < array2.Length; num22++)
				{
					if (array2[num22].assetid == andCheckIntField8)
					{
						array2[num22].stadiumcustomname = record6.GetAndCheckStringField(FI.stadiumassignments_stadiumcustomname);
						break;
					}
				}
			}
			for (int num23 = 0; num23 < table4.NValidRecords; num23++)
			{
				Record record7 = table4.Records[num23];
				int andCheckIntField9 = record7.GetAndCheckIntField(FI.teamstadiumlinks_teamid);
				for (int num24 = 0; num24 < array2.Length; num24++)
				{
					if (array2[num24].assetid == andCheckIntField9)
					{
						array2[num24].stadiumid = record7.GetAndCheckIntField(FI.teamstadiumlinks_stadiumid);
						array2[num24].LinkStadium(FifaEnvironment.Stadiums);
						break;
					}
				}
			}
			for (int num25 = 0; num25 < table11.NValidRecords; num25++)
			{
				Record record8 = table11.Records[num25];
				int andCheckIntField10 = record8.GetAndCheckIntField(FI.cz_teams_teamid);
				for (int num26 = 0; num26 < array2.Length; num26++)
				{
					if (array2[num26].assetid == andCheckIntField10)
					{
						array2[num26].TeamNameAbbr3 = record8.GetAndCheckStringField(FI.cz_teams_teamabbrev3);
						break;
					}
				}
			}
			for (int num27 = 0; num27 < table6.NValidRecords; num27++)
			{
				Record record9 = table6.Records[num27];
				Formation formation = new Formation(record9);
				Formation formation2 = FifaEnvironment.GenericFormations.GetExactFormation(formation);
				if (formation2 == null)
				{
					int newId2 = FifaEnvironment.Formations.GetNewId();
					formation.Id = newId2;
					formation.teamid = -1;
					FifaEnvironment.Formations.InsertId(formation);
					FifaEnvironment.GenericFormations.InsertId(formation);
					formation2 = formation;
				}
				int andCheckIntField11 = record9.GetAndCheckIntField(FI.formations_teamid);
				for (int num28 = 0; num28 < array2.Length; num28++)
				{
					if (array2[num28].assetid == andCheckIntField11)
					{
						array2[num28].Formation = formation2;
						array2[num28].formationid = formation2.Id;
						break;
					}
				}
			}
			statusBar.Text = "Importing Players ...";
			int num29 = 220000;
			for (int num30 = 0; num30 < table9.NValidRecords; num30++)
			{
				Record record10 = table9.Records[num30];
				int andCheckIntField12 = record10.GetAndCheckIntField(FI.players_playerid);
				int num31 = 0;
				for (int num32 = 0; num32 < table12.NValidRecords; num32++)
				{
					Record record11 = table12.Records[num32];
					if (record11.GetAndCheckIntField(FI.cz_players_playerid) == andCheckIntField12)
					{
						num31 = record11.GetAndCheckIntField(FI.cz_players_assetid);
						break;
					}
				}
				Player player = null;
				if (num31 != 0)
				{
					player = (Player)FifaEnvironment.Players.SearchId(num31);
				}
				if (player == null)
				{
					num29 = FifaEnvironment.Players.GetNextId(num29);
					player = new Player(table9.Records[num30]);
					player.Id = num29;
					FifaEnvironment.Players.InsertId(player);
					player.LinkCountry(FifaEnvironment.Countries);
				}
				array3[num30] = player;
				player.m_assetid = andCheckIntField12;
			}
			for (int num33 = 0; num33 < table8.NValidRecords; num33++)
			{
				Record record12 = table8.Records[num33];
				int andCheckIntField13 = record12.GetAndCheckIntField(FI.editedplayernames_playerid);
				int num34 = 0;
				while (num34 < array3.Length)
				{
					if (andCheckIntField13 == array3[num34].m_assetid)
					{
						if (array3[num34].lastname != null && !(array3[num34].lastname == string.Empty))
						{
							break;
						}
						array3[num34].firstname = record12.GetAndCheckStringField(FI.editedplayernames_firstname);
						array3[num34].lastname = record12.GetAndCheckStringField(FI.editedplayernames_surname);
						array3[num34].commonname = record12.GetAndCheckStringField(FI.editedplayernames_commonname);
						if (array3[num34].commonname.Contains(array3[num34].lastname))
						{
							array3[num34].commonname = null;
						}
						array3[num34].playerjerseyname = record12.GetAndCheckStringField(FI.editedplayernames_playerjerseyname);
						if (array3[num34].playerjerseyname != array3[num34].lastname && array3[num34].playerjerseyname.Contains(array3[num34].lastname))
						{
							array3[num34].playerjerseyname = array3[num34].lastname;
							break;
						}
						break;
					}
					else
					{
						num34++;
					}
				}
			}
			for (int num35 = 0; num35 < table.NValidRecords; num35++)
			{
				Record record13 = table.Records[num35];
				int andCheckIntField14 = record13.GetAndCheckIntField(FI.leagueteamlinks_leagueid);
				int andCheckIntField15 = record13.GetAndCheckIntField(FI.leagueteamlinks_teamid);
				League league2 = null;
				if (andCheckIntField14 == 384)
				{
					league2 = League.GetDefaultLeague();
				}
				else if (andCheckIntField14 >= 385 && andCheckIntField14 <= 389)
				{
					league2 = array[andCheckIntField14 - 385];
				}
				if (league2 != null)
				{
					for (int num36 = 0; num36 < array2.Length; num36++)
					{
						if (array2[num36].assetid == andCheckIntField15)
						{
							league2.AddTeam(array2[num36]);
							break;
						}
					}
				}
			}
			for (int num37 = 0; num37 < table5.NValidRecords; num37++)
			{
				Record record14 = table5.Records[num37];
				int andCheckIntField16 = record14.GetAndCheckIntField(FI.teamplayerlinks_playerid);
				int andCheckIntField17 = record14.GetAndCheckIntField(FI.teamplayerlinks_teamid);
				for (int num38 = 0; num38 < array3.Length; num38++)
				{
					if (array3[num38].m_assetid == andCheckIntField16)
					{
						int num39 = 0;
						while (num39 < array2.Length)
						{
							if (array2[num39].assetid == andCheckIntField17)
							{
								array3[num38].PlayFor(array2[num39]);
								TeamPlayer teamPlayer = new TeamPlayer(record14, array3[num38], array2[num39]);
								array2[num39].Roster.Add(teamPlayer);
								if (array2[num39].captainid == array3[num38].m_assetid)
								{
									array2[num39].PlayerCaptain = array3[num38];
									array2[num39].captainid = array3[num38].Id;
								}
								if (array2[num39].freekicktakerid == array3[num38].m_assetid)
								{
									array2[num39].PlayerFreeKick = array3[num38];
									array2[num39].freekicktakerid = array3[num38].Id;
								}
								if (array2[num39].leftcornerkicktakerid == array3[num38].m_assetid)
								{
									array2[num39].PlayerLeftCorner = array3[num38];
									array2[num39].leftcornerkicktakerid = array3[num38].Id;
								}
								if (array2[num39].longkicktakerid == array3[num38].m_assetid)
								{
									array2[num39].PlayerLongKick = array3[num38];
									array2[num39].longkicktakerid = array3[num38].Id;
								}
								if (array2[num39].penaltytakerid == array3[num38].m_assetid)
								{
									array2[num39].PlayerPenalty = array3[num38];
									array2[num39].penaltytakerid = array3[num38].Id;
								}
								if (array2[num39].rightcornerkicktakerid == array3[num38].m_assetid)
								{
									array2[num39].PlayerRightCorner = array3[num38];
									array2[num39].rightcornerkicktakerid = array3[num38].Id;
									break;
								}
								break;
							}
							else
							{
								num39++;
							}
						}
						break;
					}
				}
			}
			for (int num40 = 0; num40 < array3.Length; num40++)
			{
				array3[num40].m_assetid = array3[num40].Id;
			}
			for (int num41 = 0; num41 < array2.Length; num41++)
			{
				array2[num41].assetid = array2[num41].Id;
			}
			if (statusBar != null)
			{
				statusBar.Text = "Importing complete";
				statusBar.Owner.Refresh();
			}
		}

		// Token: 0x040000BE RID: 190
		private int m_NFiles = -1;

		// Token: 0x040000BF RID: 191
		private UgcDirEntry[] m_UgcDir;

		// Token: 0x040000C0 RID: 192
		private BinaryReader m_BinaryReader;
	}
}
