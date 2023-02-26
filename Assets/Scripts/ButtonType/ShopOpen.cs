using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopOpen : IButtonInteraction
{
    private ShopData _shopData;

    public ShopOpen(ShopData shopData)
    {
        _shopData = shopData;
    }

    public void OnButtonClick(MyInteraction button)
    {
        button.OnShopOpen(_shopData.ShopSceneIndex);
    }
}
