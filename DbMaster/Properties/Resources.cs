using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace DbMaster.Properties
{
	// Token: 0x02000016 RID: 22
	[DebuggerNonUserCode]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal class Resources
	{
		// Token: 0x060002B3 RID: 691 RVA: 0x0000FC56 File Offset: 0x0000DE56
		internal Resources()
		{
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000FC60 File Offset: 0x0000DE60
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(Resources.resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("DbMaster.Properties.Resources", typeof(Resources).Assembly);
					Resources.resourceMan = resourceManager;
				}
				return Resources.resourceMan;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000FC9F File Offset: 0x0000DE9F
		// (set) Token: 0x060002B6 RID: 694 RVA: 0x0000FCA6 File Offset: 0x0000DEA6
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

		// Token: 0x040000E3 RID: 227
		private static ResourceManager resourceMan;

		// Token: 0x040000E4 RID: 228
		private static CultureInfo resourceCulture;
	}
}
