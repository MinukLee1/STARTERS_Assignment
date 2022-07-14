using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallShooter : MonoBehaviour
{
    public Rigidbody ball;
    public Transform firePos;
    public Slider powerSlider;
    public AudioSource shootingAudio;

    //�߻��Ҷ�
    public AudioClip fireClip;

    //�������� ä�ﶧ
    public AudioClip chargingClip;

    public float minForce = 15f;
    public float maxForce = 30f;
    public float chargingTime = 0.75f;
    
    private float currentForce;

    private float chargeSpeed;

    //�ѹ� �߻��ϸ� ������������� �߻縦 ���ϵ��� boolean üũ��
    private bool fired;

    // �� ���帶�� ���� Ű���� 
    private void OnEnable()
    {
        currentForce = minForce;
        powerSlider.value = minForce;
        fired = false;

    }

    private void Start()
    {
        //1�ʿ� force(��)�� �󸶳� �����Ǿ� ���� ����Ͽ� ������ ����
        chargeSpeed = (maxForce - minForce) / chargingTime;
    }

    private void Update()
    {
        if(fired == true)
        {
            return;
        }

        powerSlider.value = minForce;

        if(currentForce >= maxForce && !fired)
        {
            currentForce = maxForce;
            Fire();
            //�߻�ó�� 
        }
        else if (Input.GetButtonDown("Fire1"))
        {
            fired = false;
            currentForce = minForce;

            shootingAudio.clip = chargingClip;
            shootingAudio.Play();
        }
        else if(Input.GetButton("Fire1") && !fired)
        {
            currentForce = currentForce + chargeSpeed * Time.deltaTime;

            powerSlider.value = currentForce;
        }
        else if (Input.GetButtonUp("Fire1") && !fired)
        {
            Fire();
            //�߻�ó�� 

        }
    }

    //�߻�ó��
    private void Fire()
    {
        fired = true;

        Rigidbody ballInstance = Instantiate(ball,firePos.position,firePos.rotation);
        ballInstance.velocity = currentForce * firePos.forward;

        shootingAudio.clip = fireClip;
        shootingAudio.Play();

        currentForce = minForce;
    }
    


}
