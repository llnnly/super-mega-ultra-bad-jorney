using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trap : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("collision with trap");
            collision.gameObject.GetComponent<Player>().lives --;
            if (collision.gameObject.GetComponent<Player>().lives == 0)
            {
                _GLOBAL.LoadScene(0);
            }
            else
            {
                UI.ChangeLives(collision.gameObject.GetComponent<Player>().lives);
            }
        }
    }
}
