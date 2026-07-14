using System;
using System.CodeDom.Compiler;
using System.Configuration;
using System.Runtime.CompilerServices;

namespace DbMaster.Properties
{
	// Token: 0x02000015 RID: 21
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	[CompilerGenerated]
	internal sealed partial class Settings : ApplicationSettingsBase
	{
		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000FC31 File Offset: 0x0000DE31
		public static Settings Default
		{
			get
			{
				return Settings.defaultInstance;
			}
		}

		// Token: 0x040000E2 RID: 226
		private static Settings defaultInstance = (Settings)SettingsBase.Synchronized(new Settings());
	}
}
