using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BlockScript : MonoBehaviour
{
    #region FIELDS

    private Transform blockTransform;

    private int lifes;

    private int minLifes = 1; //inclusive
    private int maxLifex = 4; //exclusive

    #endregion


    void Start()
    {
        //looks like a constructor
        blockTransform = this.GetComponent<Transform>();
        lifes = Random.Range(1, 4);
        //start color
        ChangeTheColor();


    }

    void ChangeTheColor()
    {
        //color of the go
        switch (lifes)
        {
            case 1:
                this.gameObject.GetComponent<MeshRenderer>().material = (Material)Resources.Load("Materials/BlueLight");
                break;

            case 2:
                this.gameObject.GetComponent<MeshRenderer>().material = (Material)Resources.Load("Materials/BlueMiddle");
                break;

            case 3:
                this.gameObject.GetComponent<MeshRenderer>().material = (Material)Resources.Load("Materials/BlueHight");
                break;
        }
    }

    private void Update()
    {
        //moving the obj
        blockTransform.position = new Vector3(blockTransform.position.x, blockTransform.position.y,
            blockTransform.position.z - 0.1f);

        if (gameObject.transform.position.z < -16)
        {
            DestroyTheLife();
        }




        //
    }


    //destroy the block, if it is so far away
    //void OnBecameInvisible()
    //{
    //    DestroyTheLife();
    //}
    

    void OnMouseDown()
    {
        if (Input.GetMouseButton(0))
        {
            //Less and less time to spawning new block
            Spawner.TimeToSpawn *= 0.96f;

            lifes--;
            ChangeTheColor();

            if (lifes <= 0)
            {
                //just hideing the object
                //it will be destroyed later
                Controller.Score++;
                Controller.UpdateTheScoreUi();
                Destroy(this.gameObject);
            }
        }
    }

    void DestroyTheLife()
    {
        
        if (GameObject.Find("Canvas/HealthImage (1)"))
        {
            StartCoroutine(UpdateTheHealthUi(1));
        }
        else if (GameObject.Find("Canvas/HealthImage (2)"))
        {
            StartCoroutine(UpdateTheHealthUi(2));
        }
        else if (GameObject.Find("Canvas/HealthImage (3)"))
        {
            StartCoroutine(UpdateTheHealthUi(3));
        }

        
    }

    IEnumerator UpdateTheHealthUi(int lifeNumber)
    {
        yield return new WaitForSeconds(0.01f);
        
        GameObject.Find("Canvas/HealthImage (" + lifeNumber + ")").GetComponent<Image>().fillAmount -= 0.01f;

        if (GameObject.Find("Canvas/HealthImage (" + lifeNumber + ")").GetComponent<Image>().fillAmount > 0)
        {
            StartCoroutine(UpdateTheHealthUi(lifeNumber));
        }
        else
        {
            Destroy(GameObject.Find("Canvas/HealthImage (" + lifeNumber + ")"));
            Controller.Lifes--;
            Destroy(this.gameObject);
        }
    }
    





}
