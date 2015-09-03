using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI.ResourceGroups
{
    /// <summary>
    /// A resource group specific for our simple popup at /Static/Views/SimplePopupSample.aspx
    /// </summary>
    public class BigBoxSimplePopupResourceGroup : ResourceGroup
    {
        public BigBoxSimplePopupResourceGroup()
        {
            AddFile("big-box-of-views.css");

            // attaches this resource to our view...
            AttachToView("SimplePopupSample.aspx");

            // Adds the Tridion.Web.UI.Editors.CME dependency
            Dependencies.Add("Tridion.Web.UI.Editors.CME");
        }
    }
}
