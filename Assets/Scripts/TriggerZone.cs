using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerZone : MonoBehaviour
{
    public bool isActive = false;
    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.CompareTag("Player"))
        {
            
            isActive = true;
        }
    }

}
