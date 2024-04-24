using UnityEngine;

public class RecolectarObjeto : MonoBehaviour
{
    public int puntosGanados = 10; 
    public SistemaPuntuacion sistemaPuntuacion; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            sistemaPuntuacion.ActualizarPuntaje(puntosGanados);

            Destroy(gameObject);
        }
    }
}
