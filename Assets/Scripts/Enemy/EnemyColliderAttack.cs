using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyColliderAttack : MonoBehaviour
{
    bool _colidindoPlayer;

    public bool colidindoPlayer
    {
        get { return _colidindoPlayer;}
    }

    void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            _colidindoPlayer = true;
        }
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            _colidindoPlayer = false;
        }
    }
}
