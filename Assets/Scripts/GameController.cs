using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    //TODO GAMECONTROLLER DEVE SER MIGRADAO PARA Primeira tela de carregamento, para evitar que varias sejam criados

    [SerializeField] int _pontuacao;

    int _moedas;

    public int moedas
    {
        get { return _moedas; }
        set { _moedas = value; }
    }

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);

        CarregaDados();
        ApagaDados();

    }


    void GravaDados()
    {
        PlayerPrefs.SetInt("vidas_do_player", 3);
        PlayerPrefs.SetInt("pontuacao_do_player", 0);
        PlayerPrefs.SetString("nome_do_player", "Victor");
    }

    void CarregaDados()
    {
        _pontuacao = PlayerPrefs.GetInt("pontuacao_do_player");
    }

    void ApagaDados()
    {
        PlayerPrefs.DeleteKey("nome_do_player");
    }
    void ApagaTodosOsDados()
    {
        PlayerPrefs.DeleteAll();
    }

    void Update()
    {
        Debug.Log("Pontuacao:" + _pontuacao);
    }
}
