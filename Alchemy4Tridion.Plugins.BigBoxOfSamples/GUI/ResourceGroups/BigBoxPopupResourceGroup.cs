using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI.ResourceGroups
{
    /// <summary>
    /// A resource group that will be included in our /Static/Views/PopupSample.aspx popup view.
    /// </summary>
    public class BigBoxPopupResourceGroup : ResourceGroup
    {
        public BigBoxPopupResourceGroup()
        {
            AddFile("BigBoxSamplePopup.js");
            AddFile("big-box-of-views.css");

            // attach this group to our view as well as add our custom context menu to it.
            AttachToView("PopupSample.aspx")
                .SetContextMenu<NewContextMenuSample>();

            // our popup contains a custom context menu, so we're adding necessary dependencies

            // Adds the Tridion.Web.UI.Editors.CME dependency
            Dependencies.Add("Tridion.Web.UI.Editors.CME");
            // Adds dependency so our contextmenu is styled and workable
            Dependencies.Add("Tridion.Web.UI.Controls.ContextMenu");
            // Adding our group with the commands as our context menu will be able to execute those.
            Dependencies.Add<BigBoxOfCommandsResourceGroup>();
        }
    }
}
