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

    //10���̻� ball�� �ı��ȵǸ� -> ������ �ı�
    public float lifeTime = 10f;

    public float explosionRadius = 20f;

    private void Start()
    {
        //�ı��ϰ� ���� ������Ʈ & �ð��� ����
        Destroy(gameObject,lifeTime);
    }

    private void OnTriggerEnter(Collider other) // Collider other : �浹�� ����
    {
        // ��ġ�� ����(�����߽�,������) -> �� ��ġ�� ��ġ�� ��� collider���� �迭�� ���� �����´�.
        // + whatIsProp LayerMask �ɼ��� �߰��ؼ� whatIsProp�� ����� collider���� �ɷ��� �����´�.
        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius,whatIsProp);
        
        for(int i =0; i< colliders.Length; i++)
        {
            Rigidbody targetRigidbody = colliders[i].GetComponent<Rigidbody>();


            //�ڵ����� � ����ŭ,�����,�ݰ� �������������ָ� ƨ�ܳ����� ȿ���� ���
            targetRigidbody.AddExplosionForce(explosionForce,transform.position,explosionRadius);

            Prop targetProp = colliders[i].GetComponent<Prop>();

            float damage = CalculateDamage(colliders[i].transform.position);

            targetProp.TakeDamage(damage);
         }


        //explosionPartcle�� �θ� null = �ڽ��� �θ� ���� = �ڽ��� �θ𿡼� ���������� 
        // -> �θ��� Ball�� �浹�Ͽ� ��������, �ڽ��� Parent�� null�� �Ͽ� ��ƼŬ�� �������������� ����
        //explosionParticle.transform.parent = null4;

        explosionParticle.Play();
        explosionAudio.Play();

        Destroy(explosionParticle.gameObject,explosionParticle.duration);
        Destroy(gameObject);
    }


    //������ ��ġ�� �־��ָ�, ���ο��Լ� ������ �Ÿ���ŭ ���� �������� �ִ� �Լ� 
    private float CalculateDamage(Vector3 targetPosition)
    {
        
        Vector3 explosionToTarget = targetPosition - transform.position;

        //magnitude : Vector3�� ���� 
        float distance = explosionToTarget.magnitude;

        float edgeToCenterDistance = explosionRadius - distance;

        //�������� �� ���� 
        float percentage = edgeToCenterDistance/explosionRadius;

        float damage = maxDamage * percentage;


        // �μ��� �־����� ū���� ��ȯ���ִ� �Լ� Max()
        //0�� damage -> �������� collider ���� ���ļ� ������ - (-damge)�� +�� �Ǵ°͸� ���� 
        damage = Mathf.Max(0,damage);

        return damage;
    }


}
