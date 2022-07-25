using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    // MainCamera�� ��� lookAt() �� ������Ʈ (ĳ����)
    public Transform target;

    //���� ī�޶��� Transform (��ġ)
    private Transform tr;

    void Start()
    {
        tr = GetComponent<Transform>();
    }


    void LateUpdate()
    {
        tr.position = new Vector3(target.position.x - 0f, tr.position.y, target.position.z -4f);

        tr.LookAt(target);
    }
}
