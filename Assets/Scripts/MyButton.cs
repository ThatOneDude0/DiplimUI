using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public enum ButtonBehaviourType
{
    ScaleChange,
    ColorChange,
    All,
    SceneChange
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
    private SceneData _sceneData;

    private void Awake()
    {
        _scaleData = Resources.Load<ScaleData>("ButtonScaleChanger");
        _colorData = Resources.Load<ColorData>("ButtonColorChanger");
        _sceneData = Resources.Load<SceneData>("ButtonSceneChanger");
    }

    private void Start()
    {
        

        _buttonImage = GetComponent<Image>();

        switch (buttonBehaviourType)
        {
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
            case ButtonBehaviourType.SceneChange:
                {
                    _buttonBehaviour = new SceneChanger(_sceneData);
                    //_buttonBehaviour = new ColorChanger(_colorData);
                    break;
                }
        }
    }

    public void ChangeColor(Color color)
    {
        _buttonImage.color = color;
    }

    public void ChangeScale(Vector3 scale)
    {
        _buttonImage.transform.localScale = scale;
    }

    public void OnButtonCliked(int sceneIndex)
    {
        SceneManager.LoadScene(_sceneData._sceneIndex);
        Debug.Log("Next Scene");
    }
    public void All(Color color, Vector3 scale)
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
