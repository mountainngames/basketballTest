using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{

    [SerializeField] bool HorizontalMove;
    [SerializeField] bool MoveLeft;
    [SerializeField] float RightLimit;
    [SerializeField] float LeftLimit;
    [SerializeField] float HorizontalSpeed;

    [SerializeField] bool VerticalMove;
    [SerializeField] bool MoveUp;
    [SerializeField] float UpLimit;
    [SerializeField] float DownLimit;
    [SerializeField] float VerticalSpeed;

    [SerializeField] bool Diagonalmove;
    [SerializeField] bool MoveFront;
    [SerializeField] float FrontLimit;
    [SerializeField] float BackLimit;
    [SerializeField] float DiagonalSpeed;


    void Awake()
    {
        if (HorizontalMove)
        {
            HorizontalMoveLoop NewLoop = gameObject.AddComponent<HorizontalMoveLoop>();
            NewLoop.IsMove = HorizontalMove;
            NewLoop.moveLeft = MoveLeft;
            NewLoop.rightLimit = RightLimit;
            NewLoop.leftLimit = LeftLimit;
            NewLoop.speed = HorizontalSpeed;
        }

        if (VerticalMove)
        {
            VerticalMoveLoop NewLoop = gameObject.AddComponent<VerticalMoveLoop>();
            NewLoop.IsMove = VerticalMove;
            NewLoop.moveUp = MoveUp;
            NewLoop.UpLimit = UpLimit;
            NewLoop.DownLimit = DownLimit;
            NewLoop.speed = VerticalSpeed;
        }

        if (Diagonalmove)
        {
            DiagonalMoveLoop NewLoop = gameObject.AddComponent<DiagonalMoveLoop>();
            NewLoop.IsMove = Diagonalmove;
            NewLoop.moveFront = MoveFront;
            NewLoop.frontLimit = FrontLimit;
            NewLoop.backLimit = BackLimit;
            NewLoop.speed = DiagonalSpeed;
        }
    }
}
