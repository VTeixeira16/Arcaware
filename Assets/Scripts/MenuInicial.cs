using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class MenuInicial : MonoBehaviour
{
    [SerializeField]
    private Text JogarTxt, SairTxt;
    /*
    private Text JogarTxt, LojaTxt, ConfiguracoesTxt, SairTxt, // Botoes
                txtGameName, txtVersao; // Textos*/

    //[SerializeField] private MusicManager musicManager;

    public void Start()
    {
        JogarTxt.text = "Jogar";

        SairTxt.text = "Sair";

        //musicManager.PlayMusica("MusicaMenu");
        /*
        txtGameName.text = "SMAUG (misterious_name)";
        txtVersao.text = "Alpha 0.0v";


        LojaTxt.text = "Loja";
        ConfiguracoesTxt.text = "Configurações";
        SairTxt.text = "Sair";

        Debug.Log("ROdando");
        */
    }

}
