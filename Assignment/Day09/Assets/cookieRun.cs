using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cookieRun : MonoBehaviour
{
    public GameObject Player;
    public GameObject Regen;

    void Start()
    {
    }
    
    void Update()
    {

    }
    // Enemy ¡¢√ÀΩ√ Life -1
     public void OnTriggerEnter(Collider Player)
    {

        Debug.Log(" Game Over !");
        Player.transform.position = Regen.transform.position;

        
    }

    



}
