using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    bool _noChao;
    Rigidbody2D rb;

    public bool noChao
    {
        get { return _noChao; }
        set { _noChao = value; }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Debug.Log("Velocidade Y:" + rb.velocity.y);
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Chao"))
        {
            _noChao = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        switch (collider.gameObject.tag)
        {
            case "Moedas":
                Debug.Log("Tocou moeda");
                Destroy(collider.gameObject);
                this.GetComponent<Player>().moedas += 1;
                Debug.Log(this.GetComponent<Player>().moedas);
                break;
            default:
                break;

        }
    }

}
