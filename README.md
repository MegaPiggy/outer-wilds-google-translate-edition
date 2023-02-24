template made from a template? it's like a template-ception!

# Outer Wilds Translation Mod Template

Based on the [standard mod template](https://github.com/Raicuparta/ow-mod-template) and using [xen's localization utility](https://github.com/xen-42/outer-wilds-localization-utility), this template allows for easy creation of Outer Wilds localization mods!

## Usage

1. Create a repository for your mod by pressing the green "Use this template" button at the top of this page.
2. Download the source code for your mod inside Visual Studio and open it.
3. Change and rename all files to replace every instance of `TranslationMod` to the mod name of your choice. That is:
   - Rename the `TranslationMod` namespaces and classes in `TranslationMod.cs` and `ILocalizationAPI.cs`.
   - Replace `TranslationMod.dll`, `Blender Addict`, `My Translation Mod`, `BA.TranslationMod` and optionally `0.1.0` inside `manifest.json` with the file name of the mod dll, author name, name of the mod seen in game, internal name of the mod seen by OWML, and the mod's version respectively.
   - Replace `BA.TranslationMod` in `TranslationMod.csproj.user` with the internal name you put in `manifest.json`.
     - This is gonna be where the mod dll is gonna be saved when the project is compiled. You can choose a diffrent folder but for the sake of parity with other mods you should stick to the same name as the mod's internal name. 
   - Rename the files `TranslationMod.cs`, `TranslationMod.csproj`, `TranslationMod.csproj.user` inside the aptly named `TranslationMod` folder.
   - Save the project and rename the `TranslationMod.sln` file and the `TranslationMod` folder. (might need to be done outside Visual Studio).
     - If done outside of Visual Studio, you might need to edit the solution file in notepad to replace `TranslationMod` with the new folder name.
// TODO: explain how to add custom fonts and use language fixer
5. Try to compile the mod.
   - The mod compiled successfully? Great, that was the hard part! Now on to the excruciatingly long part.
6. Edit the `Translation.xml` file to do the actual translation.
   - The xml contains 15848 lines, dont expect it to be quick and easy. Translating the entire game can take weeks or maybe even months!
7. Once you're done create a folder named `assets` inside whatever path was in the `.csproj.user` you renamed and edited and put the translated xml there.
Congratulations. If everything went well you should have a working localization mod!

In the case that it didn't and you're sure it's because of no fault of your own, or you spotted a problem in this template, submit an issue and tell me exactly what went wrong.
