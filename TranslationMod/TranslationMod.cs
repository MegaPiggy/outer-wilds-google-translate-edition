using OWML.Common;
using OWML.ModHelper;
using System.Xml;

namespace TranslationMod
{
    public class TranslationMod : ModBehaviour
    {
        public static TranslationMod Instance;
        private void Start()
        {
            var api = ModHelper.Interaction.TryGetModApi<ILocalizationAPI>("xen.LocalizationUtility");
            api.RegisterLanguage(this, "Language name", "Assets/Translation.xml");

            // Below are commented examples that will be ignored by the compiler

            // If your language needs a custom font, uncomment the line below and provide the files.
            //api.AddLanguageFont(this, "Font name", "path/to/assetbundle", "Assets/Font.otf");

            // If your language is, for an example, written from right to left, uncomment this.
            // TODO: how tf do you use this lmao
            //api.AddLanguageFixer("name", "");
        }
    }
}
