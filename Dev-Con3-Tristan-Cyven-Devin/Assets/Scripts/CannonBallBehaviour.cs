using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBallBehaviour : MonoBehaviour
{
    public float maxLifeTime = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        maxLifeTime -= Time.deltaTime;
        if (maxLifeTime < 0)
        {
            Destroy(gameObject);
        }
    }
}
