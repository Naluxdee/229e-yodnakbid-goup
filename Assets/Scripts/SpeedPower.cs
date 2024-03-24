using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPower : MonoBehaviour
{
    public float force = 10f; // ความเร็วที่ Player จะพุ่ง
    public float dragValue = 1f; // ค่าแรงเสียดทาน

    void OnCollisionEnter(Collision collision)
    {
        // ตรวจสอบว่าชนกับ Player หรือไม่
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                // ให้ Player พุ่งไปในแกน x
                playerRigidbody.AddForce(Vector3.right * force, ForceMode.Impulse);
                // ตั้งค่าแรงเสียดทานเพื่อให้หยุดด้วยแรงเฉื่อยหลังจากพุ่ง
                playerRigidbody.drag = dragValue;
            }
        }
    }
}
