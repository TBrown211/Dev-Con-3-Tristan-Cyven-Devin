using System.Collections;
using System.Collections.Generic;
using System.Threading;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HighScores : MonoBehaviour
{

    public float scoreCurrent;

    public string scoreBoard;

    public bool scoreSet;

    public string currentScore;
    public float checkedScore = 0;
    public float lastScore;
    public float[] scoreArray = new float[10];

    // Start is called before the first frame update
    void Start()
    {
        scoreSet = false;
        scoreCurrent = PlayerPrefs.GetFloat("currentScore");

        for (int i = 0; i < 10; i++)
        {
            lastScore = checkedScore;
            currentScore = ("score" + i.ToString());
            checkedScore = PlayerPrefs.GetFloat(currentScore);
            if (scoreSet == true)
            {
                scoreArray[i] = lastScore;
            }
            else if (checkedScore > scoreCurrent)
            {
                scoreArray[i] = checkedScore;
            }
            else if (checkedScore <= scoreCurrent)
            {
                scoreArray[i] = scoreCurrent;
                scoreSet = true;
            }
        }

        scoreBoard = scoreArray[0].ToString("N") + "\n" +
        scoreArray[1].ToString("N") + "\n" + scoreArray[2].ToString("N") + "\n" + scoreArray[3].ToString("N") + "\n" +
        scoreArray[4].ToString("N") + "\n" + scoreArray[5].ToString("N") + "\n" + scoreArray[6].ToString("N") + "\n" +
        scoreArray[7].ToString("N") + "\n" + scoreArray[8].ToString("N") + "\n" + scoreArray[9].ToString("N") + "\n" + "\n" +
        "Your score: " + scoreCurrent.ToString("N");

        GetComponent<TMP_Text>().text = scoreBoard;

        for (int i = 0; i < 10; i++)
        {
            PlayerPrefs.SetFloat("score" + i.ToString(), scoreArray[i]);
        }
    }

        // Update is called once per frame
        void Update()
        {
            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }
