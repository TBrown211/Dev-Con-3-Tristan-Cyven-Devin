using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour
{
    public GameObject cannonBallPreFab;

    public float shootForce;

    public float timeBetweenShooting;
    public float timeBetweenShots;

    public Camera cannonCam;
    public Transform attackPoint;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            ShootCannon();
        }
    }

    void ShootCannon()
    {
        Ray ray = cannonCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
        RaycastHit hit;

        Vector3 targetPoint;
        if (Physics.Raycast(ray,out hit))
        {
            targetPoint = hit.point;
        }
        else
        {
            targetPoint = ray.GetPoint(75);
        }

        Vector3 cannonBallDirection = targetPoint - attackPoint.position;

        GameObject newCannonBall = Instantiate(cannonBallPreFab, attackPoint.position, Quaternion.identity);
        newCannonBall.transform.forward = cannonBallDirection.normalized;

        newCannonBall.GetComponent<Rigidbody>().AddForce(cannonBallDirection.normalized * shootForce, ForceMode.Impulse);
    }
}
