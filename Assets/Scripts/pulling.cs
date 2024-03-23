using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulling : MonoBehaviour
{
    public float defaultPullingForce = 5f; // �ç�����㹡�ô֧ Player ��� (����������)
    public float pullingForce; // �ç�����㹡�ô֧ Player ���

    void Start()
    {
        pullingForce = defaultPullingForce; // ��˹��������������Ѻ pullingForce
    }

    void OnCollisionEnter(Collision collision)
    {
        // ��Ǩ�ͺ��� Player ����º Object �������
        if (collision.gameObject.CompareTag("Player"))
        {
            Rigidbody playerRigidbody = collision.gameObject.GetComponent<Rigidbody>();
            // ������ç㹡�ô֧ Player ���
            playerRigidbody.AddForce(Vector3.up * pullingForce, ForceMode.Impulse);
        }
    }

}
