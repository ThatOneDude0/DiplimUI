using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AllChanger : IButtonBehaviour
{
    private ColorData _colorData;
    private ScaleData _scaleData;

    public AllChanger(ColorData colorData, ScaleData scaleData)
    {
        _colorData = colorData;
        _scaleData = scaleData;
    }

    public void OnButtonClick(MyButton button)
    {
        button.ChangeColor(_colorData._clickColor);
        button.ChangeScale(_scaleData._clickScale);
    }

    public void OnButtonEnter(MyButton button)
    {
        button.ChangeColor(_colorData._enterColor);
        button.ChangeScale(_scaleData._enterScale);
    }

    public void OnButtonDefoult(MyButton button)
    {
        button.ChangeColor(_colorData._baseColor);
        button.ChangeScale(_scaleData._baseScale);
    }
}
