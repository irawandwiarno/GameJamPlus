using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Objek yang ingin diikuti oleh kamera
    public float smoothSpeed = 0.125f; // Kecepatan pergerakan kamera
    private float gapCam = -10f;


    void LateUpdate()
    {
        // Mengatur posisi kamera agar mengikuti posisi objek target
        Vector3 desiredPosition = target.position;
        Vector3 posisiCamWithGap = new Vector3(transform.position.x, transform.position.y, gapCam);
        Vector3 smoothedPosition = Vector3.Lerp(posisiCamWithGap, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;
    }
}

