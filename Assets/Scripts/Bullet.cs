using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void DecreaseLive(Collision2D collision)
    {
        collision.gameObject.GetComponent<Player>().lives--;
        UI.ChangeLives(collision.gameObject.GetComponent<Player>().lives);
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
