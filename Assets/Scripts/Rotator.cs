using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float rotataionSpeed = 60f;

    void Update()
    {
        transform.Rotate(0f, rotataionSpeed * Time.deltaTime, 0f);
    }
}
