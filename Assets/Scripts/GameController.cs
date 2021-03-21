using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //TODO GAMECONTROLLER DEVE SER MIGRADAO PARA Primeira tela de carregamento, para evitar que varias sejam criados

    [SerializeField] private int pontuacao;

    private int _moedas;

    public int moedas
    {
        get { return _moedas; }
        set { _moedas = value; }
    }

    private void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    void Start()
    {

    }


    void Update()
    {
        //Debug.Log("Pontuacao:" + pontuacao);
    }
}
