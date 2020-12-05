using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotSkorPluser : MonoBehaviour
{
    List<bool> Trigger1 = new List<bool>();
    List<bool> Trigger2 = new List<bool>();
    List<bool> Trigger3 = new List<bool>();
    List<string> BallNames = new List<string>();

    bool isWok = true;

    void Update()
    {
        if (isWok)
        {
            if (BasketController())
            {
                isWok = false;
                Destroy(gameObject, .5f);
            }


        }
    }

    public void BallTriggerMarker(string BallName, int TriggerName)
    {
        bool Trig1 = false;
        bool Trig2 = false;
        bool Trig3 = false;

        int TrigMarker1 = 0;
        int TrigMarker2 = 0;
        int TrigMarker3 = 0;

        switch (TriggerName)
        {
            case 1:
                for (int i = 0; i < BallNames.Count; i++)
                {
                    if (BallNames[i] == BallName)
                    {
                        Trigger1[i] = true;
                        Trig1 = true;
                        TrigMarker1 = i;
                        break;
                    }
                }
                if (Trig1)
                {
                    Trigger1[TrigMarker1] = true;
                }
                else
                {
                    BallNames.Add(BallName);
                    Trigger1.Add(true);
                    Trigger2.Add(false);
                    Trigger3.Add(false);
                }
                break;

            case 2:
                for (int i = 0; i < BallNames.Count; i++)
                {
                    if (BallNames[i] == BallName)
                    {
                        Trigger2[i] = true;
                        Trig2 = true;
                        TrigMarker2 = i;
                        break;
                    }
                }
                if (Trig2)
                {
                    Trigger2[TrigMarker2] = true;
                }
                else
                {
                    BallNames.Add(BallName);
                    Trigger1.Add(false);
                    Trigger2.Add(true);
                    Trigger3.Add(false);
                }
                break;

            case 3:
                for (int i = 0; i < BallNames.Count; i++)
                {
                    if (BallNames[i] == BallName)
                    {
                        Trigger3[i] = true;
                        Trig3 = true;
                        TrigMarker3 = i;
                        break;
                    }
                }
                if (Trig3)
                {
                    Trigger3[TrigMarker3] = true;
                }
                else
                {
                    BallNames.Add(BallName);
                    Trigger1.Add(false);
                    Trigger2.Add(false);
                    Trigger3.Add(true);
                }
                break;
        }
    }

    private bool BasketController()
    {
        for (int i = 0; i < BallNames.Count; i++)
        {
            if (Trigger1[i] && Trigger2[i] && Trigger3[i])
            {
                Debug.Log(BallNames[i]);
                return true;
            }
        }
        return false;
    }
}
