using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 8f; // скорость
    [SerializeField] private float jump = 15f;// прыжок
    private bool isGrounded = false;

    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    //private Animator anim;


    private int _lives = 3; // жизни
    [SerializeField] private Text _livesLabel;

    public int lives
    {
        get { return _lives; }
        set
        {
            if (value >= 0 && value <= 3)
            {
                _lives = value;
                _livesLabel.text = _lives.ToString() + " жизни";
            }
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        //anim = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Update()
    {
        //if (isGrounded) State = States.idle;

        if (Input.GetButton("Horizontal"))
            Run();
        if (isGrounded && Input.GetButtonDown("Jump"))
            Jump();
    }

    private void Run()
    {
        //if (isGrounded) State = States.run;

        Vector3 dir = transform.right * Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0.0f;
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jump, ForceMode2D.Impulse);
        lives -= 1;
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapBoxAll(transform.position, sprite.size, 0f);
        isGrounded = collider.Length > 1;
    }

    /*public enum States
    {
        idle,
        run
    }

    private States State
    {
        get { return (States)anim.GetInteger("state"); }
        set { anim.SetInteger("state", (int)value); }
    }*/
}
