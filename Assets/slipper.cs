using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slipper : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("dsfskjfljs");
        }
    }
}
