using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannonManager_Test : MonoBehaviour
{
    private bool isPressingMouse = false;
    private Camera cam;
    


    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            isPressingMouse = true;

            if (Input.GetMouseButtonUp(0)) //cannon should stop moving on release but does not for some reason
            {

                isPressingMouse = false;
            }
        }

        if (isPressingMouse)
        {
            RCannonToMouse();
        }
            
    }
    private void RCannonToMouse()
    {
        Vector3 mouseLocation = Input.mousePosition;
        mouseLocation.z = Mathf.Abs(cam.transform.position.z - transform.position.z); 

        Vector3 worldPosition = cam.ScreenToWorldPoint(mouseLocation); 
        Vector3 direction = worldPosition - transform.position; 
        direction.z = 0; 

        
        transform.up = direction; 
    }
}
