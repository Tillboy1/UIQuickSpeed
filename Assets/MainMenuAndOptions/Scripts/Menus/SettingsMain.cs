using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;

public class SettingsMain : MonoBehaviour
{
    static SettingsMain instance;

    public GameObject[] screensHolder = new GameObject[9];

    void Start()
    {
        for (int i = 0; i < transform.Find("Screens").childCount; i++)
        {
            screensHolder[i] = transform.Find("Screens").GetChild(i).gameObject;
        }
    }

    public void CloseScreens()
    {
        for (int i = 0; i < 9; i++)
        {
            screensHolder[i].gameObject.SetActive(false);
        }
    }
}