using UnityEngine;
using UnityEngine.Rendering.Universal;
using UnityEngine.Rendering;
using Unity.VisualScripting;
using System.Linq;
using UnityEngine.UIElements;
using System.Collections.Generic;
using UnityEngine.Audio;
using TMPro;
using UnityEngine.UI;

public class SettingsMain : MonoBehaviour
{
    public GameObject[] screensHolder = new GameObject[9];
    string TempString;

    public KeyCode[] keycodes = new KeyCode[12];
    bool WaitingForEvent;
    KeyCode newKey;
    Event KeyEvent;

    Dropdown resalutionDropdown;
    Resolution[] resolutions;

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

    public void ChangeVisualSettings(int settinglevel)
    {
        QualitySettings.SetQualityLevel(settinglevel);
    }
    public void ChangeRenderScale(float scale)
    {
        UniversalRenderPipelineAsset pipeline = GraphicsSettings.currentRenderPipeline as UniversalRenderPipelineAsset;
    }

    // - - - - - - - - - - - - - - - - - - - - - - - - - - - - - -  KeyBinds Changing

    public void ChangeKeybinds(string UseName)
    {
        //gets inputed key to be used later
        WaitingForEvent = true;
        TempString = UseName;
    }

    public void Keychange()
    {
        switch (TempString)
        {
            case "CharacterSheet":
                keycodes[0] = newKey;
                break;
            case "Inventory":
                keycodes[1] = newKey;
                break;
            case "QuickSlots":
                keycodes[2] = newKey;
                break;
            case "CloseScreens":
                keycodes[3] = newKey;
                break;
            case "OpenMenu":
                keycodes[4] = newKey;
                break;
            case "Interact":
                keycodes[5] = newKey;
                break;
            case "Pickup":
                keycodes[6] = newKey;
                break;
            case "Jump":
                keycodes[7] = newKey;
                break;
            case "Sprint":
                keycodes[8] = newKey;
                break;
            case "Crouch":
                keycodes[9] = newKey;
                break;
            case "Voice":
                keycodes[10] = newKey;
                break;
            case "Lying":
                keycodes[11] = newKey;
                break;
        }
        
        KeyBindLoad();
    }

    public void KeyBindLoad() // changes UI TEXT
    {
        //Transform KeybindsScreen = this.transform.GetChild(1).transform.GetChild(3).transform.GetChild(1).transform;

        #region KeyToText
        //KeybindList[0].transform.GetChild(0).GetComponent<Text>().text = Player.GetComponent<PlayerMovement>().jumpkey.ToString();
        //KeybindList[1].transform.GetChild(0).GetComponent<Text>().text = Player.GetComponent<PlayerMovement>().sprintkey.ToString();
        //KeybindList[2].transform.GetChild(0).GetComponent<Text>().text = Player.GetComponent<PlayerMovement>().crouchkey.ToString();
        //KeybindList[3].transform.GetChild(0).GetComponent<Text>().text = Player.GetComponent<SelectionManager>().interactkey.ToString();
        //KeybindList[4].transform.GetChild(0).GetComponent<Text>().text = Player.GetComponent<SelectionManager>().Pickupkey.ToString();
        //KeybindList[5].transform.GetChild(0).GetComponent<Text>().text = Manager.transform.GetChild(1).GetComponent<BasicVoice>().voiceKey.ToString();
        //KeybindList[6].transform.GetChild(0).GetComponent<Text>().text = Manager.transform.GetChild(1).GetComponent<BasicVoice>().FalsevoiceKey.ToString();
        //KeybindList[7].transform.GetChild(0).GetComponent<Text>().text = Player.GetComponent<Player>().InventoryKey.ToString();
        //KeybindList[8].transform.GetChild(0).GetComponent<Text>().text = Player.GetComponent<Player>().CharacterSheetKey.ToString();
        //KeybindList[9].transform.GetChild(0).GetComponent<Text>().text = Player.GetComponent<Player>().QuickEquipKey.ToString();
        //KeybindList[10].transform.GetChild(0).GetComponent<Text>().text = Player.GetComponent<Player>().GoToMenuKey.ToString();
        //KeybindList[11].transform.GetChild(0).GetComponent<Text>().text = Player.GetComponent<Player>().CloseScreensKey.ToString();
        #endregion
    }

    private void OnGUI()
    {
        KeyEvent = Event.current;

        if (KeyEvent.isKey && WaitingForEvent)
        {
            if(KeyEvent.keyCode == KeyCode.Escape)
            {
                newKey = KeyCode.None;
            }
            else
            {
                newKey = KeyEvent.keyCode;
            }
            WaitingForEvent = false;
            Keychange();
        }
    }
}