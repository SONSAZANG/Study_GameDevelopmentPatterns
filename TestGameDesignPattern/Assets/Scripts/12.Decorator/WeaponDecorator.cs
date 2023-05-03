using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Decorator
{
    public class WeaponDecorator : IWeapon
    {
        private readonly IWeapon decorateWeapon;
        private readonly WeaponAttachment attachment;

        public WeaponDecorator(IWeapon weapon, WeaponAttachment attachment)
        {
            this.attachment = attachment;
            decorateWeapon = weapon;
        }

        public float Rate
        {
            get { return decorateWeapon.Rate + attachment.Rate; }
        }

        public float Range
        {
            get { return decorateWeapon.Range + attachment.Range; }
        }
        
        public float Strength
        {
            get { return decorateWeapon.Strength + attachment.Strength;}
        }

        public float Cooldown
        {
            get { return decorateWeapon.Cooldown + attachment.Cooldown; }
        }
    }
}