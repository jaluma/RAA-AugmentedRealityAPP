using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeIn : MonoBehaviour
{
    public float FadeSpeed = 0.1f;
    private Material[] _materials;
    private float _spawnTime;

    // Use this for initialization
    void Start() {
        _materials = GetComponent<SkinnedMeshRenderer>().materials;
        _spawnTime = Time.time;
    }

    // Update is called once per frame
    void Update() {
        SetAlpha((Time.time - _spawnTime) * FadeSpeed);
    }

    void SetAlpha(float alpha) {
        foreach (var t in _materials)
        {
            Color color = t.color;
            color.a = Mathf.Clamp(alpha, 0, 1);
            t.color = color;
        }
    }
}
