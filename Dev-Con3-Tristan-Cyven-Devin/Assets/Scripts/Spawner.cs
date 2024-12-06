using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;
using UnityEngine.UIElements;

public class Spawner : MonoBehaviour
{
    public GameObject killSphere;
    public GameObject currentBall;
    public float spawnTime;
    public float spawnTime2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(RandomSP());

        //if (Input.GetKeyDown(KeyCode.Q))
        // {
        //Instantiate(killSphere, transform.position, Quaternion.identity);
        //}
    }
    private IEnumerator RandomSP()
    {
        spawnTime = Random.Range(1, 5);

        yield return new WaitForSeconds(spawnTime);

        if (currentBall == null)
        {
           
            currentBall = Instantiate(killSphere, transform.position, Quaternion.identity);

            spawnTime2 = Random.Range(4, 7);
            Destroy(currentBall, spawnTime2);

            if (killSphere == null)
            {
                killSphere = Instantiate(killSphere, transform.position, Quaternion.identity);
                Destroy(killSphere, spawnTime);
            }
        }

        spawnTime = Random.Range(1,5);

        yield return new WaitForSeconds(spawnTime);

        

    }
}
