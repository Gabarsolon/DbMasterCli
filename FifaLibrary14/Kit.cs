using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200003B RID: 59
	public class Kit : IdObject
	{
		// Token: 0x1700014B RID: 331
		// (get) Token: 0x0600056C RID: 1388 RVA: 0x0001F179 File Offset: 0x0001D379
		// (set) Token: 0x0600056D RID: 1389 RVA: 0x0001F181 File Offset: 0x0001D381
		public float[] Positions
		{
			get
			{
				return this.m_Positions;
			}
			set
			{
				this.m_Positions = value;
			}
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x0600056E RID: 1390 RVA: 0x0001F18A File Offset: 0x0001D38A
		// (set) Token: 0x0600056F RID: 1391 RVA: 0x0001F192 File Offset: 0x0001D392
		public bool hasadvertisingkit
		{
			get
			{
				return this.m_hasadvertisingkit;
			}
			set
			{
				this.m_hasadvertisingkit = value;
			}
		}

		// Token: 0x1700014D RID: 333
		// (get) Token: 0x06000570 RID: 1392 RVA: 0x0001F19B File Offset: 0x0001D39B
		// (set) Token: 0x06000571 RID: 1393 RVA: 0x0001F1A3 File Offset: 0x0001D3A3
		public bool jerseyBackName
		{
			get
			{
				return this.m_jerseybacknameplacementcode;
			}
			set
			{
				this.m_jerseybacknameplacementcode = value;
			}
		}

		// Token: 0x1700014E RID: 334
		// (get) Token: 0x06000572 RID: 1394 RVA: 0x0001F1AC File Offset: 0x0001D3AC
		// (set) Token: 0x06000573 RID: 1395 RVA: 0x0001F1B4 File Offset: 0x0001D3B4
		public bool jerseyFrontNumber
		{
			get
			{
				return this.m_jerseyfrontnumberplacementcode;
			}
			set
			{
				this.m_jerseyfrontnumberplacementcode = value;
			}
		}

		// Token: 0x1700014F RID: 335
		// (get) Token: 0x06000574 RID: 1396 RVA: 0x0001F1BD File Offset: 0x0001D3BD
		// (set) Token: 0x06000575 RID: 1397 RVA: 0x0001F1C5 File Offset: 0x0001D3C5
		public bool shortsNumber
		{
			get
			{
				return this.m_shortsnumberplacementcode;
			}
			set
			{
				this.m_shortsnumberplacementcode = value;
			}
		}

		// Token: 0x17000150 RID: 336
		// (get) Token: 0x06000576 RID: 1398 RVA: 0x0001F1CE File Offset: 0x0001D3CE
		// (set) Token: 0x06000577 RID: 1399 RVA: 0x0001F1D6 File Offset: 0x0001D3D6
		public int jerseyCollar
		{
			get
			{
				return this.m_jerseycollargeometrytype;
			}
			set
			{
				this.m_jerseycollargeometrytype = value;
			}
		}

		// Token: 0x17000151 RID: 337
		// (get) Token: 0x06000578 RID: 1400 RVA: 0x0001F1DF File Offset: 0x0001D3DF
		// (set) Token: 0x06000579 RID: 1401 RVA: 0x0001F1E7 File Offset: 0x0001D3E7
		public int jerseyNameFontCase
		{
			get
			{
				return this.m_jerseybacknamefontcase;
			}
			set
			{
				this.m_jerseybacknamefontcase = value;
			}
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x0600057A RID: 1402 RVA: 0x0001F1F0 File Offset: 0x0001D3F0
		// (set) Token: 0x0600057B RID: 1403 RVA: 0x0001F1F8 File Offset: 0x0001D3F8
		public int jerseyNameFont
		{
			get
			{
				return this.m_jerseynamefonttype;
			}
			set
			{
				this.m_jerseynamefonttype = value;
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x0600057C RID: 1404 RVA: 0x0001F201 File Offset: 0x0001D401
		// (set) Token: 0x0600057D RID: 1405 RVA: 0x0001F209 File Offset: 0x0001D409
		public int jerseyNumberFont
		{
			get
			{
				return this.m_numberfonttype;
			}
			set
			{
				this.m_numberfonttype = value;
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x0600057E RID: 1406 RVA: 0x0001F212 File Offset: 0x0001D412
		// (set) Token: 0x0600057F RID: 1407 RVA: 0x0001F21A File Offset: 0x0001D41A
		public int jerseyNumberColor
		{
			get
			{
				return this.m_numbercolor;
			}
			set
			{
				this.m_numbercolor = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000580 RID: 1408 RVA: 0x0001F223 File Offset: 0x0001D423
		// (set) Token: 0x06000581 RID: 1409 RVA: 0x0001F22B File Offset: 0x0001D42B
		public int shortsNumberFont
		{
			get
			{
				return this.m_shortsnumberfonttype;
			}
			set
			{
				this.m_shortsnumberfonttype = value;
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000582 RID: 1410 RVA: 0x0001F234 File Offset: 0x0001D434
		// (set) Token: 0x06000583 RID: 1411 RVA: 0x0001F23C File Offset: 0x0001D43C
		public int shortsNumberColor
		{
			get
			{
				return this.m_shortsnumbercolor;
			}
			set
			{
				this.m_shortsnumbercolor = value;
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000584 RID: 1412 RVA: 0x0001F245 File Offset: 0x0001D445
		// (set) Token: 0x06000585 RID: 1413 RVA: 0x0001F24D File Offset: 0x0001D44D
		public Color JerseyNameColor
		{
			get
			{
				return this.m_JerseyNameColor;
			}
			set
			{
				this.m_JerseyNameColor = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000586 RID: 1414 RVA: 0x0001F256 File Offset: 0x0001D456
		// (set) Token: 0x06000587 RID: 1415 RVA: 0x0001F25E File Offset: 0x0001D45E
		public Color TeamColor1
		{
			get
			{
				return this.m_TeamColor1;
			}
			set
			{
				this.m_TeamColor1 = value;
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000588 RID: 1416 RVA: 0x0001F267 File Offset: 0x0001D467
		// (set) Token: 0x06000589 RID: 1417 RVA: 0x0001F26F File Offset: 0x0001D46F
		public Color TeamColor2
		{
			get
			{
				return this.m_TeamColor2;
			}
			set
			{
				this.m_TeamColor2 = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x0600058A RID: 1418 RVA: 0x0001F278 File Offset: 0x0001D478
		// (set) Token: 0x0600058B RID: 1419 RVA: 0x0001F280 File Offset: 0x0001D480
		public Color TeamColor3
		{
			get
			{
				return this.m_TeamColor3;
			}
			set
			{
				this.m_TeamColor3 = value;
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x0600058C RID: 1420 RVA: 0x0001F289 File Offset: 0x0001D489
		// (set) Token: 0x0600058D RID: 1421 RVA: 0x0001F291 File Offset: 0x0001D491
		public int jerseyNameLayout
		{
			get
			{
				return this.m_jerseynamelayouttype;
			}
			set
			{
				this.m_jerseynamelayouttype = value;
			}
		}

		// Token: 0x1700015C RID: 348
		// (get) Token: 0x0600058E RID: 1422 RVA: 0x0001F29A File Offset: 0x0001D49A
		// (set) Token: 0x0600058F RID: 1423 RVA: 0x0001F2A2 File Offset: 0x0001D4A2
		public int year
		{
			get
			{
				return this.m_year;
			}
			set
			{
				this.m_year = value;
			}
		}

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x06000590 RID: 1424 RVA: 0x0001F2AB File Offset: 0x0001D4AB
		// (set) Token: 0x06000591 RID: 1425 RVA: 0x0001F2B3 File Offset: 0x0001D4B3
		public int teamid
		{
			get
			{
				return this.m_teamid;
			}
			set
			{
				this.m_teamid = value;
			}
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000592 RID: 1426 RVA: 0x0001F2BC File Offset: 0x0001D4BC
		// (set) Token: 0x06000593 RID: 1427 RVA: 0x0001F2C4 File Offset: 0x0001D4C4
		public int kittype
		{
			get
			{
				return this.m_kittype;
			}
			set
			{
				this.m_kittype = value;
			}
		}

		// Token: 0x1700015F RID: 351
		// (get) Token: 0x06000594 RID: 1428 RVA: 0x0001F2CD File Offset: 0x0001D4CD
		// (set) Token: 0x06000595 RID: 1429 RVA: 0x0001F2D5 File Offset: 0x0001D4D5
		public Team Team
		{
			get
			{
				return this.m_Team;
			}
			set
			{
				this.m_Team = value;
				if (this.m_Team != null)
				{
					this.m_teamid = this.Team.Id;
				}
			}
		}

		// Token: 0x06000596 RID: 1430 RVA: 0x0001F2F7 File Offset: 0x0001D4F7
		public Kit(int kitid, int teamid, int kittype)
		{
			this.m_teamid = teamid;
			this.m_kittype = kittype;
			base.Id = kitid;
			this.InitNewKit();
		}

		// Token: 0x06000597 RID: 1431 RVA: 0x0001F327 File Offset: 0x0001D527
		public Kit(int kitid)
		{
			this.m_teamid = 0;
			this.m_kittype = 0;
			base.Id = kitid;
			this.InitNewKit();
		}

		// Token: 0x06000598 RID: 1432 RVA: 0x0001F357 File Offset: 0x0001D557
		public Kit(Record r)
		{
			this.Load(r);
		}

		// Token: 0x06000599 RID: 1433 RVA: 0x0001F374 File Offset: 0x0001D574
		public static void Prepare3DModels()
		{
			Kit.s_JerseyWrinkle = new Bitmap(FifaEnvironment.LaunchDir + "\\Templates\\JerseyBump0.png");
			Kit.s_ShortsWrinkle = new Bitmap(FifaEnvironment.LaunchDir + "\\Templates\\ShortsBump.png");
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
			Rx3File rx3File;
			for (int i = 0; i < Kit.s_JerseyModel3D.Length; i++)
			{
				rx3File = new Rx3File();
				string text = FifaEnvironment.LaunchDir + "\\Templates\\data\\sceneassets\\body\\jersey_1_" + i.ToString() + "_0_1_0_0.rx3";
				rx3File.Load(text);
				Kit.s_JerseyModel3D[i] = new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], null);
			}
			rx3File = new Rx3File();
			rx3File.Load(FifaEnvironment.LaunchDir + "\\Templates\\data\\sceneassets\\body\\shorts_1_0.rx3");
			Kit.s_ShortsModel3D = new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], null);
			rx3File = new Rx3File();
			rx3File.Load(FifaEnvironment.LaunchDir + "\\Templates\\data\\sceneassets\\body\\sock_1_0.rx3");
			Kit.s_SocksModel3D = new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], null);
		}

		// Token: 0x0600059A RID: 1434 RVA: 0x0001F480 File Offset: 0x0001D680
		public override string ToString()
		{
			string text;
			if (this.m_Team != null)
			{
				text = this.m_Team.DatabaseName;
			}
			else
			{
				text = "Kit " + this.m_teamid.ToString();
			}
			string text2 = string.Empty;
			switch (this.m_kittype)
			{
			case 0:
				text2 = " Home";
				goto IL_00AF;
			case 1:
				text2 = " Away";
				goto IL_00AF;
			case 2:
				text2 = " GK";
				goto IL_00AF;
			case 3:
				text2 = " Third";
				goto IL_00AF;
			case 5:
				text2 = " Referee";
				goto IL_00AF;
			case 6:
				text2 = " Training";
				goto IL_00AF;
			case 7:
				text2 = " Training";
				goto IL_00AF;
			}
			text2 = " Type" + this.m_kittype.ToString();
			IL_00AF:
			return string.Concat(new string[]
			{
				text,
				text2,
				" (",
				base.Id.ToString(),
				")"
			});
		}

		// Token: 0x0600059B RID: 1435 RVA: 0x0001F575 File Offset: 0x0001D775
		public static int KitId(int teamid, int kittype)
		{
			return teamid * 10 + kittype;
		}

		// Token: 0x0600059C RID: 1436 RVA: 0x0001F580 File Offset: 0x0001D780
		public void InitNewKit()
		{
			this.m_hasadvertisingkit = true;
			this.m_jerseybacknameplacementcode = true;
			this.m_jerseyfrontnumberplacementcode = false;
			this.m_shortsnumberplacementcode = false;
			this.m_jerseycollargeometrytype = 0;
			this.m_jerseybacknamefontcase = 0;
			this.m_jerseynamefonttype = 0;
			this.m_numberfonttype = 0;
			this.m_numbercolor = 0;
			this.m_shortsnumberfonttype = 0;
			this.m_shortsnumbercolor = 0;
			this.m_jerseynamecolorr = 0;
			this.m_jerseynamecolorg = 0;
			this.m_jerseynamecolorb = 0;
			this.m_teamcolorprimr = 0;
			this.m_teamcolorprimg = 0;
			this.m_teamcolorprimb = 0;
			this.m_teamcolorsecr = 0;
			this.m_teamcolorsecg = 0;
			this.m_teamcolorsecb = 0;
			this.m_teamcolortertr = 0;
			this.m_teamcolortertg = 0;
			this.m_teamcolortertb = 0;
			this.m_isinheritbasedetailmap = 0;
			this.m_jerseyshapestyle = 0;
			this.m_jerseynamelayouttype = 0;
			this.m_jerseyrenderingdetailmaptype = 0;
			this.m_renderingmaterialtype = 0;
			this.m_shortsrenderingdetailmaptype = 0;
			this.m_dlc = 0;
			this.m_year = 0;
			this.m_powid = -1;
			this.m_islocked = 0;
		}

		// Token: 0x0600059D RID: 1437 RVA: 0x0001F674 File Offset: 0x0001D874
		public bool CloneTextures(Kit clone)
		{
			if (clone != null)
			{
				clone.m_KitTextures = null;
				FifaEnvironment.CloneIntoZdata(this.KitTextureFileName(), Kit.KitTextureFileName(clone.teamid, clone.kittype, 0));
				FifaEnvironment.CloneIntoZdata(this.MiniKitDdsFileName(), Kit.MiniKitDdsFileName(clone.teamid, clone.kittype, 0));
				return true;
			}
			return false;
		}

		// Token: 0x0600059E RID: 1438 RVA: 0x0001F6CC File Offset: 0x0001D8CC
		public void Load(Record r)
		{
			base.Id = r.IntField[FI.teamkits_teamkitid];
			this.m_teamid = r.IntField[FI.teamkits_teamtechid];
			this.m_kittype = r.IntField[FI.teamkits_teamkittypetechid];
			if (this.m_kittype > 10)
			{
				this.m_kittype = 10;
			}
			this.m_hasadvertisingkit = r.IntField[FI.teamkits_hasadvertisingkit] != 0;
			this.m_jerseybacknameplacementcode = r.IntField[FI.teamkits_jerseybacknameplacementcode] != 0;
			this.m_jerseyfrontnumberplacementcode = r.IntField[FI.teamkits_jerseyfrontnumberplacementcode] != 0;
			this.m_shortsnumberplacementcode = r.IntField[FI.teamkits_shortsnumberplacementcode] != 0;
			this.m_jerseycollargeometrytype = r.IntField[FI.teamkits_jerseycollargeometrytype];
			this.m_jerseybacknamefontcase = r.IntField[FI.teamkits_jerseybacknamefontcase];
			this.m_jerseynamefonttype = r.IntField[FI.teamkits_jerseynamefonttype];
			this.m_numberfonttype = r.IntField[FI.teamkits_numberfonttype];
			this.m_numbercolor = r.IntField[FI.teamkits_numbercolor];
			this.m_shortsnumberfonttype = r.IntField[FI.teamkits_shortsnumberfonttype];
			this.m_shortsnumbercolor = r.IntField[FI.teamkits_shortsnumbercolor];
			this.m_jerseynamecolorr = r.IntField[FI.teamkits_jerseynamecolorr];
			this.m_jerseynamecolorg = r.IntField[FI.teamkits_jerseynamecolorg];
			this.m_jerseynamecolorb = r.IntField[FI.teamkits_jerseynamecolorb];
			this.m_JerseyNameColor = Color.FromArgb(255, this.m_jerseynamecolorr, this.m_jerseynamecolorg, this.m_jerseynamecolorb);
			this.m_teamcolorprimr = r.IntField[FI.teamkits_teamcolorprimr];
			this.m_teamcolorprimg = r.IntField[FI.teamkits_teamcolorprimg];
			this.m_teamcolorprimb = r.IntField[FI.teamkits_teamcolorprimb];
			this.m_teamcolorsecr = r.IntField[FI.teamkits_teamcolorsecr];
			this.m_teamcolorsecg = r.IntField[FI.teamkits_teamcolorsecg];
			this.m_teamcolorsecb = r.IntField[FI.teamkits_teamcolorsecb];
			this.m_teamcolortertr = r.IntField[FI.teamkits_teamcolortertr];
			this.m_teamcolortertg = r.IntField[FI.teamkits_teamcolortertg];
			this.m_teamcolortertb = r.IntField[FI.teamkits_teamcolortertb];
			this.m_TeamColor1 = Color.FromArgb(255, this.m_teamcolorprimr, this.m_teamcolorprimg, this.m_teamcolorprimb);
			this.m_TeamColor2 = Color.FromArgb(255, this.m_teamcolorsecr, this.m_teamcolorsecg, this.m_teamcolorsecb);
			this.m_TeamColor3 = Color.FromArgb(255, this.m_teamcolortertr, this.m_teamcolortertg, this.m_teamcolortertb);
			this.m_isinheritbasedetailmap = r.IntField[FI.teamkits_isinheritbasedetailmap];
			this.m_jerseyshapestyle = r.IntField[FI.teamkits_jerseyshapestyle];
			this.m_jerseynamelayouttype = r.IntField[FI.teamkits_jerseynamelayouttype];
			this.m_jerseyrenderingdetailmaptype = r.IntField[FI.teamkits_jerseyrenderingdetailmaptype];
			this.m_renderingmaterialtype = r.IntField[FI.teamkits_renderingmaterialtype];
			this.m_shortsrenderingdetailmaptype = r.IntField[FI.teamkits_shortsrenderingdetailmaptype];
			this.m_dlc = r.IntField[FI.teamkits_dlc];
			this.m_year = r.IntField[FI.teamkits_year];
			this.m_powid = r.IntField[FI.teamkits_powid];
			this.m_islocked = r.IntField[FI.teamkits_islocked];
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x0001FA14 File Offset: 0x0001DC14
		public void LinkTeam(TeamList kitList)
		{
			if (kitList == null)
			{
				return;
			}
			Team team = (Team)kitList.SearchId(this.m_teamid);
			if (team == null)
			{
				return;
			}
			this.m_Team = team;
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x0001FA44 File Offset: 0x0001DC44
		public void SaveKit(Record r, int artificialKey)
		{
			r.IntField[FI.teamkits_teamkitid] = artificialKey;
			r.IntField[FI.teamkits_teamtechid] = this.m_teamid;
			r.IntField[FI.teamkits_teamkittypetechid] = this.m_kittype;
			r.IntField[FI.teamkits_hasadvertisingkit] = (this.m_hasadvertisingkit ? 1 : 0);
			r.IntField[FI.teamkits_jerseybacknameplacementcode] = (this.m_jerseybacknameplacementcode ? 1 : 0);
			r.IntField[FI.teamkits_jerseyfrontnumberplacementcode] = (this.m_jerseyfrontnumberplacementcode ? 1 : 0);
			r.IntField[FI.teamkits_shortsnumberplacementcode] = (this.m_shortsnumberplacementcode ? 1 : 0);
			r.IntField[FI.teamkits_jerseycollargeometrytype] = this.m_jerseycollargeometrytype;
			r.IntField[FI.teamkits_jerseybacknamefontcase] = this.m_jerseybacknamefontcase;
			r.IntField[FI.teamkits_jerseynamefonttype] = this.m_jerseynamefonttype;
			r.IntField[FI.teamkits_numberfonttype] = this.m_numberfonttype;
			r.IntField[FI.teamkits_numbercolor] = this.m_numbercolor;
			r.IntField[FI.teamkits_shortsnumberfonttype] = this.m_shortsnumberfonttype;
			r.IntField[FI.teamkits_shortsnumbercolor] = this.m_shortsnumbercolor;
			this.m_jerseynamecolorr = (int)this.m_JerseyNameColor.R;
			this.m_jerseynamecolorg = (int)this.m_JerseyNameColor.G;
			this.m_jerseynamecolorb = (int)this.m_JerseyNameColor.B;
			r.IntField[FI.teamkits_jerseynamecolorr] = this.m_jerseynamecolorr;
			r.IntField[FI.teamkits_jerseynamecolorg] = this.m_jerseynamecolorg;
			r.IntField[FI.teamkits_jerseynamecolorb] = this.m_jerseynamecolorb;
			this.m_teamcolorprimr = (int)this.m_TeamColor1.R;
			this.m_teamcolorprimg = (int)this.m_TeamColor1.G;
			this.m_teamcolorprimb = (int)this.m_TeamColor1.B;
			this.m_teamcolorsecr = (int)this.m_TeamColor2.R;
			this.m_teamcolorsecg = (int)this.m_TeamColor2.G;
			this.m_teamcolorsecb = (int)this.m_TeamColor2.B;
			this.m_teamcolortertr = (int)this.m_TeamColor3.R;
			this.m_teamcolortertg = (int)this.m_TeamColor3.G;
			this.m_teamcolortertb = (int)this.m_TeamColor3.B;
			r.IntField[FI.teamkits_teamcolorprimr] = this.m_teamcolorprimr;
			r.IntField[FI.teamkits_teamcolorprimg] = this.m_teamcolorprimg;
			r.IntField[FI.teamkits_teamcolorprimb] = this.m_teamcolorprimb;
			r.IntField[FI.teamkits_teamcolorsecr] = this.m_teamcolorsecr;
			r.IntField[FI.teamkits_teamcolorsecg] = this.m_teamcolorsecg;
			r.IntField[FI.teamkits_teamcolorsecb] = this.m_teamcolorsecb;
			r.IntField[FI.teamkits_teamcolortertr] = this.m_teamcolortertr;
			r.IntField[FI.teamkits_teamcolortertg] = this.m_teamcolortertg;
			r.IntField[FI.teamkits_teamcolortertb] = this.m_teamcolortertb;
			r.IntField[FI.teamkits_isinheritbasedetailmap] = this.m_isinheritbasedetailmap;
			r.IntField[FI.teamkits_jerseyshapestyle] = this.m_jerseyshapestyle;
			r.IntField[FI.teamkits_jerseynamelayouttype] = this.m_jerseynamelayouttype;
			r.IntField[FI.teamkits_jerseyrenderingdetailmaptype] = this.m_jerseyrenderingdetailmaptype;
			r.IntField[FI.teamkits_renderingmaterialtype] = this.m_renderingmaterialtype;
			r.IntField[FI.teamkits_shortsrenderingdetailmaptype] = this.m_shortsrenderingdetailmaptype;
			r.IntField[FI.teamkits_dlc] = this.m_dlc;
			r.IntField[FI.teamkits_year] = this.m_year;
			r.IntField[FI.teamkits_islocked] = 0;
			r.IntField[FI.teamkits_powid] = -1;
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x0001FDAE File Offset: 0x0001DFAE
		public string MiniKitDdsFileName()
		{
			return Kit.MiniKitDdsFileName(this.m_teamid, this.m_kittype, this.m_year);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x0001FDC8 File Offset: 0x0001DFC8
		public static string MiniKitDdsFileName(int teamid, int kittype, int year)
		{
			return string.Concat(new string[]
			{
				"data/ui/imgassets/kits/j",
				kittype.ToString(),
				"_",
				teamid.ToString(),
				"_",
				year.ToString(),
				".dds"
			});
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x0001FE20 File Offset: 0x0001E020
		public string MiniKitTemplateFileName()
		{
			return "data/ui/imgassets/kits/j#_%_0.dds";
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x0001FE27 File Offset: 0x0001E027
		public Bitmap GetMiniKit()
		{
			return FifaEnvironment.GetDdsArtasset(this.MiniKitDdsFileName());
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x0001FE34 File Offset: 0x0001E034
		public Bitmap GetMiniKit(int kitType)
		{
			return FifaEnvironment.GetDdsArtasset(Kit.MiniKitDdsFileName(this.m_teamid, kitType, 0));
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x0001FE48 File Offset: 0x0001E048
		public bool SetMiniKit(Bitmap bitmap)
		{
			int[] array = new int[] { this.m_kittype, this.m_teamid };
			string[] array2 = new string[]
			{
				string.Empty,
				string.Empty
			};
			return FifaEnvironment.SetDdsArtasset(this.MiniKitTemplateFileName(), array, bitmap, array2);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x0001FE93 File Offset: 0x0001E093
		public bool DeleteMiniKit()
		{
			return FifaEnvironment.DeleteFromZdata(this.MiniKitDdsFileName());
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x0001FEA0 File Offset: 0x0001E0A0
		public string KitTextureFileName()
		{
			return Kit.KitTextureFileName(this.m_teamid, this.m_kittype, this.m_year);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x0001FEBC File Offset: 0x0001E0BC
		public static string KitTextureFileName(int teamid, int kittype, int year)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/kit/kit_",
				teamid.ToString(),
				"_",
				kittype.ToString(),
				"_",
				year.ToString(),
				".rx3"
			});
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x0001FF14 File Offset: 0x0001E114
		public string KitTextureTemplateName()
		{
			return "data\\sceneassets\\kit\\kit_#_%_0.rx3";
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x0001FF1C File Offset: 0x0001E11C
		public Bitmap[] GetKitTextures()
		{
			if (this.m_KitTextures != null)
			{
				return this.m_KitTextures;
			}
			string text = this.KitTextureFileName();
			this.m_KitTextures = FifaEnvironment.GetKitFromRx3(text, out this.m_Positions);
			return this.m_KitTextures;
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x0001FF58 File Offset: 0x0001E158
		public bool SetKitTextures(Bitmap[] bitmaps)
		{
			this.m_KitTextures = bitmaps;
			int[] array = new int[] { this.m_teamid, this.m_kittype };
			return FifaEnvironment.ImportKitIntoZdata(this.KitTextureTemplateName(), array, bitmaps, this.m_Positions);
		}

		// Token: 0x060005AD RID: 1453 RVA: 0x0001FF98 File Offset: 0x0001E198
		public bool SetKitTextures(string rx3FileName)
		{
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.KitTextureFileName(), false, ECompressionMode.Chunkzip);
			if (flag)
			{
				this.m_KitTextures = null;
				this.GetKitTextures();
			}
			return flag;
		}

		// Token: 0x060005AE RID: 1454 RVA: 0x0001FFC8 File Offset: 0x0001E1C8
		public bool DeleteKitTextures()
		{
			string text = this.KitTextureFileName();
			bool flag = FifaEnvironment.DeleteFromZdata(text);
			if (flag)
			{
				this.m_KitTextures = null;
			}
			return flag;
		}

		// Token: 0x060005AF RID: 1455 RVA: 0x0001FFEE File Offset: 0x0001E1EE
		public bool ImportKitTextures(string rx3FileName)
		{
			return this.SetKitTextures(rx3FileName);
		}

		// Token: 0x060005B0 RID: 1456 RVA: 0x0001FFF8 File Offset: 0x0001E1F8
		public bool ExportKitTextures(string exportDir)
		{
			string text = this.KitTextureFileName();
			return FifaEnvironment.ExportFileFromZdata(text, exportDir);
		}

		// Token: 0x060005B1 RID: 1457 RVA: 0x00020013 File Offset: 0x0001E213
		public Bitmap[] GetJerseyFont()
		{
			return NumberFont.GetNumberFont(this.m_numberfonttype, this.m_numbercolor);
		}

		// Token: 0x060005B2 RID: 1458 RVA: 0x00020026 File Offset: 0x0001E226
		public bool SetJerseyFont(Bitmap[] bitmaps)
		{
			return NumberFont.SetNumberFont(this.m_numberfonttype, this.m_numbercolor, bitmaps);
		}

		// Token: 0x060005B3 RID: 1459 RVA: 0x0002003A File Offset: 0x0001E23A
		public bool SetJerseyFont(string rx3FileName)
		{
			return NumberFont.SetNumberFont(this.m_numberfonttype, this.m_numbercolor, rx3FileName);
		}

		// Token: 0x060005B4 RID: 1460 RVA: 0x0002004E File Offset: 0x0001E24E
		public bool DeleteJerseyFont()
		{
			return NumberFont.Delete(this.m_numberfonttype, this.m_numbercolor);
		}

		// Token: 0x060005B5 RID: 1461 RVA: 0x00020064 File Offset: 0x0001E264
		public static Bitmap ApplyJerseyShadowedTexture(Bitmap originalTexture)
		{
			if (Kit.s_JerseyShadow == null)
			{
				string text = FifaEnvironment.LaunchDir + "\\Templates\\JerseyShadow.png";
				Kit.s_JerseyShadow = new Bitmap(text);
			}
			if (Kit.s_JerseyShadow == null)
			{
				return originalTexture;
			}
			return GraphicUtil.EmbossBitmap(originalTexture, Kit.s_JerseyShadow);
		}

		// Token: 0x060005B6 RID: 1462 RVA: 0x000200A8 File Offset: 0x0001E2A8
		public static Bitmap ApplyShortsShadowedTexture(Bitmap originalTexture)
		{
			if (Kit.s_ShortsShadow == null)
			{
				string text = FifaEnvironment.LaunchDir + "\\Templates\\ShortsShadow.png";
				Kit.s_ShortsShadow = new Bitmap(text);
			}
			if (Kit.s_ShortsShadow == null)
			{
				return originalTexture;
			}
			return GraphicUtil.EmbossBitmap(originalTexture, Kit.s_ShortsShadow);
		}

		// Token: 0x0400023E RID: 574
		public static Bitmap s_JerseyWrinkle = null;

		// Token: 0x0400023F RID: 575
		public static Bitmap s_ShortsWrinkle = null;

		// Token: 0x04000240 RID: 576
		public static Model3D[] s_JerseyModel3D = new Model3D[16];

		// Token: 0x04000241 RID: 577
		public static Model3D s_ShortsModel3D = null;

		// Token: 0x04000242 RID: 578
		public static Model3D s_SocksModel3D = null;

		// Token: 0x04000243 RID: 579
		private float[] m_Positions = new float[32];

		// Token: 0x04000244 RID: 580
		private Bitmap[] m_KitTextures;

		// Token: 0x04000245 RID: 581
		private bool m_hasadvertisingkit;

		// Token: 0x04000246 RID: 582
		private bool m_jerseybacknameplacementcode;

		// Token: 0x04000247 RID: 583
		private bool m_jerseyfrontnumberplacementcode;

		// Token: 0x04000248 RID: 584
		private bool m_shortsnumberplacementcode;

		// Token: 0x04000249 RID: 585
		private int m_jerseycollargeometrytype;

		// Token: 0x0400024A RID: 586
		private int m_jerseybacknamefontcase;

		// Token: 0x0400024B RID: 587
		private int m_jerseynamefonttype;

		// Token: 0x0400024C RID: 588
		private int m_numberfonttype;

		// Token: 0x0400024D RID: 589
		private int m_numbercolor;

		// Token: 0x0400024E RID: 590
		private int m_shortsnumberfonttype;

		// Token: 0x0400024F RID: 591
		private int m_shortsnumbercolor;

		// Token: 0x04000250 RID: 592
		private int m_jerseynamecolorr;

		// Token: 0x04000251 RID: 593
		private int m_jerseynamecolorg;

		// Token: 0x04000252 RID: 594
		private int m_jerseynamecolorb;

		// Token: 0x04000253 RID: 595
		private Color m_JerseyNameColor;

		// Token: 0x04000254 RID: 596
		private int m_teamcolorprimr;

		// Token: 0x04000255 RID: 597
		private int m_teamcolorprimg;

		// Token: 0x04000256 RID: 598
		private int m_teamcolorprimb;

		// Token: 0x04000257 RID: 599
		private int m_teamcolorsecr;

		// Token: 0x04000258 RID: 600
		private int m_teamcolorsecg;

		// Token: 0x04000259 RID: 601
		private int m_teamcolorsecb;

		// Token: 0x0400025A RID: 602
		private int m_teamcolortertr;

		// Token: 0x0400025B RID: 603
		private int m_teamcolortertg;

		// Token: 0x0400025C RID: 604
		private int m_teamcolortertb;

		// Token: 0x0400025D RID: 605
		private Color m_TeamColor1;

		// Token: 0x0400025E RID: 606
		private Color m_TeamColor2;

		// Token: 0x0400025F RID: 607
		private Color m_TeamColor3;

		// Token: 0x04000260 RID: 608
		private int m_jerseynamelayouttype;

		// Token: 0x04000261 RID: 609
		private int m_isinheritbasedetailmap;

		// Token: 0x04000262 RID: 610
		private int m_jerseyshapestyle;

		// Token: 0x04000263 RID: 611
		private int m_jerseyrenderingdetailmaptype;

		// Token: 0x04000264 RID: 612
		private int m_renderingmaterialtype;

		// Token: 0x04000265 RID: 613
		private int m_shortsrenderingdetailmaptype;

		// Token: 0x04000266 RID: 614
		private int m_dlc;

		// Token: 0x04000267 RID: 615
		private int m_year;

		// Token: 0x04000268 RID: 616
		private int m_powid;

		// Token: 0x04000269 RID: 617
		private int m_islocked;

		// Token: 0x0400026A RID: 618
		private int m_teamid;

		// Token: 0x0400026B RID: 619
		private int m_kittype;

		// Token: 0x0400026C RID: 620
		private Team m_Team;

		// Token: 0x0400026D RID: 621
		private static Bitmap s_JerseyShadow = null;

		// Token: 0x0400026E RID: 622
		private static Bitmap s_ShortsShadow = null;
	}
}
