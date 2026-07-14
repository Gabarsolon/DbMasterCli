using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200007F RID: 127
	public class NameFont : IdObject
	{
		// Token: 0x06000A36 RID: 2614 RVA: 0x00046A0B File Offset: 0x00044C0B
		public static void Clone(int oldStyle, int newStyle)
		{
			FifaEnvironment.CloneIntoZdata(NameFont.NameFontFileName(oldStyle), NameFont.NameFontFileName(newStyle));
		}

		// Token: 0x06000A37 RID: 2615 RVA: 0x00046A1F File Offset: 0x00044C1F
		public static string NameFontFileName(int id)
		{
			return "data/sceneassets/jerseyfonts/font_" + id.ToString() + ".ttf";
		}

		// Token: 0x06000A38 RID: 2616 RVA: 0x00046A37 File Offset: 0x00044C37
		public NameFont(int id)
			: base(id)
		{
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x00046A40 File Offset: 0x00044C40
		public override string ToString()
		{
			return "Name Font n. " + base.Id.ToString();
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x00046A68 File Offset: 0x00044C68
		public static string CanShowNameFont(int style)
		{
			string text = NameFont.NameFontFileName(style);
			string text2 = FifaEnvironment.RootDir + "\\Game\\" + text;
			if (File.Exists(text2))
			{
				return text2;
			}
			return null;
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x00046A98 File Offset: 0x00044C98
		public static bool Delete(int style)
		{
			string text = NameFont.NameFontFileName(style);
			return FifaEnvironment.DeleteFromZdata(text);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x00046AB4 File Offset: 0x00044CB4
		public static bool Import(int style, string srcFileName)
		{
			string text = NameFont.NameFontFileName(style);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip2);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x00046AD4 File Offset: 0x00044CD4
		public static bool Export(int style, string exportDir)
		{
			string text = NameFont.NameFontFileName(style);
			return FifaEnvironment.ExportFileFromZdata(text, exportDir);
		}
	}
}
