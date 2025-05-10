using UnityEngine;
using System.Collections;

public class EA0: MonoBehaviour
{
Animation _animation; 
void Start()
    {
        _animation = GetComponentInChildren<Animation>();

    _animation["Move1"].wrapMode = WrapMode.Loop;
    _animation.Play("Move1");
    _animation["Move1"].normalizedTime = Random.value;
    }
}
