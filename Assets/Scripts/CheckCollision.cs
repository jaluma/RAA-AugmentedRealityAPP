using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().AddTorque(transform.up * Random.value);
    }
}
