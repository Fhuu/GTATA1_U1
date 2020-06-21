using System;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace UnityTemplateProjects
{
    public class GameManager : MonoBehaviour
    {
        private enum States
        {
            Begin, Play, GameOver
        }

        private States _state;
        private StateMachines _stateMachines;
        public GameObject ball, StartUI, LoseUI, score;
        private Transition currentTransition;

        void Start()
        {
            /*_stateMachines.Reset();
            _stateMachines.RegisterHandler();*/
            _state = States.Begin;
            Time.timeScale = 0;
            StartUI.SetActive(true);
            LoseUI.SetActive(false);
            score.SetActive(false);
        }

        private void Update()
        {
            switch (_state)
            {
                case States.Play :
                    Playing();
                    break;
                case States.GameOver : 
                    GameOver();
                    break;
                case States.Begin : 
                    Start();
                    break;
            }
        }

        public void Play()
        {
            currentTransition = Transition.StartPressed;
            
            _state = States.Play;
        }

        private void Playing()
        {
            Time.timeScale = 1;
            LoseUI.SetActive(false);
            StartUI.SetActive(false);
            score.SetActive(true);
        }

        public void Replay()
        {
            currentTransition = Transition.ReplayPressed;
            SceneManager.LoadScene(0);
        }

        private void GameOver()
        {
            LoseUI.SetActive(true);
            Time.timeScale = 0;
        }

        private void OnTriggerEnter(Collider other)
        {
            currentTransition = Transition.UncaughtBall;
            _state = States.GameOver;
        }
    }
}