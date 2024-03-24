using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedPower : MonoBehaviour
{
    public float force = 10f; // �������Ƿ�� Player �о��
    public float dragValue = 1f; // ����ç���´�ҹ

    void OnCollisionEnter(Collision collision)
    {
        // ��Ǩ�ͺ��Ҫ��Ѻ Player �������
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            if (playerRigidbody != null)
            {
                // ��� Player �����᡹ x
                playerRigidbody.AddForce(Vector3.right * force, ForceMode.Impulse);
                // ��駤���ç���´�ҹ���������ش�����ç�������ѧ�ҡ���
                playerRigidbody.drag = dragValue;
            }
        }
    }
}
