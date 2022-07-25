using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    // MainCamera가 계속 lookAt() 할 오브젝트 (캐릭터)
    public Transform target;

    //메인 카메라의 Transform (위치)
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
