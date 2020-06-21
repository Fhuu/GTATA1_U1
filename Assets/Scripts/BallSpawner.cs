using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallSpawner : MonoBehaviour
{

    //The timer, time limit, the timer for leveling up the difficulty, and the time limit for leveling up
    private float timer,timeLimit, levelUpTimer, levelUpTimeLimit;
    public GameObject ball, levelSlider;
    private float level;

    // Start is called before the first frame update
    void Start()
    {
        timer = 0;
        levelUpTimer = 0;
        levelUpTimeLimit = 10;
        level = 0;
        timeLimit = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (levelUpTimer > levelUpTimeLimit)
        {
            if (timeLimit != 0.4f) timeLimit -= 0.1f;
            levelUpTimer = 0;
        }
        
        //when the timer reach the time limit,
        //a new ball will be instantiate with random position in x(whether it is below 0, 0 or above 0) axis and 25 in y axis.
        //UseGravity should be changed to true,
        //because the model has rigidbody component and useGravity is turned off because we dont want the model to move anywhere near the camera by accident.
        if (timer > timeLimit)
        {
            GameObject newBall = Instantiate(ball);
            newBall.transform.position = new Vector3(Random.Range(-1,2) * RandomPosition(), 25, 0);
            newBall.GetComponent<Rigidbody>().useGravity = true;
            timer = 0;
        }
        
        timer += Time.deltaTime;
    }

    //To generate where the ball would be placed, this will gives out 5 to 15
    int RandomPosition()
    {
        return Random.Range(1, 4) * 5;
    }

    public void changeLevel(float value)
    {
        timeLimit = 1 - 0.1f * Mathf.Round(value);
    }
}
