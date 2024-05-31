using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public int damage;              // ダメージを定義
    private GameObject DeathObject; //消えるオブジェクトを定義
    private ENEMY.Enemy enemy;            //Enemy クラスを使います
    // Start is called before the first frame update
    void Start()
    {
        DeathObject = GameObject.Find("Enemy");             // 消えるオブジェクト(Enemy)を探す
        enemy = DeathObject.GetComponent<ENEMY.Enemy>();    //消えるオブジェクトEnemyのHP情報を習得
    }

    private void OnCollisionEnter(Collision collision)      //衝突時に用いるメソッド
    {
        if (collision.gameObject.tag == "Shell")             //  タグShellの物体と衝突した時
        {
            enemy.Damage(damage);                           //ダメージを受ける
        }

    }


}