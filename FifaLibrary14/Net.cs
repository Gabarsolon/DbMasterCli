using System;
using System.Drawing;

namespace FifaLibrary
{
	// Token: 0x02000081 RID: 129
	public class Net : IdObject
	{
		// Token: 0x06000A41 RID: 2625 RVA: 0x00046BA3 File Offset: 0x00044DA3
		public Net(int netId)
			: base(netId)
		{
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x00046BAC File Offset: 0x00044DAC
		public override IdObject Clone(int newId)
		{
			Net net = (Net)base.Clone(newId);
			if (net != null)
			{
				FifaEnvironment.CloneIntoZdata(Net.NetFileName(base.Id), Net.NetFileName(newId));
			}
			return net;
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x00046BE4 File Offset: 0x00044DE4
		public override string ToString()
		{
			string text = FifaUtil.PadBlanks(base.Id.ToString(), 3);
			return "Net n. " + text;
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x00046C11 File Offset: 0x00044E11
		public static string NetFileName(int netid)
		{
			return "data/sceneassets/goalnet/netcolor_" + netid.ToString() + "_textures.rx3";
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00046C2C File Offset: 0x00044E2C
		public static Bitmap GetNet(int netId)
		{
			string text = Net.NetFileName(netId);
			return FifaEnvironment.GetBmpFromRx3(text, 0);
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00046C47 File Offset: 0x00044E47
		public static bool SetNet(int netId, Bitmap bitmap)
		{
			return FifaEnvironment.ImportBmpsIntoZdata("data/sceneassets/goalnet/netcolor_#_textures.rx3", netId, bitmap, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00046C58 File Offset: 0x00044E58
		public static bool SetNet(int netId, string srcFileName)
		{
			string text = Net.NetFileName(netId);
			return FifaEnvironment.ImportFileIntoZdataAs(srcFileName, text, false, ECompressionMode.Chunkzip);
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00046C78 File Offset: 0x00044E78
		public static bool DeleteNet(int netId)
		{
			string text = Net.NetFileName(netId);
			return FifaEnvironment.DeleteFromZdata(text);
		}
	}
}
