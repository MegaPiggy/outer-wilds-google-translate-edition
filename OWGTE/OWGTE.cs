using OWML.Common;
using OWML.ModHelper;

namespace OWGTE
{
    public class OWGTE : ModBehaviour
    {
        public static OWGTE Instance;
        private void Start()
        {
            var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
            api.RegisterLanguage(this, "GT", "assets/main.xml");
            api.RegisterLanguage(this, "GTCon", "assets/consistent.xml");
        }
    }
}
