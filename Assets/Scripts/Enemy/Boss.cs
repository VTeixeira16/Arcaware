using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Persons_core
{
    Animator enemyAnimator;
    [SerializeField] GameObject PrefabInvocate;

    void Start()
    {
        enemyAnimator = GetComponent<Animator>();

    }

    void Update()
    {
        enemyAnimator.SetInteger("hp", _hp);

        if (hp <= 0)
        {
            hp = 0;
            if (enemyAnimator.GetCurrentAnimatorStateInfo(0).IsName("Boss_Death") &&
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
