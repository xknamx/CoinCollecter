using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Coin
{

    public int value { get; protected set; }  // コインの金額を表すプロパティ
    public Sprite coinSprite { get; protected set; }  // コインの画像

    // コインが持つ共通のメソッドなど
    public abstract void DisplayValue();
}

// 1円コインのクラス
public class OneYenCoin : Coin
{
    public OneYenCoin(Sprite coinImage)
    {
        value = 1;
        coinSprite = coinImage;  // 1円コインの画像を設定
    }

    public override void DisplayValue()
    {
        Debug.Log("This is a 1 yen coin.");
    }
}

// 5円コインのクラス
public class FiveYenCoin : Coin
{
    public FiveYenCoin(Sprite coinImage)
    {
        value = 5;
        coinSprite = coinImage;  // 5円コインの画像を設定
    }

    public override void DisplayValue()
    {
        Debug.Log("This is a 5 yen coin.");
    }
}


// 10円コインのクラス
public class TenYenCoin : Coin
{
    public TenYenCoin(Sprite coinImage)
    {
        value = 10;
        coinSprite = coinImage;  // 10円コインの画像を設定
    }

    public override void DisplayValue()
    {
        Debug.Log("This is a 10 yen coin.");
    }
}

// 50円コインのクラス
public class FiftyYenCoin : Coin
{
    public FiftyYenCoin(Sprite coinImage)
    {
        value = 50;
        coinSprite = coinImage;  // 50円コインの画像を設定
    }

    public override void DisplayValue()
    {
        Debug.Log("This is a 50 yen coin.");
    }
}

