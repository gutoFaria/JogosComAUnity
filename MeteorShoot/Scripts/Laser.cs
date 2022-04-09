using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Rigidbody2D rb;
    private float speed = 8f;

    // Start is called before the first frame update
    void Start()
    {
        this.rb.velocity = new Vector2(0,this.speed);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Meteoro"))
        {
            //Destroy(other.gameObject);
            MeteoroController meteoro = other.GetComponent<MeteoroController>();
            meteoro.Destruido();
            Destroy(this.gameObject);
        }
    }
}
