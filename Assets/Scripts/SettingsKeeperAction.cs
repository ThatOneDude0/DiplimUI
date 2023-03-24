public class SettingsKeeperAction : IButtonInteraction
{
    private ObjectKeeper _objectKeeper;

    public SettingsKeeperAction(ObjectKeeper objectKeeper)
    {
        _objectKeeper = objectKeeper;
    }

    public void OnButtonClick(MyInteraction button)
    {
        button.OnSettingOpen(_objectKeeper.Canvas[1]);
    }
}
