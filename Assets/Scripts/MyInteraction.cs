using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public enum ButtonInteractionType
{
    SceneChange,
    OpenSetting
}
public class MyInteraction : MonoBehaviour, IPointerClickHandler
{
    public event Action ButtonCliked;

    public ButtonInteractionType buttonInteractionType;

    private IButtonInteraction buttonInteraction;
    private SceneData _sceneData;
    private SettingData _sceneDataSetting;

    private void Start()
    {
        _sceneData = Resources.Load<SceneData>("ButtonSceneChanger");
        _sceneDataSetting = Resources.Load<SettingData>("ButtonSetting");

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
        }
    }
    public void OnSettingOpen(GameObject setting)
    {
        setting.SetActive(true);
    }

    public void OnButtonCliked(int sceneIndex)
    {
        SceneManager.LoadScene(_sceneData._sceneIndex);
        Debug.Log("Next Scene");
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        buttonInteraction.OnButtonClick(this);
        ButtonCliked?.Invoke();
        Debug.Log("отпустил");
    }
}
