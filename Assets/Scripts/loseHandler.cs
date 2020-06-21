using System.Collections.Generic;
using UnityEngine;

namespace UnityTemplateProjects
{
    public class loseHandler : StateHandler
    {
        public void OnEnter(Dictionary<string, object> payload = null)
        {
            Time.timeScale = 0;
        }

        public void OnExit()
        {
            Time.timeScale = 1;
        }
    }
}