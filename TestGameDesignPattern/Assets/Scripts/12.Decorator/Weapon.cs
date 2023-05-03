using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Decorator
{
    public class Weapon : IWeapon
    {
        public float Range
        {
            get { return config.Range; }
        }

        public float Rate
        {
            get { return config.Rate; }
        }

        public float Strength
        {
            get { return config.Strength; }
        }

        public float Cooldown
        {
            get { return config.Cooldown; }
        }



        private readonly WeaponConfig config;

        public Weapon(WeaponConfig weaponConfig)
        {
            config = weaponConfig;
        }
    }
}
