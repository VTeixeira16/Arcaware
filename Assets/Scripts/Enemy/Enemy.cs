using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Persons_core
{

    Animator enemyAnimator;
    [SerializeField] EnemyColliderAttack ColliderAttack;

    void Start()
    {
        enemyAnimator = GetComponent<Animator>();
    }

    void Update()
    {
        enemyAnimator.SetBool("Atacando", ColliderAttack.colidindoPlayer);
        enemyAnimator.SetInteger("hp", _hp);
        Debug.Log("hp enemy: " + _hp);
        if (hp <= 0)
        {
            hp = 0;

            if(enemyAnimator.GetCurrentAnimatorStateInfo(0).IsName("C_Lancer_Death") &&
               enemyAnimator.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            {
                HpZerou();
            }
        }
    }

    protected override void HpZerou()
    {
        Destroy(this.gameObject);
    }
}
