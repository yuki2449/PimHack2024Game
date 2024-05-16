using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shell : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)      //衝突時に用いるメソッド
    {
        if (collision.gameObject.tag == "Enemy")             //  Enemyと衝突した時
        {
            Destroy(this.gameObject);                           //消える
        }

    }
}
