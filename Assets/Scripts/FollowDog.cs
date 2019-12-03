using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDog : MonoBehaviour
{ 
    public GameObject Target;
    public float MoveSpeed = 5;
    public float RotationSpeed = 5;

    void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
    }

    void Update()
    {
        var rotB = Quaternion.LookRotation(Target.transform.position - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotB, RotationSpeed * Time.deltaTime);
        //transform.position += transform.forward * Time.deltaTime * MoveSpeed;
        float step = MoveSpeed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(Target.transform.position.x, Target.transform.position.y + 0.1f, Target.transform.position.z), step);
    }
}

