using Chapter.Command;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnRight : Command
{
    private BikeController controller;
    public TurnRight(BikeController controller)
    {
        this.controller = controller;
    }

    public override void Execute()
    {
        controller.Turn(BikeController.Direction.Right);
    }
}
