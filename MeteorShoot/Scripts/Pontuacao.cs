using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public static class Pontuacao 
{
   private static int pontuacao;
   private static int dano;

   public static int Pontos
   {
       get{
           return pontuacao;
       }
       set{
           pontuacao = value;
           if(pontuacao < 0){
               pontuacao = 0;
           }
           //Debug.Log("Pontos : " + pontuacao);
       }
   }

   public static int Danos
   {
       get{
           return dano;
       }
       set{
           dano = value;
           if(dano < 0){
               dano = 0;
           }
           //Debug.Log("Dano : " + dano);
       }
   }


}
