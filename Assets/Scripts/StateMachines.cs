using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine.SceneManagement;
using UnityEngine;
using UnityTemplateProjects;
using Random = UnityEngine.Random;

public class StateMachines : MonoBehaviour
{
    private State currentState;
    private StateHandler startHandler;
    private StateHandler loseHandler;
    private StateHandler gameOverHandler;
    private StateHandler currentStateHandler;

    public void Reset()
    {
        currentState = State.Begin;
    }

    public void RegisterHandler()
    {
        switch (currentState)
        {
            case State.Begin : 
                gameOverHandler.OnExit();
                startHandler.OnEnter();
                break;
            case State.Playing : 
                startHandler.OnExit();
                loseHandler.OnEnter();
                break;
            case State.GameOver:
                loseHandler.OnExit();
                gameOverHandler.OnEnter();
                break;
        }
    }

    public bool Trigger(Transition triggerType, Dictionary<String, object> payload = null)
    {
        switch (triggerType)
        {
            case Transition.StartPressed:
                if (currentState == State.Begin)
                {
                    TransitionTo(State.Playing, payload);
                    return true;
                }
                
                return false;
            case Transition.UncaughtBall:
                if (currentState == State.Playing)
                {
                    TransitionTo(State.GameOver, payload);
                    return true;
                }
                
                return false;
            case Transition.ReplayPressed:
                if (currentState == State.GameOver)
                {
                    TransitionTo(State.Begin, payload);
                    return true;
                }

                return false;
        }

        return false;
    }

    private void TransitionTo(State newState, Dictionary<String, object> payload)
    {
        if (newState == currentState) return;
        var currentHandler = GetHandler(currentState);
        var nextHandler = GetHandler(newState);

        currentHandler?.OnExit();
        nextHandler?.OnEnter(payload);

        currentState = newState;
    }

    private StateHandler GetHandler(State forState)
    {
        switch (forState)
        {
            case State.Begin:
                return startHandler;
            case State.Playing :
                return loseHandler;
            case State.GameOver :
                return gameOverHandler;
        }

        return null;
    }

}
