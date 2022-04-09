using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //velocidade da nave
    private float speed = 8f;
    //deslocar pelo rigidybody2D
    private Rigidbody2D rb;

    public Laser laserPrefab;
    private float intervaloTiro;

    public Transform[] posicaoArma;
    private Transform armaAtual;
    // Start is called before the first frame update
    void Start()
    {
        //inicializar o rigidybody
        rb = GetComponent<Rigidbody2D>();
        Pontuacao.Pontos = 0;

        this.intervaloTiro = 0;

        this.armaAtual = this.posicaoArma[0];
    }

    // Update is called once per frame
    void Update()
    {
        // if(Input.GetButton("Fire1"))
        // {}
        this.intervaloTiro += Time.deltaTime;
        if(this.intervaloTiro >= 0.45f)
        {
            this.intervaloTiro = 0;
            Shoot();
        }
        //chamada das funções
        MoveController();


        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                transform.position += (Vector3)touch.deltaPosition/300;
            }
        }
    }

    //função de Deslocamento
    private void MoveController()
    {
        float horizontal = Input.GetAxisRaw("Horizontal") * Time.deltaTime;
        float vertical = Input.GetAxisRaw("Vertical") * Time.deltaTime;

        //mudar a posição
        rb.velocity = new Vector2(horizontal,vertical).normalized * speed;

        
    }

    private void Shoot()
    {
        Instantiate(this.laserPrefab,this.posicaoArma[0].position,Quaternion.identity);
        // if(this.armaAtual == this.posicaoArma[0])
        // {
        //     this.armaAtual = this.posicaoArma[1];
        // }
        // else
        // {
        //     this.armaAtual = posicaoArma[0];
        // }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Meteoro"))
        {
            Destroy(other.gameObject);
            MeteoroController meteoro = other.GetComponent<MeteoroController>();
            meteoro.Destruido();
            //Destroy(this.gameObject);
            Pontuacao.Danos++;
        }
    }
}
