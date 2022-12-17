using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAmbient : MonoBehaviour
{
    [SerializeField] private Light _globalLight;
    [SerializeField] private float _delayBeforeActive;
    [SerializeField] private bool _active;
    private void OnTriggerEnter(Collider other)
    {
        StartCoroutine(Count());
    }

    IEnumerator Count()
    {
        yield return new WaitForSeconds(_delayBeforeActive);
        if (_active)
        {
            _globalLight.intensity = 1;
        }
        else
        {
            _globalLight.intensity = 0;
        }
    }
}
