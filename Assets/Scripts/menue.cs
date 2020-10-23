using UnityEngine;
using UnityEngine.SceneManagement;

public class menue : MonoBehaviour
{
    public void play()
    {
        SceneManager.LoadScene("SampleScene");
    }
   
    
    public void credits()
    {

        SceneManager.LoadScene("Credits");

    }

    public void exit ()
    {
        Debug.Log("Fin du jeu");
        Application.Quit();
    }
}
