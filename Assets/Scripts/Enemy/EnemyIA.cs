using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIA : MonoBehaviour
{

    [SerializeField] Transform inimigo;
    [SerializeField] Transform[] position;
    [SerializeField] float velocidade;
    [SerializeField] bool viradoDireita;

    /*[SerializeField] */ SpriteRenderer inimigoSprite;
    private int idAlvo;

    void Start()
    {
        inimigoSprite = inimigo.gameObject.GetComponent<SpriteRenderer>();
        inimigo.position = position[0].position;
        idAlvo = 1;
    }

    void Update()
    {
        if(inimigo != null)
        {
            inimigo.position = Vector3.MoveTowards(inimigo.position, position[idAlvo].position, velocidade * Time.deltaTime);
        
            if(inimigo.position == position[idAlvo].position)
            {
                idAlvo += 1;

                if(idAlvo == position.Length)
                {
                    idAlvo = 0;
                }
            }

            if(position[idAlvo].position.x < inimigo.position.x && viradoDireita == true)
            {
                Flip();
            }
            else if(position[idAlvo].position.x > inimigo.position.x && viradoDireita == false)
            {
                Flip();
            }

        }
    }

    void Flip()
    {
        viradoDireita = !viradoDireita;
        inimigoSprite.flipX = !inimigoSprite.flipX;
    }
}
