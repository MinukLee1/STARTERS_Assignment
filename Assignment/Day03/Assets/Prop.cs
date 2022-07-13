using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    // prop 자기자신이 파괴될때 마다 오를 점수 (score)
    public int score = 5;

    // prop이 파괴될때마다 실시간으로 찍어낼 파티클(효과) GameObject 생성
    public ParticleSystem explosionParticle;

    // prop의 hp
    public float hp = 100f; 

    public void TakeDamage(float damage)
    {
        // hp = hp - damage;
        hp -= damage;

        if(hp <= 0)
        {
            // Instantiate 함수는 그 안에 원본 GameObject를 넣어주면 그것을 새로 하나 복사해주는 함수. 
           ParticleSystem instance = Instantiate(explosionParticle,transform.position ,transform.rotation);

            /*AudioSource explosionAudio = instance.GetComponent<AudioSource>();
            explosionAudio.Play();*/
            
            
            Destroy(instance.gameObject, instance.duration);
            //prop object를 끄고 키며 수행 
            gameObject.SetActive(false);
        }


    }

}
