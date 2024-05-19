using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ENEMY
{

    public class Enemy : MonoBehaviour
    {
        [SerializeField] public int HP;          //HP
        private GameObject DefenseObject;       //でかミカンオブジェクトを定義
        private Rigidbody rb; //物理演算コンポーネント
        [SerializeField] private float enemy_speed; //スピードの定義
        [SerializeField] private Vector3 enemy_move_direction;     //enemy移動の向き
        [SerializeField] private Vector3 enemy_Angle;         //enemyの角度


        void Start()
        {
            DefenseObject = GameObject.FindWithTag("Defence");

            rb = this.gameObject.GetComponent<Rigidbody>(); //Rigidbodyをコンポーネントに追加
        }


        void Update()
        {
            transform.position = Vector3.MoveTowards(
                transform.position,
                DefenseObject.transform.position,
                enemy_speed * Time.deltaTime);

            if (HP <= 0)                        //HPが０になった時消える
            {
                Destroy(gameObject);
            }
        }
        public void Damage(int damage)          //ダメージを受けた時、HPを減らす
        {
            HP -= damage;
        }

        private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.tag == "Defence")
            {
                Destroy(this.gameObject);
            }
        }
    }
}