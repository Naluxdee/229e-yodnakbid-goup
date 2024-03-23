using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float moveSpeed = 5f; // ความเร็วในการเดิน

    public float jumpForce = 10f; // กำหนดความสามารถในการกระโดดของ Player

    private Rigidbody rb; // ประกาศตัวแปร Rigidbody

    void Start()
    {
        // รับค่า Rigidbody ที่ติดกับ Player
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // ใช้เงื่อนไขที่เกิดขึ้นเมื่อกดปุ่ม Spacebar เพื่อกระโดด
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        //Debug.Log("Is Grounded: " + IsGrounded());

        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(transform.position - transform.right * moveSpeed * Time.fixedDeltaTime);
        }
        // เคลื่อนที่ Player ไปทางขวา
        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(transform.position + transform.right * moveSpeed * Time.fixedDeltaTime);
        }

    }

    void Jump()
    {
        // ตรวจสอบว่า Player อยู่บนพื้นหรือไม่ หากใช่ให้กระโดด
        if (IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    bool IsGrounded()
    {
        // ตรวจสอบว่า Player ติดพื้นหรือไม่
        return Physics.Raycast(transform.position, Vector3.down, 1.3f);
    }
}
