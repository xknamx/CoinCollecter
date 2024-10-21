using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Coin
{
    public int value { get; protected set; }  // �R�C���̋��z��\���v���p�e�B
}

// 1�~�R�C���̃N���X
public class OneYenCoin : Coin
{
    public OneYenCoin()
    {
        value = 1;
    }
}

// 5�~�R�C���̃N���X
public class FiveYenCoin : Coin
{
    public FiveYenCoin()
    {
        value = 5;
    }
}


// 10�~�R�C���̃N���X
public class TenYenCoin : Coin
{
    public TenYenCoin()
    {
        value = 10;
    }
}

// 50�~�R�C���̃N���X
public class FiftyYenCoin : Coin
{
    public FiftyYenCoin()
    {
        value = 50;
    }
}

