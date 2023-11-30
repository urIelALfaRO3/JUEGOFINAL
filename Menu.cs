using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void EscenaDeJuego()
    {
        SceneManager.LoadScene("Juego");
    }

    public void CreditosDeJuego()
    {
        SceneManager.LoadScene("Creditos");
    }

    public void ReglasDeJuego()
    {
        SceneManager.LoadScene("Reglas");
    }
   

    public void salir()
    {
        Application.Quit();
    }

     
}
