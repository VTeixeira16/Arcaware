using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coletaveis : MonoBehaviour
{
    protected GameController gameController;

    private void Awake()
    {
        gameController = GameObject.Find("GameControle").GetComponent<GameController>();
    }
    public virtual void FoiColetado()
    {
        Destroy(this.gameObject);
    }
}
