using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    PlayerColision playerColision;
    Player player;
    float _horizontal;

    [SerializeField] Transform _bala;

    [SerializeField] GameObject tiroPrefab;
    [SerializeField] float velocidadeTiro, delayTiro;
    byte _ataqueAtual = 0;
    bool tiroDisparado, viradoDireita, _pulando;
    [SerializeField] int jumpForce, velocidadeMovimento;

    public byte ataqueAtual
    {
        get { return _ataqueAtual; }
        set { _ataqueAtual = value; }

    }

    public Transform bala
    {
        get { return _bala; }
    }

    public float horizontal
    {
        get {return _horizontal;}
    }

    public bool pulando
    {
        get { return _pulando; }
    }

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        playerColision = GetComponent<PlayerColision>();
        player = GetComponent<Player>();
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

        if(Input.GetButton("Fire1") && !tiroDisparado && player.municao > 0)
        {
            //Só atira se tiver parado e no chao
            //if(rb.velocity.x == 0 && playerColision.noChao)
            {
                Atirar();
            }
        }
    }

    private void FixedUpdate()
    {
        PlayerMovement(_horizontal);
        if(_pulando && playerColision.noChao)
        {
            PlayerJump();
        }

        if (_horizontal > 0 && !viradoDireita || _horizontal < 0 && viradoDireita)
        {
            Flip(_horizontal);
        }
    }

    void PlayerMovement(float _horizontal)
    {
        rb.velocity = new Vector2(_horizontal * velocidadeMovimento, rb.velocity.y);

        if (transform.position.x < 0)
            transform.position = new Vector3(0, transform.position.y, transform.position.z);
    }

    void PlayerJump()
    {
        // Debug.Log("PlayerJump executado");
        rb.AddForce(new Vector2(0f, jumpForce));
        playerColision.noChao = false;
        // _pulando = false;
    }

    void Flip(float _horizontal)
    {
        viradoDireita = !viradoDireita;
        Vector2 theScale = transform.localScale;

        theScale.x *= -1; //Inverte valores entre negativo e positivo.

        velocidadeTiro *= -1;
        transform.localScale = theScale;
    }

    void Atirar()
    {
        tiroDisparado = true;
        _ataqueAtual = 3;
        player.municao -= 1;

        StartCoroutine("tempoTiro");

        GameObject temporarioTiro = Instantiate(tiroPrefab);
        temporarioTiro.transform.position = bala.position;

        if(!viradoDireita)
        {
            temporarioTiro.GetComponent<SpriteRenderer>().flipX = true;
        }

        temporarioTiro.GetComponent<Rigidbody2D>().velocity = new Vector2(velocidadeTiro, 0);

    }

    IEnumerator tempoTiro()
    {
        yield return new WaitForSeconds(delayTiro);
        tiroDisparado = false;
    }
}
