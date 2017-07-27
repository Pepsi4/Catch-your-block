using UnityEngine;
using UnityEngine.UI;

public class Controller : MonoBehaviour
{
    #region FIELDS and PROPERTIES

    public static int BestScore { get; set; }

    private static int lifes = 3;

    public static int Lifes
    {
        get { return lifes; }
        set { lifes = value; }
    }

    private static int score = 0;

    public static int Score
    {
        get { return score; }
        set { score = value; }
    }

    private static bool gameActive = true;

    public static bool GameActive
    {
        get { return gameActive; }
        set { gameActive = value; }
    }
    #endregion

    public static void UpdateTheScoreUi()
    {
        GameObject.Find("Canvas/ScoreText").GetComponent<Text>().text = score.ToString();
    }
}
