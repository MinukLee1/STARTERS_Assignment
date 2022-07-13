using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShooterRotator : MonoBehaviour
{

    private enum RotateState
    {
        Idle, Vertical, Horizontal, Ready
    }

    //enum : ���� ������� (=�÷���) -> ������ switch�� �����Ҷ� �ַ� �����
    //enum�� �⺻������ switch ����̱⿡ switch���� ���� �ſ� ����. ( ǥ���� �ξ� ���� )
    private RotateState state = RotateState.Idle;

    public float verticalRotatSpeed = 360f;

    public float horizontalRotateSpeed = 360f;


    //0 = Idle���  1= Ready ��� 2= Horizontal ��� 


    void Update()
    {
        switch (state)
        {
            case RotateState.Idle:
                //fire1�� �����Ǵ� ��ư�� ������ ���� state�� Horizontal�� ����(����)
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
                // GetButton: ��ư�� ������������, 
                if (Input.GetButton("Fire1"))
                {
                    // X�࿡ ���� ȸ�� 
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
