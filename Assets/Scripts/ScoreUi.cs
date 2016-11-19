using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreUi : MonoBehaviour {



    public void EndTheAnimation(string path)
    {
        GameObject.Find(path).GetComponent<Animator>().Stop();
    }

    public void ShowTheScore()
    {
        string textScore = "Your score: " + Controller.Score;
        StartCoroutine(ShowTheLitters(textScore));
    }

    public void ActionsInTheEnd()
    {
        RestartButton.EnableTheButton();
        EndTheAnimation("Canvas/EndUi");
        ShowTheScore();
    }

    IEnumerator ShowTheLitters(string textScore)
    {
        for (int x = 0; x < textScore.Length; x++)
        {
            GameObject.Find("Canvas/EndUiScore").GetComponent<Text>().text += textScore[x];
            yield return new WaitForSeconds(0.1f);
        }
    }


}
