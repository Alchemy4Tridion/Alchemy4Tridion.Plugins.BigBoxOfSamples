using Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI.ResourceGroups;
using Alchemy4Tridion.Plugins.GUI.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI.ContextMenus
{
    /// <summary>
    /// An example of extending an exisitng context menu (the main dashboard one). To create a brand new one for a custom view or popup,
    /// check out the NewContextMenuSample
    /// </summary>
    public class ContextMenuExtensionSample : ContextMenuExtension
    {
        public ContextMenuExtensionSample()
        {
            AssignId = "";
            Name = "";
            InsertBefore = Constants.ContextMenuIds.MainContextMenu.Properties;

            AddSubMenu("bigbox_of_samples", "Big Box of Samples")
                .AddItem("bigbox_openpopup", "Open Popup", "OpenBigBoxPopup")
                .AddItem("bigbox_open_simple_popup", "Open Simple Popup", "OpenBigBoxSimplePopup");

            // We need to addd our resource group as a dependency to this extension
            Dependencies.Add<BigBoxOfCommandsResourceGroup>();

            // Actually apply our extension to a particular view.  You can have multiple.
            Apply.ToView(Constants.Views.DashboardView);
        }
    }
}
