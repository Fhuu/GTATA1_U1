using System;
using System.Collections.Generic;

namespace UnityTemplateProjects
{
    public interface StateHandler
    {
        void OnEnter(Dictionary<String, Object> payload = null);
        void OnExit();
    }
}