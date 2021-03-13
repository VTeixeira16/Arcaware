using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    private Rigidbody2D rb;
    private PlayerColision playerColision;
    private float _horizontal;

    [SerializeField] int jumpForce;
    

    public float horizontal
    {
        get {return _horizontal;}
    }

    [SerializeField]
    private int velocidadeMovimento;

    private bool viradoDireita, _pulando;
    
    public bool pulando
    {
        get { return _pulando; }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerColision = GetComponent<PlayerColision>();
        viradoDireita = true; // Padrao dos assets
    }

    void Update()
    {
        _pulando = false;
        _horizontal = Input.GetAxis("Horizontal");
        if (Input.GetButton("Jump"))
        {
            _pulando = true;
        }
    }

    private void FixedUpdate()
    {
        PlayerMovement(_horizontal);
        if(_pulando && playerColision.noChao)
        {
            PlayerJump();
        }


        Flip(_horizontal);
    }

    void PlayerMovement(float _horizontal)
    {
        rb.velocity = new Vector2(_horizontal * velocidadeMovimento, rb.velocity.y);

        if (transform.position.x < 0)
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
    }

    void PlayerJump()
    {
        Debug.Log("PlayerJump executado");
        rb.AddForce(new Vector2(0f, jumpForce));
        playerColision.noChao = false;
        // _pulando = false;
    }

    void Flip(float _horizontal)
    {
        if(_horizontal > 0 && !viradoDireita || _horizontal < 0 && viradoDireita)
        {
            viradoDireita = !viradoDireita;
            Vector2 theScale = transform.localScale;

            theScale.x *= -1; //Inverte valores entre negativo e positivo.

            transform.localScale = theScale;
        }
    }
}
