using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class UIAnimation : MonoBehaviour
{
    [SerializeField] private float _timeAnimation;
    [SerializeField] private RectTransform _panelShop;
    [SerializeField] private GameObject _canvasShop;

    private Tween _tween;

    private void Start()
    {
        // _canvasShop = false;
        //_panelShop.sizeDelta = new Vector2(-500, _panelShop.sizeDelta.y);
        //_panelShop.DOSizeDelta(new Vector2(Screen.width, _panelShop.sizeDelta.y), _timeAnimation);
        //if (_canvasShop.active)
        //{
        //    _panelShop.sizeDelta = new Vector2(-500, _panelShop.sizeDelta.y);
        //    _panelShop.DOSizeDelta(new Vector2(Screen.width, _panelShop.sizeDelta.y), _timeAnimation);
        //}
    }

    private void Update()
    {
        //if (_canvasShop == true)
        //{
        //    OnOpenShop();
        //}
    }

    public void OnOpenShop()
    {
        _panelShop.sizeDelta = new Vector2(-500, _panelShop.sizeDelta.y);
        _panelShop.DOSizeDelta(new Vector2(Screen.width, _panelShop.sizeDelta.y), _timeAnimation);
    }

    public void OnCloseShop()
    {
        //_panelShop.sizeDelta = new Vector2(Screen.width, _panelShop.sizeDelta.y);
        _panelShop.DOSizeDelta(new Vector2(-500, _panelShop.sizeDelta.y), 1);
        //_canvasShop.SetActive(false);
    }
}
