using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiroController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Para sumir quando sair da tela
    private void OnBecameInvisible()
    {
        Destroy(this.gameObject);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(this.gameObject);

        //Destroi objeto que receber tiro
        if (collision.gameObject.tag.Equals("Inimigo"))
        {
            collision.gameObject.GetComponent<Enemy>().hp -= 1;
        }
    }
}
