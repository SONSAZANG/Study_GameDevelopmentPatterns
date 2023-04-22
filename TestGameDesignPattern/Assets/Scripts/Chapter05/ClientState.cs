using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.State
{

    public class ClientState : MonoBehaviour
    {
        private BikeController bikeController;

        void Start()
        {
            bikeController = (BikeController) FindObjectOfType(typeof(BikeController));
        }

        private void OnGUI()
        {
            if (GUILayout.Button("Start Bike"))
                bikeController.StartBike();
            if (GUILayout.Button("Turn Left"))
                bikeController.Turn(Direction.Left);
            if (GUILayout.Button("Turn Right"))
                bikeController.Turn(Direction.Right);
            if (GUILayout.Button("Stop Bike"))
                bikeController.StopBike();
        }

    }
}

