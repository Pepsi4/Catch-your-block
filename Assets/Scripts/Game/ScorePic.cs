using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScorePic : MonoBehaviour
{

    public static void StartTheAnimation()
    {
        GameObject.Find("Canvas/EndUi").GetComponent<Animator>().Play("EndUi");
    }

    public  void EnableTheScorePic()
    {
        GameObject.Find("Canvas/EndUi").GetComponent<Image>().enabled = true;
    }

    public  void StopTheScorePicAnimation()
    {
        GameObject.Find("Canvas/EndUi").GetComponent<Animator>().Stop();
    }
}


//1) Install Android SDK 2)Set path to Android SDK from Unity Edit->Preferences 3)Exit Unity 4)Connect Android using the USB cable 5)Set the Android device to be using debugging mode 6)Download from Android Market and Launch Unity Remote 7)Launch Unity again 8)????? 9)PROFIT!