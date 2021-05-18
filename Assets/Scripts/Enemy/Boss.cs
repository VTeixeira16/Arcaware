using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Persons_core
{
    Animator enemyAnimator;
    [SerializeField] GameObject PrefabInvocate;
    [SerializeField] GameObject[] InvocationPoints;

    void Start()
    {
        enemyAnimator = GetComponent<Animator>();

        for(int i = 0; i < InvocationPoints.Length; i++)
        {
            InvocateLancer(InvocationPoints[i]);
        }

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

    void InvocateLancer(GameObject InvocationPoint)
    {
        GameObject LancerInvocated = Instantiate(PrefabInvocate);
        LancerInvocated.transform.position = InvocationPoint.transform.position;
        Debug.Log(LancerInvocated.GetComponent<EnemyIA>().position[0].gameObject.transform.position.x);
    }

    protected override void HpZerou()
    {
        Destroy(this.gameObject);
    }
}
