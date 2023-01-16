using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Item : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    //[SerializeField] private GameObject _item;

    private float _scaleChange = 1.2f;    
    private Vector3 _standartScale = new Vector3(1f, 1f);

    public static Transform dragFrom;
    public static Item draggingItem;

    //[SerializeField] private RectTransform _rectTransform;
    //private Vector2 _startPosition;
    [SerializeField] private Image _image;

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("Click");
    }


    //меняем размер
    public void OnPointerEnter(PointerEventData eventData)
    {
        _image.transform.localScale *= _scaleChange;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        _image.transform.localScale = _standartScale;
    }
    //меняем размер

    public void Drop(Transform transform)
    {
        _image.transform.SetParent(transform);
        _image.transform.localPosition = Vector2.zero;
        
        draggingItem = null;
        dragFrom = null;
    }

    private void Update()
    {
        if (Input.GetMouseButtonUp(0))
        {
            if(draggingItem != null)
            {
                Drop(dragFrom);
            }
        }
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        _image.raycastTarget = false;
        dragFrom = transform.parent;
        transform.SetParent(_image.canvas.transform);
        draggingItem = this;
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        _image.raycastTarget = true;
    }

    //public static implicit operator Item(Counter v)
    //{
    //    throw new NotImplementedException();
    //}
}