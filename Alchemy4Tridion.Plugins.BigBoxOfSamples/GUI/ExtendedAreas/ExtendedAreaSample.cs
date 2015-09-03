using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI
{
    /// <summary>
    /// Extended areas are created by creating a class that inherits ExtendedAreaExtension. This adds a section
    /// into the Welcome view (the Home link in the slideout panel) on the side panel area.
    /// </summary>
    public class ExtendedAreaSample : ExtendedAreaExtension
    {
        public ExtendedAreaSample()
        {
            // the minimum properties you need to set.

            AssignId = "MyUniqueExtendedAreaAssignId";
            Name = "";
            Control = "ExtendedAreaSample.ascx";
            PageType = "";

            // We're going to apply our extended area to the Welcome screen, within the sidepanelextendablearea control.
            // Remember, extendedareaextensions only work inside of extendablearea controls.
            Apply.ToView(Constants.Views.Welcome, "SidePanelExtendableArea");
        }
    }
}
