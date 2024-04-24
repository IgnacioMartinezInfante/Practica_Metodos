using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Inventario : MonoBehaviour
{
    public Text textomonedas;
    public Text textocajas;
    public static int contadormonedas = 0; 
    public static int contadorcajas = 0;

    
    public void Incrementarcontador(string objeto, int cantidad)
    {
        if (objeto == "monedas")
        {
            contadormonedas += cantidad;
            textomonedas.text = "Monedas: " + contadormonedas;
        }

        if (objeto == "cajas")
        {
            contadorcajas += cantidad;
            textocajas.text = "Cajas: " + contadorcajas;
        }
    }

    public void Disminuircontador(string objeto, int cantidad)
    {
        if (objeto == "monedas")
        {
            contadormonedas -= cantidad;
            textomonedas.text = "Monedas: " + contadormonedas;
        }

        if (objeto == "cajas")
        {
            contadorcajas -= cantidad;
            textocajas.text = "Cajas: " + contadorcajas;
        }
    }
}
