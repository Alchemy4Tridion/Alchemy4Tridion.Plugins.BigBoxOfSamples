using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI.ResourceGroups
{
    /// <summary>
    /// This resource group just contains references to the commands created by this plugin.
    /// </summary>
    public class BigBoxOfCommandsResourceGroup : ResourceGroup
    {
        public BigBoxOfCommandsResourceGroup()
        {
            AddFile("OpenBigBoxPopup.js");
            AddFile("OpenBigBoxSimplePopup.js");
            AddFile("big-box-of-styles.css");
            AddFile<BigBoxCommandSet>();
            
            Dependencies.AddAlchemyCore();
        }
    }
}
