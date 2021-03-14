using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    Animator playerAnimator;
    Rigidbody2D rb;
    PlayerColision playerColision;
    PlayerController playerMovements;


    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerMovements = GetComponent<PlayerController>();
        playerColision = GetComponent<PlayerColision>();
    }

    void FixedUpdate()
    {
        playerAnimator.SetBool("Pulando", !playerColision.noChao);
        playerAnimator.SetInteger("Ataque", playerMovements.ataqueAtual);
        if(playerMovements.horizontal != 0 )
        {
            playerAnimator.SetBool("Correndo", true);
        }
        else
        {
            //Movimento apresenta um certo delay por causa do velocity.
            // Se necessario, deve funcionar quando a velocidade for maior que determinado parametro.
            playerAnimator.SetBool("Correndo", false);
        }        

        if(playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("Attack3") && 
           playerAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
        {
            playerMovements.ataqueAtual = 0;
        }
    }
}
