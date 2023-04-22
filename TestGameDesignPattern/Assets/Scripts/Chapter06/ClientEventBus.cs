using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.EventBus
{

    public class ClientEventBus : MonoBehaviour
    {
        private bool isButtonEnabled;

        private void Start()
        {
            gameObject.AddComponent<HUDController>();
            gameObject.AddComponent<CountdownTimer>();
            gameObject.AddComponent<BikeController>();

            isButtonEnabled = true;
        }

        private void OnEnable()
        {
            RaceEventBus.Subscribe(RaceEventType.STOP, Restart);
        }
        private void OnDisable()
        {
            RaceEventBus.Unsubscribe(RaceEventType.STOP, Restart);
        }

        private void Restart()
        {
            isButtonEnabled = true;
        }

        private void OnGUI()
        {
            if (isButtonEnabled)
            {
                if (GUILayout.Button("Start Countdown"))
                {
                    isButtonEnabled = false;
                    RaceEventBus.Publish(RaceEventType.COUNTDOWN);
                }
            }
        }
    }
}
