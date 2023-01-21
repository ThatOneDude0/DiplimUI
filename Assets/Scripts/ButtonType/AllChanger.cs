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
        button.ChangeAll(_colorData._clickColor, _scaleData._clickScale);        
    }

    public void OnButtonEnter(MyButton button)
    {
        button.ChangeAll(_colorData._enterColor, _scaleData._enterScale);
    }

    public void OnButtonDefoult(MyButton button)
    {
        button.ChangeAll(_colorData._baseColor, _scaleData._baseScale);
    }
}
