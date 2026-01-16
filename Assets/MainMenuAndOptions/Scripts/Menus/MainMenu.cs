using JetBrains.Annotations;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    #region Variables
    // mainMenu
    public GameObject BTNStart => this.transform.GetChild(0).gameObject.transform.GetChild(0).gameObject;
    public GameObject BTNLoad => this.transform.GetChild(0).gameObject.transform.GetChild(1).gameObject;
    public GameObject BTNSettings => this.transform.GetChild(0).gameObject.transform.GetChild(2).gameObject;
    public GameObject BTNQuit => this.transform.GetChild(0).gameObject.transform.GetChild(3).gameObject;

    //

    #endregion

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    public void NewGame()
    {
        Debug.Log("Creating Game File");
    }
    public void LoadGame()
    {
        Debug.Log("Load Game");
    }
    public void Options()
    {

    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
