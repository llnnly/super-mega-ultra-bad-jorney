using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform player;
    private Vector3 pos;

    [SerializeField] float leftWall = 0.3f;
    [SerializeField] float rightWall = 41.6f;

    private void Awake()
    {
        
        if (!player)
            player = FindObjectOfType<Player>().transform;
    }

    private void Update()
    {
        pos = player.position;
        pos.z = -10f;
        pos.y = 0;

        if (pos.x > leftWall && pos.x < rightWall)
            transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime);
        else if (pos.x <= leftWall)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(leftWall, 0, -10f), Time.deltaTime);
        }
        else if (pos.x >= rightWall)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(rightWall, 0, -10f), Time.deltaTime);
        }
    }
}
