using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200001E RID: 30
	public class Stadium : IdObject
	{
		// Token: 0x1700005F RID: 95
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x0000FCD0 File Offset: 0x0000DED0
		// (set) Token: 0x060001D4 RID: 468 RVA: 0x0000FCD8 File Offset: 0x0000DED8
		public string name
		{
			get
			{
				return this.m_name;
			}
			set
			{
				this.m_name = value;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x0000FCE1 File Offset: 0x0000DEE1
		// (set) Token: 0x060001D6 RID: 470 RVA: 0x0000FCE9 File Offset: 0x0000DEE9
		public int countrycode
		{
			get
			{
				return this.m_countrycode;
			}
			set
			{
				this.m_countrycode = value;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x0000FCF2 File Offset: 0x0000DEF2
		// (set) Token: 0x060001D8 RID: 472 RVA: 0x0000FCFA File Offset: 0x0000DEFA
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
					this.m_countrycode = this.m_Country.Id;
					return;
				}
				this.m_countrycode = 0;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x0000FD24 File Offset: 0x0000DF24
		// (set) Token: 0x060001DA RID: 474 RVA: 0x0000FD2C File Offset: 0x0000DF2C
		public int policetypecode
		{
			get
			{
				return this.m_policetypecode;
			}
			set
			{
				this.m_policetypecode = value;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060001DB RID: 475 RVA: 0x0000FD35 File Offset: 0x0000DF35
		// (set) Token: 0x060001DC RID: 476 RVA: 0x0000FD3D File Offset: 0x0000DF3D
		public int sectionfacedbydefault
		{
			get
			{
				return this.m_sectionfacedbydefault;
			}
			set
			{
				this.m_sectionfacedbydefault = value;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060001DD RID: 477 RVA: 0x0000FD46 File Offset: 0x0000DF46
		// (set) Token: 0x060001DE RID: 478 RVA: 0x0000FD4E File Offset: 0x0000DF4E
		public int hometeamid
		{
			get
			{
				return this.m_hometeamid;
			}
			set
			{
				this.m_hometeamid = value;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060001DF RID: 479 RVA: 0x0000FD57 File Offset: 0x0000DF57
		// (set) Token: 0x060001E0 RID: 480 RVA: 0x0000FD5F File Offset: 0x0000DF5F
		public Team HomeTeam
		{
			get
			{
				return this.m_HomeTeam;
			}
			set
			{
				this.m_HomeTeam = value;
				if (this.m_HomeTeam != null)
				{
					this.m_hometeamid = this.m_HomeTeam.Id;
					return;
				}
				this.m_hometeamid = 0;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060001E1 RID: 481 RVA: 0x0000FD89 File Offset: 0x0000DF89
		// (set) Token: 0x060001E2 RID: 482 RVA: 0x0000FD91 File Offset: 0x0000DF91
		public int capacity
		{
			get
			{
				return this.m_capacity;
			}
			set
			{
				this.m_capacity = value;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060001E3 RID: 483 RVA: 0x0000FD9A File Offset: 0x0000DF9A
		// (set) Token: 0x060001E4 RID: 484 RVA: 0x0000FDA2 File Offset: 0x0000DFA2
		public int yearbuilt
		{
			get
			{
				return this.m_yearbuilt;
			}
			set
			{
				this.m_yearbuilt = value;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x060001E5 RID: 485 RVA: 0x0000FDAB File Offset: 0x0000DFAB
		// (set) Token: 0x060001E6 RID: 486 RVA: 0x0000FDB3 File Offset: 0x0000DFB3
		public int seatcolor
		{
			get
			{
				return this.m_seatcolor;
			}
			set
			{
				this.m_seatcolor = value;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001E7 RID: 487 RVA: 0x0000FDBC File Offset: 0x0000DFBC
		// (set) Token: 0x060001E8 RID: 488 RVA: 0x0000FDC4 File Offset: 0x0000DFC4
		public int stadiumtype
		{
			get
			{
				return this.m_stadiumtype;
			}
			set
			{
				this.m_stadiumtype = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001E9 RID: 489 RVA: 0x0000FDCD File Offset: 0x0000DFCD
		// (set) Token: 0x060001EA RID: 490 RVA: 0x0000FDD5 File Offset: 0x0000DFD5
		public int NetColor
		{
			get
			{
				return this.m_stadiumgoalnetstyle;
			}
			set
			{
				this.m_stadiumgoalnetstyle = value;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001EB RID: 491 RVA: 0x0000FDDE File Offset: 0x0000DFDE
		// (set) Token: 0x060001EC RID: 492 RVA: 0x0000FDED File Offset: 0x0000DFED
		public bool IsDeepNet
		{
			get
			{
				return this.m_stadiumgloalnetdepth == 320;
			}
			set
			{
				this.m_stadiumgloalnetdepth = (value ? 320 : 229);
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001ED RID: 493 RVA: 0x0000FE04 File Offset: 0x0000E004
		// (set) Token: 0x060001EE RID: 494 RVA: 0x0000FE0C File Offset: 0x0000E00C
		public int MowingPatternId
		{
			get
			{
				return this.m_stadiummowpattern_code;
			}
			set
			{
				this.m_stadiummowpattern_code = value;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001EF RID: 495 RVA: 0x0000FE15 File Offset: 0x0000E015
		// (set) Token: 0x060001F0 RID: 496 RVA: 0x0000FE1D File Offset: 0x0000E01D
		public int adboardendlinedistance
		{
			get
			{
				return this.m_adboardendlinedistance;
			}
			set
			{
				this.m_adboardendlinedistance = value;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x0000FE26 File Offset: 0x0000E026
		// (set) Token: 0x060001F2 RID: 498 RVA: 0x0000FE2E File Offset: 0x0000E02E
		public int adboardsidelinedistance
		{
			get
			{
				return this.m_adboardsidelinedistance;
			}
			set
			{
				this.m_adboardsidelinedistance = value;
			}
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000FE38 File Offset: 0x0000E038
		public bool HasCloudyDay()
		{
			for (int i = 0; i < 4; i++)
			{
				if (this.m_timeofday[i] == 0)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x0000FE5E File Offset: 0x0000E05E
		public void SetCloudyDay(bool enable)
		{
			this.SetTimeOfDay(enable, this.HasSunnyDay(), this.HasNight(), this.HasSunset());
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x0000FE79 File Offset: 0x0000E079
		public void SetSunnyDay(bool enable)
		{
			this.SetTimeOfDay(this.HasCloudyDay(), enable, this.HasNight(), this.HasSunset());
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000FE94 File Offset: 0x0000E094
		public void SetNight(bool enable)
		{
			this.SetTimeOfDay(this.HasCloudyDay(), this.HasSunnyDay(), enable, this.HasSunset());
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000FEAF File Offset: 0x0000E0AF
		public void SetSunset(bool enable)
		{
			this.SetTimeOfDay(this.HasCloudyDay(), this.HasSunnyDay(), this.HasNight(), enable);
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x0000FECC File Offset: 0x0000E0CC
		private void SetTimeOfDay(bool hasCloudyDay, bool hasSunnyDay, bool hasNight, bool hasSunset)
		{
			int num = this.GetWeather();
			if (num == 2)
			{
				num = 3;
			}
			int num2 = 0;
			if (hasCloudyDay)
			{
				this.m_timeofday[num2] = 0;
				this.m_todweather[num2] = num;
				num2++;
			}
			if (hasSunnyDay)
			{
				this.m_timeofday[num2] = 1;
				this.m_todweather[num2] = 0;
				num2++;
			}
			if (hasNight)
			{
				this.m_timeofday[num2] = 3;
				this.m_todweather[num2] = num;
				num2++;
			}
			if (hasSunset)
			{
				this.m_timeofday[num2] = 4;
				this.m_todweather[num2] = 0;
				num2++;
			}
			for (int i = num2; i < 4; i++)
			{
				this.m_timeofday[i] = 5;
				this.m_todweather[i] = 0;
			}
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x0000FF6C File Offset: 0x0000E16C
		public bool HasSunnyDay()
		{
			for (int i = 0; i < 4; i++)
			{
				if (this.m_timeofday[i] == 1)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x0000FF94 File Offset: 0x0000E194
		public bool HasNight()
		{
			for (int i = 0; i < 4; i++)
			{
				if (this.m_timeofday[i] == 3)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000FFBC File Offset: 0x0000E1BC
		public bool HasSunset()
		{
			for (int i = 0; i < 4; i++)
			{
				if (this.m_timeofday[i] == 4)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000FFE4 File Offset: 0x0000E1E4
		public int GetWeather()
		{
			int num = 0;
			for (int i = 0; i < 4; i++)
			{
				if (this.m_todweather[i] != 5 && this.m_todweather[i] > num)
				{
					num = this.m_todweather[i];
				}
			}
			if (num == 3)
			{
				num = 2;
			}
			return num;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00010028 File Offset: 0x0000E228
		public void SetWeather(int weather)
		{
			if (weather == 2)
			{
				weather = 3;
			}
			for (int i = 0; i < 4; i++)
			{
				this.m_todweather[i] = ((this.m_timeofday[i] == 0 || this.m_timeofday[i] == 3) ? weather : 0);
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001FE RID: 510 RVA: 0x00010069 File Offset: 0x0000E269
		// (set) Token: 0x060001FF RID: 511 RVA: 0x00010071 File Offset: 0x0000E271
		public int stadiumgoalnettype
		{
			get
			{
				return this.m_stadiumgoalnettype;
			}
			set
			{
				this.m_stadiumgoalnettype = value;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x06000200 RID: 512 RVA: 0x0001007A File Offset: 0x0000E27A
		// (set) Token: 0x06000201 RID: 513 RVA: 0x00010082 File Offset: 0x0000E282
		public int stadiumgoalnettension
		{
			get
			{
				return this.m_stadiumgoalnettension;
			}
			set
			{
				this.m_stadiumgoalnettension = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000202 RID: 514 RVA: 0x0001008B File Offset: 0x0000E28B
		// (set) Token: 0x06000203 RID: 515 RVA: 0x00010093 File Offset: 0x0000E293
		public int cameraheight
		{
			get
			{
				return this.m_cameraheight;
			}
			set
			{
				this.m_cameraheight = value;
			}
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000204 RID: 516 RVA: 0x0001009C File Offset: 0x0000E29C
		// (set) Token: 0x06000205 RID: 517 RVA: 0x000100A4 File Offset: 0x0000E2A4
		public int camerazoom
		{
			get
			{
				return this.m_camerazoom;
			}
			set
			{
				this.m_camerazoom = value;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000206 RID: 518 RVA: 0x000100AD File Offset: 0x0000E2AD
		// (set) Token: 0x06000207 RID: 519 RVA: 0x000100B5 File Offset: 0x0000E2B5
		public string LocalName
		{
			get
			{
				return this.m_LocalName;
			}
			set
			{
				this.m_LocalName = value;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x000100C0 File Offset: 0x0000E2C0
		public Stadium(int stadiumid)
			: base(stadiumid)
		{
			this.m_name = "Stadium " + stadiumid.ToString();
			this.m_LocalName = this.m_name;
			this.m_seatcolor = 1;
			this.m_yearbuilt = 1950;
			this.m_countrycode = 0;
			this.m_policetypecode = 1;
			this.m_sectionfacedbydefault = 0;
			this.m_hometeamid = 0;
			this.m_capacity = 10000;
			this.m_stadiumtype = 0;
			this.m_stadiumgoalnetstyle = 0;
			this.m_stadiumgloalnetdepth = 229;
			this.m_stadiumgoalnetlength = 250;
			this.m_stadiumgoalnetwidth = 744;
			this.m_stadiummowpattern_code = 0;
			this.m_stadiumpitchlength = 10500;
			this.m_stadiumpitchwidth = 6800;
			this.m_adboardendlinedistance = 500;
			this.m_adboardsidelinedistance = 500;
			for (int i = 0; i < 4; i++)
			{
				this.m_timeofday[i] = 0;
				this.m_todweather[i] = 0;
			}
			this.m_dlc = 0;
			this.m_stadiumgoalnettype = 0;
			this.m_stadiumgoalnettension = 0;
			this.m_cameraheight = 15;
			this.m_camerazoom = 9;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000101ED File Offset: 0x0000E3ED
		public Stadium(Record r)
			: base(r.IntField[FI.stadiums_stadiumid])
		{
			this.Load(r);
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00010220 File Offset: 0x0000E420
		public void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			if (this.m_countrycode == 0)
			{
				this.m_Country = null;
				return;
			}
			this.m_Country = (Country)countryList.SearchId(this.m_countrycode);
			if (this.m_Country == null)
			{
				this.m_countrycode = 0;
				return;
			}
			this.m_countrycode = this.m_Country.Id;
		}

		// Token: 0x0600020B RID: 523 RVA: 0x0001027C File Offset: 0x0000E47C
		public void Load(Record r)
		{
			this.m_name = r.StringField[FI.stadiums_name];
			this.m_countrycode = r.GetAndCheckIntField(FI.stadiums_countrycode);
			this.m_hometeamid = r.GetAndCheckIntField(FI.stadiums_hometeamid);
			this.m_HomeTeam = null;
			this.m_capacity = r.GetAndCheckIntField(FI.stadiums_capacity);
			this.m_policetypecode = r.GetAndCheckIntField(FI.stadiums_policetypecode);
			this.m_seatcolor = r.GetAndCheckIntField(FI.stadiums_seatcolor);
			this.m_sectionfacedbydefault = r.GetAndCheckIntField(FI.stadiums_sectionfacedbydefault);
			this.m_stadiumgoalnetstyle = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnetstyle);
			this.m_stadiumgloalnetdepth = r.GetAndCheckIntField(FI.stadiums_stadiumgloalnetdepth);
			this.m_stadiumgoalnetlength = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnetlength);
			this.m_stadiumgoalnetwidth = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnetwidth);
			this.m_stadiummowpattern_code = r.GetAndCheckIntField(FI.stadiums_stadiummowpattern_code);
			this.m_stadiumpitchlength = r.GetAndCheckIntField(FI.stadiums_stadiumpitchlength);
			this.m_stadiumpitchwidth = r.GetAndCheckIntField(FI.stadiums_stadiumpitchwidth);
			this.m_adboardendlinedistance = r.GetAndCheckIntField(FI.stadiums_adboardendlinedistance);
			this.m_adboardsidelinedistance = r.GetAndCheckIntField(FI.stadiums_adboardsidelinedistance);
			this.m_timeofday[0] = r.GetAndCheckIntField(FI.stadiums_timeofday1);
			this.m_timeofday[1] = r.GetAndCheckIntField(FI.stadiums_timeofday2);
			this.m_timeofday[2] = r.GetAndCheckIntField(FI.stadiums_timeofday3);
			this.m_timeofday[3] = r.GetAndCheckIntField(FI.stadiums_timeofday4);
			this.m_todweather[0] = r.GetAndCheckIntField(FI.stadiums_tod1weather);
			this.m_todweather[1] = r.GetAndCheckIntField(FI.stadiums_tod2weather);
			this.m_todweather[2] = r.GetAndCheckIntField(FI.stadiums_tod3weather);
			this.m_todweather[3] = r.GetAndCheckIntField(FI.stadiums_tod4weather);
			this.m_dlc = r.GetAndCheckIntField(FI.stadiums_dlc);
			this.m_stadiumgoalnettype = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnettype);
			this.m_stadiumgoalnettension = r.GetAndCheckIntField(FI.stadiums_stadiumgoalnettension);
			this.m_cameraheight = r.GetAndCheckIntField(FI.stadiums_cameraheight);
			this.m_camerazoom = r.GetAndCheckIntField(FI.stadiums_camerazoom);
			this.m_stadiumtype = r.GetAndCheckIntField(FI.stadiums_stadiumtype);
			if (this.m_stadiumtype > 1)
			{
				this.m_stadiumtype = 1;
			}
			this.m_yearbuilt = r.GetAndCheckIntField(FI.stadiums_yearbuilt);
			if (FifaEnvironment.Language != null)
			{
				this.m_LocalName = FifaEnvironment.Language.GetStadiumName(base.Id);
			}
			else
			{
				this.m_LocalName = string.Empty;
			}
			this.m_managerhometopleftx = r.GetAndCheckIntField(FI.stadiums_managerhometopleftx);
			this.m_managerhometoplefty = r.GetAndCheckIntField(FI.stadiums_managerhometoplefty);
			this.m_managerhomebotrightx = r.GetAndCheckIntField(FI.stadiums_managerhomebotrightx);
			this.m_managerhomebotrighty = r.GetAndCheckIntField(FI.stadiums_managerhomebotrighty);
			this.m_managerawaytoplefty = r.GetAndCheckIntField(FI.stadiums_managerawaytoplefty);
			this.m_managerawaytopleftx = r.GetAndCheckIntField(FI.stadiums_managerawaytopleftx);
			this.m_managerawaybotrightx = r.GetAndCheckIntField(FI.stadiums_managerawaybotrightx);
			this.m_managerawaybotrighty = r.GetAndCheckIntField(FI.stadiums_managerawaybotrighty);
			this.m_subshometopleftx = r.GetAndCheckIntField(FI.stadiums_subshometopleftx);
			this.m_subshometoplefty = r.GetAndCheckIntField(FI.stadiums_subshometoplefty);
			this.m_subshomebotrightx = r.GetAndCheckIntField(FI.stadiums_subshomebotrightx);
			this.m_subshomebotrighty = r.GetAndCheckIntField(FI.stadiums_subshomebotrighty);
			this.m_subsawaytopleftx = r.GetAndCheckIntField(FI.stadiums_subsawaytopleftx);
			this.m_subsawaytoplefty = r.GetAndCheckIntField(FI.stadiums_subsawaytoplefty);
			this.m_subsawaybotrightx = r.GetAndCheckIntField(FI.stadiums_subsawaybotrightx);
			this.m_subsawaybotrighty = r.GetAndCheckIntField(FI.stadiums_subsawaybotrighty);
			this.m_upgradetier = r.GetAndCheckIntField(FI.stadiums_upgradetier);
			this.m_upgradestyle = r.GetAndCheckIntField(FI.stadiums_upgradestyle);
			this.m_iseditable = r.GetAndCheckIntField(FI.stadiums_iseditable);
			this.m_isdynamic = r.GetAndCheckIntField(FI.stadiums_isdynamic);
			this.m_genericrank = r.GetAndCheckIntField(FI.stadiums_genericrank);
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00010650 File Offset: 0x0000E850
		public override string ToString()
		{
			if (this.m_name != null && this.m_name != string.Empty)
			{
				return this.m_name;
			}
			return "Stadium n. " + base.Id.ToString();
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00010696 File Offset: 0x0000E896
		public string DatabaseString()
		{
			return this.m_name;
		}

		// Token: 0x0600020E RID: 526 RVA: 0x0001069E File Offset: 0x0000E89E
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			this.m_HomeTeam = (Team)teamList.SearchId(this.m_hometeamid);
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000106BC File Offset: 0x0000E8BC
		public override IdObject Clone(int stadiumid)
		{
			Stadium stadium = (Stadium)base.Clone(stadiumid);
			stadium.m_name = "Stadium " + stadiumid.ToString();
			stadium.m_LocalName = stadium.m_name;
			this.CloneModel(stadiumid);
			this.ClonePreview(stadiumid, 0);
			this.ClonePreview(stadiumid, 1);
			this.ClonePreview(stadiumid, 3);
			this.ClonePreview(stadiumid, 4);
			if (this.HasCloudyDay())
			{
				this.CloneContainer(stadiumid, 0);
				this.CloneCrowd(stadiumid, 0);
				this.CloneGlares(stadiumid, 0);
			}
			if (this.HasSunnyDay())
			{
				this.CloneContainer(stadiumid, 1);
				this.CloneCrowd(stadiumid, 1);
				this.CloneGlares(stadiumid, 1);
			}
			if (this.HasNight())
			{
				this.CloneContainer(stadiumid, 3);
				this.CloneCrowd(stadiumid, 3);
				this.CloneGlares(stadiumid, 3);
			}
			if (this.HasSunset())
			{
				this.CloneContainer(stadiumid, 4);
				this.CloneCrowd(stadiumid, 4);
				this.CloneGlares(stadiumid, 4);
			}
			return stadium;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000107A9 File Offset: 0x0000E9A9
		private void CloneContainer(int newId, int timeofday)
		{
			FifaEnvironment.CloneIntoZdata(this.TexturesFileName(timeofday), Stadium.TexturesFileName(newId, timeofday));
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000107BF File Offset: 0x0000E9BF
		private void ClonePreview(int newId, int timeofday)
		{
			FifaEnvironment.CloneIntoZdata(Stadium.PreviewBigFileName(base.Id, timeofday), Stadium.PreviewBigFileName(newId, timeofday));
			FifaEnvironment.CloneIntoZdata(Stadium.PreviewLargeBigFileName(base.Id, timeofday), Stadium.PreviewLargeBigFileName(newId, timeofday));
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000107F3 File Offset: 0x0000E9F3
		private void CloneModel(int newId)
		{
			FifaEnvironment.CloneIntoZdata(Stadium.ModelFileName(base.Id), Stadium.ModelFileName(newId));
		}

		// Token: 0x06000213 RID: 531 RVA: 0x0001080C File Offset: 0x0000EA0C
		public Bitmap GetNet()
		{
			return Net.GetNet(this.m_stadiumgoalnetstyle);
		}

		// Token: 0x06000214 RID: 532 RVA: 0x00010819 File Offset: 0x0000EA19
		public bool SetNet(Bitmap bitmap)
		{
			return Net.SetNet(this.m_stadiumgoalnetstyle, bitmap);
		}

		// Token: 0x06000215 RID: 533 RVA: 0x00010827 File Offset: 0x0000EA27
		public bool SetNet(string rx3FileName)
		{
			return Net.SetNet(this.m_stadiumgoalnetstyle, rx3FileName);
		}

		// Token: 0x06000216 RID: 534 RVA: 0x00010835 File Offset: 0x0000EA35
		public bool DeleteNet()
		{
			return Net.DeleteNet(this.m_stadiumgoalnetstyle);
		}

		// Token: 0x06000217 RID: 535 RVA: 0x00010842 File Offset: 0x0000EA42
		public Bitmap GetMowingPattern()
		{
			return MowingPattern.GetMowingPattern(this.m_stadiummowpattern_code);
		}

		// Token: 0x06000218 RID: 536 RVA: 0x0001084F File Offset: 0x0000EA4F
		public bool SetMowingPattern(Bitmap bitmap)
		{
			return MowingPattern.SetMowingPattern(this.m_stadiummowpattern_code, bitmap);
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0001085D File Offset: 0x0000EA5D
		public bool SetMowingPattern(string rx3FileName)
		{
			return MowingPattern.SetMowingPattern(this.m_stadiummowpattern_code, rx3FileName);
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0001086B File Offset: 0x0000EA6B
		public bool DeleteMowingPattern()
		{
			return MowingPattern.DeleteMowingPattern(this.m_stadiummowpattern_code);
		}

		// Token: 0x0600021B RID: 539 RVA: 0x00010878 File Offset: 0x0000EA78
		public void SaveStadium(Record r)
		{
			r.IntField[FI.stadiums_stadiumid] = base.Id;
			r.StringField[FI.stadiums_name] = this.m_name;
			r.IntField[FI.stadiums_countrycode] = this.m_countrycode;
			r.IntField[FI.stadiums_hometeamid] = this.m_hometeamid;
			r.IntField[FI.stadiums_capacity] = this.m_capacity;
			r.IntField[FI.stadiums_policetypecode] = this.m_policetypecode;
			r.IntField[FI.stadiums_seatcolor] = this.m_seatcolor;
			r.IntField[FI.stadiums_sectionfacedbydefault] = this.m_sectionfacedbydefault;
			r.IntField[FI.stadiums_stadiumgoalnetstyle] = this.m_stadiumgoalnetstyle;
			r.IntField[FI.stadiums_stadiumgloalnetdepth] = this.m_stadiumgloalnetdepth;
			r.IntField[FI.stadiums_stadiumgoalnetlength] = this.m_stadiumgoalnetlength;
			r.IntField[FI.stadiums_stadiumgoalnetwidth] = this.m_stadiumgoalnetwidth;
			r.IntField[FI.stadiums_stadiummowpattern_code] = this.m_stadiummowpattern_code;
			r.IntField[FI.stadiums_stadiumpitchlength] = this.m_stadiumpitchlength;
			r.IntField[FI.stadiums_stadiumpitchwidth] = this.m_stadiumpitchwidth;
			r.IntField[FI.stadiums_adboardendlinedistance] = this.m_adboardendlinedistance;
			r.IntField[FI.stadiums_adboardsidelinedistance] = this.m_adboardsidelinedistance;
			r.IntField[FI.stadiums_timeofday1] = this.m_timeofday[0];
			r.IntField[FI.stadiums_timeofday2] = this.m_timeofday[1];
			r.IntField[FI.stadiums_timeofday3] = this.m_timeofday[2];
			r.IntField[FI.stadiums_timeofday4] = this.m_timeofday[3];
			r.IntField[FI.stadiums_tod1weather] = this.m_todweather[0];
			r.IntField[FI.stadiums_tod2weather] = this.m_todweather[1];
			r.IntField[FI.stadiums_tod3weather] = this.m_todweather[2];
			r.IntField[FI.stadiums_tod4weather] = this.m_todweather[3];
			r.IntField[FI.stadiums_dlc] = this.m_dlc;
			r.IntField[FI.stadiums_stadiumtype] = this.m_stadiumtype;
			r.IntField[FI.stadiums_yearbuilt] = this.m_yearbuilt;
			r.IntField[FI.stadiums_stadiumgoalnettype] = this.m_stadiumgoalnettype;
			r.IntField[FI.stadiums_stadiumgoalnettension] = this.m_stadiumgoalnettension;
			r.IntField[FI.stadiums_cameraheight] = this.m_cameraheight;
			r.IntField[FI.stadiums_camerazoom] = this.m_camerazoom;
			r.IntField[FI.stadiums_managerhometopleftx] = this.m_managerhometopleftx;
			r.IntField[FI.stadiums_managerhometoplefty] = this.m_managerhometoplefty;
			r.IntField[FI.stadiums_managerhomebotrightx] = this.m_managerhomebotrightx;
			r.IntField[FI.stadiums_managerhomebotrighty] = this.m_managerhomebotrighty;
			r.IntField[FI.stadiums_managerawaytoplefty] = this.m_managerawaytoplefty;
			r.IntField[FI.stadiums_managerawaytopleftx] = this.m_managerawaytopleftx;
			r.IntField[FI.stadiums_managerawaybotrightx] = this.m_managerawaybotrightx;
			r.IntField[FI.stadiums_managerawaybotrighty] = this.m_managerawaybotrighty;
			r.IntField[FI.stadiums_subshometopleftx] = this.m_subshometopleftx;
			r.IntField[FI.stadiums_subshometoplefty] = this.m_subshometoplefty;
			r.IntField[FI.stadiums_subshomebotrightx] = this.m_subshomebotrightx;
			r.IntField[FI.stadiums_subshomebotrighty] = this.m_subshomebotrighty;
			r.IntField[FI.stadiums_subsawaytopleftx] = this.m_subsawaytopleftx;
			r.IntField[FI.stadiums_subsawaytoplefty] = this.m_subsawaytoplefty;
			r.IntField[FI.stadiums_subsawaybotrightx] = this.m_subsawaybotrightx;
			r.IntField[FI.stadiums_subsawaybotrighty] = this.m_subsawaybotrighty;
			r.IntField[FI.stadiums_upgradetier] = this.m_upgradetier;
			r.IntField[FI.stadiums_upgradestyle] = this.m_upgradestyle;
			r.IntField[FI.stadiums_iseditable] = this.m_iseditable;
			r.IntField[FI.stadiums_isdynamic] = this.m_isdynamic;
			r.IntField[FI.stadiums_genericrank] = this.m_genericrank;
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetStadiumName(base.Id, this.m_LocalName);
			}
		}

		// Token: 0x0600021C RID: 540 RVA: 0x00010C6C File Offset: 0x0000EE6C
		public void SaveLangTable()
		{
			if (FifaEnvironment.Language != null)
			{
				FifaEnvironment.Language.SetStadiumName(base.Id, this.m_LocalName);
			}
		}

		// Token: 0x0600021D RID: 541 RVA: 0x00010C8C File Offset: 0x0000EE8C
		public static string PreviewBigFileName(int stadiumid, int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/ui/artassets/stadium/stadium_",
				stadiumid.ToString(),
				"_",
				timeofday.ToString(),
				".big"
			});
		}

		// Token: 0x0600021E RID: 542 RVA: 0x00010CD4 File Offset: 0x0000EED4
		public string PreviewBigFileName(int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/ui/artassets/stadium/stadium_",
				base.Id.ToString(),
				"_",
				timeofday.ToString(),
				".big"
			});
		}

		// Token: 0x0600021F RID: 543 RVA: 0x00010D21 File Offset: 0x0000EF21
		public string PreviewTemplateFileName()
		{
			return "data/ui/artassets/stadium/stadium_#_%.big";
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00010D28 File Offset: 0x0000EF28
		public string PreviewDdsFileName()
		{
			return "2";
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00010D2F File Offset: 0x0000EF2F
		public Bitmap GetPreview(int timeofday)
		{
			return FifaEnvironment.GetArtasset(this.PreviewBigFileName(timeofday));
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00010D40 File Offset: 0x0000EF40
		public bool SetPreview(int timeofday, Bitmap bitmap)
		{
			int[] array = new int[] { base.Id, timeofday };
			return FifaEnvironment.SetArtasset(this.PreviewTemplateFileName(), this.PreviewDdsFileName(), array, bitmap);
		}

		// Token: 0x06000223 RID: 547 RVA: 0x00010D74 File Offset: 0x0000EF74
		public bool DeletePreview(int timeofday)
		{
			return FifaEnvironment.DeleteFromZdata(this.PreviewBigFileName(timeofday));
		}

		// Token: 0x06000224 RID: 548 RVA: 0x00010D82 File Offset: 0x0000EF82
		private void CloneTimeOfDayPreview(int newTimeOfDay, int timeofday)
		{
			FifaEnvironment.CloneIntoZdata(this.PreviewBigFileName(timeofday), this.PreviewBigFileName(newTimeOfDay));
		}

		// Token: 0x06000225 RID: 549 RVA: 0x00010D98 File Offset: 0x0000EF98
		public static string PreviewLargeBigFileName(int stadiumid, int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/ui/artassets/stadiumsbig/st_",
				stadiumid.ToString(),
				"_",
				timeofday.ToString(),
				".big"
			});
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00010DE0 File Offset: 0x0000EFE0
		public string PreviewLargeBigFileName(int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/ui/artassets/stadiumsbig/st_",
				base.Id.ToString(),
				"_",
				timeofday.ToString(),
				".big"
			});
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00010E2D File Offset: 0x0000F02D
		public string PreviewLargeTemplateFileName()
		{
			return "data/ui/artassets/stadiumsbig/st_#_%.big";
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00010E34 File Offset: 0x0000F034
		public string PreviewLargeDdsFileName()
		{
			return "2";
		}

		// Token: 0x06000229 RID: 553 RVA: 0x00010E3B File Offset: 0x0000F03B
		public Bitmap GetPreviewLarge(int timeofday)
		{
			return FifaEnvironment.GetArtasset(this.PreviewLargeBigFileName(timeofday));
		}

		// Token: 0x0600022A RID: 554 RVA: 0x00010E4C File Offset: 0x0000F04C
		public bool SetPreviewLarge(int timeofday, Bitmap bitmap)
		{
			int[] array = new int[] { base.Id, timeofday };
			return FifaEnvironment.SetArtasset(this.PreviewLargeTemplateFileName(), this.PreviewLargeDdsFileName(), array, bitmap);
		}

		// Token: 0x0600022B RID: 555 RVA: 0x00010E80 File Offset: 0x0000F080
		public bool DeletePreviewLarge(int timeofday)
		{
			return FifaEnvironment.DeleteFromZdata(this.PreviewLargeBigFileName(timeofday));
		}

		// Token: 0x0600022C RID: 556 RVA: 0x00010E8E File Offset: 0x0000F08E
		private void CloneTimeOfDayPreviewLarge(int newTimeOfDay, int timeofday)
		{
			FifaEnvironment.CloneIntoZdata(this.PreviewLargeBigFileName(timeofday), this.PreviewLargeBigFileName(newTimeOfDay));
		}

		// Token: 0x0600022D RID: 557 RVA: 0x00010EA4 File Offset: 0x0000F0A4
		public static string TexturesFileName(int stadiumid, int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/stadium/stadium_",
				stadiumid.ToString(),
				"_",
				timeofday.ToString(),
				"_textures.rx3"
			});
		}

		// Token: 0x0600022E RID: 558 RVA: 0x00010EEC File Offset: 0x0000F0EC
		public string TexturesFileName(int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/stadium/stadium_",
				base.Id.ToString(),
				"_",
				timeofday.ToString(),
				"_textures.rx3"
			});
		}

		// Token: 0x0600022F RID: 559 RVA: 0x00010F39 File Offset: 0x0000F139
		public string TexturesTemplateFileName()
		{
			return "data/sceneassets/stadium/stadium_#_%_textures.rx3";
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00010F40 File Offset: 0x0000F140
		public Bitmap[] GetTextures(int timeofday)
		{
			return FifaEnvironment.GetBmpsFromRx3(this.TexturesFileName(timeofday));
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00010F4E File Offset: 0x0000F14E
		public bool SetTextures(int timeofday, Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoStadium(this.TexturesFileName(timeofday), bitmaps);
		}

		// Token: 0x06000232 RID: 562 RVA: 0x00010F5D File Offset: 0x0000F15D
		public bool SetTextures(int timeofday, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.TexturesFileName(timeofday), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00010F6E File Offset: 0x0000F16E
		public bool DeleteContainer(int timeofday)
		{
			return FifaEnvironment.DeleteFromZdata(this.TexturesFileName(timeofday));
		}

		// Token: 0x06000234 RID: 564 RVA: 0x00010F7C File Offset: 0x0000F17C
		public static string ModelFileName(int stadiumid)
		{
			return "data/sceneassets/stadium/stadium_" + stadiumid.ToString() + ".rx3";
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00010F94 File Offset: 0x0000F194
		public string ModelFileName()
		{
			return "data/sceneassets/stadium/stadium_" + base.Id.ToString() + ".rx3";
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00010FBE File Offset: 0x0000F1BE
		public string ModelTemplateFileName()
		{
			return "data/sceneassets/stadium/stadium_#.rx3";
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00010FC5 File Offset: 0x0000F1C5
		public Rx3File GetModel()
		{
			return FifaEnvironment.GetRx3FromZdata(this.ModelFileName());
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00010FD2 File Offset: 0x0000F1D2
		public bool SetModel(string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.ModelFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000239 RID: 569 RVA: 0x00010FE2 File Offset: 0x0000F1E2
		public bool DeleteModel(int timeofday)
		{
			return FifaEnvironment.DeleteFromZdata(this.ModelFileName());
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00010FF0 File Offset: 0x0000F1F0
		public static string CrowdFileName(int stadiumid, int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/crowdplacement/crowd_",
				stadiumid.ToString(),
				"_",
				timeofday.ToString(),
				".dat"
			});
		}

		// Token: 0x0600023B RID: 571 RVA: 0x00011038 File Offset: 0x0000F238
		public string CrowdFileName(int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/crowdplacement/crowd_",
				base.Id.ToString(),
				"_",
				timeofday.ToString(),
				".dat"
			});
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00011085 File Offset: 0x0000F285
		public bool CloneCrowd(int newId, int timeofday)
		{
			return FifaEnvironment.CloneIntoZdata(this.CrowdFileName(timeofday), Stadium.CrowdFileName(newId, timeofday));
		}

		// Token: 0x0600023D RID: 573 RVA: 0x0001109A File Offset: 0x0000F29A
		public bool SetCrowd(int timeofday, string datFileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(datFileName, this.CrowdFileName(timeofday), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x0600023E RID: 574 RVA: 0x000110AB File Offset: 0x0000F2AB
		public void CloneTimeOfDayCrowd(int newTimeOfDay, int timeofday)
		{
			FifaEnvironment.CloneIntoZdata(this.CrowdFileName(timeofday), this.CrowdFileName(newTimeOfDay));
		}

		// Token: 0x0600023F RID: 575 RVA: 0x000110C4 File Offset: 0x0000F2C4
		public static string GlaresLightFileName(int stadiumid, int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/fx/glares_",
				stadiumid.ToString(),
				"_",
				timeofday.ToString(),
				".lnx"
			});
		}

		// Token: 0x06000240 RID: 576 RVA: 0x0001110C File Offset: 0x0000F30C
		public string GlaresLightFileName(int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/fx/glares_",
				base.Id.ToString(),
				"_",
				timeofday.ToString(),
				".lnx"
			});
		}

		// Token: 0x06000241 RID: 577 RVA: 0x0001115C File Offset: 0x0000F35C
		public static string GlaresTextureFileName(int stadiumid, int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/fx/glares_",
				stadiumid.ToString(),
				"_",
				timeofday.ToString(),
				".rx3"
			});
		}

		// Token: 0x06000242 RID: 578 RVA: 0x000111A4 File Offset: 0x0000F3A4
		public string GlaresTextureFileName(int timeofday)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/fx/glares_",
				base.Id.ToString(),
				"_",
				timeofday.ToString(),
				".rx3"
			});
		}

		// Token: 0x06000243 RID: 579 RVA: 0x000111F4 File Offset: 0x0000F3F4
		public bool CloneGlares(int newId, int timeofday)
		{
			bool flag = FifaEnvironment.CloneIntoZdata(this.GlaresLightFileName(timeofday), Stadium.GlaresLightFileName(newId, timeofday));
			return flag && FifaEnvironment.CloneIntoZdata(this.GlaresTextureFileName(timeofday), Stadium.GlaresTextureFileName(newId, timeofday));
		}

		// Token: 0x06000244 RID: 580 RVA: 0x00011230 File Offset: 0x0000F430
		private bool CloneTimeOfDayGlares(int newTimeOfDay, int timeofday)
		{
			bool flag = FifaEnvironment.CloneIntoZdata(this.GlaresLightFileName(timeofday), this.GlaresLightFileName(newTimeOfDay));
			return flag && FifaEnvironment.CloneIntoZdata(this.GlaresTextureFileName(timeofday), this.GlaresTextureFileName(newTimeOfDay));
		}

		// Token: 0x06000245 RID: 581 RVA: 0x0001126C File Offset: 0x0000F46C
		public bool SetGlaresLight(int timeofday, string srcFileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, this.GlaresLightFileName(timeofday), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000246 RID: 582 RVA: 0x0001127D File Offset: 0x0000F47D
		public bool SetGlaresTexture(int timeofday, string srcFileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, this.GlaresTextureFileName(timeofday), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x040000DD RID: 221
		private string m_name;

		// Token: 0x040000DE RID: 222
		private int m_countrycode;

		// Token: 0x040000DF RID: 223
		private Country m_Country;

		// Token: 0x040000E0 RID: 224
		private int m_policetypecode;

		// Token: 0x040000E1 RID: 225
		private int m_sectionfacedbydefault;

		// Token: 0x040000E2 RID: 226
		private int m_hometeamid;

		// Token: 0x040000E3 RID: 227
		private Team m_HomeTeam;

		// Token: 0x040000E4 RID: 228
		private int m_capacity;

		// Token: 0x040000E5 RID: 229
		private int m_yearbuilt;

		// Token: 0x040000E6 RID: 230
		private int m_seatcolor;

		// Token: 0x040000E7 RID: 231
		private int m_stadiumtype;

		// Token: 0x040000E8 RID: 232
		private int m_stadiumgoalnetstyle;

		// Token: 0x040000E9 RID: 233
		private int m_stadiumgloalnetdepth;

		// Token: 0x040000EA RID: 234
		private int m_stadiumgoalnetlength;

		// Token: 0x040000EB RID: 235
		private int m_stadiumgoalnetwidth;

		// Token: 0x040000EC RID: 236
		private int m_stadiummowpattern_code;

		// Token: 0x040000ED RID: 237
		private int m_stadiumpitchlength;

		// Token: 0x040000EE RID: 238
		private int m_stadiumpitchwidth;

		// Token: 0x040000EF RID: 239
		private int m_adboardendlinedistance;

		// Token: 0x040000F0 RID: 240
		private int m_adboardsidelinedistance;

		// Token: 0x040000F1 RID: 241
		private int[] m_timeofday = new int[4];

		// Token: 0x040000F2 RID: 242
		private int[] m_todweather = new int[4];

		// Token: 0x040000F3 RID: 243
		private int m_dlc;

		// Token: 0x040000F4 RID: 244
		private int m_stadiumgoalnettype;

		// Token: 0x040000F5 RID: 245
		private int m_stadiumgoalnettension;

		// Token: 0x040000F6 RID: 246
		private int m_cameraheight;

		// Token: 0x040000F7 RID: 247
		private int m_camerazoom;

		// Token: 0x040000F8 RID: 248
		private string m_LocalName;

		// Token: 0x040000F9 RID: 249
		private int m_managerhometopleftx;

		// Token: 0x040000FA RID: 250
		private int m_managerhometoplefty;

		// Token: 0x040000FB RID: 251
		private int m_managerhomebotrightx;

		// Token: 0x040000FC RID: 252
		private int m_managerhomebotrighty;

		// Token: 0x040000FD RID: 253
		private int m_managerawaytoplefty;

		// Token: 0x040000FE RID: 254
		private int m_managerawaytopleftx;

		// Token: 0x040000FF RID: 255
		private int m_managerawaybotrightx;

		// Token: 0x04000100 RID: 256
		private int m_managerawaybotrighty;

		// Token: 0x04000101 RID: 257
		private int m_subshometopleftx;

		// Token: 0x04000102 RID: 258
		private int m_subshometoplefty;

		// Token: 0x04000103 RID: 259
		private int m_subshomebotrightx;

		// Token: 0x04000104 RID: 260
		private int m_subshomebotrighty;

		// Token: 0x04000105 RID: 261
		private int m_subsawaytopleftx;

		// Token: 0x04000106 RID: 262
		private int m_subsawaytoplefty;

		// Token: 0x04000107 RID: 263
		private int m_subsawaybotrightx;

		// Token: 0x04000108 RID: 264
		private int m_subsawaybotrighty;

		// Token: 0x04000109 RID: 265
		private int m_upgradetier;

		// Token: 0x0400010A RID: 266
		private int m_upgradestyle;

		// Token: 0x0400010B RID: 267
		private int m_iseditable;

		// Token: 0x0400010C RID: 268
		private int m_isdynamic;

		// Token: 0x0400010D RID: 269
		private int m_genericrank;

		// Token: 0x0200001F RID: 31
		public enum ETimeOfDay
		{
			// Token: 0x0400010F RID: 271
			Cloudy,
			// Token: 0x04000110 RID: 272
			Sunny,
			// Token: 0x04000111 RID: 273
			Night = 3,
			// Token: 0x04000112 RID: 274
			Sunset
		}

		// Token: 0x02000020 RID: 32
		public enum EWeather
		{
			// Token: 0x04000114 RID: 276
			Dry,
			// Token: 0x04000115 RID: 277
			CanRain,
			// Token: 0x04000116 RID: 278
			CanSnow = 3
		}
	}
}
