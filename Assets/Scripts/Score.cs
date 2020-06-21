using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    
    private static int score;

    void Start()
    {
        score = 0;
    }

    //Prints the value of score variable into text in canvas
    void Update()
    {
        GetComponent<UnityEngine.UI.Text>().text = "Score :" + score.ToString();
    }

    //adds score one by one
    public static void addScore()
    {
        score++;
    }

    //gets the value of the score
    public static int GetScore()
    {
        return score;
    }
}
