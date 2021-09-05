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



    void Start()
    {
        surviveTime = 0;
        isGameover = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameover)
        {
            surviveTime += Time.deltaTime;
            timeText.text = "Time : " + (int)surviveTime;
            Debug.Log(timeText.text);
        }

    }

    public void EndGame()
    {

    }
}
