using UnityEngine;

public class ScaleChanger : IButtonBehaviour
{
    private ScaleData _scaleData;

    public ScaleChanger(ScaleData scaleData)
    {
        _scaleData = scaleData;
    }

    public void OnButtonClick(MyButton button)
    {
        button.ChangeScale(_scaleData._clickScale);
    }

    public void OnButtonEnter(MyButton button)
    {
        button.ChangeScale(_scaleData._enterScale);
    }

    public void OnButtonDefoult(MyButton button)
    {
        button.ChangeScale(_scaleData._baseScale);
    }
}
