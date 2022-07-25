using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public GameObject targetPosition_1;
    public GameObject targetPosition_2;

    public bool check = false;
    public GameObject Player;
    void Start()
    {
        
    }




    void Update()
    {
        if (check == true)
        {
            transform.position = Vector3.Lerp(gameObject.transform.position, targetPosition_2.transform.position, 0.008f);

        }
        if (check == false)
        {
            transform.position = Vector3.Lerp(gameObject.transform.position, targetPosition_1.transform.position, 0.008f);

        }

    }

    public void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "wall_1")
        {
            check = true;
           
        }
        if (collision.gameObject.name == "wall_2")
        {
            check = false;
         }
        
        }
}
