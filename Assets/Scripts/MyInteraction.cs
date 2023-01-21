using System;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public enum ButtonInteractionType
{
    SceneChange,
    //Setting
}
public class MyInteraction : MonoBehaviour, IPointerClickHandler
{
    public event Action ButtonCliked;

    public ButtonInteractionType buttonInteractionType;

    private IButtonInteraction buttonInteraction;
    private SceneData _sceneData;
    private SceneData _sceneDataSetting;

    private void Start()
    {
        _sceneData = Resources.Load<SceneData>("ButtonSceneChanger");
        _sceneDataSetting = Resources.Load<SceneData>("ButtonSceneChangerOne");

        switch (buttonInteractionType)
        {
            case ButtonInteractionType.SceneChange:
                {
                    buttonInteraction = new SceneChanger(_sceneData);
                    break;
                }
            //case ButtonInteractionType.Setting:
            //    {
            //        buttonInteraction = new SceneChanger(_sceneDataSetting);
            //        break;
            //    }
        }
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
