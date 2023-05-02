using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

public class HeadEnemy : MonoBehaviour
{
    private Animator anim;

    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private GameObject bulletSprite;
    private SpriteRenderer enemySprite;

    private GameObject bullet = null;

    [SerializeField] private Player player;

    private Vector2 enemyPos;
    private Vector2 playerPos;
    private Vector3 shootPos;
    private Vector3 bulletStartPos;

    private GameObject sound;

    private IEnumerator Fire()
    {
        if (Mathf.Abs(playerSprite.transform.position.x - enemySprite.transform.position.x) < 10f)
        {
            while (true)
            {
                yield return new WaitForSeconds(3); //wait 3 seconds
                Destroy(bullet);
                anim.SetTrigger("Fire");
                bullet = Instantiate(bulletSprite);
                bullet.transform.position = enemySprite.transform.position;
                shootPos = playerSprite.transform.position;
                bulletStartPos = bullet.transform.position;
                float angle = (Mathf.Atan(shootPos.x - bulletStartPos.x) / (shootPos.y - bulletStartPos.y)) / Mathf.PI * 180;
                bullet.transform.Rotate(0f, 0f, -90 - angle);
                sound.GetComponent<AudioSource>().Play();
            }
        }
    }

    private void Awake()
    {
        enemySprite = GetComponentInChildren<SpriteRenderer>();
        anim = GetComponent<Animator>();
    }

    void Start()
    {
        sound = transform.Find("AudioSource").gameObject;
        StartCoroutine(Fire());
    }

    void Update()
    {   
        enemyPos = enemySprite.transform.position;
        playerPos = playerSprite.transform.position;
        playerPos.y += 3f;

        if (Mathf.Abs(playerPos.x - enemyPos.x) < 10f)
        {
            enemySprite.flipX = playerPos.x < enemySprite.transform.position.x;
            enemySprite.transform.position = Vector3.MoveTowards(enemyPos, playerPos, 4f * Time.deltaTime);

        }
    }

    void FixedUpdate()
    {
        if (bullet && Mathf.Abs(playerPos.x - enemyPos.x) < 10f)
        {
            Vector3 shootPos3 = shootPos;
            bullet.transform.position = Vector3.MoveTowards(bullet.transform.position,
                shootPos + new Vector3(shootPos.x - bulletStartPos.x, shootPos.y - bulletStartPos.y, 0f) * 4,
                10f * Time.deltaTime);
        }

    }

    //public enum States
    //{
    //    Head,
    //    Fire
    //}

    //private States State
    //{
    //    get { return (States)anim.GetInteger("state"); }
    //    set { anim.SetInteger("state", (int)value); }
    //}
}
