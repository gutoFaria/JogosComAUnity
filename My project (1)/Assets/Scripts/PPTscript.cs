using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PPTscript : MonoBehaviour
{
    public Image image;
    public Sprite pedraSprite;
    public Sprite papelSprite;
    public Sprite tesouraSprite;

    public Image Maquina;

    public Text txtVencedor;

    

    public void Sair()
    {
        SceneManager.LoadScene(0);
    }

    public void ImageMuda(int valor)
    {
        if(valor == 1)
        {
            image.sprite=pedraSprite;
            int valorMaquina =ImageMaquinaMuda();
            VerificaVenceor(valor,valorMaquina);
        }
        else if(valor == 2)
        {
            image.sprite=papelSprite;
            int valorMaquina = ImageMaquinaMuda();
            VerificaVenceor(valor,valorMaquina);
        }
        else if(valor == 3)
        {
            image.sprite=tesouraSprite;
            int valorMaquina = ImageMaquinaMuda();
            VerificaVenceor(valor,valorMaquina);
        }
    }

    private int ImageMaquinaMuda()
    {
        //sorteio de 1 até 3
        int valor = Random.Range (1, 4);

        if(valor == 1)
        {
            Maquina.sprite=pedraSprite;
        }
        else if(valor == 2)
        {
            Maquina.sprite=papelSprite;
        }
        else if(valor == 3)
        {
            Maquina.sprite=tesouraSprite;
        }

        return valor;
    }

    public void VerificaVenceor(int valor,int valorMaquina)
    {
        if(valor == valorMaquina)
        {
            txtVencedor.text = "Vencedor : empate";
        }
        else if(valor == 1 && valorMaquina == 2)
        {
            txtVencedor.text = "Vencedor : máquina";
        }
        else if(valor == 1 && valorMaquina == 3)
        {
            txtVencedor.text = "Vencedor : você";
        }
        else if(valor == 2 && valorMaquina == 1)
        {
            txtVencedor.text = "Vencedor : você";
        }
        else if(valor == 2 && valorMaquina == 3)
        {
            txtVencedor.text = "Vencedor : máquina";
        }
        else if(valor == 3 && valorMaquina == 1)
        {
            txtVencedor.text = "Vencedor : máquina";
        }
        else if(valor == 3 && valorMaquina == 2)
        {
            txtVencedor.text = "Vencedor : você";
        }

        
    }
}
