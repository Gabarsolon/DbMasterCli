using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000085 RID: 133
	public class MowingPattern : IdObject
	{
		// Token: 0x06000A7E RID: 2686 RVA: 0x00047723 File Offset: 0x00045923
		public MowingPattern(int mowingPatternId)
			: base(mowingPatternId)
		{
		}

		// Token: 0x06000A7F RID: 2687 RVA: 0x0004772C File Offset: 0x0004592C
		public override IdObject Clone(int newMowingPatternId)
		{
			MowingPattern mowingPattern = (MowingPattern)base.Clone(newMowingPatternId);
			if (mowingPattern != null)
			{
				FifaEnvironment.CloneIntoZdata(MowingPattern.MowingPatternFileName(base.Id), MowingPattern.MowingPatternFileName(newMowingPatternId));
			}
			return mowingPattern;
		}

		// Token: 0x06000A80 RID: 2688 RVA: 0x00047764 File Offset: 0x00045964
		public override string ToString()
		{
			string text = base.Id.ToString("000");
			return "Mowing Pattern n. " + text;
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x00047790 File Offset: 0x00045990
		public static string MowingPatternFileName(int mowingPatternId)
		{
			return "data/sceneassets/pitch/pitchmowpattern_" + mowingPatternId.ToString() + "_textures.rx3";
		}

		// Token: 0x06000A82 RID: 2690 RVA: 0x000477A8 File Offset: 0x000459A8
		public static Bitmap GetMowingPattern(int mowingPatternId)
		{
			string text = MowingPattern.MowingPatternFileName(mowingPatternId);
			return FifaEnvironment.GetBmpFromRx3(text);
		}

		// Token: 0x06000A83 RID: 2691 RVA: 0x000477C4 File Offset: 0x000459C4
		public static bool SetMowingPattern(int mowingPatternId, string srcFileName)
		{
			string text = MowingPattern.MowingPatternFileName(mowingPatternId);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000477E4 File Offset: 0x000459E4
		public static bool DeleteMowingPattern(int mowingPatternId)
		{
			string text = MowingPattern.MowingPatternFileName(mowingPatternId);
			return FifaEnvironment.DeleteFromZdata(text);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x000477FE File Offset: 0x000459FE
		public static bool SetMowingPattern(int mowingPatternId, Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/pitch/pitchmowpattern_#_textures.rx3", mowingPatternId, bitmap, ECompressionMode.Chunkzip);
		}
	}
}
