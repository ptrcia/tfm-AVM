using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("1escena");
    }
    public void SegundaEscena()
    {
        SceneManager.LoadScene("2escena");
    }
    public void TerceraEscena()
    {
        SceneManager.LoadScene("3escena");
    }
    public void CuartaEscena()
    {
        SceneManager.LoadScene("4escena");
    }

    public void MenuGame()
    {
        SceneManager.LoadScene("menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
    
    //escena de prueba
    public void SampleScene()
    {
        SceneManager.LoadScene("SampleScene");
    }
}
