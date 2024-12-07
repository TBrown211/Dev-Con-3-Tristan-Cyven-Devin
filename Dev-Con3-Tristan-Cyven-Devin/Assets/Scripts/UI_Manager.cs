using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        health = 3;
    }

    // Update is called once per frame
    void Update()
    {
        timeCount += Time.deltaTime;
        TimerText.GetComponent<TMP_Text>().text = timeCount.ToString("N");

      

        if (health < 3)
        {
            HealthDisplay3.SetActive(false);

            if (health < 2)
            {
                HealthDisplay2.SetActive(false);

                if (health < 1)
                {
                    HealthDisplay1.SetActive(false);
                    
                    if (health < 0)
                    {
                        Debug.Log("Game Over!");
                        SceneManager.LoadScene("DeathScreen");
                    }
                }
            }
        }
        if (Input.GetKeyDown(KeyCode.Keypad8))
        {
            for (int i = 0; i < 10; i++)
            {
                PlayerPrefs.SetFloat("score" + i.ToString(), 0);
            }
        }
    }


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("kill"))
        {
            health--;
        }
        Destroy(collision.gameObject);
    }

    void OnDisable()
    {
        PlayerPrefs.SetFloat("currentScore", timeCount);
    }
}
