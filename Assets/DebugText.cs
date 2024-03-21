using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class DebugText : MonoBehaviour
{
    public TextMeshProUGUI debugTextMeshPro;
    private int maxNumber = int.MinValue; // �纤���٧�ش��������Ѻ

    void Start()
    {
        Application.logMessageReceived += DebugLog;
    }

    void DebugLog(string logString, string stackTrace, LogType type)
    {
        // �ŧ��ͤ�������Ѻ������繵���Ţ integer
        int intValue;
        bool isInt = int.TryParse(logString, out intValue);

        // �������ö�ŧ������繵���Ţ����դ���ҡ����������ҡѺ����٧�ش��������Ѻ
        if (isInt && intValue >= maxNumber)
        {
            maxNumber = intValue; // ��Ѻ��ا����٧�ش
            // �ʴ���ͤ�������ش����Դ��� ��������ҹѺ仢�ҧ˹��
            debugTextMeshPro.text = intValue.ToString() + "\n";
        }
    }

    private void OnDisable()
    {
        Application.logMessageReceived -= DebugLog;
    }
}
