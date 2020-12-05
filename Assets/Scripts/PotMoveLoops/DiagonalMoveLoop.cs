using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalMoveLoop : MonoBehaviour
{
    public bool IsMove;
    public bool moveFront;
    public float frontLimit;
    public float backLimit;
    public float speed;

    private void Start()
    {
        frontLimit = transform.localPosition.z + frontLimit;
        backLimit = transform.localPosition.z + backLimit;
    }
    void Update()
    {
        if (IsMove)
        {
            if (moveFront)
            {
                if (transform.localPosition.z > frontLimit)
                {
                    MoveFront();
                }
                else
                {
                    moveFront = false;
                }
            }
            else
            {
                if (transform.localPosition.z < backLimit)
                {
                    MoveBack();
                }
                else
                {
                    moveFront = true;
                }
            }
        }
    }

    void MoveFront()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z - speed * Time.deltaTime);
    }

    void MoveBack()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y, transform.localPosition.z + speed * Time.deltaTime);
    }
}
