using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{

    public GameObject gameoverText;
    public Text timeText;
    public Text recordText;

    private float surviveTime;
    private bool isGameover;

    private string BEST_TIEM = "BestTime";
    private string SAMPLE_SCENE = "SampleScene";


    void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    void Update()
    {
        if (!isGameover)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time : " + (int)surviveTime;
        }
        else
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(SAMPLE_SCENE);
            }
        }

    }

    public void EndGame()
    {
        isGameover = true;
        gameoverText.SetActive(true);

        float bestTime = PlayerPrefs.GetFloat(BEST_TIEM);

        if (surviveTime > bestTime)
        {
            PlayerPrefs.SetFloat(BEST_TIEM, surviveTime);
        }

        recordText.text = "Best Time : " + (int)bestTime;
    }

    public bool GetIsGameover()
    {
        return isGameover;
    }
}
