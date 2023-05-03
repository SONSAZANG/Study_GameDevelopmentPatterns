using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BikeController : MonoBehaviour
{
    public enum Direction
    {
        Left = -1,
        Right = 1
    }

    private bool isTurboOn;
    private float distance = 1.0f;

    public void ToggleTurbo()
    {
        isTurboOn = !isTurboOn;
        Debug.Log("Turbo Active: " + isTurboOn.ToString()); 
    }

    public void Turn(Direction direction)
    {
        if (direction == Direction.Left) transform.Translate(Vector3.left * distance);
        if (direction == Direction.Right) transform.Translate(Vector3.right * distance);
    }

    public void ResetPosition()
    {
        transform.position = Vector3.zero;
    }
}
