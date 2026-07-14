using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000032 RID: 50
	public class League : IdObject
	{
		// Token: 0x17000126 RID: 294
		// (get) Token: 0x0600049C RID: 1180 RVA: 0x0001C110 File Offset: 0x0001A310
		// (set) Token: 0x0600049D RID: 1181 RVA: 0x0001C118 File Offset: 0x0001A318
		public string leaguename
		{
			get
			{
				return this.m_leaguename;
			}
			set
			{
				this.m_leaguename = value;
			}
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x0600049E RID: 1182 RVA: 0x0001C121 File Offset: 0x0001A321
		// (set) Token: 0x0600049F RID: 1183 RVA: 0x0001C129 File Offset: 0x0001A329
		public int level
		{
			get
			{
				return this.m_level;
			}
			set
			{
				this.m_level = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x060004A0 RID: 1184 RVA: 0x0001C132 File Offset: 0x0001A332
		// (set) Token: 0x060004A1 RID: 1185 RVA: 0x0001C13A File Offset: 0x0001A33A
		public int countryid
		{
			get
			{
				return this.m_countryid;
			}
			set
			{
				this.m_countryid = value;
			}
		}

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004A2 RID: 1186 RVA: 0x0001C143 File Offset: 0x0001A343
		// (set) Token: 0x060004A3 RID: 1187 RVA: 0x0001C14B File Offset: 0x0001A34B
		public Country Country
		{
			get
			{
				return this.m_Country;
			}
			set
			{
				this.m_Country = value;
				if (this.m_Country != null)
				{
					this.m_countryid = this.m_Country.Id;
					return;
				}
				this.m_countryid = 0;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004A4 RID: 1188 RVA: 0x0001C175 File Offset: 0x0001A375
		// (set) Token: 0x060004A5 RID: 1189 RVA: 0x0001C17D File Offset: 0x0001A37D
		public int[] boardoutcomes
		{
			get
			{
				return this.m_boardoutcomes;
			}
			set
			{
				this.m_boardoutcomes = value;
			}
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0001C186 File Offset: 0x0001A386
		// (set) Token: 0x060004A7 RID: 1191 RVA: 0x0001C18E File Offset: 0x0001A38E
		public bool iswithintransferwindow
		{
			get
			{
				return this.m_iswithintransferwindow;
			}
			set
			{
				this.m_iswithintransferwindow = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004A8 RID: 1192 RVA: 0x0001C197 File Offset: 0x0001A397
		// (set) Token: 0x060004A9 RID: 1193 RVA: 0x0001C19F File Offset: 0x0001A39F
		public int leaguetimeslice
		{
			get
			{
				return this.leaguetimeslice;
			}
			set
			{
				this.leaguetimeslice = value;
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x0001C1A8 File Offset: 0x0001A3A8
		// (set) Token: 0x060004AB RID: 1195 RVA: 0x0001C1B0 File Offset: 0x0001A3B0
		public string ShortName
		{
			get
			{
				return this.m_ShortName;
			}
			set
			{
				this.m_ShortName = value;
			}
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004AC RID: 1196 RVA: 0x0001C1B9 File Offset: 0x0001A3B9
		// (set) Token: 0x060004AD RID: 1197 RVA: 0x0001C1C1 File Offset: 0x0001A3C1
		public string LongName
		{
			get
			{
				return this.m_LongName;
			}
			set
			{
				this.m_LongName = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004AE RID: 1198 RVA: 0x0001C1CA File Offset: 0x0001A3CA
		// (set) Token: 0x060004AF RID: 1199 RVA: 0x0001C1D2 File Offset: 0x0001A3D2
		public TeamList PlayingTeams
		{
			get
			{
				return this.m_PlayingTeams;
			}
			set
			{
				this.m_PlayingTeams = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004B0 RID: 1200 RVA: 0x0001C1DB File Offset: 0x0001A3DB
		// (set) Token: 0x060004B1 RID: 1201 RVA: 0x0001C1E3 File Offset: 0x0001A3E3
		public Trophy Trophy
		{
			get
			{
				return this.m_Trophy;
			}
			set
			{
				this.m_Trophy = value;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x0001C1EC File Offset: 0x0001A3EC
		public override string ToString()
		{
			if (this.m_ShortName != null && this.m_ShortName != string.Empty)
			{
				return this.m_ShortName;
			}
			if (this.m_leaguename != null)
			{
				return this.m_leaguename;
			}
			return string.Empty;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0001C223 File Offset: 0x0001A423
		public string DatabaseString()
		{
			return this.m_leaguename;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001C22C File Offset: 0x0001A42C
		public League(int leagueid)
			: base(leagueid)
		{
			base.Id = leagueid;
			this.m_leaguename = "New League";
			this.m_level = 1;
			this.m_countryid = 0;
			this.LinkCountry(FifaEnvironment.Countries);
			this.m_iswithintransferwindow = false;
			this.m_leaguetimeslice = 0;
			this.m_ShortName = "Short League Name";
			this.m_LongName = "Long League Name";
			this.m_boardoutcomes[0] = 0;
			this.m_boardoutcomes[1] = 0;
			this.m_boardoutcomes[2] = 0;
			this.m_boardoutcomes[3] = 0;
			this.m_boardoutcomes[4] = 0;
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001C2D3 File Offset: 0x0001A4D3
		public League(Record r)
			: base(r.IntField[FI.leagues_leagueid])
		{
			this.Load(r);
			this.FillFromLanguage();
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x0001C30C File Offset: 0x0001A50C
		public void Load(Record r)
		{
			this.m_leaguename = r.StringField[FI.leagues_leaguename];
			this.m_level = r.GetAndCheckIntField(FI.leagues_level);
			this.m_countryid = r.GetAndCheckIntField(FI.leagues_countryid);
			this.m_iswithintransferwindow = r.GetAndCheckIntField(FI.leagues_iswithintransferwindow) != 0;
			this.m_leaguetimeslice = r.GetAndCheckIntField(FI.leagues_leaguetimeslice);
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x0001C375 File Offset: 0x0001A575
		public static League GetDefaultLeague()
		{
			return FifaEnvironment.Leagues.SearchLeague(76);
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001C383 File Offset: 0x0001A583
		public static int GetDefaultLeagueId()
		{
			return 76;
		}

		// Token: 0x060004B9 RID: 1209 RVA: 0x0001C388 File Offset: 0x0001A588
		public void LinkTeam(int teamid)
		{
			if (FifaEnvironment.Teams == null)
			{
				return;
			}
			Team team = (Team)FifaEnvironment.Teams.SearchId(teamid);
			if (team == null)
			{
				FifaEnvironment.UserMessages.ShowMessage(5022, teamid);
				return;
			}
			this.m_PlayingTeams.Add(team);
		}

		// Token: 0x060004BA RID: 1210 RVA: 0x0001C3D0 File Offset: 0x0001A5D0
		public void LinkTeam(Team team)
		{
			if (team == null)
			{
				FifaEnvironment.UserMessages.ShowMessage(5022, team.Id);
				return;
			}
			this.m_PlayingTeams.Add(team);
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x0001C3F9 File Offset: 0x0001A5F9
		public void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			this.m_Country = (Country)countryList.SearchId(this.m_countryid);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001C418 File Offset: 0x0001A618
		public void FillFromLanguage()
		{
			if (FifaEnvironment.Language != null)
			{
				this.m_ShortName = FifaEnvironment.Language.GetLeagueString(base.Id, Language.ELeagueStringType.Abbr15);
				this.m_LongName = FifaEnvironment.Language.GetLeagueString(base.Id, Language.ELeagueStringType.Full);
				if (this.m_LongName == null || this.m_LongName == string.Empty)
				{
					this.m_LongName = this.m_ShortName;
					return;
				}
			}
			else
			{
				this.m_ShortName = string.Empty;
				this.m_LongName = string.Empty;
				if (this.m_LongName == null || this.m_LongName == string.Empty)
				{
					this.m_LongName = this.m_ShortName;
				}
			}
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x0001C4C0 File Offset: 0x0001A6C0
		public void FillFromBoardOutcomes(Record r)
		{
			this.m_boardoutcomes[0] = r.GetAndCheckIntField(FI.career_boardoutcomes_outcome1);
			this.m_boardoutcomes[1] = r.GetAndCheckIntField(FI.career_boardoutcomes_outcome2);
			this.m_boardoutcomes[2] = r.GetAndCheckIntField(FI.career_boardoutcomes_outcome3);
			this.m_boardoutcomes[3] = r.GetAndCheckIntField(FI.career_boardoutcomes_outcome4);
			this.m_boardoutcomes[4] = r.GetAndCheckIntField(FI.career_boardoutcomes_outcome5);
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x0001C52C File Offset: 0x0001A72C
		public void SaveBoardOutcomes(Record r)
		{
			r.IntField[FI.career_boardoutcomes_leagueid] = base.Id;
			r.IntField[FI.career_boardoutcomes_outcome1] = this.m_boardoutcomes[0];
			r.IntField[FI.career_boardoutcomes_outcome2] = this.m_boardoutcomes[1];
			r.IntField[FI.career_boardoutcomes_outcome3] = this.m_boardoutcomes[2];
			r.IntField[FI.career_boardoutcomes_outcome4] = this.m_boardoutcomes[3];
			r.IntField[FI.career_boardoutcomes_outcome5] = this.m_boardoutcomes[4];
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x0001C5B0 File Offset: 0x0001A7B0
		public void AddTeam(Team team)
		{
			if (team == null)
			{
				return;
			}
			if (team.League != null && team.League != this)
			{
				team.League.RemoveTeam(team);
			}
			this.m_PlayingTeams.InsertId(team);
			team.League = this;
			team.PrevLeague = this;
			team.currenttableposition = this.m_PlayingTeams.Count;
			team.previousyeartableposition = this.m_PlayingTeams.Count;
		}

		// Token: 0x060004C0 RID: 1216 RVA: 0x0001C61B File Offset: 0x0001A81B
		public void RemoveTeam(Team team)
		{
			if (team == null)
			{
				return;
			}
			if (team.League == this)
			{
				team.League = null;
			}
			this.m_PlayingTeams.RemoveId(team);
		}

		// Token: 0x060004C1 RID: 1217 RVA: 0x0001C640 File Offset: 0x0001A840
		public void RemoveAllTeams()
		{
			while (this.m_PlayingTeams.Count > 0)
			{
				Team team = (Team)this.m_PlayingTeams[0];
				this.RemoveTeam(team);
			}
		}

		// Token: 0x060004C2 RID: 1218 RVA: 0x0001C676 File Offset: 0x0001A876
		public static string ReplayLogoTextureFileName(int id)
		{
			return "data/sceneassets/leaguelogo/leaguelogo_" + id.ToString() + "_textures.rx3";
		}

		// Token: 0x060004C3 RID: 1219 RVA: 0x0001C68E File Offset: 0x0001A88E
		public string ReplayLogoTextureFileName()
		{
			return League.ReplayLogoTextureFileName(base.Id);
		}

		// Token: 0x060004C4 RID: 1220 RVA: 0x0001C69B File Offset: 0x0001A89B
		public string ReplayLogoTexturesTemplateFileName()
		{
			return "data/sceneassets/leaguelogo/leaguelogo_#_textures.rx3";
		}

		// Token: 0x060004C5 RID: 1221 RVA: 0x0001C6A2 File Offset: 0x0001A8A2
		public static Bitmap[] GetReplayLogoTextures(int leagueId)
		{
			return FifaEnvironment.GetBmpsFromRx3(League.ReplayLogoTextureFileName(leagueId));
		}

		// Token: 0x060004C6 RID: 1222 RVA: 0x0001C6AF File Offset: 0x0001A8AF
		public Bitmap[] GetReplayLogoTextures()
		{
			return FifaEnvironment.GetBmpsFromRx3(this.ReplayLogoTextureFileName());
		}

		// Token: 0x060004C7 RID: 1223 RVA: 0x0001C6BC File Offset: 0x0001A8BC
		public bool SetReplayLogoTextures(Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(this.ReplayLogoTexturesTemplateFileName(), base.Id, bitmaps, ECompressionMode.Chunkzip2);
		}

		// Token: 0x060004C8 RID: 1224 RVA: 0x0001C6D1 File Offset: 0x0001A8D1
		public bool DeleteReplayLogoTextures()
		{
			return FifaEnvironment.DeleteFromZdata(this.ReplayLogoTextureFileName());
		}

		// Token: 0x060004C9 RID: 1225 RVA: 0x0001C6DE File Offset: 0x0001A8DE
		public static string ReplayLogoModelFileName(int id)
		{
			return "data/sceneassets/leaguelogo/leaguelogo_" + id.ToString() + ".rx3";
		}

		// Token: 0x060004CA RID: 1226 RVA: 0x0001C6F6 File Offset: 0x0001A8F6
		public string ReplayLogoModelTemplateFileName()
		{
			return "data/sceneassets/leaguelogo/leaguelogo_#.rx3";
		}

		// Token: 0x060004CB RID: 1227 RVA: 0x0001C6FD File Offset: 0x0001A8FD
		public string ReplayLogoModelFileName()
		{
			return League.ReplayLogoModelFileName(base.Id);
		}

		// Token: 0x060004CC RID: 1228 RVA: 0x0001C70A File Offset: 0x0001A90A
		public Rx3File GetReplayLogoModel()
		{
			return FifaEnvironment.GetRx3FromZdata(this.ReplayLogoModelFileName());
		}

		// Token: 0x060004CD RID: 1229 RVA: 0x0001C717 File Offset: 0x0001A917
		public static Rx3File GetReplayLogoModel(int id)
		{
			return FifaEnvironment.GetRx3FromZdata(League.ReplayLogoModelFileName(id));
		}

		// Token: 0x060004CE RID: 1230 RVA: 0x0001C724 File Offset: 0x0001A924
		public bool SetReplayLogoModel(string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.ReplayLogoModelFileName(), false, ECompressionMode.Chunkzip2);
		}

		// Token: 0x060004CF RID: 1231 RVA: 0x0001C734 File Offset: 0x0001A934
		public bool DeleteReplayLogoModel()
		{
			return FifaEnvironment.DeleteFromZdata(this.ReplayLogoModelFileName());
		}

		// Token: 0x060004D0 RID: 1232 RVA: 0x0001C744 File Offset: 0x0001A944
		public bool IsReplayLogoPatched()
		{
			bool flag = FifaEnvironment.IsPatched(this.ReplayLogoTextureFileName());
			return FifaEnvironment.IsPatched(this.ReplayLogoTextureFileName()) || flag;
		}

		// Token: 0x060004D1 RID: 1233 RVA: 0x0001C770 File Offset: 0x0001A970
		public bool CreateReplayLogoPatch()
		{
			string text = FifaEnvironment.LaunchDir + "\\Templates\\" + this.ReplayLogoTexturesTemplateFileName();
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(text, this.ReplayLogoTextureFileName(), false, ECompressionMode.None);
			text = FifaEnvironment.LaunchDir + "\\Templates\\" + this.ReplayLogoModelTemplateFileName();
			bool flag2 = FifaEnvironment.ImportFileIntoZdataAs(text, this.ReplayLogoModelFileName(), false, ECompressionMode.None);
			return flag2 && flag;
		}

		// Token: 0x060004D2 RID: 1234 RVA: 0x0001C7D0 File Offset: 0x0001A9D0
		public bool RemoveReplayLogoPatch()
		{
			bool flag = FifaEnvironment.DeleteFromZdata(this.ReplayLogoTextureFileName());
			bool flag2 = FifaEnvironment.DeleteFromZdata(this.ReplayLogoModelFileName());
			return flag2 && flag;
		}

		// Token: 0x060004D3 RID: 1235 RVA: 0x0001C7FB File Offset: 0x0001A9FB
		public static string AnimLogoDdsFileName(int id)
		{
			return "data/ui/imgassets/league/l" + id.ToString() + ".dds";
		}

		// Token: 0x060004D4 RID: 1236 RVA: 0x0001C813 File Offset: 0x0001AA13
		public string AnimLogoTemplateFileName()
		{
			return "data/ui/imgassets/league/l#.dds";
		}

		// Token: 0x060004D5 RID: 1237 RVA: 0x0001C81A File Offset: 0x0001AA1A
		public string AnimLogoDdsFileName()
		{
			return League.AnimLogoDdsFileName(base.Id);
		}

		// Token: 0x060004D6 RID: 1238 RVA: 0x0001C827 File Offset: 0x0001AA27
		public Bitmap GetAnimLogo()
		{
			return FifaEnvironment.GetDdsArtasset(this.AnimLogoDdsFileName());
		}

		// Token: 0x060004D7 RID: 1239 RVA: 0x0001C834 File Offset: 0x0001AA34
		public bool SetAnimLogo(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.AnimLogoTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x060004D8 RID: 1240 RVA: 0x0001C84D File Offset: 0x0001AA4D
		public bool DeleteAnimLogo()
		{
			return FifaEnvironment.DeleteFromZdata(this.AnimLogoDdsFileName());
		}

		// Token: 0x060004D9 RID: 1241 RVA: 0x0001C85A File Offset: 0x0001AA5A
		public static string AnimLogoDarkDdsFileName(int id)
		{
			return "data/ui/imgassets/league/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x060004DA RID: 1242 RVA: 0x0001C872 File Offset: 0x0001AA72
		public string AnimLogoDarkTemplateFileName()
		{
			return "data/ui/imgassets/league/dark/l#.dds";
		}

		// Token: 0x060004DB RID: 1243 RVA: 0x0001C879 File Offset: 0x0001AA79
		public string AnimLogoDarkDdsFileName()
		{
			return League.AnimLogoDarkDdsFileName(base.Id);
		}

		// Token: 0x060004DC RID: 1244 RVA: 0x0001C886 File Offset: 0x0001AA86
		public Bitmap GetAnimLogoDark()
		{
			return FifaEnvironment.GetDdsArtasset(this.AnimLogoDarkDdsFileName());
		}

		// Token: 0x060004DD RID: 1245 RVA: 0x0001C893 File Offset: 0x0001AA93
		public bool SetAnimLogoDark(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.AnimLogoDarkTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x060004DE RID: 1246 RVA: 0x0001C8AC File Offset: 0x0001AAAC
		public bool DeleteAnimLogoDark()
		{
			return FifaEnvironment.DeleteFromZdata(this.AnimLogoDarkDdsFileName());
		}

		// Token: 0x060004DF RID: 1247 RVA: 0x0001C8B9 File Offset: 0x0001AAB9
		public static string TinyLogoDdsFileName(int id)
		{
			return "data/ui/imgassets/leaguelogos_tiny/l" + id.ToString() + ".dds";
		}

		// Token: 0x060004E0 RID: 1248 RVA: 0x0001C8D1 File Offset: 0x0001AAD1
		public string TinyLogoTemplateFileName()
		{
			return "data/ui/imgassets/leaguelogos_tiny/l#.dds";
		}

		// Token: 0x060004E1 RID: 1249 RVA: 0x0001C8D8 File Offset: 0x0001AAD8
		public string TinyLogoDdsFileName()
		{
			return League.TinyLogoDdsFileName(base.Id);
		}

		// Token: 0x060004E2 RID: 1250 RVA: 0x0001C8E5 File Offset: 0x0001AAE5
		public Bitmap GetTinyLogo()
		{
			return FifaEnvironment.GetDdsArtasset(this.TinyLogoDdsFileName());
		}

		// Token: 0x060004E3 RID: 1251 RVA: 0x0001C8F2 File Offset: 0x0001AAF2
		public bool SetTinyLogo(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.TinyLogoTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x060004E4 RID: 1252 RVA: 0x0001C90B File Offset: 0x0001AB0B
		public bool DeleteTinyLogo()
		{
			return FifaEnvironment.DeleteFromZdata(this.TinyLogoDdsFileName());
		}

		// Token: 0x060004E5 RID: 1253 RVA: 0x0001C918 File Offset: 0x0001AB18
		public static string TinyLogoDarkDdsFileName(int id)
		{
			return "data/ui/imgassets/leaguelogos_tiny/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x060004E6 RID: 1254 RVA: 0x0001C930 File Offset: 0x0001AB30
		public string TinyLogoDarkTemplateFileName()
		{
			return "data/ui/imgassets/leaguelogos_tiny/dark/l#.dds";
		}

		// Token: 0x060004E7 RID: 1255 RVA: 0x0001C937 File Offset: 0x0001AB37
		public string TinyLogoDarkDdsFileName()
		{
			return League.TinyLogoDarkDdsFileName(base.Id);
		}

		// Token: 0x060004E8 RID: 1256 RVA: 0x0001C944 File Offset: 0x0001AB44
		public Bitmap GetTinyLogoDark()
		{
			return FifaEnvironment.GetDdsArtasset(this.TinyLogoDarkDdsFileName());
		}

		// Token: 0x060004E9 RID: 1257 RVA: 0x0001C951 File Offset: 0x0001AB51
		public bool SetTinyLogoDark(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.TinyLogoDarkTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x060004EA RID: 1258 RVA: 0x0001C96A File Offset: 0x0001AB6A
		public bool DeleteTinyLogoDark()
		{
			return FifaEnvironment.DeleteFromZdata(this.TinyLogoDarkDdsFileName());
		}

		// Token: 0x060004EB RID: 1259 RVA: 0x0001C977 File Offset: 0x0001AB77
		public static string SmallLogoDdsFileName(int id)
		{
			return "data/ui/imgassets/leaguelogos_sm/l" + id.ToString() + ".dds";
		}

		// Token: 0x060004EC RID: 1260 RVA: 0x0001C98F File Offset: 0x0001AB8F
		public string SmallLogoTemplateFileName()
		{
			return "data/ui/imgassets/leaguelogos_sm/l#.dds";
		}

		// Token: 0x060004ED RID: 1261 RVA: 0x0001C996 File Offset: 0x0001AB96
		public string SmallLogoDdsFileName()
		{
			return League.SmallLogoDdsFileName(base.Id);
		}

		// Token: 0x060004EE RID: 1262 RVA: 0x0001C9A3 File Offset: 0x0001ABA3
		public Bitmap GetSmallLogo()
		{
			return FifaEnvironment.GetDdsArtasset(this.SmallLogoDdsFileName());
		}

		// Token: 0x060004EF RID: 1263 RVA: 0x0001C9B0 File Offset: 0x0001ABB0
		public bool SetSmallLogo(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.SmallLogoTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x060004F0 RID: 1264 RVA: 0x0001C9C9 File Offset: 0x0001ABC9
		public bool DeleteSmallLogo()
		{
			return FifaEnvironment.DeleteFromZdata(this.SmallLogoDdsFileName());
		}

		// Token: 0x060004F1 RID: 1265 RVA: 0x0001C9D6 File Offset: 0x0001ABD6
		public static string SmallLogoDarkDdsFileName(int id)
		{
			return "data/ui/imgassets/leaguelogos_sm/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x060004F2 RID: 1266 RVA: 0x0001C9EE File Offset: 0x0001ABEE
		public string SmallLogoDarkTemplateFileName()
		{
			return "data/ui/imgassets/leaguelogos_sm/dark/l#.dds";
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x0001C9F5 File Offset: 0x0001ABF5
		public string SmallLogoDarkDdsFileName()
		{
			return League.SmallLogoDarkDdsFileName(base.Id);
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x0001CA02 File Offset: 0x0001AC02
		public Bitmap GetSmallLogoDark()
		{
			return FifaEnvironment.GetDdsArtasset(this.SmallLogoDarkDdsFileName());
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x0001CA0F File Offset: 0x0001AC0F
		public bool SetSmallLogoDark(Bitmap bitmap)
		{
			return bitmap != null && FifaEnvironment.SetDdsArtasset(this.SmallLogoDarkTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x0001CA28 File Offset: 0x0001AC28
		public bool DeleteSmallLogoDark()
		{
			return FifaEnvironment.DeleteFromZdata(this.SmallLogoDarkDdsFileName());
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x0001CA38 File Offset: 0x0001AC38
		public void SaveLeague(Record r)
		{
			r.IntField[FI.leagues_leagueid] = base.Id;
			r.StringField[FI.leagues_leaguename] = this.m_leaguename;
			r.IntField[FI.leagues_level] = this.m_level;
			r.IntField[FI.leagues_countryid] = this.m_countryid;
			r.IntField[FI.leagues_leaguetimeslice] = this.m_leaguetimeslice;
			r.IntField[FI.leagues_iswithintransferwindow] = (this.m_iswithintransferwindow ? 1 : 0);
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x0001CAB8 File Offset: 0x0001ACB8
		public void SaveTeamLink(Record r, Team team, int artificialkey)
		{
			r.IntField[FI.leagueteamlinks_artificialkey] = artificialkey;
			r.IntField[FI.leagueteamlinks_leagueid] = base.Id;
			r.IntField[FI.leagueteamlinks_teamid] = team.Id;
			if (team.PrevLeague != null)
			{
				r.IntField[FI.leagueteamlinks_prevleagueid] = team.PrevLeague.Id;
				r.IntField[FI.leagueteamlinks_champion] = (team.IsChampion ? 1 : 0);
			}
			else
			{
				r.IntField[FI.leagueteamlinks_prevleagueid] = base.Id;
				r.IntField[FI.leagueteamlinks_champion] = 0;
			}
			r.IntField[FI.leagueteamlinks_previousyeartableposition] = team.previousyeartableposition;
			r.IntField[FI.leagueteamlinks_currenttableposition] = team.currenttableposition;
			r.IntField[FI.leagueteamlinks_teamshortform] = team.teamshortform;
			r.IntField[FI.leagueteamlinks_teamlongform] = team.teamlongform;
			r.IntField[FI.leagueteamlinks_teamform] = team.teamform;
			r.IntField[FI.leagueteamlinks_hasachievedobjective] = (team.hasachievedobjective ? 1 : 0);
			r.IntField[FI.leagueteamlinks_yettowin] = (team.yettowin ? 1 : 0);
			r.IntField[FI.leagueteamlinks_unbeatenallcomps] = (team.unbeatenallcomps ? 1 : 0);
			r.IntField[FI.leagueteamlinks_unbeatenaway] = (team.unbeatenaway ? 1 : 0);
			r.IntField[FI.leagueteamlinks_unbeatenhome] = (team.unbeatenhome ? 1 : 0);
			r.IntField[FI.leagueteamlinks_unbeatenleague] = (team.unbeatenleague ? 1 : 0);
			r.IntField[FI.leagueteamlinks_highestpossible] = team.highestpossible;
			r.IntField[FI.leagueteamlinks_highestprobable] = team.highestprobable;
			r.IntField[FI.leagueteamlinks_nummatchesplayed] = team.nummatchesplayed;
			r.IntField[FI.leagueteamlinks_gapresult] = team.gapresult;
			r.IntField[FI.leagueteamlinks_grouping] = team.grouping;
			r.IntField[FI.leagueteamlinks_objective] = team.objective;
			r.IntField[FI.leagueteamlinks_actualvsexpectations] = team.actualvsexpectations;
			r.IntField[FI.leagueteamlinks_lastgameresult] = team.lastgameresult;
			r.IntField[FI.leagueteamlinks_homega] = team.homega;
			r.IntField[FI.leagueteamlinks_homegf] = team.homegf;
			r.IntField[FI.leagueteamlinks_points] = team.points;
			r.IntField[FI.leagueteamlinks_awayga] = team.awayga;
			r.IntField[FI.leagueteamlinks_homewins] = team.secondarytable;
			r.IntField[FI.leagueteamlinks_homewins] = team.homewins;
			r.IntField[FI.leagueteamlinks_awaywins] = team.awaywins;
			r.IntField[FI.leagueteamlinks_homelosses] = team.homelosses;
			r.IntField[FI.leagueteamlinks_awaylosses] = team.awaylosses;
			r.IntField[FI.leagueteamlinks_awaydraws] = team.awaydraws;
			r.IntField[FI.leagueteamlinks_homedraws] = team.homedraws;
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x0001CD8E File Offset: 0x0001AF8E
		public void SynchronizeLeague()
		{
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x0001CD90 File Offset: 0x0001AF90
		public bool ContainsNationalTeams()
		{
			foreach (object obj in this.m_PlayingTeams)
			{
				Team team = (Team)obj;
				if (team.IsNationalTeam())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x04000219 RID: 537
		private string m_leaguename;

		// Token: 0x0400021A RID: 538
		private int m_level;

		// Token: 0x0400021B RID: 539
		private int m_countryid;

		// Token: 0x0400021C RID: 540
		private Country m_Country;

		// Token: 0x0400021D RID: 541
		private int[] m_boardoutcomes = new int[5];

		// Token: 0x0400021E RID: 542
		private bool m_iswithintransferwindow;

		// Token: 0x0400021F RID: 543
		private int m_leaguetimeslice;

		// Token: 0x04000220 RID: 544
		private string m_ShortName;

		// Token: 0x04000221 RID: 545
		private string m_LongName;

		// Token: 0x04000222 RID: 546
		private TeamList m_PlayingTeams = new TeamList();

		// Token: 0x04000223 RID: 547
		private Trophy m_Trophy;
	}
}
