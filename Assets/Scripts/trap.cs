using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Player pl = collision.gameObject.GetComponent<Player>();
            pl.lives --;
            pl.Invulnerability = true;
            if (pl.lives <= 0)
                _GLOBAL.LoadScene(0);
            else
                UI.ChangeLives(pl.lives);
        }
    }
}
