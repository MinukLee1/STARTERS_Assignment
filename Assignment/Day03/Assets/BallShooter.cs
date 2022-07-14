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

    //발사할때
    public AudioClip fireClip;

    //게이지를 채울때
    public AudioClip chargingClip;

    public float minForce = 15f;
    public float maxForce = 30f;
    public float chargingTime = 0.75f;
    
    private float currentForce;

    private float chargeSpeed;

    //한번 발사하면 다음라운드까지는 발사를 못하도록 boolean 체크용
    private bool fired;

    // 매 라운드마다 껐다 키도록 
    private void OnEnable()
    {
        currentForce = minForce;
        powerSlider.value = minForce;
        fired = false;

    }

    private void Start()
    {
        //1초에 force(힘)이 얼마나 충전되야 할지 계산하여 변수에 대입
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
            //발사처리 
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
            //발사처리 

        }
    }

    //발사처리
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
