using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestructor : MonoBehaviour
{
    private float _destroyTime;

    public void Initialize(float destroyTime)
    {
        _destroyTime = destroyTime;
        Invoke(nameof(DestroySelf), _destroyTime);
    }

    private void DestroySelf()
    {
        Destroy(gameObject);
    }
}