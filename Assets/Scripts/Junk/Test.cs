using System.Collections;
using System;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private MyButton myButton;

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
        Debug.Log("Button Cltck");
    }
}
