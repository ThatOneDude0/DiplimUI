using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public enum ButtonBehaviourType
{
    ScaleChange,
    ColorChange
}

[RequireComponent(typeof(Image))]
public class MyButton : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler, IPointerUpHandler
{
    public ButtonBehaviourType buttonBehaviourType;

    public event Action ButtonEnter;
    public event Action ButtonCliked;
    public event Action ButtonEnd;

    public Color baseColor = Color.white;
    public Color enterColor = Color.white;
    public Color clickColor = Color.white;

    public Vector3 baseScale = new Vector3(1f, 1f);
    public Vector3 enterScale = new Vector3(1.2f, 1.2f);
    public Vector3 clickScale = new Vector3(1f, 1f);

    private Image _buttonImage;
    private IButtonBehaviour _buttonBehaviour;

    private void Start()
    {
        _buttonImage = GetComponent<Image>();

        switch (buttonBehaviourType)
        {
            case ButtonBehaviourType.ScaleChange:
                {
                    _buttonBehaviour = new ScaleChanger(baseScale, enterScale, clickScale);
                    break;
                }
            case ButtonBehaviourType.ColorChange:
                {
                    _buttonBehaviour = new ColorChanger(baseColor, enterColor, clickColor);
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

    //�� ������� ������ 
    public void OnPointerDown(PointerEventData eventData)
    {
        _buttonBehaviour.OnButtonDefoult(this);
        Debug.Log("input");
    }

    //�� ���������� ������ 
    public void OnPointerClick(PointerEventData eventData)
    {
        _buttonBehaviour.OnButtonClick(this);
        ButtonCliked?.Invoke();
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
