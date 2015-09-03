using Alchemy4Tridion.Plugins.GUI.Configuration;

namespace Alchemy4Tridion.Plugins.BigBoxOfSamples.GUI
{
    public class BigBoxCommandSet : CommandSet
    {
        public BigBoxCommandSet()
        {
            AddCommand("OpenBigBoxPopup");
            AddCommand("OpenBigBoxSimplePopup");
        }
    }
}
