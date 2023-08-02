using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManege : MonoBehaviour
{

    public TextMeshProUGUI textoContador;
    public TextMeshProUGUI textoColetor;
    public int contador;
    public int Coletor;
    
    
    
    public void AdicionarPonto(int valor)
    {
        contador += valor;
        //atualizar o texto
        textoContador.text = "Cerebro: " + contador;
    }
    public void ColetarCabeca(int valor)
    {
        Coletor += valor;
        //atualizar o texto
        textoColetor.text = "Cabeca: " + Coletor;
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}