using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RigidBody : MonoBehaviour
{
    private Animator animator;

    Rigidbody CharacterRigidBody;
    float playerSpeed = 4f;
    float playerJump = 6f;
    [SerializeField]
    private float X;
    [SerializeField]
    private float Z;
    //bool IsWalk = false;

    void Start()
    {
        CharacterRigidBody = gameObject.GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        Move();
        Jump();

       
    }


     void Move()
    {
        
        X = Input.GetAxis("Horizontal");
        Z = Input.GetAxis("Vertical");
        float fall = CharacterRigidBody.velocity.y;

        CharacterRigidBody.velocity = new Vector3(X * playerSpeed, fall, Z * playerSpeed);

        if (X != 0 || Z != 0)
        {
            animator.SetBool("isWalk", true);
        }
        else
        {
            animator.SetBool("isWalk", false);
        }
    }
    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CharacterRigidBody.AddForce(Vector3.up * playerJump, ForceMode.Impulse);
        }
    }
}
