public class SoundKeeperAction : IButtonSettings
{
    private SoundKeeper _soundKeeper;

    public SoundKeeperAction(SoundKeeper soundKeeper)
    {
        _soundKeeper = soundKeeper;
    }


    public void OnButtonSettingClick(MySettings mySettings)
    {
        mySettings.PlayButtonSound(_soundKeeper.Sounds[0]);
    }
}
