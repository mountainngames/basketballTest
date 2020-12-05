using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMoveControl : MonoBehaviour
{

    [SerializeField] Vector3 CameraMoveAxis;
    [SerializeField] float CameraSpeed;
    [SerializeField] float CameraTurnFadeSpeed;
    Vector3 _currentMove;

    [SerializeField] Vector3 CameraRotation;
    [SerializeField] float CameraoRotateSpeed;

    void FixedUpdate()
    {
        SmoothTurn();
        transform.position += _currentMove * CameraSpeed * Time.deltaTime;
        transform.rotation = Quaternion.Lerp(transform.rotation, Quaternion.Euler(CameraRotation), CameraoRotateSpeed);
    }

    public void Turn(Enums.Directions TurnDirection)
    {
        switch (TurnDirection)
        {
            case Enums.Directions.right:
                CameraRotation += new Vector3(0, 90, 0);
                if (CameraMoveAxis.x != 0)// X AXIS
                {
                    if (CameraMoveAxis.x < 0)
                    {
                        CameraMoveAxis = new Vector3(0, 0, 1);
                    }
                    else
                    {
                        CameraMoveAxis = new Vector3(0, 0, -1);
                    }
                }
                else // Z AXIS
                {
                    if (CameraMoveAxis.z < 0)
                    {
                        CameraMoveAxis = new Vector3(-1, 0, 0);
                    }
                    else
                    {
                        CameraMoveAxis = new Vector3(1, 0, 0);
                    }
                }
                break;
            case Enums.Directions.left:
                CameraRotation += new Vector3(0, -90, 0);

                if (CameraMoveAxis.x != 0)// X AXIS
                {
                    if (CameraMoveAxis.x < 0)
                    {
                        CameraMoveAxis = new Vector3(0, 0, -1);
                    }
                    else
                    {
                        CameraMoveAxis = new Vector3(0, 0, 1);
                    }
                }
                else // Z AXIS
                {
                    if (CameraMoveAxis.z < 0)
                    {
                        CameraMoveAxis = new Vector3(1, 0, 0);
                    }
                    else
                    {
                        CameraMoveAxis = new Vector3(-1, 0, 0);
                    }
                }
                break;
        }
    }

    void SmoothTurn()
    {
        _currentMove = Vector3.Lerp(_currentMove, CameraMoveAxis, CameraTurnFadeSpeed);
    }
}
