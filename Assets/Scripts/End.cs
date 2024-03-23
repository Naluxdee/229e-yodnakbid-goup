using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    public string nextSceneName; // ���ͧ͢ Scene �Ѵ价���ͧ�����Ŵ

    void OnCollisionEnter(Collision collision)
    {
        // ��Ǩ�ͺ��� Player ����º Object �������
        if (collision.gameObject.CompareTag("Player"))
        {
            // ��Ŵ Scene �Ѵ�
            SceneManager.LoadScene(0);
        }
    }
}