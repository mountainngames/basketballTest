using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotTriggers : MonoBehaviour
{
    [SerializeField] PotSkorPluser potSkorPluser;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
        {
            switch (transform.name)
            {
                case "Trigger1":
                    potSkorPluser.BallTriggerMarker(other.name, 1);
                    Debug.Log("Trig1");
                    break;

                case "Trigger2":
                    potSkorPluser.BallTriggerMarker(other.name, 2);
                    Debug.Log("Trig2");
                    break;

                case "Trigger3":
                    potSkorPluser.BallTriggerMarker(other.name, 3);
                    Debug.Log("Trig3");
                    break;
            }
        }
    }
}
