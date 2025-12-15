using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
using UnityEngine.UI;
using System.Collections.Generic;

public class VideoSettings : MonoBehaviour
{
    public Dropdown resalutionDropdown;
    public Resolution[] resolutions;


    void Start()
    {
        resolutions = Screen.resolutions;
        resalutionDropdown.ClearOptions();
        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + " x " + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resalutionDropdown.AddOptions(options);
        resalutionDropdown.value = currentResolutionIndex;
        resalutionDropdown.RefreshShownValue();
    }

    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  Display

    public void setResolution(int resolutionIndex)
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }
    public void SetQuality(int qualityIndex)
    {
        QualitySettings.SetQualityLevel(qualityIndex);
    }

    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  Audio

    public void SetFullScreen()
    {
        if (Screen.fullScreen)
        {
            Screen.fullScreen = false;
        }
        else
        {
            Screen.fullScreen = true;
        }
    }


    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - - Sensitivity

    public void SetYSensvalue(float Ysens)
    {
        PlayerPrefs.SetFloat("YSens", Ysens);
    }

    public void SetXSensvalue(float Xsens)
    {
        PlayerPrefs.SetFloat("XSens", Xsens);
    }

    public void ChangeVisualSettings(int settinglevel)
    {
        QualitySettings.SetQualityLevel(settinglevel);
    }
    public void ChangeRenderScale(float scale)
    {
        UniversalRenderPipelineAsset pipeline = GraphicsSettings.currentRenderPipeline as UniversalRenderPipelineAsset;
    }
}
