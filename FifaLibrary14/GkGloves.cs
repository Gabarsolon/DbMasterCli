using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000076 RID: 118
	public class GkGloves : IdObject
	{
		// Token: 0x17000214 RID: 532
		// (get) Token: 0x060009CE RID: 2510 RVA: 0x00045969 File Offset: 0x00043B69
		public static Model3D GkGlovesModel
		{
			get
			{
				return GkGloves.s_GkGlovesModel;
			}
		}

		// Token: 0x060009CF RID: 2511 RVA: 0x00045970 File Offset: 0x00043B70
		public void Set3DModelTexture(Bitmap bitmaps)
		{
			if (GkGloves.s_GkGlovesModel != null)
			{
				GkGloves.s_GkGlovesModel.TextureBitmap = bitmaps;
			}
		}

		// Token: 0x060009D0 RID: 2512 RVA: 0x00045984 File Offset: 0x00043B84
		public GkGloves(int gkglovesId)
			: base(gkglovesId)
		{
			if (GkGloves.s_GkGlovesModel == null)
			{
				Rx3Vertex.FloatType = Rx3Vertex.EFloatType.Float32;
				Rx3File rx3FromZdata = FifaEnvironment.GetRx3FromZdata(GkGloves.GkGlovesModelFileName(1));
				GkGloves.s_GkGlovesModel = new Model3D(rx3FromZdata.Rx3IndexArrays[0], rx3FromZdata.Rx3VertexArrays[0], null);
			}
		}

		// Token: 0x060009D1 RID: 2513 RVA: 0x000459CC File Offset: 0x00043BCC
		public override string ToString()
		{
			return "GK Gloves n. " + base.Id.ToString();
		}

		// Token: 0x060009D2 RID: 2514 RVA: 0x000459F1 File Offset: 0x00043BF1
		public static string GkGlovesTextureFileName(int gkglovesId)
		{
			return "data/sceneassets/gkglove/gkglove_" + gkglovesId.ToString() + "_textures.rx3";
		}

		// Token: 0x060009D3 RID: 2515 RVA: 0x00045A0C File Offset: 0x00043C0C
		public static Bitmap[] GetGkGlovesTextures(int gkglovesId)
		{
			string text = GkGloves.GkGlovesTextureFileName(gkglovesId);
			return FifaEnvironment.GetBmpsFromRx3(text);
		}

		// Token: 0x060009D4 RID: 2516 RVA: 0x00045A26 File Offset: 0x00043C26
		public static bool SetGkGlovesTextures(int gkglovesId, Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data\\sceneassets\\gkglove\\gkglove_#_textures.rx3", gkglovesId, bitmaps, ECompressionMode.Chunkzip);
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x00045A38 File Offset: 0x00043C38
		public static bool SetGkGlovesTextures(int gkglovesId, string rx3FileName)
		{
			string text = GkGloves.GkGlovesTextureFileName(gkglovesId);
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x00045A5C File Offset: 0x00043C5C
		public static bool ExportGkGlovesTextures(int gkglovesId, string exportDir)
		{
			string text = GkGloves.GkGlovesTextureFileName(gkglovesId);
			return FifaEnvironment.ExportFileFromZdata(text, exportDir);
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x00045A78 File Offset: 0x00043C78
		public static bool DeleteGkGlovesTextures(int gkglovesId)
		{
			string text = GkGloves.GkGlovesTextureFileName(gkglovesId);
			return FifaEnvironment.DeleteFromZdata(text);
		}

		// Token: 0x060009D8 RID: 2520 RVA: 0x00045A92 File Offset: 0x00043C92
		public static string GkGlovesModelFileName(int id)
		{
			return "data/sceneassets/gkglove/gkglove_" + id.ToString() + ".rx3";
		}

		// Token: 0x060009D9 RID: 2521 RVA: 0x00045AAC File Offset: 0x00043CAC
		public static Rx3File GetGkGlovesModel(int gkglovesId)
		{
			string text = GkGloves.GkGlovesTextureFileName(gkglovesId);
			return FifaEnvironment.GetRx3FromZdata(text);
		}

		// Token: 0x060009DA RID: 2522 RVA: 0x00045AC8 File Offset: 0x00043CC8
		public override IdObject Clone(int newId)
		{
			GkGloves gkGloves = (GkGloves)base.Clone(newId);
			if (gkGloves != null)
			{
				FifaEnvironment.CloneIntoZdata(GkGloves.GkGlovesTextureFileName(base.Id), GkGloves.GkGlovesTextureFileName(newId));
				FifaEnvironment.CloneIntoZdata(GkGloves.GkGlovesModelFileName(base.Id), GkGloves.GkGlovesModelFileName(newId));
			}
			return gkGloves;
		}

		// Token: 0x04000F53 RID: 3923
		private static Model3D s_GkGlovesModel;
	}
}
