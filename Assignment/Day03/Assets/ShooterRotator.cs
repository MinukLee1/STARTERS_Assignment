using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterRotator : MonoBehaviour
{

    private enum RotateState
    {
        Idle, Vertical, Horizontal, Ready
    }

    //enum : 보통 현재상태 (=플래그) -> 상태의 switch가 가능할때 주로 사용함
    //enum은 기본적으로 switch 방식이기에 switch문과 상성이 매우 좋다. ( 표현이 훨씬 쉬움 )
    private RotateState state = RotateState.Idle;

    public float verticalRotatSpeed = 360f;

    public float horizontalRotateSpeed = 360f;


    //0 = Idle취급  1= Ready 취급 2= Horizontal 취급 


    void Update()
    {
        switch (state)
        {
            case RotateState.Idle:
                //fire1에 대응되는 버튼을 누르는 순간 state를 Horizontal로 변경(수평)
                if (Input.GetButtonDown("Fire1"))
                {
                    state = RotateState.Horizontal;
                }
                break;
            case RotateState.Horizontal:
                if (Input.GetButton("Fire1"))
                {
                    transform.Rotate(new Vector3(0, horizontalRotateSpeed * Time.deltaTime, 0));
                }
                else if (Input.GetButtonUp("Fire1"))
                {
                    state = RotateState.Vertical;
                }
                break;
            case RotateState.Vertical:
                // GetButton: 버튼을 누르고있을떄, 
                if (Input.GetButton("Fire1"))
                {
                    // X축에 대한 회전 
                    transform.Rotate(new Vector3(-verticalRotatSpeed * Time.deltaTime, 0, 0));
                }
                else if (Input.GetButtonUp("Fire1"))
                {
                    state = RotateState.Ready;
                }
                break;
            case RotateState.Ready:
                break;
        }
    }
}
