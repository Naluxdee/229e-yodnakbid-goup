using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneReset : MonoBehaviour
{
    public string sceneNameToLoad; // ชื่อของฉากที่ต้องการโหลดเก่า

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            ResetScene();
        }
    }

    void ResetScene()
    {
        // โหลดฉากเก่าโดยระบุชื่อฉากที่ต้องการโหลด
        SceneManager.LoadScene(sceneNameToLoad);
    }

}
