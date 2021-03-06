//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISpySoft.SFSchemaLanguage.Designer{
	#region Using statements
	using System;
	using System.Windows.Forms;
	using Microsoft.VisualStudio.Modeling;
	using Microsoft.VisualStudio.EnterpriseTools.Shell;
	#endregion

	/// <summary>
	/// Summary description for ModelExplorerTreeContainer.
	/// </summary>
	public sealed class TreeContainer : ModelExplorerTreeContainer
	{
		private IServiceProvider sp;

		#region Constructor
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="serviceProvider">Service</param>
		public TreeContainer(IServiceProvider serviceProvider) : base(serviceProvider)
		{
			sp = serviceProvider;
		}
		#endregion

		#region ModelExplorerTreeContainer Overrides
		/// <summary>
		/// Create IElementVisitor
		/// </summary>
		/// <returns>IElementVisitor</returns>
		protected override IElementVisitor CreateElementVisitor()
		{
			return new ExplorerElementVisitor(this.ObjectModelBrowser, sp);
		}

		/// <summary>
		/// Specifies the context menu that should be shown for the model explorer.
		///</summary>
		protected override System.ComponentModel.Design.CommandID ContextMenuCommandId
		{
			get
			{
				return new System.ComponentModel.Design.CommandID(GuidList.guidSFSchemaLanguageMenu, PackageMenuIdList.menuIdExplorer);
			}
		}

			/// <summary>
		/// Return the root elements to be displayed in the explorer.
		///</summary>
		/// <param name="store">Store where root elements should be retrieved.</param>
		/// <returns>List of root elements.</returns>
		protected override System.Collections.IList FindRootElements(Store store)
		{
			MetaClassInfo rootMetaClass = store.MetaDataDirectory.FindMetaClass(typeof(ISpySoft.SFSchemaLanguage.DomainModel.SchemaModel));
			return store.ElementDirectory.GetElements(rootMetaClass);
		}
		#endregion
	}
}

