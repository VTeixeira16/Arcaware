using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ManagerCenas : MonoBehaviour
{
    GameController gameController;

    void Awake()
    {
        gameController = GameObject.Find("GameControle").GetComponent<GameController>();
    }

    public void CarregaCena(string scene)
    {        
        SceneManager.LoadScene(scene);
        gameController.levelTimer = 0;
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
