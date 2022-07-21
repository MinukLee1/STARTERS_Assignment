using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectExample : MonoBehaviour
{
    // Start is called before the first frame update
    
    [SerializeField]
    private GameObject goPrefab;
    [SerializeField]
    public GameObject goTestActiveParent;
    [SerializeField]
    public GameObject goTestActiveChild;
    
    void Start()
    {
        
        // 1. 오브젝트 생성
        GameObject go = GameObject.CreatePrimitive(PrimitiveType.Cube);
        // PrimitiveType.Capsule;
        // PrimitiveType.Cylinder;
        // PrimitiveType.Plane;
        // PrimitiveType.Quad;
        // PrimitiveType.Sphere;

        
        // 2. 오브젝트 파괴
        //Destroy(go);
        //Destroy(go, 3f);

        // 3. 오브젝트의 활성화 여부 확인
        // Debug.Log(goTestActiveChild.activeSelf);
        // Debug.Log(goTestActiveParent.activeSelf);
        // Debug.Log(goTestActiveChild.activeInHierarchy);
        // Debug.Log(goTestActiveParent.activeInHierarchy);

        //4. Tag 확인
        //Debug.Log(gameObject.CompareTag("GOExample"));

        //5. Tag로 검색        
         // GameObject goWithTag1 = GameObject.FindWithTag("Player");
         // GameObject goWithTag2 = GameObject.FindWithTag("Finish");
         // Debug.Log(goWithTag1 != null);
         // Debug.Log(goWithTag1.name);
         // Debug.Log(goWithTag2 != null);
         // Debug.Log(goWithTag2.name);

        //6. 이름으로 검색
        // GameObject goWithFind1 = GameObject.Find("FindWithName");
        // GameObject goWithFind2 = GameObject.Find("FindWithName2");
        // Debug.Log(goWithFind1 != null);
        // Debug.Log(goWithFind2 != null);


        GameObject goTest = Instantiate(goPrefab);
        goTest.name = "Cube";
        goTest.transform.parent = goTestActiveParent.transform;
        goTest.transform.localPosition = Vector3.zero;
        goTest.transform.localRotation = Quaternion.identity;
        goTest.transform.localScale = Vector3.one;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
