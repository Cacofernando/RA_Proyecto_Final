using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Controlador : MonoBehaviour
{
    // Start is called before the first frame update
    int contCuadros = 0;
    public Text m_TcontCuadros;

    int contCubosDestruidos = 0;
    public Text m_TcontCubosDestruidos;

    float tiempoTotal = 0.0f;
    public Text m_TTiempo;

    int vidas = 3;
    public Text m_Vidas;

    //Texto que dice si gané el juego o perdí
    public Text Win;
    bool JuegoActivo = true; //Variable para saber si el juego está activo

    void Start()
    {
        
    }

    /// <summary>
    /// Función para devolver el estado del juego
    /// </summary>
    /// <returns></returns>
    public bool EstadoJuego()
    {
        return JuegoActivo;
    }

    // Update is called once per frame
    void Update()
    {
        //Se acaba el juego si .....
        if (contCubosDestruidos > 11 || vidas <= 0)
        {
            if (contCubosDestruidos > 11)
            {
                Win.text = "Has ganado el juego...Felicidades ¡¡¡";
            }
            else if (vidas <= 0)
            {
                Win.text = "Perdiste tu juego ....¡¡¡";
            }

            //Cambié el estado de la variable del juego
            JuegoActivo = false;
        }

        if (JuegoActivo)
        {
            //Mido el tiempo de juego
            MideTiempo();

            //Llamo a la función que cuenta cuadros
            ContadorCuadros();
        }
    }

    /// <summary>
    /// Cuenta los cuadros
    /// </summary>
    void ContadorCuadros()
    {
        contCuadros++;
        m_TcontCuadros.text = contCuadros.ToString();
    }

    /// <summary>
    /// Cuenta los cubos destruidos
    /// </summary>
    public void ContadorCubosDest()
    {
        if (JuegoActivo)
        {
            contCubosDestruidos++;
            m_TcontCubosDestruidos.text = contCubosDestruidos.ToString();
        }
    }

    void MideTiempo()
    {
        tiempoTotal += Time.deltaTime;
        m_TTiempo.text = ((int) tiempoTotal).ToString();
    }

    /// <summary>
    /// Se llama desde el cubo enemigo para restar vidas
    /// </summary>
    public void RestaVidas()
    {
        //De esta manera, si se acabó el juego ni entro
        if (JuegoActivo)
        {
            vidas--;
            if (vidas < 0)
                vidas = 0;

            m_Vidas.text = vidas.ToString();
        }
    }
}
