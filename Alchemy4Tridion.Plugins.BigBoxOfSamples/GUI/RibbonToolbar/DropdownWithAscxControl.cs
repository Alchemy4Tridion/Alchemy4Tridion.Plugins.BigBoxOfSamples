using Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI.ResourceGroups;
using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI.RibbonToolbar
{
    /// <summary>
    /// Example of dropdown using .ascx control... unfortunately this creates a new group.
    /// </summary>
    public class DropdownWithAscxControl : RibbonToolbarExtension
    {
        public DropdownWithAscxControl()
        {
            // Typcially becomes id of the group that can be assigned to.
            AssignId = "BigBoxControlGroup";

            // Name becomes the label of the newly created group
            Name = "Big Box Control Group";

            // The filename of the ascx user control that contains the button markup/controls.
            Group = "RibbonButtonDropdown.ascx";

            // Which Page tab the extension will go on.
            PageId = Constants.PageIds.HomePage;

            // Which group to put it on... in this case we're adding it to our BigBoxPopupToolbarGroup's AssignId
            // doesnt do
            GroupId = "BigBoxToolbarGroup"; 

            // Don't forget to add a dependency to the resource group that references the command set...
            Dependencies.Add<BigBoxOfCommandsResourceGroup>();

            // And apply it to a view.
            Apply.ToView(Constants.Views.DashboardView, "DashboardToolbar");
        }
    }
}
