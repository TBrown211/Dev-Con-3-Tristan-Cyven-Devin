using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{

    public float sensitivity;

    public Transform cannonMove;
    public Camera cam;

    [SerializeField]
    float xRotation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float lookX = Input.GetAxis("Mouse X") * sensitivity * Time.deltaTime;
        float lookY = Input.GetAxis("Mouse y") * sensitivity * Time.deltaTime;

    }
}
