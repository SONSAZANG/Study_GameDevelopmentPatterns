using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Chapter.Command
{
    public abstract class Command
    {
        public abstract void Execute();
    }

    public class ToggleTurbo : Command
    {
        private BikeController controller;

        public ToggleTurbo(BikeController controller)
        {
            this.controller = controller;
        }

        public override void Execute()
        {
            this.controller.ToggleTurbo();
        }
    }
}
