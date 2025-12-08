using UnityEngine;

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
            if (Application.systemLanguage == SystemLanguage.English)
            {

            }
        }
        else
        {
            //choose language chosen
        }
    }

    public void LanguageChooser(int dropInput)
    {
        switch (dropInput)
        {
            case 0:
                PlayerPrefs.SetFloat("LanguageChosen", dropInput);
                PlayerPrefs.Save();
                break;
            case 1:
                PlayerPrefs.SetFloat("LanguageChosen", dropInput);
                PlayerPrefs.Save();
                break;
            case 2:
                PlayerPrefs.SetFloat("LanguageChosen", dropInput);
                PlayerPrefs.Save();
                break;
        }
    }
}
