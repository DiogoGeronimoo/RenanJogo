using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManege : MonoBehaviour
{

    public TextMeshProUGUI  textoContador;
    public int contador;
    
    
    
    public void AdicionarPonto(int valor)
    {
        contador += valor;
        //atualizar o texto
        textoContador.text = "Cerebro: " + contador;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}