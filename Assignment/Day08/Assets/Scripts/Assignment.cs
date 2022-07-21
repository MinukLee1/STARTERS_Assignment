using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Assignment : MonoBehaviour
{
    [SerializeField]
    private GameObject goPrefab;
    private GameObject cam;
    private Transform spawnerPosition;
    // Start is called before the first frame update

    Vector3 vec3 = new Vector3(10,10,10);
    void Start()
    {

        GameObject go1 = Instantiate(goPrefab);

        GameObject go1_1 = Instantiate(goPrefab);
        go1_1.transform.SetParent(go1.transform);
        GameObject go1_2 = Instantiate(goPrefab);
        go1_2.transform.SetParent(go1.transform);
        GameObject go1_1_1 = Instantiate(goPrefab);
        go1_1_1.transform.SetParent(go1_1.transform);
        GameObject go1_2_1 = Instantiate(goPrefab, spawnerPosition.position, spawnerPosition.rotation);
        go1_2_1.transform.SetParent(go1_2.transform);

        go1.name = "1";
        go1_1.name = "1-1";
        go1_2.name = "1-2";
        go1_1_1.name = "1-1-1";
        go1_2_1.name = "1-2-1";
        // 1. Instantiate를 이용해 오브젝트를 5개 생성해주세요 
        // 이름은 1, 1-1, 1-2, 1-1-1, 1-2-1 로 생성해주세요.
        //
        // 2. 아래와 같이 하이어라키를 구성하게끔 코드를 작성해주세요
        // 1--- (1-1) 
        //    |   ㄴ (1-1-1)
        //    ㄴ (1-2)
        //        ㄴ (1-2-1)
        // 
        //    
        // 3. Transform.Find("")를 이용하여 자식을 전부 순회하는 코드를 작성해주세요
        //

        //transform.Find("1").gameObject.SetActive(false);
        //transform.Find("go1").gameObject.SetActive(false);

        Debug.Log(go1.transform.childCount);

        Getchild_1(go1.transform);

        
    }

    void Getchild_1(Transform go1)
    {
        for (int i = 0; i < go1.childCount; i++)
        {

            Debug.Log($"{go1}의 child { go1.Find(go1.GetChild(i).name)}");

            if (go1.GetChild(i).childCount > 0)
            {
                Getchild_1(go1.GetChild(i));
            }
        }

    }



    // 4. -------------------
    //    |        |        |
    //    |        |        |
    //    |________|________|
    //    위와 같이 화면을 분할해주세요
    //
    // 5. 왼쪽 화면에 (1-1-1) 오른쪽 화면에 (1-2-1) 오브젝트를 각각 배치해주세요
    //
    // 
    // 6. 왼쪽 화살표 키를 누를 시에 1-1-1 오브젝트를 3초후 파괴
    //    오른쪽 화살표 키를 누를 시에 1-2-1 오브젝트를 3초후 파괴


    // Update is called once per frame
    void Update()
    {
        
    }
}
