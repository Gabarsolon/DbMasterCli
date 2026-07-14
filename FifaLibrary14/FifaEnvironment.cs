using System;
using System.Collections;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace FifaLibrary
{
	// Token: 0x0200000C RID: 12
	public class FifaEnvironment
	{
		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000788A File Offset: 0x00005A8A
		public static FifaFat FifaFat
		{
			get
			{
				return FifaEnvironment.m_FifaFat;
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000080 RID: 128 RVA: 0x00007891 File Offset: 0x00005A91
		public static CareerFile CareerFile
		{
			get
			{
				return FifaEnvironment.m_CareerFile;
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000081 RID: 129 RVA: 0x00007898 File Offset: 0x00005A98
		// (set) Token: 0x06000082 RID: 130 RVA: 0x0000789F File Offset: 0x00005A9F
		public static string CareerFileName
		{
			get
			{
				return FifaEnvironment.m_CareerFileName;
			}
			set
			{
				FifaEnvironment.m_CareerFileName = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000083 RID: 131 RVA: 0x000078A7 File Offset: 0x00005AA7
		public static CareerFile TournamentFile
		{
			get
			{
				return FifaEnvironment.m_TournamentFile;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000078AE File Offset: 0x00005AAE
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000078B5 File Offset: 0x00005AB5
		public static string TournamentFileName
		{
			get
			{
				return FifaEnvironment.m_TournamentFileName;
			}
			set
			{
				FifaEnvironment.m_TournamentFileName = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000078BD File Offset: 0x00005ABD
		public static CareerFile MyTeamsFile
		{
			get
			{
				return FifaEnvironment.m_MyTeamsFile;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000087 RID: 135 RVA: 0x000078C4 File Offset: 0x00005AC4
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000078CB File Offset: 0x00005ACB
		public static string MyTeamsFileName
		{
			get
			{
				return FifaEnvironment.m_MyTeamsFileName;
			}
			set
			{
				FifaEnvironment.m_MyTeamsFileName = value;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000089 RID: 137 RVA: 0x000078D3 File Offset: 0x00005AD3
		public static DbFile FifaDb
		{
			get
			{
				return FifaEnvironment.m_FifaDb;
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600008A RID: 138 RVA: 0x000078DA File Offset: 0x00005ADA
		// (set) Token: 0x0600008B RID: 139 RVA: 0x000078E1 File Offset: 0x00005AE1
		public static string FifaDbFileName
		{
			get
			{
				return FifaEnvironment.m_FifaDbFileName;
			}
			set
			{
				FifaEnvironment.m_FifaDbFileName = value;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600008C RID: 140 RVA: 0x000078E9 File Offset: 0x00005AE9
		// (set) Token: 0x0600008D RID: 141 RVA: 0x000078F0 File Offset: 0x00005AF0
		public static string FifaXmlFileName
		{
			get
			{
				return FifaEnvironment.m_FifaXmlFileName;
			}
			set
			{
				FifaEnvironment.m_FifaXmlFileName = value;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600008E RID: 142 RVA: 0x000078F8 File Offset: 0x00005AF8
		public static DbFile LangDb
		{
			get
			{
				return FifaEnvironment.m_LangDb;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000078FF File Offset: 0x00005AFF
		// (set) Token: 0x06000090 RID: 144 RVA: 0x00007906 File Offset: 0x00005B06
		public static string LangDbFileName
		{
			get
			{
				return FifaEnvironment.m_LangDbFileName;
			}
			set
			{
				FifaEnvironment.m_LangDbFileName = value;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000091 RID: 145 RVA: 0x0000790E File Offset: 0x00005B0E
		// (set) Token: 0x06000092 RID: 146 RVA: 0x00007915 File Offset: 0x00005B15
		public static string LangXmlFileName
		{
			get
			{
				return FifaEnvironment.m_LangXmlFileName;
			}
			set
			{
				FifaEnvironment.m_LangXmlFileName = value;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000093 RID: 147 RVA: 0x0000791D File Offset: 0x00005B1D
		public static Language Language
		{
			get
			{
				return FifaEnvironment.m_Language;
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000094 RID: 148 RVA: 0x00007924 File Offset: 0x00005B24
		public static string RootDir
		{
			get
			{
				return FifaEnvironment.m_RootDir;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000095 RID: 149 RVA: 0x0000792B File Offset: 0x00005B2B
		public static string ExportFolder
		{
			get
			{
				return FifaEnvironment.m_ExportFolder;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00007932 File Offset: 0x00005B32
		public static string TempFolder
		{
			get
			{
				return FifaEnvironment.m_TempFolder;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x06000097 RID: 151 RVA: 0x00007939 File Offset: 0x00005B39
		public static string LaunchDir
		{
			get
			{
				return FifaEnvironment.m_LaunchDir;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00007940 File Offset: 0x00005B40
		public static UserMessage UserMessages
		{
			get
			{
				return FifaEnvironment.m_UserMessages;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00007947 File Offset: 0x00005B47
		public static UserOptions UserOptions
		{
			get
			{
				return FifaEnvironment.m_UserOptions;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x0600009A RID: 154 RVA: 0x0000794E File Offset: 0x00005B4E
		public static CountryList Countries
		{
			get
			{
				return FifaEnvironment.s_CountryList;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00007955 File Offset: 0x00005B55
		public static LeagueList Leagues
		{
			get
			{
				return FifaEnvironment.s_LeagueList;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000795C File Offset: 0x00005B5C
		public static TeamList Teams
		{
			get
			{
				return FifaEnvironment.s_TeamList;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00007963 File Offset: 0x00005B63
		public static FreeAgentList FreeAgents
		{
			get
			{
				return FifaEnvironment.s_FreeAgentList;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009E RID: 158 RVA: 0x0000796A File Offset: 0x00005B6A
		public static PlayerList Players
		{
			get
			{
				return FifaEnvironment.s_PlayerList;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009F RID: 159 RVA: 0x00007971 File Offset: 0x00005B71
		public static PlayerNames PlayerNamesList
		{
			get
			{
				return FifaEnvironment.s_PlayerNamesList;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000A0 RID: 160 RVA: 0x00007978 File Offset: 0x00005B78
		public static NameDictionary NameDictionary
		{
			get
			{
				return FifaEnvironment.s_NameDictionary;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x0000797F File Offset: 0x00005B7F
		public static StadiumList Stadiums
		{
			get
			{
				return FifaEnvironment.s_StadiumList;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x00007986 File Offset: 0x00005B86
		public static RefereeList Referees
		{
			get
			{
				return FifaEnvironment.s_RefereeList;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x0000798D File Offset: 0x00005B8D
		public static KitList Kits
		{
			get
			{
				return FifaEnvironment.s_KitList;
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00007994 File Offset: 0x00005B94
		public static CompobjList CompetitionObjects
		{
			get
			{
				return FifaEnvironment.s_CompetitionObjects;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000A5 RID: 165 RVA: 0x0000799B File Offset: 0x00005B9B
		public static FormationList Formations
		{
			get
			{
				return FifaEnvironment.s_FormationList;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000A6 RID: 166 RVA: 0x000079A2 File Offset: 0x00005BA2
		public static FormationList GenericFormations
		{
			get
			{
				return FifaEnvironment.s_GenericFormationList;
			}
		}

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x060000A7 RID: 167 RVA: 0x000079A9 File Offset: 0x00005BA9
		public static RoleList Roles
		{
			get
			{
				return FifaEnvironment.s_RoleList;
			}
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000A8 RID: 168 RVA: 0x000079B0 File Offset: 0x00005BB0
		public static BallList Balls
		{
			get
			{
				if (FifaEnvironment.s_BallList == null)
				{
					FifaEnvironment.s_BallList = new BallList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_BallList;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000A9 RID: 169 RVA: 0x000079D2 File Offset: 0x00005BD2
		public static AdboardList Adboards
		{
			get
			{
				if (FifaEnvironment.s_AdboardList == null)
				{
					FifaEnvironment.s_AdboardList = new AdboardList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_AdboardList;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000AA RID: 170 RVA: 0x000079F4 File Offset: 0x00005BF4
		public static ShoesList Shoes
		{
			get
			{
				if (FifaEnvironment.s_ShoesList == null)
				{
					FifaEnvironment.s_ShoesList = new ShoesList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_ShoesList;
			}
		}

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x060000AB RID: 171 RVA: 0x00007A16 File Offset: 0x00005C16
		public static GkGlovesList GkGloves
		{
			get
			{
				if (FifaEnvironment.s_GkGlovesList == null)
				{
					FifaEnvironment.s_GkGlovesList = new GkGlovesList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_GkGlovesList;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x060000AC RID: 172 RVA: 0x00007A38 File Offset: 0x00005C38
		public static NetList Nets
		{
			get
			{
				if (FifaEnvironment.s_NetList == null)
				{
					FifaEnvironment.s_NetList = new NetList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_NetList;
			}
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00007A5A File Offset: 0x00005C5A
		public static MowingPatternList MowingPatterns
		{
			get
			{
				if (FifaEnvironment.s_MowingPatternList == null)
				{
					FifaEnvironment.s_MowingPatternList = new MowingPatternList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_MowingPatternList;
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00007A7C File Offset: 0x00005C7C
		public static NumberFontList NumberFonts
		{
			get
			{
				if (FifaEnvironment.s_NumberFontList == null)
				{
					FifaEnvironment.s_NumberFontList = new NumberFontList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_NumberFontList;
			}
		}

		// Token: 0x1700003D RID: 61
		// (get) Token: 0x060000AF RID: 175 RVA: 0x00007A9E File Offset: 0x00005C9E
		public static NameFontList NameFonts
		{
			get
			{
				if (FifaEnvironment.s_NameFontList == null)
				{
					FifaEnvironment.s_NameFontList = new NameFontList(FifaEnvironment.m_FifaDb, FifaEnvironment.m_FifaFat);
				}
				return FifaEnvironment.s_NameFontList;
			}
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x00007AC0 File Offset: 0x00005CC0
		public static bool Initialize(string rootDir)
		{
			if (FifaEnvironment.m_UserMessages == null)
			{
				FifaEnvironment.m_UserMessages = new UserMessage();
			}
			if (FifaEnvironment.m_UserOptions == null)
			{
				FifaEnvironment.m_UserOptions = new UserOptions();
			}
			FifaEnvironment.m_FifaFat = null;
			FifaEnvironment.m_FifaDb = null;
			FifaEnvironment.m_LangDb = null;
			int num = Environment.CommandLine.IndexOf(".exe");
			for (int i = num; i >= 0; i--)
			{
				if (Environment.CommandLine[i] == '\\')
				{
					num = i;
					break;
				}
			}
			if (num >= 0)
			{
				FifaEnvironment.m_LaunchDir = Environment.CommandLine.Substring(1, num - 1);
			}
			FifaEnvironment.m_Year = 14;
			FifaEnvironment.m_GameKey = RegistryInfo.GetFifaKey(FifaEnvironment.m_Year);
			if (rootDir == null)
			{
				if (!RegistryInfo.IsFifaInstalled(FifaEnvironment.m_GameKey))
				{
					return false;
				}
				FifaEnvironment.m_RootDir = RegistryInfo.GetInstallDir(FifaEnvironment.m_GameKey);
			}
			else
			{
				FifaEnvironment.m_RootDir = rootDir;
			}
			FifaEnvironment.m_FifaDbFileName = FifaEnvironment.m_RootDir + "\\Game\\data\\db\\fifa_ng_db.db";
			FifaEnvironment.m_FifaXmlFileName = FifaEnvironment.m_RootDir + "\\Game\\data\\db\\fifa_ng_db-meta.xml";
			FifaEnvironment.m_LangDbFileName = RegistryInfo.GetLanguageDbFilename(FifaEnvironment.m_GameKey);
			FifaEnvironment.m_LangXmlFileName = RegistryInfo.GetLanguageXmlFilename(FifaEnvironment.m_GameKey);
			if (FifaEnvironment.m_Year == 11)
			{
				FifaEnvironment.m_MiniHeadsBigFileName[0] = FifaEnvironment.m_RootDir + "\\Game\\data\\ui\\artAssets\\heads\\2dheads.big";
				FifaEnvironment.m_MiniHeadsBhFileName[0] = FifaEnvironment.m_RootDir + "\\Game\\data\\ui\\artAssets\\heads\\2dheads.bh";
			}
			else if (FifaEnvironment.m_Year == 12 || FifaEnvironment.m_Year == 13 || FifaEnvironment.m_Year == 14)
			{
				FifaEnvironment.m_MiniHeadsBigFileName[0] = FifaEnvironment.m_RootDir + "\\Game\\data\\ui\\imgAssets\\heads\\2dheads0.big";
				FifaEnvironment.m_MiniHeadsBhFileName[0] = FifaEnvironment.m_RootDir + "\\Game\\data\\ui\\imgAssets\\heads\\2dheads0.bh";
				FifaEnvironment.m_MiniHeadsBigFileName[1] = FifaEnvironment.m_RootDir + "\\Game\\data\\ui\\imgAssets\\heads\\2dheads1.big";
				FifaEnvironment.m_MiniHeadsBhFileName[1] = FifaEnvironment.m_RootDir + "\\Game\\data\\ui\\imgAssets\\heads\\2dheads1.bh";
				FifaEnvironment.m_MiniHeadsBigFileName[2] = FifaEnvironment.m_RootDir + "\\Game\\data\\ui\\imgAssets\\heads\\2dheads2.big";
				FifaEnvironment.m_MiniHeadsBhFileName[2] = FifaEnvironment.m_RootDir + "\\Game\\data\\ui\\imgAssets\\heads\\2dheads2.bh";
				FifaEnvironment.m_MiniHeadsBigFileName[3] = FifaEnvironment.m_RootDir + "\\Game\\data\\ui\\imgAssets\\heads\\2dheads3.big";
				FifaEnvironment.m_MiniHeadsBhFileName[3] = FifaEnvironment.m_RootDir + "\\Game\\data\\ui\\imgAssets\\heads\\2dheads3.bh";
			}
			FifaEnvironment.m_GameDir = FifaEnvironment.m_RootDir + "\\Game\\";
			FifaEnvironment.m_TempFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
			FifaEnvironment.m_TempFolder += "\\FM_temp";
			FifaEnvironment.m_ExportFolder = (FifaEnvironment.m_UserOptions.m_AutoExportFolder ? FifaEnvironment.m_TempFolder : FifaEnvironment.m_UserOptions.m_ExportFolder);
			if (!Directory.Exists(FifaEnvironment.m_TempFolder))
			{
				Directory.CreateDirectory(FifaEnvironment.m_TempFolder);
			}
			if (!Directory.Exists(FifaEnvironment.m_ExportFolder))
			{
				Directory.CreateDirectory(FifaEnvironment.m_TempFolder);
			}
			FifaEnvironment.s_NameFontList = null;
			FifaEnvironment.s_NumberFontList = null;
			FifaEnvironment.s_MowingPatternList = null;
			FifaEnvironment.s_NetList = null;
			FifaEnvironment.s_GkGlovesList = null;
			FifaEnvironment.s_ShoesList = null;
			FifaEnvironment.s_AdboardList = null;
			FifaEnvironment.s_BallList = null;
			FifaEnvironment.s_ShoesList = null;
			return true;
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x00007D8D File Offset: 0x00005F8D
		public static bool Initialize()
		{
			return FifaEnvironment.Initialize(null);
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x00007D98 File Offset: 0x00005F98
		public static void Close()
		{
			if (FifaEnvironment.s_AdboardList != null)
			{
				FifaEnvironment.s_AdboardList.Clear();
			}
			if (FifaEnvironment.s_BallList != null)
			{
				FifaEnvironment.s_BallList.Clear();
			}
			if (FifaEnvironment.s_ShoesList != null)
			{
				FifaEnvironment.s_ShoesList.Clear();
			}
			if (FifaEnvironment.s_CountryList != null)
			{
				FifaEnvironment.s_CountryList.Clear();
			}
			if (FifaEnvironment.s_FormationList != null)
			{
				FifaEnvironment.s_FormationList.Clear();
			}
			if (FifaEnvironment.s_GenericFormationList != null)
			{
				FifaEnvironment.s_GenericFormationList.Clear();
			}
			if (FifaEnvironment.s_FreeAgentList != null)
			{
				FifaEnvironment.s_FreeAgentList.Clear();
			}
			if (FifaEnvironment.s_NumberFontList != null)
			{
				FifaEnvironment.s_NumberFontList.Clear();
			}
			if (FifaEnvironment.s_NameFontList != null)
			{
				FifaEnvironment.s_NameFontList.Clear();
			}
			if (FifaEnvironment.s_KitList != null)
			{
				FifaEnvironment.s_KitList.Clear();
			}
			if (FifaEnvironment.s_LeagueList != null)
			{
				FifaEnvironment.s_LeagueList.Clear();
			}
			if (FifaEnvironment.s_NetList != null)
			{
				FifaEnvironment.s_NetList.Clear();
			}
			if (FifaEnvironment.s_MowingPatternList != null)
			{
				FifaEnvironment.s_MowingPatternList.Clear();
			}
			if (FifaEnvironment.s_PlayerList != null)
			{
				FifaEnvironment.s_PlayerList.Clear();
			}
			if (FifaEnvironment.s_PlayerNamesList != null)
			{
				FifaEnvironment.s_PlayerNamesList.Clear();
			}
			if (FifaEnvironment.s_NameDictionary != null)
			{
				FifaEnvironment.s_NameDictionary.Clear();
			}
			if (FifaEnvironment.s_RefereeList != null)
			{
				FifaEnvironment.s_RefereeList.Clear();
			}
			if (FifaEnvironment.s_RoleList != null)
			{
				FifaEnvironment.s_RoleList.Clear();
			}
			if (FifaEnvironment.s_ShoesList != null)
			{
				FifaEnvironment.s_ShoesList.Clear();
			}
			if (FifaEnvironment.s_GkGlovesList != null)
			{
				FifaEnvironment.s_GkGlovesList.Clear();
			}
			if (FifaEnvironment.s_StadiumList != null)
			{
				FifaEnvironment.s_StadiumList.Clear();
			}
			if (FifaEnvironment.s_TeamList != null)
			{
				FifaEnvironment.s_TeamList.Clear();
			}
			if (FifaEnvironment.s_CompetitionObjects != null)
			{
				FifaEnvironment.s_CompetitionObjects.Clear();
			}
			FifaEnvironment.m_FifaDb = null;
			FifaEnvironment.m_CareerFile = null;
			FifaEnvironment.m_FifaFat = null;
			FifaEnvironment.m_MiniHeadsBigFile = null;
			FifaEnvironment.m_LangDb = null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00007F4C File Offset: 0x0000614C
		public static bool Open(ToolStripStatusLabel statusBar)
		{
			FifaEnvironment.m_Status = statusBar;
			if (FifaEnvironment.m_FifaFat == null)
			{
				if (FifaEnvironment.m_Status != null)
				{
					FifaEnvironment.m_Status.Text = "Opening data#.big files";
					FifaEnvironment.m_Status.GetCurrentParent().Refresh();
				}
				if (!FifaEnvironment.OpenFat())
				{
					return false;
				}
			}
			if (FifaEnvironment.m_FifaDb == null)
			{
				if (FifaEnvironment.m_Status != null)
				{
					FifaEnvironment.m_Status.Text = "Opening main database";
					FifaEnvironment.m_Status.GetCurrentParent().Refresh();
				}
				FifaEnvironment.ExtractMainDatabase();
				if (!FifaEnvironment.OpenFifaDb())
				{
					return false;
				}
			}
			if (FifaEnvironment.m_LangDb == null)
			{
				if (FifaEnvironment.m_Status != null)
				{
					FifaEnvironment.m_Status.Text = "Opening language database";
					FifaEnvironment.m_Status.GetCurrentParent().Refresh();
				}
				FifaEnvironment.ExtractLangDatabase();
				if (!FifaEnvironment.OpenLangDb())
				{
					return false;
				}
			}
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Opening 2D heads files";
			}
			if (!FifaEnvironment.Open2DHeads())
			{
				return false;
			}
			FifaEnvironment.ExtractCompetitionFiles();
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Loading...";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.LoadLists();
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Ready";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			return true;
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x00008080 File Offset: 0x00006280
		public static bool Save(ToolStripStatusLabel statusBar)
		{
			FifaEnvironment.m_Status = statusBar;
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Saving lists";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.SaveLists();
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Saving main database";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.SaveFifaDb();
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Saving language";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.SaveLangDb();
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Saving big files";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.m_FifaFat.Save();
			if (FifaEnvironment.m_Status != null)
			{
				FifaEnvironment.m_Status.Text = "Saving gui files";
				FifaEnvironment.m_Status.GetCurrentParent().Refresh();
			}
			FifaEnvironment.SaveGui();
			return true;
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000816C File Offset: 0x0000636C
		public static bool OpenFat()
		{
			FifaEnvironment.m_FifaFat = null;
			FifaEnvironment.m_FifaFat = FifaFat.Create(FifaEnvironment.m_RootDir);
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10003);
				return false;
			}
			FifaEnvironment.m_FifaFat.SaveOption = FifaFat.EFifaFatSaveOption.SaveOnCommand;
			if (FifaEnvironment.m_UserOptions.m_SpecificZdata)
			{
				FifaEnvironment.m_FifaFat.SetDefaultDataBig(FifaEnvironment.m_UserOptions.m_ZdataNumber);
			}
			else
			{
				FifaEnvironment.m_FifaFat.ResetDefaultZdata();
			}
			return true;
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x000081E0 File Offset: 0x000063E0
		public static bool ExtractMainDatabase()
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return false;
			}
			string text = "data/db/fifa_ng_db.db";
			bool flag = false;
			while (FifaEnvironment.m_FifaFat.IsArchivedFilePresent(text))
			{
				if (!flag)
				{
					flag = FifaEnvironment.m_FifaFat.ExtractFile(text);
				}
				else
				{
					FifaEnvironment.m_FifaFat.HideFile(text);
				}
			}
			string text2 = "data/db/fifa_ng_db-meta.xml";
			bool flag2 = false;
			while (FifaEnvironment.m_FifaFat.IsArchivedFilePresent(text2))
			{
				if (!flag2)
				{
					flag2 = FifaEnvironment.m_FifaFat.ExtractFile(text2);
				}
				else
				{
					FifaEnvironment.m_FifaFat.HideFile(text2);
				}
			}
			return flag && flag2;
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x00008264 File Offset: 0x00006464
		public static bool ExtractLangDatabase()
		{
			string text = FifaEnvironment.m_RootDir + "\\Game\\data\\loc\\locale.big";
			string text2 = FifaEnvironment.m_RootDir + "\\Game";
			FifaBigFile fifaBigFile = new FifaBigFile(text);
			string[] archivedFileNames = fifaBigFile.GetArchivedFileNames("*.db", true);
			string[] archivedFileNames2 = fifaBigFile.GetArchivedFileNames("*.xml", true);
			bool flag = fifaBigFile.Export(archivedFileNames, text2);
			if (flag)
			{
				fifaBigFile.Delete(archivedFileNames);
			}
			bool flag2 = fifaBigFile.Export(archivedFileNames2, text2);
			if (flag2)
			{
				fifaBigFile.Delete(archivedFileNames2);
			}
			if (flag || flag2)
			{
				fifaBigFile.Save();
			}
			return flag || flag2;
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x000082F8 File Offset: 0x000064F8
		public static bool ExtractCompetitionFiles()
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return false;
			}
			string[] fileNames = CompobjList.GetFileNames();
			bool flag = false;
			for (int i = 0; i < fileNames.Length; i++)
			{
				string text = FifaEnvironment.m_RootDir + "\\Game\\" + fileNames[i];
				if (!File.Exists(text))
				{
					FifaEnvironment.m_FifaFat.ExtractFile(fileNames[i]);
					flag = true;
				}
				else
				{
					FifaEnvironment.m_FifaFat.HideFile(fileNames[i]);
				}
			}
			return flag;
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x00008360 File Offset: 0x00006560
		public static bool OpenFifaDb()
		{
			FifaEnvironment.m_FifaDb = null;
			if (FifaEnvironment.m_FifaDbFileName != null && FifaEnvironment.m_FifaXmlFileName != null && File.Exists(FifaEnvironment.m_FifaDbFileName) && File.Exists(FifaEnvironment.m_FifaXmlFileName))
			{
				FifaEnvironment.m_FifaDb = new DbFile(FifaEnvironment.m_FifaDbFileName, FifaEnvironment.m_FifaXmlFileName);
			}
			if (FifaEnvironment.m_FifaDb == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10000);
				return false;
			}
			if (FifaEnvironment.m_Year == 12)
			{
				TI.InitTIAsFIFA12(FifaEnvironment.m_FifaDb);
				FI.InitFIAsFIFA12();
			}
			if (FifaEnvironment.m_Year == 13)
			{
				TI.InitTIAsFIFA13(FifaEnvironment.m_FifaDb);
				FI.InitFIAsFIFA13();
			}
			if (FifaEnvironment.m_Year == 14)
			{
				TI.InitTIAsFIFA14(FifaEnvironment.m_FifaDb);
				FI.InitFI(FifaEnvironment.m_FifaDb);
			}
			return FifaEnvironment.m_FifaDb != null;
		}

		// Token: 0x060000BA RID: 186 RVA: 0x00008424 File Offset: 0x00006624
		public static bool OpenLangDb()
		{
			FifaEnvironment.m_LangDb = null;
			if (FifaEnvironment.m_LangDbFileName != null && FifaEnvironment.m_LangXmlFileName != null && File.Exists(FifaEnvironment.m_LangDbFileName) && File.Exists(FifaEnvironment.m_LangXmlFileName))
			{
				FifaEnvironment.m_LangDb = new DbFile(FifaEnvironment.m_LangDbFileName, FifaEnvironment.m_LangXmlFileName);
			}
			if (FifaEnvironment.m_LangDb != null)
			{
				FifaEnvironment.m_Language = new Language(FifaEnvironment.m_LangDb.Table[TI.lang]);
			}
			return FifaEnvironment.m_LangDb != null;
		}

		// Token: 0x060000BB RID: 187 RVA: 0x000084A0 File Offset: 0x000066A0
		public static bool Open2DHeads()
		{
			if (!File.Exists(FifaEnvironment.m_MiniHeadsBigFileName[0]))
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5000);
				return true;
			}
			FifaEnvironment.m_MiniHeadsBigFile[0] = new FifaBigFile(FifaEnvironment.m_MiniHeadsBigFileName[0]);
			FifaEnvironment.m_MiniHeadsBhFile[0] = new BhFile(FifaEnvironment.m_MiniHeadsBhFileName[0]);
			if (FifaEnvironment.m_Year >= 12)
			{
				FifaEnvironment.m_MiniHeadsBigFile[1] = new FifaBigFile(FifaEnvironment.m_MiniHeadsBigFileName[1]);
				FifaEnvironment.m_MiniHeadsBhFile[1] = new BhFile(FifaEnvironment.m_MiniHeadsBhFileName[1]);
				FifaEnvironment.m_MiniHeadsBigFile[2] = new FifaBigFile(FifaEnvironment.m_MiniHeadsBigFileName[2]);
				FifaEnvironment.m_MiniHeadsBhFile[2] = new BhFile(FifaEnvironment.m_MiniHeadsBhFileName[2]);
				FifaEnvironment.m_MiniHeadsBigFile[3] = new FifaBigFile(FifaEnvironment.m_MiniHeadsBigFileName[3]);
				FifaEnvironment.m_MiniHeadsBhFile[3] = new BhFile(FifaEnvironment.m_MiniHeadsBhFileName[3]);
			}
			return true;
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000856F File Offset: 0x0000676F
		public static void SaveFifaDb()
		{
			File.Copy(FifaEnvironment.m_FifaDbFileName, FifaEnvironment.m_FifaDbFileName + ".bak", true);
			FifaEnvironment.m_FifaDb.SaveDb(FifaEnvironment.m_FifaDbFileName);
			FifaEnvironment.m_FifaDb.SaveXml(FifaEnvironment.m_FifaXmlFileName);
		}

		// Token: 0x060000BD RID: 189 RVA: 0x000085AC File Offset: 0x000067AC
		public static void SaveLangDb()
		{
			File.Copy(FifaEnvironment.m_LangDbFileName, FifaEnvironment.m_LangDbFileName + ".bak", true);
			FifaEnvironment.m_Language.Save(FifaEnvironment.m_LangDb.Table[TI.lang]);
			FifaEnvironment.m_LangDb.SaveDb(FifaEnvironment.m_LangDbFileName);
		}

		// Token: 0x060000BE RID: 190 RVA: 0x00008600 File Offset: 0x00006800
		public static void SaveGui()
		{
			for (int i = 0; i < 4; i++)
			{
				if (FifaEnvironment.m_MiniHeadsBhFile[i] != null && FifaEnvironment.m_NeedToSaveMiniHeads)
				{
					FifaEnvironment.m_MiniHeadsBhFile[i].Save();
				}
			}
			FifaEnvironment.m_NeedToSaveMiniHeads = false;
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000863C File Offset: 0x0000683C
		public static Rx3File GetRx3FromZdata(string rx3FileName)
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return null;
			}
			Rx3File rx3File = null;
			FifaFile fifaFile = FifaEnvironment.m_FifaFat.GetArchivedFile(rx3FileName);
			if (fifaFile != null)
			{
				if (fifaFile.IsCompressed)
				{
					fifaFile.Decompress();
				}
				BinaryReader reader = fifaFile.GetReader();
				rx3File = new Rx3File();
				rx3File.Load(reader);
				fifaFile.ReleaseReader(reader);
			}
			else
			{
				string text = FifaEnvironment.m_RootDir + "\\Game\\" + rx3FileName;
				if (File.Exists(text))
				{
					fifaFile = new FifaFile(text, false);
					if (fifaFile != null)
					{
						rx3File = new Rx3File();
						rx3File.Load(fifaFile);
					}
				}
			}
			if (rx3File == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(3000, rx3FileName, true);
				return null;
			}
			return rx3File;
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x000086DC File Offset: 0x000068DC
		public static KitFile GetKitFromZdata(string rx3FileName)
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return null;
			}
			KitFile kitFile = null;
			FifaFile fifaFile = FifaEnvironment.m_FifaFat.GetArchivedFile(rx3FileName);
			if (fifaFile != null)
			{
				if (fifaFile.IsCompressed)
				{
					fifaFile.Decompress();
				}
				BinaryReader reader = fifaFile.GetReader();
				kitFile = new KitFile();
				kitFile.Load(reader);
				fifaFile.ReleaseReader(reader);
			}
			else
			{
				string text = FifaEnvironment.m_RootDir + "\\Game\\" + rx3FileName;
				if (File.Exists(text))
				{
					fifaFile = new FifaFile(text, false);
					if (fifaFile != null)
					{
						kitFile = new KitFile();
						kitFile.Load(fifaFile);
					}
				}
			}
			if (kitFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(3000, rx3FileName, true);
				return null;
			}
			return kitFile;
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000877C File Offset: 0x0000697C
		public static bool IsFilePresent(string fileName)
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return false;
			}
			bool flag = FifaEnvironment.m_FifaFat.IsArchivedFilePresent(fileName);
			if (flag)
			{
				return true;
			}
			string text = FifaEnvironment.m_RootDir + "\\Game\\" + fileName;
			return File.Exists(text);
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x000087C0 File Offset: 0x000069C0
		public static Bitmap GetBmpFromRx3(string rx3FileName, int imageIndex)
		{
			Rx3File rx3FromZdata = FifaEnvironment.GetRx3FromZdata(rx3FileName);
			if (rx3FromZdata == null)
			{
				return null;
			}
			if (rx3FromZdata.Images.Length > imageIndex && imageIndex >= 0)
			{
				return rx3FromZdata.Images[imageIndex].GetBitmap();
			}
			return null;
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x000087F8 File Offset: 0x000069F8
		public static Bitmap[] GetBmpsFromRx3(string rx3FileName)
		{
			Rx3File rx3FromZdata = FifaEnvironment.GetRx3FromZdata(rx3FileName);
			if (rx3FromZdata == null)
			{
				return null;
			}
			if (rx3FromZdata.Images != null && rx3FromZdata.Images.Length > 0)
			{
				return rx3FromZdata.GetBitmaps();
			}
			return null;
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000882C File Offset: 0x00006A2C
		public static Bitmap[] GetBitmapsFromRx3File(string rx3FileName)
		{
			if (rx3FileName == null)
			{
				return null;
			}
			if (!File.Exists(rx3FileName))
			{
				return null;
			}
			Rx3File rx3File = new Rx3File();
			if (!rx3File.Load(rx3FileName))
			{
				return null;
			}
			if (rx3File.Images.Length > 0)
			{
				return rx3File.GetBitmaps();
			}
			return null;
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x00008870 File Offset: 0x00006A70
		public static Bitmap[] GetKitFromRx3(string rx3FileName, out float[] positions)
		{
			KitFile kitFromZdata = FifaEnvironment.GetKitFromZdata(rx3FileName);
			if (kitFromZdata == null)
			{
				positions = null;
				return null;
			}
			positions = kitFromZdata.Positions;
			if (kitFromZdata.Images.Length > 0)
			{
				return kitFromZdata.GetBitmaps();
			}
			return null;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000088A8 File Offset: 0x00006AA8
		public static Bitmap GetBmpFromRx3(string rx3FileName)
		{
			Rx3File rx3FromZdata = FifaEnvironment.GetRx3FromZdata(rx3FileName);
			if (rx3FromZdata == null)
			{
				return null;
			}
			if (rx3FromZdata.Images.Length > 0)
			{
				return rx3FromZdata.Images[0].GetBitmap();
			}
			return null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000088DC File Offset: 0x00006ADC
		public static Bitmap GetArtasset(string bigFileName)
		{
			FifaBigFile bigFromZdata = FifaEnvironment.GetBigFromZdata(bigFileName);
			if (bigFromZdata == null)
			{
				return null;
			}
			FifaFile firstDds = bigFromZdata.GetFirstDds();
			if (firstDds == null)
			{
				return null;
			}
			DdsFile ddsFile = new DdsFile(firstDds);
			return ddsFile.GetBitmap();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00008910 File Offset: 0x00006B10
		public static Bitmap GetDdsArtasset(string ddsFileName)
		{
			FifaFile fileFromZdata = FifaEnvironment.GetFileFromZdata(ddsFileName);
			if (fileFromZdata == null)
			{
				return null;
			}
			DdsFile ddsFile = new DdsFile(fileFromZdata);
			if (fileFromZdata == null)
			{
				return null;
			}
			return ddsFile.GetBitmap();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000893C File Offset: 0x00006B3C
		public static Bitmap GetBitmapFromDdsFile(string ddsFileName)
		{
			if (ddsFileName == null)
			{
				return null;
			}
			if (!File.Exists(ddsFileName))
			{
				return null;
			}
			DdsFile ddsFile = new DdsFile(ddsFileName);
			return ddsFile.GetBitmap();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x00008968 File Offset: 0x00006B68
		public static Bitmap GetBitmapFromBigFile(string bigFileName)
		{
			if (bigFileName == null)
			{
				return null;
			}
			if (!File.Exists(bigFileName))
			{
				return null;
			}
			FifaBigFile fifaBigFile = new FifaBigFile(bigFileName);
			if (fifaBigFile == null)
			{
				return null;
			}
			FifaFile firstDds = fifaBigFile.GetFirstDds();
			if (firstDds == null)
			{
				return null;
			}
			DdsFile ddsFile = new DdsFile(firstDds);
			return ddsFile.GetBitmap();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000089AC File Offset: 0x00006BAC
		public static Bitmap Get2dHead(string ddsFileName)
		{
			FifaFile from2dHeads = FifaEnvironment.GetFrom2dHeads(ddsFileName);
			if (from2dHeads == null)
			{
				return null;
			}
			DdsFile ddsFile = new DdsFile(from2dHeads);
			return ddsFile.GetBitmap();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x000089D4 File Offset: 0x00006BD4
		private static FifaBigFile GetBigFromZdata(string bigFileName)
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return null;
			}
			FifaBigFile fifaBigFile = null;
			FifaFile archivedFile = FifaEnvironment.m_FifaFat.GetArchivedFile(bigFileName);
			if (archivedFile != null)
			{
				if (archivedFile.IsCompressed)
				{
					archivedFile.Decompress();
				}
				fifaBigFile = new FifaBigFile(archivedFile);
			}
			else
			{
				string text = FifaEnvironment.m_GameDir + bigFileName;
				if (File.Exists(text))
				{
					fifaBigFile = new FifaBigFile(text);
				}
			}
			if (fifaBigFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(3000, bigFileName, true);
				return null;
			}
			return fifaBigFile;
		}

		// Token: 0x060000CD RID: 205 RVA: 0x00008A48 File Offset: 0x00006C48
		private static FifaBigFile GetFrom2dHeads(string bigFileName)
		{
			FifaBigFile fifaBigFile = null;
			for (int i = 0; i < 4; i++)
			{
				if (FifaEnvironment.m_MiniHeadsBhFile[i] != null && FifaEnvironment.m_MiniHeadsBigFile[i] != null)
				{
					int archivedFileIndex = FifaEnvironment.m_MiniHeadsBhFile[i].GetArchivedFileIndex(bigFileName);
					if (archivedFileIndex >= 0)
					{
						FifaFile archivedFile = FifaEnvironment.m_MiniHeadsBigFile[i].GetArchivedFile(archivedFileIndex);
						if (archivedFile.IsCompressed)
						{
							archivedFile.Decompress();
						}
						fifaBigFile = new FifaBigFile(archivedFile);
						break;
					}
				}
			}
			if (fifaBigFile == null)
			{
				string text = FifaEnvironment.m_GameDir + bigFileName;
				if (File.Exists(text))
				{
					fifaBigFile = new FifaBigFile(text);
				}
			}
			if (fifaBigFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(3000, bigFileName, true);
				return null;
			}
			return fifaBigFile;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x00008AE8 File Offset: 0x00006CE8
		public static bool SetArtasset(string templateBigName, string ddsName, int id, Bitmap bitmap)
		{
			string text = FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, id, bitmap);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x00008B14 File Offset: 0x00006D14
		public static bool SetArtasset(string templateBigName, string ddsName, int[] ids, Bitmap bitmap)
		{
			string text = FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, ids, bitmap);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x00008B40 File Offset: 0x00006D40
		public static bool SetArtasset(string templateBigName, string ddsName, int[] ids, Bitmap bitmap, string[] format)
		{
			string text = FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, ids, bitmap, format);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x00008B6C File Offset: 0x00006D6C
		public static bool SetDdsArtasset(string templateDdsName, int id, Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			string text = FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, id, bitmap);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x00008B9C File Offset: 0x00006D9C
		public static bool SetDdsArtasset(string templateDdsName, int[] ids, Bitmap bitmap, string[] format)
		{
			string text = FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, ids, bitmap, format);
			if (text == null)
			{
				return false;
			}
			FifaEnvironment.m_FifaFat.HideFile(text);
			return true;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x00008BC8 File Offset: 0x00006DC8
		public static bool Set2dHead(string templateDdsName, int id, Bitmap bitmap)
		{
			string text = FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, id, bitmap);
			if (text == null)
			{
				return false;
			}
			for (int i = 0; i < 4; i++)
			{
				if (FifaEnvironment.m_MiniHeadsBhFile[i] != null && FifaEnvironment.m_MiniHeadsBhFile[i].Hide(text))
				{
					FifaEnvironment.m_NeedToSaveMiniHeads = true;
					break;
				}
			}
			return true;
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x00008C10 File Offset: 0x00006E10
		public static bool Delete2dHead(string fileName)
		{
			if (fileName == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10010);
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			string text = FifaEnvironment.m_GameDir + fileName;
			if (File.Exists(text))
			{
				File.Delete(text);
				for (int i = 0; i < 4; i++)
				{
					int archivedFileIndex = FifaEnvironment.m_MiniHeadsBigFile[i].GetArchivedFileIndex(fileName, true);
					if (archivedFileIndex >= 0)
					{
						FifaEnvironment.m_MiniHeadsBhFile[i].Restore(fileName, archivedFileIndex);
						break;
					}
				}
				return true;
			}
			for (int j = 0; j < 4; j++)
			{
				if (FifaEnvironment.m_MiniHeadsBhFile[j].Hide(fileName))
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x00008CD4 File Offset: 0x00006ED4
		private static string CreateAssetFromTemplate(string templateBigName, string ddsName, int id, Bitmap bitmap)
		{
			string text = null;
			Path.GetDirectoryName(templateBigName);
			string text2 = templateBigName.Replace("#", id.ToString(text));
			return FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, text2, bitmap);
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x00008D08 File Offset: 0x00006F08
		private static string CreateAssetFromTemplate(string templateBigName, string ddsName, int[] ids, Bitmap bitmap)
		{
			string text = null;
			Path.GetDirectoryName(templateBigName);
			string text2 = templateBigName.Replace("#", ids[0].ToString(text));
			text2 = text2.Replace("%", ids[1].ToString(text));
			return FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, text2, bitmap);
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x00008D5C File Offset: 0x00006F5C
		private static string CreateAssetFromTemplate(string templateBigName, string ddsName, int[] ids, Bitmap bitmap, string[] format)
		{
			Path.GetDirectoryName(templateBigName);
			string text = templateBigName.Replace("#", ids[0].ToString(format[0]));
			text = text.Replace("%", ids[1].ToString(format[1]));
			return FifaEnvironment.CreateAssetFromTemplate(templateBigName, ddsName, text, bitmap);
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x00008DB4 File Offset: 0x00006FB4
		private static string CreateAssetFromTemplate(string templateBigName, string ddsName, string newBigFileName, Bitmap bitmap)
		{
			string directoryName = Path.GetDirectoryName(templateBigName);
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\" + templateBigName;
			string text2 = FifaEnvironment.m_LaunchDir + "\\Templates\\" + newBigFileName;
			if (!File.Exists(text))
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5026);
				return null;
			}
			File.Copy(text, text2, true);
			FifaBigFile fifaBigFile = new FifaBigFile(text2);
			if (fifaBigFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			fifaBigFile.LoadArchivedFiles();
			FifaFile archivedFile = fifaBigFile.GetArchivedFile(ddsName, true);
			if (archivedFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			if (archivedFile.IsCompressed)
			{
				archivedFile.Decompress();
			}
			DdsFile ddsFile = new DdsFile(archivedFile);
			if (ddsFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			ddsFile.ReplaceBitmap(bitmap);
			BinaryWriter writer = archivedFile.GetWriter();
			if (writer == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			ddsFile.Save(writer);
			archivedFile.ReleaseWriter(writer);
			fifaBigFile.Save();
			string text3 = FifaEnvironment.m_GameDir + directoryName + "\\";
			string text4 = text3 + Path.GetFileName(newBigFileName);
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			File.Copy(text2, text4, true);
			if (!text2.Contains("#"))
			{
				File.Delete(text2);
			}
			return newBigFileName;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x00008F10 File Offset: 0x00007110
		private static string CreateDdsAssetFromTemplate(string templateDdsName, int id, Bitmap bitmap)
		{
			Path.GetDirectoryName(templateDdsName);
			string text = templateDdsName.Replace("#", id.ToString());
			return FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, text, bitmap);
		}

		// Token: 0x060000DA RID: 218 RVA: 0x00008F40 File Offset: 0x00007140
		private static string CreateDdsAssetFromTemplate(string templateDdsName, int id, Bitmap bitmap, string[] format)
		{
			int[] array = new int[2];
			array[0] = id;
			return FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, array, bitmap, format);
		}

		// Token: 0x060000DB RID: 219 RVA: 0x00008F64 File Offset: 0x00007164
		private static string CreateDdsAssetFromTemplate(string templateDdsName, int[] ids, Bitmap bitmap, string[] format)
		{
			Path.GetDirectoryName(templateDdsName);
			string text = templateDdsName.Replace("#", ids[0].ToString(format[0]));
			text = text.Replace("%", ids[1].ToString(format[1]));
			return FifaEnvironment.CreateDdsAssetFromTemplate(templateDdsName, text, bitmap);
		}

		// Token: 0x060000DC RID: 220 RVA: 0x00008FB8 File Offset: 0x000071B8
		private static string CreateDdsAssetFromTemplate(string templateDdsName, string newDdsFileName, Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return null;
			}
			string directoryName = Path.GetDirectoryName(templateDdsName);
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\" + templateDdsName;
			string text2 = FifaEnvironment.m_LaunchDir + "\\Templates\\" + newDdsFileName;
			if (!File.Exists(text))
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5026);
				return null;
			}
			File.Copy(text, text2, true);
			DdsFile ddsFile = new DdsFile(text2);
			if (ddsFile == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5027);
				return null;
			}
			ddsFile.ReplaceBitmap(bitmap);
			ddsFile.Save(text2);
			string text3 = FifaEnvironment.m_GameDir + directoryName + "\\";
			string text4 = text3 + Path.GetFileName(newDdsFileName);
			if (!Directory.Exists(text3))
			{
				Directory.CreateDirectory(text3);
			}
			File.Copy(text2, text4, true);
			if (!text2.Contains("#"))
			{
				File.Delete(text2);
			}
			return newDdsFileName;
		}

		// Token: 0x060000DD RID: 221 RVA: 0x00009090 File Offset: 0x00007290
		public static bool IsPatched(string fileName)
		{
			string text = FifaEnvironment.m_GameDir + fileName;
			return File.Exists(text);
		}

		// Token: 0x060000DE RID: 222 RVA: 0x000090B0 File Offset: 0x000072B0
		public static FifaFile GetFileFromZdata(string fileName)
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				return null;
			}
			FifaFile archivedFile = FifaEnvironment.m_FifaFat.GetArchivedFile(fileName);
			if (archivedFile != null)
			{
				return archivedFile;
			}
			string text = FifaEnvironment.m_RootDir + "\\Game\\" + fileName;
			if (File.Exists(text))
			{
				return new FifaFile(text, false);
			}
			return null;
		}

		// Token: 0x060000DF RID: 223 RVA: 0x000090FC File Offset: 0x000072FC
		public static bool ExportFileFromZdata(string fileName, string path)
		{
			if (FifaEnvironment.m_FifaFat == null || fileName == null)
			{
				return false;
			}
			bool flag = FifaEnvironment.m_FifaFat.ExportFile(fileName, path);
			if (flag)
			{
				return true;
			}
			string text = FifaEnvironment.m_RootDir + "\\Game\\" + fileName;
			string text2 = path + "\\" + fileName;
			if (File.Exists(text) && text != text2)
			{
				string directoryName = Path.GetDirectoryName(text2);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.Copy(text, text2, true);
				return true;
			}
			FifaEnvironment.m_UserMessages.ShowMessage(1028, " " + fileName, true);
			return flag;
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x00009194 File Offset: 0x00007394
		public static bool ExportTtfFromZdata(string fileName, string path)
		{
			if (FifaEnvironment.m_FifaFat == null || fileName == null)
			{
				return false;
			}
			string text = FifaEnvironment.m_RootDir + "\\Game\\" + fileName;
			string text2 = path + "\\" + fileName;
			if (File.Exists(text))
			{
				if (text != text2)
				{
					File.Copy(text, text2, true);
				}
				return true;
			}
			FifaEnvironment.m_UserMessages.ShowMessage(1028, " " + fileName, true);
			return false;
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x00009204 File Offset: 0x00007404
		public static bool AskAndExportFromZdata(string fileName, ref string path)
		{
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
			folderBrowserDialog.SelectedPath = path;
			folderBrowserDialog.Description = "Select the export folder";
			folderBrowserDialog.ShowNewFolderButton = true;
			if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
			{
				folderBrowserDialog.Dispose();
				return false;
			}
			path = folderBrowserDialog.SelectedPath;
			folderBrowserDialog.Dispose();
			return FifaEnvironment.ExportFileFromZdata(fileName, path);
		}

		// Token: 0x060000E2 RID: 226 RVA: 0x00009274 File Offset: 0x00007474
		public static bool ImportKitIntoZdata(string templateRx3Name, int[] ids, Bitmap[] bitmaps, float[] kitPositions)
		{
			if (templateRx3Name == null)
			{
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\" + templateRx3Name;
			string text2 = templateRx3Name;
			string text3 = text;
			if (ids.Length > 0)
			{
				text2 = text2.Replace("#", ids[0].ToString());
				text3 = text3.Replace("#", ids[0].ToString());
			}
			if (ids.Length > 1)
			{
				text2 = text2.Replace("%", ids[1].ToString());
				text3 = text3.Replace("%", ids[1].ToString());
			}
			if (text != text3)
			{
				File.Copy(text, text3, true);
			}
			KitFile kitFile = new KitFile();
			kitFile.Load(text3);
			if (kitFile.Images.Length != bitmaps.Length)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5025);
				return false;
			}
			kitFile.ReplaceBitmaps(bitmaps);
			kitFile.Positions = kitPositions;
			kitFile.Save(text3, true, false);
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(text3, text2, true, ECompressionMode.Chunkzip);
			if (!flag)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10007);
			}
			return flag;
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000093B8 File Offset: 0x000075B8
		public static bool ImportBmpsIntoStadium(string stadiumRx3Name, Bitmap[] bitmaps)
		{
			if (stadiumRx3Name == null)
			{
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			string text = FifaEnvironment.m_RootDir + "\\Game\\" + stadiumRx3Name;
			if (!File.Exists(text) && !FifaEnvironment.m_FifaFat.ExtractFile(stadiumRx3Name))
			{
				return false;
			}
			Rx3File rx3File = new Rx3File();
			rx3File.Load(text);
			if (rx3File.Images.Length != bitmaps.Length)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5025);
				return false;
			}
			rx3File.ReplaceBitmaps(bitmaps);
			rx3File.Save(text, true, false);
			return true;
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000946C File Offset: 0x0000766C
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int[] ids, Bitmap[] bitmaps, ECompressionMode compressionMode, Rx3Signatures signatures)
		{
			if (templateRx3Name == null)
			{
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			string text = FifaEnvironment.m_LaunchDir + "\\Templates\\" + templateRx3Name;
			string text2 = templateRx3Name;
			string text3 = text;
			if (ids.Length > 0)
			{
				text2 = text2.Replace("#", ids[0].ToString());
				text3 = text3.Replace("#", ids[0].ToString());
			}
			if (ids.Length > 1)
			{
				text2 = text2.Replace("%", ids[1].ToString());
				text3 = text3.Replace("%", ids[1].ToString());
			}
			if (text != text3)
			{
				File.Copy(text, text3, true);
			}
			Rx3File rx3File = new Rx3File();
			rx3File.Load(text3);
			if (rx3File.Images.Length != bitmaps.Length)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5025);
				return false;
			}
			rx3File.ReplaceBitmaps(bitmaps);
			rx3File.Signatures = signatures;
			rx3File.Save(text3, true, false);
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(text3, text2, true, compressionMode);
			if (!flag)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10007);
			}
			return flag;
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000095AF File Offset: 0x000077AF
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int[] ids, Bitmap[] bitmaps, ECompressionMode compressionMode)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, ids, bitmaps, compressionMode, null);
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000095BC File Offset: 0x000077BC
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int id, Bitmap bitmap, ECompressionMode compressionMode)
		{
			Bitmap[] array = new Bitmap[] { bitmap };
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, new int[] { id }, array, compressionMode, null);
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000095EC File Offset: 0x000077EC
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int id, Bitmap bitmap, ECompressionMode compressionMode, Rx3Signatures signatures)
		{
			Bitmap[] array = new Bitmap[] { bitmap };
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, new int[] { id }, array, compressionMode, signatures);
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000961C File Offset: 0x0000781C
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int id, Bitmap[] bitmaps, ECompressionMode compressionMode)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, new int[] { id }, bitmaps, compressionMode, null);
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00009640 File Offset: 0x00007840
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int id, Bitmap[] bitmaps, ECompressionMode compressionMode, Rx3Signatures signatures)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, new int[] { id }, bitmaps, compressionMode, signatures);
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00009664 File Offset: 0x00007864
		public static bool ImportBmpsIntoZdata(string templateRx3Name, int[] ids, Bitmap bitmap, ECompressionMode compressionMode)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(templateRx3Name, ids, new Bitmap[] { bitmap }, compressionMode, null);
		}

		// Token: 0x060000EB RID: 235 RVA: 0x00009686 File Offset: 0x00007886
		public static bool ImportFileIntoZdataAs(string fileName, string archivedName, bool delete, ECompressionMode compressionMode)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(fileName, archivedName, delete, compressionMode, null);
		}

		// Token: 0x060000EC RID: 236 RVA: 0x00009694 File Offset: 0x00007894
		public static bool ImportFileIntoZdataAs(string fileName, string archivedName, bool delete, ECompressionMode compressionMode, Rx3Signatures signatures)
		{
			delete = delete && !fileName.Contains("#");
			archivedName = archivedName.Replace('\\', '/');
			if (fileName == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10010);
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				if (delete)
				{
					File.Delete(fileName);
				}
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				if (delete)
				{
					File.Delete(fileName);
				}
				return false;
			}
			if (!File.Exists(fileName))
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10011);
				return false;
			}
			if (FifaEnvironment.m_UserOptions.m_SaveZdataInFolder)
			{
				string text = FifaEnvironment.m_RootDir + "\\Game\\" + archivedName;
				string directoryName = Path.GetDirectoryName(text);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.Copy(fileName, text, true);
				if (signatures != null)
				{
					FileStream fileStream = new FileStream(text, FileMode.Open, FileAccess.ReadWrite);
					BinaryWriter binaryWriter = new BinaryWriter(fileStream);
					signatures.Save(binaryWriter);
					binaryWriter.Close();
					fileStream.Close();
				}
				if (delete)
				{
					File.Delete(fileName);
				}
				FifaEnvironment.m_FifaFat.HideFile(archivedName);
				return true;
			}
			return FifaEnvironment.m_FifaFat.ImportFileAs(fileName, archivedName, delete, compressionMode);
		}

		// Token: 0x060000ED RID: 237 RVA: 0x000097C4 File Offset: 0x000079C4
		public static bool ImportTtfIntoZdataAs(string fileName, string archivedName, bool delete)
		{
			delete = delete && !fileName.Contains("#");
			archivedName = archivedName.Replace('\\', '/');
			if (fileName == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10010);
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				if (delete)
				{
					File.Delete(fileName);
				}
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				if (delete)
				{
					File.Delete(fileName);
				}
				return false;
			}
			if (!File.Exists(fileName))
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10011);
				return false;
			}
			if (FifaEnvironment.m_UserOptions.m_SaveZdataInFolder)
			{
				string text = FifaEnvironment.m_RootDir + "\\Game\\" + archivedName;
				string directoryName = Path.GetDirectoryName(text);
				if (!Directory.Exists(directoryName))
				{
					Directory.CreateDirectory(directoryName);
				}
				File.Copy(fileName, text, true);
				if (delete)
				{
					File.Delete(fileName);
				}
				FifaEnvironment.m_FifaFat.HideFile(archivedName);
				return true;
			}
			return false;
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000098C0 File Offset: 0x00007AC0
		public static bool DeleteFromZdata(string fileName)
		{
			if (fileName == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10010);
				return false;
			}
			if (!FifaEnvironment.m_UserOptions.m_SaveZdata)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(5035);
				return false;
			}
			if (FifaEnvironment.m_FifaFat == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10002);
				return false;
			}
			string text = FifaEnvironment.m_GameDir + fileName;
			if (File.Exists(text))
			{
				File.Delete(text);
				FifaEnvironment.m_FifaFat.RestoreFile(fileName);
				return true;
			}
			return FifaEnvironment.m_FifaFat.HideFile(fileName);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000994C File Offset: 0x00007B4C
		public static bool CloneIntoZdata(string srcFileName, string destFileName)
		{
			string text = FifaEnvironment.m_TempFolder + "\\";
			if (!FifaEnvironment.ExportFileFromZdata(srcFileName, FifaEnvironment.m_TempFolder))
			{
				return false;
			}
			string text2 = text + srcFileName;
			if (!File.Exists(text2))
			{
				return false;
			}
			ECompressionMode compressionMode = FifaEnvironment.m_FifaFat.GetCompressionMode(srcFileName);
			return FifaEnvironment.ImportFileIntoZdataAs(text2, destFileName, true, compressionMode);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x000099A8 File Offset: 0x00007BA8
		public static bool AskAndSaveBitmap(Bitmap bitmap)
		{
			if (bitmap == null)
			{
				return false;
			}
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Filter = "bmp files (*.bmp)|*.bmp|png files (*.png)|*.png";
			saveFileDialog.InitialDirectory = FifaEnvironment.m_ExportFolder;
			saveFileDialog.FilterIndex = 2;
			saveFileDialog.Title = "Save picture as .bmp or .png";
			if (saveFileDialog.ShowDialog() != DialogResult.OK)
			{
				saveFileDialog.Dispose();
				return false;
			}
			string extension = Path.GetExtension(saveFileDialog.FileName);
			ImageFormat imageFormat;
			if (extension.ToLower() == ".bmp")
			{
				imageFormat = ImageFormat.Bmp;
				Color pixel = bitmap.GetPixel(0, 0);
				for (int i = bitmap.Width - 1; i >= 0; i--)
				{
					for (int j = bitmap.Height - 1; j >= 0; j--)
					{
						if (bitmap.GetPixel(i, j).A < 192)
						{
							bitmap.SetPixel(i, j, pixel);
						}
					}
				}
			}
			else
			{
				if (!(extension.ToLower() == ".png"))
				{
					FifaEnvironment.m_UserMessages.ShowMessage(5034);
					return false;
				}
				imageFormat = ImageFormat.Png;
			}
			bitmap.Save(saveFileDialog.FileName, imageFormat);
			saveFileDialog.Dispose();
			return true;
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00009ABC File Offset: 0x00007CBC
		public static Bitmap BrowseAndCheckBitmap(int width, int height, int sizeMultiplier, int transparentMode)
		{
			DialogResult dialogResult = FifaEnvironment.m_UserMessages.ShowMessage(12);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return null;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.InitialDirectory = FifaEnvironment.m_ExportFolder;
			openFileDialog.RestoreDirectory = true;
			openFileDialog.Filter = "Image Files (*.bmp;*.png)|*.bmp;*.png";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = "Open Image File";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				openFileDialog.Dispose();
				return null;
			}
			string fileName = openFileDialog.FileName;
			openFileDialog.Dispose();
			Bitmap bitmap = new Bitmap(fileName);
			if (bitmap == null)
			{
				FifaEnvironment.m_UserMessages.ShowMessage(10006);
				return null;
			}
			if (bitmap.Width != width || bitmap.Height != height)
			{
				switch (sizeMultiplier)
				{
				case 1:
					width += width / 2;
					height += height / 2;
					break;
				case 2:
					width *= 2;
					height *= 2;
					break;
				}
				if (bitmap.Width != width || bitmap.Height != height)
				{
					FifaEnvironment.m_UserMessages.ShowMessage(5015);
					return null;
				}
			}
			if (transparentMode != 0)
			{
				string extension = Path.GetExtension(fileName);
				if (extension.ToLower() == ".bmp")
				{
					Bitmap bitmap2 = new Bitmap(bitmap.Width, bitmap.Height, PixelFormat.Format32bppArgb);
					Color pixel = bitmap.GetPixel(0, 0);
					Color color = Color.FromArgb(0, 0, 0, 0);
					for (int i = 0; i < bitmap.Width; i++)
					{
						for (int j = 0; j < bitmap.Height; j++)
						{
							Color pixel2 = bitmap.GetPixel(i, j);
							if (pixel2 == pixel)
							{
								bitmap2.SetPixel(i, j, color);
							}
							else
							{
								bitmap2.SetPixel(i, j, pixel2);
							}
						}
					}
					return bitmap2;
				}
			}
			return bitmap;
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00009C78 File Offset: 0x00007E78
		public static string BrowseAndCheckModel(ref string path, string title, string filter)
		{
			DialogResult dialogResult = FifaEnvironment.m_UserMessages.ShowMessage(12);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return null;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.InitialDirectory = path;
			openFileDialog.Filter = filter;
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = title;
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				openFileDialog.Dispose();
				return null;
			}
			string fileName = openFileDialog.FileName;
			path = Path.GetFullPath(fileName);
			openFileDialog.Dispose();
			return fileName;
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00009CF4 File Offset: 0x00007EF4
		public static string BrowseAndCheckTtf(ref string path)
		{
			DialogResult dialogResult = FifaEnvironment.m_UserMessages.ShowMessage(12);
			if (dialogResult == DialogResult.No || dialogResult == DialogResult.Cancel)
			{
				return null;
			}
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.CheckFileExists = true;
			openFileDialog.Multiselect = false;
			openFileDialog.InitialDirectory = path;
			openFileDialog.Filter = "Font files(*.ttf)|*.ttf";
			openFileDialog.FilterIndex = 1;
			openFileDialog.Title = "Open font file";
			if (openFileDialog.ShowDialog() != DialogResult.OK)
			{
				openFileDialog.Dispose();
				return null;
			}
			string fileName = openFileDialog.FileName;
			path = Path.GetFullPath(fileName);
			openFileDialog.Dispose();
			return fileName;
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00009D78 File Offset: 0x00007F78
		public static void LoadLists(EFifaObjects fifaObjects)
		{
			FifaFat fifaFat = FifaEnvironment.m_FifaFat;
			if (FifaEnvironment.m_FifaDb != null)
			{
				if ((fifaObjects & EFifaObjects.FifaRole) != (EFifaObjects)0)
				{
					FifaEnvironment.s_RoleList = new RoleList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaFormation) != (EFifaObjects)0)
				{
					FifaEnvironment.s_FormationList = new FormationList(FifaEnvironment.m_FifaDb);
					FifaEnvironment.s_GenericFormationList = new FormationList();
					foreach (object obj in FifaEnvironment.s_FormationList)
					{
						Formation formation = (Formation)obj;
						if (formation.IsGeneric())
						{
							FifaEnvironment.s_GenericFormationList.Add(formation);
						}
					}
				}
				if ((fifaObjects & EFifaObjects.FifaCountry) != (EFifaObjects)0)
				{
					FifaEnvironment.s_CountryList = new CountryList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaKit) != (EFifaObjects)0)
				{
					FifaEnvironment.s_KitList = new KitList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaReferee) != (EFifaObjects)0)
				{
					FifaEnvironment.s_RefereeList = new RefereeList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaLeague) != (EFifaObjects)0)
				{
					FifaEnvironment.s_LeagueList = new LeagueList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaTeam) != (EFifaObjects)0)
				{
					FifaEnvironment.s_TeamList = new TeamList(FifaEnvironment.m_FifaDb);
					FifaEnvironment.s_FreeAgentList = new FreeAgentList();
					FifaEnvironment.s_TeamList.LinkOpponent(FifaEnvironment.s_TeamList);
				}
				if (FifaEnvironment.s_RefereeList != null && FifaEnvironment.s_CountryList != null)
				{
					FifaEnvironment.s_RefereeList.LinkCountry(FifaEnvironment.s_CountryList);
				}
				if (FifaEnvironment.s_RefereeList != null && FifaEnvironment.s_LeagueList != null)
				{
					FifaEnvironment.s_RefereeList.LinkLeague(FifaEnvironment.s_LeagueList);
				}
				if (FifaEnvironment.s_KitList != null && FifaEnvironment.s_TeamList != null)
				{
					FifaEnvironment.s_TeamList.LinkKits(FifaEnvironment.s_KitList);
					FifaEnvironment.s_KitList.LinkTeam(FifaEnvironment.s_TeamList);
				}
				if (FifaEnvironment.s_LeagueList != null && FifaEnvironment.s_TeamList != null)
				{
					FifaEnvironment.s_LeagueList.FillFromLeagueTeamLinks(FifaEnvironment.m_FifaDb.Table[TI.leagueteamlinks]);
				}
				if (FifaEnvironment.s_LeagueList != null && FifaEnvironment.s_CountryList != null)
				{
					FifaEnvironment.s_LeagueList.LinkCountry(FifaEnvironment.s_CountryList);
				}
				if (FifaEnvironment.s_LeagueList != null && FifaEnvironment.s_BallList != null)
				{
					FifaEnvironment.s_LeagueList.LinkBall(FifaEnvironment.s_BallList);
				}
				if ((fifaObjects & EFifaObjects.FifaPlayer) != (EFifaObjects)0)
				{
					FifaEnvironment.s_PlayerNamesList = new PlayerNames(FifaEnvironment.m_FifaDb);
					Player.PlayerNames = FifaEnvironment.s_PlayerNamesList;
					FifaEnvironment.s_NameDictionary = new NameDictionary(FifaEnvironment.m_FifaDb);
					FifaEnvironment.s_PlayerList = new PlayerList(FifaEnvironment.m_FifaDb);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_PlayerList != null)
				{
					FifaEnvironment.s_TeamList.FillFromTeamPlayerLinks(FifaEnvironment.m_FifaDb);
					FifaEnvironment.s_TeamList.LinkPlayer(FifaEnvironment.s_PlayerList);
				}
				if (FifaEnvironment.s_PlayerList != null && FifaEnvironment.s_CountryList != null)
				{
					FifaEnvironment.s_PlayerList.LinkCountry(FifaEnvironment.s_CountryList);
				}
				if (FifaEnvironment.s_PlayerList != null && FifaEnvironment.s_TeamList != null)
				{
					FifaEnvironment.s_PlayerList.LinkTeam(FifaEnvironment.s_TeamList);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_CountryList != null)
				{
					FifaEnvironment.s_TeamList.LinkCountry(FifaEnvironment.s_CountryList);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_CountryList != null)
				{
					FifaEnvironment.s_CountryList.LinkTeam(FifaEnvironment.s_TeamList);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_FormationList != null)
				{
					FifaEnvironment.s_TeamList.LinkFormation(FifaEnvironment.s_FormationList);
					FifaEnvironment.s_FormationList.LinkTeam(FifaEnvironment.s_TeamList);
				}
				if ((fifaObjects & EFifaObjects.FifaStadium) != (EFifaObjects)0)
				{
					FifaEnvironment.s_StadiumList = new StadiumList(FifaEnvironment.m_FifaDb);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_StadiumList != null)
				{
					FifaEnvironment.s_TeamList.LinkStadiums(FifaEnvironment.s_StadiumList);
					FifaEnvironment.s_StadiumList.LinkTeam(FifaEnvironment.s_TeamList);
				}
				if (FifaEnvironment.s_CountryList != null && FifaEnvironment.s_StadiumList != null)
				{
					FifaEnvironment.s_StadiumList.LinkCountry(FifaEnvironment.s_CountryList);
				}
				if (FifaEnvironment.s_TeamList != null && FifaEnvironment.s_LeagueList != null)
				{
					FifaEnvironment.s_TeamList.LinkLeague(FifaEnvironment.s_LeagueList);
				}
				if ((fifaObjects & EFifaObjects.FifaTournament) != (EFifaObjects)0)
				{
					FifaEnvironment.s_CompetitionObjects = new CompobjList(FifaEnvironment.m_GameDir, FifaEnvironment.m_FifaDb);
				}
				if (FifaEnvironment.s_CompetitionObjects != null)
				{
					FifaEnvironment.s_CompetitionObjects.Link();
				}
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000A120 File Offset: 0x00008320
		public static void LoadLists()
		{
			EFifaObjects efifaObjects = EFifaObjects.FifaAdboard;
			efifaObjects |= EFifaObjects.FifaBall;
			efifaObjects |= EFifaObjects.FifaColor;
			efifaObjects |= EFifaObjects.FifaCountry;
			efifaObjects |= EFifaObjects.FifaFormation;
			efifaObjects |= EFifaObjects.FifaGrass;
			efifaObjects |= EFifaObjects.FifaJerseyFont;
			efifaObjects |= EFifaObjects.FifaKit;
			efifaObjects |= EFifaObjects.FifaLeague;
			efifaObjects |= EFifaObjects.FifaNet;
			efifaObjects |= EFifaObjects.FifaPlayer;
			efifaObjects |= EFifaObjects.FifaReferee;
			efifaObjects |= EFifaObjects.FifaRole;
			efifaObjects |= EFifaObjects.FifaShoes;
			efifaObjects |= EFifaObjects.FifaShortsFont;
			efifaObjects |= EFifaObjects.FifaSponsor;
			efifaObjects |= EFifaObjects.FifaStadium;
			efifaObjects |= EFifaObjects.FifaTeam;
			efifaObjects |= EFifaObjects.FifaTournament;
			efifaObjects |= EFifaObjects.FifaReward;
			efifaObjects |= EFifaObjects.FifaMowingPattern;
			efifaObjects |= EFifaObjects.FifaWeather;
			FifaEnvironment.LoadLists(efifaObjects);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000A1C8 File Offset: 0x000083C8
		public static void SaveLists()
		{
			if (FifaEnvironment.s_RoleList != null)
			{
				FifaEnvironment.s_RoleList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_FormationList != null)
			{
				FifaEnvironment.s_FormationList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_CountryList != null)
			{
				FifaEnvironment.s_CountryList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_KitList != null)
			{
				FifaEnvironment.s_KitList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_RefereeList != null)
			{
				FifaEnvironment.s_RefereeList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_LeagueList != null)
			{
				FifaEnvironment.s_LeagueList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_TeamList != null)
			{
				FifaEnvironment.s_TeamList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_PlayerList != null)
			{
				FifaEnvironment.s_PlayerNamesList.ClearUsedFlags();
				FifaEnvironment.s_PlayerList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_PlayerNamesList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_NameDictionary.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_StadiumList != null)
			{
				FifaEnvironment.s_StadiumList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_CompetitionObjects != null)
			{
				FifaEnvironment.s_CompetitionObjects.Save(FifaEnvironment.m_GameDir, FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_BallList != null)
			{
				FifaEnvironment.s_BallList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_ShoesList != null)
			{
				FifaEnvironment.s_ShoesList.Save(FifaEnvironment.m_FifaDb);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000A30C File Offset: 0x0000850C
		public static void SaveLists(EFifaObjects fifaObjects)
		{
			if (FifaEnvironment.s_RoleList != null && (fifaObjects & EFifaObjects.FifaRole) != (EFifaObjects)0)
			{
				FifaEnvironment.s_RoleList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_FormationList != null && (fifaObjects & EFifaObjects.FifaFormation) != (EFifaObjects)0)
			{
				FifaEnvironment.s_FormationList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_CountryList != null && (fifaObjects & EFifaObjects.FifaCountry) != (EFifaObjects)0)
			{
				FifaEnvironment.s_CountryList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_KitList != null && (fifaObjects & EFifaObjects.FifaKit) != (EFifaObjects)0)
			{
				FifaEnvironment.s_KitList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_RefereeList != null && (fifaObjects & EFifaObjects.FifaReferee) != (EFifaObjects)0)
			{
				FifaEnvironment.s_RefereeList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_LeagueList != null && (fifaObjects & EFifaObjects.FifaLeague) != (EFifaObjects)0)
			{
				FifaEnvironment.s_LeagueList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_TeamList != null && (fifaObjects & EFifaObjects.FifaTeam) != (EFifaObjects)0)
			{
				FifaEnvironment.s_TeamList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_PlayerList != null && (fifaObjects & EFifaObjects.FifaPlayer) != (EFifaObjects)0)
			{
				FifaEnvironment.s_PlayerNamesList.ClearUsedFlags();
				FifaEnvironment.s_PlayerList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_PlayerNamesList.Save(FifaEnvironment.m_FifaDb);
				FifaEnvironment.s_NameDictionary.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_StadiumList != null && (fifaObjects & EFifaObjects.FifaStadium) != (EFifaObjects)0)
			{
				FifaEnvironment.s_StadiumList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_CompetitionObjects != null && (fifaObjects & EFifaObjects.FifaTournament) != (EFifaObjects)0)
			{
				FifaEnvironment.s_CompetitionObjects.Save(FifaEnvironment.m_GameDir, FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_BallList != null && (fifaObjects & EFifaObjects.FifaBall) != (EFifaObjects)0)
			{
				FifaEnvironment.s_BallList.Save(FifaEnvironment.m_FifaDb);
			}
			if (FifaEnvironment.s_ShoesList != null && (fifaObjects & EFifaObjects.FifaShoes) != (EFifaObjects)0)
			{
				FifaEnvironment.s_ShoesList.Save(FifaEnvironment.m_FifaDb);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x0000A4A1 File Offset: 0x000086A1
		public static void SaveCareerLists()
		{
			if (FifaEnvironment.s_RoleList != null)
			{
				FifaEnvironment.s_RoleList.Save(FifaEnvironment.m_FifaDb);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x0000A4BC File Offset: 0x000086BC
		public static ArrayList FindMissedFiles()
		{
			ArrayList arrayList = new ArrayList();
			if (arrayList.Count == 0)
			{
				arrayList.Add("No missed files found.");
			}
			else
			{
				arrayList.Add(arrayList.Count.ToString() + " missed files found.");
			}
			return arrayList;
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0000A505 File Offset: 0x00008705
		public static void LoadCareerLists(EFifaObjects fifaObjects)
		{
			FifaFat fifaFat = FifaEnvironment.m_FifaFat;
			if (FifaEnvironment.m_CareerFile != null)
			{
				if ((fifaObjects & EFifaObjects.FifaRole) != (EFifaObjects)0)
				{
					FifaEnvironment.s_RoleList = new RoleList(FifaEnvironment.m_FifaDb);
				}
				if ((fifaObjects & EFifaObjects.FifaLeague) != (EFifaObjects)0)
				{
					FifaEnvironment.s_LeagueList = new LeagueList(FifaEnvironment.m_FifaDb);
				}
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x0000A540 File Offset: 0x00008740
		public static void ShowOptions()
		{
			DialogResult dialogResult = FifaEnvironment.m_UserOptions.ShowOptions();
			if (dialogResult == DialogResult.OK)
			{
				if (FifaEnvironment.m_UserOptions.m_AutoExportFolder)
				{
					FifaEnvironment.m_ExportFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
					return;
				}
				FifaEnvironment.m_ExportFolder = FifaEnvironment.m_UserOptions.m_ExportFolder;
			}
		}

		// Token: 0x0400004D RID: 77
		private static ToolStripStatusLabel m_Status = null;

		// Token: 0x0400004E RID: 78
		private static FifaFat m_FifaFat;

		// Token: 0x0400004F RID: 79
		private static CareerFile m_CareerFile;

		// Token: 0x04000050 RID: 80
		private static string m_CareerFileName;

		// Token: 0x04000051 RID: 81
		private static CareerFile m_TournamentFile;

		// Token: 0x04000052 RID: 82
		private static string m_TournamentFileName;

		// Token: 0x04000053 RID: 83
		private static CareerFile m_MyTeamsFile;

		// Token: 0x04000054 RID: 84
		private static string m_MyTeamsFileName;

		// Token: 0x04000055 RID: 85
		private static DbFile m_FifaDb;

		// Token: 0x04000056 RID: 86
		private static string m_FifaDbFileName;

		// Token: 0x04000057 RID: 87
		private static string m_FifaXmlFileName;

		// Token: 0x04000058 RID: 88
		private static int m_Year;

		// Token: 0x04000059 RID: 89
		private static string m_GameKey = null;

		// Token: 0x0400005A RID: 90
		private static DbFile m_LangDb;

		// Token: 0x0400005B RID: 91
		private static string m_LangDbFileName;

		// Token: 0x0400005C RID: 92
		private static string m_LangXmlFileName;

		// Token: 0x0400005D RID: 93
		private static Language m_Language = null;

		// Token: 0x0400005E RID: 94
		private static string m_RootDir;

		// Token: 0x0400005F RID: 95
		private static string m_GameDir;

		// Token: 0x04000060 RID: 96
		private static string m_ExportFolder;

		// Token: 0x04000061 RID: 97
		private static string m_TempFolder;

		// Token: 0x04000062 RID: 98
		private static string m_LaunchDir;

		// Token: 0x04000063 RID: 99
		private static UserMessage m_UserMessages;

		// Token: 0x04000064 RID: 100
		private static UserOptions m_UserOptions;

		// Token: 0x04000065 RID: 101
		private static FifaBigFile[] m_MiniHeadsBigFile = new FifaBigFile[4];

		// Token: 0x04000066 RID: 102
		private static BhFile[] m_MiniHeadsBhFile = new BhFile[4];

		// Token: 0x04000067 RID: 103
		private static string[] m_MiniHeadsBigFileName = new string[4];

		// Token: 0x04000068 RID: 104
		private static string[] m_MiniHeadsBhFileName = new string[4];

		// Token: 0x04000069 RID: 105
		private static bool m_NeedToSaveMiniHeads = false;

		// Token: 0x0400006A RID: 106
		private static CountryList s_CountryList = null;

		// Token: 0x0400006B RID: 107
		private static LeagueList s_LeagueList = null;

		// Token: 0x0400006C RID: 108
		private static TeamList s_TeamList = null;

		// Token: 0x0400006D RID: 109
		private static FreeAgentList s_FreeAgentList = null;

		// Token: 0x0400006E RID: 110
		private static PlayerList s_PlayerList = null;

		// Token: 0x0400006F RID: 111
		private static PlayerNames s_PlayerNamesList = null;

		// Token: 0x04000070 RID: 112
		private static NameDictionary s_NameDictionary = null;

		// Token: 0x04000071 RID: 113
		private static StadiumList s_StadiumList = null;

		// Token: 0x04000072 RID: 114
		private static RefereeList s_RefereeList = null;

		// Token: 0x04000073 RID: 115
		private static KitList s_KitList = null;

		// Token: 0x04000074 RID: 116
		private static CompobjList s_CompetitionObjects = null;

		// Token: 0x04000075 RID: 117
		private static FormationList s_FormationList = null;

		// Token: 0x04000076 RID: 118
		private static FormationList s_GenericFormationList = null;

		// Token: 0x04000077 RID: 119
		private static RoleList s_RoleList = null;

		// Token: 0x04000078 RID: 120
		private static BallList s_BallList = null;

		// Token: 0x04000079 RID: 121
		private static AdboardList s_AdboardList = null;

		// Token: 0x0400007A RID: 122
		private static ShoesList s_ShoesList = null;

		// Token: 0x0400007B RID: 123
		private static GkGlovesList s_GkGlovesList = null;

		// Token: 0x0400007C RID: 124
		private static NetList s_NetList = null;

		// Token: 0x0400007D RID: 125
		private static MowingPatternList s_MowingPatternList = null;

		// Token: 0x0400007E RID: 126
		private static NumberFontList s_NumberFontList = null;

		// Token: 0x0400007F RID: 127
		private static NameFontList s_NameFontList = null;
	}
}
