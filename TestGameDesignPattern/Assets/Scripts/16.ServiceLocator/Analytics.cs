using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.ServiceLocator
{

    public class Analytics : IAnlyticsService
    {
        public void SendEvent(string eventName)
        {
            Debug.Log("Sent: " + eventName);
        }
    }
}