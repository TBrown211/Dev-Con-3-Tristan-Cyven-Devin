using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{
    public float timeCount;
    public int health;
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
                        // make die happen
                    }
                }
            }
        }
    }

    void OnDisable()
    {
        PlayerPrefs.SetInt("currentScore", playerScore);
    }
}
