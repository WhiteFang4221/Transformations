using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        float angle = _rotateSpeed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(0, angle, 0);
        transform.rotation *= rotation;
    }
}
