using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _moedas;
    [SerializeField] int _municao;

    public int moedas{
        get { return _moedas;}
        set { _moedas = value;}
    }

    public int municao
    {
        get { return _municao; }
        set { _municao = value; }
    }
    void Start()
    {
        moedas = 0;
    }
}
