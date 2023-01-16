using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class ButtonClick : MonoBehaviour, IPointerDownHandler, IPointerEnterHandler, IPointerExitHandler, IAction
{
    private float _scaleChange = 1.2f;
    private Vector3 _standartScale = new Vector3(1f, 1f);

    public static Transform dragFrom;
    public static Item draggingItem;

    [SerializeField] private Image _image;
    [SerializeField] private int _sceneIndex;

    public void OnPointerDown(PointerEventData eventData)
    {
        NextScene(_sceneIndex);
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

    public void NextScene(int _sceneIndex)
    {
        SceneManager.LoadScene(_sceneIndex);
        Debug.Log("YAAAA");
    }
}
