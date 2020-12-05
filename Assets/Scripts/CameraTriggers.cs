using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraTriggers : MonoBehaviour
{
    CameraMoveControl cameraMoveControl;
    [SerializeField] bool DirectionRight;
    [SerializeField] bool DirectionLeft;

    void Start()
    {
        cameraMoveControl = FindObjectOfType<CameraMoveControl>();
        if (DirectionRight && DirectionLeft)
        {
            Debug.LogError("Trigger Direction Error: " + transform.name);
            DirectionLeft = false;
            DirectionRight = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "MainCamera")
        {
            if (DirectionRight)
            {
                cameraMoveControl.Turn(Enums.Directions.right);
            }
            else if (DirectionLeft)
            {
                cameraMoveControl.Turn(Enums.Directions.left);
            }
        }
    }
}
