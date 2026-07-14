using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000069 RID: 105
	public class Country : IdObject
	{
		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x060008E7 RID: 2279 RVA: 0x00042F04 File Offset: 0x00041104
		// (set) Token: 0x060008E8 RID: 2280 RVA: 0x00042F0C File Offset: 0x0004110C
		public int ChantRegionIndex
		{
			get
			{
				return this.m_ChantRegionIndex;
			}
			set
			{
				this.m_ChantRegionIndex = value;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x060008E9 RID: 2281 RVA: 0x00042F15 File Offset: 0x00041115
		// (set) Token: 0x060008EA RID: 2282 RVA: 0x00042F1D File Offset: 0x0004111D
		public int PALanguageIndex
		{
			get
			{
				return this.m_PALanguageIndex;
			}
			set
			{
				this.m_PALanguageIndex = value;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x060008EB RID: 2283 RVA: 0x00042F26 File Offset: 0x00041126
		// (set) Token: 0x060008EC RID: 2284 RVA: 0x00042F2E File Offset: 0x0004112E
		public int CrowdBedsRegionIndex
		{
			get
			{
				return this.m_CrowdBedsRegionIndex;
			}
			set
			{
				this.m_CrowdBedsRegionIndex = value;
			}
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x060008ED RID: 2285 RVA: 0x00042F37 File Offset: 0x00041137
		// (set) Token: 0x060008EE RID: 2286 RVA: 0x00042F3F File Offset: 0x0004113F
		public int WhistlesRegionIndex
		{
			get
			{
				return this.m_WhistlesRegionIndex;
			}
			set
			{
				this.m_WhistlesRegionIndex = value;
			}
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060008EF RID: 2287 RVA: 0x00042F48 File Offset: 0x00041148
		// (set) Token: 0x060008F0 RID: 2288 RVA: 0x00042F50 File Offset: 0x00041150
		public int AmbienceRegionIndex
		{
			get
			{
				return this.m_AmbienceRegionIndex;
			}
			set
			{
				this.m_AmbienceRegionIndex = value;
			}
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060008F1 RID: 2289 RVA: 0x00042F59 File Offset: 0x00041159
		// (set) Token: 0x060008F2 RID: 2290 RVA: 0x00042F61 File Offset: 0x00041161
		public int HecklesRegionIndex
		{
			get
			{
				return this.m_HecklesRegionIndex;
			}
			set
			{
				this.m_HecklesRegionIndex = value;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060008F3 RID: 2291 RVA: 0x00042F6A File Offset: 0x0004116A
		// (set) Token: 0x060008F4 RID: 2292 RVA: 0x00042F72 File Offset: 0x00041172
		public int ReactionsRegionIndex
		{
			get
			{
				return this.m_ReactionsRegionIndex;
			}
			set
			{
				this.m_ReactionsRegionIndex = value;
			}
		}

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x060008F5 RID: 2293 RVA: 0x00042F7B File Offset: 0x0004117B
		// (set) Token: 0x060008F6 RID: 2294 RVA: 0x00042F83 File Offset: 0x00041183
		public int PlayerCallPatchBankIndex
		{
			get
			{
				return this.m_PlayerCallPatchBankIndex;
			}
			set
			{
				this.m_PlayerCallPatchBankIndex = value;
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060008F7 RID: 2295 RVA: 0x00042F8C File Offset: 0x0004118C
		// (set) Token: 0x060008F8 RID: 2296 RVA: 0x00042F94 File Offset: 0x00041194
		public int TeamCanWhistleIndex
		{
			get
			{
				return this.m_TeamCanWhistleIndex;
			}
			set
			{
				this.m_TeamCanWhistleIndex = value;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060008F9 RID: 2297 RVA: 0x00042F9D File Offset: 0x0004119D
		// (set) Token: 0x060008FA RID: 2298 RVA: 0x00042FA5 File Offset: 0x000411A5
		public string DatabaseName
		{
			get
			{
				return this.m_nationname;
			}
			set
			{
				this.m_nationname = value;
			}
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060008FB RID: 2299 RVA: 0x00042FAE File Offset: 0x000411AE
		// (set) Token: 0x060008FC RID: 2300 RVA: 0x00042FB6 File Offset: 0x000411B6
		public int Confederation
		{
			get
			{
				return this.m_confederation;
			}
			set
			{
				this.m_confederation = value;
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060008FD RID: 2301 RVA: 0x00042FBF File Offset: 0x000411BF
		// (set) Token: 0x060008FE RID: 2302 RVA: 0x00042FC7 File Offset: 0x000411C7
		public bool Top_tier
		{
			get
			{
				return this.m_top_tier;
			}
			set
			{
				this.m_top_tier = value;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060008FF RID: 2303 RVA: 0x00042FD0 File Offset: 0x000411D0
		// (set) Token: 0x06000900 RID: 2304 RVA: 0x00042FD8 File Offset: 0x000411D8
		public string DefaultCommLang
		{
			get
			{
				return this.m_DefaultCommLang;
			}
			set
			{
				this.m_DefaultCommLang = value;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000901 RID: 2305 RVA: 0x00042FE1 File Offset: 0x000411E1
		// (set) Token: 0x06000902 RID: 2306 RVA: 0x00042FE9 File Offset: 0x000411E9
		public string LanguageName
		{
			get
			{
				return this.m_LanguageName;
			}
			set
			{
				this.m_LanguageName = value;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000903 RID: 2307 RVA: 0x00042FF2 File Offset: 0x000411F2
		// (set) Token: 0x06000904 RID: 2308 RVA: 0x00042FFA File Offset: 0x000411FA
		public Team NationalTeam
		{
			get
			{
				return this.m_NationalTeam;
			}
			set
			{
				this.m_NationalTeam = value;
				if (this.m_NationalTeam != null)
				{
					this.m_NationalTeamId = this.m_NationalTeam.Id;
					return;
				}
				this.m_NationalTeamId = -1;
			}
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x06000905 RID: 2309 RVA: 0x00043024 File Offset: 0x00041224
		// (set) Token: 0x06000906 RID: 2310 RVA: 0x0004302C File Offset: 0x0004122C
		public int NationalTeamId
		{
			get
			{
				return this.m_NationalTeamId;
			}
			set
			{
				this.m_NationalTeamId = value;
			}
		}

		// Token: 0x06000907 RID: 2311 RVA: 0x00043038 File Offset: 0x00041238
		public Country(int countryid)
			: base(countryid)
		{
			this.m_nationname = "Country " + countryid.ToString();
			this.m_LanguageName = this.m_nationname;
			this.m_confederation = 0;
			this.m_top_tier = false;
			this.m_nationstartingfirstletter = 1;
			this.m_NationalTeamId = -1;
			this.m_NationalTeam = null;
			this.m_ChantRegionIndex = 1;
			this.m_PALanguageIndex = 0;
			this.m_CrowdBedsRegionIndex = 0;
			this.m_WhistlesRegionIndex = 0;
			this.m_AmbienceRegionIndex = 0;
			this.m_PlayerCallPatchBankIndex = 0;
			this.m_HecklesRegionIndex = 0;
			this.m_TeamCanWhistleIndex = 0;
			this.m_ReactionsRegionIndex = 0;
		}

		// Token: 0x06000908 RID: 2312 RVA: 0x000430D1 File Offset: 0x000412D1
		public Country(Record r)
			: base(r.IntField[FI.nations_nationid])
		{
			this.Load(r);
		}

		// Token: 0x06000909 RID: 2313 RVA: 0x000430EC File Offset: 0x000412EC
		public void Load(Record r)
		{
			this.m_nationname = r.StringField[FI.nations_nationname];
			this.m_confederation = r.GetAndCheckIntField(FI.nations_confederation) - 1;
			this.m_top_tier = r.GetAndCheckIntField(FI.nations_top_tier) != 0;
			this.m_nationstartingfirstletter = r.GetAndCheckIntField(FI.nations_nationstartingfirstletter);
			if (FifaEnvironment.Language != null)
			{
				this.m_LanguageName = FifaEnvironment.Language.GetCountryName(base.Id);
			}
			else
			{
				this.m_LanguageName = string.Empty;
			}
			if (this.m_LanguageName == null)
			{
				this.m_LanguageName = this.m_nationname;
			}
			this.m_NationalTeamId = r.GetAndCheckIntField(FI.nations_teamid);
		}

		// Token: 0x0600090A RID: 2314 RVA: 0x00043198 File Offset: 0x00041398
		public void FillFromAudionation(Record r)
		{
			this.m_ChantRegionIndex = r.GetAndCheckIntField(FI.audionation_ChantRegionIndex);
			this.m_PALanguageIndex = r.GetAndCheckIntField(FI.audionation_PALanguageIndex);
			this.m_DefaultCommLang = r.StringField[FI.audionation_DefaultCommLang];
			this.m_CrowdBedsRegionIndex = r.GetAndCheckIntField(FI.audionation_CrowdBedsRegionIndex);
			this.m_WhistlesRegionIndex = r.GetAndCheckIntField(FI.audionation_WhistlesRegionIndex);
			this.m_AmbienceRegionIndex = r.GetAndCheckIntField(FI.audionation_AmbienceRegionIndex);
			this.m_PlayerCallPatchBankIndex = r.GetAndCheckIntField(FI.audionation_PlayerCallPatchBankIndex);
			this.m_HecklesRegionIndex = r.GetAndCheckIntField(FI.audionation_HecklesRegionIndex);
			this.m_TeamCanWhistleIndex = r.GetAndCheckIntField(FI.audionation_TeamCanWhistleIndex);
			this.m_ReactionsRegionIndex = r.GetAndCheckIntField(FI.audionation_ReactionsRegionIndex);
		}

		// Token: 0x0600090B RID: 2315 RVA: 0x00043250 File Offset: 0x00041450
		public void SaveAudionation(Record r)
		{
			r.IntField[FI.audionation_nationid] = base.Id;
			r.IntField[FI.audionation_ChantRegionIndex] = this.m_ChantRegionIndex;
			r.StringField[FI.audionation_DefaultCommLang] = this.m_DefaultCommLang;
			r.IntField[FI.audionation_PALanguageIndex] = this.m_PALanguageIndex;
			r.IntField[FI.audionation_CrowdBedsRegionIndex] = this.m_CrowdBedsRegionIndex;
			r.IntField[FI.audionation_WhistlesRegionIndex] = this.m_WhistlesRegionIndex;
			r.IntField[FI.audionation_AmbienceRegionIndex] = this.m_AmbienceRegionIndex;
			r.IntField[FI.audionation_PlayerCallPatchBankIndex] = this.m_PlayerCallPatchBankIndex;
			r.IntField[FI.audionation_HecklesRegionIndex] = this.m_HecklesRegionIndex;
			r.IntField[FI.audionation_TeamCanWhistleIndex] = this.m_TeamCanWhistleIndex;
			r.IntField[FI.audionation_ReactionsRegionIndex] = this.m_ReactionsRegionIndex;
		}

		// Token: 0x0600090C RID: 2316 RVA: 0x00043323 File Offset: 0x00041523
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			this.m_NationalTeam = (Team)teamList.SearchId(this.m_NationalTeamId);
			Team nationalTeam = this.m_NationalTeam;
		}

		// Token: 0x0600090D RID: 2317 RVA: 0x00043348 File Offset: 0x00041548
		public void SetNationalTeam(Team nationalTeam, int nationalTeamId)
		{
			if (nationalTeam != null)
			{
				nationalTeamId = nationalTeam.Id;
			}
			if (nationalTeamId == -1)
			{
				nationalTeam = null;
			}
			Team nationalTeam2 = this.m_NationalTeam;
			if (nationalTeam2 != null)
			{
				nationalTeam2.UnsetAsNationalTeam(nationalTeamId);
			}
			this.m_NationalTeam = nationalTeam;
			this.m_NationalTeamId = nationalTeamId;
			if (this.m_NationalTeam != null)
			{
				this.m_NationalTeam.SetAsNationalTeam(this);
			}
		}

		// Token: 0x0600090E RID: 2318 RVA: 0x0004339C File Offset: 0x0004159C
		public void SaveCountry(Record r)
		{
			r.IntField[FI.nations_nationid] = base.Id;
			r.StringField[FI.nations_nationname] = this.m_nationname;
			r.IntField[FI.nations_confederation] = this.m_confederation + 1;
			r.IntField[FI.nations_top_tier] = (this.m_top_tier ? 1 : 0);
			r.IntField[FI.nations_nationstartingfirstletter] = this.m_nationstartingfirstletter;
			r.IntField[FI.nations_teamid] = this.m_NationalTeamId;
		}

		// Token: 0x0600090F RID: 2319 RVA: 0x0004341D File Offset: 0x0004161D
		public void SaveLangTable()
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetCountryName(base.Id, this.m_LanguageName);
			}
		}

		// Token: 0x06000910 RID: 2320 RVA: 0x0004343C File Offset: 0x0004163C
		public override string ToString()
		{
			if (this.m_LanguageName != null && this.m_LanguageName != string.Empty)
			{
				return this.m_LanguageName;
			}
			if (this.m_nationname != null)
			{
				return this.m_nationname;
			}
			return string.Empty;
		}

		// Token: 0x06000911 RID: 2321 RVA: 0x00043473 File Offset: 0x00041673
		public string DatabaseString()
		{
			return this.m_nationname;
		}

		// Token: 0x06000912 RID: 2322 RVA: 0x0004347B File Offset: 0x0004167B
		public string FlagBigFileName()
		{
			return Country.FlagBigFileName(base.Id);
		}

		// Token: 0x06000913 RID: 2323 RVA: 0x00043488 File Offset: 0x00041688
		public static string FlagTemplateBigFileName()
		{
			return "data/ui/artassets/countryflags/f_#.big";
		}

		// Token: 0x06000914 RID: 2324 RVA: 0x0004348F File Offset: 0x0004168F
		public static string FlagTemplateDdsName()
		{
			return "2";
		}

		// Token: 0x06000915 RID: 2325 RVA: 0x00043496 File Offset: 0x00041696
		public static string FlagBigFileName(int id)
		{
			return "data/ui/artassets/countryflags/f_" + id.ToString() + ".big";
		}

		// Token: 0x06000916 RID: 2326 RVA: 0x000434B0 File Offset: 0x000416B0
		public Bitmap GetFlag()
		{
			string text = Country.FlagBigFileName(base.Id);
			return FifaEnvironment.GetArtasset(text);
		}

		// Token: 0x06000917 RID: 2327 RVA: 0x000434CF File Offset: 0x000416CF
		public bool SetFlag(Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(Country.FlagTemplateBigFileName(), Country.FlagTemplateDdsName(), base.Id, bitmap);
		}

		// Token: 0x06000918 RID: 2328 RVA: 0x000434E8 File Offset: 0x000416E8
		public bool DeleteFlag()
		{
			return FifaEnvironment.DeleteFromZdata(this.FlagBigFileName());
		}

		// Token: 0x06000919 RID: 2329 RVA: 0x00043502 File Offset: 0x00041702
		public string MiniFlagBigFileName()
		{
			return Country.MiniFlagBigFileName(base.Id);
		}

		// Token: 0x0600091A RID: 2330 RVA: 0x0004350F File Offset: 0x0004170F
		public static string MiniFlagTemplateBigFileName()
		{
			return "data/ui/artassets/miniflags/flag_#.big";
		}

		// Token: 0x0600091B RID: 2331 RVA: 0x00043516 File Offset: 0x00041716
		public static string MiniFlagTemplateDdsName()
		{
			return "2";
		}

		// Token: 0x0600091C RID: 2332 RVA: 0x0004351D File Offset: 0x0004171D
		public static string MiniFlagBigFileName(int id)
		{
			return "data/ui/artassets/miniflags/flag_" + id.ToString() + ".big";
		}

		// Token: 0x0600091D RID: 2333 RVA: 0x00043538 File Offset: 0x00041738
		public Bitmap GetMiniFlag()
		{
			string text = Country.MiniFlagBigFileName(base.Id);
			return FifaEnvironment.GetArtasset(text);
		}

		// Token: 0x0600091E RID: 2334 RVA: 0x00043557 File Offset: 0x00041757
		public bool SetMiniFlag(Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(Country.MiniFlagTemplateBigFileName(), Country.MiniFlagTemplateDdsName(), base.Id, bitmap);
		}

		// Token: 0x0600091F RID: 2335 RVA: 0x0004356F File Offset: 0x0004176F
		public bool DeleteMiniFlag()
		{
			return FifaEnvironment.DeleteFromZdata(this.MiniFlagBigFileName());
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x0004357C File Offset: 0x0004177C
		public string CardFlagBigFileName()
		{
			return Country.CardFlagBigFileName(base.Id);
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00043589 File Offset: 0x00041789
		public static string CardFlagTemplateBigFileName()
		{
			return "data/ui/artassets/cardflags/#.big";
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00043590 File Offset: 0x00041790
		public static string CardFlagTemplateDdsName()
		{
			return "2";
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00043597 File Offset: 0x00041797
		public static string CardFlagBigFileName(int id)
		{
			return "data/ui/artassets/cardflags/" + id.ToString() + ".big";
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x000435B0 File Offset: 0x000417B0
		public Bitmap GetCardFlag()
		{
			string text = Country.CardFlagBigFileName(base.Id);
			return FifaEnvironment.GetArtasset(text);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x000435CF File Offset: 0x000417CF
		public bool SetCardFlag(Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(Country.CardFlagTemplateBigFileName(), Country.CardFlagTemplateDdsName(), base.Id, bitmap);
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x000435E7 File Offset: 0x000417E7
		public bool DeleteCardFlag()
		{
			return FifaEnvironment.DeleteFromZdata(this.CardFlagBigFileName());
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x000435F4 File Offset: 0x000417F4
		public bool Fit(string lowerName, int id)
		{
			return (this.m_nationname != null && this.m_nationname.ToLower() == lowerName) || (this.m_LanguageName != null && this.m_LanguageName.ToLower() == lowerName);
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0004362F File Offset: 0x0004182F
		public string ShapeFileName()
		{
			return Country.ShapeFileName(base.Id);
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0004363C File Offset: 0x0004183C
		public static string ShapeFileName(int countryid)
		{
			return "data/ui/imgassets/tiles/careerhub/countryshapes/c" + countryid.ToString() + ".dds";
		}

		// Token: 0x0600092A RID: 2346 RVA: 0x00043654 File Offset: 0x00041854
		public string ShapeTemplateFileName()
		{
			return "data/ui/imgassets/tiles/careerhub/countryshapes/c#.dds";
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x0004365B File Offset: 0x0004185B
		public Bitmap GetShape()
		{
			return FifaEnvironment.GetDdsArtasset(this.ShapeFileName());
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00043668 File Offset: 0x00041868
		public static Bitmap GetShape(int countryId)
		{
			return FifaEnvironment.GetDdsArtasset(Country.ShapeFileName(countryId));
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00043675 File Offset: 0x00041875
		public bool SetShape(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.ShapeTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x00043689 File Offset: 0x00041889
		public bool DeleteShape()
		{
			return FifaEnvironment.DeleteFromZdata(this.ShapeFileName());
		}

		// Token: 0x04000F0D RID: 3853
		private int m_ChantRegionIndex;

		// Token: 0x04000F0E RID: 3854
		private int m_PALanguageIndex;

		// Token: 0x04000F0F RID: 3855
		private int m_CrowdBedsRegionIndex;

		// Token: 0x04000F10 RID: 3856
		private int m_WhistlesRegionIndex;

		// Token: 0x04000F11 RID: 3857
		private int m_AmbienceRegionIndex;

		// Token: 0x04000F12 RID: 3858
		private int m_HecklesRegionIndex;

		// Token: 0x04000F13 RID: 3859
		private int m_ReactionsRegionIndex;

		// Token: 0x04000F14 RID: 3860
		private int m_PlayerCallPatchBankIndex;

		// Token: 0x04000F15 RID: 3861
		private int m_TeamCanWhistleIndex;

		// Token: 0x04000F16 RID: 3862
		private string m_nationname;

		// Token: 0x04000F17 RID: 3863
		public int m_confederation;

		// Token: 0x04000F18 RID: 3864
		public bool m_top_tier;

		// Token: 0x04000F19 RID: 3865
		private int m_nationstartingfirstletter;

		// Token: 0x04000F1A RID: 3866
		private string m_DefaultCommLang;

		// Token: 0x04000F1B RID: 3867
		private string m_LanguageName;

		// Token: 0x04000F1C RID: 3868
		private Team m_NationalTeam;

		// Token: 0x04000F1D RID: 3869
		private int m_NationalTeamId;

		// Token: 0x0200006A RID: 106
		public enum EConfederation
		{
			// Token: 0x04000F1F RID: 3871
			None = 1,
			// Token: 0x04000F20 RID: 3872
			Europe,
			// Token: 0x04000F21 RID: 3873
			Africa,
			// Token: 0x04000F22 RID: 3874
			South_America,
			// Token: 0x04000F23 RID: 3875
			Asia,
			// Token: 0x04000F24 RID: 3876
			Oceania,
			// Token: 0x04000F25 RID: 3877
			North_America
		}
	}
}
