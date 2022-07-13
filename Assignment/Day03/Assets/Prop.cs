using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prop : MonoBehaviour
{
    // prop �ڱ��ڽ��� �ı��ɶ� ���� ���� ���� (score)
    public int score = 5;

    // prop�� �ı��ɶ����� �ǽð����� �� ��ƼŬ(ȿ��) GameObject ����
    public ParticleSystem explosionParticle;

    // prop�� hp
    public float hp = 100f; 

    public void TakeDamage(float damage)
    {
        // hp = hp - damage;
        hp -= damage;

        if(hp <= 0)
        {
            // Instantiate �Լ��� �� �ȿ� ���� GameObject�� �־��ָ� �װ��� ���� �ϳ� �������ִ� �Լ�. 
           ParticleSystem instance = Instantiate(explosionParticle,transform.position ,transform.rotation);

            /*AudioSource explosionAudio = instance.GetComponent<AudioSource>();
            explosionAudio.Play();*/
            
            
            Destroy(instance.gameObject, instance.duration);
            //prop object�� ���� Ű�� ���� 
            gameObject.SetActive(false);
        }


    }

}
