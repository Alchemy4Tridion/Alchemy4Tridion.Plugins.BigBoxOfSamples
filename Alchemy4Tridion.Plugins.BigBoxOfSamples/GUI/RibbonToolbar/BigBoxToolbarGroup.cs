using Alchemy4Tridion.Plugins.GUI.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI.RibbonToolbar
{
    /// <summary>
    /// An example of creating an empty group within the ribbon toolbar.
    /// </summary>
    public class BigBoxToolbarGroup : RibbonToolbarExtension
    {
        public BigBoxToolbarGroup()
        {
            AssignId = "BigBoxToolbarGroup";
            Name = "Big Box of Samples";

            Group = "";
            InsertBefore = Constants.GroupIds.HomePage.PublishGroup;
            PageId = Constants.PageIds.HomePage;

            Apply.ToView(Constants.Views.DashboardView, "DashboardToolbar");
        }
    }
}
