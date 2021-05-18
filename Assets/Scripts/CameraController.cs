using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    Transform player;
    Vector2 velocidade;

    [SerializeField]float SmoothTimeX;


    void Start()
    {
        player = GameObject.Find("Player").GetComponent<Transform>();
        //transform.position = player.transform.position;
    }

    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, player.position.x, ref velocidade.x, SmoothTimeX);

        transform.position = new Vector3(posX, transform.position.y, transform.position.z);
    }
}
