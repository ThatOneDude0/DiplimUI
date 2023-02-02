using UnityEngine;
using UnityEngine.SceneManagement;

public class NextScene : MonoBehaviour
{
    [SerializeField] private MyButton myButton;
    [SerializeField] private int _sceneIndex;

    private void OnEnable()
    {
        myButton.ButtonCliked += OnButtonCliked;
    }
    private void OnDisable()
    {
        myButton.ButtonCliked += OnButtonCliked;
    }

    private void OnButtonCliked()
    {
        SceneManager.LoadScene(_sceneIndex);
        Debug.Log("YAAAA");
    }
}
