using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;


public class CountdownTimes : MonoBehaviour
{
    [SerializeField] float countdownTime = 60f; // ���ҷ�����Ѻ�����ѧ (��Թҷ�)
    [SerializeField] TextMeshProUGUI countdownText; // ��ǹ�ͧ TextMeshProUGUI �����ʴ�����
    [SerializeField] GameObject loseUI; // UI �����ʴ�����ͼ�������
    [SerializeField] GameObject player; // GameObject �ͧ����Ф�

    float currentTime; // ���һѨ�غѹ
    bool isCounting = true; // ʶҹС�ùѺ�����ѧ

    void Start()
    {
        currentTime = countdownTime; // ��駤�������������
    }

    void Update()
    {
        if (isCounting)
        {
            currentTime -= Time.deltaTime;

            if (currentTime <= 0f)
            {
                isCounting = false;
                countdownText.text = "Lose"; // ����¹�� "Lose" ������������
                ShowLoseUI(); // �ʴ�˹�� UI "Lose"
                StopPlayerMovement(); // ��ش�������͹��Ǣͧ����Ф�
            }
            else
            {
                countdownText.text = "Time Left: " + Mathf.Round(currentTime).ToString(); // �ʴ����ҷ�������� TextMeshProUGUI
            }

        }
    }

    void ShowLoseUI()
    {
        loseUI.SetActive(true); // �ʴ�˹�� UI "Lose"
    }

    void StopPlayerMovement()
    {
        // ��ش�������͹��Ǣͧ����Ф��»Դ�����ҹ����๹�����繡�äǺ����������͹���
        player.GetComponent<playerControl>().enabled = false;
    }


}
