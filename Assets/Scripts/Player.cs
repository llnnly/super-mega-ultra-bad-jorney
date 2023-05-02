using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;
using UnityEngine.UI;
using System.Timers;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed = 8f; // скорость
    [SerializeField] private float jump = 15f;// прыжок
    private bool isGrounded = false;

    private bool invulnerability = false;
    private Rigidbody2D rb;
    private SpriteRenderer sprite;
    private Collider2D plr;
    private Animator anim;
    public bool stopped = false;

    private static Timer aTimer = new System.Timers.Timer();
    private GameObject jumpSound;

    private int _lives = 3; // жизни
    [SerializeField] private Text _livesLabel;

    public bool Invulnerability
    {
        get { return invulnerability; }
        set
        {
            if (value && !aTimer.Enabled)
                aTimer.Enabled = true;
            invulnerability = value;
        }
    }

    private void OffInvulnerability(object source, System.Timers.ElapsedEventArgs e)
    {
        aTimer.Enabled = false;
        invulnerability = false;
    }

    public int lives
    {
        get { return _lives; }
        set
        {

            if (value >= 0 && value <= 3 && !invulnerability)
            {
                if (value < _lives)
                    anim.SetTrigger("Getting Damage");
                Debug.Log(value + " \"" + invulnerability + "\"");
                _lives = value;
            }
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sprite = GetComponentInChildren<SpriteRenderer>();
        plr = GetComponent<Collider2D>();
        aTimer.AutoReset = true;
        aTimer.Interval = 500;
        aTimer.Elapsed += OffInvulnerability;
    }

    private void Start()
    {
        jumpSound = transform.Find("jump").gameObject;
    }

    private void FixedUpdate()
    {
        CheckGround();
    }

    private void Update()
    {
        //if (isGrounded) State = States.idle;
        if (!stopped)
        {

            if (Input.GetButton("Horizontal"))
            {
                Run();
                anim.SetBool("Staying", false);
            }
            else
                anim.SetBool("Run", false);

            if (isGrounded && Input.GetButtonDown("Jump"))
            {
                anim.SetTrigger("Jump");
                Jump();
                jumpSound.GetComponent<AudioSource>().Play();
            }

            if (!isGrounded)
            {
                anim.SetBool("Falling", true);
                anim.SetBool("Run", false);
                anim.SetBool("Staying", false);
            }
            else
            {
                anim.SetBool("Falling", false);
            }

            if (isGrounded && !Input.GetButton("Horizontal") && !Input.GetButtonDown("Jump"))
            {
                anim.SetBool("Staying", true);
            }
        }
    }

    private void Run()
    {
        if (isGrounded)
            anim.SetBool("Run", true);

        Vector3 dir = transform.right * Input.GetAxis("Horizontal");

        transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, speed * Time.deltaTime);

        sprite.flipX = dir.x < 0.0f;
    }

    private void Jump()
    {
        rb.AddForce(transform.up * jump, ForceMode2D.Impulse);
    }

    private void CheckGround()
    {
        Collider2D[] collider = Physics2D.OverlapBoxAll(transform.position, plr.bounds.size, 0f);
        isGrounded = collider.Length > 1;
    }
}
