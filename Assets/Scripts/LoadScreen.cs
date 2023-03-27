using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoadScreen : MonoBehaviour
{
    [SerializeField] private int _sceneIndex;
    [SerializeField] private Slider _sliderProgress;

    public void Start()
    {       
        StartCoroutine(LoadAsync());
    }

    IEnumerator LoadAsync()
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(_sceneIndex);

        while (!operation.isDone)
        {
            float prgress = operation.progress / 5.0f;
            _sliderProgress.value = prgress;

            yield return null;
        }
    }
}
