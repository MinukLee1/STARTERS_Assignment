using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorExample : MonoBehaviour
{
    Vector3 vec = new Vector3(0,0,0);
    Vector3 vec2 = new Vector3(10,10,10);
    float currentVel;

    // Start is called before the first frame update
    void Start()
    {
       

        Debug.Log(vec2.magnitude);
        Debug.Log(vec2.normalized);

        //Vector3.one;
        //Vector3.zero;
        //Vector3.left;
        //Vector3.right;
        //Vector3.up;
        //Vector3.down;

        Debug.Log(Vector3.Distance(vec, vec2));

    }

    // Update is called once per frame
    void Update()
    {
        var currentVel = Vector3.one; 
        Debug.Log(Vector3.Lerp(vec, vec2, Time.deltaTime));
        Debug.Log(Vector3.SmoothDamp(vec,vec2, ref currentVel, Time.deltaTime));
        
        //Debug.Log(Input.GetKey(KeyCode.A));
        //Input.GetMouseButton(0);
        //0 for left button, 1 for right button, 2 for the middle button
        //Input.GetKeyDown(KeyCode.A);
        //Input.GetKeyUp(KeyCode.A);
            

    }
}
