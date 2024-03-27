using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaling : MonoBehaviour
{
    [SerializeField] private float _scalingSpeed;
    private Vector3 _scalingDirection = new Vector3(1, 1, 1);

    void Update()
    {
        Scale();
    }

    public void Scale()
    {
        transform.localScale += _scalingDirection * _scalingSpeed * Time.deltaTime;
    }
}
