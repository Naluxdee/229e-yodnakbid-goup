using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReset : MonoBehaviour
{
    public string sceneNameToLoad; // ���ͧ͢�ҡ����ͧ�����Ŵ���

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ResetScene();
        }
    }

    void ResetScene()
    {
        // ��Ŵ�ҡ������кت��ͩҡ����ͧ�����Ŵ
        SceneManager.LoadScene(sceneNameToLoad);
    }

}
