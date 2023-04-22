using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Visitor
{
    public class BikeController : MonoBehaviour, IBikeElement
    {
        private List<IBikeElement> bikeElements = new List<IBikeElement>();

        private void Start()
        {
            bikeElements.Add(gameObject.AddComponent<BikeShield>());
            bikeElements.Add(gameObject.AddComponent<BikeWeapon>());
            bikeElements.Add(gameObject.AddComponent<BikeEngine>());
        }

        public void Accept(IVisitor visitor)
        {
            foreach (IBikeElement element in bikeElements)
            {
                element.Accept(visitor);
            }
        }
    }
}
