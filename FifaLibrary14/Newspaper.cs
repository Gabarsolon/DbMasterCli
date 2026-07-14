using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000086 RID: 134
	public class Newspaper
	{
		// Token: 0x06000A86 RID: 2694 RVA: 0x0004780D File Offset: 0x00045A0D
		public static string NewspaperTemplateBigFileName()
		{
			return "data/ui/artassets/newspapers/np_#.big";
		}

		// Token: 0x06000A87 RID: 2695 RVA: 0x00047814 File Offset: 0x00045A14
		public static string NewspaperTemplateDdsName()
		{
			return "2";
		}

		// Token: 0x06000A88 RID: 2696 RVA: 0x0004781B File Offset: 0x00045A1B
		public static string NewspaperBigFileName(int id)
		{
			return "data/ui/artassets/newspapers/np_" + id.ToString() + ".big";
		}

		// Token: 0x06000A89 RID: 2697 RVA: 0x00047834 File Offset: 0x00045A34
		public static Bitmap GetNewspaper(int id)
		{
			string text = Newspaper.NewspaperBigFileName(id);
			return FifaEnvironment.GetArtasset(text);
		}

		// Token: 0x06000A8A RID: 2698 RVA: 0x0004784E File Offset: 0x00045A4E
		public static bool SetNewspaper(int id, Bitmap bitmap)
		{
			return FifaEnvironment.SetArtasset(Newspaper.NewspaperTemplateBigFileName(), Newspaper.NewspaperTemplateDdsName(), id, bitmap);
		}

		// Token: 0x02000087 RID: 135
		public enum ENewspaperCountry
		{
			// Token: 0x04000F6C RID: 3948
			Equipe,
			// Token: 0x04000F6D RID: 3949
			Kicker,
			// Token: 0x04000F6E RID: 3950
			SkySport,
			// Token: 0x04000F6F RID: 3951
			CorriereDelloSport,
			// Token: 0x04000F70 RID: 3952
			Carrusel,
			// Token: 0x04000F71 RID: 3953
			LasNoticias,
			// Token: 0x04000F72 RID: 3954
			FutbolMundial,
			// Token: 0x04000F73 RID: 3955
			EAInsider,
			// Token: 0x04000F74 RID: 3956
			RMC,
			// Token: 0x04000F75 RID: 3957
			Deportes,
			// Token: 0x04000F76 RID: 3958
			Marca,
			// Token: 0x04000F77 RID: 3959
			LaStampa,
			// Token: 0x04000F78 RID: 3960
			talkSport,
			// Token: 0x04000F79 RID: 3961
			Carrusel2,
			// Token: 0x04000F7A RID: 3962
			Soccer
		}
	}
}
