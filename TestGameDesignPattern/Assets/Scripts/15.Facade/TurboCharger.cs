using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Facade
{

    public class TurboCharger : MonoBehaviour
    {
        public BikeEngine engine;
        private bool isTurboOn;
        private CoolingSystem coolingSystem;

        public void ToggleTurbo(CoolingSystem coolingSystem)
        {
            this.coolingSystem = coolingSystem;
            if (!isTurboOn)
            {
                StartCoroutine(TurboCharge());
            }
        }

        IEnumerator TurboCharge()
        {
            isTurboOn = true;
            coolingSystem.PauseCooling();

            yield return new WaitForSeconds(engine.turboDuration);

            isTurboOn = false;
            coolingSystem.PauseCooling();
        }

        private void OnGUI()
        {
            GUI.color = Color.green;
            GUI.Label(new Rect(100, 60, 500, 20), $"Turbe Activated: {isTurboOn}");
        }
    }

}