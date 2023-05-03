using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Facade
{
    public class CoolingSystem : MonoBehaviour
    {
        public BikeEngine engine;
        public IEnumerator coolEngine;
        private bool isPaused;

        private void Start()
        {
            coolEngine = CoolEngine();
        }

        public void PauseCooling()
        {
            isPaused = !isPaused;
        }

        public void ResetTemperature()
        {
            engine.currentTemp = 0.0f;
        }

        IEnumerator CoolEngine()
        {
            while (true)
            {
                yield return new WaitForSeconds(1);

                if (!isPaused)
                {
                    if (engine.currentTemp > engine.minTemp)
                        engine.currentTemp -= engine.tempRate;
                    if (engine.currentTemp < engine.minTemp)
                        engine.currentTemp += engine.tempRate;
                }
                else
                {
                    engine.currentTemp += engine.tempRate;
                }

                if (engine.currentTemp > engine.maxTemp)
                    engine.TurnOff();
            }
        }

        private void OnGUI()
        {
            GUI.color = Color.green;
            GUI.Label(new Rect(100, 20, 500, 20), $"Temp: {engine.currentTemp}");
        }
    }
}