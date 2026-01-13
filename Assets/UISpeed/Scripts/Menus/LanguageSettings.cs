using System.Collections;
using UnityEditor.Localization.Editor;
using UnityEngine;
using UnityEngine.Localization;
using UnityEngine.Localization.Settings;

public class LanguageSettings : MonoBehaviour
{
    public SystemLanguage chosenLanguage;

    void Start()
    {
        if (!PlayerPrefs.HasKey("LanguageChosen"))
        {
            switch (Application.systemLanguage)
            {
                case SystemLanguage.English:
                    chosenLanguage = SystemLanguage.English;
                    break;
                case SystemLanguage.German:
                    chosenLanguage = SystemLanguage.German;
                    break;
                case SystemLanguage.French:
                    chosenLanguage = SystemLanguage.French;
                    break;
            }
        }
        else
        {
            //choose language chosen
            //LocalizationSettings.
        }
    }

    private bool ActiveLANGUAGEChange = false;
    public void LanguageChange(int dropInput)
    {
        if (ActiveLANGUAGEChange)
            return;
        StartCoroutine(SetLocale(dropInput));
    }

    IEnumerator SetLocale(int _LocaleID)
    {
        ActiveLANGUAGEChange = true;
        yield return LocalizationSettings.InitializationOperation;
        LocalizationSettings.SelectedLocale = LocalizationSettings.AvailableLocales.Locales[_LocaleID];

        PlayerPrefs.SetFloat("LanguageChosen", _LocaleID);
        PlayerPrefs.Save();

        ActiveLANGUAGEChange = false;
    }
}
