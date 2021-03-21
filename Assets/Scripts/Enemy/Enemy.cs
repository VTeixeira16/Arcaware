using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Persons_core
{
    void Update()
    {
        if (hp <= 0)
        {
            hp = 0;
            HpZerou();
        }
    }

    protected override void HpZerou()
    {
        Debug.Log("Vida zerada");
        Destroy(this.gameObject);
    }
}
