using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ENEMY
{

    public class Enemy : MonoBehaviour
    {
        public int damage;                                          // ダメージを定義
        [SerializeField] public int HP;                             //HP
        private GameObject DefenseObject;                           //でかミカンオブジェクトの定義
        private Rigidbody rb;                                       //物理演算コンポーネント
        [SerializeField] private float enemy_speed;                 //スピードの定義
        [SerializeField] private Vector3 enemy_move_direction;      //enemy移動の向き
        [SerializeField] private Vector3 enemy_Angle;               //enemyの角度


        void Start()
        {
            DefenseObject = GameObject.FindWithTag("Defence");      //Defence  

            rb = this.gameObject.GetComponent<Rigidbody>();         //Rigidbodyをコンポーネントに追加
        }


        void Update()
        {
            transform.position = Vector3.MoveTowards(               //守るものに最短距離で近づく
                transform.position,
                DefenseObject.transform.position,
                enemy_speed * Time.deltaTime);

            if (HP <= 0)                                            //HPが０になった時消える
            {
                Destroy(gameObject);
            }
        }
        public void Damage(int damage)                              //ダメージを受けた時、HPを減らす
        {
            HP -= damage;
        }

        private void OnCollisionEnter(Collision collision)          //守るものにぶつかった時
        {
            if (collision.gameObject.tag == "Defence")
            {
                Destroy(this.gameObject);                           //消える
            }
        }

        private void OnTriggerEnter(Collider other)                 //球に当たった時
        {
            if (other.gameObject.CompareTag("Shell"))
            {
                Damage(damage);                                     //ダメージを受け
                Destroy(other.gameObject);                          //球も消える
            }
        }
    }
}