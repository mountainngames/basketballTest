using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] GameObject BallPrefab;
    [SerializeField] float ballRange;
    [SerializeField] float destroyTime;
    int useingBallCount;
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out RaycastHit hit))
            {
                GameObject ball = Instantiate(BallPrefab, transform.position, Quaternion.identity);
                ball.name = "Ball" + useingBallCount;
                useingBallCount++;
                ball.transform.LookAt(hit.point);
                ball.GetComponent<Rigidbody>().velocity = (ball.transform.forward * ballRange);
                ball.GetComponent<BallDestroy>().destroyTime = destroyTime;
            }
        }
    }
}
