using UnityEngine;
using UnityEngine.UI;

public class RestartButton : MonoBehaviour
{

    void Start()
    {
        GameObject.Find("Canvas/Restart").GetComponent<Button>().onClick.AddListener(() => { ClickActions(); });
        DisableTheButton();
    }

    public static void DisableTheButton()
    {
        GameObject.Find("Canvas/Restart").GetComponent<Button>().enabled = false;
        GameObject.Find("Canvas/Restart").GetComponent<Image>().enabled = false;
        GameObject.Find("Canvas/Restart/Text").GetComponent<Text>().enabled = false;
    }

    public static void EnableTheButton()
    {
        GameObject.Find("Canvas/Restart").GetComponent<Button>().enabled = true;
        GameObject.Find("Canvas/Restart").GetComponent<Image>().enabled = true;
        GameObject.Find("Canvas/Restart/Text").GetComponent<Text>().enabled = true;
    }

    void ClickActions()
    {
        RestartTheGame();
    }

    private void RestartTheGame()
    {
        Application.LoadLevel(1);
    }

    



}
