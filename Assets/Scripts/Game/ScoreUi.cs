using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUi : MonoBehaviour
{
    private const float TextShowDelay = 0.1f;



    //private ScorePic scr;
    //private void EnableTheUiScoreText()
    //{
    //    GameObject.Find("Canvas/EndUiScore").GetComponent<>()
    //}


     void ShowTheScore()
    {
        string textScore = "Your score: " + Controller.Score;
        StartCoroutine(ShowTheLitters(textScore));
    }

    public void ActionsInTheEnd()
    {
        RestartButton.EnableTheButton();
        //ScorePic.StartTheAnimation();
        ShowTheScore();
    }

    IEnumerator ShowTheLitters(string textScore)
    {
        for (int x = 0; x < textScore.Length; x++)
        {
            GameObject.Find("Canvas/EndUi/EndUiScore").GetComponent<Text>().text += textScore[x];
            yield return new WaitForSeconds(TextShowDelay);
        }
    }

    


}
