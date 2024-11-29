using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{
    //Sensestivity
    public float senX = 100f;
    public float senY = 100f;

    public Transform cannonMove;
    //Roatations of the x and y axis
    float xRotation = 0f;
    float yRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        //This will lock the cursor to the center of the screen and make it invisible
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        //Gets the input for mouse movement
        float lookX = Input.GetAxisRaw("Mouse X") * senX * Time.deltaTime; 
        float lookY = Input.GetAxisRaw("Mouse Y") * senY * Time.deltaTime;

        yRotation += lookX; //X mouse movement
        yRotation = Mathf.Clamp(yRotation, -90f, 90f); 

        xRotation -= lookY;//Y mouse movement
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        //Rotates the camera
        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        cannonMove.rotation = Quaternion.Euler(0f, yRotation, 0f);


    }
}
