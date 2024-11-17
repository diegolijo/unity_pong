using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class GameManager : MonoBehaviour
{

    public int scorePL;
    public int scorePR;

    [SerializeField] TextMeshProUGUI scoreTextPL;
    [SerializeField] TextMeshProUGUI scoreTextPR;

    [SerializeField] GameObject ball;
    public bool isPlaying = false;

    public void addScoreR()
    {
        scorePR++;
    }
    public void addScoreL()
    {
        scorePL++;
    }

    void Start()
    {
        scorePL = 0;
        scorePR = 0;
        Cursor.visible = false;
    }


    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Space) && !isPlaying)
        {
            ball.SetActive(true);
            isPlaying = true;
        }

    }
    void OnGUI()
    {
        scoreTextPL.text = scorePL.ToString();
        scoreTextPR.text = scorePR.ToString();
    }
}
