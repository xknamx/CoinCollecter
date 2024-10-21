using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Coin
{
    public int value { get; protected set; }  // コインの金額を表すプロパティ
}

// 1円コインのクラス
public class OneYenCoin : Coin
{
    public OneYenCoin()
    {
        value = 1;
    }
}

// 5円コインのクラス
public class FiveYenCoin : Coin
{
    public FiveYenCoin()
    {
        value = 5;
    }
}


// 10円コインのクラス
public class TenYenCoin : Coin
{
    public TenYenCoin()
    {
        value = 10;
    }
}

// 50円コインのクラス
public class FiftyYenCoin : Coin
{
    public FiftyYenCoin()
    {
        value = 50;
    }
}

