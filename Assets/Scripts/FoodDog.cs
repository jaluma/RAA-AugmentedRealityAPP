using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class FoodDog : MonoBehaviour
{
    public void Spawn()
    {
        SpawnBone();
    }

    #region Heart
    // Spawn hearts
    public GameObject Heart;
    public float Distance;
    public int AmountOfObjectsToSpawn;

    public void SpawnHeart()
    {
        var r = GetComponent<SphereCollider>().radius;
        for (var i = 0; i < AmountOfObjectsToSpawn; i++)
        {
            Vector3 randomPos;
            int c = 0;
            do
            {
                randomPos = Random.insideUnitSphere * Distance;
                c++;
            } while (Physics.CheckSphere(randomPos, r / 10 * 2) || c<10);
            {
                randomPos.y = Mathf.Abs(randomPos.y);

                var position = transform.position + randomPos;
                var o = Instantiate(Heart, position, Quaternion.identity).gameObject;
                o.transform.parent = transform;
                Destroy(o, 5f);
            }
        }
    }
    #endregion

    #region Bone
    // Spawn bone
    public GameObject Bone;

    void SpawnBone()
    {
        var o = Instantiate(Bone, new Vector3(Random.Range(-0.3f, 0.3f), 0.28f, -0.71f), new Quaternion(0, 0, 64.42f, Bone.transform.rotation.w)).gameObject;
        o.transform.parent = transform;
        o.transform.localScale = Vector3.one * 0.005f;
        o.GetComponent<FollowDog>().Target = this.gameObject;
    }
    #endregion
}
