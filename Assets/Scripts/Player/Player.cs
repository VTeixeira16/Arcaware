using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int _moedas;


    public int moedas{
        get { return _moedas;}
        set { _moedas = value;}
    }
    void Start()
    {
        moedas = 0; //
    }

    
    void Update()
    {
        
    }
}
