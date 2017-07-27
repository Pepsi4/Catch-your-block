using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUi : MonoBehaviour
{
    private const float TextShowDelay = 0.1f;

    void ShowTheScore()
    {
        string textScore = "Your score: " + Controller.Score;
        string bestScore = "Best: " + Controller.BestScore;
        StartCoroutine(ShowTheLitters(GameObject.Find("Canvas/EndUi/EndUiScore"), GameObject.Find("Canvas/EndUi/BestScore"), textScore, bestScore));
    }

    public void ActionsInTheEnd()
    {
        RestartButton.EnableTheButton();
        ShowTheScore();
    }

    IEnumerator ShowTheLitters(GameObject obj, string textScore)
    {
        for (int x = 0; x < textScore.Length; x++)
        {
            obj.GetComponent<Text>().text += textScore[x];
            yield return new WaitForSeconds(TextShowDelay);
        }
    }

    IEnumerator ShowTheLitters(GameObject objFirst, GameObject objSecond, string textScoreFirst, string textScoreSecond)
    {
        for (int x = 0; x < textScoreFirst.Length; x++)
        {
            objFirst.GetComponent<Text>().text += textScoreFirst[x];
            yield return new WaitForSeconds(TextShowDelay);
        }

        for (int x = 0; x < textScoreSecond.Length; x++)
        {
            objSecond.GetComponent<Text>().text += textScoreSecond[x];
            yield return new WaitForSeconds(TextShowDelay);
        }
    }
}
