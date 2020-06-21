using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class AddScore : MonoBehaviour
{
    //Trigger event when something is colliding with the score validator
    private void OnTriggerEnter(Collider other)
    {
        //Add score when a collision is detected
        Score.addScore();
        //Destroy any object collided with the validator
        Destroy(other.GetComponent<Collider>().gameObject);
    }
}
