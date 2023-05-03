using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Chapter.Command
{
    public class TurnLeft : Command
    {
        private BikeController controller;
        public TurnLeft(BikeController controller)
        {
            this.controller = controller;
        }

        public override void Execute()
        {
            controller.Turn(BikeController.Direction.Left);
        }
    }
}
