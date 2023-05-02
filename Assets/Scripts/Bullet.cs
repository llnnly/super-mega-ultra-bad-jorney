using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void DecreaseLive(Collision2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();
        player.lives--;
        UI.ChangeLives(player.lives);
        if (player.lives <= 0)
        {
            player.lives = 3;
            _GLOBAL.LoadScene(0);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            DecreaseLive(collision);
        }
        Destroy(gameObject);
    }
}
