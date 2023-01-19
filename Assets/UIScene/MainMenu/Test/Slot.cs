using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IDropHandler
{
    public void OnDrop(PointerEventData eventData)
    {
        if (Item.draggingItem != null)
        {
            Item.dragFrom = transform;
        }
    }
}
