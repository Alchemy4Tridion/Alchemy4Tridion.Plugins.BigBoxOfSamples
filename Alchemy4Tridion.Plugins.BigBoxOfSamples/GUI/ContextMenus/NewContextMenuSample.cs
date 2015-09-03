using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI
{
    public class NewContextMenuSample : ContextMenuDeclaration
    {
        // the name is optional when calling the base constructor... this is the unique identifier of your custom context menu.
        // if not set, the name will be auto generated based on your plugin's name + ContextMenu's Type name.
        public NewContextMenuSample()
            : base("BigBoxContextMenu")
        {
            AddItem("bigbox_openpopup", "Open Popup", "OpenBigBoxPopup");
            AddItem("bigbox_open_simple_popup", "Open Simple Popup", "OpenBigBoxSimplePopup");
        }
    }
}
