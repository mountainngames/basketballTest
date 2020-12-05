using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalMoveLoop : MonoBehaviour
{
    public bool IsMove;
    public bool moveUp;
    public float UpLimit;
    public float DownLimit;
    public float speed;

    private void Start()
    {
        UpLimit = transform.localPosition.y + UpLimit;
        DownLimit = transform.localPosition.y + DownLimit;
    }

    void Update()
    {
        if (IsMove)
        {
            if (moveUp)
            {
                if (transform.localPosition.y < UpLimit)
                {
                    MoveUp();
                }
                else
                {
                    moveUp = false;
                }
            }
            else
            {
                if (transform.localPosition.y > DownLimit)
                {
                    MoveDown();
                }
                else
                {
                    moveUp = true;
                }
            }
        }
    }

    void MoveDown()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y - speed * Time.deltaTime, transform.localPosition.z);
    }

    void MoveUp()
    {
        transform.localPosition = new Vector3(transform.localPosition.x, transform.localPosition.y + speed * Time.deltaTime, transform.localPosition.z);
    }
}
