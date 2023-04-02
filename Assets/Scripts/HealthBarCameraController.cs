using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBarCameraController : MonoBehaviour
{
    Transform targetCamera;

    private void Awake()
    {
        targetCamera = Camera.main.transform;
    }

    void Update()
    {
        transform.rotation = Quaternion.LookRotation(transform.position - targetCamera.position);
    }
}
