using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    #region FIELDS and PROPERTIES

    private static float time = 1.3f;

    public static float TimeToSpawn
    {
        get { return time; }
        set { time = value; }
    }




    #endregion


    void Start()
    {
        //The start point
        //In the next time, recursion will work here.
        if (Controller.GameActive)
        {
            StartCoroutine(SpawnNewBlock());
        }
    }

    IEnumerator SpawnNewBlock()
    {
        if (Controller.GameActive)
        {
        //W8ing some time
        yield return new WaitForSeconds(time);
        //load the obj
        GameObject block = (GameObject)Resources.Load("Prefabs/Block");
        //gives to the obj random position
        block.transform.position = new Vector3(GeneratePositionX(), block.transform.position.y, block.transform.position.z);
        //creating the prefab
        Instantiate(block);
        //Recursion
        StartCoroutine("SpawnNewBlock");
        }

    }

    float GeneratePositionX()
    {
        float z = Random.Range(-1.85f, 2.15f);
        return z;
    }



   




}
