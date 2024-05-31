using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ENEMY
{

    public class Rare_Enemy : MonoBehaviour
    {
        public int damage;                                          // ダメージを定義
        [SerializeField] public int HP;                             //HP
        private GameObject DefenseObject;                           //でかミカンオブジェクトの定義
        private Rigidbody rb;                                       //物理演算コンポーネント
        [SerializeField] private float enemy_speed;                 //スピードの定義
        [SerializeField] private Vector3 enemy_move_direction;      //enemy移動の向き
        [SerializeField] private Vector3 enemy_Angle;               //enemyの角度
        [SerializeField] public AudioClip EnemySound;               //
        AudioSource EnemyAudio;                                     //
        [SerializeField] private GameObject KillEffect;             //
        [SerializeField] public AudioClip KillSound;                //
        bool killflag = true;
        public ScoreManager scoreManager;                           // ScoreManager クラスのインスタンスを参照する変数を宣言
        private int SC;

        void Start()
        {
            DefenseObject = GameObject.FindWithTag("Defence");      //Defence  

            rb = this.gameObject.GetComponent<Rigidbody>();         //Rigidbodyをコンポーネントに追加

            EnemyAudio = GetComponent<AudioSource>();
        }


        void Update()
        {
            transform.position = Vector3.MoveTowards(               //守るものに最短距離で近づく
                transform.position,
                DefenseObject.transform.position,
                enemy_speed * Time.deltaTime);

            if (HP <= 0)                                            //HPが０になった時消える
            {

                Destroy(gameObject, 0.5f);
                Invoke(nameof(kill), 0.49f);
                Invoke(nameof(KillBGM), 0.2f);
                if (SC == 0)
                {
                    scoreManager = FindObjectOfType<ScoreManager>();
                    scoreManager.score_num += 500;
                    SC += 1;
                }

            }
        }
        public void Damage(int damage)                              //ダメージを受けた時、HPを減らす
        {
            HP -= damage;
            EnemyAudio.PlayOneShot(EnemySound);

            Invoke(nameof(Remove), 0.5f);
        }

        private void OnCollisionEnter(Collision collision)          //守るものにぶつかった時
        {
            if (collision.gameObject.tag == "Defence")
            {
                Destroy(this.gameObject);                           //消える
            }
            if (collision.gameObject.tag == "Shell")                // 球に当たった時
            {
                Damage(damage);                                     // ダメージを受ける
            }
        }

        void Remove()                                               //再接近
        {
            rb.velocity = Vector3.zero;                             //速度０
            transform.position = Vector3.MoveTowards(               //守るものに最短で近づく
                transform.position,
                DefenseObject.transform.position,
                enemy_speed * 3f * Time.deltaTime);

        }

        void kill()                                                             //消える時のエフェクト
        {
            GameObject effect = (GameObject)Instantiate(KillEffect);            //エフェクト生成
            effect.transform.position = gameObject.transform.position;          //敵のいる位置に生成
            Destroy(effect, 0.1f);
           
        }

        void KillBGM()
        {
            if (killflag == true)
            {
                EnemyAudio.PlayOneShot(KillSound);
                killflag = false;
            }
        }
    }
}