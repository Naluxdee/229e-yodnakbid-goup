using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class CountdownTimes : MonoBehaviour
{
    [SerializeField] float countdownTime = 60f; // เวลาที่ให้นับถอยหลัง (ในวินาที)
    [SerializeField] TextMeshProUGUI countdownText; // ส่วนของ TextMeshProUGUI ที่จะแสดงเวลา
    [SerializeField] GameObject loseUI; // UI ที่จะแสดงเมื่อผู้เล่นแพ้
    [SerializeField] GameObject player; // GameObject ของตัวละคร

    float currentTime; // เวลาปัจจุบัน
    bool isCounting = true; // สถานะการนับถอยหลัง

    void Start()
    {
        currentTime = countdownTime; // ตั้งค่าเวลาเริ่มต้น
    }

    void Update()
    {
        if (isCounting)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0f)
            {
                isCounting = false;
                countdownText.text = "Lose"; // เปลี่ยนเป็น "Lose" เมื่อเวลาหมด
                ShowLoseUI(); // แสดงหน้า UI "Lose"
                StopPlayerMovement(); // หยุดการเคลื่อนไหวของตัวละคร
            }
            else
            {
                countdownText.text = "Time Left: " + Mathf.Round(currentTime).ToString(); // แสดงเวลาที่เหลือใน TextMeshProUGUI
            }

        }
    }

    void ShowLoseUI()
    {
        loseUI.SetActive(true); // แสดงหน้า UI "Lose"
    }

    void StopPlayerMovement()
    {
        // หยุดการเคลื่อนไหวของตัวละครโดยปิดการใช้งานคอมโพเนนต์ที่เป็นการควบคุมการเคลื่อนไหว
        player.GetComponent<playerControl>().enabled = false;
    }


}
