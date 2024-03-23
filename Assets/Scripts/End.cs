using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public string nextSceneName; // ชื่อของ Scene ถัดไปที่ต้องการโหลด

    void OnCollisionEnter(Collision collision)
    {
        // ตรวจสอบว่า Player เหยียบ Object หรือไม่
        if (collision.gameObject.CompareTag("Player"))
        {
            // โหลด Scene ถัดไป
            SceneManager.LoadScene(0);
        }
    }
}