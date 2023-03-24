public class ShopKeeperAction : IButtonInteraction
{
    private ObjectKeeper _objectKeeper;

    public ShopKeeperAction(ObjectKeeper objectKeeper)
    {
        _objectKeeper = objectKeeper;
    }

    public void OnButtonClick(MyInteraction button)
    {
        button.OnShopOpen(_objectKeeper.Canvas[2]);
    }
}
