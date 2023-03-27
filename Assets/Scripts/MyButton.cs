using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum ButtonBehaviourType
{
    Inaction,
    ScaleChange,
    ColorChange,
    AllChange
}

[RequireComponent(typeof(Image))]
public class MyButton : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
{
    public ButtonBehaviourType buttonBehaviourType;

    public event Action ButtonEnter;
    public event Action ButtonCliked;
    public event Action ButtonEnd;

    private Image _buttonImage;

    private IButtonBehaviour _buttonBehaviour;

    private ScaleData _scaleData;
    private ColorData _colorData;

    private void Awake()
    {
        _scaleData = Resources.Load<ScaleData>("ButtonScaleChanger");
        _colorData = Resources.Load<ColorData>("ButtonColorChanger");       
    }

    private void Start()
    {
        _buttonImage = GetComponent<Image>();

        switch (buttonBehaviourType)
        {
            case ButtonBehaviourType.Inaction:
                {                  
                    break;
                }
            case ButtonBehaviourType.ScaleChange:
                {
                    _buttonBehaviour = new ScaleChanger(_scaleData);
                    break;
                }
            case ButtonBehaviourType.ColorChange:
                {
                    _buttonBehaviour = new ColorChanger(_colorData);
                    break;
                }         
            case ButtonBehaviourType.AllChange:
                {
                    _buttonBehaviour = new AllChanger(_colorData, _scaleData);
                    break;
                }        
        }      
    }

    public void None() { }

    public void ChangeColor(Color color)
    {
        _buttonImage.color = color;
    }

    public void ChangeScale(Vector3 scale)
    {
        _buttonImage.transform.localScale = scale;
    }

    public void ChangeAll(Color color, Vector3 scale)
    {
        _buttonImage.color = color;
        _buttonImage.transform.localScale = scale;
    }

    //на отпускание кнокпи
    public void OnPointerClick(PointerEventData eventData)
    {
        _buttonBehaviour.OnButtonClick(this);
        ButtonCliked?.Invoke();
        Debug.Log("отпустил");
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        _buttonBehaviour.OnButtonEnter(this);
        ButtonEnter?.Invoke();
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _buttonBehaviour.OnButtonDefoult(this);
        ButtonEnd?.Invoke();
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        _buttonBehaviour.OnButtonDefoult(this);
        ButtonEnd?.Invoke();
    }
}