using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateController : MonoBehaviour
{
    public float rotateSpeed;
    private float moveX;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //verifica a entrada do mouse
        // if(Input.GetMouseButton(0))
        // {
        //     moveX = Input.GetAxis("Mouse X");
        //     //3 paremetros (x,y,z) rotacionar apenas no eixo y
        //     transform.Rotate(0f,rotateSpeed * moveX * Time.deltaTime,0f);
        // }

        //touch do android
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if(touch.phase == TouchPhase.Moved)
            {
                Vector2 posicaoToque = new Vector2(0,touch.deltaPosition.x * -1);
                //converter em radianos
                transform.Rotate(posicaoToque * rotateSpeed * Time.deltaTime,Space.World);
            }
        }
    }
}
