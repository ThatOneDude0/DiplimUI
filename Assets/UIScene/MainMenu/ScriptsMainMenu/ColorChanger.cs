using UnityEngine;

public class ColorChanger : IButtonBehaviour
{
    private Color _baseColor;
    private Color _enterColor;
    private Color _clickColor;

    public ColorChanger(Color baseColor, Color enterColor, Color clickColor)
    {
        _baseColor = baseColor;
        _enterColor = enterColor;
        _clickColor = clickColor;
    }

    public void OnButtonClick(MyButton button)
    {
        button.ChangeColor(_clickColor);
    }

    public void OnButtonEnter(MyButton button)
    {
        button.ChangeColor(_enterColor);
    }

    public void OnButtonDefoult(MyButton button)
    {
        button.ChangeColor(_baseColor);
    }
}
