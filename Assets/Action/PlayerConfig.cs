using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PLAYER
{
    public class PlayerConfig : MonoBehaviour
    {
        [SerializeField] private Vector3 Camera_Direction;   //カメラの向き
        [SerializeField] private Vector3 move_direction;     //プレイヤー移動の向き
        [SerializeField] private Vector3 Player_Angle;       //プレイヤーの角度
        [SerializeField] private GameObject Camera;          // アタッチするカメラ
        [SerializeField] private GameObject Config;          //親オブジェクトを定義
        private Rigidbody rb;                                //物理演算コンポーネント
        [SerializeField] private float speed;                //スピードの定義
        float Xlimit = 15.0f;
        float Zlimit = 15.0f;
        private Animator mikan_anime;


        private void Start()
        {
            rb = this.gameObject.GetComponent<Rigidbody>(); //Rigidbodyをコンポーネントに追加
            mikan_anime = GetComponent<Animator>();
        }
        void FixedUpdate()
        {
            //プレイヤーのトランスフォームコンポーネントを定義
            Transform PlayerTransform = this.transform;

            float Horizontal = Input.GetAxis("Horizontal");  //横移動
            float Vertical = Input.GetAxis("Vertical");     //縦移動

            Vector3 Mikan_velocity = new Vector3(Horizontal,rb.velocity.y, Vertical).normalized;

            //move//

            //vector3.scale(a,b); ->aとbをかけた３次元ベクトルの習得
            //カメラの正面の向きと(1,0,1)ベクトルの成分同士の掛け算。xz平面でのカメラの向きを習得
            Camera_Direction = Vector3.Scale(Config.transform.forward, new Vector3(1, 0, 1)).normalized;
            //カメラの向きの方向は縦方向、カメラの右方向の向きは横方向。
            //足し算にして斜めの方向を実装
            move_direction = Camera_Direction * Vertical + Config.transform.right * Horizontal;
            if(Mikan_velocity.magnitude > 0.1f)
            {
                mikan_anime.SetBool("Move", true);
            }
            else
            {
                mikan_anime.SetBool("Move", false);
            }
            rb.velocity = move_direction * speed;  //移動　＝　プレイヤーの向き × スピード



            //move//

            Player_Angle = transform.localEulerAngles;                  //プレイヤーの向きを取得
            Player_Angle.x = Config.transform.localEulerAngles.x;       //回転させた時のx軸角度
            Player_Angle.y = Config.transform.localEulerAngles.y;       //回転させた時のy軸角度
            PlayerTransform.rotation = Quaternion.Euler(Player_Angle.x, Player_Angle.y, 0); //回転してもプレイヤーの向きは変わらない

            Vector3 NowPos = transform.position;
            NowPos.x = Mathf.Clamp(NowPos.x, -Xlimit, Xlimit);
            NowPos.z = Mathf.Clamp(NowPos.z, -Zlimit, Zlimit);

            transform.position = NowPos;
        }

    }

}