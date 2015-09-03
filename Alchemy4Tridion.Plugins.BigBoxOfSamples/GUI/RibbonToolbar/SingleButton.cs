using Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI.ResourceGroups;
using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI.RibbonToolbar
{
    /// <summary>
    /// Example of a single ribbon toolbar button.
    /// </summary>
    public class SingleButton : RibbonToolbarExtension
    {
        public SingleButton()
        {
            // Id of element, can be used for css
            AssignId = "BigBoxRibbonToolbarSingleButton";
            // Becomes label of button
            Name = "Single Button";
            // which tab to put it on
            PageId = Constants.PageIds.HomePage;
            // Which group to put it on... in this case we're adding it to our BigBoxPopupToolbarGroup's AssignId
            GroupId = "BigBoxToolbarGroup"; 

            // the command to execute when clicked..
            Command = "OpenBigBoxPopup";
            // the title attribute of the element (shows when hovering mouse over button)
            Title = "Open the Big Box of Samples Popup Page";

            Dependencies.Add<BigBoxOfCommandsResourceGroup>();
            Apply.ToView(Constants.Views.DashboardView, "DashboardToolbar");
        }
    }
}
