using UnityEngine;
using UnityEngine.SceneManagement;

public class menue : MonoBehaviour
{
    public void play() 
    {
        SceneManager.LoadScene("SampleScene"); // fonction qui sert à lancer la scene de jeu 
    }
   
    
    public void credits()
    {

        SceneManager.LoadScene("Credits"); // fonction qui sert à lancer les credits

    }

    public void exit ()
    {
        Debug.Log("Fin du jeu"); // fonction qui sert à détecter le fonctionnement de "Fin du jeu" dans la console 
        Application.Quit(); 
    }
}
