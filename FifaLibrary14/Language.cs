using System;
using System.Collections.Generic;

namespace FifaLibrary
{
	// Token: 0x0200006C RID: 108
	public class Language : Dictionary<int, string>
	{
		// Token: 0x0600093A RID: 2362 RVA: 0x0004397C File Offset: 0x00041B7C
		public Language(Table langTable)
		{
			this.m_LangTable = langTable;
			this.m_Conventional = new Dictionary<int, string>();
			this.Load(this.m_LangTable);
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000439A4 File Offset: 0x00041BA4
		public void Load(Table langTable)
		{
			base.Clear();
			this.m_Conventional.Clear();
			for (int i = 0; i < langTable.NRecords; i++)
			{
				Record record = langTable.Records[i];
				int num = record.IntField[FI.language_hashid];
				if (!base.ContainsKey(num))
				{
					string text = record.CompressedString[FI.language_sourcetext];
					base.Add(num, text);
					text = record.CompressedString[FI.language_stringid];
					this.m_Conventional.Add(num, text);
				}
			}
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00043A24 File Offset: 0x00041C24
		public void Save(Table langTable)
		{
			langTable.ResizeRecords(base.Count);
			langTable.NValidRecords = base.Count;
			int num = 0;
			foreach (KeyValuePair<int, string> keyValuePair in this)
			{
				Record record = langTable.Records[num];
				num++;
				record.IntField[FI.language_hashid] = keyValuePair.Key;
				string empty;
				if (!this.m_Conventional.TryGetValue(keyValuePair.Key, out empty))
				{
					empty = string.Empty;
				}
				if (keyValuePair.Value != null)
				{
					record.CompressedString[FI.language_sourcetext] = keyValuePair.Value;
				}
				else
				{
					record.CompressedString[FI.language_sourcetext] = string.Empty;
				}
				record.CompressedString[FI.language_stringid] = empty;
			}
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00043B08 File Offset: 0x00041D08
		public uint GetTournamentHash(int assetId, Language.ETournamentStringType stringType)
		{
			string tournamentConventionalString = this.GetTournamentConventionalString(assetId, stringType);
			return FifaUtil.ComputeLanguageHash(tournamentConventionalString);
		}

		// Token: 0x0600093E RID: 2366 RVA: 0x00043B24 File Offset: 0x00041D24
		public string GetTournamentConventionalString(int assetId, Language.ETournamentStringType stringType)
		{
			string text;
			switch (stringType)
			{
			case Language.ETournamentStringType.Full:
				text = "TrophyName_";
				break;
			case Language.ETournamentStringType.Abbr15:
				text = "TrophyName_Abbr15_";
				break;
			default:
				return null;
			}
			return text + assetId.ToString();
		}

		// Token: 0x0600093F RID: 2367 RVA: 0x00043B64 File Offset: 0x00041D64
		public string GetTournamentString(int assetId, Language.ETournamentStringType stringType)
		{
			string tournamentConventionalString = this.GetTournamentConventionalString(assetId, stringType);
			if (tournamentConventionalString == null)
			{
				return string.Empty;
			}
			return this.GetString(tournamentConventionalString);
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00043B8C File Offset: 0x00041D8C
		public void SetTournamentString(int assetId, Language.ETournamentStringType stringType, string name)
		{
			string tournamentConventionalString = this.GetTournamentConventionalString(assetId, stringType);
			if (tournamentConventionalString == null)
			{
				return;
			}
			this.SetString(tournamentConventionalString, name);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x00043BB0 File Offset: 0x00041DB0
		public void RemoveTournamentString(int assetId, Language.ETournamentStringType stringType)
		{
			string tournamentConventionalString = this.GetTournamentConventionalString(assetId, stringType);
			if (tournamentConventionalString == null)
			{
				return;
			}
			this.RemoveString(tournamentConventionalString);
		}

		// Token: 0x06000942 RID: 2370 RVA: 0x00043BD4 File Offset: 0x00041DD4
		public uint GetFormationtHash(int formationFullNameId)
		{
			string formationConventionalString = this.GetFormationConventionalString(formationFullNameId);
			return FifaUtil.ComputeLanguageHash(formationConventionalString);
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x00043BF0 File Offset: 0x00041DF0
		public string GetFormationConventionalString(int formationFullNameId)
		{
			string text = "Formation_FullName_";
			return text + formationFullNameId.ToString();
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x00043C14 File Offset: 0x00041E14
		public string GetFormationString(int formationFullNameId)
		{
			if (formationFullNameId < 0)
			{
				return null;
			}
			string formationConventionalString = this.GetFormationConventionalString(formationFullNameId);
			if (formationConventionalString == null)
			{
				return string.Empty;
			}
			return this.GetString(formationConventionalString);
		}

		// Token: 0x06000945 RID: 2373 RVA: 0x00043C40 File Offset: 0x00041E40
		public void SetFormationString(int formationFullNameId, string name)
		{
			string formationConventionalString = this.GetFormationConventionalString(formationFullNameId);
			if (formationConventionalString == null)
			{
				return;
			}
			this.SetString(formationConventionalString, name);
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00043C64 File Offset: 0x00041E64
		public void RemoveFormationString(int assetId)
		{
			string formationConventionalString = this.GetFormationConventionalString(assetId);
			if (formationConventionalString == null)
			{
				return;
			}
			this.RemoveString(formationConventionalString);
		}

		// Token: 0x06000947 RID: 2375 RVA: 0x00043C84 File Offset: 0x00041E84
		public uint GetLeagueHash(int assetId, Language.ELeagueStringType stringType)
		{
			string leagueConventionalString = this.GetLeagueConventionalString(assetId, stringType);
			return FifaUtil.ComputeLanguageHash(leagueConventionalString);
		}

		// Token: 0x06000948 RID: 2376 RVA: 0x00043CA0 File Offset: 0x00041EA0
		private string GetLeagueConventionalString(int assetId, Language.ELeagueStringType stringType)
		{
			string text;
			switch (stringType)
			{
			case Language.ELeagueStringType.Full:
				text = "LeagueName_";
				break;
			case Language.ELeagueStringType.Abbr15:
				text = "LeagueName_Abbr15_";
				break;
			default:
				return null;
			}
			return text + assetId.ToString();
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00043CE0 File Offset: 0x00041EE0
		public string GetLeagueString(int assetId, Language.ELeagueStringType stringType)
		{
			string leagueConventionalString = this.GetLeagueConventionalString(assetId, stringType);
			if (leagueConventionalString == null)
			{
				return string.Empty;
			}
			return this.GetString(leagueConventionalString);
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00043D08 File Offset: 0x00041F08
		public void SetLeagueString(int assetId, Language.ELeagueStringType stringType, string name)
		{
			string leagueConventionalString = this.GetLeagueConventionalString(assetId, stringType);
			if (leagueConventionalString == null)
			{
				return;
			}
			this.SetString(leagueConventionalString, name);
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00043D2C File Offset: 0x00041F2C
		public void RemoveLeagueString(int assetId, Language.ELeagueStringType stringType)
		{
			string leagueConventionalString = this.GetLeagueConventionalString(assetId, stringType);
			if (leagueConventionalString == null)
			{
				return;
			}
			this.RemoveString(leagueConventionalString);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00043D50 File Offset: 0x00041F50
		public uint GetStadiumHash(int id)
		{
			string stadiumConventionalString = this.GetStadiumConventionalString(id);
			return FifaUtil.ComputeLanguageHash(stadiumConventionalString);
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00043D6C File Offset: 0x00041F6C
		private string GetStadiumConventionalString(int stadiumId)
		{
			return "StadiumName_" + stadiumId.ToString();
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x00043D8C File Offset: 0x00041F8C
		public string GetStadiumName(int stadiumId)
		{
			string stadiumConventionalString = this.GetStadiumConventionalString(stadiumId);
			return this.GetString(stadiumConventionalString);
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x00043DA8 File Offset: 0x00041FA8
		public void SetStadiumName(int stadiumId, string stadiumName)
		{
			string stadiumConventionalString = this.GetStadiumConventionalString(stadiumId);
			this.SetString(stadiumConventionalString, stadiumName);
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x00043DC8 File Offset: 0x00041FC8
		public void RemoveStadiumName(int stadiumId)
		{
			string stadiumConventionalString = this.GetStadiumConventionalString(stadiumId);
			this.RemoveString(stadiumConventionalString);
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x00043DE4 File Offset: 0x00041FE4
		public uint GetBallHash(int id)
		{
			string ballConventionalString = this.GetBallConventionalString(id, true);
			return FifaUtil.ComputeLanguageHash(ballConventionalString);
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00043E00 File Offset: 0x00042000
		private string GetBallConventionalString(int ballId, bool isGeneric)
		{
			string text;
			if (isGeneric)
			{
				text = "ballname_" + ballId.ToString();
			}
			else
			{
				text = "BallName_" + ballId.ToString();
			}
			return text;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x00043E38 File Offset: 0x00042038
		public string GetBallName(int ballId, out bool isGeneric)
		{
			string ballConventionalString = this.GetBallConventionalString(ballId, true);
			int num = (int)FifaUtil.ComputeLanguageHash(ballConventionalString);
			string @string = this.GetString(num);
			string conventionalString = this.GetConventionalString(num);
			isGeneric = conventionalString == ballConventionalString;
			return @string;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00043E70 File Offset: 0x00042070
		public void SetBallName(int ballId, string ballName, bool isGeneric)
		{
			string ballConventionalString = this.GetBallConventionalString(ballId, isGeneric);
			this.SetString(ballConventionalString, ballName);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x00043E90 File Offset: 0x00042090
		public void RemoveBallName(int ballId)
		{
			string ballConventionalString = this.GetBallConventionalString(ballId, true);
			this.RemoveString(ballConventionalString);
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00043EB0 File Offset: 0x000420B0
		public uint GetShoesHash(int id)
		{
			string shoesConventionalString = this.GetShoesConventionalString(id);
			return FifaUtil.ComputeLanguageHash(shoesConventionalString);
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00043ECC File Offset: 0x000420CC
		private string GetShoesConventionalString(int ShoesId)
		{
			return "CreatePlayerBoot_" + ShoesId.ToString();
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00043EEC File Offset: 0x000420EC
		public string GetShoesName(int ShoesId)
		{
			string shoesConventionalString = this.GetShoesConventionalString(ShoesId);
			int num = (int)FifaUtil.ComputeLanguageHash(shoesConventionalString);
			return this.GetString(num);
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00043F14 File Offset: 0x00042114
		public void SetShoesName(int ShoesId, string ShoesName)
		{
			string shoesConventionalString = this.GetShoesConventionalString(ShoesId);
			this.SetString(shoesConventionalString, ShoesName);
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00043F34 File Offset: 0x00042134
		public void RemoveShoesName(int ShoesId)
		{
			string shoesConventionalString = this.GetShoesConventionalString(ShoesId);
			this.RemoveString(shoesConventionalString);
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00043F50 File Offset: 0x00042150
		public uint GetCountryHash(int countryId)
		{
			string countryConventionalString = this.GetCountryConventionalString(countryId);
			return FifaUtil.ComputeLanguageHash(countryConventionalString);
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x00043F6C File Offset: 0x0004216C
		public string GetCountryConventionalString(int countryId)
		{
			return "NationName_" + countryId.ToString();
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00043F8C File Offset: 0x0004218C
		public string GetCountryName(int countryId)
		{
			string countryConventionalString = this.GetCountryConventionalString(countryId);
			return this.GetString(countryConventionalString);
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x00043FA8 File Offset: 0x000421A8
		public void SetCountryName(int countryId, string countryName)
		{
			string countryConventionalString = this.GetCountryConventionalString(countryId);
			this.SetString(countryConventionalString, countryName);
		}

		// Token: 0x0600095F RID: 2399 RVA: 0x00043FC8 File Offset: 0x000421C8
		public void RemoveCountryName(int countryId)
		{
			string countryConventionalString = this.GetCountryConventionalString(countryId);
			this.RemoveString(countryConventionalString);
		}

		// Token: 0x06000960 RID: 2400 RVA: 0x00043FE4 File Offset: 0x000421E4
		private string GetRoleLongConventionalString(int roleId)
		{
			return "SoccerFormationPosFull_" + roleId.ToString();
		}

		// Token: 0x06000961 RID: 2401 RVA: 0x00044004 File Offset: 0x00042204
		private string GetRoleShortConventionalString(int roleId)
		{
			string text = "SoccerFormationPos_Abbr4_";
			switch (roleId)
			{
			case 0:
				text += "GK";
				break;
			case 1:
				text += "SW";
				break;
			case 2:
				text += "RWB";
				break;
			case 3:
				text += "RB";
				break;
			case 4:
				text += "RCB";
				break;
			case 5:
				text += "CB";
				break;
			case 6:
				text += "LCB";
				break;
			case 7:
				text += "LB";
				break;
			case 8:
				text += "LWB";
				break;
			case 9:
				text += "RDM";
				break;
			case 10:
				text += "CDM";
				break;
			case 11:
				text += "LDM";
				break;
			case 12:
				text += "RM";
				break;
			case 13:
				text += "RCM";
				break;
			case 14:
				text += "CM";
				break;
			case 15:
				text += "LCM";
				break;
			case 16:
				text += "LM";
				break;
			case 17:
				text += "RAM";
				break;
			case 18:
				text += "CAM";
				break;
			case 19:
				text += "LAM";
				break;
			case 20:
				text += "RF";
				break;
			case 21:
				text += "CF";
				break;
			case 22:
				text += "LF";
				break;
			case 23:
				text += "RW";
				break;
			case 24:
				text += "RS";
				break;
			case 25:
				text += "ST";
				break;
			case 26:
				text += "LS";
				break;
			case 27:
				text += "LW";
				break;
			default:
				return null;
			}
			return text;
		}

		// Token: 0x06000962 RID: 2402 RVA: 0x00044258 File Offset: 0x00042458
		public string GetRoleShortString(int roleId)
		{
			string text;
			switch (roleId)
			{
			case 28:
				text = "Substitute";
				break;
			case 29:
				text = "Reserve";
				break;
			default:
				text = this.GetRoleShortConventionalString(roleId);
				break;
			}
			return this.GetString(text);
		}

		// Token: 0x06000963 RID: 2403 RVA: 0x0004429C File Offset: 0x0004249C
		public void SetRoleShortString(int roleId, string roleShortName)
		{
			string roleShortConventionalString = this.GetRoleShortConventionalString(roleId);
			this.SetString(roleShortConventionalString, roleShortName);
		}

		// Token: 0x06000964 RID: 2404 RVA: 0x000442BC File Offset: 0x000424BC
		public string GetRoleLongString(int roleId)
		{
			string roleLongConventionalString = this.GetRoleLongConventionalString(roleId);
			return this.GetString(roleLongConventionalString);
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000442D8 File Offset: 0x000424D8
		public void SetRoleLongString(int roleId, string roleLongName)
		{
			string roleShortConventionalString = this.GetRoleShortConventionalString(roleId);
			this.SetString(roleShortConventionalString, roleLongName);
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x000442F8 File Offset: 0x000424F8
		public uint GetSponsorDescriptionHash(int id)
		{
			string sponsorDescrConventionalString = this.GetSponsorDescrConventionalString(id);
			return FifaUtil.ComputeLanguageHash(sponsorDescrConventionalString);
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x00044314 File Offset: 0x00042514
		public uint GetSponsorNameHash(int id)
		{
			string sponsorNameConventionalString = this.GetSponsorNameConventionalString(id);
			return FifaUtil.ComputeLanguageHash(sponsorNameConventionalString);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x00044330 File Offset: 0x00042530
		private string GetSponsorNameConventionalString(int sponsorId)
		{
			return "mm_Sponsor" + sponsorId.ToString();
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x00044350 File Offset: 0x00042550
		private string GetSponsorDescrConventionalString(int sponsorId)
		{
			return "mm_SponsorBio" + sponsorId.ToString();
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00044370 File Offset: 0x00042570
		public string GetSponsorName(int sponsorId)
		{
			string sponsorNameConventionalString = this.GetSponsorNameConventionalString(sponsorId);
			return this.GetString(sponsorNameConventionalString);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x0004438C File Offset: 0x0004258C
		public string GetSponsorDescription(int sponsorId)
		{
			string sponsorDescrConventionalString = this.GetSponsorDescrConventionalString(sponsorId);
			return this.GetString(sponsorDescrConventionalString);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x000443A8 File Offset: 0x000425A8
		public void SetSponsorName(int sponsorId, string sponsorName)
		{
			string sponsorNameConventionalString = this.GetSponsorNameConventionalString(sponsorId);
			this.SetString(sponsorNameConventionalString, sponsorName);
		}

		// Token: 0x0600096D RID: 2413 RVA: 0x000443C8 File Offset: 0x000425C8
		public void SetSponsorDescription(int sponsorId, string sponsorDesc)
		{
			string sponsorDescrConventionalString = this.GetSponsorDescrConventionalString(sponsorId);
			this.SetString(sponsorDescrConventionalString, sponsorDesc);
		}

		// Token: 0x0600096E RID: 2414 RVA: 0x000443E8 File Offset: 0x000425E8
		public void RemoveSponsorName(int sponsorId)
		{
			string sponsorNameConventionalString = this.GetSponsorNameConventionalString(sponsorId);
			this.RemoveString(sponsorNameConventionalString);
		}

		// Token: 0x0600096F RID: 2415 RVA: 0x00044404 File Offset: 0x00042604
		public void RemoveSponsorDescription(int sponsorId)
		{
			string sponsorDescrConventionalString = this.GetSponsorDescrConventionalString(sponsorId);
			this.RemoveString(sponsorDescrConventionalString);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00044420 File Offset: 0x00042620
		public uint GetTeamHash(int teamId, Language.ETeamStringType stringType)
		{
			string teamConventionalString = this.GetTeamConventionalString(teamId, stringType);
			return FifaUtil.ComputeLanguageHash(teamConventionalString);
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x0004443C File Offset: 0x0004263C
		public string GetTeamConventionalString(int teamId, Language.ETeamStringType stringType)
		{
			string text;
			switch (stringType)
			{
			case Language.ETeamStringType.Full:
				text = "TeamName_";
				break;
			case Language.ETeamStringType.Abbr3:
				text = "TeamName_Abbr3_";
				break;
			case Language.ETeamStringType.Abbr10:
				text = "TeamName_Abbr10_";
				break;
			case Language.ETeamStringType.Abbr15:
				text = "TeamName_Abbr15_";
				break;
			default:
				return null;
			}
			return text + teamId.ToString();
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x00044494 File Offset: 0x00042694
		public string GetTeamString(int teamId, Language.ETeamStringType stringType)
		{
			string teamConventionalString = this.GetTeamConventionalString(teamId, stringType);
			return this.GetString(teamConventionalString);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000444B4 File Offset: 0x000426B4
		public void SetTeamString(int teamId, Language.ETeamStringType stringType, string teamName)
		{
			string teamConventionalString = this.GetTeamConventionalString(teamId, stringType);
			this.SetString(teamConventionalString, teamName);
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000444D4 File Offset: 0x000426D4
		public void RemoveTeamStrings(int teamId)
		{
			string text = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Abbr10);
			this.RemoveString(text);
			text = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Abbr15);
			this.RemoveString(text);
			text = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Abbr3);
			this.RemoveString(text);
			text = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Full);
			this.RemoveString(text);
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00044524 File Offset: 0x00042724
		public void RemoveTeamString(int teamId, Language.ETeamStringType stringType)
		{
			string teamConventionalString = this.GetTeamConventionalString(teamId, Language.ETeamStringType.Abbr10);
			this.RemoveString(teamConventionalString);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x00044544 File Offset: 0x00042744
		public string GetString(int key)
		{
			string text;
			if (base.TryGetValue(key, out text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00044560 File Offset: 0x00042760
		public string GetConventionalString(int key)
		{
			string text;
			if (this.m_Conventional.TryGetValue(key, out text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00044580 File Offset: 0x00042780
		public string GetString(string stringConventional)
		{
			int num = (int)FifaUtil.ComputeLanguageHash(stringConventional);
			string text;
			if (base.TryGetValue(num, out text))
			{
				return text;
			}
			return null;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x000445A4 File Offset: 0x000427A4
		public void SetString(string stringConventional, string stringValue)
		{
			int num = (int)FifaUtil.ComputeLanguageHash(stringConventional);
			this.SetString(num, stringConventional, stringValue);
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x000445C4 File Offset: 0x000427C4
		public void SetString(int key, string stringConventional, string stringValue)
		{
			if (base.ContainsKey(key))
			{
				base.Remove(key);
			}
			base.Add(key, stringValue);
			if (this.m_Conventional.ContainsKey(key))
			{
				this.m_Conventional.Remove(key);
			}
			this.m_Conventional.Add(key, stringConventional);
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x00044612 File Offset: 0x00042812
		public void RemoveString(int key)
		{
			if (base.ContainsKey(key))
			{
				base.Remove(key);
			}
			if (this.m_Conventional.ContainsKey(key))
			{
				this.m_Conventional.Remove(key);
			}
		}

		// Token: 0x0600097C RID: 2428 RVA: 0x00044640 File Offset: 0x00042840
		public void RemoveString(string stringConventional)
		{
			int num = (int)FifaUtil.ComputeLanguageHash(stringConventional);
			this.RemoveString(num);
		}

		// Token: 0x04000F26 RID: 3878
		private Dictionary<int, string> m_Conventional;

		// Token: 0x04000F27 RID: 3879
		private Table m_LangTable;

		// Token: 0x0200006D RID: 109
		public enum ETournamentStringType
		{
			// Token: 0x04000F29 RID: 3881
			Full,
			// Token: 0x04000F2A RID: 3882
			Abbr15
		}

		// Token: 0x0200006E RID: 110
		public enum ELeagueStringType
		{
			// Token: 0x04000F2C RID: 3884
			Full,
			// Token: 0x04000F2D RID: 3885
			Abbr15
		}

		// Token: 0x0200006F RID: 111
		public enum ETeamStringType
		{
			// Token: 0x04000F2F RID: 3887
			Full,
			// Token: 0x04000F30 RID: 3888
			Abbr3,
			// Token: 0x04000F31 RID: 3889
			Abbr10,
			// Token: 0x04000F32 RID: 3890
			Abbr15
		}
	}
}
