using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MeteoroController : MonoBehaviour
{
    
    private Rigidbody2D rb;

    //velocidades min e max
    private float velMin = 3f;
    private float velMax = 10f;

    private float velY;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        this.velY = Random.Range(this.velMin,this.velMax);
        
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(0,-this.velY);
    }

    public void Destruido()
    {
        Pontuacao.Pontos++;
        
        Destroy(this.gameObject);
    }
}
