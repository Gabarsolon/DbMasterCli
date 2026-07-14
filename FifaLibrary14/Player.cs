using System;
using System.Drawing;
using Microsoft.DirectX.Direct3D;

namespace FifaLibrary
{
	// Token: 0x02000027 RID: 39
	public class Player : IdObject
	{
		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600029F RID: 671 RVA: 0x00013383 File Offset: 0x00011583
		// (set) Token: 0x060002A0 RID: 672 RVA: 0x0001338A File Offset: 0x0001158A
		public static PlayerNames PlayerNames
		{
			get
			{
				return Player.s_PlayerNames;
			}
			set
			{
				Player.s_PlayerNames = value;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060002A1 RID: 673 RVA: 0x00013392 File Offset: 0x00011592
		public bool HasSpecificHeadModel
		{
			get
			{
				return this.m_headclasscode == 0;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060002A2 RID: 674 RVA: 0x0001339D File Offset: 0x0001159D
		public Bitmap EyesTextureBitmap
		{
			get
			{
				return this.m_EyesTextureBitmap;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060002A3 RID: 675 RVA: 0x000133A5 File Offset: 0x000115A5
		public Bitmap FaceTextureBitmap
		{
			get
			{
				return this.m_FaceTextureBitmap;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000133AD File Offset: 0x000115AD
		public Bitmap HairColorTextureBitmap
		{
			get
			{
				return this.m_HairColorTextureBitmap;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060002A5 RID: 677 RVA: 0x000133B5 File Offset: 0x000115B5
		public Bitmap HairAlfaTextureBitmap
		{
			get
			{
				return this.m_HairAlfaTextureBitmap;
			}
		}

		// Token: 0x060002A6 RID: 678 RVA: 0x000133BD File Offset: 0x000115BD
		public Team IsInTopLeague()
		{
			return this.m_PlayingForTeams.IsInTopLeague();
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060002A7 RID: 679 RVA: 0x000133CA File Offset: 0x000115CA
		// (set) Token: 0x060002A8 RID: 680 RVA: 0x000133D2 File Offset: 0x000115D2
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

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060002A9 RID: 681 RVA: 0x000133DB File Offset: 0x000115DB
		// (set) Token: 0x060002AA RID: 682 RVA: 0x000133E3 File Offset: 0x000115E3
		public string lastname
		{
			get
			{
				return this.m_lastname;
			}
			set
			{
				this.m_lastname = value;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060002AB RID: 683 RVA: 0x000133EC File Offset: 0x000115EC
		// (set) Token: 0x060002AC RID: 684 RVA: 0x000133F4 File Offset: 0x000115F4
		public int lastnameKey
		{
			get
			{
				return this.m_lastnameKey;
			}
			set
			{
				this.m_lastnameKey = value;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060002AD RID: 685 RVA: 0x000133FD File Offset: 0x000115FD
		public string Name
		{
			get
			{
				if (this.m_commonname != null && this.m_commonname != string.Empty)
				{
					return this.m_commonname;
				}
				return this.m_lastname;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060002AE RID: 686 RVA: 0x00013426 File Offset: 0x00011626
		// (set) Token: 0x060002AF RID: 687 RVA: 0x0001342E File Offset: 0x0001162E
		public string commonname
		{
			get
			{
				return this.m_commonname;
			}
			set
			{
				this.m_commonname = value;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x00013437 File Offset: 0x00011637
		// (set) Token: 0x060002B1 RID: 689 RVA: 0x0001343F File Offset: 0x0001163F
		public string playerjerseyname
		{
			get
			{
				return this.m_playerjerseyname;
			}
			set
			{
				this.m_playerjerseyname = value;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x00013448 File Offset: 0x00011648
		// (set) Token: 0x060002B3 RID: 691 RVA: 0x00013450 File Offset: 0x00011650
		public int firstnameid
		{
			get
			{
				return this.m_firstnameid;
			}
			set
			{
				this.m_firstnameid = value;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x00013459 File Offset: 0x00011659
		// (set) Token: 0x060002B5 RID: 693 RVA: 0x00013461 File Offset: 0x00011661
		public int lastnameid
		{
			get
			{
				return this.m_lastnameid;
			}
			set
			{
				this.m_lastnameid = value;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0001346A File Offset: 0x0001166A
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x00013472 File Offset: 0x00011672
		public int commonnameid
		{
			get
			{
				return this.m_commonnameid;
			}
			set
			{
				this.m_commonnameid = value;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060002B8 RID: 696 RVA: 0x0001347B File Offset: 0x0001167B
		// (set) Token: 0x060002B9 RID: 697 RVA: 0x00013483 File Offset: 0x00011683
		public int playerjerseynameid
		{
			get
			{
				return this.m_playerjerseynameid;
			}
			set
			{
				this.m_playerjerseynameid = value;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060002BA RID: 698 RVA: 0x0001348C File Offset: 0x0001168C
		// (set) Token: 0x060002BB RID: 699 RVA: 0x00013494 File Offset: 0x00011694
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

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0001349D File Offset: 0x0001169D
		// (set) Token: 0x060002BD RID: 701 RVA: 0x000134A5 File Offset: 0x000116A5
		public DateTime joindate
		{
			get
			{
				return this.m_playerjointeamdate;
			}
			set
			{
				this.m_playerjointeamdate = value;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060002BE RID: 702 RVA: 0x000134AE File Offset: 0x000116AE
		// (set) Token: 0x060002BF RID: 703 RVA: 0x000134B6 File Offset: 0x000116B6
		public int contractvaliduntil
		{
			get
			{
				return this.m_contractvaliduntil;
			}
			set
			{
				this.m_contractvaliduntil = value;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x000134BF File Offset: 0x000116BF
		// (set) Token: 0x060002C1 RID: 705 RVA: 0x000134C7 File Offset: 0x000116C7
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

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060002C2 RID: 706 RVA: 0x000134D0 File Offset: 0x000116D0
		// (set) Token: 0x060002C3 RID: 707 RVA: 0x000134D8 File Offset: 0x000116D8
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

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060002C4 RID: 708 RVA: 0x000134E1 File Offset: 0x000116E1
		// (set) Token: 0x060002C5 RID: 709 RVA: 0x000134E9 File Offset: 0x000116E9
		public int nationality
		{
			get
			{
				return this.m_nationality;
			}
			set
			{
				this.m_nationality = value;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002C6 RID: 710 RVA: 0x000134F2 File Offset: 0x000116F2
		// (set) Token: 0x060002C7 RID: 711 RVA: 0x000134FA File Offset: 0x000116FA
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
					this.m_nationality = this.Country.Id;
					return;
				}
				this.m_nationality = 0;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002C8 RID: 712 RVA: 0x00013524 File Offset: 0x00011724
		// (set) Token: 0x060002C9 RID: 713 RVA: 0x0001352C File Offset: 0x0001172C
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

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002CA RID: 714 RVA: 0x0001353C File Offset: 0x0001173C
		// (set) Token: 0x060002CB RID: 715 RVA: 0x00013544 File Offset: 0x00011744
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

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002CC RID: 716 RVA: 0x00013554 File Offset: 0x00011754
		// (set) Token: 0x060002CD RID: 717 RVA: 0x0001355C File Offset: 0x0001175C
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

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002CE RID: 718 RVA: 0x00013565 File Offset: 0x00011765
		// (set) Token: 0x060002CF RID: 719 RVA: 0x0001356D File Offset: 0x0001176D
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

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002D0 RID: 720 RVA: 0x0001357D File Offset: 0x0001177D
		// (set) Token: 0x060002D1 RID: 721 RVA: 0x00013585 File Offset: 0x00011785
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

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002D2 RID: 722 RVA: 0x00013595 File Offset: 0x00011795
		// (set) Token: 0x060002D3 RID: 723 RVA: 0x0001359D File Offset: 0x0001179D
		public int headclasscode
		{
			get
			{
				return this.m_headclasscode;
			}
			set
			{
				this.m_headclasscode = value;
				this.m_HairAlfaTextureBitmap = null;
				this.m_HairColorTextureBitmap = null;
				this.m_FaceTextureBitmap = null;
				this.m_EyesTextureBitmap = null;
				this.m_HeadModelFile = null;
				this.m_HairModelFile = null;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002D4 RID: 724 RVA: 0x000135D0 File Offset: 0x000117D0
		// (set) Token: 0x060002D5 RID: 725 RVA: 0x000135D8 File Offset: 0x000117D8
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

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002D6 RID: 726 RVA: 0x000135EF File Offset: 0x000117EF
		// (set) Token: 0x060002D7 RID: 727 RVA: 0x000135F7 File Offset: 0x000117F7
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

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x00013607 File Offset: 0x00011807
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x0001360F File Offset: 0x0001180F
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

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002DA RID: 730 RVA: 0x0001361F File Offset: 0x0001181F
		// (set) Token: 0x060002DB RID: 731 RVA: 0x00013627 File Offset: 0x00011827
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

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002DC RID: 732 RVA: 0x00013637 File Offset: 0x00011837
		// (set) Token: 0x060002DD RID: 733 RVA: 0x0001363F File Offset: 0x0001183F
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

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002DE RID: 734 RVA: 0x0001364F File Offset: 0x0001184F
		// (set) Token: 0x060002DF RID: 735 RVA: 0x00013657 File Offset: 0x00011857
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

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002E0 RID: 736 RVA: 0x00013667 File Offset: 0x00011867
		// (set) Token: 0x060002E1 RID: 737 RVA: 0x0001366F File Offset: 0x0001186F
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

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002E2 RID: 738 RVA: 0x00013678 File Offset: 0x00011878
		// (set) Token: 0x060002E3 RID: 739 RVA: 0x00013680 File Offset: 0x00011880
		public int jerseystylecode
		{
			get
			{
				return this.m_jerseystylecode;
			}
			set
			{
				this.m_jerseystylecode = value;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002E4 RID: 740 RVA: 0x00013689 File Offset: 0x00011889
		// (set) Token: 0x060002E5 RID: 741 RVA: 0x00013691 File Offset: 0x00011891
		public int hasseasonaljersey
		{
			get
			{
				return this.m_hasseasonaljersey;
			}
			set
			{
				this.m_hasseasonaljersey = value;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002E6 RID: 742 RVA: 0x0001369A File Offset: 0x0001189A
		// (set) Token: 0x060002E7 RID: 743 RVA: 0x000136A2 File Offset: 0x000118A2
		public int animfreekickstartposcode
		{
			get
			{
				return this.m_animfreekickstartposcode;
			}
			set
			{
				this.m_animfreekickstartposcode = value;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002E8 RID: 744 RVA: 0x000136AB File Offset: 0x000118AB
		// (set) Token: 0x060002E9 RID: 745 RVA: 0x000136B3 File Offset: 0x000118B3
		public int animpenaltieskickstylecode
		{
			get
			{
				return this.m_animpenaltieskickstylecode;
			}
			set
			{
				this.m_animpenaltieskickstylecode = value;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002EA RID: 746 RVA: 0x000136BC File Offset: 0x000118BC
		// (set) Token: 0x060002EB RID: 747 RVA: 0x000136C4 File Offset: 0x000118C4
		public int animpenaltiesmotionstylecode
		{
			get
			{
				return this.m_animpenaltiesmotionstylecode;
			}
			set
			{
				this.m_animpenaltiesmotionstylecode = value;
			}
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002EC RID: 748 RVA: 0x000136CD File Offset: 0x000118CD
		// (set) Token: 0x060002ED RID: 749 RVA: 0x000136D5 File Offset: 0x000118D5
		public int animpenaltiesstartposcode
		{
			get
			{
				return this.m_animpenaltiesstartposcode;
			}
			set
			{
				this.m_animpenaltiesstartposcode = value;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002EE RID: 750 RVA: 0x000136DE File Offset: 0x000118DE
		// (set) Token: 0x060002EF RID: 751 RVA: 0x000136E6 File Offset: 0x000118E6
		public int accessorycode1
		{
			get
			{
				return this.m_accessorycode1;
			}
			set
			{
				this.m_accessorycode1 = value;
			}
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x000136EF File Offset: 0x000118EF
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x000136F7 File Offset: 0x000118F7
		public int accessorycolourcode1
		{
			get
			{
				return this.m_accessorycolourcode1;
			}
			set
			{
				this.m_accessorycolourcode1 = value;
			}
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x00013700 File Offset: 0x00011900
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x00013708 File Offset: 0x00011908
		public int accessorycode2
		{
			get
			{
				return this.m_accessorycode2;
			}
			set
			{
				this.m_accessorycode2 = value;
			}
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002F4 RID: 756 RVA: 0x00013711 File Offset: 0x00011911
		// (set) Token: 0x060002F5 RID: 757 RVA: 0x00013719 File Offset: 0x00011919
		public int accessorycolourcode2
		{
			get
			{
				return this.m_accessorycolourcode2;
			}
			set
			{
				this.m_accessorycolourcode2 = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002F6 RID: 758 RVA: 0x00013722 File Offset: 0x00011922
		// (set) Token: 0x060002F7 RID: 759 RVA: 0x0001372A File Offset: 0x0001192A
		public int accessorycode3
		{
			get
			{
				return this.m_accessorycode3;
			}
			set
			{
				this.m_accessorycode3 = value;
			}
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x00013733 File Offset: 0x00011933
		// (set) Token: 0x060002F9 RID: 761 RVA: 0x0001373B File Offset: 0x0001193B
		public int accessorycolourcode3
		{
			get
			{
				return this.m_accessorycolourcode3;
			}
			set
			{
				this.m_accessorycolourcode3 = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002FA RID: 762 RVA: 0x00013744 File Offset: 0x00011944
		// (set) Token: 0x060002FB RID: 763 RVA: 0x0001374C File Offset: 0x0001194C
		public int accessorycode4
		{
			get
			{
				return this.m_accessorycode4;
			}
			set
			{
				this.m_accessorycode4 = value;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00013755 File Offset: 0x00011955
		// (set) Token: 0x060002FD RID: 765 RVA: 0x0001375D File Offset: 0x0001195D
		public int accessorycolourcode4
		{
			get
			{
				return this.m_accessorycolourcode4;
			}
			set
			{
				this.m_accessorycolourcode4 = value;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002FE RID: 766 RVA: 0x00013766 File Offset: 0x00011966
		// (set) Token: 0x060002FF RID: 767 RVA: 0x0001376E File Offset: 0x0001196E
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

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x06000300 RID: 768 RVA: 0x00013777 File Offset: 0x00011977
		// (set) Token: 0x06000301 RID: 769 RVA: 0x0001377F File Offset: 0x0001197F
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

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00013788 File Offset: 0x00011988
		// (set) Token: 0x06000303 RID: 771 RVA: 0x00013790 File Offset: 0x00011990
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

		// Token: 0x170000AF RID: 175
		// (get) Token: 0x06000304 RID: 772 RVA: 0x00013799 File Offset: 0x00011999
		// (set) Token: 0x06000305 RID: 773 RVA: 0x000137A1 File Offset: 0x000119A1
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

		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x06000306 RID: 774 RVA: 0x000137AA File Offset: 0x000119AA
		// (set) Token: 0x06000307 RID: 775 RVA: 0x000137B2 File Offset: 0x000119B2
		public int preferredposition1
		{
			get
			{
				return this.m_preferredposition1;
			}
			set
			{
				this.m_preferredposition1 = value;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000308 RID: 776 RVA: 0x000137BB File Offset: 0x000119BB
		// (set) Token: 0x06000309 RID: 777 RVA: 0x000137C3 File Offset: 0x000119C3
		public int preferredposition2
		{
			get
			{
				return this.m_preferredposition2;
			}
			set
			{
				this.m_preferredposition2 = value;
			}
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600030A RID: 778 RVA: 0x000137CC File Offset: 0x000119CC
		// (set) Token: 0x0600030B RID: 779 RVA: 0x000137D4 File Offset: 0x000119D4
		public int preferredposition3
		{
			get
			{
				return this.m_preferredposition3;
			}
			set
			{
				this.m_preferredposition3 = value;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600030C RID: 780 RVA: 0x000137DD File Offset: 0x000119DD
		// (set) Token: 0x0600030D RID: 781 RVA: 0x000137E5 File Offset: 0x000119E5
		public int preferredposition4
		{
			get
			{
				return this.m_preferredposition4;
			}
			set
			{
				this.m_preferredposition4 = value;
			}
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600030E RID: 782 RVA: 0x000137EE File Offset: 0x000119EE
		// (set) Token: 0x0600030F RID: 783 RVA: 0x000137F6 File Offset: 0x000119F6
		public int preferredfoot
		{
			get
			{
				return this.m_preferredfoot;
			}
			set
			{
				this.m_preferredfoot = value;
			}
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000310 RID: 784 RVA: 0x000137FF File Offset: 0x000119FF
		// (set) Token: 0x06000311 RID: 785 RVA: 0x00013809 File Offset: 0x00011A09
		public int weakfootabilitytypecode
		{
			get
			{
				return this.m_weakfootabilitytypecode - 1;
			}
			set
			{
				this.m_weakfootabilitytypecode = value + 1;
			}
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000312 RID: 786 RVA: 0x00013814 File Offset: 0x00011A14
		// (set) Token: 0x06000313 RID: 787 RVA: 0x0001381C File Offset: 0x00011A1C
		public int acceleration
		{
			get
			{
				return this.m_acceleration;
			}
			set
			{
				this.m_acceleration = value;
			}
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000314 RID: 788 RVA: 0x00013825 File Offset: 0x00011A25
		// (set) Token: 0x06000315 RID: 789 RVA: 0x0001382D File Offset: 0x00011A2D
		public int aggression
		{
			get
			{
				return this.m_aggression;
			}
			set
			{
				this.m_aggression = value;
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000316 RID: 790 RVA: 0x00013836 File Offset: 0x00011A36
		// (set) Token: 0x06000317 RID: 791 RVA: 0x0001383E File Offset: 0x00011A3E
		public int gkglovetypecode
		{
			get
			{
				return this.m_gkglovetypecode;
			}
			set
			{
				this.m_gkglovetypecode = value;
			}
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00013847 File Offset: 0x00011A47
		// (set) Token: 0x06000319 RID: 793 RVA: 0x0001384F File Offset: 0x00011A4F
		public int agility
		{
			get
			{
				return this.m_agility;
			}
			set
			{
				this.m_agility = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600031A RID: 794 RVA: 0x00013858 File Offset: 0x00011A58
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00013860 File Offset: 0x00011A60
		public int balance
		{
			get
			{
				return this.m_balance;
			}
			set
			{
				this.m_balance = value;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600031C RID: 796 RVA: 0x00013869 File Offset: 0x00011A69
		// (set) Token: 0x0600031D RID: 797 RVA: 0x00013871 File Offset: 0x00011A71
		public int gkkicking
		{
			get
			{
				return this.m_gkkicking;
			}
			set
			{
				this.m_gkkicking = value;
			}
		}

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0001387A File Offset: 0x00011A7A
		// (set) Token: 0x0600031F RID: 799 RVA: 0x00013882 File Offset: 0x00011A82
		public int gkkickstyle
		{
			get
			{
				return this.m_gkkickstyle;
			}
			set
			{
				this.m_gkkickstyle = value;
			}
		}

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000320 RID: 800 RVA: 0x0001388B File Offset: 0x00011A8B
		// (set) Token: 0x06000321 RID: 801 RVA: 0x00013893 File Offset: 0x00011A93
		public int jumping
		{
			get
			{
				return this.m_jumping;
			}
			set
			{
				this.m_jumping = value;
			}
		}

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000322 RID: 802 RVA: 0x0001389C File Offset: 0x00011A9C
		// (set) Token: 0x06000323 RID: 803 RVA: 0x000138A4 File Offset: 0x00011AA4
		public int penalties
		{
			get
			{
				return this.m_penalties;
			}
			set
			{
				this.m_penalties = value;
			}
		}

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000324 RID: 804 RVA: 0x000138AD File Offset: 0x00011AAD
		// (set) Token: 0x06000325 RID: 805 RVA: 0x000138B5 File Offset: 0x00011AB5
		public int vision
		{
			get
			{
				return this.m_vision;
			}
			set
			{
				this.m_vision = value;
			}
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000326 RID: 806 RVA: 0x000138BE File Offset: 0x00011ABE
		// (set) Token: 0x06000327 RID: 807 RVA: 0x000138C6 File Offset: 0x00011AC6
		public int volleys
		{
			get
			{
				return this.m_volleys;
			}
			set
			{
				this.m_volleys = value;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000328 RID: 808 RVA: 0x000138CF File Offset: 0x00011ACF
		// (set) Token: 0x06000329 RID: 809 RVA: 0x000138D7 File Offset: 0x00011AD7
		public int skillmoves
		{
			get
			{
				return this.m_skillmoves;
			}
			set
			{
				this.m_skillmoves = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600032A RID: 810 RVA: 0x000138E0 File Offset: 0x00011AE0
		// (set) Token: 0x0600032B RID: 811 RVA: 0x000138E8 File Offset: 0x00011AE8
		public int usercaneditname
		{
			get
			{
				return this.m_usercaneditname;
			}
			set
			{
				this.m_usercaneditname = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600032C RID: 812 RVA: 0x000138F1 File Offset: 0x00011AF1
		// (set) Token: 0x0600032D RID: 813 RVA: 0x000138F9 File Offset: 0x00011AF9
		public int sprintspeed
		{
			get
			{
				return this.m_sprintspeed;
			}
			set
			{
				this.m_sprintspeed = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600032E RID: 814 RVA: 0x00013902 File Offset: 0x00011B02
		// (set) Token: 0x0600032F RID: 815 RVA: 0x0001390A File Offset: 0x00011B0A
		public int stamina
		{
			get
			{
				return this.m_stamina;
			}
			set
			{
				this.m_stamina = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000330 RID: 816 RVA: 0x00013913 File Offset: 0x00011B13
		// (set) Token: 0x06000331 RID: 817 RVA: 0x0001391B File Offset: 0x00011B1B
		public int strength
		{
			get
			{
				return this.m_strength;
			}
			set
			{
				this.m_strength = value;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000332 RID: 818 RVA: 0x00013924 File Offset: 0x00011B24
		// (set) Token: 0x06000333 RID: 819 RVA: 0x0001392C File Offset: 0x00011B2C
		public int marking
		{
			get
			{
				return this.m_marking;
			}
			set
			{
				this.m_marking = value;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000334 RID: 820 RVA: 0x00013935 File Offset: 0x00011B35
		// (set) Token: 0x06000335 RID: 821 RVA: 0x0001393D File Offset: 0x00011B3D
		public int standingtackle
		{
			get
			{
				return this.m_standingtackle;
			}
			set
			{
				this.m_standingtackle = value;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000336 RID: 822 RVA: 0x00013946 File Offset: 0x00011B46
		// (set) Token: 0x06000337 RID: 823 RVA: 0x0001394E File Offset: 0x00011B4E
		public int slidingtackle
		{
			get
			{
				return this.m_slidingtackle;
			}
			set
			{
				this.m_slidingtackle = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000338 RID: 824 RVA: 0x00013957 File Offset: 0x00011B57
		// (set) Token: 0x06000339 RID: 825 RVA: 0x0001395F File Offset: 0x00011B5F
		public int ballcontrol
		{
			get
			{
				return this.m_ballcontrol;
			}
			set
			{
				this.m_ballcontrol = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x0600033A RID: 826 RVA: 0x00013968 File Offset: 0x00011B68
		// (set) Token: 0x0600033B RID: 827 RVA: 0x00013970 File Offset: 0x00011B70
		public int dribbling
		{
			get
			{
				return this.m_dribbling;
			}
			set
			{
				this.m_dribbling = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00013979 File Offset: 0x00011B79
		// (set) Token: 0x0600033D RID: 829 RVA: 0x00013981 File Offset: 0x00011B81
		public int crossing
		{
			get
			{
				return this.m_crossing;
			}
			set
			{
				this.m_crossing = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600033E RID: 830 RVA: 0x0001398A File Offset: 0x00011B8A
		// (set) Token: 0x0600033F RID: 831 RVA: 0x00013992 File Offset: 0x00011B92
		public int headingaccuracy
		{
			get
			{
				return this.m_headingaccuracy;
			}
			set
			{
				this.m_headingaccuracy = value;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000340 RID: 832 RVA: 0x0001399B File Offset: 0x00011B9B
		// (set) Token: 0x06000341 RID: 833 RVA: 0x000139A3 File Offset: 0x00011BA3
		public int shortpassing
		{
			get
			{
				return this.m_shortpassing;
			}
			set
			{
				this.m_shortpassing = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000342 RID: 834 RVA: 0x000139AC File Offset: 0x00011BAC
		// (set) Token: 0x06000343 RID: 835 RVA: 0x000139B4 File Offset: 0x00011BB4
		public int longpassing
		{
			get
			{
				return this.m_longpassing;
			}
			set
			{
				this.m_longpassing = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000139BD File Offset: 0x00011BBD
		// (set) Token: 0x06000345 RID: 837 RVA: 0x000139C5 File Offset: 0x00011BC5
		public int longshots
		{
			get
			{
				return this.m_longshots;
			}
			set
			{
				this.m_longshots = value;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000346 RID: 838 RVA: 0x000139CE File Offset: 0x00011BCE
		// (set) Token: 0x06000347 RID: 839 RVA: 0x000139D6 File Offset: 0x00011BD6
		public int finishing
		{
			get
			{
				return this.m_finishing;
			}
			set
			{
				this.m_finishing = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000348 RID: 840 RVA: 0x000139DF File Offset: 0x00011BDF
		// (set) Token: 0x06000349 RID: 841 RVA: 0x000139E7 File Offset: 0x00011BE7
		public int shotpower
		{
			get
			{
				return this.m_shotpower;
			}
			set
			{
				this.m_shotpower = value;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x0600034A RID: 842 RVA: 0x000139F0 File Offset: 0x00011BF0
		// (set) Token: 0x0600034B RID: 843 RVA: 0x000139F8 File Offset: 0x00011BF8
		public int reactions
		{
			get
			{
				return this.m_reactions;
			}
			set
			{
				this.m_reactions = value;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00013A01 File Offset: 0x00011C01
		// (set) Token: 0x0600034D RID: 845 RVA: 0x00013A09 File Offset: 0x00011C09
		public int gkreflexes
		{
			get
			{
				return this.m_gkreflexes;
			}
			set
			{
				this.m_gkreflexes = value;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00013A12 File Offset: 0x00011C12
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00013A1A File Offset: 0x00011C1A
		public int gkhandling
		{
			get
			{
				return this.m_gkhandling;
			}
			set
			{
				this.m_gkhandling = value;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000350 RID: 848 RVA: 0x00013A23 File Offset: 0x00011C23
		// (set) Token: 0x06000351 RID: 849 RVA: 0x00013A2B File Offset: 0x00011C2B
		public int gkdiving
		{
			get
			{
				return this.m_gkdiving;
			}
			set
			{
				this.m_gkdiving = value;
			}
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00013A34 File Offset: 0x00011C34
		// (set) Token: 0x06000353 RID: 851 RVA: 0x00013A3C File Offset: 0x00011C3C
		public int gkpositioning
		{
			get
			{
				return this.m_gkpositioning;
			}
			set
			{
				this.m_gkpositioning = value;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00013A45 File Offset: 0x00011C45
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00013A4D File Offset: 0x00011C4D
		public int freekickaccuracy
		{
			get
			{
				return this.m_freekickaccuracy;
			}
			set
			{
				this.m_freekickaccuracy = value;
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00013A56 File Offset: 0x00011C56
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00013A5E File Offset: 0x00011C5E
		public int potential
		{
			get
			{
				return this.m_potential;
			}
			set
			{
				this.m_potential = value;
			}
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00013A67 File Offset: 0x00011C67
		// (set) Token: 0x06000359 RID: 857 RVA: 0x00013A6F File Offset: 0x00011C6F
		public int positioning
		{
			get
			{
				return this.m_positioning;
			}
			set
			{
				this.m_positioning = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600035A RID: 858 RVA: 0x00013A78 File Offset: 0x00011C78
		// (set) Token: 0x0600035B RID: 859 RVA: 0x00013A80 File Offset: 0x00011C80
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

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00013A89 File Offset: 0x00011C89
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00013A91 File Offset: 0x00011C91
		public bool Inflexible
		{
			get
			{
				return this.m_Inflexible;
			}
			set
			{
				this.m_Inflexible = value;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00013A9A File Offset: 0x00011C9A
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00013AA2 File Offset: 0x00011CA2
		public bool GkOneOnOne
		{
			get
			{
				return this.m_GkOneOnOne;
			}
			set
			{
				this.m_GkOneOnOne = value;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00013AAB File Offset: 0x00011CAB
		// (set) Token: 0x06000361 RID: 865 RVA: 0x00013AB3 File Offset: 0x00011CB3
		public bool CrowdFavorite
		{
			get
			{
				return this.m_CrowdFavorite;
			}
			set
			{
				this.m_CrowdFavorite = value;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00013ABC File Offset: 0x00011CBC
		// (set) Token: 0x06000363 RID: 867 RVA: 0x00013AC4 File Offset: 0x00011CC4
		public bool SecondWind
		{
			get
			{
				return this.m_SecondWind;
			}
			set
			{
				this.m_SecondWind = value;
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000364 RID: 868 RVA: 0x00013ACD File Offset: 0x00011CCD
		// (set) Token: 0x06000365 RID: 869 RVA: 0x00013AD5 File Offset: 0x00011CD5
		public bool AcrobaticClearance
		{
			get
			{
				return this.m_AcrobaticClearance;
			}
			set
			{
				this.m_AcrobaticClearance = value;
			}
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00013ADE File Offset: 0x00011CDE
		// (set) Token: 0x06000367 RID: 871 RVA: 0x00013AE6 File Offset: 0x00011CE6
		public bool Longthrows
		{
			get
			{
				return this.m_Longthrows;
			}
			set
			{
				this.m_Longthrows = value;
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00013AEF File Offset: 0x00011CEF
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00013AF7 File Offset: 0x00011CF7
		public bool PowerfulFreeKicks
		{
			get
			{
				return this.m_PowerfulFreeKicks;
			}
			set
			{
				this.m_PowerfulFreeKicks = value;
			}
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00013B00 File Offset: 0x00011D00
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00013B08 File Offset: 0x00011D08
		public bool Diver
		{
			get
			{
				return this.m_Diver;
			}
			set
			{
				this.m_Diver = value;
			}
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00013B11 File Offset: 0x00011D11
		// (set) Token: 0x0600036D RID: 877 RVA: 0x00013B19 File Offset: 0x00011D19
		public bool InjuryFree
		{
			get
			{
				return this.m_InjuryFree;
			}
			set
			{
				this.m_InjuryFree = value;
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00013B22 File Offset: 0x00011D22
		// (set) Token: 0x0600036F RID: 879 RVA: 0x00013B2A File Offset: 0x00011D2A
		public bool InjuryProne
		{
			get
			{
				return this.m_InjuryProne;
			}
			set
			{
				this.m_InjuryProne = value;
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00013B33 File Offset: 0x00011D33
		// (set) Token: 0x06000371 RID: 881 RVA: 0x00013B3B File Offset: 0x00011D3B
		public bool AvoidsWeakFoot
		{
			get
			{
				return this.m_AvoidsWeakFoot;
			}
			set
			{
				this.m_AvoidsWeakFoot = value;
			}
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00013B44 File Offset: 0x00011D44
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00013B4C File Offset: 0x00011D4C
		public bool Divesintotackles
		{
			get
			{
				return this.m_Divesintotackles;
			}
			set
			{
				this.m_Divesintotackles = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x06000374 RID: 884 RVA: 0x00013B55 File Offset: 0x00011D55
		// (set) Token: 0x06000375 RID: 885 RVA: 0x00013B5D File Offset: 0x00011D5D
		public bool BeatDefensiveLine
		{
			get
			{
				return this.m_BeatDefensiveLine;
			}
			set
			{
				this.m_BeatDefensiveLine = value;
			}
		}

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x06000376 RID: 886 RVA: 0x00013B66 File Offset: 0x00011D66
		// (set) Token: 0x06000377 RID: 887 RVA: 0x00013B6E File Offset: 0x00011D6E
		public bool Selfish
		{
			get
			{
				return this.m_Selfish;
			}
			set
			{
				this.m_Selfish = value;
			}
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000378 RID: 888 RVA: 0x00013B77 File Offset: 0x00011D77
		// (set) Token: 0x06000379 RID: 889 RVA: 0x00013B7F File Offset: 0x00011D7F
		public bool Leadership
		{
			get
			{
				return this.m_Leadership;
			}
			set
			{
				this.m_Leadership = value;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x0600037A RID: 890 RVA: 0x00013B88 File Offset: 0x00011D88
		// (set) Token: 0x0600037B RID: 891 RVA: 0x00013B90 File Offset: 0x00011D90
		public bool ArguesWithOfficials
		{
			get
			{
				return this.m_ArguesWithOfficials;
			}
			set
			{
				this.m_ArguesWithOfficials = value;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x0600037C RID: 892 RVA: 0x00013B99 File Offset: 0x00011D99
		// (set) Token: 0x0600037D RID: 893 RVA: 0x00013BA1 File Offset: 0x00011DA1
		public bool Earlycrosser
		{
			get
			{
				return this.m_Earlycrosser;
			}
			set
			{
				this.m_Earlycrosser = value;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600037E RID: 894 RVA: 0x00013BAA File Offset: 0x00011DAA
		// (set) Token: 0x0600037F RID: 895 RVA: 0x00013BB2 File Offset: 0x00011DB2
		public bool FinesseShot
		{
			get
			{
				return this.m_FinesseShot;
			}
			set
			{
				this.m_FinesseShot = value;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00013BBB File Offset: 0x00011DBB
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00013BC3 File Offset: 0x00011DC3
		public bool Flair
		{
			get
			{
				return this.m_Flair;
			}
			set
			{
				this.m_Flair = value;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00013BCC File Offset: 0x00011DCC
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00013BD4 File Offset: 0x00011DD4
		public bool LongPasser
		{
			get
			{
				return this.m_LongPasser;
			}
			set
			{
				this.m_LongPasser = value;
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00013BDD File Offset: 0x00011DDD
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00013BE5 File Offset: 0x00011DE5
		public bool LongShotTaker
		{
			get
			{
				return this.m_LongShotTaker;
			}
			set
			{
				this.m_LongShotTaker = value;
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00013BEE File Offset: 0x00011DEE
		// (set) Token: 0x06000387 RID: 903 RVA: 0x00013BF6 File Offset: 0x00011DF6
		public bool Technicaldribbler
		{
			get
			{
				return this.m_Technicaldribbler;
			}
			set
			{
				this.m_Technicaldribbler = value;
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000388 RID: 904 RVA: 0x00013BFF File Offset: 0x00011DFF
		// (set) Token: 0x06000389 RID: 905 RVA: 0x00013C07 File Offset: 0x00011E07
		public bool Playmaker
		{
			get
			{
				return this.m_Playmaker;
			}
			set
			{
				this.m_Playmaker = value;
			}
		}

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00013C10 File Offset: 0x00011E10
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00013C18 File Offset: 0x00011E18
		public bool Pushesupforcorners
		{
			get
			{
				return this.m_Pushesupforcorners;
			}
			set
			{
				this.m_Pushesupforcorners = value;
			}
		}

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00013C21 File Offset: 0x00011E21
		// (set) Token: 0x0600038D RID: 909 RVA: 0x00013C29 File Offset: 0x00011E29
		public bool Puncher
		{
			get
			{
				return this.m_Puncher;
			}
			set
			{
				this.m_Puncher = value;
			}
		}

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600038E RID: 910 RVA: 0x00013C32 File Offset: 0x00011E32
		// (set) Token: 0x0600038F RID: 911 RVA: 0x00013C3A File Offset: 0x00011E3A
		public bool GkLongThrower
		{
			get
			{
				return this.m_GkLongThrower;
			}
			set
			{
				this.m_GkLongThrower = value;
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000390 RID: 912 RVA: 0x00013C43 File Offset: 0x00011E43
		// (set) Token: 0x06000391 RID: 913 RVA: 0x00013C4B File Offset: 0x00011E4B
		public bool PowerHeader
		{
			get
			{
				return this.m_PowerHeader;
			}
			set
			{
				this.m_PowerHeader = value;
			}
		}

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00013C54 File Offset: 0x00011E54
		// (set) Token: 0x06000393 RID: 915 RVA: 0x00013C5C File Offset: 0x00011E5C
		public bool GiantThrow
		{
			get
			{
				return this.m_GiantThrow;
			}
			set
			{
				this.m_GiantThrow = value;
			}
		}

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000394 RID: 916 RVA: 0x00013C65 File Offset: 0x00011E65
		// (set) Token: 0x06000395 RID: 917 RVA: 0x00013C6D File Offset: 0x00011E6D
		public bool OutsideFootShot
		{
			get
			{
				return this.m_OutsideFootShot;
			}
			set
			{
				this.m_OutsideFootShot = value;
			}
		}

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00013C76 File Offset: 0x00011E76
		// (set) Token: 0x06000397 RID: 919 RVA: 0x00013C7E File Offset: 0x00011E7E
		public bool SwervePasser
		{
			get
			{
				return this.m_SwervePasser;
			}
			set
			{
				this.m_SwervePasser = value;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00013C87 File Offset: 0x00011E87
		// (set) Token: 0x06000399 RID: 921 RVA: 0x00013C8F File Offset: 0x00011E8F
		public bool HighClubIdentification
		{
			get
			{
				return this.m_HighClubIdentification;
			}
			set
			{
				this.m_HighClubIdentification = value;
			}
		}

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00013C98 File Offset: 0x00011E98
		// (set) Token: 0x0600039B RID: 923 RVA: 0x00013CA0 File Offset: 0x00011EA0
		public bool TeamPlayer
		{
			get
			{
				return this.m_TeamPlayer;
			}
			set
			{
				this.m_TeamPlayer = value;
			}
		}

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600039C RID: 924 RVA: 0x00013CA9 File Offset: 0x00011EA9
		// (set) Token: 0x0600039D RID: 925 RVA: 0x00013CB1 File Offset: 0x00011EB1
		public bool FancyFeet
		{
			get
			{
				return this.m_FancyFeet;
			}
			set
			{
				this.m_FancyFeet = value;
			}
		}

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600039E RID: 926 RVA: 0x00013CBA File Offset: 0x00011EBA
		// (set) Token: 0x0600039F RID: 927 RVA: 0x00013CC2 File Offset: 0x00011EC2
		public bool FancyPasses
		{
			get
			{
				return this.m_FancyPasses;
			}
			set
			{
				this.m_FancyPasses = value;
			}
		}

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x060003A0 RID: 928 RVA: 0x00013CCB File Offset: 0x00011ECB
		// (set) Token: 0x060003A1 RID: 929 RVA: 0x00013CD3 File Offset: 0x00011ED3
		public bool FancyFlicks
		{
			get
			{
				return this.m_FancyFlicks;
			}
			set
			{
				this.m_FancyFlicks = value;
			}
		}

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x060003A2 RID: 930 RVA: 0x00013CDC File Offset: 0x00011EDC
		// (set) Token: 0x060003A3 RID: 931 RVA: 0x00013CE4 File Offset: 0x00011EE4
		public bool StutterPenalty
		{
			get
			{
				return this.m_StutterPenalty;
			}
			set
			{
				this.m_StutterPenalty = value;
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x060003A4 RID: 932 RVA: 0x00013CED File Offset: 0x00011EED
		// (set) Token: 0x060003A5 RID: 933 RVA: 0x00013CF5 File Offset: 0x00011EF5
		public bool ChipperPenalty
		{
			get
			{
				return this.m_ChipperPenalty;
			}
			set
			{
				this.m_ChipperPenalty = value;
			}
		}

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00013CFE File Offset: 0x00011EFE
		// (set) Token: 0x060003A7 RID: 935 RVA: 0x00013D06 File Offset: 0x00011F06
		public bool BycicleKick
		{
			get
			{
				return this.m_BycicleKick;
			}
			set
			{
				this.m_BycicleKick = value;
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00013D0F File Offset: 0x00011F0F
		// (set) Token: 0x060003A9 RID: 937 RVA: 0x00013D17 File Offset: 0x00011F17
		public bool DivingHeader
		{
			get
			{
				return this.m_DivingHeader;
			}
			set
			{
				this.m_DivingHeader = value;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00013D20 File Offset: 0x00011F20
		// (set) Token: 0x060003AB RID: 939 RVA: 0x00013D28 File Offset: 0x00011F28
		public bool DrivenPass
		{
			get
			{
				return this.m_DrivenPass;
			}
			set
			{
				this.m_DrivenPass = value;
			}
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x060003AC RID: 940 RVA: 0x00013D31 File Offset: 0x00011F31
		// (set) Token: 0x060003AD RID: 941 RVA: 0x00013D39 File Offset: 0x00011F39
		public bool GkFlatKick
		{
			get
			{
				return this.m_GkFlatKick;
			}
			set
			{
				this.m_GkFlatKick = value;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x060003AE RID: 942 RVA: 0x00013D42 File Offset: 0x00011F42
		// (set) Token: 0x060003AF RID: 943 RVA: 0x00013D4A File Offset: 0x00011F4A
		public int curve
		{
			get
			{
				return this.m_curve;
			}
			set
			{
				this.m_curve = value;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x060003B0 RID: 944 RVA: 0x00013D53 File Offset: 0x00011F53
		// (set) Token: 0x060003B1 RID: 945 RVA: 0x00013D5B File Offset: 0x00011F5B
		public int internationalrep
		{
			get
			{
				return this.m_internationalrep;
			}
			set
			{
				this.m_internationalrep = value;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x060003B2 RID: 946 RVA: 0x00013D64 File Offset: 0x00011F64
		// (set) Token: 0x060003B3 RID: 947 RVA: 0x00013D6C File Offset: 0x00011F6C
		public int finishingcode1
		{
			get
			{
				return this.m_finishingcode1;
			}
			set
			{
				this.m_finishingcode1 = value;
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00013D75 File Offset: 0x00011F75
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00013D7D File Offset: 0x00011F7D
		public int finishingcode2
		{
			get
			{
				return this.m_finishingcode2;
			}
			set
			{
				this.m_finishingcode2 = value;
			}
		}

		// Token: 0x17000108 RID: 264
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x00013D86 File Offset: 0x00011F86
		// (set) Token: 0x060003B7 RID: 951 RVA: 0x00013D8E File Offset: 0x00011F8E
		public int runningcode1
		{
			get
			{
				return this.m_runningcode1;
			}
			set
			{
				this.m_runningcode1 = value;
			}
		}

		// Token: 0x17000109 RID: 265
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00013D97 File Offset: 0x00011F97
		// (set) Token: 0x060003B9 RID: 953 RVA: 0x00013D9F File Offset: 0x00011F9F
		public int runningcode2
		{
			get
			{
				return this.m_runningcode2;
			}
			set
			{
				this.m_runningcode2 = value;
			}
		}

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x060003BA RID: 954 RVA: 0x00013DA8 File Offset: 0x00011FA8
		// (set) Token: 0x060003BB RID: 955 RVA: 0x00013DB0 File Offset: 0x00011FB0
		public int gksavetype
		{
			get
			{
				return this.m_gksavetype;
			}
			set
			{
				this.m_gksavetype = value;
			}
		}

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x060003BC RID: 956 RVA: 0x00013DB9 File Offset: 0x00011FB9
		// (set) Token: 0x060003BD RID: 957 RVA: 0x00013DC1 File Offset: 0x00011FC1
		public int faceposercode
		{
			get
			{
				return this.m_faceposercode;
			}
			set
			{
				this.m_faceposercode = value;
			}
		}

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x060003BE RID: 958 RVA: 0x00013DCA File Offset: 0x00011FCA
		// (set) Token: 0x060003BF RID: 959 RVA: 0x00013DD2 File Offset: 0x00011FD2
		public int isretiring
		{
			get
			{
				return this.m_isretiring;
			}
			set
			{
				this.m_isretiring = value;
			}
		}

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x060003C0 RID: 960 RVA: 0x00013DDB File Offset: 0x00011FDB
		// (set) Token: 0x060003C1 RID: 961 RVA: 0x00013DE3 File Offset: 0x00011FE3
		public int socklengthcode
		{
			get
			{
				return this.m_socklengthcode;
			}
			set
			{
				this.m_socklengthcode = value;
			}
		}

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x060003C2 RID: 962 RVA: 0x00013DEC File Offset: 0x00011FEC
		// (set) Token: 0x060003C3 RID: 963 RVA: 0x00013DF4 File Offset: 0x00011FF4
		public int hashighqualityhead
		{
			get
			{
				return this.m_hashighqualityhead;
			}
			set
			{
				this.m_hashighqualityhead = value;
			}
		}

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x060003C4 RID: 964 RVA: 0x00013DFD File Offset: 0x00011FFD
		// (set) Token: 0x060003C5 RID: 965 RVA: 0x00013E05 File Offset: 0x00012005
		public int attackingworkrate
		{
			get
			{
				return this.m_attackingworkrate;
			}
			set
			{
				this.m_attackingworkrate = value;
			}
		}

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x00013E0E File Offset: 0x0001200E
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x00013E16 File Offset: 0x00012016
		public int defensiveworkrate
		{
			get
			{
				return this.m_defensiveworkrate;
			}
			set
			{
				this.m_defensiveworkrate = value;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x00013E1F File Offset: 0x0001201F
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x00013E27 File Offset: 0x00012027
		public bool TrainingPants
		{
			get
			{
				return this.m_shortstyle;
			}
			set
			{
				this.m_shortstyle = value;
			}
		}

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x060003CA RID: 970 RVA: 0x00013E30 File Offset: 0x00012030
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00013E38 File Offset: 0x00012038
		public int interceptions
		{
			get
			{
				return this.m_interceptions;
			}
			set
			{
				this.m_interceptions = value;
			}
		}

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x060003CC RID: 972 RVA: 0x00013E41 File Offset: 0x00012041
		// (set) Token: 0x060003CD RID: 973 RVA: 0x00013E49 File Offset: 0x00012049
		public bool jerseyfit
		{
			get
			{
				return this.m_jerseyfit;
			}
			set
			{
				this.m_jerseyfit = value;
			}
		}

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x060003CE RID: 974 RVA: 0x00013E52 File Offset: 0x00012052
		// (set) Token: 0x060003CF RID: 975 RVA: 0x00013E5A File Offset: 0x0001205A
		public Team TeamLoanedFrom
		{
			get
			{
				return this.m_TeamLoanedFrom;
			}
			set
			{
				this.m_TeamLoanedFrom = value;
				this.m_teamidloanedfrom = ((this.m_TeamLoanedFrom != null) ? this.m_TeamLoanedFrom.Id : 0);
			}
		}

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x00013E7F File Offset: 0x0001207F
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x00013E87 File Offset: 0x00012087
		public Team PreviousTeam
		{
			get
			{
				return this.m_PreviousTeam;
			}
			set
			{
				this.m_PreviousTeam = value;
				this.m_previousteamid = ((this.m_PreviousTeam != null) ? this.m_PreviousTeam.Id : 0);
			}
		}

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x00013EAC File Offset: 0x000120AC
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x00013EBA File Offset: 0x000120BA
		public bool IsLoaned
		{
			get
			{
				return this.m_teamidloanedfrom != 0;
			}
			set
			{
				if (!value)
				{
					this.m_teamidloanedfrom = 0;
					return;
				}
				if (this.m_TeamLoanedFrom == null)
				{
					this.TeamLoanedFrom = (Team)FifaEnvironment.Teams[0];
					return;
				}
				this.m_teamidloanedfrom = this.TeamLoanedFrom.Id;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x060003D4 RID: 980 RVA: 0x00013EF7 File Offset: 0x000120F7
		// (set) Token: 0x060003D5 RID: 981 RVA: 0x00013EFF File Offset: 0x000120FF
		public DateTime loandateend
		{
			get
			{
				return this.m_loandateend;
			}
			set
			{
				this.m_loandateend = value;
			}
		}

		// Token: 0x060003D6 RID: 982 RVA: 0x00013F08 File Offset: 0x00012108
		public override string ToString()
		{
			if (this.m_commonname != null && this.m_commonname != string.Empty)
			{
				return this.m_commonname;
			}
			if (this.m_firstname != null && this.m_firstname != string.Empty)
			{
				return this.m_lastname + " " + this.m_firstname;
			}
			return this.m_lastname + " [" + base.Id.ToString() + "]";
		}

		// Token: 0x060003D7 RID: 983 RVA: 0x00013F8A File Offset: 0x0001218A
		public string DatabaseString()
		{
			return this.ToString();
		}

		// Token: 0x060003D8 RID: 984 RVA: 0x00013F92 File Offset: 0x00012192
		public Player(Record r)
			: base(r.IntField[FI.players_playerid])
		{
			this.Load(r);
		}

		// Token: 0x060003D9 RID: 985 RVA: 0x00013FB8 File Offset: 0x000121B8
		public void Load(Record r)
		{
			this.m_headclasscode = r.GetAndCheckIntField(FI.players_headclasscode);
			this.m_firstnameid = r.IntField[FI.players_firstnameid];
			if (!Player.PlayerNames.TryGetValue(this.m_firstnameid, out this.m_firstname, true))
			{
				this.m_firstname = string.Empty;
			}
			this.m_lastnameid = r.IntField[FI.players_lastnameid];
			if (!Player.PlayerNames.TryGetValue(this.m_lastnameid, out this.m_lastname, out this.m_lastnameKey, true))
			{
				this.m_lastname = string.Empty;
				this.m_lastnameKey = 900000;
			}
			this.m_commonnameid = r.IntField[FI.players_commonnameid];
			if (!Player.PlayerNames.TryGetValue(this.m_commonnameid, out this.m_commonname, true))
			{
				this.m_commonname = string.Empty;
			}
			this.m_playerjerseynameid = r.IntField[FI.players_playerjerseynameid];
			if (!Player.PlayerNames.TryGetValue(this.m_playerjerseynameid, out this.m_playerjerseyname, true))
			{
				this.m_playerjerseyname = string.Empty;
			}
			DateTime dateTime = FifaUtil.ConvertToDate(r.GetAndCheckIntField(FI.players_birthdate));
			if (dateTime.Year < 1900)
			{
				dateTime = new DateTime(1980, 1, 1);
			}
			this.m_birthdate = dateTime;
			this.m_playerjointeamdate = FifaUtil.ConvertToDate(r.GetAndCheckIntField(FI.players_playerjointeamdate));
			this.m_contractvaliduntil = r.GetAndCheckIntField(FI.players_contractvaliduntil);
			this.m_height = r.GetAndCheckIntField(FI.players_height);
			this.m_weight = r.GetAndCheckIntField(FI.players_weight);
			this.m_preferredposition1 = r.GetAndCheckIntField(FI.players_preferredposition1);
			this.m_preferredposition2 = r.GetAndCheckIntField(FI.players_preferredposition2);
			this.m_preferredposition3 = r.GetAndCheckIntField(FI.players_preferredposition3);
			this.m_preferredposition4 = r.GetAndCheckIntField(FI.players_preferredposition4);
			this.m_preferredfoot = r.GetAndCheckIntField(FI.players_preferredfoot) - 1;
			this.m_bodytypecode = r.GetAndCheckIntField(FI.players_bodytypecode) - 1;
			this.m_shoecolorcode1 = r.GetAndCheckIntField(FI.players_shoecolorcode1);
			this.m_shoetypecode = r.GetAndCheckIntField(FI.players_shoetypecode);
			this.m_jerseysleevelengthcode = r.GetAndCheckIntField(FI.players_jerseysleevelengthcode);
			this.m_eyecolorcode = r.GetAndCheckIntField(FI.players_eyecolorcode);
			this.m_eyebrowcode = r.GetAndCheckIntField(FI.players_eyebrowcode);
			this.m_facialhairtypecode = r.GetAndCheckIntField(FI.players_facialhairtypecode);
			this.m_facialhaircolorcode = r.GetAndCheckIntField(FI.players_facialhaircolorcode);
			this.m_hairtypecode = r.GetAndCheckIntField(FI.players_hairtypecode);
			this.m_haircolorcode = r.GetAndCheckIntField(FI.players_haircolorcode);
			this.m_headtypecode = r.GetAndCheckIntField(FI.players_headtypecode);
			this.m_sideburnscode = r.GetAndCheckIntField(FI.players_sideburnscode);
			this.m_skintypecode = r.GetAndCheckIntField(FI.players_skintypecode);
			this.m_skintonecode = r.GetAndCheckIntField(FI.players_skintonecode);
			this.m_overallrating = r.GetAndCheckIntField(FI.players_overallrating);
			this.m_jerseystylecode = r.GetAndCheckIntField(FI.players_jerseystylecode);
			this.m_hasseasonaljersey = r.GetAndCheckIntField(FI.players_hasseasonaljersey);
			this.m_animfreekickstartposcode = r.GetAndCheckIntField(FI.players_animfreekickstartposcode);
			this.m_animpenaltieskickstylecode = r.GetAndCheckIntField(FI.players_animpenaltieskickstylecode);
			this.m_animpenaltiesmotionstylecode = r.GetAndCheckIntField(FI.players_animpenaltiesmotionstylecode);
			this.m_animpenaltiesstartposcode = r.GetAndCheckIntField(FI.players_animpenaltiesstartposcode);
			this.m_accessorycode1 = r.GetAndCheckIntField(FI.players_accessorycode1);
			this.m_accessorycolourcode1 = r.GetAndCheckIntField(FI.players_accessorycolourcode1);
			this.m_accessorycode2 = r.GetAndCheckIntField(FI.players_accessorycode2);
			this.m_accessorycolourcode2 = r.GetAndCheckIntField(FI.players_accessorycolourcode2);
			this.m_accessorycode3 = r.GetAndCheckIntField(FI.players_accessorycode3);
			this.m_accessorycolourcode3 = r.GetAndCheckIntField(FI.players_accessorycolourcode3);
			this.m_accessorycode4 = r.GetAndCheckIntField(FI.players_accessorycode4);
			this.m_accessorycolourcode4 = r.GetAndCheckIntField(FI.players_accessorycolourcode4);
			this.m_acceleration = r.GetAndCheckIntField(FI.players_acceleration);
			this.m_aggression = r.GetAndCheckIntField(FI.players_aggression);
			this.m_ballcontrol = r.GetAndCheckIntField(FI.players_ballcontrol);
			this.m_crossing = r.GetAndCheckIntField(FI.players_crossing);
			this.m_dribbling = r.GetAndCheckIntField(FI.players_dribbling);
			this.m_finishing = r.GetAndCheckIntField(FI.players_finishing);
			this.m_freekickaccuracy = r.GetAndCheckIntField(FI.players_freekickaccuracy);
			this.m_headingaccuracy = r.GetAndCheckIntField(FI.players_headingaccuracy);
			this.m_longpassing = r.GetAndCheckIntField(FI.players_longpassing);
			this.m_longshots = r.GetAndCheckIntField(FI.players_longshots);
			this.m_marking = r.GetAndCheckIntField(FI.players_marking);
			this.m_positioning = r.GetAndCheckIntField(FI.players_positioning);
			this.m_potential = r.GetAndCheckIntField(FI.players_potential);
			this.m_reactions = r.GetAndCheckIntField(FI.players_reactions);
			this.m_shortpassing = r.GetAndCheckIntField(FI.players_shortpassing);
			this.m_shotpower = r.GetAndCheckIntField(FI.players_shotpower);
			this.m_sprintspeed = r.GetAndCheckIntField(FI.players_sprintspeed);
			this.m_stamina = r.GetAndCheckIntField(FI.players_stamina);
			this.m_strength = r.GetAndCheckIntField(FI.players_strength);
			this.m_standingtackle = r.GetAndCheckIntField(FI.players_standingtackle);
			this.m_slidingtackle = r.GetAndCheckIntField(FI.players_slidingtackle);
			this.m_gkdiving = r.GetAndCheckIntField(FI.players_gkdiving);
			this.m_gkpositioning = r.GetAndCheckIntField(FI.players_gkpositioning);
			this.m_gkhandling = r.GetAndCheckIntField(FI.players_gkhandling);
			this.m_gkreflexes = r.GetAndCheckIntField(FI.players_gkreflexes);
			this.m_gkglovetypecode = r.GetAndCheckIntField(FI.players_gkglovetypecode);
			this.m_agility = r.GetAndCheckIntField(FI.players_agility);
			this.m_balance = r.GetAndCheckIntField(FI.players_balance);
			this.m_gkkicking = r.GetAndCheckIntField(FI.players_gkkicking);
			this.m_gkkickstyle = r.GetAndCheckIntField(FI.players_gkkickstyle);
			this.m_jumping = r.GetAndCheckIntField(FI.players_jumping);
			this.m_penalties = r.GetAndCheckIntField(FI.players_penalties);
			this.m_vision = r.GetAndCheckIntField(FI.players_vision);
			this.m_volleys = r.GetAndCheckIntField(FI.players_volleys);
			this.m_skillmoves = r.GetAndCheckIntField(FI.players_skillmoves);
			this.m_usercaneditname = r.GetAndCheckIntField(FI.players_usercaneditname);
			this.m_finishingcode1 = r.GetAndCheckIntField(FI.players_finishingcode1);
			this.m_finishingcode2 = r.GetAndCheckIntField(FI.players_finishingcode2);
			this.m_runningcode1 = r.GetAndCheckIntField(FI.players_runningcode1);
			this.m_runningcode2 = r.GetAndCheckIntField(FI.players_runningcode2);
			this.m_gksavetype = r.GetAndCheckIntField(FI.players_gksavetype);
			this.m_faceposercode = r.GetAndCheckIntField(FI.players_faceposercode);
			this.m_isretiring = r.GetAndCheckIntField(FI.players_isretiring);
			this.m_socklengthcode = r.GetAndCheckIntField(FI.players_socklengthcode);
			this.m_hashighqualityhead = r.GetAndCheckIntField(FI.players_hashighqualityhead);
			this.m_attackingworkrate = r.GetAndCheckIntField(FI.players_attackingworkrate);
			this.m_defensiveworkrate = r.GetAndCheckIntField(FI.players_defensiveworkrate);
			this.m_shortstyle = r.GetAndCheckIntField(FI.players_shortstyle) != 0;
			int andCheckIntField = r.GetAndCheckIntField(FI.players_trait1);
			this.m_Inflexible = (andCheckIntField & 1) != 0;
			this.m_Longthrows = (andCheckIntField & 2) != 0;
			this.m_PowerfulFreeKicks = (andCheckIntField & 4) != 0;
			this.m_Diver = (andCheckIntField & 8) != 0;
			this.m_InjuryProne = (andCheckIntField & 16) != 0;
			this.m_InjuryFree = (andCheckIntField & 32) != 0;
			this.m_AvoidsWeakFoot = (andCheckIntField & 64) != 0;
			this.m_Divesintotackles = (andCheckIntField & 128) != 0;
			this.m_BeatDefensiveLine = (andCheckIntField & 256) != 0;
			this.m_Selfish = (andCheckIntField & 512) != 0;
			this.m_Leadership = (andCheckIntField & 1024) != 0;
			this.m_ArguesWithOfficials = (andCheckIntField & 2048) != 0;
			this.m_Earlycrosser = (andCheckIntField & 4096) != 0;
			this.m_FinesseShot = (andCheckIntField & 8192) != 0;
			this.m_Flair = (andCheckIntField & 16384) != 0;
			this.m_LongPasser = (andCheckIntField & 32768) != 0;
			this.m_LongShotTaker = (andCheckIntField & 65536) != 0;
			this.m_Technicaldribbler = (andCheckIntField & 131072) != 0;
			this.m_Playmaker = (andCheckIntField & 262144) != 0;
			this.m_Pushesupforcorners = (andCheckIntField & 524288) != 0;
			this.m_Puncher = (andCheckIntField & 1048576) != 0;
			this.m_GkLongThrower = (andCheckIntField & 2097152) != 0;
			this.m_PowerHeader = (andCheckIntField & 4194304) != 0;
			this.m_GkOneOnOne = (andCheckIntField & 8388608) != 0;
			this.m_GiantThrow = (andCheckIntField & 16777216) != 0;
			this.m_OutsideFootShot = (andCheckIntField & 33554432) != 0;
			this.m_CrowdFavorite = (andCheckIntField & 67108864) != 0;
			this.m_SwervePasser = (andCheckIntField & 134217728) != 0;
			this.m_SecondWind = (andCheckIntField & 268435456) != 0;
			this.m_AcrobaticClearance = (andCheckIntField & 536870912) != 0;
			int andCheckIntField2 = r.GetAndCheckIntField(FI.players_trait2);
			this.m_FancyFeet = (andCheckIntField2 & 1) != 0;
			this.m_FancyPasses = (andCheckIntField2 & 2) != 0;
			this.m_FancyFlicks = (andCheckIntField2 & 4) != 0;
			this.m_StutterPenalty = (andCheckIntField2 & 8) != 0;
			this.m_ChipperPenalty = (andCheckIntField2 & 16) != 0;
			this.m_BycicleKick = (andCheckIntField2 & 32) != 0;
			this.m_DivingHeader = (andCheckIntField2 & 64) != 0;
			this.m_DrivenPass = (andCheckIntField2 & 128) != 0;
			this.m_GkFlatKick = (andCheckIntField2 & 256) != 0;
			this.m_HighClubIdentification = (andCheckIntField2 & 512) != 0;
			this.m_TeamPlayer = (andCheckIntField2 & 1024) != 0;
			this.m_assetid = base.Id;
			this.m_nationality = r.GetAndCheckIntField(FI.players_nationality);
			this.m_weakfootabilitytypecode = r.GetAndCheckIntField(FI.players_weakfootabilitytypecode);
			this.m_curve = r.GetAndCheckIntField(FI.players_curve);
			this.m_internationalrep = r.GetAndCheckIntField(FI.players_internationalrep) - 1;
			this.m_interceptions = r.GetAndCheckIntField(FI.players_interceptions);
			this.m_shoecolorcode2 = r.GetAndCheckIntField(FI.players_shoecolorcode2);
			this.m_jerseyfit = r.GetAndCheckIntField(FI.players_jerseyfit) != 0;
			this.m_shoedesigncode = r.GetAndCheckIntField(FI.players_shoedesigncode);
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00014A45 File Offset: 0x00012C45
		public void FillFromPlayerloans(Record r)
		{
			this.m_teamidloanedfrom = r.GetAndCheckIntField(FI.playerloans_teamidloanedfrom);
			this.m_loandateend = FifaUtil.ConvertToDate(r.GetAndCheckIntField(FI.playerloans_loandateend));
			this.m_IsLoaned = true;
		}

		// Token: 0x060003DB RID: 987 RVA: 0x00014A75 File Offset: 0x00012C75
		public void FillFromPreviousTeam(Record r)
		{
			this.m_previousteamid = r.GetAndCheckIntField(FI.previousteam_previousteamid);
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00014A88 File Offset: 0x00012C88
		public void FillFromEditedPlayerNames(Record r)
		{
			this.m_firstname = r.GetAndCheckStringField(FI.editedplayernames_firstname);
			this.m_lastname = r.GetAndCheckStringField(FI.editedplayernames_surname);
			this.m_commonname = r.GetAndCheckStringField(FI.editedplayernames_commonname);
			this.m_playerjerseyname = r.GetAndCheckStringField(FI.editedplayernames_playerjerseyname);
			this.m_IsLoaned = true;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x00014AE0 File Offset: 0x00012CE0
		public void SavePlayerloans(Record r)
		{
			r.IntField[FI.playerloans_playerid] = base.Id;
			r.IntField[FI.playerloans_teamidloanedfrom] = this.m_teamidloanedfrom;
			r.IntField[FI.playerloans_loandateend] = FifaUtil.ConvertFromDate(this.m_loandateend);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00014B1D File Offset: 0x00012D1D
		public void SavePreviousTeam(Record r)
		{
			r.IntField[FI.previousteam_playerid] = base.Id;
			r.IntField[FI.previousteam_previousteamid] = this.m_previousteamid;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00014B44 File Offset: 0x00012D44
		public void LinkCountry(CountryList countryList)
		{
			if (countryList == null)
			{
				return;
			}
			this.m_Country = (Country)countryList.SearchId(this.m_nationality);
			if (this.m_Country == null)
			{
				if (countryList.Count > 0)
				{
					this.m_Country = (Country)countryList[0];
					this.m_nationality = this.m_Country.Id;
					return;
				}
				this.m_nationality = 0;
			}
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00014BA8 File Offset: 0x00012DA8
		public void LinkTeam(TeamList teamList)
		{
			if (teamList == null)
			{
				return;
			}
			if (this.m_teamidloanedfrom != 0)
			{
				this.m_TeamLoanedFrom = (Team)teamList.SearchId(this.m_teamidloanedfrom);
				if (this.m_TeamLoanedFrom == null)
				{
					this.m_teamidloanedfrom = 0;
				}
			}
			if (this.m_previousteamid != 0)
			{
				this.m_PreviousTeam = (Team)teamList.SearchId(this.m_previousteamid);
				if (this.m_PreviousTeam == null)
				{
					this.m_previousteamid = 0;
				}
			}
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00014C18 File Offset: 0x00012E18
		public void SearchCountry()
		{
			if (FifaEnvironment.Countries == null)
			{
				this.m_Country = null;
				return;
			}
			this.m_Country = (Country)FifaEnvironment.Countries.SearchId(this.m_nationality);
			if (this.m_Country == null)
			{
				if (FifaEnvironment.Countries.Count > 0)
				{
					this.m_Country = (Country)FifaEnvironment.Countries[0];
					this.m_nationality = this.m_Country.Id;
					return;
				}
				this.m_nationality = 0;
			}
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00014C93 File Offset: 0x00012E93
		public void SearchWouldTeams()
		{
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00014C98 File Offset: 0x00012E98
		public void InitNewPlayer()
		{
			this.m_firstname = string.Empty;
			this.m_lastname = "New Player";
			this.m_lastnameKey = 900000;
			this.m_commonname = string.Empty;
			this.m_playerjerseyname = "New Player";
			this.m_playerjerseynameid = 0;
			this.m_firstnameid = 0;
			this.m_commonnameid = 0;
			this.m_lastnameid = 0;
			this.m_birthdate = new DateTime(1980, 6, 15);
			this.m_playerjointeamdate = new DateTime(2010, 1, 1);
			this.m_contractvaliduntil = 2015;
			this.m_height = 180;
			this.m_weight = 80;
			this.m_preferredposition1 = 0;
			this.m_preferredposition2 = -1;
			this.m_preferredposition3 = -1;
			this.m_preferredposition4 = -1;
			this.m_preferredfoot = 0;
			this.m_jerseysleevelengthcode = 0;
			this.m_jerseystylecode = 0;
			this.m_hasseasonaljersey = 0;
			this.m_animfreekickstartposcode = 0;
			this.m_animpenaltieskickstylecode = 0;
			this.m_animpenaltiesmotionstylecode = 0;
			this.m_animpenaltiesstartposcode = 0;
			this.m_accessorycode1 = 0;
			this.m_accessorycolourcode1 = 1;
			this.m_accessorycode2 = 0;
			this.m_accessorycolourcode2 = 1;
			this.m_accessorycode3 = 0;
			this.m_accessorycolourcode3 = 1;
			this.m_accessorycode4 = 0;
			this.m_accessorycolourcode4 = 1;
			this.m_acceleration = 50;
			this.m_aggression = 50;
			this.m_sprintspeed = 50;
			this.m_stamina = 50;
			this.m_strength = 50;
			this.m_marking = 50;
			this.m_standingtackle = 50;
			this.m_slidingtackle = 50;
			this.m_ballcontrol = 50;
			this.m_dribbling = 50;
			this.m_crossing = 50;
			this.m_headingaccuracy = 50;
			this.m_shortpassing = 50;
			this.m_longpassing = 50;
			this.m_longshots = 50;
			this.m_finishing = 50;
			this.m_shotpower = 50;
			this.m_reactions = 50;
			this.m_gkreflexes = 50;
			this.m_gkglovetypecode = 0;
			this.m_agility = 50;
			this.m_balance = 50;
			this.m_gkkicking = 50;
			this.m_gkkickstyle = 0;
			this.m_jumping = 50;
			this.m_penalties = 50;
			this.m_vision = 50;
			this.m_volleys = 50;
			this.m_skillmoves = 0;
			this.m_usercaneditname = 0;
			this.m_gkhandling = 50;
			this.m_gkdiving = 50;
			this.m_gkpositioning = 50;
			this.m_freekickaccuracy = 50;
			this.m_positioning = 50;
			this.m_InjuryFree = false;
			this.m_HighClubIdentification = false;
			this.m_TeamPlayer = false;
			this.m_Leadership = false;
			this.m_ArguesWithOfficials = false;
			this.m_AvoidsWeakFoot = false;
			this.m_InjuryProne = false;
			this.m_Puncher = false;
			this.m_Pushesupforcorners = false;
			this.m_Technicaldribbler = false;
			this.m_Selfish = false;
			this.m_Playmaker = false;
			this.m_Diver = false;
			this.m_Divesintotackles = false;
			this.m_LongShotTaker = false;
			this.m_Earlycrosser = false;
			this.m_Inflexible = false;
			this.m_GkOneOnOne = false;
			this.m_Longthrows = false;
			this.m_OutsideFootShot = false;
			this.m_LongPasser = false;
			this.m_GiantThrow = false;
			this.m_Flair = false;
			this.m_PowerfulFreeKicks = false;
			this.m_FinesseShot = false;
			this.m_PowerHeader = false;
			this.m_SwervePasser = false;
			this.m_BeatDefensiveLine = false;
			this.m_GkLongThrower = false;
			this.m_CrowdFavorite = false;
			this.m_SecondWind = false;
			this.m_AcrobaticClearance = false;
			this.m_FancyFeet = false;
			this.m_FancyPasses = false;
			this.m_FancyFlicks = false;
			this.m_StutterPenalty = false;
			this.m_ChipperPenalty = false;
			this.m_BycicleKick = false;
			this.m_DivingHeader = false;
			this.m_DrivenPass = false;
			this.m_GkFlatKick = false;
			this.m_assetid = base.Id;
			this.m_potential = 50;
			this.m_nationality = 0;
			this.SearchCountry();
			this.m_bodytypecode = 1;
			this.m_weakfootabilitytypecode = 3;
			this.m_curve = 50;
			this.m_internationalrep = 2;
			this.m_eyecolorcode = 1;
			this.m_eyebrowcode = 0;
			this.m_hairtypecode = 1;
			this.m_headtypecode = 1;
			this.m_headclasscode = 1;
			this.m_haircolorcode = 1;
			this.m_facialhairtypecode = 0;
			this.m_facialhaircolorcode = 0;
			this.m_sideburnscode = 1;
			this.m_skintypecode = 0;
			this.m_skintonecode = 2;
			this.m_shoecolorcode1 = 1;
			this.m_shoetypecode = 0;
			this.m_overallrating = 50;
			this.m_finishingcode1 = 0;
			this.m_finishingcode2 = 0;
			this.m_runningcode1 = 0;
			this.m_runningcode2 = 0;
			this.m_gksavetype = 0;
			this.m_faceposercode = 0;
			this.m_isretiring = 0;
			this.m_socklengthcode = 0;
			this.m_hashighqualityhead = 0;
			this.m_attackingworkrate = 0;
			this.m_defensiveworkrate = 0;
			this.m_shortstyle = false;
			this.m_interceptions = 50;
			this.m_shoecolorcode2 = 31;
			this.m_jerseyfit = false;
			this.m_shoedesigncode = 0;
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x0001510D File Offset: 0x0001330D
		public Player(int playerId)
			: base(playerId)
		{
			base.Id = playerId;
			this.InitNewPlayer();
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00015130 File Offset: 0x00013330
		public override IdObject Clone(int playerid)
		{
			Player player = (Player)base.Clone(playerid);
			player.m_lastname = "Player " + player.Id.ToString();
			player.m_lastnameKey = player.m_lastnameKey;
			player.m_firstname = string.Empty;
			player.m_assetid = playerid;
			player.m_PlayingForTeams = new TeamList();
			player.m_HasSpecificPhoto = false;
			player.GetPhoto();
			player.m_HeadModelFile = null;
			player.m_HairModelFile = null;
			player.GetHeadModel();
			player.m_FaceTextureBitmap = null;
			player.GetFaceTexture();
			player.m_HairColorTextureBitmap = null;
			player.m_HairAlfaTextureBitmap = null;
			player.GetHairTextures();
			return player;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x000151D8 File Offset: 0x000133D8
		public Player Copy(Player clone)
		{
			clone.m_birthdate = this.m_birthdate;
			clone.m_playerjointeamdate = this.m_playerjointeamdate;
			clone.m_contractvaliduntil = this.m_contractvaliduntil;
			clone.m_nationality = this.m_nationality;
			clone.m_Country = this.m_Country;
			clone.m_height = this.m_height;
			clone.m_weight = this.m_weight;
			clone.m_bodytypecode = this.m_bodytypecode;
			clone.m_jerseysleevelengthcode = this.m_jerseysleevelengthcode;
			clone.m_jerseystylecode = this.m_jerseystylecode;
			clone.m_hasseasonaljersey = this.m_hasseasonaljersey;
			clone.m_animfreekickstartposcode = this.m_animfreekickstartposcode;
			clone.m_animpenaltieskickstylecode = this.m_animpenaltieskickstylecode;
			clone.m_animpenaltiesmotionstylecode = this.m_animpenaltiesmotionstylecode;
			clone.m_animpenaltiesstartposcode = this.m_animpenaltiesstartposcode;
			clone.m_accessorycode1 = this.m_accessorycode1;
			clone.m_accessorycolourcode1 = this.m_accessorycolourcode1;
			clone.m_accessorycode2 = this.m_accessorycode2;
			clone.m_accessorycolourcode2 = this.m_accessorycolourcode2;
			clone.m_accessorycode3 = this.m_accessorycode3;
			clone.m_accessorycolourcode3 = this.m_accessorycolourcode3;
			clone.m_accessorycode4 = this.m_accessorycode4;
			clone.m_accessorycolourcode4 = this.m_accessorycolourcode4;
			clone.m_preferredposition1 = this.m_preferredposition1;
			clone.m_preferredposition2 = this.m_preferredposition2;
			clone.m_preferredposition3 = this.m_preferredposition3;
			clone.m_preferredposition4 = this.m_preferredposition4;
			clone.m_preferredfoot = this.m_preferredfoot;
			clone.m_weakfootabilitytypecode = this.m_weakfootabilitytypecode;
			clone.m_acceleration = this.m_acceleration;
			clone.m_aggression = this.m_aggression;
			clone.m_sprintspeed = this.m_sprintspeed;
			clone.m_stamina = this.m_stamina;
			clone.m_strength = this.m_strength;
			clone.m_marking = this.m_marking;
			clone.m_interceptions = this.m_interceptions;
			clone.m_standingtackle = this.m_standingtackle;
			clone.m_slidingtackle = this.m_slidingtackle;
			clone.m_ballcontrol = this.m_ballcontrol;
			clone.m_dribbling = this.m_dribbling;
			clone.m_crossing = this.m_crossing;
			clone.m_headingaccuracy = this.m_headingaccuracy;
			clone.m_shortpassing = this.m_shortpassing;
			clone.m_longpassing = this.m_longpassing;
			clone.m_longshots = this.m_longshots;
			clone.m_finishing = this.m_finishing;
			clone.m_shotpower = this.m_shotpower;
			clone.m_reactions = this.m_reactions;
			clone.m_gkreflexes = this.m_gkreflexes;
			clone.m_gkglovetypecode = this.m_gkglovetypecode;
			clone.m_agility = this.m_agility;
			clone.m_balance = this.m_balance;
			clone.m_gkkicking = this.m_gkkicking;
			clone.m_gkkickstyle = this.m_gkkickstyle;
			clone.m_jumping = this.m_jumping;
			clone.m_penalties = this.m_penalties;
			clone.m_vision = this.m_vision;
			clone.m_volleys = this.m_volleys;
			clone.m_skillmoves = this.m_skillmoves;
			clone.m_usercaneditname = this.m_usercaneditname;
			clone.m_gkhandling = this.m_gkhandling;
			clone.m_gkdiving = this.m_gkdiving;
			clone.m_gkpositioning = this.m_gkpositioning;
			clone.m_positioning = this.m_positioning;
			clone.m_freekickaccuracy = this.m_freekickaccuracy;
			clone.m_potential = this.m_potential;
			clone.m_InjuryFree = this.m_InjuryFree;
			clone.m_HighClubIdentification = this.m_HighClubIdentification;
			clone.m_TeamPlayer = this.m_TeamPlayer;
			clone.m_Leadership = this.m_Leadership;
			clone.m_ArguesWithOfficials = this.m_ArguesWithOfficials;
			clone.m_AvoidsWeakFoot = this.m_AvoidsWeakFoot;
			clone.m_InjuryProne = this.m_InjuryProne;
			clone.m_Puncher = this.m_Puncher;
			clone.m_Pushesupforcorners = this.m_Pushesupforcorners;
			clone.m_Technicaldribbler = this.m_Technicaldribbler;
			clone.m_Selfish = this.m_Selfish;
			clone.m_Playmaker = this.m_Playmaker;
			clone.m_Diver = this.m_Diver;
			clone.m_Divesintotackles = this.m_Divesintotackles;
			clone.m_LongShotTaker = this.m_LongShotTaker;
			clone.m_Earlycrosser = this.m_Earlycrosser;
			clone.m_Inflexible = this.m_Inflexible;
			clone.m_GkOneOnOne = this.m_GkOneOnOne;
			clone.m_Longthrows = this.m_Longthrows;
			clone.m_OutsideFootShot = this.m_OutsideFootShot;
			clone.m_LongPasser = this.m_LongPasser;
			clone.m_GiantThrow = this.m_GiantThrow;
			clone.m_Flair = this.m_Flair;
			clone.m_PowerfulFreeKicks = this.m_PowerfulFreeKicks;
			clone.m_FinesseShot = this.m_FinesseShot;
			clone.m_PowerHeader = this.m_PowerHeader;
			clone.m_SwervePasser = this.m_SwervePasser;
			clone.m_BeatDefensiveLine = this.m_BeatDefensiveLine;
			clone.m_GkLongThrower = this.m_GkLongThrower;
			clone.m_FancyFeet = this.m_FancyFeet;
			clone.m_FancyPasses = this.m_FancyPasses;
			clone.m_FancyFlicks = this.m_FancyFlicks;
			clone.m_StutterPenalty = this.m_StutterPenalty;
			clone.m_ChipperPenalty = this.m_ChipperPenalty;
			clone.m_BycicleKick = this.m_BycicleKick;
			clone.m_DivingHeader = this.m_DivingHeader;
			clone.m_DrivenPass = this.m_DrivenPass;
			clone.m_GkFlatKick = this.m_GkFlatKick;
			clone.m_curve = this.m_curve;
			clone.m_internationalrep = this.m_internationalrep + 1;
			clone.m_eyecolorcode = this.m_eyecolorcode;
			clone.m_eyebrowcode = this.m_eyebrowcode;
			clone.m_hairtypecode = this.m_hairtypecode;
			clone.m_headtypecode = this.m_headtypecode;
			clone.m_headclasscode = 1;
			clone.m_haircolorcode = this.m_haircolorcode;
			clone.m_facialhairtypecode = this.m_facialhairtypecode;
			clone.m_facialhaircolorcode = this.m_facialhaircolorcode;
			clone.m_sideburnscode = this.m_sideburnscode;
			clone.m_skintypecode = this.m_skintypecode;
			clone.m_skintonecode = this.m_skintonecode;
			clone.m_shoecolorcode1 = this.m_shoecolorcode1;
			clone.m_shoecolorcode2 = this.m_shoecolorcode2;
			clone.m_shoetypecode = this.m_shoetypecode;
			clone.m_shoedesigncode = this.m_shoedesigncode;
			clone.m_overallrating = this.m_overallrating;
			clone.m_HasSpecificPhoto = false;
			return clone;
		}

		// Token: 0x060003E7 RID: 999 RVA: 0x000157A2 File Offset: 0x000139A2
		public string SpecificFaceTextureFileName()
		{
			return Player.SpecificFaceTextureFileName(base.Id);
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x000157AF File Offset: 0x000139AF
		public static string SpecificFaceTextureFileName(int id)
		{
			return "data/sceneassets/faces/face_" + id.ToString() + "_0_0_0_0_0_0_0_0_textures.rx3";
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x000157C8 File Offset: 0x000139C8
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

		// Token: 0x060003EA RID: 1002 RVA: 0x00015875 File Offset: 0x00013A75
		public string SpecificFaceTextureTemplateName()
		{
			return "data/sceneassets/faces/face_#_0_0_0_0_0_0_0_0_textures.rx3";
		}

		// Token: 0x060003EB RID: 1003 RVA: 0x0001587C File Offset: 0x00013A7C
		public string GenericHeadModelFileName()
		{
			return "data/sceneassets/heads/head_" + this.m_headtypecode.ToString() + "_1.rx3";
		}

		// Token: 0x060003EC RID: 1004 RVA: 0x000158A8 File Offset: 0x00013AA8
		public string GenericHeadModelTemplateName()
		{
			return "data/sceneassets/heads/head_#_1.rx3";
		}

		// Token: 0x060003ED RID: 1005 RVA: 0x000158BC File Offset: 0x00013ABC
		public string SpecificHeadModelFileName()
		{
			return Player.SpecificHeadModelFileName(base.Id);
		}

		// Token: 0x060003EE RID: 1006 RVA: 0x000158CC File Offset: 0x00013ACC
		public static string SpecificHeadModelFileName(int id)
		{
			return "data/sceneassets/heads/head_" + id.ToString() + "_0.rx3";
		}

		// Token: 0x060003EF RID: 1007 RVA: 0x000158F4 File Offset: 0x00013AF4
		public string SpecificHeadModelTemplateName()
		{
			return "data/sceneassets/heads/head_#_0.rx3";
		}

		// Token: 0x060003F0 RID: 1008 RVA: 0x00015908 File Offset: 0x00013B08
		public string GenericHairModelFileName()
		{
			return this.GenericHairModelFileName(this.m_hairtypecode);
		}

		// Token: 0x060003F1 RID: 1009 RVA: 0x00015918 File Offset: 0x00013B18
		public string GenericHairModelFileName(int hairtypecode)
		{
			return "data/sceneassets/hair/hair_" + hairtypecode.ToString() + "_1_0.rx3";
		}

		// Token: 0x060003F2 RID: 1010 RVA: 0x00015940 File Offset: 0x00013B40
		public static string GenericHairLodModelFileName(int hairtypecode)
		{
			return "data/sceneassets/hairlod/hairlod_" + hairtypecode.ToString() + "_1_0.rx3";
		}

		// Token: 0x060003F3 RID: 1011 RVA: 0x00015965 File Offset: 0x00013B65
		public string GenericHairLodModelFileName()
		{
			return Player.GenericHairLodModelFileName(this.m_hairtypecode);
		}

		// Token: 0x060003F4 RID: 1012 RVA: 0x00015974 File Offset: 0x00013B74
		public static string SpecificHairLodModelFileName(int id)
		{
			return "data/sceneassets/hairlod/hairlod_" + id.ToString() + "_0_0.rx3";
		}

		// Token: 0x060003F5 RID: 1013 RVA: 0x00015999 File Offset: 0x00013B99
		public string SpecificHairLodModelFileName()
		{
			return Player.SpecificHairLodModelFileName(base.Id);
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000159A8 File Offset: 0x00013BA8
		public string GenericHairModelTemplateName()
		{
			return "data/sceneassets/hair/hair_#_1_0.rx3";
		}

		// Token: 0x060003F7 RID: 1015 RVA: 0x000159BC File Offset: 0x00013BBC
		public string SpecificHairModelFileName()
		{
			return "data/sceneassets/hair/hair_" + base.Id.ToString() + "_0_0.rx3";
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x000159E8 File Offset: 0x00013BE8
		public string SpecificHairModelTemplateName()
		{
			return "data/sceneassets/hair/hair_#_0_0.rx3";
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x000159FC File Offset: 0x00013BFC
		public string HeadModelFileName()
		{
			if (this.headclasscode == 0)
			{
				return this.SpecificHeadModelFileName();
			}
			return this.GenericHeadModelFileName();
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00015A13 File Offset: 0x00013C13
		public string HairModelFileName()
		{
			if (this.headclasscode == 0)
			{
				return this.SpecificHairModelFileName();
			}
			return this.GenericHairModelFileName();
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00015A2A File Offset: 0x00013C2A
		public string HairLodModelFileName()
		{
			if (this.headclasscode == 0)
			{
				return this.SpecificHairLodModelFileName();
			}
			return this.GenericHairLodModelFileName();
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00015A41 File Offset: 0x00013C41
		public string FaceTextureFileName()
		{
			if (this.HasSpecificHeadModel)
			{
				return this.SpecificFaceTextureFileName();
			}
			return this.GenericFaceTextureFileName();
		}

		// Token: 0x060003FD RID: 1021 RVA: 0x00015A58 File Offset: 0x00013C58
		public string SpecificEyesTextureFileName()
		{
			return "data/sceneassets/heads/eyes_" + base.Id.ToString() + "_0_textures.rx3";
		}

		// Token: 0x060003FE RID: 1022 RVA: 0x00015A84 File Offset: 0x00013C84
		public static string SpecificEyesTextureFileName(int id)
		{
			return "data/sceneassets/heads/eyes_" + id.ToString() + "_0_textures.rx3";
		}

		// Token: 0x060003FF RID: 1023 RVA: 0x00015AAC File Offset: 0x00013CAC
		public string SpecificEyesTextureTemplateName()
		{
			return "data/sceneassets/heads/eyes_#_0_textures.rx3";
		}

		// Token: 0x06000400 RID: 1024 RVA: 0x00015AC0 File Offset: 0x00013CC0
		public string GenericEyesTextureFileName()
		{
			return "data/sceneassets/heads/eyes_" + this.m_eyecolorcode.ToString() + "_1_textures.rx3";
		}

		// Token: 0x06000401 RID: 1025 RVA: 0x00015AEC File Offset: 0x00013CEC
		public string SkinTextureTemplateName()
		{
			return "data/sceneassets/body/skin_#_textures.rx3";
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00015B00 File Offset: 0x00013D00
		public string SkinTextureFileName()
		{
			return "data/sceneassets/body/skin_" + this.m_skintonecode.ToString() + "_textures.rx3";
		}

		// Token: 0x06000403 RID: 1027 RVA: 0x00015B29 File Offset: 0x00013D29
		public string SpecificPhotoTemplateFileName()
		{
			return "data/ui/imgassets/heads/p#.dds";
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00015B30 File Offset: 0x00013D30
		public string SpecificPhotoDdsFileName()
		{
			return "data/ui/imgassets/heads/p" + base.Id.ToString() + ".dds";
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00015B5A File Offset: 0x00013D5A
		public static string SpecificPhotoDdsFileName(int id)
		{
			return "data/ui/imgassets/heads/p" + id.ToString() + ".dds";
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00015B74 File Offset: 0x00013D74
		public bool IsPlayingFor(Team team)
		{
			if (this.m_PlayingForTeams == null)
			{
				return false;
			}
			foreach (object obj in this.m_PlayingForTeams)
			{
				Team team2 = (Team)obj;
				if (team2 == team)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x00015BDC File Offset: 0x00013DDC
		public void PlayFor(Team team)
		{
			if (this.m_PlayingForTeams == null)
			{
				this.m_PlayingForTeams = new TeamList();
			}
			foreach (object obj in this.m_PlayingForTeams)
			{
				Team team2 = (Team)obj;
				if (team2 == team)
				{
					return;
				}
			}
			this.m_PlayingForTeams.Add(team);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x00015C54 File Offset: 0x00013E54
		public void NotPlayFor(Team team)
		{
			if (this.m_PlayingForTeams == null)
			{
				return;
			}
			foreach (object obj in this.m_PlayingForTeams)
			{
				Team team2 = (Team)obj;
				if (team2 == team)
				{
					this.m_PlayingForTeams.Remove(team);
					break;
				}
			}
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x00015CC4 File Offset: 0x00013EC4
		public bool IsFreeAgent()
		{
			return this.m_PlayingForTeams == null || this.m_PlayingForTeams.Count == 0;
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x00015CE0 File Offset: 0x00013EE0
		public bool IsMultiClub()
		{
			int num = 0;
			if (this.m_PlayingForTeams != null)
			{
				foreach (object obj in this.m_PlayingForTeams)
				{
					Team team = (Team)obj;
					if (team.IsClub())
					{
						num++;
					}
				}
			}
			return num > 1;
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x00015D4C File Offset: 0x00013F4C
		public Bitmap GetPhoto()
		{
			string text = this.SpecificPhotoDdsFileName();
			Bitmap bitmap = FifaEnvironment.Get2dHead(text);
			this.m_HasSpecificPhoto = bitmap != null;
			return bitmap;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00015D75 File Offset: 0x00013F75
		public bool SetPhoto(Bitmap bitmap)
		{
			return FifaEnvironment.Set2dHead(this.SpecificPhotoTemplateFileName(), base.Id, bitmap);
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00015D89 File Offset: 0x00013F89
		public bool DeletePhoto()
		{
			return FifaEnvironment.Delete2dHead(this.SpecificPhotoDdsFileName());
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00015D98 File Offset: 0x00013F98
		private void ChangeHairColor(Bitmap bitmap, int color)
		{
			int num = 128;
			int num2 = 128;
			int num3 = 128;
			switch (color)
			{
			case 1:
				num = 64;
				num2 = 64;
				num3 = 64;
				break;
			case 2:
				num = 92;
				num2 = 92;
				num3 = 92;
				break;
			case 3:
				return;
			case 4:
				num = 160;
				num2 = 180;
				num3 = 128;
				break;
			case 5:
				num = 170;
				num2 = 128;
				num3 = 128;
				break;
			case 6:
				num = 192;
				num2 = 256;
				num3 = 256;
				break;
			case 7:
				num = 128;
				num2 = 150;
				num3 = 150;
				break;
			}
			for (int i = 0; i < 128; i++)
			{
				for (int j = 0; j < 128; j++)
				{
					Color pixel = bitmap.GetPixel(i, j);
					if (pixel.R != 128 || pixel.G != 128 || pixel.B != 128)
					{
						int num4 = (int)pixel.R * num / 128;
						int num5 = (int)pixel.G * num2 / 128;
						int num6 = (int)pixel.B * num3 / 128;
						if (num4 > 255)
						{
							num4 = 255;
						}
						if (num5 > 255)
						{
							num5 = 255;
						}
						if (num6 > 255)
						{
							num6 = 255;
						}
						if (color == 6)
						{
							num5 = (num4 = num6);
						}
						bitmap.SetPixel(i, j, Color.FromArgb(255, num4, num5, num6));
					}
				}
			}
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00015F38 File Offset: 0x00014138
		private void OverlapBitmaps(Bitmap lowerBitmap, Bitmap upperBitmap)
		{
			for (int i = 0; i < 128; i++)
			{
				for (int j = 0; j < 128; j++)
				{
					Color pixel = upperBitmap.GetPixel(i, j);
					if (pixel.R != 128 || pixel.G != 128 || pixel.B != 128)
					{
						lowerBitmap.SetPixel(i, j, pixel);
					}
				}
			}
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x00015FA4 File Offset: 0x000141A4
		public void ChangeId()
		{
			this.m_assetid = base.Id;
			this.headclasscode = (FifaEnvironment.IsFilePresent(this.SpecificHeadModelFileName()) ? 0 : 1);
			this.m_FaceTextureBitmap = null;
			this.m_HairColorTextureBitmap = null;
			this.m_HairAlfaTextureBitmap = null;
			this.m_HeadModelFile = null;
		}

		// Token: 0x06000411 RID: 1041 RVA: 0x00015FF0 File Offset: 0x000141F0
		public void CleanFaceTexture()
		{
			if (this.m_FaceTextureBitmap != null)
			{
				this.m_FaceTextureBitmap.Dispose();
			}
			this.m_FaceTextureBitmap = null;
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x0001600C File Offset: 0x0001420C
		public Bitmap GetFaceTexture()
		{
			if (this.m_FaceTextureBitmap != null)
			{
				return this.m_FaceTextureBitmap;
			}
			string text;
			if (this.HasSpecificHeadModel)
			{
				text = this.SpecificFaceTextureFileName();
			}
			else
			{
				text = this.GenericFaceTextureFileName();
			}
			this.m_FaceTextureBitmap = FifaEnvironment.GetBmpFromRx3(text, 0);
			return this.m_FaceTextureBitmap;
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00016055 File Offset: 0x00014255
		public bool SetFaceTextures(Bitmap bitmap)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5038);
				return false;
			}
			this.CleanFaceTexture();
			return FifaEnvironment.ImportBmpsIntoZdata(this.SpecificFaceTextureTemplateName(), base.Id, bitmap, ECompressionMode.Chunkzip, null);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x0001608B File Offset: 0x0001428B
		public bool SetFaceTextures(string rx3FileName)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5038);
				return false;
			}
			this.CleanFaceTexture();
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificFaceTextureFileName(), false, ECompressionMode.Chunkzip, null);
		}

		// Token: 0x06000415 RID: 1045 RVA: 0x000160BC File Offset: 0x000142BC
		public bool DeleteFaceTexture()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5039);
				return false;
			}
			bool flag = FifaEnvironment.DeleteFromZdata(this.FaceTextureFileName());
			if (flag)
			{
				this.m_FaceTextureBitmap = null;
			}
			return flag;
		}

		// Token: 0x06000416 RID: 1046 RVA: 0x000160FA File Offset: 0x000142FA
		public bool SetSkinTextures(Bitmap bitmap)
		{
			if (this.m_skintonecode < 10)
			{
				FifaEnvironment.UserMessages.ShowMessage(5063);
				return false;
			}
			return FifaEnvironment.ImportBmpsIntoZdata(this.SkinTextureTemplateName(), this.m_skintonecode, bitmap, ECompressionMode.Chunkzip, this.SkinSignature());
		}

		// Token: 0x06000417 RID: 1047 RVA: 0x00016134 File Offset: 0x00014334
		public Bitmap GetSkinTexture()
		{
			string text = this.SkinTextureFileName();
			return FifaEnvironment.GetBmpFromRx3(text, 0);
		}

		// Token: 0x06000418 RID: 1048 RVA: 0x00016154 File Offset: 0x00014354
		public bool DeleteSkinTexture()
		{
			if (this.m_skintonecode < 10)
			{
				FifaEnvironment.UserMessages.ShowMessage(5063);
				return false;
			}
			return FifaEnvironment.DeleteFromZdata(this.SkinTextureFileName());
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x0001618C File Offset: 0x0001438C
		private Rx3Signatures SkinSignature()
		{
			return new Rx3Signatures(175072, 24, new string[] { "body_" + this.m_skintonecode.ToString() + "_cm.Raster" });
		}

		// Token: 0x0600041A RID: 1050 RVA: 0x000161CC File Offset: 0x000143CC
		public Bitmap GetEyesTexture()
		{
			if (this.m_EyesTextureBitmap != null)
			{
				return this.m_EyesTextureBitmap;
			}
			string text;
			if (this.HasSpecificHeadModel)
			{
				text = this.SpecificEyesTextureFileName();
			}
			else
			{
				text = this.GenericEyesTextureFileName();
			}
			this.m_EyesTextureBitmap = FifaEnvironment.GetBmpFromRx3(text, 0);
			return this.m_EyesTextureBitmap;
		}

		// Token: 0x0600041B RID: 1051 RVA: 0x00016218 File Offset: 0x00014418
		private Rx3Signatures EyesSignature()
		{
			return new Rx3Signatures(11200, 24, new string[] { "eyes_" + base.Id.ToString() + "_0_cm.Raster" });
		}

		// Token: 0x0600041C RID: 1052 RVA: 0x0001625B File Offset: 0x0001445B
		public bool SetEyesTextures(Bitmap bitmap)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5038);
				return false;
			}
			this.CleanEyesTexture();
			return FifaEnvironment.ImportBmpsIntoZdata(this.SpecificEyesTextureTemplateName(), base.Id, bitmap, ECompressionMode.Chunkzip, this.EyesSignature());
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00016296 File Offset: 0x00014496
		public bool SetEyesTextures(string rx3FileName)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5038);
				return false;
			}
			this.CleanEyesTexture();
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificEyesTextureFileName(), false, ECompressionMode.Chunkzip, this.EyesSignature());
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x000162CC File Offset: 0x000144CC
		public void CleanEyesTexture()
		{
			if (this.m_EyesTextureBitmap != null)
			{
				this.m_EyesTextureBitmap.Dispose();
			}
			this.m_EyesTextureBitmap = null;
		}

		// Token: 0x0600041F RID: 1055 RVA: 0x000162E8 File Offset: 0x000144E8
		public bool DeleteEyesTexture()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5039);
				return false;
			}
			bool flag = FifaEnvironment.DeleteFromZdata(this.SpecificEyesTextureFileName());
			if (flag)
			{
				this.m_EyesTextureBitmap = null;
			}
			return flag;
		}

		// Token: 0x06000420 RID: 1056 RVA: 0x00016326 File Offset: 0x00014526
		public string HairTexturesFileName()
		{
			if (this.m_headclasscode == 0)
			{
				return this.SpecificHairTexturesFileName();
			}
			return this.GenericHairTexturesFileName();
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0001633D File Offset: 0x0001453D
		public string SpecificHairTexturesFileName()
		{
			return Player.SpecificHairTexturesFileName(base.Id);
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x0001634C File Offset: 0x0001454C
		public static string SpecificHairTexturesFileName(int id)
		{
			return "data/sceneassets/hair/hair_" + id.ToString() + "_0_textures.rx3";
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00016374 File Offset: 0x00014574
		public string GenericHairTexturesFileName()
		{
			return "data/sceneassets/hair/hair_" + this.m_hairtypecode.ToString() + "_1_textures.rx3";
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x000163A0 File Offset: 0x000145A0
		public string HairTexturesTemplateName()
		{
			return "data/sceneassets/hair/hair_#_0_textures.rx3";
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x000163B4 File Offset: 0x000145B4
		public void CleanHairTextures()
		{
			if (this.m_HairAlfaTextureBitmap != null)
			{
				this.m_HairAlfaTextureBitmap.Dispose();
			}
			this.m_HairAlfaTextureBitmap = null;
			if (this.m_HairColorTextureBitmap != null)
			{
				this.m_HairColorTextureBitmap.Dispose();
			}
			this.m_HairColorTextureBitmap = null;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x000163EC File Offset: 0x000145EC
		public Bitmap GetGenericHairColorTexture()
		{
			if (!this.HasSpecificHeadModel)
			{
				return this.m_HairColorTextureBitmap;
			}
			string text = this.GenericHairTexturesFileName();
			Bitmap[] bmpsFromRx = FifaEnvironment.GetBmpsFromRx3(text);
			if (bmpsFromRx != null)
			{
				return GraphicUtil.MultiplyColorToBitmap(bmpsFromRx[1], Player.s_GenericColors[this.m_haircolorcode], 96);
			}
			return null;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x0001643C File Offset: 0x0001463C
		public Bitmap[] GetHairTextures()
		{
			if (this.m_HairAlfaTextureBitmap != null && this.m_HairColorTextureBitmap != null)
			{
				return new Bitmap[] { this.m_HairAlfaTextureBitmap, this.m_HairColorTextureBitmap };
			}
			Bitmap[] array;
			if (this.HasSpecificHeadModel)
			{
				string text = this.SpecificHairTexturesFileName();
				array = FifaEnvironment.GetBmpsFromRx3(text);
				if (array != null)
				{
					this.m_HairAlfaTextureBitmap = array[0];
					this.m_HairColorTextureBitmap = array[1];
				}
				else
				{
					this.m_HairAlfaTextureBitmap = null;
					this.m_HairColorTextureBitmap = null;
				}
			}
			else
			{
				string text = this.GenericHairTexturesFileName();
				array = FifaEnvironment.GetBmpsFromRx3(text);
				if (array != null)
				{
					this.m_HairAlfaTextureBitmap = array[0];
					this.m_HairColorTextureBitmap = GraphicUtil.MultiplyColorToBitmap(array[1], Player.s_GenericColors[this.m_haircolorcode], 96);
				}
				else
				{
					this.m_HairColorTextureBitmap = null;
				}
			}
			return array;
		}

		// Token: 0x06000428 RID: 1064 RVA: 0x000164FC File Offset: 0x000146FC
		public bool SetHairTextures(Bitmap[] bitmaps)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5038);
				return false;
			}
			return FifaEnvironment.ImportBmpsIntoZdata(this.HairTexturesTemplateName(), base.Id, bitmaps, ECompressionMode.Chunkzip2);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0001652B File Offset: 0x0001472B
		public bool SetHairTextures(string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificHairTexturesFileName(), false, ECompressionMode.Chunkzip2);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0001653C File Offset: 0x0001473C
		public bool DeleteHairTextures()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5039);
				return false;
			}
			bool flag = FifaEnvironment.DeleteFromZdata(this.HairTexturesFileName());
			if (flag)
			{
				this.m_HairColorTextureBitmap = null;
				this.m_HairAlfaTextureBitmap = null;
			}
			return flag;
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x00016581 File Offset: 0x00014781
		public Bitmap GetHairColorTexture()
		{
			if (this.m_HairColorTextureBitmap != null)
			{
				return this.m_HairColorTextureBitmap;
			}
			this.GetHairTextures();
			return this.m_HairColorTextureBitmap;
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0001659F File Offset: 0x0001479F
		public Bitmap GetHairAlfaTexture()
		{
			if (this.m_HairAlfaTextureBitmap != null)
			{
				return this.m_HairAlfaTextureBitmap;
			}
			this.GetHairTextures();
			return this.m_HairAlfaTextureBitmap;
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x000165C0 File Offset: 0x000147C0
		public Rx3File GetHeadModel()
		{
			if (this.m_HeadModelFile != null)
			{
				return this.m_HeadModelFile;
			}
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
			if (this.m_headclasscode == 0)
			{
				this.m_HeadModelFile = FifaEnvironment.GetRx3FromZdata(this.SpecificHeadModelFileName());
			}
			else
			{
				this.m_HeadModelFile = FifaEnvironment.GetRx3FromZdata(this.GenericHeadModelFileName());
			}
			return this.m_HeadModelFile;
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x00016614 File Offset: 0x00014814
		public bool SetHeadModel(string rx3FileName)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificHeadModelFileName(), false, ECompressionMode.Chunkzip);
			if (flag)
			{
				this.m_HeadModelFile = FifaEnvironment.GetRx3FromZdata(this.SpecificHeadModelFileName());
			}
			return flag;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00016664 File Offset: 0x00014864
		public bool DeleteHeadModel()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			bool flag = FifaEnvironment.DeleteFromZdata(this.SpecificHeadModelFileName());
			if (flag)
			{
				this.m_HeadModelFile = null;
			}
			return flag;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x000166A2 File Offset: 0x000148A2
		public void CleanHeadModel()
		{
			this.m_HeadModelFile = null;
		}

		// Token: 0x06000431 RID: 1073 RVA: 0x000166AB File Offset: 0x000148AB
		public void CleanHead()
		{
			this.CleanFaceTexture();
			this.CleanEyesTexture();
			this.CleanHeadModel();
		}

		// Token: 0x06000432 RID: 1074 RVA: 0x000166C0 File Offset: 0x000148C0
		public Rx3File GetHairModel()
		{
			if (this.m_HairModelFile != null)
			{
				return this.m_HairModelFile;
			}
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float16;
			if (this.m_headclasscode == 0)
			{
				this.m_HairModelFile = FifaEnvironment.GetRx3FromZdata(this.SpecificHairModelFileName());
			}
			else
			{
				this.m_HairModelFile = FifaEnvironment.GetRx3FromZdata(this.GenericHairModelFileName());
			}
			return this.m_HairModelFile;
		}

		// Token: 0x06000433 RID: 1075 RVA: 0x00016714 File Offset: 0x00014914
		public bool SetHairLodModel(string rx3FileName)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificHairLodModelFileName(), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000434 RID: 1076 RVA: 0x00016750 File Offset: 0x00014950
		public bool SetHairModel(string rx3FileName)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			bool flag = FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, this.SpecificHairModelFileName(), false, ECompressionMode.Chunkzip);
			if (flag)
			{
				this.m_HairModelFile = FifaEnvironment.GetRx3FromZdata(this.SpecificHairModelFileName());
			}
			return flag;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x000167A0 File Offset: 0x000149A0
		public bool UpdateHairVertex(CustomVertex.PositionNormalTextured[] newVertex4, CustomVertex.PositionNormalTextured[] newVertex5)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			FifaEnvironment.FifaFat.ExtractFile(this.SpecificHairModelFileName());
			Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float16;
			this.m_HairModelFile = new Rx3File();
			this.m_HairModelFile.Load(FifaEnvironment.RootDir + "\\Game\\" + this.SpecificHairModelFileName());
			if (newVertex4 != null)
			{
				this.m_HairModelFile.Rx3VertexArrays[0].SetVertex(newVertex4);
			}
			if (newVertex5 != null)
			{
				this.m_HairModelFile.Rx3VertexArrays[1].SetVertex(newVertex5);
			}
			this.m_HairModelFile.Save(FifaEnvironment.RootDir + "\\Game\\" + this.SpecificHairModelFileName(), false, true);
			return true;
		}

		// Token: 0x06000436 RID: 1078 RVA: 0x0001685C File Offset: 0x00014A5C
		public bool DeleteHairModel()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			bool flag = FifaEnvironment.DeleteFromZdata(this.SpecificHairModelFileName());
			if (flag)
			{
				this.m_HairModelFile = null;
			}
			return flag;
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0001689C File Offset: 0x00014A9C
		public bool DeleteHairLodModel()
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5062);
				return false;
			}
			return FifaEnvironment.DeleteFromZdata(this.SpecificHairLodModelFileName());
		}

		// Token: 0x06000438 RID: 1080 RVA: 0x000168D0 File Offset: 0x00014AD0
		public void CleanHairModel()
		{
			this.m_HairModelFile = null;
		}

		// Token: 0x06000439 RID: 1081 RVA: 0x000168D9 File Offset: 0x00014AD9
		public void CleanHair()
		{
			this.CleanHairModel();
			this.CleanHairTextures();
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x000168E7 File Offset: 0x00014AE7
		public void CleanAllHead()
		{
			this.CleanHair();
			this.CleanHead();
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x000168F8 File Offset: 0x00014AF8
		public bool SetHairTextures(Bitmap colorBitmap, Bitmap alfaBitmap)
		{
			if (!this.HasSpecificHeadModel)
			{
				FifaEnvironment.UserMessages.ShowMessage(5038);
				return false;
			}
			return this.SetHairTextures(new Bitmap[] { alfaBitmap, colorBitmap });
		}

		// Token: 0x0600043C RID: 1084 RVA: 0x00016938 File Offset: 0x00014B38
		public void SavePlayer(Record r)
		{
			string text = null;
			Player.s_PlayerNames.TryGetValue(this.m_firstnameid, out text, true);
			if (text != this.m_firstname)
			{
				this.m_firstnameid = Player.s_PlayerNames.GetKey(this.m_firstname);
			}
			text = null;
			Player.s_PlayerNames.TryGetValue(this.m_lastnameid, out text, true);
			if (text != this.m_lastname)
			{
				this.m_lastnameid = Player.s_PlayerNames.GetKey(this.m_lastname);
			}
			text = null;
			Player.s_PlayerNames.TryGetValue(this.m_commonnameid, out text, true);
			if (text != this.m_commonname)
			{
				this.m_commonnameid = Player.s_PlayerNames.GetKey(this.m_commonname);
			}
			text = null;
			Player.s_PlayerNames.TryGetValue(this.m_playerjerseynameid, out text, true);
			if (text != this.m_playerjerseyname)
			{
				this.m_playerjerseynameid = Player.s_PlayerNames.GetKey(this.m_playerjerseyname);
			}
			r.IntField[FI.players_playerid] = base.Id;
			r.IntField[FI.players_firstnameid] = this.m_firstnameid;
			r.IntField[FI.players_lastnameid] = this.m_lastnameid;
			r.IntField[FI.players_commonnameid] = this.m_commonnameid;
			r.IntField[FI.players_playerjerseynameid] = this.m_playerjerseynameid;
			r.IntField[FI.players_birthdate] = FifaUtil.ConvertFromDate(this.m_birthdate);
			r.IntField[FI.players_playerjointeamdate] = FifaUtil.ConvertFromDate(this.m_playerjointeamdate);
			r.IntField[FI.players_contractvaliduntil] = this.m_contractvaliduntil;
			r.IntField[FI.players_height] = this.m_height;
			r.IntField[FI.players_weight] = this.m_weight;
			r.IntField[FI.players_preferredposition1] = this.m_preferredposition1;
			r.IntField[FI.players_preferredposition2] = this.m_preferredposition2;
			r.IntField[FI.players_preferredposition3] = this.m_preferredposition3;
			r.IntField[FI.players_preferredposition4] = this.m_preferredposition4;
			r.IntField[FI.players_preferredfoot] = this.m_preferredfoot + 1;
			r.IntField[FI.players_jerseysleevelengthcode] = this.m_jerseysleevelengthcode;
			r.IntField[FI.players_jerseystylecode] = this.m_jerseystylecode;
			r.IntField[FI.players_hasseasonaljersey] = this.m_hasseasonaljersey;
			r.IntField[FI.players_animfreekickstartposcode] = this.m_animfreekickstartposcode;
			r.IntField[FI.players_animpenaltieskickstylecode] = this.m_animpenaltieskickstylecode;
			r.IntField[FI.players_animpenaltiesmotionstylecode] = this.m_animpenaltiesmotionstylecode;
			r.IntField[FI.players_animpenaltiesstartposcode] = this.m_animpenaltiesstartposcode;
			r.IntField[FI.players_accessorycode1] = this.m_accessorycode1;
			r.IntField[FI.players_accessorycolourcode1] = this.m_accessorycolourcode1;
			r.IntField[FI.players_accessorycode2] = this.m_accessorycode2;
			r.IntField[FI.players_accessorycolourcode2] = this.m_accessorycolourcode2;
			r.IntField[FI.players_accessorycode3] = this.m_accessorycode3;
			r.IntField[FI.players_accessorycolourcode3] = this.m_accessorycolourcode3;
			r.IntField[FI.players_accessorycode4] = this.m_accessorycode4;
			r.IntField[FI.players_accessorycolourcode4] = this.m_accessorycolourcode4;
			r.IntField[FI.players_acceleration] = this.m_acceleration;
			r.IntField[FI.players_aggression] = this.m_aggression;
			r.IntField[FI.players_sprintspeed] = this.m_sprintspeed;
			r.IntField[FI.players_stamina] = this.m_stamina;
			r.IntField[FI.players_strength] = this.m_strength;
			r.IntField[FI.players_marking] = this.m_marking;
			r.IntField[FI.players_standingtackle] = this.m_standingtackle;
			r.IntField[FI.players_slidingtackle] = this.m_slidingtackle;
			r.IntField[FI.players_ballcontrol] = this.m_ballcontrol;
			r.IntField[FI.players_dribbling] = this.m_dribbling;
			r.IntField[FI.players_crossing] = this.m_crossing;
			r.IntField[FI.players_headingaccuracy] = this.m_headingaccuracy;
			r.IntField[FI.players_shortpassing] = this.m_shortpassing;
			r.IntField[FI.players_longpassing] = this.m_longpassing;
			r.IntField[FI.players_longshots] = this.m_longshots;
			r.IntField[FI.players_finishing] = this.m_finishing;
			r.IntField[FI.players_shotpower] = this.m_shotpower;
			r.IntField[FI.players_reactions] = this.m_reactions;
			r.IntField[FI.players_gkreflexes] = this.m_gkreflexes;
			r.IntField[FI.players_gkglovetypecode] = this.m_gkglovetypecode;
			r.IntField[FI.players_agility] = this.m_agility;
			r.IntField[FI.players_balance] = this.m_balance;
			r.IntField[FI.players_gkkicking] = this.m_gkkicking;
			r.IntField[FI.players_gkkickstyle] = this.m_gkkickstyle;
			r.IntField[FI.players_jumping] = this.m_jumping;
			r.IntField[FI.players_penalties] = this.m_penalties;
			r.IntField[FI.players_vision] = this.m_vision;
			r.IntField[FI.players_volleys] = this.m_volleys;
			r.IntField[FI.players_skillmoves] = this.m_skillmoves;
			r.IntField[FI.players_usercaneditname] = this.m_usercaneditname;
			r.IntField[FI.players_gkhandling] = this.m_gkhandling;
			r.IntField[FI.players_gkdiving] = this.m_gkdiving;
			r.IntField[FI.players_gkpositioning] = this.m_gkpositioning;
			r.IntField[FI.players_positioning] = this.m_positioning;
			r.IntField[FI.players_potential] = this.m_potential;
			r.IntField[FI.players_freekickaccuracy] = this.m_freekickaccuracy;
			r.IntField[FI.players_nationality] = this.m_nationality;
			r.IntField[FI.players_finishingcode1] = this.m_finishingcode1;
			r.IntField[FI.players_finishingcode2] = this.m_finishingcode2;
			r.IntField[FI.players_runningcode1] = this.m_runningcode1;
			r.IntField[FI.players_runningcode2] = this.m_runningcode2;
			r.IntField[FI.players_gksavetype] = this.m_gksavetype;
			r.IntField[FI.players_faceposercode] = this.m_faceposercode;
			r.IntField[FI.players_isretiring] = this.m_isretiring;
			r.IntField[FI.players_socklengthcode] = this.m_socklengthcode;
			r.IntField[FI.players_hashighqualityhead] = this.m_hashighqualityhead;
			r.IntField[FI.players_attackingworkrate] = this.m_attackingworkrate;
			r.IntField[FI.players_defensiveworkrate] = this.m_defensiveworkrate;
			r.IntField[FI.players_shortstyle] = (this.m_shortstyle ? 1 : 0);
			int num = 0;
			num |= (this.m_Inflexible ? 1 : 0);
			num |= (this.m_Longthrows ? 2 : 0);
			num |= (this.m_PowerfulFreeKicks ? 4 : 0);
			num |= (this.m_Diver ? 8 : 0);
			num |= (this.m_InjuryProne ? 16 : 0);
			num |= (this.m_InjuryFree ? 32 : 0);
			num |= (this.m_AvoidsWeakFoot ? 64 : 0);
			num |= (this.m_Divesintotackles ? 128 : 0);
			num |= (this.m_BeatDefensiveLine ? 256 : 0);
			num |= (this.m_Selfish ? 512 : 0);
			num |= (this.m_Leadership ? 1024 : 0);
			num |= (this.m_ArguesWithOfficials ? 2048 : 0);
			num |= (this.m_Earlycrosser ? 4096 : 0);
			num |= (this.m_FinesseShot ? 8192 : 0);
			num |= (this.m_Flair ? 16384 : 0);
			num |= (this.m_LongPasser ? 32768 : 0);
			num |= (this.m_LongShotTaker ? 65536 : 0);
			num |= (this.m_Technicaldribbler ? 131072 : 0);
			num |= (this.m_Playmaker ? 262144 : 0);
			num |= (this.m_Pushesupforcorners ? 524288 : 0);
			num |= (this.m_Puncher ? 1048576 : 0);
			num |= (this.m_GkLongThrower ? 2097152 : 0);
			num |= (this.m_PowerHeader ? 4194304 : 0);
			num |= (this.m_GkOneOnOne ? 8388608 : 0);
			num |= (this.m_GiantThrow ? 16777216 : 0);
			num |= (this.m_OutsideFootShot ? 33554432 : 0);
			num |= (this.m_CrowdFavorite ? 67108864 : 0);
			num |= (this.m_SwervePasser ? 134217728 : 0);
			num |= (this.m_SecondWind ? 268435456 : 0);
			num |= (this.m_AcrobaticClearance ? 536870912 : 0);
			num |= (r.IntField[FI.players_trait1] = num);
			int num2 = 0;
			num2 |= (this.m_FancyFeet ? 1 : 0);
			num2 |= (this.m_FancyPasses ? 2 : 0);
			num2 |= (this.m_FancyFlicks ? 4 : 0);
			num2 |= (this.m_StutterPenalty ? 8 : 0);
			num2 |= (this.m_ChipperPenalty ? 16 : 0);
			num2 |= (this.m_BycicleKick ? 32 : 0);
			num2 |= (this.m_DivingHeader ? 64 : 0);
			num2 |= (this.m_DrivenPass ? 128 : 0);
			num2 |= (this.m_GkFlatKick ? 256 : 0);
			num2 |= (this.m_HighClubIdentification ? 512 : 0);
			num2 |= (this.m_TeamPlayer ? 1024 : 0);
			r.IntField[FI.players_trait2] = num2;
			r.IntField[FI.players_bodytypecode] = this.m_bodytypecode + 1;
			r.IntField[FI.players_weakfootabilitytypecode] = this.m_weakfootabilitytypecode;
			r.IntField[FI.players_curve] = this.m_curve;
			r.IntField[FI.players_internationalrep] = this.m_internationalrep + 1;
			r.IntField[FI.players_eyecolorcode] = this.m_eyecolorcode;
			r.IntField[FI.players_eyebrowcode] = this.m_eyebrowcode;
			r.IntField[FI.players_hairtypecode] = this.m_hairtypecode;
			r.IntField[FI.players_headtypecode] = this.m_headtypecode;
			r.IntField[FI.players_headclasscode] = this.m_headclasscode;
			r.IntField[FI.players_haircolorcode] = this.m_haircolorcode;
			r.IntField[FI.players_facialhairtypecode] = this.m_facialhairtypecode;
			r.IntField[FI.players_facialhaircolorcode] = this.m_facialhaircolorcode;
			r.IntField[FI.players_sideburnscode] = this.m_sideburnscode;
			r.IntField[FI.players_skintypecode] = this.m_skintypecode;
			r.IntField[FI.players_skintonecode] = this.m_skintonecode;
			r.IntField[FI.players_shoecolorcode1] = this.m_shoecolorcode1;
			r.IntField[FI.players_shoetypecode] = this.m_shoetypecode;
			r.IntField[FI.players_overallrating] = this.m_overallrating;
			r.IntField[FI.players_interceptions] = this.m_interceptions;
			r.IntField[FI.players_shoecolorcode2] = this.m_shoecolorcode2;
			r.IntField[FI.players_jerseyfit] = (this.m_jerseyfit ? 1 : 0);
			r.IntField[FI.players_shoedesigncode] = this.m_shoedesigncode;
		}

		// Token: 0x0600043D RID: 1085 RVA: 0x00017460 File Offset: 0x00015660
		public void RandomizeAttributes(int level)
		{
			int num = Player.s_MeanLevels[level];
			int preferredposition = this.m_preferredposition1;
			int num2 = Player.c_Attributes[preferredposition, 0] * num / 100;
			num2 = FifaUtil.Limit(num2, 11, 90);
			int num3 = Player.c_Attributes[preferredposition, 1] * num / 100;
			num3 = FifaUtil.Limit(num3, 11, 90);
			int num4 = Player.c_Attributes[preferredposition, 2] * num / 100;
			num4 = FifaUtil.Limit(num4, 11, 90);
			int num5 = Player.c_Attributes[preferredposition, 3] * num / 100;
			num5 = FifaUtil.Limit(num5, 11, 90);
			this.m_gkreflexes = Player.m_Randomizer.Next(num2 - 10, num2 + 10);
			this.m_gkdiving = Player.m_Randomizer.Next(num2 - 10, num2 + 10);
			this.m_gkpositioning = Player.m_Randomizer.Next(num2 - 10, num2 + 10);
			this.m_gkhandling = Player.m_Randomizer.Next(num2 - 10, num2 + 10);
			this.m_gkkicking = Player.m_Randomizer.Next(num2 - 10, num2 + 10);
			int num6 = 20 + level * 8 + (this.m_height - 175) * 2;
			if (num6 > 90)
			{
				num6 = 90;
			}
			if (num6 < 20)
			{
				num6 = 20;
			}
			this.m_headingaccuracy = Player.m_Randomizer.Next(num6 - 10, num6 + 10);
			this.m_marking = Player.m_Randomizer.Next(num3 - 7, num3 + 7);
			this.m_interceptions = Player.m_Randomizer.Next(num3 - 7, num3 + 7);
			this.m_standingtackle = Player.m_Randomizer.Next(num3 - 7, num3 + 7);
			this.m_slidingtackle = Player.m_Randomizer.Next(num3 - 7, num3 + 7);
			this.m_aggression = Player.m_Randomizer.Next(num3 - 10, num3 + 10);
			this.m_shortpassing = Player.m_Randomizer.Next(num4 - 7, num4 + 7);
			this.m_longpassing = Player.m_Randomizer.Next(num4 - 7, num4 + 7);
			this.m_crossing = Player.m_Randomizer.Next(num4 - 7, num4 + 7);
			this.m_ballcontrol = Player.m_Randomizer.Next(num4 - 7, num4 + 7);
			this.m_vision = Player.m_Randomizer.Next(num4 - 10, num4 + 10);
			this.m_weakfootabilitytypecode = Player.m_Randomizer.Next(1, 6);
			this.m_curve = Player.m_Randomizer.Next(num4 - 10, num4 + 10);
			this.m_finishing = Player.m_Randomizer.Next(num5 - 7, num5 + 7);
			this.m_shotpower = Player.m_Randomizer.Next(num5 - 10, num5 + 10);
			this.m_longshots = Player.m_Randomizer.Next(num5 - 10, num5 + 10);
			this.m_dribbling = Player.m_Randomizer.Next(num5 - 7, num5 + 7);
			this.m_volleys = Player.m_Randomizer.Next(num5 - 10, num5 + 10);
			this.m_penalties = Player.m_Randomizer.Next(num5 - 10, num5 + 10);
			this.m_positioning = Player.m_Randomizer.Next(num5 - 10, num5 + 10);
			int num7 = 37 + level * 8;
			this.m_acceleration = Player.m_Randomizer.Next(num7 - 10, num7 + 10);
			this.m_sprintspeed = Player.m_Randomizer.Next(num7 - 10, num7 + 10);
			this.m_stamina = Player.m_Randomizer.Next(num7 - 10, num7 + 10);
			this.m_strength = Player.m_Randomizer.Next(num7 - 10, num7 + 10);
			this.m_potential = Player.m_Randomizer.Next(num7 - 10, num7 + 10);
			this.m_freekickaccuracy = Player.m_Randomizer.Next(num7 - 10, num7 + 10);
			this.m_reactions = Player.m_Randomizer.Next(num7 - 10, num7 + 10);
			this.m_agility = Player.m_Randomizer.Next(num7 - 10, num7 + 10);
			this.m_balance = Player.m_Randomizer.Next(num7 - 10, num7 + 10);
			this.m_jumping = Player.m_Randomizer.Next(num7 - 10, num7 + 10);
			this.m_InjuryFree = Player.m_Randomizer.Next(0, 100) <= 5;
			if (this.m_InjuryFree)
			{
				this.m_InjuryProne = false;
			}
			else
			{
				this.m_InjuryProne = Player.m_Randomizer.Next(0, 100) <= 5;
			}
			if (level >= 4)
			{
				this.m_Leadership = Player.m_Randomizer.Next(0, 100) <= 5;
			}
			this.m_ArguesWithOfficials = Player.m_Randomizer.Next(0, 100) <= 5;
			this.m_AvoidsWeakFoot = Player.m_Randomizer.Next(0, 100) <= 5;
			if (this.m_preferredposition1 == 0)
			{
				this.m_Pushesupforcorners = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_Puncher = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_GkLongThrower = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_gksavetype = ((Player.m_Randomizer.Next(0, 100) <= 20) ? 1 : 0);
				this.m_GkOneOnOne = Player.m_Randomizer.Next(0, 100) <= 5;
			}
			else
			{
				if (num5 >= 75)
				{
					this.m_Selfish = Player.m_Randomizer.Next(0, 100) <= 5;
				}
				if (num4 >= 70)
				{
					this.m_Playmaker = Player.m_Randomizer.Next(0, 100) <= 5;
				}
				else
				{
					this.m_Playmaker = false;
				}
				this.m_Diver = Player.m_Randomizer.Next(0, 100) <= 5;
				if (preferredposition < 12)
				{
					this.m_Divesintotackles = Player.m_Randomizer.Next(0, 100) <= 5;
				}
				this.m_LongShotTaker = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_Earlycrosser = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_LongPasser = Player.m_Randomizer.Next(0, 100) <= 5;
				this.m_Longthrows = Player.m_Randomizer.Next(0, 100) <= 2;
				this.m_Inflexible = Player.m_Randomizer.Next(0, 100) <= 2;
				if (this.m_dribbling > 75)
				{
					this.m_Technicaldribbler = Player.m_Randomizer.Next(0, 100) <= this.m_dribbling - 70;
				}
				if (this.m_curve > 75)
				{
					this.m_OutsideFootShot = Player.m_Randomizer.Next(0, 100) <= this.m_curve - 70;
				}
				if (num4 >= 80 || num5 >= 85)
				{
					this.m_Flair = Player.m_Randomizer.Next(0, 100) <= 10;
					this.m_FinesseShot = Player.m_Randomizer.Next(0, 100) <= 10;
				}
				this.m_PowerfulFreeKicks = Player.m_Randomizer.Next(0, 100) <= 5;
				if ((double)this.m_height > 1.85)
				{
					this.m_PowerHeader = Player.m_Randomizer.Next(0, 100) <= this.m_height - 180;
				}
				this.m_BeatDefensiveLine = Player.m_Randomizer.Next(0, 100) <= 5;
			}
			this.m_animfreekickstartposcode = Player.m_Randomizer.Next(0, 10);
			this.m_animpenaltieskickstylecode = Player.m_Randomizer.Next(0, 3);
			this.m_animpenaltiesmotionstylecode = Player.m_Randomizer.Next(0, 7);
			this.m_animpenaltiesstartposcode = Player.m_Randomizer.Next(0, 9);
			int num8 = level - 1;
			this.m_internationalrep = ((num8 < 1) ? 1 : num8);
			this.m_overallrating = this.GetAverageRoleAttribute();
		}

		// Token: 0x0600043E RID: 1086 RVA: 0x00017C0C File Offset: 0x00015E0C
		public void RandomizeIdentity()
		{
			this.m_height = Player.m_Randomizer.Next(165, 196);
			this.m_bodytypecode = Player.m_Randomizer.Next(0, 3);
			this.m_weight = this.m_height - 110 + this.m_bodytypecode * 5 + Player.m_Randomizer.Next(0, 5);
			this.m_preferredfoot = ((Player.m_Randomizer.Next(0, 100) < 10) ? 1 : 0);
			this.m_weakfootabilitytypecode = Player.m_Randomizer.Next(1, 6);
			this.m_jerseysleevelengthcode = ((Player.m_Randomizer.Next(0, 100) < 5) ? 1 : 0);
			this.m_jerseystylecode = ((Player.m_Randomizer.Next(0, 100) < 10) ? 1 : 0);
			this.m_hasseasonaljersey = ((Player.m_Randomizer.Next(0, 100) < 40) ? 1 : 0);
			int num = Player.m_Randomizer.Next(1, 7665);
			this.m_birthdate = new DateTime(1974, 1, 1) + new TimeSpan(num, 0, 0, 0);
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00017D40 File Offset: 0x00015F40
		public void RandomizeCaucasianAppearance()
		{
			int[] array = new int[] { 1, 0, 1, 0, 1, 3, 2, 4, 3, 3 };
			if (Player.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Player.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Player.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			this.m_hairtypecode = Player.m_Randomizer.Next(0, 109);
			this.m_haircolorcode = Player.m_Randomizer.Next(0, 8);
			this.m_sideburnscode = Player.m_Randomizer.Next(0, 2);
			this.m_skintonecode = Player.m_Randomizer.Next(1, 5);
			if (this.m_skintonecode == 1)
			{
				this.m_skintonecode = 2;
			}
			if (this.m_skintonecode == 3)
			{
				this.m_skintonecode = 2;
			}
			this.m_skintypecode = Player.m_Randomizer.Next(0, 3);
			this.m_eyecolorcode = Player.m_Randomizer.Next(1, 8);
			this.m_facialhairtypecode = Player.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = array[this.m_haircolorcode];
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00017EA0 File Offset: 0x000160A0
		public void RandomizeAsiaticAppearance()
		{
			int[] array = new int[] { 1, 0, 1, 0, 1, 3, 2, 4, 3, 3 };
			if (Player.m_Randomizer.Next(1, 11) <= 9)
			{
				this.m_headtypecode = GenericHead.c_AsiaticModels[Player.m_Randomizer.Next(0, GenericHead.c_AsiaticModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Player.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			this.m_hairtypecode = Player.m_Randomizer.Next(0, 109);
			this.m_haircolorcode = Player.m_Randomizer.Next(1, 6);
			if (this.m_haircolorcode == 3)
			{
				this.m_haircolorcode = 1;
			}
			this.m_sideburnscode = Player.m_Randomizer.Next(0, 2);
			this.m_skintonecode = Player.m_Randomizer.Next(3, 7);
			if (this.m_skintonecode == 3)
			{
				this.m_skintonecode = 4;
			}
			this.m_skintypecode = Player.m_Randomizer.Next(0, 3);
			this.m_eyecolorcode = Player.m_Randomizer.Next(3, 8);
			this.m_facialhairtypecode = Player.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = array[this.m_haircolorcode];
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00018000 File Offset: 0x00016200
		public void RandomizeAfricanAppearance()
		{
			int[] array = new int[] { 1, 0, 1, 0, 1, 3, 2, 4, 3, 3 };
			if (Player.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_AfricanModels[Player.m_Randomizer.Next(0, GenericHead.c_AfricanModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Player.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			this.m_hairtypecode = Player.m_Randomizer.Next(0, 109);
			this.m_haircolorcode = 1;
			this.m_sideburnscode = Player.m_Randomizer.Next(0, 2);
			this.m_skintonecode = Player.m_Randomizer.Next(6, 11);
			if (this.m_skintonecode == 7)
			{
				this.m_skintonecode = 8;
			}
			this.m_skintypecode = Player.m_Randomizer.Next(0, 3);
			this.m_eyecolorcode = Player.m_Randomizer.Next(3, 5);
			this.m_facialhairtypecode = Player.m_Randomizer.Next(0, 5);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = array[this.m_haircolorcode];
		}

		// Token: 0x06000442 RID: 1090 RVA: 0x00018148 File Offset: 0x00016348
		public void RandomizeLatinAppearance()
		{
			int[] array = new int[] { 1, 0, 1, 0, 1, 3, 2, 4, 3, 3 };
			if (Player.m_Randomizer.Next(1, 11) <= 7)
			{
				this.m_headtypecode = GenericHead.c_LatinModels[Player.m_Randomizer.Next(0, GenericHead.c_LatinModels.Length)];
			}
			else
			{
				this.m_headtypecode = GenericHead.c_CaucasicModels[Player.m_Randomizer.Next(0, GenericHead.c_CaucasicModels.Length)];
			}
			this.m_hairtypecode = Player.m_Randomizer.Next(0, 112);
			this.m_haircolorcode = 1;
			this.m_sideburnscode = Player.m_Randomizer.Next(0, 2);
			this.m_skintonecode = Player.m_Randomizer.Next(4, 7);
			this.m_skintypecode = Player.m_Randomizer.Next(0, 3);
			this.m_eyecolorcode = Player.m_Randomizer.Next(3, 8);
			this.m_facialhairtypecode = Player.m_Randomizer.Next(0, 10);
			if (this.m_facialhairtypecode == 2 || this.m_facialhairtypecode > 7)
			{
				this.m_facialhairtypecode = 0;
			}
			this.m_facialhaircolorcode = array[this.m_haircolorcode];
		}

		// Token: 0x06000443 RID: 1091 RVA: 0x00018254 File Offset: 0x00016454
		public int ComputeMeanAttributes(int type)
		{
			switch (type)
			{
			case 0:
				return (this.m_gkpositioning + this.m_gkdiving + this.m_gkreflexes + this.m_gkhandling + this.m_gkkicking) / 5;
			case 1:
				return (this.m_aggression + this.m_standingtackle + this.m_slidingtackle + this.m_marking + this.m_interceptions) / 5;
			case 2:
				return (this.m_crossing + this.m_shortpassing + this.m_longpassing + this.m_ballcontrol + this.m_vision + this.m_curve) / 6;
			case 3:
				return (this.m_finishing + this.m_shotpower + this.m_longshots + this.m_dribbling + this.m_headingaccuracy + this.m_volleys) / 6;
			case 4:
				return (this.m_acceleration + this.m_sprintspeed + this.m_stamina + this.m_strength + this.m_agility + this.m_jumping + this.m_reactions + this.m_balance) / 8;
			case 5:
				return (this.m_potential + this.m_positioning) / 2;
			case 6:
				return (this.m_freekickaccuracy + this.m_penalties) / 2;
			default:
				return 0;
			}
		}

		// Token: 0x06000444 RID: 1092 RVA: 0x00018388 File Offset: 0x00016588
		public int GetAverageRoleAttribute()
		{
			int num;
			switch (this.m_preferredposition1)
			{
			case 0:
				num = (this.m_gkreflexes * 22 + this.m_gkhandling * 22 + this.m_gkdiving * 24 + this.m_gkpositioning * 22 + this.m_gkkicking * 4 + this.m_reactions * 6 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 1:
				num = (this.m_interceptions * 20 + this.m_standingtackle * 14 + this.m_marking * 12 + this.m_slidingtackle * 12 + this.m_headingaccuracy * 8 + this.m_ballcontrol * 7 + this.m_shortpassing * 6 + this.m_reactions * 6 + this.m_vision * 6 + this.m_longpassing * 5 + this.m_aggression * 4 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 2:
			case 8:
				num = (this.m_standingtackle * 11 + this.m_slidingtackle * 10 + this.m_crossing * 10 + this.m_shortpassing * 10 + this.m_ballcontrol * 10 + this.m_interceptions * 10 + this.m_marking * 9 + this.m_stamina * 8 + this.m_reactions * 8 + this.m_dribbling * 7 + this.m_sprintspeed * 4 + this.m_agility * 3 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 3:
			case 7:
				num = (this.m_slidingtackle * 13 + this.m_standingtackle * 12 + this.m_interceptions * 12 + this.m_marking * 10 + this.m_stamina * 8 + this.m_reactions * 8 + this.m_crossing * 7 + this.m_headingaccuracy * 7 + this.m_ballcontrol * 7 + this.m_shortpassing * 6 + this.m_sprintspeed * 5 + this.m_aggression * 5 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 4:
			case 5:
			case 6:
				num = (this.m_marking * 15 + this.m_standingtackle * 15 + this.m_slidingtackle * 15 + this.m_headingaccuracy * 10 + this.m_strength * 10 + this.m_aggression * 8 + this.m_interceptions * 8 + this.m_shortpassing * 5 + this.m_ballcontrol * 5 + this.m_reactions * 5 + this.m_jumping * 4 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 9:
			case 10:
			case 11:
				num = (this.m_shortpassing * 13 + this.m_interceptions * 13 + this.m_longpassing * 11 + this.m_marking * 10 + this.m_standingtackle * 10 + this.m_ballcontrol * 9 + this.m_reactions * 9 + this.m_vision * 8 + this.m_stamina * 6 + this.m_strength * 6 + this.m_aggression * 5 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 12:
			case 16:
				num = (this.m_crossing * 14 + this.m_dribbling * 14 + this.m_ballcontrol * 12 + this.m_shortpassing * 12 + this.m_longpassing * 8 + this.m_vision * 8 + this.m_reactions * 7 + this.m_positioning * 7 + this.m_acceleration * 5 + this.m_sprintspeed * 5 + this.m_stamina * 5 + this.m_agility * 3 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 13:
			case 14:
			case 15:
				num = (this.m_shortpassing * 15 + this.m_longpassing * 13 + this.m_vision * 12 + this.m_ballcontrol * 10 + this.m_dribbling * 9 + this.m_reactions * 8 + this.m_interceptions * 8 + this.m_positioning * 8 + this.m_standingtackle * 6 + this.m_stamina * 6 + this.m_longshots * 5 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 17:
			case 18:
			case 19:
				num = (this.m_shortpassing * 16 + this.m_vision * 16 + this.m_ballcontrol * 13 + this.m_positioning * 12 + this.m_dribbling * 11 + this.m_reactions * 8 + this.m_longshots * 6 + this.m_finishing * 5 + this.m_shotpower * 5 + this.m_acceleration * 4 + this.m_agility * 4 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 20:
			case 21:
			case 22:
				num = (this.m_finishing * 12 + this.m_positioning * 12 + this.m_dribbling * 11 + this.m_ballcontrol * 11 + this.m_shotpower * 10 + this.m_longshots * 10 + this.m_reactions * 10 + this.m_shortpassing * 6 + this.m_headingaccuracy * 5 + this.m_vision * 5 + this.m_acceleration * 4 + this.m_sprintspeed * 4 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 23:
			case 27:
				num = (this.m_crossing * 16 + this.m_dribbling * 16 + this.m_ballcontrol * 13 + this.m_shortpassing * 10 + this.m_positioning * 9 + this.m_acceleration * 6 + this.m_sprintspeed * 6 + this.m_reactions * 6 + this.m_agility * 5 + this.m_vision * 5 + this.m_finishing * 4 + this.m_longshots * 4 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			case 24:
			case 25:
			case 26:
				num = (this.m_finishing * 20 + this.m_positioning * 12 + this.m_headingaccuracy * 10 + this.m_shotpower * 10 + this.m_reactions * 10 + this.m_dribbling * 8 + this.m_ballcontrol * 8 + this.m_volleys * 5 + this.m_longshots * 5 + this.m_acceleration * 5 + this.m_sprintspeed * 4 + this.m_strength * 3 + 50) / 100;
				if (num > 99)
				{
					num = 99;
				}
				break;
			default:
				return 0;
			}
			switch (this.m_internationalrep + 1)
			{
			case 3:
				if (num > 50)
				{
					num++;
				}
				break;
			case 4:
				if (num > 68)
				{
					num += 2;
				}
				else if (num > 34)
				{
					num++;
				}
				break;
			case 5:
				if (num > 77)
				{
					num += 3;
				}
				else if (num > 51)
				{
					num += 2;
				}
				else if (num > 25)
				{
					num++;
				}
				break;
			}
			return num;
		}

		// Token: 0x06000445 RID: 1093 RVA: 0x00018A78 File Offset: 0x00016C78
		public int GetRolePerformance(ERole requestedRole)
		{
			int preferredposition = this.m_preferredposition1;
			int averageRoleAttribute = this.GetAverageRoleAttribute();
			return averageRoleAttribute * Player.c_RolesMap[preferredposition, (int)requestedRole] / 100;
		}

		// Token: 0x06000446 RID: 1094 RVA: 0x00018AA8 File Offset: 0x00016CA8
		public ERole ChooseRole(ERole[] availableRoles, int nRoles)
		{
			ERole erole = ERole.Tribune;
			int num = -1;
			for (int i = 0; i < nRoles; i++)
			{
				int rolePerformance = this.GetRolePerformance(availableRoles[i]);
				if (rolePerformance > num)
				{
					erole = availableRoles[i];
					num = rolePerformance;
				}
			}
			if ((this.m_preferredposition1 == 0 && erole != ERole.Goalkeeper) || (this.m_preferredposition1 != 0 && erole == ERole.Goalkeeper))
			{
				return ERole.Tribune;
			}
			return erole;
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x00018AF4 File Offset: 0x00016CF4
		public string GetRoleAcronym()
		{
			if (FifaEnvironment.Language != null)
			{
				return FifaEnvironment.Language.GetRoleShortString(this.m_preferredposition1);
			}
			return string.Empty;
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x00018B13 File Offset: 0x00016D13
		public string GetRoleString()
		{
			if (FifaEnvironment.Language != null)
			{
				return FifaEnvironment.Language.GetRoleLongString(this.m_preferredposition1);
			}
			return string.Empty;
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x00018B34 File Offset: 0x00016D34
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

		// Token: 0x0600044A RID: 1098 RVA: 0x00018BA4 File Offset: 0x00016DA4
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

		// Token: 0x0600044B RID: 1099 RVA: 0x00018C44 File Offset: 0x00016E44
		public void ChangeSkills(int delta)
		{
			this.m_acceleration = this.ChangeSkill(this.m_acceleration, delta);
			this.m_aggression = this.ChangeSkill(this.m_aggression, delta);
			this.m_agility = this.ChangeSkill(this.m_agility, delta);
			this.m_balance = this.ChangeSkill(this.m_balance, delta);
			this.m_ballcontrol = this.ChangeSkill(this.m_ballcontrol, delta);
			this.m_crossing = this.ChangeSkill(this.m_crossing, delta);
			this.m_curve = this.ChangeSkill(this.m_curve, delta);
			this.m_dribbling = this.ChangeSkill(this.m_dribbling, delta);
			this.m_finishing = this.ChangeSkill(this.m_finishing, delta);
			this.m_freekickaccuracy = this.ChangeSkill(this.m_freekickaccuracy, delta);
			this.m_gkdiving = this.ChangeSkill(this.m_gkdiving, delta);
			this.m_gkhandling = this.ChangeSkill(this.m_gkhandling, delta);
			this.m_gkkicking = this.ChangeSkill(this.m_gkkicking, delta);
			this.m_gkpositioning = this.ChangeSkill(this.m_gkpositioning, delta);
			this.m_gkreflexes = this.ChangeSkill(this.m_gkreflexes, delta);
			this.m_interceptions = this.ChangeSkill(this.m_interceptions, delta);
			this.m_jumping = this.ChangeSkill(this.m_jumping, delta);
			this.m_longpassing = this.ChangeSkill(this.m_longpassing, delta);
			this.m_longshots = this.ChangeSkill(this.m_longshots, delta);
			this.m_marking = this.ChangeSkill(this.m_marking, delta);
			this.m_overallrating = this.ChangeSkill(this.m_overallrating, delta);
			this.m_penalties = this.ChangeSkill(this.m_penalties, delta);
			this.m_positioning = this.ChangeSkill(this.m_positioning, delta);
			this.m_potential = this.ChangeSkill(this.m_potential, delta);
			this.m_reactions = this.ChangeSkill(this.m_reactions, delta);
			this.m_shortpassing = this.ChangeSkill(this.m_shortpassing, delta);
			this.m_shotpower = this.ChangeSkill(this.m_shotpower, delta);
			this.m_sprintspeed = this.ChangeSkill(this.m_sprintspeed, delta);
			this.m_stamina = this.ChangeSkill(this.m_stamina, delta);
			this.m_standingtackle = this.ChangeSkill(this.m_standingtackle, delta);
			this.m_strength = this.ChangeSkill(this.m_strength, delta);
			this.m_vision = this.ChangeSkill(this.m_vision, delta);
			this.m_volleys = this.ChangeSkill(this.m_volleys, delta);
		}

		// Token: 0x0600044C RID: 1100 RVA: 0x00018EC4 File Offset: 0x000170C4
		private int ChangeSkill(int skillValue, int delta)
		{
			if (skillValue + delta < 10)
			{
				return 10;
			}
			if (skillValue + delta > 99)
			{
				return 99;
			}
			return skillValue + delta;
		}

		// Token: 0x04000140 RID: 320
		private static int[,] c_RolesMap = new int[,]
		{
			{
				100, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0, 0, 0,
				0, 0, 0, 0, 0, 0, 0, 0
			},
			{
				0, 100, 30, 85, 90, 95, 90, 85, 80, 50,
				50, 50, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 50, 100, 80, 70, 50, 50, 50, 75, 5,
				5, 5, 50, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 80, 50, 100, 95, 90, 85, 80, 50, 50,
				50, 30, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 85, 40, 95, 100, 95, 90, 85, 50, 50,
				50, 30, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 90, 30, 90, 95, 100, 95, 90, 30, 50,
				50, 50, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 85, 20, 85, 90, 95, 100, 95, 60, 30,
				30, 50, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 80, 20, 80, 85, 90, 95, 100, 70, 30,
				30, 50, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 50, 75, 70, 50, 50, 70, 80, 100, 5,
				5, 5, 5, 5, 5, 5, 50, 5, 5, 5,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 20, 15, 10, 5, 5, 5, 5, 100,
				90, 85, 90, 85, 80, 75, 70, 25, 25, 25,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 10, 15, 20, 10, 5, 5, 5, 95,
				100, 95, 80, 85, 90, 85, 80, 25, 25, 25,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 10, 15, 20, 15, 10, 85,
				90, 100, 70, 75, 80, 95, 90, 25, 25, 25,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 85,
				70, 60, 100, 95, 90, 85, 80, 90, 70, 70,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 90,
				70, 60, 95, 100, 95, 90, 85, 85, 80, 75,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 80,
				90, 80, 90, 95, 100, 95, 90, 80, 90, 80,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 60,
				80, 90, 85, 90, 95, 100, 95, 75, 80, 85,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 40, 5, 5, 5, 5, 30, 70, 60,
				70, 80, 80, 85, 90, 95, 100, 70, 70, 90,
				5, 5, 5, 5, 5, 5, 5, 5
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 25,
				25, 25, 75, 80, 75, 70, 65, 100, 95, 90,
				90, 85, 80, 60, 20, 20, 20, 20
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 25,
				25, 25, 70, 75, 80, 75, 70, 95, 100, 95,
				85, 90, 85, 20, 20, 30, 20, 20
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 25,
				25, 25, 65, 70, 75, 80, 75, 90, 95, 100,
				80, 85, 90, 20, 20, 20, 20, 60
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 55, 55, 50,
				100, 95, 90, 70, 100, 95, 90, 55
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 50, 60, 50,
				95, 100, 95, 50, 95, 100, 95, 50
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 50, 55, 55,
				90, 95, 100, 55, 90, 95, 100, 70
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 50, 10, 5, 10, 15, 60, 40, 40,
				60, 50, 50, 100, 90, 80, 85, 95
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 40, 40, 40,
				50, 50, 50, 70, 100, 95, 95, 70
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 40, 40, 40,
				50, 50, 50, 60, 95, 100, 95, 60
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 15, 40, 40, 40,
				50, 50, 50, 70, 95, 95, 100, 70
			},
			{
				0, 5, 5, 5, 5, 5, 5, 5, 5, 5,
				5, 5, 15, 10, 5, 10, 50, 40, 40, 60,
				50, 50, 60, 95, 85, 80, 90, 100
			}
		};

		// Token: 0x04000141 RID: 321
		private static int[] c_GenericModels = new int[]
		{
			0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
			10, 11, 12, 13, 14, 15, 16, 17, 18, 19,
			20, 21, 22, 23, 24, 25, 2000, 2001, 2002, 2003,
			2004, 2005, 2006, 2007, 2008, 2009, 2010, 2012, 2013, 2014,
			3500, 3501, 3502, 3503, 3504, 3505, 4000, 4001, 4002, 4003,
			500, 501, 502, 503, 504, 505, 506, 507, 508, 509,
			510, 511, 512, 513, 514, 515, 516, 517, 518, 519,
			520, 521, 522, 1500, 1501, 1502, 1503, 1504, 1505, 1506,
			1507, 1508, 1509, 1510, 1511, 1512, 1513, 1514, 1515, 1516,
			1517, 1518, 1519, 1520, 1521, 1522, 1523, 1524, 1525, 1526,
			1527, 1528, 2500, 2501, 2502, 2503, 2504, 2505, 2506, 2507,
			2508, 2509, 2510, 2511, 2512, 1000, 1001, 1002, 1003, 1004,
			1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014,
			1015, 1016, 1017, 1018, 3000, 3001, 3002, 3003, 3004, 3005,
			4500, 4501, 4502, 5000, 5001, 5002, 5003
		};

		// Token: 0x04000142 RID: 322
		private static int[,] c_Attributes = new int[,]
		{
			{ 99, 20, 20, 20 },
			{ 20, 99, 70, 50 },
			{ 20, 90, 70, 50 },
			{ 20, 95, 75, 50 },
			{ 20, 99, 75, 50 },
			{ 20, 99, 75, 50 },
			{ 20, 99, 75, 50 },
			{ 20, 95, 75, 50 },
			{ 20, 90, 70, 50 },
			{ 20, 90, 90, 70 },
			{ 20, 90, 90, 70 },
			{ 20, 90, 90, 70 },
			{ 20, 75, 99, 85 },
			{ 20, 75, 99, 85 },
			{ 20, 75, 99, 85 },
			{ 20, 75, 99, 85 },
			{ 20, 75, 99, 85 },
			{ 20, 50, 99, 90 },
			{ 20, 50, 99, 90 },
			{ 20, 50, 99, 90 },
			{ 20, 50, 80, 99 },
			{ 20, 50, 80, 99 },
			{ 20, 50, 80, 99 },
			{ 20, 70, 90, 95 },
			{ 20, 50, 80, 99 },
			{ 20, 50, 80, 99 },
			{ 20, 50, 80, 99 },
			{ 20, 70, 90, 95 }
		};

		// Token: 0x04000143 RID: 323
		public static Color[] s_GenericColors = new Color[]
		{
			Color.FromArgb(180, 156, 114),
			Color.FromArgb(20, 20, 20),
			Color.FromArgb(135, 126, 100),
			Color.FromArgb(42, 35, 24),
			Color.FromArgb(168, 160, 128),
			Color.FromArgb(111, 91, 69),
			Color.FromArgb(75, 63, 49),
			Color.FromArgb(120, 85, 58),
			Color.FromArgb(160, 162, 155),
			Color.FromArgb(110, 115, 121),
			Color.FromArgb(77, 115, 70),
			Color.FromArgb(51, 80, 126)
		};

		// Token: 0x04000144 RID: 324
		private static Random m_Randomizer = new Random();

		// Token: 0x04000145 RID: 325
		private static PlayerNames s_PlayerNames = null;

		// Token: 0x04000146 RID: 326
		private Bitmap m_EyesTextureBitmap;

		// Token: 0x04000147 RID: 327
		private Bitmap m_FaceTextureBitmap;

		// Token: 0x04000148 RID: 328
		private Bitmap m_HairColorTextureBitmap;

		// Token: 0x04000149 RID: 329
		private Bitmap m_HairAlfaTextureBitmap;

		// Token: 0x0400014A RID: 330
		private Rx3File m_HeadModelFile;

		// Token: 0x0400014B RID: 331
		private Rx3File m_HairModelFile;

		// Token: 0x0400014C RID: 332
		public static Model3D s_Model3DHead = null;

		// Token: 0x0400014D RID: 333
		public static Model3D s_Model3DEyes = null;

		// Token: 0x0400014E RID: 334
		public static Model3D s_Model3DHairPart4 = null;

		// Token: 0x0400014F RID: 335
		public static Model3D s_Model3DHairPart5 = null;

		// Token: 0x04000150 RID: 336
		public bool m_HasSpecificPhoto;

		// Token: 0x04000151 RID: 337
		public TeamList m_PlayingForTeams = new TeamList();

		// Token: 0x04000152 RID: 338
		public int m_assetid;

		// Token: 0x04000153 RID: 339
		private string m_firstname;

		// Token: 0x04000154 RID: 340
		private string m_lastname;

		// Token: 0x04000155 RID: 341
		private int m_lastnameKey;

		// Token: 0x04000156 RID: 342
		public string m_commonname;

		// Token: 0x04000157 RID: 343
		public string m_playerjerseyname;

		// Token: 0x04000158 RID: 344
		private int m_firstnameid;

		// Token: 0x04000159 RID: 345
		private int m_lastnameid;

		// Token: 0x0400015A RID: 346
		private int m_commonnameid;

		// Token: 0x0400015B RID: 347
		private int m_playerjerseynameid;

		// Token: 0x0400015C RID: 348
		private DateTime m_birthdate;

		// Token: 0x0400015D RID: 349
		public DateTime m_playerjointeamdate;

		// Token: 0x0400015E RID: 350
		private int m_contractvaliduntil;

		// Token: 0x0400015F RID: 351
		private int m_height;

		// Token: 0x04000160 RID: 352
		private int m_weight;

		// Token: 0x04000161 RID: 353
		private int m_nationality;

		// Token: 0x04000162 RID: 354
		private Country m_Country;

		// Token: 0x04000163 RID: 355
		private int m_eyecolorcode;

		// Token: 0x04000164 RID: 356
		private int m_eyebrowcode;

		// Token: 0x04000165 RID: 357
		private int m_bodytypecode;

		// Token: 0x04000166 RID: 358
		private int m_hairtypecode;

		// Token: 0x04000167 RID: 359
		private int m_headtypecode;

		// Token: 0x04000168 RID: 360
		private int m_headclasscode;

		// Token: 0x04000169 RID: 361
		private int m_haircolorcode;

		// Token: 0x0400016A RID: 362
		private int m_facialhairtypecode;

		// Token: 0x0400016B RID: 363
		private int m_facialhaircolorcode;

		// Token: 0x0400016C RID: 364
		private int m_sideburnscode;

		// Token: 0x0400016D RID: 365
		private int m_skintypecode;

		// Token: 0x0400016E RID: 366
		private int m_skintonecode;

		// Token: 0x0400016F RID: 367
		private int m_jerseysleevelengthcode;

		// Token: 0x04000170 RID: 368
		private int m_jerseystylecode;

		// Token: 0x04000171 RID: 369
		private int m_hasseasonaljersey;

		// Token: 0x04000172 RID: 370
		private int m_animfreekickstartposcode;

		// Token: 0x04000173 RID: 371
		private int m_animpenaltieskickstylecode;

		// Token: 0x04000174 RID: 372
		private int m_animpenaltiesmotionstylecode;

		// Token: 0x04000175 RID: 373
		private int m_animpenaltiesstartposcode;

		// Token: 0x04000176 RID: 374
		private int m_accessorycode1;

		// Token: 0x04000177 RID: 375
		private int m_accessorycolourcode1;

		// Token: 0x04000178 RID: 376
		private int m_accessorycode2;

		// Token: 0x04000179 RID: 377
		private int m_accessorycolourcode2;

		// Token: 0x0400017A RID: 378
		private int m_accessorycode3;

		// Token: 0x0400017B RID: 379
		private int m_accessorycolourcode3;

		// Token: 0x0400017C RID: 380
		private int m_accessorycode4;

		// Token: 0x0400017D RID: 381
		private int m_accessorycolourcode4;

		// Token: 0x0400017E RID: 382
		private int m_shoetypecode;

		// Token: 0x0400017F RID: 383
		private int m_shoedesigncode;

		// Token: 0x04000180 RID: 384
		private int m_shoecolorcode1;

		// Token: 0x04000181 RID: 385
		private int m_shoecolorcode2;

		// Token: 0x04000182 RID: 386
		private int m_preferredposition1;

		// Token: 0x04000183 RID: 387
		private int m_preferredposition2;

		// Token: 0x04000184 RID: 388
		private int m_preferredposition3;

		// Token: 0x04000185 RID: 389
		private int m_preferredposition4;

		// Token: 0x04000186 RID: 390
		private int m_preferredfoot;

		// Token: 0x04000187 RID: 391
		private int m_weakfootabilitytypecode;

		// Token: 0x04000188 RID: 392
		private int m_acceleration;

		// Token: 0x04000189 RID: 393
		private int m_aggression;

		// Token: 0x0400018A RID: 394
		private int m_gkglovetypecode;

		// Token: 0x0400018B RID: 395
		private int m_agility;

		// Token: 0x0400018C RID: 396
		private int m_balance;

		// Token: 0x0400018D RID: 397
		private int m_gkkicking;

		// Token: 0x0400018E RID: 398
		private int m_gkkickstyle;

		// Token: 0x0400018F RID: 399
		private int m_jumping;

		// Token: 0x04000190 RID: 400
		private int m_penalties;

		// Token: 0x04000191 RID: 401
		private int m_vision;

		// Token: 0x04000192 RID: 402
		private int m_volleys;

		// Token: 0x04000193 RID: 403
		private int m_skillmoves;

		// Token: 0x04000194 RID: 404
		private int m_usercaneditname;

		// Token: 0x04000195 RID: 405
		private int m_sprintspeed;

		// Token: 0x04000196 RID: 406
		private int m_stamina;

		// Token: 0x04000197 RID: 407
		private int m_strength;

		// Token: 0x04000198 RID: 408
		private int m_marking;

		// Token: 0x04000199 RID: 409
		private int m_standingtackle;

		// Token: 0x0400019A RID: 410
		private int m_slidingtackle;

		// Token: 0x0400019B RID: 411
		private int m_ballcontrol;

		// Token: 0x0400019C RID: 412
		private int m_dribbling;

		// Token: 0x0400019D RID: 413
		private int m_crossing;

		// Token: 0x0400019E RID: 414
		private int m_headingaccuracy;

		// Token: 0x0400019F RID: 415
		private int m_shortpassing;

		// Token: 0x040001A0 RID: 416
		private int m_longpassing;

		// Token: 0x040001A1 RID: 417
		private int m_longshots;

		// Token: 0x040001A2 RID: 418
		private int m_finishing;

		// Token: 0x040001A3 RID: 419
		private int m_shotpower;

		// Token: 0x040001A4 RID: 420
		private int m_reactions;

		// Token: 0x040001A5 RID: 421
		private int m_gkreflexes;

		// Token: 0x040001A6 RID: 422
		private int m_gkhandling;

		// Token: 0x040001A7 RID: 423
		private int m_gkdiving;

		// Token: 0x040001A8 RID: 424
		private int m_gkpositioning;

		// Token: 0x040001A9 RID: 425
		private int m_freekickaccuracy;

		// Token: 0x040001AA RID: 426
		private int m_potential;

		// Token: 0x040001AB RID: 427
		private int m_positioning;

		// Token: 0x040001AC RID: 428
		private int m_overallrating;

		// Token: 0x040001AD RID: 429
		private bool m_Inflexible;

		// Token: 0x040001AE RID: 430
		private bool m_GkOneOnOne;

		// Token: 0x040001AF RID: 431
		private bool m_CrowdFavorite;

		// Token: 0x040001B0 RID: 432
		private bool m_SecondWind;

		// Token: 0x040001B1 RID: 433
		private bool m_AcrobaticClearance;

		// Token: 0x040001B2 RID: 434
		private bool m_Longthrows;

		// Token: 0x040001B3 RID: 435
		private bool m_PowerfulFreeKicks;

		// Token: 0x040001B4 RID: 436
		private bool m_Diver;

		// Token: 0x040001B5 RID: 437
		private bool m_InjuryFree;

		// Token: 0x040001B6 RID: 438
		private bool m_InjuryProne;

		// Token: 0x040001B7 RID: 439
		private bool m_AvoidsWeakFoot;

		// Token: 0x040001B8 RID: 440
		private bool m_Divesintotackles;

		// Token: 0x040001B9 RID: 441
		private bool m_BeatDefensiveLine;

		// Token: 0x040001BA RID: 442
		private bool m_Selfish;

		// Token: 0x040001BB RID: 443
		private bool m_Leadership;

		// Token: 0x040001BC RID: 444
		private bool m_ArguesWithOfficials;

		// Token: 0x040001BD RID: 445
		private bool m_Earlycrosser;

		// Token: 0x040001BE RID: 446
		private bool m_FinesseShot;

		// Token: 0x040001BF RID: 447
		private bool m_Flair;

		// Token: 0x040001C0 RID: 448
		private bool m_LongPasser;

		// Token: 0x040001C1 RID: 449
		private bool m_LongShotTaker;

		// Token: 0x040001C2 RID: 450
		private bool m_Technicaldribbler;

		// Token: 0x040001C3 RID: 451
		private bool m_Playmaker;

		// Token: 0x040001C4 RID: 452
		private bool m_Pushesupforcorners;

		// Token: 0x040001C5 RID: 453
		private bool m_Puncher;

		// Token: 0x040001C6 RID: 454
		private bool m_GkLongThrower;

		// Token: 0x040001C7 RID: 455
		private bool m_PowerHeader;

		// Token: 0x040001C8 RID: 456
		private bool m_GiantThrow;

		// Token: 0x040001C9 RID: 457
		private bool m_OutsideFootShot;

		// Token: 0x040001CA RID: 458
		private bool m_SwervePasser;

		// Token: 0x040001CB RID: 459
		private bool m_HighClubIdentification;

		// Token: 0x040001CC RID: 460
		private bool m_TeamPlayer;

		// Token: 0x040001CD RID: 461
		private bool m_FancyFeet;

		// Token: 0x040001CE RID: 462
		private bool m_FancyPasses;

		// Token: 0x040001CF RID: 463
		private bool m_FancyFlicks;

		// Token: 0x040001D0 RID: 464
		private bool m_StutterPenalty;

		// Token: 0x040001D1 RID: 465
		private bool m_ChipperPenalty;

		// Token: 0x040001D2 RID: 466
		private bool m_BycicleKick;

		// Token: 0x040001D3 RID: 467
		private bool m_DivingHeader;

		// Token: 0x040001D4 RID: 468
		private bool m_DrivenPass;

		// Token: 0x040001D5 RID: 469
		private bool m_GkFlatKick;

		// Token: 0x040001D6 RID: 470
		private int m_curve;

		// Token: 0x040001D7 RID: 471
		private int m_internationalrep;

		// Token: 0x040001D8 RID: 472
		private int m_finishingcode1;

		// Token: 0x040001D9 RID: 473
		private int m_finishingcode2;

		// Token: 0x040001DA RID: 474
		private int m_runningcode1;

		// Token: 0x040001DB RID: 475
		private int m_runningcode2;

		// Token: 0x040001DC RID: 476
		private int m_gksavetype;

		// Token: 0x040001DD RID: 477
		private int m_faceposercode;

		// Token: 0x040001DE RID: 478
		private int m_isretiring;

		// Token: 0x040001DF RID: 479
		private int m_socklengthcode;

		// Token: 0x040001E0 RID: 480
		private int m_hashighqualityhead;

		// Token: 0x040001E1 RID: 481
		private int m_attackingworkrate;

		// Token: 0x040001E2 RID: 482
		private int m_defensiveworkrate;

		// Token: 0x040001E3 RID: 483
		private bool m_shortstyle;

		// Token: 0x040001E4 RID: 484
		private int m_interceptions;

		// Token: 0x040001E5 RID: 485
		private bool m_jerseyfit;

		// Token: 0x040001E6 RID: 486
		private int m_teamidloanedfrom;

		// Token: 0x040001E7 RID: 487
		private Team m_TeamLoanedFrom;

		// Token: 0x040001E8 RID: 488
		private int m_previousteamid;

		// Token: 0x040001E9 RID: 489
		private Team m_PreviousTeam;

		// Token: 0x040001EA RID: 490
		public bool m_IsLoaned;

		// Token: 0x040001EB RID: 491
		private DateTime m_loandateend;

		// Token: 0x040001EC RID: 492
		private static int[] s_MeanLevels = new int[] { 52, 59, 66, 72, 77, 82, 88 };
	}
}
