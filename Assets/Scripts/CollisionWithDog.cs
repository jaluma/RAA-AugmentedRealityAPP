using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionWithDog : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Destroy(this.gameObject);
        collision.gameObject.GetComponent<FoodDog>().SpawnHeart();
    }
}
