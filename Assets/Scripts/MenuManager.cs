using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void PlayGame()
    {
        SceneManager.LoadScene("1-casa");
    }
    public void SegundaEscena()
    {
        SceneManager.LoadScene("2-fiesta");
    }
    public void TerceraEscena()
    {
        SceneManager.LoadScene("3-");
    }
    public void CuartaEscena()
    {
        SceneManager.LoadScene("4-");
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
