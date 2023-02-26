using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public enum ButtonInteractionType
{
    SceneChange,
    OpenSetting,
    OpenShop
}
public class MyInteraction : MonoBehaviour, IPointerClickHandler
{
    public event Action ButtonCliked;

    public ButtonInteractionType buttonInteractionType;

    private IButtonInteraction buttonInteraction;

    private SceneData _sceneData;
    private SettingData _sceneDataSetting;
    private ShopData _shopData;

    private void Start()
    {
        _sceneData = Resources.Load<SceneData>("ButtonSceneChanger");
        _sceneDataSetting = Resources.Load<SettingData>("ButtonSetting");
        _shopData = Resources.Load<ShopData>("ButtonShop");

        switch (buttonInteractionType)
        {
            case ButtonInteractionType.SceneChange:
                {
                    buttonInteraction = new SceneChanger(_sceneData);
                    break;
                }
            case ButtonInteractionType.OpenSetting:
                {
                    buttonInteraction = new SettingOpen(_sceneDataSetting);
                    break;
                }
            case ButtonInteractionType.OpenShop:
                {
                    buttonInteraction = new ShopOpen(_shopData); 
                    break;
                }
        }
    }
    public void OnSettingOpen(int sceneIndex)
    {
        SceneManager.LoadScene(_sceneDataSetting.SettingsSceneIndex);
        Debug.Log("Next Scene 0");
    }

    public void OnButtonCliked(int sceneIndex)
    {
        SceneManager.LoadScene(_sceneData.SceneIndex);
        Debug.Log("Next Scene 1");
    }

    public void OnShopOpen(int sceneIndex)
    {
        SceneManager.LoadScene(_shopData.ShopSceneIndex);
        Debug.Log("Next Scene 2");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        buttonInteraction.OnButtonClick(this);
        ButtonCliked?.Invoke();
        Debug.Log("отпустил");
    }
}
