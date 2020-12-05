using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalMoveLoop : MonoBehaviour
{
    public bool IsMove;
    public bool moveLeft;
    public float rightLimit;
    public float leftLimit;
    public float speed;

    private void Start()
    {
        rightLimit = transform.localPosition.x + rightLimit;
        leftLimit = transform.localPosition.x + leftLimit;
    }

    void Update()
    {
        if (IsMove)
        {
            if (moveLeft)
            {
                if (transform.localPosition.x > leftLimit)
                {
                    MoveLeft();
                }
                else
                {
                    moveLeft = false;
                }
            }
            else
            {
                if (transform.localPosition.x < rightLimit)
                {
                    MoveRight();
                }
                else
                {
                    moveLeft = true;
                }
            }
        }
    }

    void MoveLeft()
    {
        transform.localPosition = new Vector3(transform.localPosition.x - speed * Time.deltaTime, transform.localPosition.y, transform.localPosition.z);
    }

    void MoveRight()
    {
        transform.localPosition = new Vector3(transform.localPosition.x + speed * Time.deltaTime, transform.localPosition.y, transform.localPosition.z);
    }
}
