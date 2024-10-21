using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Coin
{

    public int value { get; protected set; }  // �R�C���̋��z��\���v���p�e�B
    public Sprite coinSprite { get; protected set; }  // �R�C���̉摜

    // �R�C���������ʂ̃��\�b�h�Ȃ�
    public abstract void DisplayValue();
}

// 1�~�R�C���̃N���X
public class OneYenCoin : Coin
{
    public OneYenCoin(Sprite coinImage)
    {
        value = 1;
        coinSprite = coinImage;  // 1�~�R�C���̉摜��ݒ�
    }

    public override void DisplayValue()
    {
        Debug.Log("This is a 1 yen coin.");
    }
}

// 5�~�R�C���̃N���X
public class FiveYenCoin : Coin
{
    public FiveYenCoin(Sprite coinImage)
    {
        value = 5;
        coinSprite = coinImage;  // 5�~�R�C���̉摜��ݒ�
    }

    public override void DisplayValue()
    {
        Debug.Log("This is a 5 yen coin.");
    }
}


// 10�~�R�C���̃N���X
public class TenYenCoin : Coin
{
    public TenYenCoin(Sprite coinImage)
    {
        value = 10;
        coinSprite = coinImage;  // 10�~�R�C���̉摜��ݒ�
    }

    public override void DisplayValue()
    {
        Debug.Log("This is a 10 yen coin.");
    }
}

// 50�~�R�C���̃N���X
public class FiftyYenCoin : Coin
{
    public FiftyYenCoin(Sprite coinImage)
    {
        value = 50;
        coinSprite = coinImage;  // 50�~�R�C���̉摜��ݒ�
    }

    public override void DisplayValue()
    {
        Debug.Log("This is a 50 yen coin.");
    }
}

