using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControler : MonoBehaviour
{
    public Transform target; // ��� Transform �ͧ Player ���������ͧ�Դ��� Player
    public Vector3 offset; // ������ҧ�����ҧ���ͧ�Ѻ Player
    public float smoothSpeed = 0.125f; // ������蹢ͧ�������͹���ͧ���ͧ

    void LateUpdate()
    {
        Vector3 desiredPosition = target.position + offset; // ���˹觷����ͧ��ͧ��è�����
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed); // ����͹�����ͧ��ѧ���˹觷���ͧ��ô��¤������
        transform.position = smoothedPosition; // ��˹����˹觢ͧ���ͧ����繵��˹觷����ҡ�������͹������
    }
}
