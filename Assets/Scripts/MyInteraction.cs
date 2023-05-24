using System;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public enum ButtonInteractionType
{
    SceneChange,
    OpenSetting,
    OpenShop,
    OpenMainScreen
}
public class MyInteraction : MonoBehaviour, IPointerClickHandler
{
    public event Action ButtonCliked;

    public ButtonInteractionType buttonInteractionType;

    private IButtonInteraction buttonInteraction;

    [SerializeField] private UIAnimation _uIAnimation;

    //private SceneData _sceneData;

    [SerializeField] private ObjectKeeper _objectKeeper;

    private void Start()
    {
        //_sceneData = Resources.Load<SceneData>("ButtonSceneChanger");

        switch (buttonInteractionType)
        {
            case ButtonInteractionType.OpenSetting:
                {                   
                    buttonInteraction = new SettingsKeeperAction(_objectKeeper);
                    break;
                }
            case ButtonInteractionType.OpenShop:
                {
                    buttonInteraction = new ShopKeeperAction(_objectKeeper);
                    break;
                }
            case ButtonInteractionType.OpenMainScreen:
                {
                    buttonInteraction = new MainScreenKeeperAction(_objectKeeper);
                    break;
                }
        }
    }

    public void OnSettingOpen(GameObject one)
    {
        _uIAnimation.OnOpenShop();
        //_objectKeeper.Canvas[1].SetActive(true);
        //_objectKeeper.Canvas[2].SetActive(false);
    }

    public void OnShopOpen(GameObject one)
    {
        _uIAnimation.OnOpenShop();
        //_objectKeeper.Canvas[2].SetActive(true);
        //_objectKeeper.Canvas[1].SetActive(false);    
    }

    public void OnMainScreenOpen(GameObject one)
    {
        //_objectKeeper.Canvas[0].SetActive(true);
        //_objectKeeper.Canvas[2].SetActive(false);
        //_objectKeeper.Canvas[1].SetActive(false);
        _uIAnimation.OnCloseShop();
    }

    //public void OnButtonCliked(int sceneIndex)
    //{
    //    SceneManager.LoadScene(_sceneData.SceneIndex);
    //    Debug.Log("Next Scene 1");
    //}

    public void OnPointerClick(PointerEventData eventData)
    {
        buttonInteraction.OnButtonClick(this);
        ButtonCliked?.Invoke();
        Debug.Log("отпустил");
    }
}
