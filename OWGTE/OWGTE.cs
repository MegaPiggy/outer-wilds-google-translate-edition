using OWML.Common;
using OWML.ModHelper;

namespace OWGTE
{
    public class OWGTE : ModBehaviour
    {
        public static OWGTE Instance;
        private void Start()
        {
            Instance = this;
            var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
            api.RegisterLanguage(this, "Google Translate", "GT.xml");
        }
    }
}
