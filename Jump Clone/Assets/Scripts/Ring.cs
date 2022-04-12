using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ring : MonoBehaviour
{
    public Transform ball;
    private GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y + -1.5f >= ball.transform.position.y)
        {
            Destroy(gameObject);
            gameManager.GameScore(10);
        }
    }
}
