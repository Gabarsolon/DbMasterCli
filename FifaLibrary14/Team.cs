using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x020000A9 RID: 169
	public class Team : IdObject
	{
		// Token: 0x06000C69 RID: 3177 RVA: 0x00050884 File Offset: 0x0004EA84
		public bool IsInTopLeague()
		{
			if (this.m_League == null)
			{
				return false;
			}
			for (int i = 0; i < Team.c_TopLeaguesId.Length; i++)
			{
				if (this.m_League.Id == Team.c_TopLeaguesId[i])
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x17000298 RID: 664
		// (get) Token: 0x06000C6A RID: 3178 RVA: 0x000508C4 File Offset: 0x0004EAC4
		// (set) Token: 0x06000C6B RID: 3179 RVA: 0x000508CC File Offset: 0x0004EACC
		public bool ImpatientBoard
		{
			get
			{
				return this.m_ImpatientBoard;
			}
			set
			{
				this.m_ImpatientBoard = value;
			}
		}

		// Token: 0x17000299 RID: 665
		// (get) Token: 0x06000C6C RID: 3180 RVA: 0x000508D5 File Offset: 0x0004EAD5
		// (set) Token: 0x06000C6D RID: 3181 RVA: 0x000508DD File Offset: 0x0004EADD
		public bool LoyalBoard
		{
			get
			{
				return this.m_LoyalBoard;
			}
			set
			{
				this.m_LoyalBoard = value;
			}
		}

		// Token: 0x1700029A RID: 666
		// (get) Token: 0x06000C6E RID: 3182 RVA: 0x000508E6 File Offset: 0x0004EAE6
		// (set) Token: 0x06000C6F RID: 3183 RVA: 0x000508EE File Offset: 0x0004EAEE
		public bool SquadRotation
		{
			get
			{
				return this.m_SquadRotation;
			}
			set
			{
				this.m_SquadRotation = value;
			}
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06000C70 RID: 3184 RVA: 0x000508F7 File Offset: 0x0004EAF7
		// (set) Token: 0x06000C71 RID: 3185 RVA: 0x000508FF File Offset: 0x0004EAFF
		public bool ConsistentLineup
		{
			get
			{
				return this.m_ConsistentLineup;
			}
			set
			{
				this.m_ConsistentLineup = value;
			}
		}

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x06000C72 RID: 3186 RVA: 0x00050908 File Offset: 0x0004EB08
		// (set) Token: 0x06000C73 RID: 3187 RVA: 0x00050910 File Offset: 0x0004EB10
		public bool SwitchWingers
		{
			get
			{
				return this.m_SwitchWingers;
			}
			set
			{
				this.m_SwitchWingers = value;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x06000C74 RID: 3188 RVA: 0x00050919 File Offset: 0x0004EB19
		// (set) Token: 0x06000C75 RID: 3189 RVA: 0x00050921 File Offset: 0x0004EB21
		public bool CenterBacksSplit
		{
			get
			{
				return this.m_CenterBacksSplit;
			}
			set
			{
				this.m_CenterBacksSplit = value;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x06000C76 RID: 3190 RVA: 0x0005092A File Offset: 0x0004EB2A
		// (set) Token: 0x06000C77 RID: 3191 RVA: 0x00050932 File Offset: 0x0004EB32
		public bool DefendLead
		{
			get
			{
				return this.m_DefendLead;
			}
			set
			{
				this.m_DefendLead = value;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x06000C78 RID: 3192 RVA: 0x0005093B File Offset: 0x0004EB3B
		// (set) Token: 0x06000C79 RID: 3193 RVA: 0x00050943 File Offset: 0x0004EB43
		public bool KeepUpPressure
		{
			get
			{
				return this.m_KeepUpPressure;
			}
			set
			{
				this.m_KeepUpPressure = value;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x06000C7A RID: 3194 RVA: 0x0005094C File Offset: 0x0004EB4C
		// (set) Token: 0x06000C7B RID: 3195 RVA: 0x00050954 File Offset: 0x0004EB54
		public bool MoreAttackingAtHome
		{
			get
			{
				return this.m_MoreAttackingAtHome;
			}
			set
			{
				this.m_MoreAttackingAtHome = value;
			}
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06000C7C RID: 3196 RVA: 0x0005095D File Offset: 0x0004EB5D
		// (set) Token: 0x06000C7D RID: 3197 RVA: 0x00050965 File Offset: 0x0004EB65
		public bool ShortOutBack
		{
			get
			{
				return this.m_ShortOutBack;
			}
			set
			{
				this.m_ShortOutBack = value;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06000C7E RID: 3198 RVA: 0x0005096E File Offset: 0x0004EB6E
		// (set) Token: 0x06000C7F RID: 3199 RVA: 0x00050976 File Offset: 0x0004EB76
		public int balltype
		{
			get
			{
				return this.m_balltype;
			}
			set
			{
				this.m_balltype = value;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06000C80 RID: 3200 RVA: 0x0005097F File Offset: 0x0004EB7F
		// (set) Token: 0x06000C81 RID: 3201 RVA: 0x00050987 File Offset: 0x0004EB87
		public int adboardid
		{
			get
			{
				return this.m_adboardid;
			}
			set
			{
				this.m_adboardid = value;
			}
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06000C82 RID: 3202 RVA: 0x00050990 File Offset: 0x0004EB90
		// (set) Token: 0x06000C83 RID: 3203 RVA: 0x00050998 File Offset: 0x0004EB98
		public int stadiumid
		{
			get
			{
				return this.m_stadiumid;
			}
			set
			{
				this.m_stadiumid = value;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x06000C84 RID: 3204 RVA: 0x000509A1 File Offset: 0x0004EBA1
		// (set) Token: 0x06000C85 RID: 3205 RVA: 0x000509A9 File Offset: 0x0004EBA9
		public Stadium Stadium
		{
			get
			{
				return this.m_Stadium;
			}
			set
			{
				this.m_Stadium = value;
				if (this.m_Stadium != null)
				{
					this.m_stadiumid = this.m_Stadium.Id;
				}
			}
		}

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06000C86 RID: 3206 RVA: 0x000509CB File Offset: 0x0004EBCB
		// (set) Token: 0x06000C87 RID: 3207 RVA: 0x000509D3 File Offset: 0x0004EBD3
		public int rivalteam
		{
			get
			{
				return this.m_rivalteam;
			}
			set
			{
				this.m_rivalteam = value;
			}
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x000509DC File Offset: 0x0004EBDC
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x000509E4 File Offset: 0x0004EBE4
		public Team RivalTeam
		{
			get
			{
				return this.m_RivalTeam;
			}
			set
			{
				this.m_RivalTeam = value;
				if (this.m_RivalTeam != null)
				{
					this.m_rivalteam = this.m_RivalTeam.Id;
				}
			}
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00050A06 File Offset: 0x0004EC06
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00050A0E File Offset: 0x0004EC0E
		public int formationid
		{
			get
			{
				return this.m_formationid;
			}
			set
			{
				this.m_formationid = value;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00050A17 File Offset: 0x0004EC17
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00050A1F File Offset: 0x0004EC1F
		public Formation Formation
		{
			get
			{
				return this.m_Formation;
			}
			set
			{
				this.m_Formation = value;
				if (this.m_Formation != null)
				{
					this.m_formationid = this.m_Formation.Id;
				}
			}
		}

		// Token: 0x170002AA RID: 682
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00050A41 File Offset: 0x0004EC41
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00050A49 File Offset: 0x0004EC49
		public int captainid
		{
			get
			{
				return this.m_captainid;
			}
			set
			{
				this.m_captainid = value;
			}
		}

		// Token: 0x170002AB RID: 683
		// (get) Token: 0x06000C90 RID: 3216 RVA: 0x00050A52 File Offset: 0x0004EC52
		// (set) Token: 0x06000C91 RID: 3217 RVA: 0x00050A5A File Offset: 0x0004EC5A
		public int penaltytakerid
		{
			get
			{
				return this.m_penaltytakerid;
			}
			set
			{
				this.m_penaltytakerid = value;
			}
		}

		// Token: 0x170002AC RID: 684
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x00050A63 File Offset: 0x0004EC63
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x00050A6B File Offset: 0x0004EC6B
		public int freekicktakerid
		{
			get
			{
				return this.m_freekicktakerid;
			}
			set
			{
				this.m_freekicktakerid = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x06000C94 RID: 3220 RVA: 0x00050A74 File Offset: 0x0004EC74
		// (set) Token: 0x06000C95 RID: 3221 RVA: 0x00050A7C File Offset: 0x0004EC7C
		public int longkicktakerid
		{
			get
			{
				return this.m_longkicktakerid;
			}
			set
			{
				this.m_longkicktakerid = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x00050A85 File Offset: 0x0004EC85
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x00050A8D File Offset: 0x0004EC8D
		public int leftcornerkicktakerid
		{
			get
			{
				return this.m_leftcornerkicktakerid;
			}
			set
			{
				this.m_leftcornerkicktakerid = value;
			}
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000C98 RID: 3224 RVA: 0x00050A96 File Offset: 0x0004EC96
		// (set) Token: 0x06000C99 RID: 3225 RVA: 0x00050A9E File Offset: 0x0004EC9E
		public int rightcornerkicktakerid
		{
			get
			{
				return this.m_rightcornerkicktakerid;
			}
			set
			{
				this.m_rightcornerkicktakerid = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x00050AA7 File Offset: 0x0004ECA7
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x00050AAF File Offset: 0x0004ECAF
		public string TeamNameFull
		{
			get
			{
				return this.m_TeamNameFull;
			}
			set
			{
				this.m_TeamNameFull = value;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x00050AB8 File Offset: 0x0004ECB8
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x00050AC0 File Offset: 0x0004ECC0
		public string TeamNameAbbr15
		{
			get
			{
				return this.m_TeamNameAbbr15;
			}
			set
			{
				this.m_TeamNameAbbr15 = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x00050AC9 File Offset: 0x0004ECC9
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x00050AD1 File Offset: 0x0004ECD1
		public string TeamNameAbbr10
		{
			get
			{
				return this.m_TeamNameAbbr10;
			}
			set
			{
				this.m_TeamNameAbbr10 = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x06000CA0 RID: 3232 RVA: 0x00050ADA File Offset: 0x0004ECDA
		// (set) Token: 0x06000CA1 RID: 3233 RVA: 0x00050AE2 File Offset: 0x0004ECE2
		public string TeamNameAbbr3
		{
			get
			{
				return this.m_TeamNameAbbr3;
			}
			set
			{
				this.m_TeamNameAbbr3 = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x06000CA2 RID: 3234 RVA: 0x00050AEB File Offset: 0x0004ECEB
		// (set) Token: 0x06000CA3 RID: 3235 RVA: 0x00050AF3 File Offset: 0x0004ECF3
		public string DatabaseName
		{
			get
			{
				return this.m_teamname;
			}
			set
			{
				this.m_teamname = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x06000CA4 RID: 3236 RVA: 0x00050AFC File Offset: 0x0004ECFC
		// (set) Token: 0x06000CA5 RID: 3237 RVA: 0x00050B04 File Offset: 0x0004ED04
		public int jerseytype
		{
			get
			{
				return this.m_jerseytype;
			}
			set
			{
				this.m_jerseytype = value;
			}
		}

		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06000CA6 RID: 3238 RVA: 0x00050B0D File Offset: 0x0004ED0D
		// (set) Token: 0x06000CA7 RID: 3239 RVA: 0x00050B15 File Offset: 0x0004ED15
		public int stafftracksuitcolorcode
		{
			get
			{
				return this.m_stafftracksuitcolorcode;
			}
			set
			{
				this.m_stafftracksuitcolorcode = value;
			}
		}

		// Token: 0x170002B7 RID: 695
		// (get) Token: 0x06000CA8 RID: 3240 RVA: 0x00050B1E File Offset: 0x0004ED1E
		// (set) Token: 0x06000CA9 RID: 3241 RVA: 0x00050B26 File Offset: 0x0004ED26
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

		// Token: 0x170002B8 RID: 696
		// (get) Token: 0x06000CAA RID: 3242 RVA: 0x00050B2F File Offset: 0x0004ED2F
		// (set) Token: 0x06000CAB RID: 3243 RVA: 0x00050B37 File Offset: 0x0004ED37
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

		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x06000CAC RID: 3244 RVA: 0x00050B40 File Offset: 0x0004ED40
		// (set) Token: 0x06000CAD RID: 3245 RVA: 0x00050B48 File Offset: 0x0004ED48
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

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x00050B51 File Offset: 0x0004ED51
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x00050B59 File Offset: 0x0004ED59
		public int managerid
		{
			get
			{
				return this.m_managerid;
			}
			set
			{
				this.m_managerid = value;
			}
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x06000CB0 RID: 3248 RVA: 0x00050B62 File Offset: 0x0004ED62
		// (set) Token: 0x06000CB1 RID: 3249 RVA: 0x00050B6A File Offset: 0x0004ED6A
		public int latitude
		{
			get
			{
				return this.m_latitude;
			}
			set
			{
				this.m_latitude = value;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x06000CB2 RID: 3250 RVA: 0x00050B73 File Offset: 0x0004ED73
		// (set) Token: 0x06000CB3 RID: 3251 RVA: 0x00050B7B File Offset: 0x0004ED7B
		public int longitude
		{
			get
			{
				return this.m_longitude;
			}
			set
			{
				this.m_longitude = value;
			}
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x06000CB4 RID: 3252 RVA: 0x00050B84 File Offset: 0x0004ED84
		// (set) Token: 0x06000CB5 RID: 3253 RVA: 0x00050B8C File Offset: 0x0004ED8C
		public int bodytypeid
		{
			get
			{
				return this.m_bodytypeid;
			}
			set
			{
				this.m_bodytypeid = value;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x06000CB6 RID: 3254 RVA: 0x00050B95 File Offset: 0x0004ED95
		// (set) Token: 0x06000CB7 RID: 3255 RVA: 0x00050B9D File Offset: 0x0004ED9D
		public int suitvariationid
		{
			get
			{
				return this.m_suitvariationid;
			}
			set
			{
				this.m_suitvariationid = value;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x06000CB8 RID: 3256 RVA: 0x00050BA6 File Offset: 0x0004EDA6
		// (set) Token: 0x06000CB9 RID: 3257 RVA: 0x00050BAE File Offset: 0x0004EDAE
		public int suittypeid
		{
			get
			{
				return this.m_suittypeid;
			}
			set
			{
				this.m_suittypeid = value;
			}
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x00050BB7 File Offset: 0x0004EDB7
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x00050BBF File Offset: 0x0004EDBF
		public int personalityid
		{
			get
			{
				return this.m_personalityid;
			}
			set
			{
				this.m_personalityid = value;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06000CBC RID: 3260 RVA: 0x00050BC8 File Offset: 0x0004EDC8
		// (set) Token: 0x06000CBD RID: 3261 RVA: 0x00050BD0 File Offset: 0x0004EDD0
		public int busdribbling
		{
			get
			{
				return this.m_busdribbling;
			}
			set
			{
				this.m_busdribbling = value;
			}
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x00050BD9 File Offset: 0x0004EDD9
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x00050BE1 File Offset: 0x0004EDE1
		public int trait1
		{
			get
			{
				return this.m_trait1;
			}
			set
			{
				this.m_trait1 = value;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06000CC0 RID: 3264 RVA: 0x00050BEA File Offset: 0x0004EDEA
		// (set) Token: 0x06000CC1 RID: 3265 RVA: 0x00050BF2 File Offset: 0x0004EDF2
		public int utcoffset
		{
			get
			{
				return this.m_utcoffset;
			}
			set
			{
				this.m_utcoffset = value;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x00050BFB File Offset: 0x0004EDFB
		// (set) Token: 0x06000CC3 RID: 3267 RVA: 0x00050C03 File Offset: 0x0004EE03
		public int ethnicity
		{
			get
			{
				return this.m_ethnicity;
			}
			set
			{
				this.m_ethnicity = value;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00050C0C File Offset: 0x0004EE0C
		// (set) Token: 0x06000CC5 RID: 3269 RVA: 0x00050C14 File Offset: 0x0004EE14
		public int assetid
		{
			get
			{
				return this.m_assetid;
			}
			set
			{
				this.m_assetid = value;
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x06000CC6 RID: 3270 RVA: 0x00050C1D File Offset: 0x0004EE1D
		// (set) Token: 0x06000CC7 RID: 3271 RVA: 0x00050C25 File Offset: 0x0004EE25
		public int transferbudget
		{
			get
			{
				return this.m_transferbudget;
			}
			set
			{
				this.m_transferbudget = value;
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x06000CC8 RID: 3272 RVA: 0x00050C2E File Offset: 0x0004EE2E
		// (set) Token: 0x06000CC9 RID: 3273 RVA: 0x00050C36 File Offset: 0x0004EE36
		public int internationalprestige
		{
			get
			{
				return this.m_internationalprestige;
			}
			set
			{
				this.m_internationalprestige = value;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000CCA RID: 3274 RVA: 0x00050C3F File Offset: 0x0004EE3F
		// (set) Token: 0x06000CCB RID: 3275 RVA: 0x00050C47 File Offset: 0x0004EE47
		public int domesticprestige
		{
			get
			{
				return this.m_domesticprestige;
			}
			set
			{
				this.m_domesticprestige = value;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000CCC RID: 3276 RVA: 0x00050C50 File Offset: 0x0004EE50
		// (set) Token: 0x06000CCD RID: 3277 RVA: 0x00050C58 File Offset: 0x0004EE58
		public string stadiumcustomname
		{
			get
			{
				return this.m_stadiumcustomname;
			}
			set
			{
				this.m_stadiumcustomname = value;
			}
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x00050C61 File Offset: 0x0004EE61
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x00050C69 File Offset: 0x0004EE69
		public string ManagerFirstName
		{
			get
			{
				return this.m_ManagerFirstName;
			}
			set
			{
				this.m_ManagerFirstName = value;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00050C72 File Offset: 0x0004EE72
		// (set) Token: 0x06000CD1 RID: 3281 RVA: 0x00050C7A File Offset: 0x0004EE7A
		public string ManagerSurname
		{
			get
			{
				return this.m_ManagerSurname;
			}
			set
			{
				this.m_ManagerSurname = value;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00050C83 File Offset: 0x0004EE83
		// (set) Token: 0x06000CD3 RID: 3283 RVA: 0x00050C8B File Offset: 0x0004EE8B
		public int busbuildupspeed
		{
			get
			{
				return this.m_busbuildupspeed;
			}
			set
			{
				this.m_busbuildupspeed = value;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000CD4 RID: 3284 RVA: 0x00050C94 File Offset: 0x0004EE94
		// (set) Token: 0x06000CD5 RID: 3285 RVA: 0x00050C9C File Offset: 0x0004EE9C
		public int buspassing
		{
			get
			{
				return this.m_buspassing;
			}
			set
			{
				this.m_buspassing = value;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000CD6 RID: 3286 RVA: 0x00050CA5 File Offset: 0x0004EEA5
		// (set) Token: 0x06000CD7 RID: 3287 RVA: 0x00050CAD File Offset: 0x0004EEAD
		public int buspositioning
		{
			get
			{
				return this.m_buspositioning;
			}
			set
			{
				this.m_buspositioning = value;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000CD8 RID: 3288 RVA: 0x00050CB6 File Offset: 0x0004EEB6
		// (set) Token: 0x06000CD9 RID: 3289 RVA: 0x00050CBE File Offset: 0x0004EEBE
		public int ccpassing
		{
			get
			{
				return this.m_ccpassing;
			}
			set
			{
				this.m_ccpassing = value;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00050CC7 File Offset: 0x0004EEC7
		// (set) Token: 0x06000CDB RID: 3291 RVA: 0x00050CCF File Offset: 0x0004EECF
		public int cccrossing
		{
			get
			{
				return this.m_cccrossing;
			}
			set
			{
				this.m_cccrossing = value;
			}
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000CDC RID: 3292 RVA: 0x00050CD8 File Offset: 0x0004EED8
		// (set) Token: 0x06000CDD RID: 3293 RVA: 0x00050CE0 File Offset: 0x0004EEE0
		public int ccshooting
		{
			get
			{
				return this.m_ccshooting;
			}
			set
			{
				this.m_ccshooting = value;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000CDE RID: 3294 RVA: 0x00050CE9 File Offset: 0x0004EEE9
		// (set) Token: 0x06000CDF RID: 3295 RVA: 0x00050CF1 File Offset: 0x0004EEF1
		public int ccpositioning
		{
			get
			{
				return this.m_ccpositioning;
			}
			set
			{
				this.m_ccpositioning = value;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x06000CE0 RID: 3296 RVA: 0x00050CFA File Offset: 0x0004EEFA
		// (set) Token: 0x06000CE1 RID: 3297 RVA: 0x00050D02 File Offset: 0x0004EF02
		public int defmentality
		{
			get
			{
				return this.m_defmentality;
			}
			set
			{
				this.m_defmentality = value;
			}
		}

		// Token: 0x170002D4 RID: 724
		// (get) Token: 0x06000CE2 RID: 3298 RVA: 0x00050D0B File Offset: 0x0004EF0B
		// (set) Token: 0x06000CE3 RID: 3299 RVA: 0x00050D13 File Offset: 0x0004EF13
		public int defaggression
		{
			get
			{
				return this.m_defaggression;
			}
			set
			{
				this.m_defaggression = value;
			}
		}

		// Token: 0x170002D5 RID: 725
		// (get) Token: 0x06000CE4 RID: 3300 RVA: 0x00050D1C File Offset: 0x0004EF1C
		// (set) Token: 0x06000CE5 RID: 3301 RVA: 0x00050D24 File Offset: 0x0004EF24
		public int defteamwidth
		{
			get
			{
				return this.m_defteamwidth;
			}
			set
			{
				this.m_defteamwidth = value;
			}
		}

		// Token: 0x170002D6 RID: 726
		// (get) Token: 0x06000CE6 RID: 3302 RVA: 0x00050D2D File Offset: 0x0004EF2D
		// (set) Token: 0x06000CE7 RID: 3303 RVA: 0x00050D35 File Offset: 0x0004EF35
		public int defdefenderline
		{
			get
			{
				return this.m_defdefenderline;
			}
			set
			{
				this.m_defdefenderline = value;
			}
		}

		// Token: 0x170002D7 RID: 727
		// (get) Token: 0x06000CE8 RID: 3304 RVA: 0x00050D3E File Offset: 0x0004EF3E
		// (set) Token: 0x06000CE9 RID: 3305 RVA: 0x00050D46 File Offset: 0x0004EF46
		public int midfieldrating
		{
			get
			{
				return this.m_midfieldrating;
			}
			set
			{
				this.m_midfieldrating = value;
			}
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000CEA RID: 3306 RVA: 0x00050D4F File Offset: 0x0004EF4F
		// (set) Token: 0x06000CEB RID: 3307 RVA: 0x00050D57 File Offset: 0x0004EF57
		public int defenserating
		{
			get
			{
				return this.m_defenserating;
			}
			set
			{
				this.m_defenserating = value;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000CEC RID: 3308 RVA: 0x00050D60 File Offset: 0x0004EF60
		// (set) Token: 0x06000CED RID: 3309 RVA: 0x00050D68 File Offset: 0x0004EF68
		public int attackrating
		{
			get
			{
				return this.m_attackrating;
			}
			set
			{
				this.m_attackrating = value;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000CEE RID: 3310 RVA: 0x00050D71 File Offset: 0x0004EF71
		// (set) Token: 0x06000CEF RID: 3311 RVA: 0x00050D79 File Offset: 0x0004EF79
		public int overallrating
		{
			get
			{
				return this.m_overallrating;
			}
			set
			{
				this.m_overallrating = value;
			}
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x00050D82 File Offset: 0x0004EF82
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x00050D8A File Offset: 0x0004EF8A
		public int matchdayoverallrating
		{
			get
			{
				return this.m_matchdayoverallrating;
			}
			set
			{
				this.m_matchdayoverallrating = value;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x00050D93 File Offset: 0x0004EF93
		// (set) Token: 0x06000CF3 RID: 3315 RVA: 0x00050D9B File Offset: 0x0004EF9B
		public int matchdaydefenserating
		{
			get
			{
				return this.m_matchdaydefenserating;
			}
			set
			{
				this.m_matchdaydefenserating = value;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x06000CF4 RID: 3316 RVA: 0x00050DA4 File Offset: 0x0004EFA4
		// (set) Token: 0x06000CF5 RID: 3317 RVA: 0x00050DAC File Offset: 0x0004EFAC
		public int matchdaymidfieldrating
		{
			get
			{
				return this.m_matchdaymidfieldrating;
			}
			set
			{
				this.m_matchdaymidfieldrating = value;
			}
		}

		// Token: 0x170002DE RID: 734
		// (get) Token: 0x06000CF6 RID: 3318 RVA: 0x00050DB5 File Offset: 0x0004EFB5
		// (set) Token: 0x06000CF7 RID: 3319 RVA: 0x00050DBD File Offset: 0x0004EFBD
		public int matchdayattackrating
		{
			get
			{
				return this.m_matchdayattackrating;
			}
			set
			{
				this.m_matchdayattackrating = value;
			}
		}

		// Token: 0x170002DF RID: 735
		// (get) Token: 0x06000CF8 RID: 3320 RVA: 0x00050DC6 File Offset: 0x0004EFC6
		public Roster Roster
		{
			get
			{
				return this.m_Roster;
			}
		}

		// Token: 0x170002E0 RID: 736
		// (get) Token: 0x06000CF9 RID: 3321 RVA: 0x00050DCE File Offset: 0x0004EFCE
		// (set) Token: 0x06000CFA RID: 3322 RVA: 0x00050DD8 File Offset: 0x0004EFD8
		public Country Country
		{
			get
			{
				return this.m_Country;
			}
			set
			{
				if (this.IsNationalTeam())
				{
					if (this.m_Country == value)
					{
						return;
					}
					if (this.m_Country != null)
					{
						this.m_Country.NationalTeam = null;
					}
				}
				if (value != null)
				{
					this.m_Country = value;
					this.m_countryid_IfRowTeam = this.m_Country.Id;
					return;
				}
				this.m_Country = value;
				this.m_countryid_IfRowTeam = 0;
			}
		}

		// Token: 0x06000CFB RID: 3323 RVA: 0x00050E37 File Offset: 0x0004F037
		public void SetAsNationalTeam(Country country)
		{
			this.m_Country = country;
			this.m_countryid_IfNationalTeam = country.Id;
			this.m_countryid_IfRowTeam = 0;
		}

		// Token: 0x06000CFC RID: 3324 RVA: 0x00050E53 File Offset: 0x0004F053
		public void UnsetAsNationalTeam(int nationalTeamId)
		{
			this.m_countryid_IfRowTeam = this.m_countryid_IfNationalTeam;
			this.m_countryid_IfNationalTeam = 0;
		}

		// Token: 0x06000CFD RID: 3325 RVA: 0x00050E68 File Offset: 0x0004F068
		public bool IsNationalTeam()
		{
			return this.m_countryid_IfNationalTeam != 0;
		}

		// Token: 0x06000CFE RID: 3326 RVA: 0x00050E76 File Offset: 0x0004F076
		public bool IsClub()
		{
			return !this.IsNationalTeam() && base.Id != 111072 && base.Id != 111205;
		}

		// Token: 0x170002E1 RID: 737
		// (get) Token: 0x06000CFF RID: 3327 RVA: 0x00050E9F File Offset: 0x0004F09F
		// (set) Token: 0x06000D00 RID: 3328 RVA: 0x00050EA7 File Offset: 0x0004F0A7
		public League League
		{
			get
			{
				return this.m_League;
			}
			set
			{
				if (value == null)
				{
					this.m_League = League.GetDefaultLeague();
					this.m_leagueid = League.GetDefaultLeagueId();
					return;
				}
				this.m_League = value;
				this.m_leagueid = this.m_League.Id;
			}
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x06000D01 RID: 3329 RVA: 0x00050EDB File Offset: 0x0004F0DB
		// (set) Token: 0x06000D02 RID: 3330 RVA: 0x00050EE3 File Offset: 0x0004F0E3
		public League PrevLeague
		{
			get
			{
				return this.m_PrevLeague;
			}
			set
			{
				if (value == null)
				{
					this.m_PrevLeague = null;
					this.m_prevleagueid = 0;
					return;
				}
				this.m_PrevLeague = value;
				this.m_prevleagueid = this.m_PrevLeague.Id;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x06000D03 RID: 3331 RVA: 0x00050F0F File Offset: 0x0004F10F
		// (set) Token: 0x06000D04 RID: 3332 RVA: 0x00050F17 File Offset: 0x0004F117
		public bool IsChampion
		{
			get
			{
				return this.m_champion;
			}
			set
			{
				this.m_champion = value;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x06000D05 RID: 3333 RVA: 0x00050F20 File Offset: 0x0004F120
		// (set) Token: 0x06000D06 RID: 3334 RVA: 0x00050F28 File Offset: 0x0004F128
		public int previousyeartableposition
		{
			get
			{
				return this.m_previousyeartableposition;
			}
			set
			{
				this.m_previousyeartableposition = value;
			}
		}

		// Token: 0x170002E5 RID: 741
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00050F31 File Offset: 0x0004F131
		// (set) Token: 0x06000D08 RID: 3336 RVA: 0x00050F39 File Offset: 0x0004F139
		public int currenttableposition
		{
			get
			{
				return this.m_currenttableposition;
			}
			set
			{
				this.m_currenttableposition = value;
			}
		}

		// Token: 0x170002E6 RID: 742
		// (get) Token: 0x06000D09 RID: 3337 RVA: 0x00050F42 File Offset: 0x0004F142
		// (set) Token: 0x06000D0A RID: 3338 RVA: 0x00050F4A File Offset: 0x0004F14A
		public int teamshortform
		{
			get
			{
				return this.m_teamshortform;
			}
			set
			{
				this.m_teamshortform = value;
			}
		}

		// Token: 0x170002E7 RID: 743
		// (get) Token: 0x06000D0B RID: 3339 RVA: 0x00050F53 File Offset: 0x0004F153
		// (set) Token: 0x06000D0C RID: 3340 RVA: 0x00050F5B File Offset: 0x0004F15B
		public int teamlongform
		{
			get
			{
				return this.m_teamlongform;
			}
			set
			{
				this.m_teamlongform = value;
			}
		}

		// Token: 0x170002E8 RID: 744
		// (get) Token: 0x06000D0D RID: 3341 RVA: 0x00050F64 File Offset: 0x0004F164
		// (set) Token: 0x06000D0E RID: 3342 RVA: 0x00050F6C File Offset: 0x0004F16C
		public int teamform
		{
			get
			{
				return this.m_teamform;
			}
			set
			{
				this.m_teamform = value;
			}
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x00050F75 File Offset: 0x0004F175
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x00050F7D File Offset: 0x0004F17D
		public bool hasachievedobjective
		{
			get
			{
				return this.m_hasachievedobjective;
			}
			set
			{
				this.m_hasachievedobjective = value;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06000D11 RID: 3345 RVA: 0x00050F86 File Offset: 0x0004F186
		// (set) Token: 0x06000D12 RID: 3346 RVA: 0x00050F8E File Offset: 0x0004F18E
		public bool yettowin
		{
			get
			{
				return this.m_yettowin;
			}
			set
			{
				this.m_yettowin = value;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x06000D13 RID: 3347 RVA: 0x00050F97 File Offset: 0x0004F197
		// (set) Token: 0x06000D14 RID: 3348 RVA: 0x00050F9F File Offset: 0x0004F19F
		public bool unbeatenallcomps
		{
			get
			{
				return this.m_unbeatenallcomps;
			}
			set
			{
				this.m_unbeatenallcomps = value;
			}
		}

		// Token: 0x170002EC RID: 748
		// (get) Token: 0x06000D15 RID: 3349 RVA: 0x00050FA8 File Offset: 0x0004F1A8
		// (set) Token: 0x06000D16 RID: 3350 RVA: 0x00050FB0 File Offset: 0x0004F1B0
		public bool unbeatenaway
		{
			get
			{
				return this.m_unbeatenaway;
			}
			set
			{
				this.m_unbeatenaway = value;
			}
		}

		// Token: 0x170002ED RID: 749
		// (get) Token: 0x06000D17 RID: 3351 RVA: 0x00050FB9 File Offset: 0x0004F1B9
		// (set) Token: 0x06000D18 RID: 3352 RVA: 0x00050FC1 File Offset: 0x0004F1C1
		public bool unbeatenhome
		{
			get
			{
				return this.m_unbeatenhome;
			}
			set
			{
				this.m_unbeatenhome = value;
			}
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000D19 RID: 3353 RVA: 0x00050FCA File Offset: 0x0004F1CA
		// (set) Token: 0x06000D1A RID: 3354 RVA: 0x00050FD2 File Offset: 0x0004F1D2
		public bool unbeatenleague
		{
			get
			{
				return this.m_unbeatenleague;
			}
			set
			{
				this.m_unbeatenleague = value;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00050FDB File Offset: 0x0004F1DB
		// (set) Token: 0x06000D1C RID: 3356 RVA: 0x00050FE3 File Offset: 0x0004F1E3
		public int highestpossible
		{
			get
			{
				return this.m_highestpossible;
			}
			set
			{
				this.m_highestpossible = value;
			}
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x06000D1D RID: 3357 RVA: 0x00050FEC File Offset: 0x0004F1EC
		// (set) Token: 0x06000D1E RID: 3358 RVA: 0x00050FF4 File Offset: 0x0004F1F4
		public int highestprobable
		{
			get
			{
				return this.m_highestprobable;
			}
			set
			{
				this.m_highestprobable = value;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x06000D1F RID: 3359 RVA: 0x00050FFD File Offset: 0x0004F1FD
		// (set) Token: 0x06000D20 RID: 3360 RVA: 0x00051005 File Offset: 0x0004F205
		public int nummatchesplayed
		{
			get
			{
				return this.m_nummatchesplayed;
			}
			set
			{
				this.m_nummatchesplayed = value;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x06000D21 RID: 3361 RVA: 0x0005100E File Offset: 0x0004F20E
		// (set) Token: 0x06000D22 RID: 3362 RVA: 0x00051016 File Offset: 0x0004F216
		public int gapresult
		{
			get
			{
				return this.m_gapresult;
			}
			set
			{
				this.m_gapresult = value;
			}
		}

		// Token: 0x170002F3 RID: 755
		// (get) Token: 0x06000D23 RID: 3363 RVA: 0x0005101F File Offset: 0x0004F21F
		// (set) Token: 0x06000D24 RID: 3364 RVA: 0x00051027 File Offset: 0x0004F227
		public int grouping
		{
			get
			{
				return this.m_grouping;
			}
			set
			{
				this.m_grouping = value;
			}
		}

		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00051030 File Offset: 0x0004F230
		// (set) Token: 0x06000D26 RID: 3366 RVA: 0x00051038 File Offset: 0x0004F238
		public int objective
		{
			get
			{
				return this.m_objective;
			}
			set
			{
				this.m_objective = value;
			}
		}

		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000D27 RID: 3367 RVA: 0x00051041 File Offset: 0x0004F241
		// (set) Token: 0x06000D28 RID: 3368 RVA: 0x00051049 File Offset: 0x0004F249
		public int actualvsexpectations
		{
			get
			{
				return this.m_actualvsexpectations;
			}
			set
			{
				this.m_actualvsexpectations = value;
			}
		}

		// Token: 0x170002F6 RID: 758
		// (get) Token: 0x06000D29 RID: 3369 RVA: 0x00051052 File Offset: 0x0004F252
		// (set) Token: 0x06000D2A RID: 3370 RVA: 0x0005105A File Offset: 0x0004F25A
		public int lastgameresult
		{
			get
			{
				return this.m_lastgameresult;
			}
			set
			{
				this.m_lastgameresult = value;
			}
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x06000D2B RID: 3371 RVA: 0x00051063 File Offset: 0x0004F263
		// (set) Token: 0x06000D2C RID: 3372 RVA: 0x0005106B File Offset: 0x0004F26B
		public int homega
		{
			get
			{
				return this.m_homega;
			}
			set
			{
				this.m_homega = value;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x06000D2D RID: 3373 RVA: 0x00051074 File Offset: 0x0004F274
		// (set) Token: 0x06000D2E RID: 3374 RVA: 0x0005107C File Offset: 0x0004F27C
		public int homegf
		{
			get
			{
				return this.m_homegf;
			}
			set
			{
				this.m_homegf = value;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000D2F RID: 3375 RVA: 0x00051085 File Offset: 0x0004F285
		// (set) Token: 0x06000D30 RID: 3376 RVA: 0x0005108D File Offset: 0x0004F28D
		public int points
		{
			get
			{
				return this.m_points;
			}
			set
			{
				this.m_points = value;
			}
		}

		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000D31 RID: 3377 RVA: 0x00051096 File Offset: 0x0004F296
		// (set) Token: 0x06000D32 RID: 3378 RVA: 0x0005109E File Offset: 0x0004F29E
		public int awayga
		{
			get
			{
				return this.m_awayga;
			}
			set
			{
				this.m_awayga = value;
			}
		}

		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000D33 RID: 3379 RVA: 0x000510A7 File Offset: 0x0004F2A7
		// (set) Token: 0x06000D34 RID: 3380 RVA: 0x000510AF File Offset: 0x0004F2AF
		public int secondarytable
		{
			get
			{
				return this.m_secondarytable;
			}
			set
			{
				this.m_secondarytable = value;
			}
		}

		// Token: 0x170002FC RID: 764
		// (get) Token: 0x06000D35 RID: 3381 RVA: 0x000510B8 File Offset: 0x0004F2B8
		// (set) Token: 0x06000D36 RID: 3382 RVA: 0x000510C0 File Offset: 0x0004F2C0
		public int homewins
		{
			get
			{
				return this.m_homewins;
			}
			set
			{
				this.m_homewins = value;
			}
		}

		// Token: 0x170002FD RID: 765
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x000510C9 File Offset: 0x0004F2C9
		// (set) Token: 0x06000D38 RID: 3384 RVA: 0x000510D1 File Offset: 0x0004F2D1
		public int awaywins
		{
			get
			{
				return this.m_awaywins;
			}
			set
			{
				this.m_awaywins = value;
			}
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x06000D39 RID: 3385 RVA: 0x000510DA File Offset: 0x0004F2DA
		// (set) Token: 0x06000D3A RID: 3386 RVA: 0x000510E2 File Offset: 0x0004F2E2
		public int homelosses
		{
			get
			{
				return this.m_homelosses;
			}
			set
			{
				this.m_homelosses = value;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x06000D3B RID: 3387 RVA: 0x000510EB File Offset: 0x0004F2EB
		// (set) Token: 0x06000D3C RID: 3388 RVA: 0x000510F3 File Offset: 0x0004F2F3
		public int awaylosses
		{
			get
			{
				return this.m_awaylosses;
			}
			set
			{
				this.m_awaylosses = value;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000D3D RID: 3389 RVA: 0x000510FC File Offset: 0x0004F2FC
		// (set) Token: 0x06000D3E RID: 3390 RVA: 0x00051104 File Offset: 0x0004F304
		public int awaydraws
		{
			get
			{
				return this.m_awaydraws;
			}
			set
			{
				this.m_awaydraws = value;
			}
		}

		// Token: 0x17000301 RID: 769
		// (get) Token: 0x06000D3F RID: 3391 RVA: 0x0005110D File Offset: 0x0004F30D
		// (set) Token: 0x06000D40 RID: 3392 RVA: 0x00051115 File Offset: 0x0004F315
		public int homedraws
		{
			get
			{
				return this.m_homedraws;
			}
			set
			{
				this.m_homedraws = value;
			}
		}

		// Token: 0x06000D41 RID: 3393 RVA: 0x00051120 File Offset: 0x0004F320
		public override string ToString()
		{
			if (this.m_TeamNameFull != null && this.m_TeamNameFull != string.Empty)
			{
				return this.m_TeamNameFull;
			}
			if (this.m_teamname != null)
			{
				this.m_TeamNameFull = this.m_teamname;
				return this.m_teamname;
			}
			return string.Empty;
		}

		// Token: 0x06000D42 RID: 3394 RVA: 0x00051170 File Offset: 0x0004F370
		public Team(Record recTeams)
			: base(recTeams.IntField[FI.teams_teamid])
		{
			this.Load(recTeams);
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x000511D0 File Offset: 0x0004F3D0
		public Team(int teamId)
		{
			base.Id = teamId;
			this.m_assetid = teamId;
			this.m_TeamNameFull = "Team " + teamId.ToString();
			this.InitNewTeam();
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00051248 File Offset: 0x0004F448
		public void InitNewTeam()
		{
			this.m_TeamNameAbbr10 = this.m_TeamNameFull;
			this.m_TeamNameAbbr15 = this.m_TeamNameAbbr10;
			this.m_TeamNameAbbr3 = "XYZ";
			this.m_teamname = this.m_TeamNameFull;
			this.m_balltype = 1;
			this.m_adboardid = 1;
			this.m_Stadium = null;
			this.m_stadiumid = 0;
			this.m_genericbanner = false;
			this.m_jerseytype = 1;
			this.m_physioid_primary = 1;
			this.m_physioid_secondary = 2;
			this.m_teamcolor1r = 255;
			this.m_teamcolor1g = 255;
			this.m_teamcolor1b = 255;
			this.m_teamcolor2r = 0;
			this.m_teamcolor2g = 0;
			this.m_teamcolor2b = 0;
			this.m_teamcolor3r = 128;
			this.m_teamcolor3g = 128;
			this.m_teamcolor3b = 128;
			this.m_TeamColor1 = Color.FromArgb(255, this.m_teamcolor1r, this.m_teamcolor1g, this.m_teamcolor1b);
			this.m_TeamColor2 = Color.FromArgb(255, this.m_teamcolor2r, this.m_teamcolor2g, this.m_teamcolor2b);
			this.m_TeamColor3 = Color.FromArgb(255, this.m_teamcolor3r, this.m_teamcolor3g, this.m_teamcolor3b);
			this.m_form = 0;
			this.m_managerid = 8105;
			this.m_stadiumcustomname = null;
			this.m_ManagerSurname = null;
			this.m_ManagerFirstName = null;
			this.m_fancrowdhairskintexturecode = 0;
			this.m_stafftracksuitcolorcode = 0;
			for (int i = 0; i < 10; i++)
			{
				this.m_teamkitidList[i] = 0;
			}
			this.m_RivalTeam = null;
			this.m_rivalteam = 1;
			this.m_assetid = base.Id;
			this.m_transferbudget = 1000000;
			this.m_internationalprestige = 10;
			this.m_domesticprestige = 10;
			this.m_formationid = 0;
			this.m_busbuildupspeed = 50;
			this.m_buspassing = 50;
			this.m_buspositioning = 0;
			this.m_ccpassing = 50;
			this.m_cccrossing = 50;
			this.m_ccshooting = 50;
			this.m_ccpositioning = 0;
			this.m_defmentality = 50;
			this.m_defaggression = 50;
			this.m_defteamwidth = 50;
			this.m_defdefenderline = 0;
			this.m_captainid = 0;
			this.m_penaltytakerid = 0;
			this.m_freekicktakerid = 0;
			this.m_longkicktakerid = 0;
			this.m_leftcornerkicktakerid = 0;
			this.m_rightcornerkicktakerid = 0;
			this.PlayerCaptain = null;
			this.PlayerPenalty = null;
			this.PlayerFreeKick = null;
			this.PlayerLongKick = null;
			this.PlayerLeftCorner = null;
			this.PlayerRightCorner = null;
			this.m_numtransfersin = 0;
			this.m_genericint2 = -1;
			this.m_genericint1 = -1;
			this.m_latitude = 0;
			this.m_longitude = 0;
			this.m_utcoffset = 0;
			this.m_powid = -1;
			this.m_midfieldrating = 50;
			this.m_defenserating = 50;
			this.m_attackrating = 50;
			this.m_overallrating = 50;
			this.m_matchdayoverallrating = 50;
			this.m_matchdaydefenserating = 50;
			this.m_matchdaymidfieldrating = 50;
			this.m_matchdayattackrating = 50;
			this.m_suitvariationid = 0;
			this.m_suittypeid = 0;
			this.m_bodytypeid = 1;
			this.m_ethnicity = 2;
			this.m_personalityid = 0;
			this.m_countryid_IfNationalTeam = 0;
			this.m_Country = null;
			this.m_leagueid = 0;
			this.m_League = null;
			this.m_prevleagueid = 0;
			this.m_PrevLeague = null;
			this.m_champion = false;
			this.m_previousyeartableposition = 1;
			this.m_currenttableposition = 1;
			this.m_teamshortform = 50;
			this.m_teamlongform = 50;
			this.m_teamform = 0;
			this.m_hasachievedobjective = false;
			this.m_yettowin = false;
			this.m_unbeatenallcomps = false;
			this.m_unbeatenaway = false;
			this.m_unbeatenhome = false;
			this.m_unbeatenleague = false;
			this.m_highestpossible = 0;
			this.m_highestprobable = 0;
			this.m_nummatchesplayed = 0;
			this.m_gapresult = 0;
			this.m_grouping = 0;
			this.m_objective = 0;
			this.m_actualvsexpectations = 0;
			this.m_lastgameresult = 0;
			this.m_busdribbling = 50;
			this.m_trait1 = 0;
			this.m_ImpatientBoard = false;
			this.m_LoyalBoard = false;
			this.m_SquadRotation = false;
			this.m_ConsistentLineup = false;
			this.m_SwitchWingers = false;
			this.m_CenterBacksSplit = false;
			this.m_DefendLead = false;
			this.m_KeepUpPressure = false;
			this.m_MoreAttackingAtHome = false;
			this.m_ShortOutBack = false;
			this.m_homega = 0;
			this.m_homegf = 0;
			this.m_points = 0;
			this.m_awayga = 0;
			this.m_secondarytable = 0;
			this.m_homewins = 0;
			this.m_awaywins = 0;
			this.m_homelosses = 0;
			this.m_awaylosses = 0;
			this.m_awaydraws = 0;
			this.m_homedraws = 0;
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x00051698 File Offset: 0x0004F898
		public void Load(Record r)
		{
			this.m_assetid = base.Id;
			this.m_teamname = r.StringField[FI.teams_teamname];
			this.m_transferbudget = r.GetAndCheckIntField(FI.teams_transferbudget);
			this.m_domesticprestige = r.GetAndCheckIntField(FI.teams_domesticprestige);
			this.m_internationalprestige = r.GetAndCheckIntField(FI.teams_internationalprestige);
			this.m_rivalteam = r.GetAndCheckIntField(FI.teams_rivalteam);
			this.m_captainid = r.GetAndCheckIntField(FI.teams_captainid);
			this.m_penaltytakerid = r.GetAndCheckIntField(FI.teams_penaltytakerid);
			this.m_freekicktakerid = r.GetAndCheckIntField(FI.teams_freekicktakerid);
			this.m_longkicktakerid = r.GetAndCheckIntField(FI.teams_longkicktakerid);
			this.m_leftcornerkicktakerid = r.GetAndCheckIntField(FI.teams_leftcornerkicktakerid);
			this.m_rightcornerkicktakerid = r.GetAndCheckIntField(FI.teams_rightcornerkicktakerid);
			this.m_adboardid = r.GetAndCheckIntField(FI.teams_adboardid);
			this.m_balltype = r.GetAndCheckIntField(FI.teams_balltype);
			this.m_genericbanner = r.GetAndCheckIntField(FI.teams_genericbanner) != 0;
			this.m_jerseytype = r.GetAndCheckIntField(FI.teams_jerseytype);
			this.m_fancrowdhairskintexturecode = r.GetAndCheckIntField(FI.teams_fancrowdhairskintexturecode);
			this.m_stafftracksuitcolorcode = r.GetAndCheckIntField(FI.teams_stafftracksuitcolorcode);
			this.m_busbuildupspeed = r.GetAndCheckIntField(FI.teams_busbuildupspeed);
			this.m_buspassing = r.GetAndCheckIntField(FI.teams_buspassing);
			this.m_buspositioning = r.GetAndCheckIntField(FI.teams_buspositioning) - 1;
			this.m_busdribbling = r.GetAndCheckIntField(FI.teams_busdribbling);
			this.m_cccrossing = r.GetAndCheckIntField(FI.teams_cccrossing);
			this.m_ccpassing = r.GetAndCheckIntField(FI.teams_ccpassing);
			this.m_ccshooting = r.GetAndCheckIntField(FI.teams_ccshooting);
			this.m_ccpositioning = r.GetAndCheckIntField(FI.teams_ccpositioning) - 1;
			this.m_defmentality = r.GetAndCheckIntField(FI.teams_defmentality);
			this.m_defaggression = r.GetAndCheckIntField(FI.teams_defaggression);
			this.m_defteamwidth = r.GetAndCheckIntField(FI.teams_defteamwidth);
			this.m_defdefenderline = r.GetAndCheckIntField(FI.teams_defdefenderline) - 1;
			this.m_physioid_primary = r.GetAndCheckIntField(FI.teams_physioid_primary);
			this.m_physioid_secondary = r.GetAndCheckIntField(FI.teams_physioid_secondary);
			this.m_teamcolor1r = r.GetAndCheckIntField(FI.teams_teamcolor1r);
			this.m_teamcolor1g = r.GetAndCheckIntField(FI.teams_teamcolor1g);
			this.m_teamcolor1b = r.GetAndCheckIntField(FI.teams_teamcolor1b);
			this.m_teamcolor2r = r.GetAndCheckIntField(FI.teams_teamcolor2r);
			this.m_teamcolor2g = r.GetAndCheckIntField(FI.teams_teamcolor2g);
			this.m_teamcolor2b = r.GetAndCheckIntField(FI.teams_teamcolor2b);
			this.m_teamcolor3r = r.GetAndCheckIntField(FI.teams_teamcolor3r);
			this.m_teamcolor3g = r.GetAndCheckIntField(FI.teams_teamcolor3g);
			this.m_teamcolor3b = r.GetAndCheckIntField(FI.teams_teamcolor3b);
			this.m_TeamColor1 = Color.FromArgb(255, this.m_teamcolor1r, this.m_teamcolor1g, this.m_teamcolor1b);
			this.m_TeamColor2 = Color.FromArgb(255, this.m_teamcolor2r, this.m_teamcolor2g, this.m_teamcolor2b);
			this.m_TeamColor3 = Color.FromArgb(255, this.m_teamcolor3r, this.m_teamcolor3g, this.m_teamcolor3b);
			this.m_form = r.GetAndCheckIntField(FI.teams_form);
			this.m_latitude = r.GetAndCheckIntField(FI.teams_latitude);
			this.m_longitude = r.GetAndCheckIntField(FI.teams_longitude);
			this.m_utcoffset = r.GetAndCheckIntField(FI.teams_utcoffset);
			this.m_powid = r.GetAndCheckIntField(FI.teams_powid);
			this.m_midfieldrating = r.GetAndCheckIntField(FI.teams_midfieldrating);
			this.m_defenserating = r.GetAndCheckIntField(FI.teams_defenserating);
			this.m_attackrating = r.GetAndCheckIntField(FI.teams_attackrating);
			this.m_overallrating = r.GetAndCheckIntField(FI.teams_overallrating);
			this.m_matchdayoverallrating = r.GetAndCheckIntField(FI.teams_matchdayoverallrating);
			this.m_matchdaydefenserating = r.GetAndCheckIntField(FI.teams_matchdaydefenserating);
			this.m_matchdaymidfieldrating = r.GetAndCheckIntField(FI.teams_matchdaymidfieldrating);
			this.m_matchdayattackrating = r.GetAndCheckIntField(FI.teams_matchdayattackrating);
			this.m_suitvariationid = r.GetAndCheckIntField(FI.teams_suitvariationid);
			this.m_suittypeid = r.GetAndCheckIntField(FI.teams_suittypeid);
			this.m_bodytypeid = r.GetAndCheckIntField(FI.teams_bodytypeid);
			this.m_ethnicity = r.GetAndCheckIntField(FI.teams_ethnicity);
			this.m_personalityid = r.GetAndCheckIntField(FI.teams_personalityid);
			this.m_trait1 = r.GetAndCheckIntField(FI.teams_trait1);
			this.m_ImpatientBoard = (this.m_trait1 & 1) != 0;
			this.m_LoyalBoard = (this.m_trait1 & 2) != 0;
			this.m_SquadRotation = (this.m_trait1 & 4) != 0;
			this.m_ConsistentLineup = (this.m_trait1 & 8) != 0;
			this.m_SwitchWingers = (this.m_trait1 & 16) != 0;
			this.m_CenterBacksSplit = (this.m_trait1 & 32) != 0;
			this.m_DefendLead = (this.m_trait1 & 64) != 0;
			this.m_KeepUpPressure = (this.m_trait1 & 128) != 0;
			this.m_MoreAttackingAtHome = (this.m_trait1 & 256) != 0;
			this.m_ShortOutBack = (this.m_trait1 & 512) != 0;
			this.m_numtransfersin = r.GetAndCheckIntField(FI.teams_numtransfersin);
			this.m_genericint2 = r.GetAndCheckIntField(FI.teams_genericint1);
			this.m_genericint1 = r.GetAndCheckIntField(FI.teams_genericint2);
			if (FifaEnvironment.Language != null)
			{
				this.m_TeamNameFull = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Full);
				this.m_TeamNameAbbr15 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr15);
				this.m_TeamNameAbbr10 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr10);
				this.m_TeamNameAbbr3 = FifaEnvironment.Language.GetTeamString(base.Id, Language.ETeamStringType.Abbr3);
				if (this.m_TeamNameFull == null || this.m_TeamNameFull == string.Empty)
				{
					this.m_TeamNameFull = this.m_TeamNameAbbr10;
					return;
				}
			}
			else
			{
				this.m_TeamNameFull = string.Empty;
				this.m_TeamNameAbbr15 = string.Empty;
				this.m_TeamNameAbbr3 = string.Empty;
				this.m_TeamNameAbbr10 = string.Empty;
			}
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00051CD2 File Offset: 0x0004FED2
		public void FillFromStadiumAssignments(Record r)
		{
			this.m_stadiumcustomname = r.StringField[FI.stadiumassignments_stadiumcustomname];
		}

		// Token: 0x06000D47 RID: 3399 RVA: 0x00051CE6 File Offset: 0x0004FEE6
		public void FillFromManager(Record r)
		{
			this.m_ManagerFirstName = r.StringField[FI.manager_firstname];
			this.m_ManagerSurname = r.StringField[FI.manager_surname];
		}

		// Token: 0x06000D48 RID: 3400 RVA: 0x00051D0C File Offset: 0x0004FF0C
		public void FillFromTeamStadiumLinks(Record r)
		{
			this.m_stadiumid = r.GetAndCheckIntField(FI.teamstadiumlinks_stadiumid);
		}

		// Token: 0x06000D49 RID: 3401 RVA: 0x00051D20 File Offset: 0x0004FF20
		public void FillFromTeamkits(Record r)
		{
			int andCheckIntField = r.GetAndCheckIntField(FI.teamkits_teamkittypetechid);
			if (andCheckIntField < this.m_teamkitidList.Length && r.GetAndCheckIntField(FI.teamkits_year) == 0)
			{
				this.m_teamkitidList[andCheckIntField] = r.GetAndCheckIntField(FI.teamkits_teamkitid);
			}
		}

		// Token: 0x06000D4A RID: 3402 RVA: 0x00051D64 File Offset: 0x0004FF64
		public void FillFromFormations(Record r)
		{
			this.m_formationid = r.GetAndCheckIntField(FI.formations_formationid);
		}

		// Token: 0x06000D4B RID: 3403 RVA: 0x00051D77 File Offset: 0x0004FF77
		public void FillFromTeamFormationLinks(Record r)
		{
			this.m_formationid = r.GetAndCheckIntField(FI.teamformationteamstylelinks_formationid);
		}

		// Token: 0x06000D4C RID: 3404 RVA: 0x00051D8A File Offset: 0x0004FF8A
		public void FillFromNations(Record r)
		{
			this.m_countryid_IfNationalTeam = r.GetAndCheckIntField(FI.nations_nationid);
		}

		// Token: 0x06000D4D RID: 3405 RVA: 0x00051DA0 File Offset: 0x0004FFA0
		public void FillFromLeagueTeamLinks(Record r)
		{
			this.m_leagueid = r.GetAndCheckIntField(FI.leagueteamlinks_leagueid);
			this.m_prevleagueid = r.GetAndCheckIntField(FI.leagueteamlinks_prevleagueid);
			this.m_champion = r.GetAndCheckIntField(FI.leagueteamlinks_champion) != 0;
			this.m_previousyeartableposition = r.GetAndCheckIntField(FI.leagueteamlinks_previousyeartableposition);
			this.m_currenttableposition = r.GetAndCheckIntField(FI.leagueteamlinks_currenttableposition);
			this.m_teamshortform = r.GetAndCheckIntField(FI.leagueteamlinks_teamshortform);
			this.m_teamlongform = r.GetAndCheckIntField(FI.leagueteamlinks_teamlongform);
			this.m_teamform = r.GetAndCheckIntField(FI.leagueteamlinks_teamform);
			this.m_hasachievedobjective = r.GetAndCheckIntField(FI.leagueteamlinks_hasachievedobjective) != 0;
			this.m_yettowin = r.GetAndCheckIntField(FI.leagueteamlinks_yettowin) != 0;
			this.m_unbeatenallcomps = r.GetAndCheckIntField(FI.leagueteamlinks_unbeatenallcomps) != 0;
			this.m_unbeatenaway = r.GetAndCheckIntField(FI.leagueteamlinks_unbeatenaway) != 0;
			this.m_unbeatenhome = r.GetAndCheckIntField(FI.leagueteamlinks_unbeatenhome) != 0;
			this.m_unbeatenleague = r.GetAndCheckIntField(FI.leagueteamlinks_unbeatenleague) != 0;
			this.m_highestpossible = r.GetAndCheckIntField(FI.leagueteamlinks_highestpossible);
			this.m_highestprobable = r.GetAndCheckIntField(FI.leagueteamlinks_highestprobable);
			this.m_nummatchesplayed = r.GetAndCheckIntField(FI.leagueteamlinks_nummatchesplayed);
			this.m_gapresult = r.GetAndCheckIntField(FI.leagueteamlinks_gapresult);
			this.m_grouping = r.GetAndCheckIntField(FI.leagueteamlinks_grouping);
			this.m_objective = r.GetAndCheckIntField(FI.leagueteamlinks_objective);
			this.m_actualvsexpectations = r.GetAndCheckIntField(FI.leagueteamlinks_actualvsexpectations);
			this.m_lastgameresult = r.GetAndCheckIntField(FI.leagueteamlinks_lastgameresult);
			this.m_homega = r.GetAndCheckIntField(FI.leagueteamlinks_homega);
			this.m_homegf = r.GetAndCheckIntField(FI.leagueteamlinks_homegf);
			this.m_points = r.GetAndCheckIntField(FI.leagueteamlinks_points);
			this.m_awayga = r.GetAndCheckIntField(FI.leagueteamlinks_awayga);
			this.m_secondarytable = r.GetAndCheckIntField(FI.leagueteamlinks_secondarytable);
			this.m_homewins = r.GetAndCheckIntField(FI.leagueteamlinks_homewins);
			this.m_awaywins = r.GetAndCheckIntField(FI.leagueteamlinks_awaywins);
			this.m_homelosses = r.GetAndCheckIntField(FI.leagueteamlinks_homelosses);
			this.m_awaylosses = r.GetAndCheckIntField(FI.leagueteamlinks_awaylosses);
			this.m_awaydraws = r.GetAndCheckIntField(FI.leagueteamlinks_awaydraws);
			this.m_homedraws = r.GetAndCheckIntField(FI.leagueteamlinks_homedraws);
		}

		// Token: 0x06000D4E RID: 3406 RVA: 0x00052008 File Offset: 0x00050208
		public void FillFromRowTeamNationLinks(Record r)
		{
			this.m_countryid_IfRowTeam = r.GetAndCheckIntField(FI.rowteamnationlinks_nationid);
		}

		// Token: 0x06000D4F RID: 3407 RVA: 0x0005201B File Offset: 0x0005021B
		public void LinkBall(BallList ballList)
		{
			if (ballList == null)
			{
				return;
			}
			this.m_Ball = (Ball)ballList.SearchId(this.m_balltype);
		}

		// Token: 0x06000D50 RID: 3408 RVA: 0x00052038 File Offset: 0x00050238
		public void LinkKits(KitList kitList)
		{
			if (kitList == null)
			{
				return;
			}
			for (int i = 0; i < this.m_teamkitidList.Length; i++)
			{
				if (this.m_teamkitidList[i] != 0)
				{
					Kit kit = (Kit)kitList.SearchId(this.m_teamkitidList[i]);
					this.m_KitList.Add(kit);
				}
			}
		}

		// Token: 0x06000D51 RID: 3409 RVA: 0x00052087 File Offset: 0x00050287
		public void LinkStadium(StadiumList stadiumList)
		{
			if (stadiumList == null)
			{
				return;
			}
			this.m_Stadium = (Stadium)stadiumList.SearchId(this.m_stadiumid);
		}

		// Token: 0x06000D52 RID: 3410 RVA: 0x000520A4 File Offset: 0x000502A4
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			this.m_RivalTeam = (Team)teamList.SearchId(this.m_rivalteam);
		}

		// Token: 0x06000D53 RID: 3411 RVA: 0x000520C4 File Offset: 0x000502C4
		public void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			if (this.m_countryid_IfNationalTeam == 0)
			{
				if (this.m_countryid_IfRowTeam != 0)
				{
					this.m_Country = (Country)countryList.SearchId(this.m_countryid_IfRowTeam);
					return;
				}
				if (this.m_League != null && this.m_League.Country != null)
				{
					this.m_Country = this.m_League.Country;
					this.m_countryid_IfRowTeam = this.m_League.Country.Id;
					return;
				}
			}
			else
			{
				this.m_Country = (Country)countryList.SearchId(this.m_countryid_IfNationalTeam);
			}
		}

		// Token: 0x06000D54 RID: 3412 RVA: 0x00052151 File Offset: 0x00050351
		public void LinkFormation(FormationList formationList)
		{
			if (formationList == null)
			{
				return;
			}
			this.m_Formation = (Formation)formationList.SearchId(this.m_formationid);
		}

		// Token: 0x06000D55 RID: 3413 RVA: 0x00052170 File Offset: 0x00050370
		public void LinkPlayer(PlayerList playerList)
		{
			if (playerList == null)
			{
				return;
			}
			this.PlayerCaptain = (Player)playerList.SearchId(this.m_captainid);
			this.PlayerFreeKick = (Player)playerList.SearchId(this.m_freekicktakerid);
			this.PlayerLongKick = (Player)playerList.SearchId(this.m_longkicktakerid);
			this.PlayerPenalty = (Player)playerList.SearchId(this.m_penaltytakerid);
			this.PlayerLeftCorner = (Player)playerList.SearchId(this.m_leftcornerkicktakerid);
			this.PlayerRightCorner = (Player)playerList.SearchId(this.m_rightcornerkicktakerid);
		}

		// Token: 0x06000D56 RID: 3414 RVA: 0x0005220B File Offset: 0x0005040B
		public void LinkLeague(LeagueList leagueList)
		{
			if (leagueList == null)
			{
				return;
			}
			this.m_League = (League)leagueList.SearchId(this.m_leagueid);
			this.m_PrevLeague = (League)leagueList.SearchId(this.m_prevleagueid);
		}

		// Token: 0x06000D57 RID: 3415 RVA: 0x0005223F File Offset: 0x0005043F
		public bool IsPlayingInLeague(League league)
		{
			return this.m_leagueid == league.Id;
		}

		// Token: 0x06000D58 RID: 3416 RVA: 0x00052250 File Offset: 0x00050450
		public void SaveTeam(Record r)
		{
			r.IntField[FI.teams_teamid] = base.Id;
			r.StringField[FI.teams_teamname] = this.m_teamname;
			r.IntField[FI.teams_balltype] = this.m_balltype;
			r.IntField[FI.teams_adboardid] = this.m_adboardid;
			r.IntField[FI.teams_genericbanner] = (this.m_genericbanner ? 1 : 0);
			r.IntField[FI.teams_jerseytype] = this.m_jerseytype;
			r.IntField[FI.teams_stafftracksuitcolorcode] = this.m_stafftracksuitcolorcode;
			r.IntField[FI.teams_fancrowdhairskintexturecode] = this.m_fancrowdhairskintexturecode;
			r.IntField[FI.teams_physioid_primary] = this.m_physioid_primary;
			r.IntField[FI.teams_physioid_secondary] = this.m_physioid_secondary;
			this.m_teamcolor1r = (int)this.m_TeamColor1.R;
			this.m_teamcolor1g = (int)this.m_TeamColor1.G;
			this.m_teamcolor1b = (int)this.m_TeamColor1.B;
			this.m_teamcolor2r = (int)this.m_TeamColor2.R;
			this.m_teamcolor2g = (int)this.m_TeamColor2.G;
			this.m_teamcolor2b = (int)this.m_TeamColor2.B;
			this.m_teamcolor3r = (int)this.m_TeamColor3.R;
			this.m_teamcolor3g = (int)this.m_TeamColor3.G;
			this.m_teamcolor3b = (int)this.m_TeamColor3.B;
			r.IntField[FI.teams_teamcolor1r] = this.m_teamcolor1r;
			r.IntField[FI.teams_teamcolor1g] = this.m_teamcolor1g;
			r.IntField[FI.teams_teamcolor1b] = this.m_teamcolor1b;
			r.IntField[FI.teams_teamcolor2r] = this.m_teamcolor2r;
			r.IntField[FI.teams_teamcolor2g] = this.m_teamcolor2g;
			r.IntField[FI.teams_teamcolor2b] = this.m_teamcolor2b;
			r.IntField[FI.teams_teamcolor3r] = this.m_teamcolor3r;
			r.IntField[FI.teams_teamcolor3g] = this.m_teamcolor3g;
			r.IntField[FI.teams_teamcolor3b] = this.m_teamcolor3b;
			r.IntField[FI.teams_form] = this.m_form;
			r.IntField[FI.teams_numtransfersin] = this.m_numtransfersin;
			r.IntField[FI.teams_genericint1] = this.m_genericint1;
			r.IntField[FI.teams_genericint2] = this.m_genericint2;
			r.IntField[FI.teams_rivalteam] = this.m_rivalteam;
			r.IntField[FI.teams_assetid] = this.m_assetid;
			r.IntField[FI.teams_transferbudget] = this.m_transferbudget;
			r.IntField[FI.teams_internationalprestige] = this.m_internationalprestige;
			r.IntField[FI.teams_domesticprestige] = this.m_domesticprestige;
			r.IntField[FI.teams_busbuildupspeed] = this.m_busbuildupspeed;
			r.IntField[FI.teams_buspassing] = this.m_buspassing;
			r.IntField[FI.teams_buspositioning] = this.m_buspositioning + 1;
			r.IntField[FI.teams_busdribbling] = this.m_busdribbling;
			r.IntField[FI.teams_ccpassing] = this.m_ccpassing;
			r.IntField[FI.teams_cccrossing] = this.m_cccrossing;
			r.IntField[FI.teams_ccshooting] = this.m_ccshooting;
			r.IntField[FI.teams_ccpositioning] = this.m_ccpositioning + 1;
			r.IntField[FI.teams_defmentality] = this.m_defmentality;
			r.IntField[FI.teams_defaggression] = this.m_defaggression;
			r.IntField[FI.teams_defteamwidth] = this.m_defteamwidth;
			r.IntField[FI.teams_defdefenderline] = this.m_defdefenderline + 1;
			r.IntField[FI.teams_captainid] = this.m_captainid;
			r.IntField[FI.teams_penaltytakerid] = this.m_penaltytakerid;
			r.IntField[FI.teams_freekicktakerid] = this.m_freekicktakerid;
			r.IntField[FI.teams_longkicktakerid] = this.m_longkicktakerid;
			r.IntField[FI.teams_leftcornerkicktakerid] = this.m_leftcornerkicktakerid;
			r.IntField[FI.teams_rightcornerkicktakerid] = this.m_rightcornerkicktakerid;
			r.IntField[FI.teams_latitude] = this.m_latitude;
			r.IntField[FI.teams_longitude] = this.m_longitude;
			r.IntField[FI.teams_utcoffset] = this.m_utcoffset;
			r.IntField[FI.teams_powid] = this.m_powid;
			r.IntField[FI.teams_midfieldrating] = this.m_midfieldrating;
			r.IntField[FI.teams_defenserating] = this.m_defenserating;
			r.IntField[FI.teams_attackrating] = this.m_attackrating;
			r.IntField[FI.teams_overallrating] = this.m_overallrating;
			r.IntField[FI.teams_matchdayoverallrating] = this.m_matchdayoverallrating;
			r.IntField[FI.teams_matchdaydefenserating] = this.m_matchdaydefenserating;
			r.IntField[FI.teams_matchdaymidfieldrating] = this.m_matchdaymidfieldrating;
			r.IntField[FI.teams_matchdayattackrating] = this.m_matchdayattackrating;
			r.IntField[FI.teams_suitvariationid] = this.m_suitvariationid;
			r.IntField[FI.teams_suittypeid] = this.m_suittypeid;
			r.IntField[FI.teams_bodytypeid] = this.m_bodytypeid;
			r.IntField[FI.teams_ethnicity] = this.m_ethnicity;
			r.IntField[FI.teams_personalityid] = this.m_personalityid;
			this.m_trait1 = 0;
			this.m_trait1 |= (this.m_ImpatientBoard ? 1 : 0);
			this.m_trait1 |= (this.m_LoyalBoard ? 2 : 0);
			this.m_trait1 |= (this.m_SquadRotation ? 4 : 0);
			this.m_trait1 |= (this.m_ConsistentLineup ? 8 : 0);
			this.m_trait1 |= (this.m_SwitchWingers ? 16 : 0);
			this.m_trait1 |= (this.m_CenterBacksSplit ? 32 : 0);
			this.m_trait1 |= (this.m_DefendLead ? 64 : 0);
			this.m_trait1 |= (this.m_KeepUpPressure ? 128 : 0);
			this.m_trait1 |= (this.m_MoreAttackingAtHome ? 256 : 0);
			this.m_trait1 |= (this.m_ShortOutBack ? 512 : 0);
			r.IntField[FI.teams_trait1] = this.m_trait1;
		}

		// Token: 0x06000D59 RID: 3417 RVA: 0x00052892 File Offset: 0x00050A92
		public void SaveTeamStadiumLinks(Record r)
		{
			r.IntField[FI.teamstadiumlinks_teamid] = base.Id;
			r.IntField[FI.teamstadiumlinks_stadiumid] = this.m_stadiumid;
		}

		// Token: 0x06000D5A RID: 3418 RVA: 0x000528B8 File Offset: 0x00050AB8
		public void SaveLangTable()
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetTeamString(base.Id, Language.ETeamStringType.Full, this.m_TeamNameFull);
				FifaEnvironment.Language.SetTeamString(base.Id, Language.ETeamStringType.Abbr15, this.m_TeamNameAbbr15);
				FifaEnvironment.Language.SetTeamString(base.Id, Language.ETeamStringType.Abbr10, this.m_TeamNameAbbr10);
				FifaEnvironment.Language.SetTeamString(base.Id, Language.ETeamStringType.Abbr3, this.m_TeamNameAbbr3);
			}
		}

		// Token: 0x06000D5B RID: 3419 RVA: 0x00052928 File Offset: 0x00050B28
		public void SaveTeamCountry(Record r)
		{
		}

		// Token: 0x06000D5C RID: 3420 RVA: 0x0005292A File Offset: 0x00050B2A
		public void SaveStadiumAssignment(Record r)
		{
			r.IntField[FI.stadiumassignments_teamid] = base.Id;
			r.StringField[FI.stadiumassignments_stadiumcustomname] = this.m_stadiumcustomname;
		}

		// Token: 0x06000D5D RID: 3421 RVA: 0x00052950 File Offset: 0x00050B50
		public void SaveManager(Record r)
		{
			r.IntField[FI.manager_teamid] = base.Id;
			r.StringField[FI.manager_firstname] = this.m_ManagerFirstName;
			r.StringField[FI.manager_surname] = this.m_ManagerSurname;
		}

		// Token: 0x06000D5E RID: 3422 RVA: 0x00052988 File Offset: 0x00050B88
		public void SaveTeamFormationLinks(Record r)
		{
			r.IntField[FI.teamformationteamstylelinks_teamid] = base.Id;
			r.IntField[FI.teamformationteamstylelinks_formationid] = this.m_formationid;
			r.IntField[FI.teamformationteamstylelinks_teamstyleid] = 0;
			r.IntField[FI.teamformationteamstylelinks_cddl] = 0;
		}

		// Token: 0x06000D5F RID: 3423 RVA: 0x000529C8 File Offset: 0x00050BC8
		public void SaveRowTeamNationLinks(Record r)
		{
			r.IntField[FI.rowteamnationlinks_teamid] = base.Id;
			if (this.m_Country != null)
			{
				r.IntField[FI.rowteamnationlinks_nationid] = this.m_Country.Id;
			}
		}

		// Token: 0x06000D60 RID: 3424 RVA: 0x000529FB File Offset: 0x00050BFB
		public string CrestTemplateFileName()
		{
			return "data/ui/imgassets/crest/l#.dds";
		}

		// Token: 0x06000D61 RID: 3425 RVA: 0x00052A04 File Offset: 0x00050C04
		public string CrestDdsFileName()
		{
			return "data/ui/imgassets/crest/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000D62 RID: 3426 RVA: 0x00052A2E File Offset: 0x00050C2E
		public static string CrestDdsFileName(int id)
		{
			return "data/ui/imgassets/crest/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000D63 RID: 3427 RVA: 0x00052A46 File Offset: 0x00050C46
		public string Crest50TemplateFileName()
		{
			return "data/ui/imgassets/crest50x50/l#.dds";
		}

		// Token: 0x06000D64 RID: 3428 RVA: 0x00052A50 File Offset: 0x00050C50
		public string Crest50DdsFileName()
		{
			return "data/ui/imgassets/crest50x50/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000D65 RID: 3429 RVA: 0x00052A7A File Offset: 0x00050C7A
		public static string Crest50DdsFileName(int id)
		{
			return "data/ui/imgassets/crest50x50/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000D66 RID: 3430 RVA: 0x00052A92 File Offset: 0x00050C92
		public string Crest32TemplateFileName()
		{
			return "data/ui/imgassets/crest32x32/l#.dds";
		}

		// Token: 0x06000D67 RID: 3431 RVA: 0x00052A9C File Offset: 0x00050C9C
		public string Crest32DdsFileName()
		{
			return "data/ui/imgassets/crest32x32/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000D68 RID: 3432 RVA: 0x00052AC6 File Offset: 0x00050CC6
		public static string Crest32DdsFileName(int id)
		{
			return "data/ui/imgassets/crest32x32/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000D69 RID: 3433 RVA: 0x00052ADE File Offset: 0x00050CDE
		public string Crest16TemplateFileName()
		{
			return "data/ui/imgassets/crest16x16/l#.dds";
		}

		// Token: 0x06000D6A RID: 3434 RVA: 0x00052AE8 File Offset: 0x00050CE8
		public string Crest16DdsFileName()
		{
			return "data/ui/imgassets/crest16x16/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000D6B RID: 3435 RVA: 0x00052B12 File Offset: 0x00050D12
		public static string Crest16DdsFileName(int id)
		{
			return "data/ui/imgassets/crest16x16/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000D6C RID: 3436 RVA: 0x00052B2A File Offset: 0x00050D2A
		public string CrestTemplateFileNameDark()
		{
			return "data/ui/imgassets/crest/dark/l#.dds";
		}

		// Token: 0x06000D6D RID: 3437 RVA: 0x00052B34 File Offset: 0x00050D34
		public string CrestDdsFileNameDark()
		{
			return "data/ui/imgassets/crest/dark/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000D6E RID: 3438 RVA: 0x00052B5E File Offset: 0x00050D5E
		public static string CrestDdsFileNameDark(int id)
		{
			return "data/ui/imgassets/crest/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000D6F RID: 3439 RVA: 0x00052B76 File Offset: 0x00050D76
		public string Crest50TemplateFileNameDark()
		{
			return "data/ui/imgassets/crest50x50/dark/l#.dds";
		}

		// Token: 0x06000D70 RID: 3440 RVA: 0x00052B80 File Offset: 0x00050D80
		public string Crest50DdsFileNameDark()
		{
			return "data/ui/imgassets/crest50x50/dark/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000D71 RID: 3441 RVA: 0x00052BAA File Offset: 0x00050DAA
		public static string Crest50DdsFileNameDark(int id)
		{
			return "data/ui/imgassets/crest50x50/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000D72 RID: 3442 RVA: 0x00052BC2 File Offset: 0x00050DC2
		public string Crest32TemplateFileNameDark()
		{
			return "data/ui/imgassets/crest32x32/dark/l#.dds";
		}

		// Token: 0x06000D73 RID: 3443 RVA: 0x00052BCC File Offset: 0x00050DCC
		public string Crest32DdsFileNameDark()
		{
			return "data/ui/imgassets/crest32x32/dark/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000D74 RID: 3444 RVA: 0x00052BF6 File Offset: 0x00050DF6
		public static string Crest32DdsFileNameDark(int id)
		{
			return "data/ui/imgassets/crest32x32/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000D75 RID: 3445 RVA: 0x00052C0E File Offset: 0x00050E0E
		public string Crest16TemplateFileNameDark()
		{
			return "data/ui/imgassets/crest16x16/dark/l#.dds";
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00052C18 File Offset: 0x00050E18
		public string Crest16DdsFileNameDark()
		{
			return "data/ui/imgassets/crest16x16/dark/l" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00052C42 File Offset: 0x00050E42
		public static string Crest16DdsFileNameDark(int id)
		{
			return "data/ui/imgassets/crest16x16/dark/l" + id.ToString() + ".dds";
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00052C5A File Offset: 0x00050E5A
		public Bitmap GetCrest()
		{
			return FifaEnvironment.GetDdsArtasset(this.CrestDdsFileName());
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00052C67 File Offset: 0x00050E67
		public bool SetCrest(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.CrestTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00052C7B File Offset: 0x00050E7B
		public bool DeleteCrest()
		{
			return FifaEnvironment.DeleteFromZdata(this.CrestDdsFileName());
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00052C88 File Offset: 0x00050E88
		public Bitmap GetCrest50()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest50DdsFileName());
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00052C95 File Offset: 0x00050E95
		public bool SetCrest50(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest50TemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00052CA9 File Offset: 0x00050EA9
		public bool DeleteCrest50()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest50DdsFileName());
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00052CB6 File Offset: 0x00050EB6
		public Bitmap GetCrest32()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest32DdsFileName());
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00052CC3 File Offset: 0x00050EC3
		public bool SetCrest32(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest32TemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00052CD7 File Offset: 0x00050ED7
		public bool DeleteCrest32()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest32DdsFileName());
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00052CE4 File Offset: 0x00050EE4
		public Bitmap GetCrest16()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest16DdsFileName());
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00052CF1 File Offset: 0x00050EF1
		public bool SetCrest16(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest16TemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x06000D83 RID: 3459 RVA: 0x00052D05 File Offset: 0x00050F05
		public bool DeleteCrest16()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest16DdsFileName());
		}

		// Token: 0x06000D84 RID: 3460 RVA: 0x00052D12 File Offset: 0x00050F12
		public Bitmap GetCrestDark()
		{
			return FifaEnvironment.GetDdsArtasset(this.CrestDdsFileNameDark());
		}

		// Token: 0x06000D85 RID: 3461 RVA: 0x00052D1F File Offset: 0x00050F1F
		public bool SetCrestDark(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.CrestTemplateFileNameDark(), base.Id, bitmap);
		}

		// Token: 0x06000D86 RID: 3462 RVA: 0x00052D33 File Offset: 0x00050F33
		public bool DeleteCrestDark()
		{
			return FifaEnvironment.DeleteFromZdata(this.CrestDdsFileNameDark());
		}

		// Token: 0x06000D87 RID: 3463 RVA: 0x00052D40 File Offset: 0x00050F40
		public Bitmap GetCrest50Dark()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest50DdsFileNameDark());
		}

		// Token: 0x06000D88 RID: 3464 RVA: 0x00052D4D File Offset: 0x00050F4D
		public bool SetCrest50Dark(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest50TemplateFileNameDark(), base.Id, bitmap);
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x00052D61 File Offset: 0x00050F61
		public bool DeleteCrest50Dark()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest50DdsFileNameDark());
		}

		// Token: 0x06000D8A RID: 3466 RVA: 0x00052D6E File Offset: 0x00050F6E
		public Bitmap GetCrest32Dark()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest32DdsFileNameDark());
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00052D7B File Offset: 0x00050F7B
		public bool SetCrest32Dark(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest32TemplateFileNameDark(), base.Id, bitmap);
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x00052D8F File Offset: 0x00050F8F
		public bool DeleteCrest32Dark()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest32DdsFileNameDark());
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00052D9C File Offset: 0x00050F9C
		public Bitmap GetCrest16Dark()
		{
			return FifaEnvironment.GetDdsArtasset(this.Crest16DdsFileNameDark());
		}

		// Token: 0x06000D8E RID: 3470 RVA: 0x00052DA9 File Offset: 0x00050FA9
		public bool SetCrest16Dark(Bitmap bitmap)
		{
			return FifaEnvironment.SetDdsArtasset(this.Crest16TemplateFileNameDark(), base.Id, bitmap);
		}

		// Token: 0x06000D8F RID: 3471 RVA: 0x00052DBD File Offset: 0x00050FBD
		public bool DeleteCrest16Dark()
		{
			return FifaEnvironment.DeleteFromZdata(this.Crest16DdsFileNameDark());
		}

		// Token: 0x06000D90 RID: 3472 RVA: 0x00052DCC File Offset: 0x00050FCC
		public string BannerFileName()
		{
			return "data/sceneassets/banner/banner_" + base.Id.ToString() + ".rx3";
		}

		// Token: 0x06000D91 RID: 3473 RVA: 0x00052DF6 File Offset: 0x00050FF6
		public static string BannerFileName(int id)
		{
			return "data/sceneassets/banner/banner_" + id.ToString() + ".rx3";
		}

		// Token: 0x06000D92 RID: 3474 RVA: 0x00052E0E File Offset: 0x0005100E
		public string BannerTemplateFileName()
		{
			return "data/sceneassets/banner/banner_#.rx3";
		}

		// Token: 0x06000D93 RID: 3475 RVA: 0x00052E15 File Offset: 0x00051015
		public Bitmap GetBanner()
		{
			return FifaEnvironment.GetBmpFromRx3(this.BannerFileName());
		}

		// Token: 0x06000D94 RID: 3476 RVA: 0x00052E22 File Offset: 0x00051022
		public bool SetBanner(Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(this.BannerTemplateFileName(), base.Id, bitmap, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000D95 RID: 3477 RVA: 0x00052E37 File Offset: 0x00051037
		public bool SetBanner(string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.BannerFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000D96 RID: 3478 RVA: 0x00052E47 File Offset: 0x00051047
		public bool DeleteBanner()
		{
			return FifaEnvironment.DeleteFromZdata(this.BannerFileName());
		}

		// Token: 0x06000D97 RID: 3479 RVA: 0x00052E54 File Offset: 0x00051054
		public static string GenericFlagFileName(int style)
		{
			return "data/sceneassets/flag/gf" + style.ToString() + ".png";
		}

		// Token: 0x06000D98 RID: 3480 RVA: 0x00052E6C File Offset: 0x0005106C
		public string FlagFileName()
		{
			return "data/sceneassets/flag/flag_" + base.Id.ToString() + ".rx3";
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00052E96 File Offset: 0x00051096
		public static string FlagFileName(int id)
		{
			return "data/sceneassets/flag/flag_" + id.ToString() + ".rx3";
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00052EAE File Offset: 0x000510AE
		public string FlagTemplateFileName()
		{
			return "data/sceneassets/flag/flag_#.rx3";
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00052EB8 File Offset: 0x000510B8
		private Rx3Signatures FlagsSignature()
		{
			return new Rx3Signatures(44560, 29, new string[]
			{
				"flag_" + base.Id.ToString() + "_0.Raster",
				"flag_" + base.Id.ToString() + "_1.Raster",
				"flag_" + base.Id.ToString() + "_2.Raster",
				"flag_" + base.Id.ToString() + "_3.Raster"
			});
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00052F5D File Offset: 0x0005115D
		public Bitmap[] GetFlags()
		{
			return FifaEnvironment.GetBmpsFromRx3(this.FlagFileName());
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00052F6A File Offset: 0x0005116A
		public bool SetFlags(Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata(this.FlagTemplateFileName(), base.Id, bitmaps, ECompressionMode.Chunkzip, this.FlagsSignature());
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x00052F85 File Offset: 0x00051185
		public bool DeleteFlag()
		{
			return FifaEnvironment.DeleteFromZdata(this.FlagFileName());
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x00052F94 File Offset: 0x00051194
		public bool SetFlags(string rx3FileName)
		{
			string text = this.FlagFileName();
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000DA0 RID: 3488 RVA: 0x00052FB5 File Offset: 0x000511B5
		public bool ExportFlags(string exportFolder)
		{
			return FifaEnvironment.ExportFileFromZdata(this.FlagFileName(), exportFolder);
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00052FC4 File Offset: 0x000511C4
		public void RemoveTeamPlayer(TeamPlayer teamPlayer)
		{
			this.m_Roster.Remove(teamPlayer);
			teamPlayer.Player.NotPlayFor(this);
			if (teamPlayer.position < 28)
			{
				this.AssignRoleToSubstitute((ERole)teamPlayer.position);
				this.AssignBench();
			}
			else if (teamPlayer.position == 28)
			{
				this.AssignBench();
			}
			if (this.PlayerCaptain == teamPlayer.Player)
			{
				this.AssignCaptain();
			}
			if (this.PlayerFreeKick == teamPlayer.Player)
			{
				this.AssignFreeKick();
			}
			if (this.PlayerPenalty == teamPlayer.Player)
			{
				this.AssignPenalty();
			}
			if (this.PlayerLeftCorner == teamPlayer.Player)
			{
				this.AssignLeftCorner();
			}
			if (this.PlayerRightCorner == teamPlayer.Player)
			{
				this.AssignRightCorner();
			}
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x0005307C File Offset: 0x0005127C
		public void RemoveTeamPlayer(Player player)
		{
			TeamPlayer teamPlayer = this.m_Roster.SearchTeamPlayer(player);
			if (teamPlayer != null)
			{
				this.RemoveTeamPlayer(teamPlayer);
			}
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000530A0 File Offset: 0x000512A0
		public void AssignRoles()
		{
			this.AssignRoles(this.m_Formation);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000530B0 File Offset: 0x000512B0
		public void AssignRoles(Formation formation)
		{
			Roster roster = new Roster(32);
			ERole[] array = new ERole[11];
			int num = 11;
			for (int i = 0; i < 11; i++)
			{
				array[i] = formation.PlayingRoles[i].Role.RoleId;
			}
			for (int j = 0; j < 7; j++)
			{
				TeamPlayer teamPlayer = this.m_Roster.GetBestPlayer();
				if (teamPlayer == null)
				{
					break;
				}
				ERole erole = teamPlayer.Player.ChooseRole(array, num);
				teamPlayer.position = (int)erole;
				roster.Add(teamPlayer);
				this.m_Roster.Remove(teamPlayer);
				for (int k = 0; k < num; k++)
				{
					if (erole == array[k])
					{
						for (int l = k; l < num - 1; l++)
						{
							array[l] = array[l + 1];
						}
						num--;
					}
				}
			}
			for (int m = 0; m < num; m++)
			{
				ERole erole2 = array[m];
				TeamPlayer teamPlayer = this.m_Roster.GetRoleBestPlayer(erole2);
				if (teamPlayer == null)
				{
					break;
				}
				teamPlayer.position = (int)erole2;
				roster.Add(teamPlayer);
				this.m_Roster.Remove(teamPlayer);
			}
			for (int n = 0; n < 7; n++)
			{
				TeamPlayer teamPlayer = this.m_Roster.GetBestPlayer();
				if (teamPlayer == null)
				{
					break;
				}
				teamPlayer.position = 28;
				roster.Add(teamPlayer);
				this.m_Roster.Remove(teamPlayer);
			}
			for (int num2 = 0; num2 < 14; num2++)
			{
				TeamPlayer teamPlayer = this.m_Roster.GetBestPlayer();
				if (teamPlayer == null)
				{
					break;
				}
				teamPlayer.position = 29;
				roster.Add(teamPlayer);
				this.m_Roster.Remove(teamPlayer);
			}
			foreach (object obj in roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				this.m_Roster.Add(teamPlayer2);
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0005328C File Offset: 0x0005148C
		public void AssignTitolarToRoles(Formation formation)
		{
			Roster roster = new Roster(32);
			ERole[] array = new ERole[11];
			int num = 11;
			for (int i = 0; i < 11; i++)
			{
				array[i] = formation.PlayingRoles[i].Role.RoleId;
			}
			for (int j = 0; j < 11; j++)
			{
				TeamPlayer bestTitolar = this.m_Roster.GetBestTitolar();
				if (bestTitolar == null)
				{
					break;
				}
				ERole erole = bestTitolar.Player.ChooseRole(array, num);
				bestTitolar.position = (int)erole;
				roster.Add(bestTitolar);
				this.m_Roster.Remove(bestTitolar);
				for (int k = 0; k < num; k++)
				{
					if (erole == array[k])
					{
						for (int l = k; l < num - 1; l++)
						{
							array[l] = array[l + 1];
						}
						num--;
					}
				}
			}
			foreach (object obj in roster)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				this.m_Roster.Add(teamPlayer);
			}
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x000533B0 File Offset: 0x000515B0
		public void AssignRoleToSubstitute(ERole role)
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position >= 28)
				{
					int rolePerformance = teamPlayer2.Player.GetRolePerformance(role);
					if (rolePerformance > num)
					{
						num = rolePerformance;
						teamPlayer = teamPlayer2;
					}
				}
			}
			if (teamPlayer != null)
			{
				teamPlayer.position = (int)role;
			}
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x00053438 File Offset: 0x00051638
		public void AssignBench()
		{
			int num = 0;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer = (TeamPlayer)obj;
				if (teamPlayer.position == 28)
				{
					num++;
				}
			}
			for (int i = num; i < 7; i++)
			{
				foreach (object obj2 in this.m_Roster)
				{
					TeamPlayer teamPlayer2 = (TeamPlayer)obj2;
					if (teamPlayer2.position == 29)
					{
						teamPlayer2.position = 28;
						break;
					}
				}
			}
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x0005350C File Offset: 0x0005170C
		public void AssignCaptain()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int num2 = teamPlayer2.Player.ComputeMeanAttributes(5);
					if (num2 >= num)
					{
						teamPlayer = teamPlayer2;
						num = num2;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerCaptain = teamPlayer.Player;
				this.m_captainid = this.PlayerCaptain.Id;
			}
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x000535A8 File Offset: 0x000517A8
		public void AssignPenalty()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int num2 = teamPlayer2.Player.ComputeMeanAttributes(3);
					if (num2 >= num)
					{
						teamPlayer = teamPlayer2;
						num = num2;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerPenalty = teamPlayer.Player;
				this.m_penaltytakerid = this.PlayerCaptain.Id;
			}
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x00053644 File Offset: 0x00051844
		public void AssignFreeKick()
		{
			int num = -1;
			int num2 = -1;
			TeamPlayer teamPlayer = null;
			TeamPlayer teamPlayer2 = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer3 = (TeamPlayer)obj;
				if (teamPlayer3.position < 28)
				{
					int freekickaccuracy = teamPlayer3.Player.freekickaccuracy;
					if (freekickaccuracy >= num)
					{
						teamPlayer = teamPlayer3;
						num = freekickaccuracy;
					}
					int num3 = teamPlayer3.Player.freekickaccuracy + teamPlayer3.Player.longshots;
					if (num3 >= num2)
					{
						teamPlayer2 = teamPlayer3;
						num2 = num3;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerFreeKick = teamPlayer.Player;
				this.m_freekicktakerid = this.PlayerFreeKick.Id;
			}
			if (teamPlayer2 != null)
			{
				this.PlayerLongKick = teamPlayer.Player;
				this.m_longkicktakerid = this.PlayerFreeKick.Id;
			}
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00053734 File Offset: 0x00051934
		public void AssignLeftCorner()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int crossing = teamPlayer2.Player.crossing;
					if (crossing >= num)
					{
						teamPlayer = teamPlayer2;
						num = crossing;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerLeftCorner = teamPlayer.Player;
				this.m_leftcornerkicktakerid = this.PlayerLeftCorner.Id;
			}
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x000537D0 File Offset: 0x000519D0
		public void AssignRightCorner()
		{
			int num = -1;
			TeamPlayer teamPlayer = null;
			foreach (object obj in this.m_Roster)
			{
				TeamPlayer teamPlayer2 = (TeamPlayer)obj;
				if (teamPlayer2.position < 28)
				{
					int crossing = teamPlayer2.Player.crossing;
					if (crossing >= num)
					{
						teamPlayer = teamPlayer2;
						num = crossing;
					}
				}
			}
			if (teamPlayer != null)
			{
				this.PlayerRightCorner = teamPlayer.Player;
				this.m_rightcornerkicktakerid = this.PlayerRightCorner.Id;
			}
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x0005386C File Offset: 0x00051A6C
		public void AddTeamPlayer(TeamPlayer teamPlayer)
		{
			teamPlayer.position = 29;
			teamPlayer.m_jerseynumber = this.m_Roster.GetFreeNumber();
			teamPlayer.Team = this;
			this.m_Roster.Add(teamPlayer);
			teamPlayer.Player.PlayFor(this);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x000538A8 File Offset: 0x00051AA8
		public void AddTeamPlayer(Player player)
		{
			TeamPlayer teamPlayer = new TeamPlayer(player);
			this.AddTeamPlayer(teamPlayer);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x000538C3 File Offset: 0x00051AC3
		public Kit GetKit(int kitType)
		{
			return this.m_KitList.GetKit(base.Id, kitType);
		}

		// Token: 0x04001063 RID: 4195
		private static int[] c_TopLeaguesId = new int[] { 13, 16, 19, 31, 53, 341 };

		// Token: 0x04001064 RID: 4196
		private bool m_ImpatientBoard;

		// Token: 0x04001065 RID: 4197
		private bool m_LoyalBoard;

		// Token: 0x04001066 RID: 4198
		private bool m_SquadRotation;

		// Token: 0x04001067 RID: 4199
		private bool m_ConsistentLineup;

		// Token: 0x04001068 RID: 4200
		private bool m_SwitchWingers;

		// Token: 0x04001069 RID: 4201
		private bool m_CenterBacksSplit;

		// Token: 0x0400106A RID: 4202
		private bool m_DefendLead;

		// Token: 0x0400106B RID: 4203
		private bool m_KeepUpPressure;

		// Token: 0x0400106C RID: 4204
		private bool m_MoreAttackingAtHome;

		// Token: 0x0400106D RID: 4205
		private bool m_ShortOutBack;

		// Token: 0x0400106E RID: 4206
		private int m_balltype = 1;

		// Token: 0x0400106F RID: 4207
		private Ball m_Ball;

		// Token: 0x04001070 RID: 4208
		private int m_adboardid = 1;

		// Token: 0x04001071 RID: 4209
		private int m_stadiumid = 1;

		// Token: 0x04001072 RID: 4210
		private Stadium m_Stadium;

		// Token: 0x04001073 RID: 4211
		private int m_rivalteam;

		// Token: 0x04001074 RID: 4212
		private Team m_RivalTeam;

		// Token: 0x04001075 RID: 4213
		private int m_formationid;

		// Token: 0x04001076 RID: 4214
		private Formation m_Formation;

		// Token: 0x04001077 RID: 4215
		private int m_captainid;

		// Token: 0x04001078 RID: 4216
		private int m_penaltytakerid;

		// Token: 0x04001079 RID: 4217
		private int m_freekicktakerid;

		// Token: 0x0400107A RID: 4218
		private int m_longkicktakerid;

		// Token: 0x0400107B RID: 4219
		private int m_leftcornerkicktakerid;

		// Token: 0x0400107C RID: 4220
		private int m_rightcornerkicktakerid;

		// Token: 0x0400107D RID: 4221
		public Player PlayerCaptain;

		// Token: 0x0400107E RID: 4222
		public Player PlayerPenalty;

		// Token: 0x0400107F RID: 4223
		public Player PlayerFreeKick;

		// Token: 0x04001080 RID: 4224
		public Player PlayerLongKick;

		// Token: 0x04001081 RID: 4225
		public Player PlayerLeftCorner;

		// Token: 0x04001082 RID: 4226
		public Player PlayerRightCorner;

		// Token: 0x04001083 RID: 4227
		private string m_TeamNameFull;

		// Token: 0x04001084 RID: 4228
		private string m_TeamNameAbbr15;

		// Token: 0x04001085 RID: 4229
		private string m_TeamNameAbbr10;

		// Token: 0x04001086 RID: 4230
		private string m_TeamNameAbbr3;

		// Token: 0x04001087 RID: 4231
		private string m_teamname;

		// Token: 0x04001088 RID: 4232
		private int m_jerseytype;

		// Token: 0x04001089 RID: 4233
		private int m_fancrowdhairskintexturecode;

		// Token: 0x0400108A RID: 4234
		private int m_stafftracksuitcolorcode;

		// Token: 0x0400108B RID: 4235
		private int m_physioid_primary;

		// Token: 0x0400108C RID: 4236
		private int m_physioid_secondary;

		// Token: 0x0400108D RID: 4237
		private int m_teamcolor1r;

		// Token: 0x0400108E RID: 4238
		private int m_teamcolor1g;

		// Token: 0x0400108F RID: 4239
		private int m_teamcolor1b;

		// Token: 0x04001090 RID: 4240
		private Color m_TeamColor1;

		// Token: 0x04001091 RID: 4241
		private Color m_TeamColor2;

		// Token: 0x04001092 RID: 4242
		private Color m_TeamColor3;

		// Token: 0x04001093 RID: 4243
		private int m_teamcolor2r;

		// Token: 0x04001094 RID: 4244
		private int m_teamcolor2g;

		// Token: 0x04001095 RID: 4245
		private int m_teamcolor2b;

		// Token: 0x04001096 RID: 4246
		private int m_teamcolor3r;

		// Token: 0x04001097 RID: 4247
		private int m_teamcolor3g;

		// Token: 0x04001098 RID: 4248
		private int m_teamcolor3b;

		// Token: 0x04001099 RID: 4249
		private int m_form;

		// Token: 0x0400109A RID: 4250
		private int m_managerid;

		// Token: 0x0400109B RID: 4251
		private int m_latitude;

		// Token: 0x0400109C RID: 4252
		private int m_longitude;

		// Token: 0x0400109D RID: 4253
		private int m_bodytypeid;

		// Token: 0x0400109E RID: 4254
		private int m_suitvariationid;

		// Token: 0x0400109F RID: 4255
		private int m_suittypeid;

		// Token: 0x040010A0 RID: 4256
		private int m_personalityid;

		// Token: 0x040010A1 RID: 4257
		private int m_busdribbling;

		// Token: 0x040010A2 RID: 4258
		private int m_trait1;

		// Token: 0x040010A3 RID: 4259
		private int m_utcoffset;

		// Token: 0x040010A4 RID: 4260
		private int m_ethnicity;

		// Token: 0x040010A5 RID: 4261
		private int m_powid;

		// Token: 0x040010A6 RID: 4262
		public bool m_genericbanner;

		// Token: 0x040010A7 RID: 4263
		private int m_assetid;

		// Token: 0x040010A8 RID: 4264
		private int m_transferbudget;

		// Token: 0x040010A9 RID: 4265
		private int m_internationalprestige;

		// Token: 0x040010AA RID: 4266
		private int m_domesticprestige;

		// Token: 0x040010AB RID: 4267
		private int m_numtransfersin;

		// Token: 0x040010AC RID: 4268
		private string m_stadiumcustomname;

		// Token: 0x040010AD RID: 4269
		private string m_ManagerFirstName;

		// Token: 0x040010AE RID: 4270
		private string m_ManagerSurname;

		// Token: 0x040010AF RID: 4271
		private int m_busbuildupspeed;

		// Token: 0x040010B0 RID: 4272
		private int m_buspassing;

		// Token: 0x040010B1 RID: 4273
		private int m_buspositioning;

		// Token: 0x040010B2 RID: 4274
		private int m_ccpassing;

		// Token: 0x040010B3 RID: 4275
		private int m_cccrossing;

		// Token: 0x040010B4 RID: 4276
		private int m_ccshooting;

		// Token: 0x040010B5 RID: 4277
		private int m_ccpositioning;

		// Token: 0x040010B6 RID: 4278
		private int m_defmentality;

		// Token: 0x040010B7 RID: 4279
		private int m_defaggression;

		// Token: 0x040010B8 RID: 4280
		private int m_defteamwidth;

		// Token: 0x040010B9 RID: 4281
		private int m_defdefenderline;

		// Token: 0x040010BA RID: 4282
		private int m_genericint2;

		// Token: 0x040010BB RID: 4283
		private int m_genericint1;

		// Token: 0x040010BC RID: 4284
		private int m_midfieldrating;

		// Token: 0x040010BD RID: 4285
		private int m_defenserating;

		// Token: 0x040010BE RID: 4286
		private int m_attackrating;

		// Token: 0x040010BF RID: 4287
		private int m_overallrating;

		// Token: 0x040010C0 RID: 4288
		private int m_matchdayoverallrating;

		// Token: 0x040010C1 RID: 4289
		private int m_matchdaydefenserating;

		// Token: 0x040010C2 RID: 4290
		private int m_matchdaymidfieldrating;

		// Token: 0x040010C3 RID: 4291
		private int m_matchdayattackrating;

		// Token: 0x040010C4 RID: 4292
		private Roster m_Roster = new Roster(32);

		// Token: 0x040010C5 RID: 4293
		public int m_countryid_IfNationalTeam;

		// Token: 0x040010C6 RID: 4294
		public int m_countryid_IfRowTeam;

		// Token: 0x040010C7 RID: 4295
		private Country m_Country;

		// Token: 0x040010C8 RID: 4296
		private int m_leagueid;

		// Token: 0x040010C9 RID: 4297
		private League m_League;

		// Token: 0x040010CA RID: 4298
		private int m_prevleagueid;

		// Token: 0x040010CB RID: 4299
		private League m_PrevLeague;

		// Token: 0x040010CC RID: 4300
		private bool m_champion;

		// Token: 0x040010CD RID: 4301
		private int m_previousyeartableposition;

		// Token: 0x040010CE RID: 4302
		private int m_currenttableposition;

		// Token: 0x040010CF RID: 4303
		private int m_teamshortform;

		// Token: 0x040010D0 RID: 4304
		private int m_teamlongform;

		// Token: 0x040010D1 RID: 4305
		private int m_teamform;

		// Token: 0x040010D2 RID: 4306
		private bool m_hasachievedobjective;

		// Token: 0x040010D3 RID: 4307
		private bool m_yettowin;

		// Token: 0x040010D4 RID: 4308
		private bool m_unbeatenallcomps;

		// Token: 0x040010D5 RID: 4309
		private bool m_unbeatenaway;

		// Token: 0x040010D6 RID: 4310
		private bool m_unbeatenhome;

		// Token: 0x040010D7 RID: 4311
		private bool m_unbeatenleague;

		// Token: 0x040010D8 RID: 4312
		private int m_highestpossible;

		// Token: 0x040010D9 RID: 4313
		private int m_highestprobable;

		// Token: 0x040010DA RID: 4314
		private int m_nummatchesplayed;

		// Token: 0x040010DB RID: 4315
		private int m_gapresult;

		// Token: 0x040010DC RID: 4316
		private int m_grouping;

		// Token: 0x040010DD RID: 4317
		private int m_objective;

		// Token: 0x040010DE RID: 4318
		private int m_actualvsexpectations;

		// Token: 0x040010DF RID: 4319
		private int m_lastgameresult;

		// Token: 0x040010E0 RID: 4320
		private int m_homega;

		// Token: 0x040010E1 RID: 4321
		private int m_homegf;

		// Token: 0x040010E2 RID: 4322
		private int m_points;

		// Token: 0x040010E3 RID: 4323
		private int m_awayga;

		// Token: 0x040010E4 RID: 4324
		private int m_secondarytable;

		// Token: 0x040010E5 RID: 4325
		private int m_homewins;

		// Token: 0x040010E6 RID: 4326
		private int m_awaywins;

		// Token: 0x040010E7 RID: 4327
		private int m_homelosses;

		// Token: 0x040010E8 RID: 4328
		private int m_awaylosses;

		// Token: 0x040010E9 RID: 4329
		private int m_awaydraws;

		// Token: 0x040010EA RID: 4330
		private int m_homedraws;

		// Token: 0x040010EB RID: 4331
		public KitList m_KitList = new KitList();

		// Token: 0x040010EC RID: 4332
		private int[] m_teamkitidList = new int[10];
	}
}
