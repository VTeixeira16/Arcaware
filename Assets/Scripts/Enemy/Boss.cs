using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : Persons_core
{
    Animator enemyAnimator;
    [SerializeField] GameObject PrefabInvocate;
    [SerializeField] GameObject[] InvocationPoints;
    [SerializeField] GameObject BossPoint;
    Transform player;
    bool invocouLancers = false;
    float invocationTimer;
    //Em segundos
    [SerializeField] float invocationInterval;


    void Start()
    {
        enemyAnimator = GetComponent<Animator>();

        player = GameObject.Find("Player").GetComponent<Transform>();

    }

    void Update()
    {
        invocationTimer += Time.deltaTime;
        Debug.Log(invocationTimer);

        enemyAnimator.SetInteger("hp", _hp);

        if(invocationTimer > invocationInterval)
        {
            invocouLancers = false;
        }

        if(player.transform.position.x > BossPoint.transform.position.x && !invocouLancers)
        {
            for (int i = 0; i < InvocationPoints.Length; i++)
            {
                InvocateLancer(InvocationPoints[i]);
            }
            invocouLancers = true;
            invocationTimer = 0;
        }
        
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
