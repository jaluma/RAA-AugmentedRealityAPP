using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingUp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float r = (Random.value * 0.2f);
        GetComponent<Rigidbody>().velocity = transform.up * r;
        var rotB = Quaternion.LookRotation(Camera.main.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotB, 3 * Time.deltaTime);
    }
}
