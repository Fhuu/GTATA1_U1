using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxMovement : MonoBehaviour
{
    //The box has 2 components, the box itself and a score validator (scoreChecker)
    public GameObject box, scoreChecker;

    private Vector3 boxPosition, checkerPosition;

    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        //both the box and score validator start at the same point in x axis, only the have different position in y axis,
        //because we want the ball to be validated even before it touches the box
        box.transform.position = new Vector3(0, -1 , 0);
        boxPosition = box.transform.position;
        scoreChecker.transform.position = new Vector3(0, 1 , 0);
        checkerPosition = scoreChecker.transform.position;
        speed = 10;
    }

    //The keyboard to map the positions according to x axis:
    /**
     * 1. S -15
     * 2. D -10
     * 3. F -5
     * 4. SPACE 0
     * 5. J 5
     * 6. K 10
     * 7. L 15
     */
    // Update is called once per frame  
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            box.transform.position = new Vector3(-15, boxPosition.y, boxPosition.z);
            boxPosition = box.transform.position;
            scoreChecker.transform.position = new Vector3(-15, checkerPosition.y, checkerPosition.z);
            checkerPosition = scoreChecker.transform.position;
        }

        if (Input.GetKey(KeyCode.D))
        {
            box.transform.position = new Vector3(-10, boxPosition.y, boxPosition.z);
            boxPosition = box.transform.position;
            scoreChecker.transform.position = new Vector3(-10, checkerPosition.y, checkerPosition.z);
            checkerPosition = scoreChecker.transform.position;
        }
        if (Input.GetKey(KeyCode.F))
        {
            box.transform.position = new Vector3(-5, boxPosition.y, boxPosition.z);
            boxPosition = box.transform.position;
            scoreChecker.transform.position = new Vector3(-5, checkerPosition.y, checkerPosition.z);
            checkerPosition = scoreChecker.transform.position;
        }
        if (Input.GetKey(KeyCode.Space))
        {
            box.transform.position = new Vector3(0, boxPosition.y, boxPosition.z);
            boxPosition = box.transform.position;
            scoreChecker.transform.position = new Vector3(0, checkerPosition.y, checkerPosition.z);
            checkerPosition = scoreChecker.transform.position;
        }
        if (Input.GetKey(KeyCode.J))
        {
            box.transform.position = new Vector3(5, boxPosition.y, boxPosition.z);
            boxPosition = box.transform.position;
            scoreChecker.transform.position = new Vector3(5, checkerPosition.y, checkerPosition.z);
            checkerPosition = scoreChecker.transform.position;
        }
        if (Input.GetKey(KeyCode.K))
        {
            box.transform.position = new Vector3(10, boxPosition.y, boxPosition.z);
            boxPosition = box.transform.position;
            scoreChecker.transform.position = new Vector3(10, checkerPosition.y, checkerPosition.z);
            checkerPosition = scoreChecker.transform.position;
        }
        if (Input.GetKey(KeyCode.L))
        {
            box.transform.position = new Vector3(15, boxPosition.y, boxPosition.z);
            boxPosition = box.transform.position;
            scoreChecker.transform.position = new Vector3(15, checkerPosition.y, checkerPosition.z);
            checkerPosition = scoreChecker.transform.position;
        }
    }
} 
