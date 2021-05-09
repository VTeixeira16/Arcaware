using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    bool _noChao;
    Rigidbody2D rb;
    Player player;

    public bool noChao
    {
        get { return _noChao; }
        set { _noChao = value; }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        player = GetComponent<Player>();
    }

    private void Update()
    {
        // Debug.Log("Velocidade Y:" + rb.velocity.y);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Chao":
                _noChao = true;
                break;
            default:
                break;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.gameObject.tag)
        {
            case "Coletaveis":
                collider.GetComponent<Coletaveis>().FoiColetado();
                break;
            case "InimigoAttack":
                rb.velocity = new Vector2(rb.velocity.x, 0);
                rb.AddForce(new Vector2(0, 450));
                player.hp--;
                break;
            default:
                break;
        }
    }
}
