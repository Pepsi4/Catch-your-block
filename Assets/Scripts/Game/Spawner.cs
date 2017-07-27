using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour
{
    #region FIELDS and PROPERTIES

    public static float TimeToSpawn { get; set; }

    public const float SpawnTime = 1.3f;
    public const float MinSpawnTime = 0.5f;
    #endregion

    void Start()
    {
        //The start point
        //In the next time, recursion will work here.
        if (Controller.GameActive)
        {
            TimeToSpawn = SpawnTime;
            StartCoroutine(SpawnNewBlock());
        }
    }

    IEnumerator SpawnNewBlock()
    {
        if (Controller.GameActive)
        {
            //W8ing some time
            yield return new WaitForSeconds(Mathf.Sqrt(TimeToSpawn));
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
        float x = Random.Range(-1.85f, 2.15f);
        return x;
    }
}
