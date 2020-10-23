using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField] private GameObject loading1; // variable qui défini le canvas (loadin1)
    [SerializeField] private string SceneToLoad; // variable qui défini la scene à charger 

    public void LoadScene() // focntion qui active le chargement de la scene 
    {
        StartCoroutine(Load()); // démarrage de la scene 
    }
    
    private IEnumerator Load() // fonction qui permet de lancer les differentes animations 
    {
        var Loading_ScreenInstance = Instantiate(loading1); // on instancie le canvas dans laquelle on trouve l'animation 
        DontDestroyOnLoad(Loading_ScreenInstance); // on lui demande de ne pas supprimer le canvas après avoir lancer l'animation 
        var loadingAnimator = Loading_ScreenInstance.GetComponent<Animator>(); // on récupere le composant animator dans le canvas 
        var AnimationTime = loadingAnimator.GetCurrentAnimatorStateInfo(0).length; // calcul le temps de l'animation 
        var loading = SceneManager.LoadSceneAsync(SceneToLoad); // charger la scene en arriere plan pendant l'animation 

        loading.allowSceneActivation = false; // cela desatcive le canvas où se trouve l'animation 

        while(!loading.isDone) // tant que la scene n'a pas fini de charger, la scene ne se lance pas 
        {
            if(loading.progress >= 0.9f) // si le chargement est terminé, la scene se lance 
            {
                loading.allowSceneActivation = true; // activation de la scene de jeu 
                loadingAnimator.SetTrigger("Disparition"); // animation de "Disparition" du chargement 

            }

           yield return new WaitForSeconds(AnimationTime); // c'est le temps d'attente pour que toutes les animations soit jouées 

        }

        
    
    }
    
}
