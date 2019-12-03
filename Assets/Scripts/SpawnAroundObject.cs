using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class SpawnAroundObject : MonoBehaviour
{
    public GameObject Prefab1;
    public float Distance;
    public int AmountOfObjectsToSpawn;

    public void Spawn()
    {
        var r = GetComponent<SphereCollider>().radius;
        for (var i = 0; i < AmountOfObjectsToSpawn; i++)
        {
            Vector3 randomPos;
            do
            {
                randomPos = Random.insideUnitSphere * Distance;
            } while (Physics.CheckSphere(randomPos, r / 5 * 3));

            randomPos.y = Mathf.Abs(randomPos.y);

            var position = transform.position + randomPos;
            var o = Instantiate(Prefab1, position, Quaternion.identity).gameObject;
            o.transform.parent = transform;
            Destroy(o, 3f);
        }
    }
       
}
