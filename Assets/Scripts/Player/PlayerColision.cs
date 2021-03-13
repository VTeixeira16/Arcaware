using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColision : MonoBehaviour
{
    bool _noChao;
    
    public bool noChao
    {
        get { return _noChao; }
        set { _noChao = value; }
    }


    void OnCollisionEnter2D(Collision2D collision)
    {
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Chao"))
        {
            _noChao = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        switch (collision.gameObject.tag)
        {
            case "Moedas":
                Debug.Log("Tocou moeda");
                Destroy(collision.gameObject);
                this.GetComponent<Player>().moedas += 1;
                Debug.Log(this.GetComponent<Player>().moedas);
                break;


            default:
                break;

        }
    }

}
