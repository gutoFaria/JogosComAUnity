using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Limites : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Meteoro") || other.CompareTag("fogo") || other.CompareTag("meteoro2"))
        {
            Destroy(other.gameObject);
        }
    }
}
