public class SceneChanger : IButtonInteraction
{
    private SceneData _sceneData;

    public SceneChanger(SceneData sceneData)
    {
        _sceneData = sceneData;
    }

    public void OnButtonClick(MyInteraction button)
    {
        button.OnButtonCliked(_sceneData._sceneIndex);
    }
}
