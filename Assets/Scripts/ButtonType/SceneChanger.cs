using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : IButtonBehaviour
{
    private SceneData _sceneData;

    public SceneChanger(SceneData sceneData)
    {
        _sceneData = sceneData;
    }

    public void OnButtonClick(MyButton button)
    {
        button.OnButtonCliked(_sceneData._sceneIndex);
    }

    public void OnButtonDefoult(MyButton button)
    {
        //button.OnButtonCliked(_sceneData._sceneIndex);
    }

    public void OnButtonEnter(MyButton button)
    {
        //button.OnButtonCliked(_sceneData._sceneIndex);
    }   
}
