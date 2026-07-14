using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200009D RID: 157
	public class Referee : IdObject
	{
		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06000B76 RID: 2934 RVA: 0x0004C345 File Offset: 0x0004A545
		public Bitmap EyesTextureBitmap
		{
			get
			{
				return this.m_EyesTextureBitmap;
			}
		}

		// Token: 0x1700025F RID: 607
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0004C34D File Offset: 0x0004A54D
		public Bitmap FaceTextureBitmap
		{
			get
			{
				return this.m_FaceTextureBitmap;
			}
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000B78 RID: 2936 RVA: 0x0004C355 File Offset: 0x0004A555
		public Bitmap HairColorTextureBitmap
		{
			get
			{
				return this.m_HairColorTextureBitmap;
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000B79 RID: 2937 RVA: 0x0004C35D File Offset: 0x0004A55D
		public Bitmap HairAlfaTextureBitmap
		{
			get
			{
				return this.m_HairAlfaTextureBitmap;
			}
		}

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000B7A RID: 2938 RVA: 0x0004C365 File Offset: 0x0004A565
		// (set) Token: 0x06000B7B RID: 2939 RVA: 0x0004C36D File Offset: 0x0004A56D
		public string firstname
		{
			get
			{
				return this.m_firstname;
			}
			set
			{
				this.m_firstname = value;
			}
		}

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000B7C RID: 2940 RVA: 0x0004C376 File Offset: 0x0004A576
		// (set) Token: 0x06000B7D RID: 2941 RVA: 0x0004C37E File Offset: 0x0004A57E
		public string surname
		{
			get
			{
				return this.m_surname;
			}
			set
			{
				this.m_surname = value;
			}
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000B7E RID: 2942 RVA: 0x0004C387 File Offset: 0x0004A587
		// (set) Token: 0x06000B7F RID: 2943 RVA: 0x0004C38F File Offset: 0x0004A58F
		public DateTime birthdate
		{
			get
			{
				return this.m_birthdate;
			}
			set
			{
				this.m_birthdate = value;
			}
		}

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000B80 RID: 2944 RVA: 0x0004C398 File Offset: 0x0004A598
		// (set) Token: 0x06000B81 RID: 2945 RVA: 0x0004C3A0 File Offset: 0x0004A5A0
		public int nationalitycode
		{
			get
			{
				return this.m_nationalitycode;
			}
			set
			{
				this.m_nationalitycode = value;
			}
		}

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000B82 RID: 2946 RVA: 0x0004C3A9 File Offset: 0x0004A5A9
		// (set) Token: 0x06000B83 RID: 2947 RVA: 0x0004C3B1 File Offset: 0x0004A5B1
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
					this.m_nationalitycode = this.m_Country.Id;
				}
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0004C3D3 File Offset: 0x0004A5D3
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0004C3DB File Offset: 0x0004A5DB
		public int[] leagueids
		{
			get
			{
				return this.m_leagueids;
			}
			set
			{
				this.m_leagueids = value;
			}
		}

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0004C3E4 File Offset: 0x0004A5E4
		// (set) Token: 0x06000B87 RID: 2951 RVA: 0x0004C3EC File Offset: 0x0004A5EC
		public League[] Leagues
		{
			get
			{
				return this.m_Leagues;
			}
			set
			{
				this.m_Leagues = value;
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0004C3F8 File Offset: 0x0004A5F8
		public void SetLeague(int id)
		{
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				if (this.m_leagueids[i] == id)
				{
					return;
				}
			}
			for (int j = 0; j < this.m_Leagues.Length; j++)
			{
				if (this.m_leagueids[j] == 0)
				{
					this.m_leagueids[j] = id;
					return;
				}
			}
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0004C44C File Offset: 0x0004A64C
		public int CntLeagues()
		{
			int num = 0;
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				if (this.m_leagueids[i] != 0)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06000B8A RID: 2954 RVA: 0x0004C480 File Offset: 0x0004A680
		public int GetMainLeague()
		{
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				if (this.m_leagueids[i] != 0)
				{
					return this.m_leagueids[i];
				}
			}
			return 1;
		}

		// Token: 0x06000B8B RID: 2955 RVA: 0x0004C4B4 File Offset: 0x0004A6B4
		public bool IsInLeague(League league)
		{
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				if (this.Leagues[i] == league)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0004C4E2 File Offset: 0x0004A6E2
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0004C4EA File Offset: 0x0004A6EA
		public int height
		{
			get
			{
				return this.m_height;
			}
			set
			{
				this.m_height = value;
			}
		}

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000B8E RID: 2958 RVA: 0x0004C4F3 File Offset: 0x0004A6F3
		// (set) Token: 0x06000B8F RID: 2959 RVA: 0x0004C4FB File Offset: 0x0004A6FB
		public int weight
		{
			get
			{
				return this.m_weight;
			}
			set
			{
				this.m_weight = value;
			}
		}

		// Token: 0x1700026B RID: 619
		// (get) Token: 0x06000B90 RID: 2960 RVA: 0x0004C504 File Offset: 0x0004A704
		// (set) Token: 0x06000B91 RID: 2961 RVA: 0x0004C50C File Offset: 0x0004A70C
		public int eyecolorcode
		{
			get
			{
				return this.m_eyecolorcode;
			}
			set
			{
				this.m_eyecolorcode = value;
				this.m_EyesTextureBitmap = null;
			}
		}

		// Token: 0x1700026C RID: 620
		// (get) Token: 0x06000B92 RID: 2962 RVA: 0x0004C51C File Offset: 0x0004A71C
		// (set) Token: 0x06000B93 RID: 2963 RVA: 0x0004C524 File Offset: 0x0004A724
		public int eyebrowcode
		{
			get
			{
				return this.m_eyebrowcode;
			}
			set
			{
				this.m_eyebrowcode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x1700026D RID: 621
		// (get) Token: 0x06000B94 RID: 2964 RVA: 0x0004C534 File Offset: 0x0004A734
		// (set) Token: 0x06000B95 RID: 2965 RVA: 0x0004C53C File Offset: 0x0004A73C
		public int stylecode
		{
			get
			{
				return this.m_stylecode;
			}
			set
			{
				this.m_stylecode = value;
			}
		}

		// Token: 0x1700026E RID: 622
		// (get) Token: 0x06000B96 RID: 2966 RVA: 0x0004C545 File Offset: 0x0004A745
		// (set) Token: 0x06000B97 RID: 2967 RVA: 0x0004C54D File Offset: 0x0004A74D
		public int cardstrictness
		{
			get
			{
				return this.m_cardstrictness;
			}
			set
			{
				this.m_cardstrictness = value;
			}
		}

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x06000B98 RID: 2968 RVA: 0x0004C556 File Offset: 0x0004A756
		// (set) Token: 0x06000B99 RID: 2969 RVA: 0x0004C55E File Offset: 0x0004A75E
		public int foulstrictness
		{
			get
			{
				return this.m_foulstrictness;
			}
			set
			{
				this.m_foulstrictness = value;
			}
		}

		// Token: 0x17000270 RID: 624
		// (get) Token: 0x06000B9A RID: 2970 RVA: 0x0004C567 File Offset: 0x0004A767
		// (set) Token: 0x06000B9B RID: 2971 RVA: 0x0004C56F File Offset: 0x0004A76F
		public int bodytypecode
		{
			get
			{
				return this.m_bodytypecode;
			}
			set
			{
				this.m_bodytypecode = value;
			}
		}

		// Token: 0x17000271 RID: 625
		// (get) Token: 0x06000B9C RID: 2972 RVA: 0x0004C578 File Offset: 0x0004A778
		// (set) Token: 0x06000B9D RID: 2973 RVA: 0x0004C580 File Offset: 0x0004A780
		public int hairtypecode
		{
			get
			{
				return this.m_hairtypecode;
			}
			set
			{
				this.m_hairtypecode = value;
				this.m_HairModelFile = null;
			}
		}

		// Token: 0x17000272 RID: 626
		// (get) Token: 0x06000B9E RID: 2974 RVA: 0x0004C590 File Offset: 0x0004A790
		// (set) Token: 0x06000B9F RID: 2975 RVA: 0x0004C598 File Offset: 0x0004A798
		public int headtypecode
		{
			get
			{
				return this.m_headtypecode;
			}
			set
			{
				this.m_headtypecode = value;
				this.m_HeadModelFile = null;
			}
		}

		// Token: 0x17000273 RID: 627
		// (get) Token: 0x06000BA0 RID: 2976 RVA: 0x0004C5A8 File Offset: 0x0004A7A8
		// (set) Token: 0x06000BA1 RID: 2977 RVA: 0x0004C5B0 File Offset: 0x0004A7B0
		public int haircolorcode
		{
			get
			{
				return this.m_haircolorcode;
			}
			set
			{
				this.m_haircolorcode = value;
				this.m_HairColorTextureBitmap = null;
				this.m_HairAlfaTextureBitmap = null;
			}
		}

		// Token: 0x17000274 RID: 628
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0004C5C7 File Offset: 0x0004A7C7
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0004C5CF File Offset: 0x0004A7CF
		public int facialhairtypecode
		{
			get
			{
				return this.m_facialhairtypecode;
			}
			set
			{
				this.m_facialhairtypecode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x17000275 RID: 629
		// (get) Token: 0x06000BA4 RID: 2980 RVA: 0x0004C5DF File Offset: 0x0004A7DF
		// (set) Token: 0x06000BA5 RID: 2981 RVA: 0x0004C5E7 File Offset: 0x0004A7E7
		public int facialhaircolorcode
		{
			get
			{
				return this.m_facialhaircolorcode;
			}
			set
			{
				this.m_facialhaircolorcode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x17000276 RID: 630
		// (get) Token: 0x06000BA6 RID: 2982 RVA: 0x0004C5F7 File Offset: 0x0004A7F7
		// (set) Token: 0x06000BA7 RID: 2983 RVA: 0x0004C5FF File Offset: 0x0004A7FF
		public int sideburnscode
		{
			get
			{
				return this.m_sideburnscode;
			}
			set
			{
				this.m_sideburnscode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x17000277 RID: 631
		// (get) Token: 0x06000BA8 RID: 2984 RVA: 0x0004C60F File Offset: 0x0004A80F
		// (set) Token: 0x06000BA9 RID: 2985 RVA: 0x0004C617 File Offset: 0x0004A817
		public int skintypecode
		{
			get
			{
				return this.m_skintypecode;
			}
			set
			{
				this.m_skintypecode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x17000278 RID: 632
		// (get) Token: 0x06000BAA RID: 2986 RVA: 0x0004C627 File Offset: 0x0004A827
		// (set) Token: 0x06000BAB RID: 2987 RVA: 0x0004C62F File Offset: 0x0004A82F
		public int skintonecode
		{
			get
			{
				return this.m_skintonecode;
			}
			set
			{
				this.m_skintonecode = value;
				this.m_FaceTextureBitmap = null;
			}
		}

		// Token: 0x17000279 RID: 633
		// (get) Token: 0x06000BAC RID: 2988 RVA: 0x0004C63F File Offset: 0x0004A83F
		// (set) Token: 0x06000BAD RID: 2989 RVA: 0x0004C647 File Offset: 0x0004A847
		public int jerseysleevelengthcode
		{
			get
			{
				return this.m_jerseysleevelengthcode;
			}
			set
			{
				this.m_jerseysleevelengthcode = value;
			}
		}

		// Token: 0x1700027A RID: 634
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0004C650 File Offset: 0x0004A850
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0004C658 File Offset: 0x0004A858
		public int shoedesigncode
		{
			get
			{
				return this.m_shoedesigncode;
			}
			set
			{
				this.m_shoedesigncode = value;
			}
		}

		// Token: 0x1700027B RID: 635
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0004C661 File Offset: 0x0004A861
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0004C669 File Offset: 0x0004A869
		public int shoecolorcode1
		{
			get
			{
				return this.m_shoecolorcode1;
			}
			set
			{
				this.m_shoecolorcode1 = value;
			}
		}

		// Token: 0x1700027C RID: 636
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0004C672 File Offset: 0x0004A872
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0004C67A File Offset: 0x0004A87A
		public int shoecolorcode2
		{
			get
			{
				return this.m_shoecolorcode2;
			}
			set
			{
				this.m_shoecolorcode2 = value;
			}
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0004C683 File Offset: 0x0004A883
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0004C68B File Offset: 0x0004A88B
		public int shoetypecode
		{
			get
			{
				return this.m_shoetypecode;
			}
			set
			{
				this.m_shoetypecode = value;
			}
		}

		// Token: 0x06000BB6 RID: 2998 RVA: 0x0004C7D4 File Offset: 0x0004A9D4
		public Referee(Record r)
			: base(r.IntField[FI.referee_refereeid])
		{
			this.Load(r);
		}

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0004C98C File Offset: 0x0004AB8C
		public Referee(int refereeid)
			: base(refereeid)
		{
			int newRefereeHeadId = FifaEnvironment.Referees.GetNewRefereeHeadId();
			this.m_refereeheadid_unused = ((newRefereeHeadId > -1000) ? (-1000) : newRefereeHeadId);
			this.m_firstname = "";
			this.m_surname = "Referee " + base.Id.ToString();
			this.m_birthdate = new DateTime(1970, 6, 15);
			this.m_nationalitycode = 0;
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				this.m_leagueids[i] = 0;
				this.m_Leagues[i] = null;
			}
			this.m_height = 180;
			this.m_weight = 75;
			this.m_bodytypecode = 1;
			this.m_shoedesigncode = 0;
			this.m_shoecolorcode1 = 30;
			this.m_shoecolorcode2 = 31;
			this.m_shoetypecode = 72;
			this.m_jerseysleevelengthcode = 0;
			this.m_eyecolorcode = 1;
			this.m_eyebrowcode = 0;
			this.m_facialhairtypecode = 0;
			this.m_facialhaircolorcode = 0;
			this.m_hairtypecode = 0;
			this.m_haircolorcode = 0;
			this.m_headtypecode = 1;
			this.m_headclasscode = 1;
			this.m_sideburnscode = 0;
			this.m_skintypecode = 0;
			this.m_skintonecode = 2;
			this.m_stylecode = 1;
			this.m_cardstrictness = 1;
			this.m_foulstrictness = 1;
			this.m_homecitycode = 5;
			this.m_sockheightcode = 0;
			this.m_haireffecttypecode = 0;
			this.m_hairlinecode = 0;
			this.m_hairpartcode = 0;
			this.m_hairstateid = 0;
			this.m_hairvariationid = 0;
			this.m_sweatid = 0;
			this.m_wrinkleid = 0;
			this.m_proxyhaircolorid = 1;
			this.m_proxyheadclass = 1;
		}

		// Token: 0x06000BB8 RID: 3000 RVA: 0x0004CB68 File Offset: 0x0004AD68
		public void Load(Record r)
		{
			this.m_firstname = r.StringField[FI.referee_firstname];
			this.m_surname = r.StringField[FI.referee_surname];
			this.m_nationalitycode = r.GetAndCheckIntField(FI.referee_nationalitycode);
			int andCheckIntField = r.GetAndCheckIntField(FI.referee_leagueid);
			this.SetLeague(andCheckIntField);
			DateTime dateTime = FifaUtil.ConvertToDate(r.GetAndCheckIntField(FI.referee_birthdate));
			if (dateTime.Year < 1900)
			{
				dateTime = new DateTime(1980, 1, 1);
			}
			this.m_birthdate = dateTime;
			this.m_height = r.GetAndCheckIntField(FI.referee_height);
			this.m_weight = r.GetAndCheckIntField(FI.referee_weight);
			this.m_bodytypecode = r.GetAndCheckIntField(FI.referee_bodytypecode) - 1;
			this.m_shoedesigncode = r.GetAndCheckIntField(FI.referee_shoedesigncode);
			this.m_shoecolorcode1 = r.GetAndCheckIntField(FI.referee_shoecolorcode1);
			this.m_shoecolorcode2 = r.GetAndCheckIntField(FI.referee_shoecolorcode2);
			this.m_shoetypecode = r.GetAndCheckIntField(FI.referee_shoetypecode);
			this.m_jerseysleevelengthcode = r.GetAndCheckIntField(FI.referee_jerseysleevelengthcode);
			this.m_eyecolorcode = r.GetAndCheckIntField(FI.referee_eyecolorcode);
			this.m_eyebrowcode = r.GetAndCheckIntField(FI.referee_eyebrowcode);
			this.m_facialhairtypecode = r.GetAndCheckIntField(FI.referee_facialhairtypecode);
			this.m_facialhaircolorcode = r.GetAndCheckIntField(FI.referee_facialhaircolorcode);
			this.m_hairtypecode = r.GetAndCheckIntField(FI.referee_hairtypecode);
			this.m_haircolorcode = r.GetAndCheckIntField(FI.referee_haircolorcode);
			this.m_headtypecode = r.GetAndCheckIntField(FI.referee_headtypecode);
			this.m_headclasscode = r.GetAndCheckIntField(FI.referee_headclasscode);
			this.m_sideburnscode = r.GetAndCheckIntField(FI.referee_sideburnscode);
			this.m_skintypecode = r.GetAndCheckIntField(FI.referee_skintypecode);
			this.m_skintonecode = r.GetAndCheckIntField(FI.referee_skintonecode);
			this.m_stylecode = r.GetAndCheckIntField(FI.referee_stylecode);
			this.m_cardstrictness = r.GetAndCheckIntField(FI.referee_cardstrictness);
			this.m_foulstrictness = r.GetAndCheckIntField(FI.referee_foulstrictness);
			this.m_homecitycode = r.GetAndCheckIntField(FI.referee_homecitycode);
			this.m_sockheightcode = r.GetAndCheckIntField(FI.referee_sockheightcode);
			this.m_haireffecttypecode = r.GetAndCheckIntField(FI.referee_haireffecttypecode);
			this.m_hairlinecode = r.GetAndCheckIntField(FI.referee_hairlinecode);
			this.m_hairpartcode = r.GetAndCheckIntField(FI.referee_hairpartcode);
			this.m_hairstateid = r.GetAndCheckIntField(FI.referee_hairstateid);
			this.m_hairvariationid = r.GetAndCheckIntField(FI.referee_hairvariationid);
			this.m_sweatid = r.GetAndCheckIntField(FI.referee_sweatid);
			this.m_wrinkleid = r.GetAndCheckIntField(FI.referee_wrinkleid);
			this.m_proxyhaircolorid = r.GetAndCheckIntField(FI.referee_proxyhaircolorid);
			this.m_proxyheadclass = r.GetAndCheckIntField(FI.referee_proxyheadclass);
		}

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0004CE24 File Offset: 0x0004B024
		public void FillFromLeagueRefereeLinks(Record r)
		{
			int andCheckIntField = r.GetAndCheckIntField(FI.leaguerefereelinks_leagueid);
			this.SetLeague(andCheckIntField);
		}

		// Token: 0x06000BBA RID: 3002 RVA: 0x0004CE44 File Offset: 0x0004B044
		public override string ToString()
		{
			return this.m_surname + " " + this.m_firstname;
		}

		// Token: 0x06000BBB RID: 3003 RVA: 0x0004CE5C File Offset: 0x0004B05C
		public string DatabaseString()
		{
			return this.ToString();
		}

		// Token: 0x06000BBC RID: 3004 RVA: 0x0004CE64 File Offset: 0x0004B064
		public void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			this.m_Country = (Country)countryList.SearchId(this.m_nationalitycode);
			if (this.m_Country == null)
			{
				if (countryList.Count > 0)
				{
					this.m_Country = (Country)countryList[0];
					this.m_nationalitycode = this.m_Country.Id;
					return;
				}
				this.m_nationalitycode = 0;
			}
		}

		// Token: 0x06000BBD RID: 3005 RVA: 0x0004CEC8 File Offset: 0x0004B0C8
		public void LinkLeague(LeagueList leagueList)
		{
			if (leagueList == null)
			{
				return;
			}
			for (int i = 0; i < this.m_Leagues.Length; i++)
			{
				if (this.m_leagueids[i] != 0)
				{
					this.m_Leagues[i] = (League)leagueList.SearchId(this.m_leagueids[i]);
					if (this.m_Leagues[i] == null)
					{
						this.m_leagueids[i] = 0;
						this.m_Leagues[i] = null;
					}
				}
			}
		}

		// Token: 0x06000BBE RID: 3006 RVA: 0x0004CF30 File Offset: 0x0004B130
		public string GenericHairModelFileName()
		{
			return "data/sceneassets/hair/hair_" + this.m_hairtypecode.ToString() + "_1_0.rx3";
		}

		// Token: 0x06000BBF RID: 3007 RVA: 0x0004CF5C File Offset: 0x0004B15C
		public string GenericFaceTextureFileName()
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/faces/face_0_1_0_",
				this.m_eyebrowcode.ToString(),
				"_",
				this.m_sideburnscode.ToString(),
				"_",
				this.m_facialhaircolorcode.ToString(),
				"_",
				this.m_facialhairtypecode.ToString(),
				"_",
				this.m_skintypecode.ToString(),
				"_",
				this.m_skintonecode.ToString(),
				"_textures.rx3"
			});
		}

		// Token: 0x06000BC0 RID: 3008 RVA: 0x0004D00C File Offset: 0x0004B20C
		public string GenericHeadModelFileName()
		{
			return "data/sceneassets/heads/head_" + this.m_headtypecode.ToString() + "_1.rx3";
		}

		// Token: 0x06000BC1 RID: 3009 RVA: 0x0004D038 File Offset: 0x0004B238
		public override IdObject Clone(int refereeid)
		{
			Referee referee = (Referee)base.Clone(refereeid);
			if (referee == null)
			{
				return null;
			}
			referee.m_refereeheadid_unused = this.m_refereeheadid_unused;
			referee.m_firstname = "";
			referee.m_surname = "Referee " + referee.Id.ToString();
			return referee;
		}

		// Token: 0x06000BC2 RID: 3010 RVA: 0x0004D08D File Offset: 0x0004B28D
		public void CleanFaceTexture()
		{
			if (this.m_FaceTextureBitmap != null)
			{
				this.m_FaceTextureBitmap.Dispose();
			}
			this.m_FaceTextureBitmap = null;
		}

		// Token: 0x06000BC3 RID: 3011 RVA: 0x0004D0AC File Offset: 0x0004B2AC
		public Bitmap GetFaceTexture()
		{
			if (this.m_FaceTextureBitmap != null)
			{
				return this.m_FaceTextureBitmap;
			}
			string text = this.GenericFaceTextureFileName();
			this.m_FaceTextureBitmap = FifaEnvironment.GetBmpFromRx3(text, 0);
			return this.m_FaceTextureBitmap;
		}

		// Token: 0x06000BC4 RID: 3012 RVA: 0x0004D0E4 File Offset: 0x0004B2E4
		public string GenericEyesTextureFileName()
		{
			return "data/sceneassets/heads/eyes_" + this.m_eyecolorcode.ToString() + "_1_textures.rx3";
		}

		// Token: 0x06000BC5 RID: 3013 RVA: 0x0004D110 File Offset: 0x0004B310
		public Bitmap GetEyesTexture()
		{
			if (this.m_EyesTextureBitmap != null)
			{
				return this.m_EyesTextureBitmap;
			}
			string text = this.GenericEyesTextureFileName();
			this.m_EyesTextureBitmap = FifaEnvironment.GetBmpFromRx3(text, 0);
			return this.m_EyesTextureBitmap;
		}

		// Token: 0x06000BC6 RID: 3014 RVA: 0x0004D148 File Offset: 0x0004B348
		public void CleanEyesTexture()
		{
			if (this.m_EyesTextureBitmap != null)
			{
				this.m_EyesTextureBitmap.Dispose();
			}
			this.m_EyesTextureBitmap = null;
		}

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0004D164 File Offset: 0x0004B364
		public string GenericHairColorTextureFileName()
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/hair/haircolour_",
				this.m_hairtypecode.ToString(),
				"_0_",
				this.m_haircolorcode.ToString(),
				"_0_1_textures.rx3"
			});
		}

		// Token: 0x06000BC8 RID: 3016 RVA: 0x0004D1B4 File Offset: 0x0004B3B4
		public void CleanHairColorTexture()
		{
			if (this.m_HairColorTextureBitmap != null)
			{
				this.m_HairColorTextureBitmap.Dispose();
			}
			this.m_HairColorTextureBitmap = null;
		}

		// Token: 0x06000BC9 RID: 3017 RVA: 0x0004D1D0 File Offset: 0x0004B3D0
		public Bitmap GetHairColorTexture()
		{
			if (this.m_HairColorTextureBitmap != null)
			{
				return this.m_HairColorTextureBitmap;
			}
			this.GetHairTextures();
			return this.m_HairColorTextureBitmap;
		}

		// Token: 0x06000BCA RID: 3018 RVA: 0x0004D1F0 File Offset: 0x0004B3F0
		public string GenericHairTexturesFileName()
		{
			return "data/sceneassets/hair/hair_" + this.m_hairtypecode.ToString() + "_1_textures.rx3";
		}

		// Token: 0x06000BCB RID: 3019 RVA: 0x0004D21C File Offset: 0x0004B41C
		public Bitmap[] GetHairTextures()
		{
			if (this.m_HairAlfaTextureBitmap != null && this.m_HairColorTextureBitmap != null)
			{
				return new Bitmap[] { this.m_HairAlfaTextureBitmap, this.m_HairColorTextureBitmap };
			}
			string text = this.GenericHairTexturesFileName();
			Bitmap[] bmpsFromRx = FifaEnvironment.GetBmpsFromRx3(text);
			this.m_HairAlfaTextureBitmap = bmpsFromRx[0];
			this.m_HairColorTextureBitmap = GraphicUtil.MultiplyColorToBitmap(bmpsFromRx[1], Player.s_GenericColors[this.m_haircolorcode], 96);
			return bmpsFromRx;
		}

		// Token: 0x06000BCC RID: 3020 RVA: 0x0004D293 File Offset: 0x0004B493
		public void CleanHairAlfaTexture()
		{
			if (this.m_HairAlfaTextureBitmap != null)
			{
				this.m_HairAlfaTextureBitmap.Dispose();
			}
			this.m_HairAlfaTextureBitmap = null;
		}

		// Token: 0x06000BCD RID: 3021 RVA: 0x0004D2AF File Offset: 0x0004B4AF
		public Bitmap GetHairAlfaTexture()
		{
			if (this.m_HairAlfaTextureBitmap != null)
			{
				return this.m_HairAlfaTextureBitmap;
			}
			this.GetHairTextures();
			return this.m_HairAlfaTextureBitmap;
		}

		// Token: 0x06000BCE RID: 3022 RVA: 0x0004D2CD File Offset: 0x0004B4CD
		public void CleanHairTextures()
		{
			this.CleanHairColorTexture();
			this.CleanHairAlfaTexture();
		}

		// Token: 0x06000BCF RID: 3023 RVA: 0x0004D2DC File Offset: 0x0004B4DC
		public string GenericHairAlfaTextureFileName()
		{
			return "data/sceneassets/hair/hair_" + this.m_hairtypecode.ToString() + "_0_1_textures.rx3";
		}

		// Token: 0x06000BD0 RID: 3024 RVA: 0x0004D305 File Offset: 0x0004B505
		public Rx3File GetHeadModel()
		{
			if (this.m_HeadModelFile != null)
			{
				return this.m_HeadModelFile;
			}
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
			this.m_HeadModelFile = FifaEnvironment.GetRx3FromZdata(this.GenericHeadModelFileName());
			return this.m_HeadModelFile;
		}

		// Token: 0x06000BD1 RID: 3025 RVA: 0x0004D333 File Offset: 0x0004B533
		public void CleanHeadModel()
		{
			this.m_HeadModelFile = null;
		}

		// Token: 0x06000BD2 RID: 3026 RVA: 0x0004D33C File Offset: 0x0004B53C
		public void CleanHead()
		{
			this.CleanFaceTexture();
			this.CleanEyesTexture();
			this.CleanHeadModel();
		}

		// Token: 0x06000BD3 RID: 3027 RVA: 0x0004D350 File Offset: 0x0004B550
		public Rx3File GetHairModel()
		{
			if (this.m_HairModelFile != null)
			{
				return this.m_HairModelFile;
			}
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float16;
			this.m_HairModelFile = FifaEnvironment.GetRx3FromZdata(this.GenericHairModelFileName());
			return this.m_HairModelFile;
		}

		// Token: 0x06000BD4 RID: 3028 RVA: 0x0004D37E File Offset: 0x0004B57E
		public void CleanHairModel()
		{
			this.m_HairModelFile = null;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0004D387 File Offset: 0x0004B587
		public void CleanHair()
		{
			this.CleanHairModel();
			this.CleanHairTextures();
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0004D395 File Offset: 0x0004B595
		public void CleanAllHead()
		{
			this.CleanHair();
			this.CleanHead();
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0004D3A3 File Offset: 0x0004B5A3
		public static string PhotoBigFileName(int refereeId)
		{
			return "data/ui/artassets/referee/ref_" + refereeId.ToString() + ".big";
		}

		// Token: 0x06000BD8 RID: 3032 RVA: 0x0004D3BB File Offset: 0x0004B5BB
		public string PhotoBigFileName()
		{
			return Referee.PhotoBigFileName(base.Id);
		}

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0004D3C8 File Offset: 0x0004B5C8
		public string PhotoTemplateFileName()
		{
			return "data/ui/artassets/referee/ref_#.big";
		}

		// Token: 0x06000BDA RID: 3034 RVA: 0x0004D3CF File Offset: 0x0004B5CF
		public string PhotoDdsFileName()
		{
			return "2";
		}

		// Token: 0x06000BDB RID: 3035 RVA: 0x0004D3D6 File Offset: 0x0004B5D6
		public Bitmap GetPhoto()
		{
			return FifaEnvironment.GetArtasset(this.PhotoBigFileName());
		}

		// Token: 0x06000BDC RID: 3036 RVA: 0x0004D3E3 File Offset: 0x0004B5E3
		public bool SetPhoto(Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(this.PhotoTemplateFileName(), this.PhotoDdsFileName(), base.Id, bitmap);
		}

		// Token: 0x06000BDD RID: 3037 RVA: 0x0004D3FD File Offset: 0x0004B5FD
		public bool DeletePhoto()
		{
			return FifaEnvironment.DeleteFromZdata(this.PhotoBigFileName());
		}

		// Token: 0x06000BDE RID: 3038 RVA: 0x0004D40C File Offset: 0x0004B60C
		public void SaveReferee(Record r)
		{
			r.IntField[FI.referee_refereeid] = base.Id;
			r.IntField[FI.referee_birthdate] = FifaUtil.ConvertFromDate(this.m_birthdate);
			r.StringField[FI.referee_firstname] = this.m_firstname;
			r.StringField[FI.referee_surname] = this.m_surname;
			r.StringField[FI.referee_firstname] = this.m_firstname;
			r.StringField[FI.referee_surname] = this.m_surname;
			r.IntField[FI.referee_nationalitycode] = this.m_nationalitycode;
			r.IntField[FI.referee_leagueid] = this.GetMainLeague();
			r.IntField[FI.referee_height] = this.m_height;
			r.IntField[FI.referee_weight] = this.m_weight;
			r.IntField[FI.referee_bodytypecode] = this.m_bodytypecode + 1;
			r.IntField[FI.referee_shoedesigncode] = this.m_shoedesigncode;
			r.IntField[FI.referee_shoecolorcode1] = this.m_shoecolorcode1;
			r.IntField[FI.referee_shoecolorcode2] = this.m_shoecolorcode2;
			r.IntField[FI.referee_shoetypecode] = this.m_shoetypecode;
			r.IntField[FI.referee_jerseysleevelengthcode] = this.m_jerseysleevelengthcode;
			r.IntField[FI.referee_eyecolorcode] = this.m_eyecolorcode;
			r.IntField[FI.referee_eyebrowcode] = this.m_eyebrowcode;
			r.IntField[FI.referee_facialhairtypecode] = this.m_facialhairtypecode;
			r.IntField[FI.referee_facialhaircolorcode] = this.m_facialhaircolorcode;
			r.IntField[FI.referee_hairtypecode] = this.m_hairtypecode;
			r.IntField[FI.referee_haircolorcode] = this.m_haircolorcode;
			r.IntField[FI.referee_headtypecode] = this.m_headtypecode;
			r.IntField[FI.referee_headclasscode] = this.m_headclasscode;
			r.IntField[FI.referee_sideburnscode] = this.m_sideburnscode;
			r.IntField[FI.referee_skintypecode] = this.m_skintypecode;
			r.IntField[FI.referee_skintonecode] = this.m_skintonecode;
			r.IntField[FI.referee_stylecode] = this.m_stylecode;
			r.IntField[FI.referee_cardstrictness] = this.m_cardstrictness;
			r.IntField[FI.referee_foulstrictness] = this.m_foulstrictness;
			r.IntField[FI.referee_homecitycode] = this.m_homecitycode;
			r.IntField[FI.referee_sockheightcode] = this.m_sockheightcode;
			r.IntField[FI.referee_haireffecttypecode] = this.m_haireffecttypecode;
			r.IntField[FI.referee_hairlinecode] = this.m_hairlinecode;
			r.IntField[FI.referee_hairpartcode] = this.m_hairpartcode;
			r.IntField[FI.referee_hairstateid] = this.m_hairstateid;
			r.IntField[FI.referee_hairvariationid] = this.m_hairvariationid;
			r.IntField[FI.referee_sweatid] = this.m_sweatid;
			r.IntField[FI.referee_wrinkleid] = this.m_wrinkleid;
			r.IntField[FI.referee_proxyhaircolorid] = this.m_proxyhaircolorid;
			r.IntField[FI.referee_proxyheadclass] = this.m_proxyheadclass;
		}

		// Token: 0x06000BDF RID: 3039 RVA: 0x0004D702 File Offset: 0x0004B902
		public void SaveLeagueRefereeLinks(Record r, int index)
		{
			r.IntField[FI.leaguerefereelinks_refereeid] = base.Id;
			r.IntField[FI.leaguerefereelinks_leagueid] = this.m_leagueids[index];
		}

		// Token: 0x06000BE0 RID: 3040 RVA: 0x0004D72C File Offset: 0x0004B92C
		public void BuildHairPartsTextures()
		{
			if (this.m_HairColorTextureBitmap != null && this.m_HairAlfaTextureBitmap != null && this.m_HairColorTextureBitmap != null && this.m_HairAlfaTextureBitmap != null)
			{
				Bitmap bitmap = (Bitmap)this.m_HairColorTextureBitmap.Clone();
				GraphicUtil.GetAlfaFromChannel(bitmap, this.m_HairAlfaTextureBitmap, 2);
				Bitmap bitmap2 = (Bitmap)this.m_HairColorTextureBitmap.Clone();
				GraphicUtil.GetAlfaFromChannel(bitmap2, this.m_HairAlfaTextureBitmap, 1);
				return;
			}
		}

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0004D79C File Offset: 0x0004B99C
		public bool CreateHead3D(string xFileName)
		{
			this.BuildHairPartsTextures();
			Rx3File rx3File = this.GetHeadModel();
			if (this.m_FaceTextureBitmap == null || rx3File == null)
			{
				return false;
			}
			new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], this.m_FaceTextureBitmap);
			if (this.m_EyesTextureBitmap == null || rx3File == null)
			{
				return false;
			}
			new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], this.m_EyesTextureBitmap);
			rx3File = this.GetHairModel();
			if (this.m_FaceTextureBitmap == null || rx3File == null)
			{
				return false;
			}
			new Model3D(rx3File.Rx3IndexArrays[0], rx3File.Rx3VertexArrays[0], this.m_HairColorTextureBitmap);
			return true;
		}

		// Token: 0x06000BE2 RID: 3042 RVA: 0x0004D83C File Offset: 0x0004BA3C
		public void RandomizeCaucasianAppearance()
		{
			if (Referee.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Referee.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Referee.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			this.m_hairtypecode = this.c_RefereHair[Referee.m_Randomizer.Next(0, this.c_RefereHair.Length)];
			this.m_haircolorcode = Referee.m_Randomizer.Next(0, 8);
			this.m_sideburnscode = Referee.m_Randomizer.Next(0, 2);
			this.m_skintonecode = Referee.m_Randomizer.Next(1, 5);
			if (this.m_skintonecode == 1)
			{
				this.m_skintonecode = 2;
			}
			if (this.m_skintonecode == 3)
			{
				this.m_skintonecode = 2;
			}
			this.m_skintypecode = 2;
			this.m_eyecolorcode = Referee.m_Randomizer.Next(1, 8);
			this.m_facialhairtypecode = Referee.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			if (this.m_facialhairtypecode == 2)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = this.c_HairToFacial[this.m_haircolorcode];
		}

		// Token: 0x06000BE3 RID: 3043 RVA: 0x0004D978 File Offset: 0x0004BB78
		public void RandomizeAsiaticAppearance()
		{
			if (Referee.m_Randomizer.Next(1, 11) <= 9)
			{
				this.m_headtypecode = GenericHead.c_AsiaticModels[Referee.m_Randomizer.Next(0, GenericHead.c_AsiaticModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Referee.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			this.m_hairtypecode = this.c_RefereHair[Referee.m_Randomizer.Next(0, this.c_RefereHair.Length)];
			this.m_haircolorcode = Referee.m_Randomizer.Next(1, 6);
			if (this.m_haircolorcode == 2 || this.m_haircolorcode == 4)
			{
				this.m_haircolorcode = 1;
			}
			if (this.m_haircolorcode == 3)
			{
				this.m_haircolorcode = 1;
			}
			this.m_sideburnscode = Referee.m_Randomizer.Next(0, 2);
			this.m_skintonecode = Referee.m_Randomizer.Next(2, 7);
			if (this.m_skintonecode == 3)
			{
				this.m_skintonecode = 4;
			}
			this.m_skintypecode = 2;
			this.m_eyecolorcode = Referee.m_Randomizer.Next(3, 8);
			this.m_facialhairtypecode = Referee.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = this.c_HairToFacial[this.m_haircolorcode];
		}

		// Token: 0x06000BE4 RID: 3044 RVA: 0x0004DABC File Offset: 0x0004BCBC
		public void RandomizeAfricanAppearance()
		{
			if (Referee.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_AfricanModels[Referee.m_Randomizer.Next(0, GenericHead.c_AfricanModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Referee.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			this.m_hairtypecode = this.c_RefereHair[Referee.m_Randomizer.Next(0, this.c_RefereHair.Length)];
			this.m_haircolorcode = 1;
			this.m_sideburnscode = Referee.m_Randomizer.Next(0, 2);
			this.m_skintonecode = Referee.m_Randomizer.Next(6, 11);
			if (this.m_skintonecode == 7)
			{
				this.m_skintonecode = 8;
			}
			this.m_skintypecode = 2;
			this.m_eyecolorcode = Referee.m_Randomizer.Next(3, 5);
			this.m_facialhairtypecode = Referee.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			if (this.m_facialhairtypecode == 2)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = this.c_HairToFacial[this.m_haircolorcode];
		}

		// Token: 0x06000BE5 RID: 3045 RVA: 0x0004DBDC File Offset: 0x0004BDDC
		public void RandomizeLatinAppearance()
		{
			if (Referee.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Referee.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Referee.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			this.m_hairtypecode = this.c_RefereHair[Referee.m_Randomizer.Next(0, this.c_RefereHair.Length)];
			this.m_haircolorcode = 1;
			this.m_sideburnscode = Referee.m_Randomizer.Next(0, 2);
			this.m_skintonecode = Referee.m_Randomizer.Next(4, 7);
			this.m_skintypecode = 2;
			this.m_eyecolorcode = Referee.m_Randomizer.Next(3, 8);
			this.m_facialhairtypecode = Referee.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			if (this.m_facialhairtypecode == 2)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = this.c_HairToFacial[this.m_haircolorcode];
		}

		// Token: 0x04000FEA RID: 4074
		private static int c_MaxNLeagues = 8;

		// Token: 0x04000FEB RID: 4075
		private Bitmap m_EyesTextureBitmap;

		// Token: 0x04000FEC RID: 4076
		private Bitmap m_FaceTextureBitmap;

		// Token: 0x04000FED RID: 4077
		private Bitmap m_HairColorTextureBitmap;

		// Token: 0x04000FEE RID: 4078
		private Bitmap m_HairAlfaTextureBitmap;

		// Token: 0x04000FEF RID: 4079
		private Rx3File m_HeadModelFile;

		// Token: 0x04000FF0 RID: 4080
		private Rx3File m_HairModelFile;

		// Token: 0x04000FF1 RID: 4081
		private string m_firstname;

		// Token: 0x04000FF2 RID: 4082
		private string m_surname;

		// Token: 0x04000FF3 RID: 4083
		private DateTime m_birthdate;

		// Token: 0x04000FF4 RID: 4084
		public int m_refereeheadid_unused;

		// Token: 0x04000FF5 RID: 4085
		public bool m_isinternationalreferee;

		// Token: 0x04000FF6 RID: 4086
		private int m_nationalitycode;

		// Token: 0x04000FF7 RID: 4087
		private Country m_Country;

		// Token: 0x04000FF8 RID: 4088
		private int[] m_leagueids = new int[Referee.c_MaxNLeagues];

		// Token: 0x04000FF9 RID: 4089
		private League[] m_Leagues = new League[Referee.c_MaxNLeagues];

		// Token: 0x04000FFA RID: 4090
		private int m_height;

		// Token: 0x04000FFB RID: 4091
		private int m_weight;

		// Token: 0x04000FFC RID: 4092
		private int m_eyecolorcode;

		// Token: 0x04000FFD RID: 4093
		private int m_eyebrowcode;

		// Token: 0x04000FFE RID: 4094
		private int m_stylecode;

		// Token: 0x04000FFF RID: 4095
		private int m_cardstrictness;

		// Token: 0x04001000 RID: 4096
		private int m_foulstrictness;

		// Token: 0x04001001 RID: 4097
		private int m_homecitycode;

		// Token: 0x04001002 RID: 4098
		private int m_sockheightcode;

		// Token: 0x04001003 RID: 4099
		private int m_haireffecttypecode;

		// Token: 0x04001004 RID: 4100
		private int m_hairlinecode;

		// Token: 0x04001005 RID: 4101
		private int m_hairpartcode;

		// Token: 0x04001006 RID: 4102
		private int m_hairstateid;

		// Token: 0x04001007 RID: 4103
		private int m_hairvariationid;

		// Token: 0x04001008 RID: 4104
		private int m_sweatid;

		// Token: 0x04001009 RID: 4105
		private int m_wrinkleid;

		// Token: 0x0400100A RID: 4106
		private int m_proxyhaircolorid;

		// Token: 0x0400100B RID: 4107
		private int m_proxyheadclass;

		// Token: 0x0400100C RID: 4108
		private static Random m_Randomizer = new Random();

		// Token: 0x0400100D RID: 4109
		private int m_bodytypecode;

		// Token: 0x0400100E RID: 4110
		private int m_hairtypecode;

		// Token: 0x0400100F RID: 4111
		private int m_headtypecode;

		// Token: 0x04001010 RID: 4112
		private int m_headclasscode;

		// Token: 0x04001011 RID: 4113
		private int m_haircolorcode;

		// Token: 0x04001012 RID: 4114
		private int m_facialhairtypecode;

		// Token: 0x04001013 RID: 4115
		private int m_facialhaircolorcode;

		// Token: 0x04001014 RID: 4116
		private int m_sideburnscode;

		// Token: 0x04001015 RID: 4117
		private int m_skintypecode;

		// Token: 0x04001016 RID: 4118
		private int m_skintonecode;

		// Token: 0x04001017 RID: 4119
		private int m_jerseysleevelengthcode;

		// Token: 0x04001018 RID: 4120
		private int m_shoedesigncode;

		// Token: 0x04001019 RID: 4121
		private int m_shoecolorcode1;

		// Token: 0x0400101A RID: 4122
		private int m_shoecolorcode2;

		// Token: 0x0400101B RID: 4123
		private int m_shoetypecode;

		// Token: 0x0400101C RID: 4124
		private int[] c_HairToFacial = new int[] { 1, 0, 1, 0, 1, 3, 2, 4, 3, 3 };

		// Token: 0x0400101D RID: 4125
		private int[] c_RefereHair = new int[]
		{
			0, 1, 2, 8, 13, 14, 16, 19, 20, 21,
			22, 23, 24, 25, 26, 28, 29, 30, 31, 32,
			35, 36, 37, 38, 40, 41, 43, 45, 46, 47,
			54, 57, 58, 59, 62, 64, 65, 66, 67, 69,
			70, 72, 73, 74, 75, 77, 78, 82, 83, 85,
			86, 87, 88, 89, 90, 92, 93, 95, 98, 99,
			100, 101, 102, 103, 104, 105, 106, 107, 108
		};
	}
}
