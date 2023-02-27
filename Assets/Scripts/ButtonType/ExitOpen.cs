using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitOpen : IButtonInteraction
{
    private ExitData _ExitData;

    public ExitOpen(ExitData ExitData)
    {
        _ExitData = ExitData;
    }

    public void OnButtonClick(MyInteraction button)
    {
        button.OnExitOpen(_ExitData.ExitSceneIndex);
    }
}
