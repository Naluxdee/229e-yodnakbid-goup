using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour
{
    public Transform target; // ใส่ Transform ของ Player เพื่อให้กล้องติดตาม Player
    public Vector3 offset; // ระยะห่างระหว่างกล้องกับ Player
    public float smoothSpeed = 0.125f; // ความลื่นของการเคลื่อนที่ของกล้อง

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // ตำแหน่งที่กล้องต้องการจะอยู่
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // เคลื่อนที่กล้องไปยังตำแหน่งที่ต้องการด้วยความลื่น
        transform.position = smoothedPosition; // กำหนดตำแหน่งของกล้องให้เป็นตำแหน่งที่ได้จากการเคลื่อนที่ลื่น
    }
}
