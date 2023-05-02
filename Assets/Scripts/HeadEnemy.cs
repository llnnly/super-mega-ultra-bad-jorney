using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadEnemy : MonoBehaviour
{
    [SerializeField] private SpriteRenderer playerSprite;
    [SerializeField] private GameObject bulletSprite;
    private SpriteRenderer enemySprite;

    private GameObject bullet = null;

    [SerializeField] private Player player;

    private Vector2 enemyPos;
    private Vector2 playerPos;
    private Vector3 shootPos;
    private Vector3 bulletStartPos;

    private IEnumerator Fire()
    {
        while (true)
        {
            yield return new WaitForSeconds(3); //wait 3 seconds
            Destroy(bullet);
            bullet = Instantiate(bulletSprite);
            bullet.transform.position = enemySprite.transform.position;
            shootPos = playerSprite.transform.position;
            bulletStartPos = bullet.transform.position;
        }
    }

    private void Awake()
    {
        enemySprite = GetComponentInChildren<SpriteRenderer>();
    }

    void Start()
    {
        StartCoroutine(Fire());
    }

    void Update()
    {
        enemyPos = enemySprite.transform.position;
        playerPos = playerSprite.transform.position;
        playerPos.y += 3f;

        enemySprite.transform.position = Vector3.MoveTowards(enemyPos, playerPos, 4f * Time.deltaTime);
    }

    void FixedUpdate()
    {
        if (bullet)
        {
            Vector3 shootPos3 = shootPos;
            bullet.transform.position = Vector3.MoveTowards(bullet.transform.position, 
                shootPos + new Vector3(shootPos.x - bulletStartPos.x, shootPos.y - bulletStartPos.y, 0f) * 4, 
                10f * Time.deltaTime);
        }
    }
}
