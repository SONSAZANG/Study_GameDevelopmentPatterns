using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Observer
{
    public class ClientObserver : MonoBehaviour
    {
        private BikeController bikeController;
        private void Start()
        {
            bikeController = (BikeController)FindObjectOfType(typeof(BikeController));
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Damage Bike"))
            {
                if (bikeController)
                {
                    bikeController.TakeDamage(15.0f);
                }
            }

            if (GUILayout.Button("Toggle Turbo"))
            {
                if (bikeController)
                {
                    bikeController.ToggleTurbe();
                }
            }
        }
    }
}
