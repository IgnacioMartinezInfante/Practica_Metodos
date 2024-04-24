using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SistemaPuntuacion : MonoBehaviour
{
    public Text textoPuntaje; 
    private int puntaje = 0; 

    public void ActualizarPuntaje(int puntos)
    {
        puntaje += puntos;

        textoPuntaje.text = "Puntaje: " + puntaje.ToString();
    }
}
