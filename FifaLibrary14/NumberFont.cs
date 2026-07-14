using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200007D RID: 125
	public class NumberFont : IdObject
	{
		// Token: 0x06000A23 RID: 2595 RVA: 0x00046552 File Offset: 0x00044752
		public NumberFont(int fontId)
			: base(fontId)
		{
			this.ComputeStyleAndColor(fontId);
		}

		// Token: 0x06000A24 RID: 2596 RVA: 0x00046562 File Offset: 0x00044762
		private void ComputeStyleAndColor(int fontId)
		{
			this.m_Style = fontId / NumberFont.s_MaxColors;
			this.m_Color = fontId - this.m_Style * NumberFont.s_MaxColors;
		}

		// Token: 0x06000A25 RID: 2597 RVA: 0x00046588 File Offset: 0x00044788
		public override string ToString()
		{
			FifaUtil.PadBlanks(base.Id.ToString(), 3);
			string text = "Font n. " + this.m_Style + " ";
			switch (this.m_Color)
			{
			case 0:
				text += "Transparent";
				break;
			case 1:
				text += "White";
				break;
			case 2:
				text += "Black";
				break;
			case 3:
				text += "Blue";
				break;
			case 4:
				text += "Red";
				break;
			case 5:
				text += "Yellow";
				break;
			case 6:
				text += "Green";
				break;
			case 7:
				text += "Orange";
				break;
			case 8:
				text += "Violet";
				break;
			case 9:
				text += "Brown";
				break;
			case 10:
				text += "Pink";
				break;
			case 11:
				text += "Dark Red";
				break;
			case 12:
				text += "Cyano";
				break;
			case 13:
				text += "Dark Blue";
				break;
			case 14:
				text += "Gray";
				break;
			case 15:
				text += "Pale Green";
				break;
			case 16:
				text += "Dark Gold";
				break;
			case 17:
				text += "Gold";
				break;
			case 18:
				text += "Light Red";
				break;
			case 19:
				text += "Dark Green";
				break;
			default:
				text += this.m_Color.ToString();
				break;
			}
			return text;
		}

		// Token: 0x06000A26 RID: 2598 RVA: 0x00046776 File Offset: 0x00044976
		public static void Clone(int oldStyle, int oldColor, int newStyle, int newColor)
		{
			FifaEnvironment.CloneIntoZdata(NumberFont.NumberFontFileName(oldStyle, oldColor), NumberFont.NumberFontFileName(newStyle, newColor));
		}

		// Token: 0x06000A27 RID: 2599 RVA: 0x0004678C File Offset: 0x0004498C
		public static string NumberFontFileName(int styleId, int colorId)
		{
			return string.Concat(new string[]
			{
				"data/sceneassets/kitnumbers/kitnumbers_",
				styleId.ToString(),
				"_",
				colorId.ToString(),
				".rx3"
			});
		}

		// Token: 0x06000A28 RID: 2600 RVA: 0x000467D2 File Offset: 0x000449D2
		public string NumberFontFileName()
		{
			return NumberFont.NumberFontFileName(this.m_Style, this.m_Color);
		}

		// Token: 0x06000A29 RID: 2601 RVA: 0x000467E5 File Offset: 0x000449E5
		public static string NumberFontTemplateName()
		{
			return "data/sceneassets/kitnumbers/kitnumbers_#_%.rx3";
		}

		// Token: 0x06000A2A RID: 2602 RVA: 0x000467EC File Offset: 0x000449EC
		public static Rx3Signatures NumberFontSignature(int id, int colorId)
		{
			string[] array = new string[10];
			for (int i = 0; i < 10; i++)
			{
				array[i] = string.Concat(new string[]
				{
					"numbers_",
					id.ToString(),
					"_",
					colorId.ToString(),
					"_",
					i.ToString(),
					".Raster"
				});
			}
			return new Rx3Signatures(218800, 31, array);
		}

		// Token: 0x06000A2B RID: 2603 RVA: 0x0004686C File Offset: 0x00044A6C
		public static Rx3File GetNumberFontRx3(int style, int color)
		{
			string text = NumberFont.NumberFontFileName(style, color);
			return FifaEnvironment.GetRx3FromZdata(text);
		}

		// Token: 0x06000A2C RID: 2604 RVA: 0x00046888 File Offset: 0x00044A88
		public static Bitmap[] GetNumberFont(int style, int color)
		{
			string text = NumberFont.NumberFontFileName(style, color);
			return FifaEnvironment.GetBmpsFromRx3(text);
		}

		// Token: 0x06000A2D RID: 2605 RVA: 0x000468A4 File Offset: 0x00044AA4
		public static bool SetNumberFont(int style, int color, Bitmap[] bitmaps)
		{
			int[] array = new int[] { style, color };
			return FifaEnvironment.ImportBmpsIntoZdata(NumberFont.NumberFontTemplateName(), array, bitmaps, ECompressionMode.Chunkzip, NumberFont.NumberFontSignature(style, color));
		}

		// Token: 0x06000A2E RID: 2606 RVA: 0x000468D4 File Offset: 0x00044AD4
		public static bool SetNumberFont(int style, int color, string rx3FileName)
		{
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, NumberFont.NumberFontFileName(style, color), false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A2F RID: 2607 RVA: 0x000468F4 File Offset: 0x00044AF4
		public static bool Delete(int style, int color)
		{
			string text = NumberFont.NumberFontFileName(style, color);
			return FifaEnvironment.DeleteFromZdata(text);
		}

		// Token: 0x06000A30 RID: 2608 RVA: 0x00046910 File Offset: 0x00044B10
		public static bool Import(int style, int color, string rx3FileName)
		{
			string text = NumberFont.NumberFontFileName(style, color);
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A31 RID: 2609 RVA: 0x00046930 File Offset: 0x00044B30
		public static bool Export(int style, int color, string exportDir)
		{
			string text = NumberFont.NumberFontFileName(style, color);
			return FifaEnvironment.ExportFileFromZdata(text, exportDir);
		}

		// Token: 0x04000F5A RID: 3930
		private static int s_MaxColors = 20;

		// Token: 0x04000F5B RID: 3931
		private int m_Style;

		// Token: 0x04000F5C RID: 3932
		private int m_Color;
	}
}
