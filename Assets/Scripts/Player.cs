using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Core.Movement;

public class Player : MonoBehaviour
{

    [SerializeField]
    float moveSpeed = 0f;

    Animator anim;
    SpriteRenderer spr;

    float moveX;
    [SerializeField]
    AudioClip sfx_coin;
    [SerializeField]
    AudioClip sfx_jump;
    [SerializeField]
    AudioClip sfx_win;
    [SerializeField]
    AudioClip sfx_dead;
    AudioSource auds;

    Rigidbody2D rb2d;
    [SerializeField, Range(0.1f, 15f)]
    float jumpForce = 3f;

    [SerializeField]
    Color rayColor = Color.magenta;
    [SerializeField, Range(0.1f, 10f)]
    float rayLenght;
    [SerializeField]
    LayerMask detectionLayer;
    [SerializeField]
    Vector2 rayPosition;
    [SerializeField, Range(1f, 10f)]
    float maxSpeed = 3f;
    Vector2 ClampedVelocity;


    void Start()
    {
        anim = GetComponent<Animator>();
        spr = GetComponent<SpriteRenderer>();
        auds = GetComponent<AudioSource>();
        rb2d = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        moveX = Movement.Axis.x;

        //Movement.DeltaMovement(transform, moveSpeed);

        anim.SetFloat("MoveX", Mathf.Abs(moveX));

        spr.flipX = moveX < 0f ? true : moveX > 0f ? false : spr.flipX;

    }
    public void UpdateState(string state = null)
    {
        if(state != null)
        {
            anim.Play(state);
        }
    }
    private void FixedUpdate()
    {

        Movement.PhysicMovement(rb2d, moveSpeed, maxSpeed);
        if (Movement.btn_Jump && Grounding)
        {
            auds.PlayOneShot(sfx_jump, 3f);

            Movement.PhysicJumpUp(rb2d, jumpForce);
            UpdateState("jump");

        }

    }


    public void PlayCoinSFX()
    {
        auds.PlayOneShot(sfx_coin, 4f);
    }

    public void PlayWinSFX()
    {
        auds.PlayOneShot(sfx_win, 4f);
    }
    public void PlayDeadSFX()
    {
        auds.PlayOneShot(sfx_dead, 30f);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = rayColor;
        Gizmos.DrawRay(transform.position + (Vector3)rayPosition, Vector2.down * rayLenght);
    }

    bool Grounding
    {
        get => Physics2D.Raycast(transform.position + (Vector3)rayPosition, Vector2.down, rayLenght, detectionLayer);
    }
}
