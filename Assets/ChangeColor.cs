using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // �շ��س��ͧ������ Cube ����¹����Ͷ١����º
    public Color targetColor = Color.green;

    // ������ա�ê��Ѻ Collider ��� �
    void OnTriggerEnter(Collider other)
    {
        // ��Ǩ�ͺ����� Player �������
        if (other.CompareTag("Player"))
        {
            // ����¹�բͧ Cube ��������
            GetComponent<Renderer>().material.color = targetColor;
        }
    }
}
