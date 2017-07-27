using UnityEngine;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
    void Start()
    {
        //Start button
        GameObject.Find("Canvas/Start").GetComponent<Button>().onClick.AddListener(() => { LoadTheGame(); });
        //Settings
        //GameObject.Find("Canvas/Settings").GetComponent<Button>().onClick.AddListener(() => { LoadSetting(); });
        //Exit
        GameObject.Find("Canvas/Exit").GetComponent<Button>().onClick.AddListener(() => { Exit(); });
    }

    void LoadTheGame()
    {
        Application.LoadLevel("GameScene");
    }

    void LoadSetting()
    {
        Application.LoadLevel("SettingsScene");
    }

    void Exit()
    {
        Application.Quit();
    }
}
