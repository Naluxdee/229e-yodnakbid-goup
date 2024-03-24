using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UIElements.UxmlAttributeDescription;

public class Pushup : MonoBehaviour
{
    public float floatingSpeed = 1f; // ��������㹡����¢��
    public float maxFloatingHeight = 3f;
    private bool isPlayerOnTop = false;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.velocity = Vector3.zero; // ��˹���������������ٹ��㹷ء��ȷҧ������������
    }

    void FixedUpdate()
    {
        // �ҡ Player �����º Object
        if (isPlayerOnTop)
        {
            // �ҡ���˹觢ͧ Object �ѧ�����֧�����٧����ͧ���
            if (transform.position.y < maxFloatingHeight)
            {
                // �����������Ǥ�����᡹ Y ������� Object ��¢��
                rb.velocity = Vector3.up * floatingSpeed;
            }
            else
            {
                // ��ش�������͹�������Ͷ֧�����٧����ͧ���
                rb.velocity = Vector3.zero;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        // ��Ǩ�ͺ��� Player �����º Object �������
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerOnTop = true;
        }
    }

    void OnCollisionExit(Collision collision)
    {
        // ��Ǩ�ͺ��� Player ���ش�͡�ҡ Object �������
        if (collision.gameObject.CompareTag("Player"))
        {
            isPlayerOnTop = false;
        }
    }
}
