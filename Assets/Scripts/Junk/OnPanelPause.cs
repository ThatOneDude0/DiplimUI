using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OnPanelPause : MonoBehaviour
{
    [SerializeField] private MyButton myButton;
    [SerializeField] private MyButton myButtonClose;
    [SerializeField] private GameObject _panelPause;
    [SerializeField] private GameObject _buttonPause;

    private void OnEnable()
    {
        myButton.ButtonCliked += OnButtonCliked;
        myButtonClose.ButtonCliked += OutButtonCliked;
    }
    private void OnDisable()
    {
        myButton.ButtonCliked += OnButtonCliked;
        myButtonClose.ButtonCliked += OutButtonCliked;
    }

    private void OnButtonCliked()
    {
        _panelPause.SetActive(true);
        _buttonPause.SetActive(false);
    }

    private void OutButtonCliked()
    {
        _panelPause.SetActive(false);
        _buttonPause.SetActive(true);
    }
}
