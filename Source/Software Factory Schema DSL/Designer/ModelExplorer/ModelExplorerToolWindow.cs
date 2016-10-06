//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISpySoft.SFSchemaLanguage.Designer
{
	#region Using directives
	using Microsoft.VisualStudio.EnterpriseTools.Shell;
	using Microsoft.VisualStudio.Modeling;
	using Microsoft.Win32;
	using System;
	using System.Collections;
	using System.ComponentModel;
	using System.ComponentModel.Design;
	using System.Diagnostics;
	using System.Drawing;
	using System.IO;
	using System.Runtime.InteropServices;
	using System.Security.Permissions;
	using System.Windows.Forms;
	using ISpySoft.SFSchemaLanguage.Designer.Diagram; // For resource class
	#endregion

	/// <summary>
	/// This is the concrete tool window class
	/// </summary>
	[Guid(GuidList.guidModelExplorerToolWindowString)]
	[CLSCompliant(false)]
	public sealed class SFSchemaLanguageModelExplorer : ModelExplorerToolWindow
	{
		#region Construction/Destruction
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="serviceProvider">Service Provider</param>
		public SFSchemaLanguageModelExplorer(IServiceProvider serviceProvider) : base(serviceProvider)
		{
		}
		#endregion

		#region ModelExplorerToolWindow Overrides

		public override String WindowTitle
		{
			get
			{
				return EditorFactory.GetResource("ModelExplorerTitle") as string;
			}
		}

		/// <summary>
		/// Create TreeContainer
		/// </summary>
		/// <returns>ModelExplorerTreeContainer</returns>
		protected override Microsoft.VisualStudio.EnterpriseTools.Shell.ModelExplorerTreeContainer CreateTreeContainer()
		{
			return new TreeContainer(this);
		}
		#endregion
	}
}
