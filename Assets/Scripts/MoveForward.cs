using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForward : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Move();
    }

    public void Move()
    {
        transform.Translate(Vector3.forward * _speed * Time.deltaTime);
    }
}
