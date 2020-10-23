using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField] private GameObject loading1;
    [SerializeField] private string SceneToLoad;

    public void LoadScene()
    {
        StartCoroutine(Load());
    }
    
    private IEnumerator Load()
    {
        var Loading_ScreenInstance = Instantiate(loading1);
        DontDestroyOnLoad(Loading_ScreenInstance);
        var loadingAnimator = Loading_ScreenInstance.GetComponent<Animator>();
        var AnimationTime = loadingAnimator.GetCurrentAnimatorStateInfo(0).length;
        var loading = SceneManager.LoadSceneAsync(SceneToLoad);

        loading.allowSceneActivation = false;

        while(!loading.isDone)
        {
            if(loading.progress >= 0.9f)
            {
                loading.allowSceneActivation = true;
                loadingAnimator.SetTrigger("Disparition");

            }

           yield return new WaitForSeconds(AnimationTime);

        }

        
    
    }
    
}
