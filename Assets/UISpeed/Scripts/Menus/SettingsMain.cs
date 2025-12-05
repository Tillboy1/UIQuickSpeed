using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
using Unity.VisualScripting;
using System.Linq;

public class SettingsMain : MonoBehaviour
{
    public GameObject[] screensHolder = new GameObject[9];

    void Start()
    {

        for (int i = 0; i < transform.Find("Screens").childCount; i++)
        {
            screensHolder[i] = transform.Find("Screens").GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CloseScreens()
    {
        for (int i = 0; i < 9; i++)
        {
            screensHolder[i].gameObject.SetActive(false);
        }
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
