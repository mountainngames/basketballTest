using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallDestroy : MonoBehaviour
{
    public float destroyTime;
    bool IsDestroy = false;
    Color currentColor;
    void Start()
    {
        currentColor = transform.GetComponent<MeshRenderer>().sharedMaterial.color;
        StartCoroutine(Timer());
    }


    void Update()
    {
        if (IsDestroy)
        {
            currentColor = new Color(currentColor.r, currentColor.g, currentColor.b, currentColor.a - .01f);
            transform.GetComponent<MeshRenderer>().material.color = currentColor;
            if (currentColor.a <= 0)
            {
                Destroy(gameObject);
            }
        }

    }

    IEnumerator Timer()
    {
        yield return new WaitForSeconds(destroyTime);
        IsDestroy = true;
    }
}
