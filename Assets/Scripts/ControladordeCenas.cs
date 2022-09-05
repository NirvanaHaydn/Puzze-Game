using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladordeCenas : MonoBehaviour
{
    public void IniciarJogo()
    {
        SceneManager.LoadScene("Primeira Cena");
    }
    public void PrimeiraCena()
    {
        SceneManager.LoadScene("");
    }
    public void SegundaCena()
    {
        SceneManager.LoadScene("");
    }
    public void TerceiraCena()
    {
        SceneManager.LoadScene("");
    }
    public void Sair()
    {
        Debug.Log("Saiu");
        Application.Quit();
    }

}
