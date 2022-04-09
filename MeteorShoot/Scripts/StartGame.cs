using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    //return menu
    public GameObject player;
    public GameObject panelInicial;
    // Start is called before the first frame update

    //vidas
    public GameObject[] vidas;
    void Start()
    {
        player.SetActive(false);
        panelInicial.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ComecaJogo()
    {
        Pontuacao.Pontos = 0;
        foreach (GameObject vida in vidas)
        {
            vida.SetActive(true);
        }

        player.SetActive(true);
        panelInicial.SetActive(false);
    }

    public void EndGame()
    {
        Application.Quit();
    }

    public void ReturnMenu()
    {
        player.SetActive(false);
        panelInicial.SetActive(true);
    }
}
