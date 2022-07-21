using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Transform tr1 = transform.Find("FindInChild");
        Transform tr2 = transform.Find("FindInChild2");
        
        Debug.Log(transform.GetChild(0).name);
        tr1.SetAsLastSibling();
        Debug.Log(transform.GetChild(0).name);
        tr1.SetAsFirstSibling();
        Debug.Log(transform.GetChild(0).name);
        tr1.SetSiblingIndex(1);
        
        Debug.Log(tr1.parent.name);
    }

    // Update is called once per frame
    void Update()
    { 
        //컴파일 에러
        //transform.position.x += 0.01f;
        
        Vector3 vecP = transform.localPosition;
        vecP.x += 0.01f;
        transform.localPosition = vecP;
        
        Vector3 vecR = transform.localRotation.eulerAngles;
        vecR.x += 0.01f;
        transform.localRotation = Quaternion.Euler(vecR);
        
        Vector3 vecS = transform.localScale;
        vecS.x += 0.01f;
        transform.localScale = vecS;
        
        
    }
}
