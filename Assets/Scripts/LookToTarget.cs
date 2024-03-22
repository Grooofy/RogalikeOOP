using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookToTarget : MonoBehaviour
{
    [SerializeField] private GameObject _target;


    private void Update()
    {
        if (_target == null)
            return;

        transform.position = _target.transform.position + new Vector3(0,0,-10);
    }

    public void SetTarget(GameObject target)
    {
        _target = target;
    }
}
