using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKey("escape"))
        {
            Debug.Log("Quit");

            Application.Quit();
        }
    }
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
        SceneManager.LoadScene("3-pasillo");
    }
    public void CuartaEscena()
    {
        SceneManager.LoadScene("4-camas");
    }
    public void QuintaEscena()
    {
        SceneManager.LoadScene("5-espejos");
    }
    public void SextaEscena()
    {
        SceneManager.LoadScene("6-escalera");
    }


    public void MenuGame()
    {
        SceneManager.LoadScene("0-menu");
    }

    public void QuitGame()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
   
}
