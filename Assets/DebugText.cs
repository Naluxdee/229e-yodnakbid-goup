using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class DebugText : MonoBehaviour
{
    public TextMeshProUGUI debugTextMeshPro;
    private int maxNumber = int.MinValue; // เก็บค่าสูงสุดที่เคยได้รับ

    void Start()
    {
        Application.logMessageReceived += DebugLog;
    }

    void DebugLog(string logString, string stackTrace, LogType type)
    {
        // แปลงข้อความที่รับเข้ามาเป็นตัวเลข integer
        int intValue;
        bool isInt = int.TryParse(logString, out intValue);

        // ถ้าสามารถแปลงได้และเป็นตัวเลขที่มีค่ามากกว่าหรือเท่ากับค่าสูงสุดที่เคยได้รับ
        if (isInt && intValue >= maxNumber)
        {
            maxNumber = intValue; // ปรับปรุงค่าสูงสุด
            // แสดงข้อความล่าสุดที่เกิดขึ้น โดยเพิ่มค่านับไปข้างหน้า
            debugTextMeshPro.text = intValue.ToString() + "\n";
        }
    }

    private void OnDisable()
    {
        Application.logMessageReceived -= DebugLog;
    }
}
