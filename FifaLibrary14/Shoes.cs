using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000083 RID: 131
	public class Shoes : IdObject
	{
		// Token: 0x06000A4D RID: 2637 RVA: 0x00046E20 File Offset: 0x00045020
		public static Color GetGenericColor(int colorId)
		{
			if (colorId >= 0 && colorId <= 15)
			{
				return Shoes.c_ShoesColor[colorId];
			}
			return Color.FromArgb(0, 0, 0, 0);
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06000A4E RID: 2638 RVA: 0x00046E45 File Offset: 0x00045045
		public static Color[] ShoesColorPalette
		{
			get
			{
				return Shoes.c_ShoesColor;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06000A4F RID: 2639 RVA: 0x00046E4C File Offset: 0x0004504C
		// (set) Token: 0x06000A50 RID: 2640 RVA: 0x00046E54 File Offset: 0x00045054
		public bool HasName
		{
			get
			{
				return this.m_HasName;
			}
			set
			{
				this.m_HasName = value;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06000A51 RID: 2641 RVA: 0x00046E5D File Offset: 0x0004505D
		// (set) Token: 0x06000A52 RID: 2642 RVA: 0x00046E65 File Offset: 0x00045065
		public string Name
		{
			get
			{
				return this.m_LanguageName;
			}
			set
			{
				this.m_LanguageName = value;
				FifaEnvironment.Language.SetShoesName(base.Id, this.m_LanguageName);
				this.m_HasName = true;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06000A53 RID: 2643 RVA: 0x00046E8B File Offset: 0x0004508B
		// (set) Token: 0x06000A54 RID: 2644 RVA: 0x00046E93 File Offset: 0x00045093
		public int shoecolor1
		{
			get
			{
				return this.m_shoecolor1;
			}
			set
			{
				this.m_shoecolor1 = value;
			}
		}

		// Token: 0x1700021F RID: 543
		// (get) Token: 0x06000A55 RID: 2645 RVA: 0x00046E9C File Offset: 0x0004509C
		// (set) Token: 0x06000A56 RID: 2646 RVA: 0x00046EA4 File Offset: 0x000450A4
		public int shoecolor2
		{
			get
			{
				return this.m_shoecolor2;
			}
			set
			{
				this.m_shoecolor2 = value;
			}
		}

		// Token: 0x17000220 RID: 544
		// (get) Token: 0x06000A57 RID: 2647 RVA: 0x00046EAD File Offset: 0x000450AD
		// (set) Token: 0x06000A58 RID: 2648 RVA: 0x00046EB5 File Offset: 0x000450B5
		public int shoedesign
		{
			get
			{
				return this.m_shoedesign;
			}
			set
			{
				this.m_shoedesign = value;
			}
		}

		// Token: 0x17000221 RID: 545
		// (get) Token: 0x06000A59 RID: 2649 RVA: 0x00046EBE File Offset: 0x000450BE
		// (set) Token: 0x06000A5A RID: 2650 RVA: 0x00046EC6 File Offset: 0x000450C6
		public int powid
		{
			get
			{
				return this.m_powid;
			}
			set
			{
				this.m_powid = value;
			}
		}

		// Token: 0x17000222 RID: 546
		// (get) Token: 0x06000A5B RID: 2651 RVA: 0x00046ECF File Offset: 0x000450CF
		// (set) Token: 0x06000A5C RID: 2652 RVA: 0x00046ED7 File Offset: 0x000450D7
		public bool IsAdidas
		{
			get
			{
				return this.m_IsAdidas;
			}
			set
			{
				this.m_IsAdidas = value;
			}
		}

		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000A5D RID: 2653 RVA: 0x00046EE0 File Offset: 0x000450E0
		// (set) Token: 0x06000A5E RID: 2654 RVA: 0x00046EE8 File Offset: 0x000450E8
		public bool IsAvailableinStore
		{
			get
			{
				return this.m_IsAvailableinStore;
			}
			set
			{
				this.m_IsAvailableinStore = value;
			}
		}

		// Token: 0x17000224 RID: 548
		// (get) Token: 0x06000A5F RID: 2655 RVA: 0x00046EF1 File Offset: 0x000450F1
		// (set) Token: 0x06000A60 RID: 2656 RVA: 0x00046EF9 File Offset: 0x000450F9
		public bool IsEmbargoed
		{
			get
			{
				return this.m_IsEmbargoed;
			}
			set
			{
				this.m_IsEmbargoed = value;
			}
		}

		// Token: 0x17000225 RID: 549
		// (get) Token: 0x06000A61 RID: 2657 RVA: 0x00046F02 File Offset: 0x00045102
		// (set) Token: 0x06000A62 RID: 2658 RVA: 0x00046F0A File Offset: 0x0004510A
		public bool IsLegacy
		{
			get
			{
				return this.m_IsLegacy;
			}
			set
			{
				this.m_IsLegacy = value;
			}
		}

		// Token: 0x17000226 RID: 550
		// (get) Token: 0x06000A63 RID: 2659 RVA: 0x00046F13 File Offset: 0x00045113
		// (set) Token: 0x06000A64 RID: 2660 RVA: 0x00046F1B File Offset: 0x0004511B
		public bool IsLicensed
		{
			get
			{
				return this.m_IsLicensed;
			}
			set
			{
				this.m_IsLicensed = value;
			}
		}

		// Token: 0x17000227 RID: 551
		// (get) Token: 0x06000A65 RID: 2661 RVA: 0x00046F24 File Offset: 0x00045124
		// (set) Token: 0x06000A66 RID: 2662 RVA: 0x00046F2C File Offset: 0x0004512C
		public bool IsLocked
		{
			get
			{
				return this.m_IsLocked;
			}
			set
			{
				this.m_IsLocked = value;
			}
		}

		// Token: 0x06000A67 RID: 2663 RVA: 0x00046F38 File Offset: 0x00045138
		public Shoes(Record r)
			: base(r.IntField[FI.playerboots_shoetype])
		{
			this.m_LanguageName = FifaEnvironment.Language.GetShoesName(base.Id);
			this.m_HasName = this.m_LanguageName != null;
			if (!this.m_HasName)
			{
				string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
				this.m_LanguageName = "Shoes n. " + text;
			}
			this.m_shoecolor1 = r.GetAndCheckIntField(FI.playerboots_shoecolor1);
			this.m_shoecolor2 = r.GetAndCheckIntField(FI.playerboots_shoecolor2);
			this.m_shoedesign = r.GetAndCheckIntField(FI.playerboots_shoedesign);
			this.m_IsAdidas = r.IntField[FI.playerboots_isadidas] > 0;
			this.m_IsAvailableinStore = r.IntField[FI.playerboots_isavailableinstore] > 0;
			this.m_IsEmbargoed = r.IntField[FI.playerboots_isembargoed] > 0;
			this.m_IsLegacy = r.IntField[FI.playerboots_islegacy] > 0;
			this.m_IsLicensed = r.IntField[FI.playerboots_islicensed] > 0;
			this.m_IsLocked = r.IntField[FI.playerboots_islocked] > 0;
			this.m_powid = r.GetAndCheckIntField(FI.playerboots_powid);
		}

		// Token: 0x06000A68 RID: 2664 RVA: 0x00047088 File Offset: 0x00045288
		public Shoes(int shoesId)
			: base(shoesId)
		{
			this.m_LanguageName = FifaEnvironment.Language.GetShoesName(base.Id);
			this.m_HasName = this.m_LanguageName != null;
			if (!this.m_HasName)
			{
				string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
				this.m_LanguageName = "Shoes n. " + text;
			}
			this.m_shoecolor1 = 30;
			this.m_shoecolor2 = 31;
			this.m_shoedesign = 0;
			this.m_IsAdidas = false;
			this.m_IsAvailableinStore = false;
			this.m_IsEmbargoed = false;
			this.m_IsLegacy = false;
			this.m_IsLicensed = false;
			this.m_IsLocked = false;
			this.m_powid = -1;
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0004713C File Offset: 0x0004533C
		public void SaveShoes(Record r)
		{
			r.IntField[FI.playerboots_shoetype] = base.Id;
			r.IntField[FI.playerboots_shoecolor1] = this.m_shoecolor1;
			r.IntField[FI.playerboots_shoecolor2] = this.m_shoecolor2;
			r.IntField[FI.playerboots_shoedesign] = this.m_shoedesign;
			r.IntField[FI.playerboots_isadidas] = (this.m_IsAdidas ? 1 : 0);
			r.IntField[FI.playerboots_isavailableinstore] = (this.m_IsAvailableinStore ? 1 : 0);
			r.IntField[FI.playerboots_isembargoed] = 0;
			r.IntField[FI.playerboots_islegacy] = 0;
			r.IntField[FI.playerboots_islicensed] = 1;
			r.IntField[FI.playerboots_islocked] = 0;
			r.IntField[FI.playerboots_powid] = -1;
		}

		// Token: 0x06000A6A RID: 2666 RVA: 0x00047204 File Offset: 0x00045404
		public override IdObject Clone(int newId)
		{
			Shoes shoes = (Shoes)base.Clone(newId);
			if (shoes != null)
			{
				string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
				shoes.Name = "Shoes n. " + text;
				FifaEnvironment.CloneIntoZdata(Shoes.ShoesTexturesFileName(base.Id, 0), Shoes.ShoesTexturesFileName(newId, 0));
				FifaEnvironment.CloneIntoZdata(Shoes.ShoesModelFileName(base.Id), Shoes.ShoesModelFileName(newId));
			}
			return shoes;
		}

		// Token: 0x06000A6B RID: 2667 RVA: 0x00047278 File Offset: 0x00045478
		public override string ToString()
		{
			return this.m_LanguageName;
		}

		// Token: 0x06000A6C RID: 2668 RVA: 0x00047280 File Offset: 0x00045480
		public static string ShoesTexturesFileName(int shoesBrand, int shoesDesign)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/shoe/shoe_",
				shoesBrand.ToString(),
				"_",
				shoesDesign.ToString(),
				"_textures.rx3"
			});
		}

		// Token: 0x06000A6D RID: 2669 RVA: 0x000472C6 File Offset: 0x000454C6
		public static string ShoesModelFileName(int shoesBrand)
		{
			return "data/sceneassets/shoe/shoe_" + shoesBrand.ToString() + ".rx3";
		}

		// Token: 0x06000A6E RID: 2670 RVA: 0x000472E0 File Offset: 0x000454E0
		public static Bitmap GetShoesColorTexture(int shoesBrand, int shoesDesign)
		{
			string text = Shoes.ShoesTexturesFileName(shoesBrand, shoesDesign);
			return FifaEnvironment.GetBmpFromRx3(text);
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000472FC File Offset: 0x000454FC
		public static Bitmap[] GetShoesTextures(int shoesBrand, int shoesDesign)
		{
			string text = Shoes.ShoesTexturesFileName(shoesBrand, shoesDesign);
			return FifaEnvironment.GetBmpsFromRx3(text);
		}

		// Token: 0x06000A70 RID: 2672 RVA: 0x00047317 File Offset: 0x00045517
		public static bool ImportShoesTextures(int shoesBrand, int shoesColor, string rx3FileName)
		{
			return Shoes.SetShoesTextures(shoesBrand, shoesColor, rx3FileName);
		}

		// Token: 0x06000A71 RID: 2673 RVA: 0x00047324 File Offset: 0x00045524
		public static bool ExportShoesTextures(int shoesBrand, int shoesColor, string exportDir)
		{
			string text = Shoes.ShoesTexturesFileName(shoesBrand, shoesColor);
			return FifaEnvironment.ExportFileFromZdata(text, exportDir);
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x00047340 File Offset: 0x00045540
		public static Rx3File GetShoesModel(int shoesBrand)
		{
			string text = Shoes.ShoesModelFileName(shoesBrand);
			return FifaEnvironment.GetRx3FromZdata(text);
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0004735C File Offset: 0x0004555C
		public static bool SetShoesTextures(int shoesBrand, int shoesDesign, Bitmap[] bitmaps)
		{
			Shoes.ShoesTexturesFileName(shoesBrand, shoesDesign);
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/shoe/shoe_#_%_textures.rx3", new int[] { shoesBrand, shoesDesign }, bitmaps, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x00047390 File Offset: 0x00045590
		public static bool SetShoesTextures(int shoesBrand, int shoesDesign, string rx3FileName)
		{
			string text = Shoes.ShoesTexturesFileName(shoesBrand, shoesDesign);
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x000473B4 File Offset: 0x000455B4
		public static bool SetShoesModel(int shoesBrand, string rx3FileName)
		{
			string text = Shoes.ShoesModelFileName(shoesBrand);
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A76 RID: 2678 RVA: 0x000473D8 File Offset: 0x000455D8
		public static bool ExportShoesModel(int shoesBrand, string exportDir)
		{
			string text = Shoes.ShoesModelFileName(shoesBrand);
			return FifaEnvironment.ExportFileFromZdata(text, exportDir);
		}

		// Token: 0x06000A77 RID: 2679 RVA: 0x000473F4 File Offset: 0x000455F4
		public static bool DeleteShoes(int shoesBrand, int shoesColor)
		{
			string text = Shoes.ShoesTexturesFileName(shoesBrand, shoesColor);
			FifaEnvironment.DeleteFromZdata(text);
			text = Shoes.ShoesModelFileName(shoesBrand);
			FifaEnvironment.DeleteFromZdata(text);
			return true;
		}

		// Token: 0x06000A78 RID: 2680 RVA: 0x00047420 File Offset: 0x00045620
		public static bool DeleteShoesTextures(int shoesBrand, int shoesColor)
		{
			string text = Shoes.ShoesTexturesFileName(shoesBrand, shoesColor);
			FifaEnvironment.DeleteFromZdata(text);
			return true;
		}

		// Token: 0x06000A79 RID: 2681 RVA: 0x00047440 File Offset: 0x00045640
		public static bool DeleteShoesModel(int shoesBrand)
		{
			string text = Shoes.ShoesModelFileName(shoesBrand);
			FifaEnvironment.DeleteFromZdata(text);
			return true;
		}

		// Token: 0x04000F5E RID: 3934
		private static Color[] c_ShoesColor = new Color[]
		{
			Color.FromArgb(255, 20, 20, 20),
			Color.FromArgb(255, 50, 34, 105),
			Color.FromArgb(255, 1, 32, 87),
			Color.FromArgb(255, 8, 77, 158),
			Color.FromArgb(255, 1, 159, 224),
			Color.FromArgb(255, 0, 177, 17),
			Color.FromArgb(255, 120, 200, 25),
			Color.FromArgb(255, 250, 245, 10),
			Color.FromArgb(255, 250, 240, 0),
			Color.FromArgb(255, 236, 86, 1),
			Color.FromArgb(255, 227, 1, 103),
			Color.FromArgb(255, 177, 11, 35),
			Color.FromArgb(255, 112, 37, 42),
			Color.FromArgb(255, 146, 114, 63),
			Color.FromArgb(255, 160, 160, 160),
			Color.FromArgb(255, 235, 235, 235)
		};

		// Token: 0x04000F5F RID: 3935
		private bool m_HasName;

		// Token: 0x04000F60 RID: 3936
		private string m_LanguageName;

		// Token: 0x04000F61 RID: 3937
		private int m_shoecolor1;

		// Token: 0x04000F62 RID: 3938
		private int m_shoecolor2;

		// Token: 0x04000F63 RID: 3939
		private int m_shoedesign;

		// Token: 0x04000F64 RID: 3940
		private int m_powid;

		// Token: 0x04000F65 RID: 3941
		private bool m_IsAdidas;

		// Token: 0x04000F66 RID: 3942
		private bool m_IsAvailableinStore;

		// Token: 0x04000F67 RID: 3943
		private bool m_IsEmbargoed;

		// Token: 0x04000F68 RID: 3944
		private bool m_IsLegacy;

		// Token: 0x04000F69 RID: 3945
		private bool m_IsLicensed;

		// Token: 0x04000F6A RID: 3946
		private bool m_IsLocked;
	}
}
