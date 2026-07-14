using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000089 RID: 137
	public class Gloves : IdObject
	{
		// Token: 0x06000A8E RID: 2702 RVA: 0x0004790B File Offset: 0x00045B0B
		public Gloves(int ballId)
			: base(ballId)
		{
		}

		// Token: 0x06000A8F RID: 2703 RVA: 0x00047914 File Offset: 0x00045B14
		public static string GlovesFileName(int id)
		{
			return "data/sceneassets/gkgloves/gkgloves_0_" + id.ToString() + "_textures.rx3";
		}

		// Token: 0x06000A90 RID: 2704 RVA: 0x0004793C File Offset: 0x00045B3C
		public static Rx3File GetGloves(int id)
		{
			string text = Gloves.GlovesFileName(id);
			return FifaEnvironment.GetRx3FromZdata(text);
		}

		// Token: 0x06000A91 RID: 2705 RVA: 0x00047956 File Offset: 0x00045B56
		public static bool SetGloves(int id, Bitmap[] bitmaps)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/gkgloves/gkgloves_0_#_textures.rx3", id, bitmaps, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A92 RID: 2706 RVA: 0x00047968 File Offset: 0x00045B68
		public static bool SetGloves(int id, string rx3FileName)
		{
			string text = Gloves.GlovesFileName(id);
			return FifaEnvironment.ImportFileIntoZdataAs(rx3FileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A93 RID: 2707 RVA: 0x0004798C File Offset: 0x00045B8C
		public static bool DeleteGloves(int id)
		{
			string text = Gloves.GlovesFileName(id);
			return FifaEnvironment.DeleteFromZdata(text);
		}
	}
}
