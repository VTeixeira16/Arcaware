using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Plataforma : MonoBehaviour
{
    GameObject player;
    Transform playerTransform;
    Collider2D collider;

    void Start()
    {
        player = GameObject.Find("Player");
        playerTransform = player.GetComponent<Transform>();

        collider = GetComponent<Collider2D>();
    }


    void Update()
    {
        if(playerTransform.position.y < transform.position.y)
        {
            collider.isTrigger = true;
        }
        else if(playerTransform.position.y - 2 > transform.position.y)
        {
            collider.isTrigger = false;
        }
    }
}
