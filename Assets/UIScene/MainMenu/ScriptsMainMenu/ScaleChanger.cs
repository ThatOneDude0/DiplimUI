using UnityEngine;

public class ScaleChanger : IButtonBehaviour
{
    private Vector3 _baseScale;
    private Vector3 _enterScale;
    private Vector3 _clickScale;


    public ScaleChanger(Vector3 baseScale, Vector3 enterScale, Vector3 clickScale)
    {
        _baseScale = baseScale;
        _enterScale = enterScale;
        _clickScale = clickScale;
    }

    public void OnButtonClick(MyButton button)
    {
        button.ChangeScale(_clickScale);
    }

    public void OnButtonEnter(MyButton button)
    {
        button.ChangeScale(_enterScale);
    }

    public void OnButtonDefoult(MyButton button)
    {
        button.ChangeScale(_baseScale);
    }
}
