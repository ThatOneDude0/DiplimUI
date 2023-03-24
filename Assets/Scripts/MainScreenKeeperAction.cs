public class MainScreenKeeperAction : IButtonInteraction
{
    private ObjectKeeper _objectKeeper;

    public MainScreenKeeperAction(ObjectKeeper objectKeeper)
    {
        _objectKeeper = objectKeeper;
    }

    public void OnButtonClick(MyInteraction button)
    {
        button.OnMainScreenOpen(_objectKeeper.Canvas[0]);
    }
}
