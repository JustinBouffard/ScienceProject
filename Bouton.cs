using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bouton : MonoBehaviour
{
    public void QuitGame()
    {
        Application.Quit();
    }
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Commencer()
    {
        SceneManager.LoadScene("Gameplay");
        Globules.Score = 0;
    }

    public void Revision()
    {
        SceneManager.LoadScene("RevisionMenu");
    }

    public void Ganglions()
    {
        SceneManager.LoadScene("Ganglions");
    }

    public void Liquide()
    {
        SceneManager.LoadScene("LiquideInterstitiel");
    }

    public void Lymphe()
    {
        SceneManager.LoadScene("Lymphe"); 
    }

    public void Organes()
    {
        SceneManager.LoadScene("Organes");
    }

    public void Plasma()
    {
        SceneManager.LoadScene("Plasma");
    }

    public void Système()
    {
        SceneManager.LoadScene("SystèmeLymphatique");
    }

    public void Vaisseaux()
    {
        SceneManager.LoadScene("VaisseauxLymphatiques");
    }

}//class
