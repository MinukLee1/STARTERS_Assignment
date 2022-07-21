using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ComponentExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //AudioSource asrc = transform.AddComponent<AudioSource>();
        AudioSource asrc = transform.GetComponent<AudioSource>();

        transform.GetComponent<Component>();
        
        Component[] com = transform.GetComponentsInChildren<Component>(true);
        AudioSource[] asrcArray = transform.GetComponentsInChildren<AudioSource>(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
