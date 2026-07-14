using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace FifaControls.Properties
{
	// Token: 0x0200002B RID: 43
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
	internal class Resources
	{
		// Token: 0x0600019E RID: 414 RVA: 0x00012252 File Offset: 0x00010452
		internal Resources()
		{
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600019F RID: 415 RVA: 0x0001225C File Offset: 0x0001045C
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("FifaControls.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x0001229B File Offset: 0x0001049B
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x000122A2 File Offset: 0x000104A2
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return Resources.resourceCulture;
			}
			set
			{
				Resources.resourceCulture = value;
			}
		}

		// Token: 0x040001A7 RID: 423
		private static ResourceManager resourceMan;

		// Token: 0x040001A8 RID: 424
		private static CultureInfo resourceCulture;
	}
}
