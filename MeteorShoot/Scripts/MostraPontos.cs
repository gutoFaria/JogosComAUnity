using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostraPontos : MonoBehaviour
{
    public Text pontos;
    public GameObject vida1;
    public GameObject vida2;
    public GameObject vida3;

    public GameObject player;
    public GameObject PainelInicial;

    public Text txtPontuacaoMeteoros;
    // Start is called before the first frame update
    void Start()
    {
        vida1.SetActive(true);
        vida2.SetActive(true);
        vida3.SetActive(true);

    }

    // Update is called once per frame
    void Update()
    {
        pontos.text = Pontuacao.Pontos.ToString();
        VerificaVida();
    }

    private void VerificaVida()
    {
        if(Pontuacao.Danos == 1)
        {
            vida3.SetActive(false);
        }
        else if(Pontuacao.Danos == 2)
        {
            vida2.SetActive(false);
        }
        else if(Pontuacao.Danos == 3)
        {
            vida3.SetActive(false);    
            player.SetActive(false);        
            txtPontuacaoMeteoros.text = "Pontos: " + Pontuacao.Pontos.ToString();
            Pontuacao.Danos= 0;
            PainelInicial.SetActive(true);
        }
    }
}
