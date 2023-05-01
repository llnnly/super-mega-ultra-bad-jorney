using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slipper : MonoBehaviour
{
    int TICK_COUNT_MOVEMENT = 400;
    int ticks = 0;
    bool direction;
    float x_scale;
    float y_scale;
    float z_scale;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().lives = 3;
            _GLOBAL.LoadScene(0);
        }
    }

    private void Start()
    {
        x_scale = this.gameObject.transform.localScale.x;
        y_scale = this.gameObject.transform.localScale.y;
        z_scale = this.gameObject.transform.localScale.z;
    }

    private void Update()
    {
        if (ticks < TICK_COUNT_MOVEMENT)
        {
            Vector3 dir = -transform.right;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, 5f * Time.deltaTime);
        }
        else if (ticks == TICK_COUNT_MOVEMENT)
            this.gameObject.transform.localScale = new Vector3(-1* x_scale, y_scale, z_scale);
        else if (ticks < TICK_COUNT_MOVEMENT * 2)
        {
            Vector3 dir = transform.right;
            transform.position = Vector3.MoveTowards(transform.position, transform.position + dir, 5f * Time.deltaTime);
        }
        else
        {
            ticks = 0;
            this.gameObject.transform.localScale = new Vector3(1* x_scale, y_scale, z_scale);
        }

        ticks++;
    }
}
