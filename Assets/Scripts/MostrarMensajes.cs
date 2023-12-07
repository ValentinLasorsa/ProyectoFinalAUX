using UnityEngine.UI;
using UnityEngine;

public class MostrarMensajes : MonoBehaviour
{
    public GameObject gameObjectCanvasGanador;
    public GameObject gameObjectCanvasPerdedor;

    void Start()
    {
        // Asegurar que ambos Canvas estén inicialmente ocultos al comenzar el juego
        gameObjectCanvasGanador.SetActive(false);
        gameObjectCanvasPerdedor.SetActive(false);
    }

    public void MostrarCanvasGanador()
    {
        gameObjectCanvasGanador.SetActive(true);
        gameObjectCanvasPerdedor.SetActive(false);
    }

    public void MostrarCanvasPerdedor()
    {
        gameObjectCanvasGanador.SetActive(false);
        gameObjectCanvasPerdedor.SetActive(true);
    }
}
