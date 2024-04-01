using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed;
    private Vector3 _scalingDirection = Vector3.one;

    private void Update()
    {
        Scale();
    }

    private void Scale()
    {
        transform.localScale += _scalingDirection * _scalingSpeed * Time.deltaTime;
    }
}
