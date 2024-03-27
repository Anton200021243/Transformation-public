using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardLocal : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _moveSpeed;

    // Update is called once per frame
    void Update()
    {
        Move();
        Rotate();
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * _moveSpeed, Space.Self);
    }

    public void Rotate()
    {
        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);
    }
}
