using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Strategy
{
    public class Drone : MonoBehaviour
    {
        private RaycastHit hit;
        private Vector3 rayDirection;
        private float rayAngle = -45.0f;
        private float rayDistance = 15.0f;

        public float speed = 1.0f;
        public float maxHeight = 5.0f;
        public float weavingDistance = 1.5f;
        public float fallbackDistance = 20.0f;

        private void Start()
        {
            rayDirection = transform.TransformDirection(Vector3.back) * rayDistance;
            rayDirection = Quaternion.Euler(rayAngle, 0.0f, 0f) * rayDirection;
        }

        public void ApplyStrategy(IManeuverBehaviour strategy)
        {
            strategy.Maneuver(this);
        }

        private void Update()
        {
            Debug.DrawRay(transform.position, rayDirection, Color.blue);

            if (Physics.Raycast(transform.position, rayDirection, out hit, rayDistance))
            {
                if (hit.collider)
                {
                    Debug.DrawRay(transform.position, rayDirection, Color.green);
                }
            }
        }
    }
}
