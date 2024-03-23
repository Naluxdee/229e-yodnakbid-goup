using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBounce : MonoBehaviour
{
    public float bounceForce = 10f; // แรงสะท้อน

    private Rigidbody playerRigidbody; // Rigidbody ของ Player

    void Start()
    {
        // รับค่า Rigidbody ของ Player
        playerRigidbody = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        // เมื่อ Player ชนกับวัตถุอื่น
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            // ใส่แรงสะท้อนให้กับ Player
            playerRigidbody.AddForce(Vector3.up * bounceForce, ForceMode.Impulse);
        }
    }
}
