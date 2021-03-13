using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    Animator playerAnimator;
    Rigidbody2D rb;
    PlayerColision playerColision;
    PlayerMovements playerMovements;
    public Transform groundCheck;

    void Start()
    {
        playerAnimator = GetComponent<Animator>();
        playerMovements = GetComponent<PlayerMovements>();
        playerColision = GetComponent<PlayerColision>();
    }

    void FixedUpdate()
    {
        playerAnimator.SetBool("Pulando", !playerColision.noChao);
        Debug.Log(!playerColision.noChao);

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
    }
}
