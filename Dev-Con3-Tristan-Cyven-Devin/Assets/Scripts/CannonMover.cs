using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMover : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 12f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");

        Vector3 move = new Vector3(x, 0f, 0f);
        controller.Move(move * speed * Time.deltaTime);
    }
}
