using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulling : MonoBehaviour
{
    public float defaultPullingForce = 5f; // แรงที่ใช้ในการดึง Player ขึ้น (ค่าเริ่มต้น)
    public float pullingForce; // แรงที่ใช้ในการดึง Player ขึ้น

    void Start()
    {
        pullingForce = defaultPullingForce; // กำหนดค่าเริ่มต้นให้กับ pullingForce
    }

    void OnCollisionEnter(Collision collision)
    {
        // ตรวจสอบว่า Player เหยียบ Object หรือไม่
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            // ให้ใช้แรงในการดึง Player ขึ้น
            playerRigidbody.AddForce(Vector3.up * pullingForce, ForceMode.Impulse);
        }
    }

}
