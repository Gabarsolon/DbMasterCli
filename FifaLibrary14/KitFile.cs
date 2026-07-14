using System;
using System.IO;

namespace FifaLibrary
{
	// Token: 0x0200003A RID: 58
	public class KitFile : Rx3File
	{
		// Token: 0x06000569 RID: 1385 RVA: 0x0001F15D File Offset: 0x0001D35D
		public override bool Load(BinaryReader r)
		{
			return base.Load(r);
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x0001F166 File Offset: 0x0001D366
		public override bool Save(BinaryWriter w, bool saveBitmaps, bool saveVertex)
		{
			return base.Save(w, true, false);
		}
	}
}
