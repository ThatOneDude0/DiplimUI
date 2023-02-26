using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingOpen : IButtonInteraction
{
    private SettingData _settingData;

    public SettingOpen(SettingData settingData)
    {
        _settingData = settingData;
    }

    public void OnButtonClick(MyInteraction button)
    {
        button.OnSettingOpen(_settingData.SettingsSceneIndex);
    }
}
