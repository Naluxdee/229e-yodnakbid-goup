using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Pushup : MonoBehaviour
{
    public float floatingSpeed = 1f; // ความเร็วในการลอยขึ้น
    public float maxFloatingHeight = 3f;
    private bool isPlayerOnTop = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero; // กำหนดความเร็วให้เป็นศูนย์ในทุกทิศทางเมื่อเริ่มต้น
    }

    void FixedUpdate()
    {
        // หาก Player ไปเหยียบ Object
        if (isPlayerOnTop)
        {
            // หากตำแหน่งของ Object ยังไม่ได้ถึงความสูงที่ต้องการ
            if (transform.position.y < maxFloatingHeight)
            {
                // ให้ใช้ความเร็วคงที่ในแกน Y เพื่อให้ Object ลอยขึ้น
                rb.velocity = Vector3.up * floatingSpeed;
            }
            else
            {
                // หยุดการเคลื่อนที่เมื่อถึงความสูงที่ต้องการ
                rb.velocity = Vector3.zero;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // ตรวจสอบว่า Player ไปเหยียบ Object หรือไม่
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerOnTop = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // ตรวจสอบว่า Player ไปหลุดออกจาก Object หรือไม่
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerOnTop = false;
        }
    }
}
