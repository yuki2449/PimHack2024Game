using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerConfig : MonoBehaviour
{
    [SerializeField] public Vector3 Camera_Direction;   //カメラの向き
    [SerializeField] public Vector3 move_direction;     //プレイヤー移動の向き
    [SerializeField] public GameObject Camera;          // アタッチするカメラ
    [SerializeField] public Rigidbody rb;               //物理演算コンポーネント
    [SerializeField] public float speed;                //スピードの定義

    private void Start()
    {
        rb = this.gameObject.GetComponent<Rigidbody>(); //Rigidbodyをコンポーネントに追加
    }
    void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");  //横移動
        float Vertical = Input.GetAxis("Vertical");     //縦移動

        //move//

        //vector3.scale(a,b); ->aとbをかけた３次元ベクトルの習得
        //カメラの正面の向きと(1,0,1)ベクトルの成分同士の掛け算。xz平面でのカメラの向きを習得
        Camera_Direction = Vector3.Scale(Camera.transform.forward, new Vector3(1, 0, 1)).normalized;

        //カメラの向きの方向は縦方向、カメラの右方向の向きは横方向。
        //足し算にして斜めの方向を実装
        move_direction = Camera_Direction * Vertical + Camera.transform.right * Horizontal;
        rb.velocity = move_direction * speed;  //移動　＝　プレイヤーの向き × スピード
        //move

    }

}
