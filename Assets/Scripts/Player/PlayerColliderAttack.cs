using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColliderAttack : MonoBehaviour
{
    bool _colidindoInimigo;

    public bool colidindoPlayer
    {
        get { return _colidindoInimigo; }
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Inimigo")
        {
            _colidindoInimigo = true;
            if (collision.GetComponent<Enemy>())
                collision.GetComponent<Enemy>().hp--;
            else if (collision.GetComponent<Boss>())
                collision.GetComponent<Boss>().hp--;
            //Destroy(this);
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Inimigo")
        {
            _colidindoInimigo = false;
            //  Destroy(this);
        }
    }
}
