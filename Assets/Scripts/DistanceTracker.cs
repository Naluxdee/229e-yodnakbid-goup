using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceTracker : MonoBehaviour
{
    public Transform player; // ���͡ GameObject �ͧ������
    public Transform cubeArea; // ���͡ GameObject �ͧ��鹷�� cube
    private int distanceTravelled = 0;
    private float initialXPosition;

    void Start()
    {
        initialXPosition = player.position.x;
    }

    void Update()
    {
        // ��Ǩ�ͺ��Ҽ���������㹾�鹷��ͧ cube �������
        if (player.position.x >= cubeArea.position.x - cubeArea.localScale.x / 2 &&
            player.position.x <= cubeArea.position.x + cubeArea.localScale.x / 2 &&
            player.position.z >= cubeArea.position.z - cubeArea.localScale.z / 2 &&
            player.position.z <= cubeArea.position.z + cubeArea.localScale.z / 2)
        {
            // �ӹǳ���зҧ������������͹����������ǹ͹ (����仢��)
            float distanceX = player.position.x - initialXPosition;
            // �Ѿഷ���зҧ������Թ������������¹�� integer
            distanceTravelled = Mathf.RoundToInt(Mathf.Abs(distanceX));

            // �ʴ������зҧ������������͹���������˹�������
            Debug.Log(distanceTravelled);
        }
    }
}
