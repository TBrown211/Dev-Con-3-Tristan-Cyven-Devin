using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public float timeCount;
    public int health = 3;
    public int playerScore;

    public GameObject TimerText;
    public GameObject HealthDisplay1;
    public GameObject HealthDisplay2;
    public GameObject HealthDisplay3;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        TimerText.GetComponent<TMP_Text>().text = timeCount.ToString("N");

        if (health <= 0)
        {
            health = 0;
            Debug.Log("Game Over!");
        }
        else if (health < 1)
        {
            HealthDisplay1.SetActive(false);
        }
        else if (health < 2)
        {
            HealthDisplay2.SetActive(false);
        }
        else if (health < 3)
        {
            HealthDisplay3.SetActive(false);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("kill"))
        {
            health--;
        }
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("currentScore", playerScore);
    }
}
