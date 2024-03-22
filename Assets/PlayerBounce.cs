using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounce : MonoBehaviour
{
    public float bounceForce = 10f; // �ç�з�͹

    private Rigidbody playerRigidbody; // Rigidbody �ͧ Player

    void Start()
    {
        // �Ѻ��� Rigidbody �ͧ Player
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // ����� Player ���Ѻ�ѵ�����
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // ����ç�з�͹���Ѻ Player
            playerRigidbody.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        }
    }
}
