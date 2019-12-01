using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogAnimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Animation>().Play("Idle1");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
