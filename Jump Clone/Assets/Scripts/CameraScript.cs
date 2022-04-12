using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform bola;
    private Vector3 offset;
    public float lerpSpeed;
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - bola.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = Vector3.Lerp(transform.position, bola.position + offset,lerpSpeed);
        transform.position = newPos;
    }
}
