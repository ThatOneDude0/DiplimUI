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
    }

    public void OnButtonEnter(MyButton button)
    {        
    }   
}
