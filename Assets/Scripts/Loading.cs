using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loading : MonoBehaviour
{
    [SerializeField] private GameObject loading;

    public void LoadScene(string SceneToLoad)
    {
        StartCoroutine(loading(SceneToLoad));
    }
    
    private IEnumerator Load(string SceneToLoad)
    {
        var Loading_ScreenInstance = Instantiate(loading_Screen);
        DontDestroyOnLoad(Loading_ScreenInstance);
        var loadingAnimator = Loading_ScreenInstance.GetComponent<Animator>();
        var AnimationTime = loadingAnimator.GetCurrentAnimatorStarteInfo(0).length;
        var loading = SceneManager.LoadSceneAsync(SceneToLoad);

        loading.allowSceneActivation = false;

        while(!loading.isDone)
        {
            if(loading.progress >= 0.9f)
            {
                loading.allowSceneActivation = true;
                loadingAnimator.SetTrigger("EndLoading");

            }
        }

        yield return new WaitForSeconds(AnimationTime);
    
    }
    
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
