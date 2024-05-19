using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PLAYER
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] public GameObject bullet;                      //発射する球を定義
        [SerializeField] private float speed;                           //球の速さ
        [SerializeField] private int count;                             //打てる球数
        [SerializeField] private float interval = 0;                    // 球を発射できるインターバル

        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))                       // 左クリックした時
            {
                interval += 2;                                          //インターバルカウントを２足す

                if (interval % 2 == 0 && count > 0)                     //インターバルカウントが２で割れる時かつ球数が１以上の時
                {
                    count -= 1;                                         //球数１消費して

                    GameObject ball = (GameObject)Instantiate(          //球を生成
                        bullet,
                        transform.position,
                        Quaternion.Euler(
                            transform.parent.eulerAngles.x,
                            transform.parent.eulerAngles.y,
                            0));
                    Rigidbody ballrb = ball.GetComponent<Rigidbody>();  //球に物理コンポーネント付与
                    ballrb.AddForce(transform.forward * speed);         //クリックした向き＊スピードの力を加える

                    Destroy(ball, 1.0f);                                //1秒経ったら破壊する
                }
            }
            else if (Input.GetKeyDown(KeyCode.R))                       //Rでリロード
            {
                count = 30;
            }
        }
    }

}