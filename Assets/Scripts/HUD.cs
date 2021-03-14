using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{

    [SerializeField] Text moedasHUD_txt_num;
    [SerializeField] GameObject player;

    //string moedas_txt = "Moedas";
    int moedas_num;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        moedas_num = player.GetComponent<Player>().moedas;
        //moedasHUD_txt_num.text = moedas_txt + ": " + moedas_num;
        moedasHUD_txt_num.text = moedas_num.ToString();
    }
}