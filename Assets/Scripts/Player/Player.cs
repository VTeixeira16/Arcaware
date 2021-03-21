using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class Player : Persons_core
{


    protected override void HpZerou()
    {
        Invoke("ReiniciaFase", 2f);
    }

    private void OnBecameInvisible()
    {
        _hp = 0;
    }

    void ReiniciaFase()
    {
        //TODO deve ir para uma cena de Menu e não para a tela inicial
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        //SceneManager.LoadScene("MenuInicial");
    }
}
