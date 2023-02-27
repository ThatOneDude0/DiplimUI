using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{
    [SerializeField] private Slider _sliderProgress;

    public void Start()
    {       
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(1);
        asyncOperation.allowSceneActivation = false;

        while (!asyncOperation.isDone)
        {
            _sliderProgress.value = asyncOperation.progress;

            if (asyncOperation.progress >= .9f && !asyncOperation.allowSceneActivation)
            {
                yield return new WaitForSeconds(2.3f);
                asyncOperation.allowSceneActivation = true;
            }
        }

        yield return null;
    }
}
