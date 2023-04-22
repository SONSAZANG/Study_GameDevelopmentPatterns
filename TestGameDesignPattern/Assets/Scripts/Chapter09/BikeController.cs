using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Observer
{
    public class BikeController : Subject
    {
        public bool IsTurboOn
        {
            get; private set;
        }

        public float CurrentHealth
        {
            get { return health; }
        }

        private bool isEngineOn;
        private HUDController hudContoller;
        private CameraController cameraController;

        [SerializeField]
        private float health = 100.0f;

        private void Awake()
        {
            hudContoller = gameObject.AddComponent<HUDController>();
            cameraController = (CameraController)FindObjectOfType(typeof(CameraController));
        }

        private void Start()
        {
            StartEngine();
        }

        private void OnEnable()
        {
            if (hudContoller)
            {
                Attach(hudContoller);
            }

            if (cameraController)
            {
                Attach(cameraController);
            }
        }

        private void OnDisable()
        {
            if (hudContoller)
            {
                Detach(hudContoller);
            }

            if (cameraController)
            {
                Detach(cameraController);
            }
        }

        private void StartEngine()
        {
            isEngineOn = true;
            NotifyObservers();
        }

        public void ToggleTurbe()
        {
            if (isEngineOn)
            {
                IsTurboOn = !IsTurboOn;
            }

            NotifyObservers();
        }

        public void TakeDamage(float amount)
        {
            health -= amount;
            IsTurboOn = false;

            NotifyObservers();

            if (health < 0)
            {
                Destroy(gameObject);
            }
        }
    }
}
