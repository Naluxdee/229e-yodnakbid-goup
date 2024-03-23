using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
    public Transform player; // เลือก GameObject ของผู้เล่น
    public Transform cubeArea; // เลือก GameObject ของพื้นที่ cube
    private int distanceTravelled = 0;
    private float initialXPosition;

    void Start()
    {
        initialXPosition = player.position.x;
    }

    void Update()
    {
        // ตรวจสอบว่าผู้เล่นอยู่ในพื้นที่ของ cube หรือไม่
        if (player.position.x >= cubeArea.position.x - cubeArea.localScale.x / 2 &&
            player.position.x <= cubeArea.position.x + cubeArea.localScale.x / 2 &&
            player.position.z >= cubeArea.position.z - cubeArea.localScale.z / 2 &&
            player.position.z <= cubeArea.position.z + cubeArea.localScale.z / 2)
        {
            // คำนวณระยะทางที่ผู้เล่นเคลื่อนที่ไปแล้วในแนวนอน (ซ้ายไปขวา)
            float distanceX = player.position.x - initialXPosition;
            // อัพเดทระยะทางที่เคยเดินไปแล้วและเปลี่ยนเป็น integer
            distanceTravelled = Mathf.RoundToInt(Mathf.Abs(distanceX));

            // แสดงผลระยะทางที่ผู้เล่นเคลื่อนที่ไปแล้วในหน่วยเมตร
            Debug.Log(distanceTravelled);
        }
    }
}
