using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int Playerhealth = 3; 

    private void OnCollisionEnter(Collision collision)
    {
       
        if (collision.gameObject.CompareTag("kill"))
        {
            
            Playerhealth--;

            
            if (Playerhealth <= 0)
            {
                Debug.Log("Game Over!");
                
            }
            else
            {
                Debug.Log("Health: " + Playerhealth);
            }
        }
    }
}
