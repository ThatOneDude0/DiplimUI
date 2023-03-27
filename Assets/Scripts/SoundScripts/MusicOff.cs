public class MusicOff : IButtonSettings
{
    private SoundKeeper _soundKeeper;

    public MusicOff(SoundKeeper soundKeeper)
    {
        _soundKeeper = soundKeeper;
    }


    public void OnButtonSettingClick(MySettings mySettings)
    {
        mySettings.ButtonMusicOff(_soundKeeper.Sounds[1]);
    }
}
