using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public LayerMask whatIsProp;


    public ParticleSystem explosionParticle;
    public AudioSource explosionAudio;

    public float maxDamage = 100f;
    public float explosionForce = 1000f;

    //10초이상 ball이 파괴안되면 -> 스스로 파괴
    public float lifeTime = 10f;

    public float explosionRadius = 20f;

    private void Start()
    {
        //파괴하고 싶은 오브젝트 & 시간을 넣음
        Destroy(gameObject,lifeTime);
    }

    private void OnTriggerEnter(Collider other) // Collider other : 충돌한 상대방
    {
        // 위치를 지정(구의중심,반지름) -> 그 위치에 겹치는 모든 collider들을 배열로 전부 가져온다.
        // + whatIsProp LayerMask 옵션을 추가해서 whatIsProp이 적용된 collider만을 걸러서 가져온다.
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius,whatIsProp);
        
        for(int i =0; i< colliders.Length; i++)
        {
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();


            //자동으로 어떤 힘만큼,어떤지점,반경 인지를지정해주면 튕겨나가는 효과를 재생
            targetRigidbody.AddExplosionForce(explosionForce,transform.position,explosionRadius);

            Prop targetProp = colliders[i].GetComponent<Prop>();

            float damage = CalculateDamage(colliders[i].transform.position);

            targetProp.TakeDamage(damage);
         }


        //explosionPartcle의 부모를 null = 자식의 부모를 없앰 = 자식이 부모에서 떨어져나감 
        // -> 부모인 Ball이 충돌하여 없어지면, 자식의 Parent를 null로 하여 파티클은 떨어져나가도록 설정
        //explosionParticle.transform.parent = null4;

        explosionParticle.Play();
        explosionAudio.Play();

        Destroy(explosionParticle.gameObject,explosionParticle.duration);
        Destroy(gameObject);
    }


    //상대방의 위치를 넣어주면, 본인에게서 떨어진 거리만큼 차등 데미지를 주는 함수 
    private float CalculateDamage(Vector3 targetPosition)
    {
        
        Vector3 explosionToTarget = targetPosition - transform.position;

        //magnitude : Vector3의 길이 
        float distance = explosionToTarget.magnitude;

        float edgeToCenterDistance = explosionRadius - distance;

        //안쪽으로 들어간 정도 
        float percentage = edgeToCenterDistance/explosionRadius;

        float damage = maxDamage * percentage;


        // 두수를 넣었을때 큰수를 반환해주는 함수 Max()
        //0과 damage -> 데미지가 collider 원에 걸쳐서 오히려 - (-damge)로 +가 되는것를 방지 
        damage = Mathf.Max(0,damage);

        return damage;
    }


}
