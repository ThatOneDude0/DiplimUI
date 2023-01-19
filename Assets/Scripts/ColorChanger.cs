using UnityEngine;

public class ColorChanger : IButtonBehaviour
{
    private ColorData _colorData;

    public ColorChanger(ColorData colorData)
    {
        _colorData = colorData;
    }

    public void OnButtonClick(MyButton button)
    {
        button.ChangeColor(_colorData._clickColor);
    }

    public void OnButtonEnter(MyButton button)
    {
        button.ChangeColor(_colorData._enterColor);
    }

    public void OnButtonDefoult(MyButton button)
    {
        button.ChangeColor(_colorData._baseColor);
    }
}
