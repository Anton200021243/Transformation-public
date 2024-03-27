using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    void Update()
    {
        Rotate();
    }

    public void Rotate()
    {
        transform.Rotate(_rotateSpeed * Vector3.up * Time.deltaTime);
    }
}
