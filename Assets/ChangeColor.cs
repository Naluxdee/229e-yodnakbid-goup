using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // สีที่คุณต้องการให้ Cube เปลี่ยนเมื่อถูกเหยียบ
    public Color targetColor = Color.green;

    // เมื่อมีการชนกับ Collider อื่น ๆ
    void OnTriggerEnter(Collider other)
    {
        // ตรวจสอบว่าเป็น Player หรือไม่
        if (other.CompareTag("Player"))
        {
            // เปลี่ยนสีของ Cube เป็นสีเขียว
            GetComponent<Renderer>().material.color = targetColor;
        }
    }
}
