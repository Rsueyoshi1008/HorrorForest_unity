using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUseCase
{
    //アイテムを使った時の処理indexは使ったアイテムのID
    public void UseItem(int index)
    {
        //modelからItemのリストを持ってきてindexで指定して消費する処理書きたい
    }

    //playerのダメージ計算
    public void PlayerDamege(int damege)
    {
        //modekからplayerHPを持ってきてそこからdamegeを引く
    }

    //敵のダメージ計算
    public void EnemyDamege(int damege)
    {
        //modelからEnemyHPをdamegeで引く
    }

    //アイテムをゲットしたときの処理
    public void PickItem()
    {
        
    }

}
