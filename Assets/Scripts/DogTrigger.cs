using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogTrigger : MonoBehaviour
{
    private Animator _animator;
    private float _time;
    private int _lastState;

    // Use this for initialization
    void Start()
    {
        _animator = GetComponent<Animator>();
        _time = 0;
    }

    // Update is called once per frame
    void Update()
    {
        var an = _animator.GetCurrentAnimatorStateInfo(0);

        if (_lastState == 0 || !an.shortNameHash.Equals(_lastState)) {
            _time = 0;
            _animator.SetBool("Idle", false);
        }
        _lastState = an.shortNameHash;

        if (an.loop)
        {
            _time++;
        }

        var delay = an.length * 40 <= _time;

        if (delay) {
            _animator.SetBool("Idle", true);
            _time = 0;
        }

        if (!delay && (an.IsName("SitDown") || an.IsName("IdleSit")))
        {
            _animator.SetBool("Sit", true);
            _animator.SetBool("Idle", false);
        }

        if (an.IsName("Idle1")) {
            _animator.SetBool("Sit", false);
        }
    }
}
