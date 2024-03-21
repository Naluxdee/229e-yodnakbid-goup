using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControl : MonoBehaviour
{
    public float moveSpeed = 5f; // ��������㹡���Թ

    public float jumpForce = 10f; // ��˹���������ö㹡�á��ⴴ�ͧ Player

    private Rigidbody rb; // ��С�ȵ���� Rigidbody

    void Start()
    {
        // �Ѻ��� Rigidbody ���Դ�Ѻ Player
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // �����͹䢷���Դ�������͡����� Spacebar ���͡��ⴴ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        //Debug.Log("Is Grounded: " + IsGrounded());

        if (Input.GetKey(KeyCode.A))
        {
            rb.MovePosition(transform.position - transform.right * moveSpeed * Time.fixedDeltaTime);
        }
        // ����͹��� Player 价ҧ���
        if (Input.GetKey(KeyCode.D))
        {
            rb.MovePosition(transform.position + transform.right * moveSpeed * Time.fixedDeltaTime);
        }

    }

    void Jump()
    {
        // ��Ǩ�ͺ��� Player ���躹���������� �ҡ�������ⴴ
        if (IsGrounded())
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    bool IsGrounded()
    {
        // ��Ǩ�ͺ��� Player �Դ����������
        return Physics.Raycast(transform.position, Vector3.down, 1.3f);
    }
}
