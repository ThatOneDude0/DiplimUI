public class SoundOff : IButtonSettings
{
    private SoundKeeper _soundKeeper;

    public SoundOff(SoundKeeper soundKeeper)
    {
        _soundKeeper = soundKeeper;
    }


    public void OnButtonSettingClick(MySettings mySettings)
    {
        mySettings.ButtonSoundOff(_soundKeeper.Sounds[0]);
    }
}
