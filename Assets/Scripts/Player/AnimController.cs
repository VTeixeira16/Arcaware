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
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        //TODO Para movimento ficar mais fluido, melhor vincular com teclado.
        //Debug.Log("SPEED: " + rb.velocity.x + " VirDireita: " + playerMovements.viradoDireita );
        playerAnimator.SetBool("Pulando", !playerColision.noChao);
        playerAnimator.SetInteger("Ataque", playerMovements.ataqueAtual);
        if(rb.velocity.x > 0.5f && playerMovements.viradoDireita ||
           rb.velocity.x < -0.5f && !playerMovements.viradoDireita)
        {
            playerAnimator.SetBool("Correndo", true);
        }
        else
        {
            //Movimento apresenta um certo delay por causa do velocity.
            // Se necessario, deve funcionar quando a velocidade for maior que determinado parametro.
            playerAnimator.SetBool("Correndo", false);
        }

        if((playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("Player_Attack1") && playerAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.7f)
            || (playerAnimator.GetCurrentAnimatorStateInfo(0).IsName("Player_Attack1_run") && playerAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 0.5f))           
        {
            playerMovements.ataqueAtual = 0;
        }
    }
}
