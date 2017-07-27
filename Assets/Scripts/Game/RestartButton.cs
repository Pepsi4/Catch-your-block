using UnityEngine;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{
    void Start()
    {
        GameObject.Find("Canvas/EndUi/Restart").GetComponent<Button>().onClick.AddListener(() => { ClickActions(); });
        DisableTheButton();
    }

    public static void DisableTheButton()
    {
        GameObject.Find("Canvas/EndUi/Restart").GetComponent<Button>().enabled = false;
        GameObject.Find("Canvas/EndUi/Restart").GetComponent<Image>().enabled = false;
    }

    public static void EnableTheButton()
    {
        GameObject.Find("Canvas/EndUi/Restart").GetComponent<Button>().enabled = true;
        GameObject.Find("Canvas/EndUi/Restart").GetComponent<Image>().enabled = true;
    }

    void ClickActions()
    {
        RestartTheGame();
        Spawner.TimeToSpawn = Spawner.SpawnTime;
        Controller.GameActive = true;
        Controller.Lifes = 3;
        Controller.Score = 0;
    }

    private void RestartTheGame()
    {
        Application.LoadLevel(1);
    }
}
