using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Persons_core : MonoBehaviour
{
    [SerializeField] protected int _hp, _municao;

    public int hp
    {
        get { return _hp; }
        set { _hp = value; }
    }
    public int municao
    {
        get { return _municao; }
        set { _municao = value; }
    }

    void Update()
    {
        if (hp <= 0)
        {
            hp = 0;
            HpZerou();
        }
    }

    //Funcoes que devem ser implementadas indidualmente no player e enemy
    protected virtual void HpZerou() {}

}
