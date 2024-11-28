using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{

    public float senX = 100f;
    public float senY = 100f;

    public Transform cannonMove;

    float xRotation = 0f;
    float yRotation = 0f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        float lookX = Input.GetAxisRaw("Mouse X") * senX * Time.deltaTime;
        float lookY = Input.GetAxisRaw("Mouse Y") * senY * Time.deltaTime;

        yRotation += lookX;
        yRotation = Mathf.Clamp(yRotation, -90f, 90f);

        xRotation -= lookY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.rotation = Quaternion.Euler(xRotation, yRotation, 0f);
        cannonMove.rotation = Quaternion.Euler(0f, yRotation, 0f);


    }
}
