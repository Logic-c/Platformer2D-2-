using UnityEngine;
using UnityEngine.SceneManagement;

public class menue : MonoBehaviour
{
    public void play() // une variable 
    {
        SceneManager.LoadScene("SampleScene"); 
    }
   
    
    public void credits()
    {

        SceneManager.LoadScene("Credits"); // fonction qui sert à lancer les credits

    }

    public void exit ()
    {
        Debug.Log("Fin du jeu"); // fonction qui sert à quitter le jeu 
        Application.Quit(); 
    }
}
