using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slipper : MonoBehaviour
{

    int ticks = 0;
    bool direction;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().lives = 3;
            _GLOBAL.LoadScene(0);
        }
    }

    private void Update()
    {
        if (ticks <= 180)
        {
            Vector3 dir = -transform.right;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, 5f * Time.deltaTime);
        }
        else if (ticks <= 360)
        {
            Vector3 dir = transform.right;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, 5f * Time.deltaTime);
        }
        else
            ticks = 0;

        ticks++;
    }
}
