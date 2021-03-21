using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Moedas : Coletaveis
{
    public override void FoiColetado()
    {
        //Executa primeiro a funcao FoiColetado de Coletaveis.
        base.FoiColetado();
        gameController.moedas += 1;
    }
}
