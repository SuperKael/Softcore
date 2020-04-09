using GadgetCore.API;

namespace Softcore
{
    [Gadget("Softcore")]
    public class Softcore : Gadget
    {
        protected override void Initialize()
		{
			Logger.Log("Softcore v" + Info.Mod.Version);
		}
    }
}