using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x0200007B RID: 123
	public class Adboard : IdObject
	{
		// Token: 0x06000A14 RID: 2580 RVA: 0x0004630F File Offset: 0x0004450F
		public Adboard(int adboardId)
			: base(adboardId)
		{
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x00046318 File Offset: 0x00044518
		public override IdObject Clone(int newId)
		{
			Adboard adboard = (Adboard)base.Clone(newId);
			if (adboard != null)
			{
				FifaEnvironment.CloneIntoZdata(Adboard.AdboardFileName(base.Id), Adboard.AdboardFileName(newId));
			}
			return adboard;
		}

		// Token: 0x06000A16 RID: 2582 RVA: 0x00046350 File Offset: 0x00044550
		public override string ToString()
		{
			string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
			return "Adboard n. " + text;
		}

		// Token: 0x06000A17 RID: 2583 RVA: 0x0004637D File Offset: 0x0004457D
		public static string AdboardFileName(int adboardid)
		{
			return "data/sceneassets/adboard/adboard_" + adboardid.ToString() + "_0.rx3";
		}

		// Token: 0x06000A18 RID: 2584 RVA: 0x00046398 File Offset: 0x00044598
		public static Bitmap GetAdboard(int adboardId)
		{
			string text = Adboard.AdboardFileName(adboardId);
			return FifaEnvironment.GetBmpFromRx3(text);
		}

		// Token: 0x06000A19 RID: 2585 RVA: 0x000463B2 File Offset: 0x000445B2
		public Bitmap GetAdboard()
		{
			return Adboard.GetAdboard(base.Id);
		}

		// Token: 0x06000A1A RID: 2586 RVA: 0x000463BF File Offset: 0x000445BF
		public static bool SetAdboard(int adboardId, Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/adboard/adboard_#_0.rx3", adboardId, bitmap, ECompressionMode.Chunkref);
		}

		// Token: 0x06000A1B RID: 2587 RVA: 0x000463CE File Offset: 0x000445CE
		public bool SetAdboard(Bitmap bitmap)
		{
			return Adboard.SetAdboard(base.Id, bitmap);
		}

		// Token: 0x06000A1C RID: 2588 RVA: 0x000463DC File Offset: 0x000445DC
		public static bool SetAdboard(int adboardId, string srcFileName)
		{
			string text = Adboard.AdboardFileName(adboardId);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A1D RID: 2589 RVA: 0x000463F9 File Offset: 0x000445F9
		public bool SetAdboard(string srcFileName)
		{
			return Adboard.SetAdboard(base.Id, srcFileName);
		}

		// Token: 0x06000A1E RID: 2590 RVA: 0x00046408 File Offset: 0x00044608
		public static bool DeleteAdboard(int adboardId)
		{
			string text = Adboard.AdboardFileName(adboardId);
			return FifaEnvironment.DeleteFromZdata(text);
		}
	}
}
