using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public MeteoroController inimiOriginal;
    public MeteoroController meteoro2;
    public MeteoroController meteoro3;
    private float tempoDeCriacao;
    private float tempoDeCriacao2;
    private float tempoDeCriacao3;
    // Start is called before the first frame update
    void Start()
    {
        this.tempoDeCriacao = 0;
        this.tempoDeCriacao2 = 0;
        this.tempoDeCriacao3 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        this.tempoDeCriacao  += Time.deltaTime;
        this.tempoDeCriacao2  += Time.deltaTime;
        this.tempoDeCriacao3  += Time.deltaTime;
        if(this.tempoDeCriacao >= 1)
        {
            this.tempoDeCriacao = 0;

            Vector2 posicaoMaxima = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
            Vector2 posicaoMinima = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
            float posicaoX = Random.Range(-2.1f,2.1f);
            Vector2 posicao = new Vector2(posicaoX,posicaoMaxima.y);
            //criar o inimigo
            //int i = Random.Range(0,5);
            Instantiate(inimiOriginal,posicao,Quaternion.identity);

           
        }
        else if(this.tempoDeCriacao2 >= 3)
        {
            this.tempoDeCriacao2 = 0;

            Vector2 posicaoMaxima = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
            Vector2 posicaoMinima = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
            float posicaoX = Random.Range(-2.1f,2.1f);
            Vector2 posicao = new Vector2(posicaoX,posicaoMaxima.y);
            //criar o inimigo
            //int i = Random.Range(0,5);
            Instantiate(meteoro2,posicao,Quaternion.identity);

            
        }
        else if(this.tempoDeCriacao3 >= 2)
        {
            this.tempoDeCriacao3 = 0;

            Vector2 posicaoMaxima = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
            Vector2 posicaoMinima = Camera.main.ViewportToWorldPoint(new Vector2(1,1));
            float posicaoX = Random.Range(-2.1f,2.1f);
            Vector2 posicao = new Vector2(posicaoX,posicaoMaxima.y);
            //criar o inimigo
            //int i = Random.Range(0,5);
            Instantiate(meteoro3,posicao,Quaternion.identity);

        }
    }
}
