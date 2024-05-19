using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ENEMY
{
    public class Spawn : MonoBehaviour
    {

        [SerializeField] public GameObject enemypref;                           //生成される敵を定義
        [SerializeField] public float Respawn_MinT = 2f;                        //生成される最小時間と最大時間
        [SerializeField] public float Respawn_MaxT = 5f;
        [SerializeField] public float Respawn_MinX_Pos = -10f;                  //X軸での湧く範囲
        [SerializeField] public float Respawn_MaxX_Pos = 10f;
        [SerializeField] public float Respawn_MinY_Pos = 0f;                    //Y軸での湧く範囲
        [SerializeField] public float Respawn_MaxY_Pos = 5f;
        [SerializeField] public float Respawn_MinZ_Pos = -10f;                  //Z軸での湧く範囲
        [SerializeField] public float Respawn_MaxZ_Pos = 10f;
        private float Respawn_Interval;                                         //生成間隔を定義
        private float time = 0f;                                                //生成間隔を測るための時間を定義
        private GameObject DeathObject;                                         //消えるオブジェクトを定義
        private Enemy en;                                                       //Enemy クラスを使います

        void Start()
        {
            Respawn_Interval = Random.Range(Respawn_MinT, Respawn_MaxT);        //生成される時間を決定
        }


        void Update()
        {
            time += Time.deltaTime;                                             //時間を計測

            if (time > Respawn_Interval)                                        //生成時間を超えた時
            {
                GameObject enemy = Instantiate(enemypref);                      //敵を生成
                enemy.transform.position = GetRespawnPosition();
                time = 0f;                                                      //時間をリセット
                Respawn_Interval = Random.Range(Respawn_MinT, Respawn_MaxT);    //生成時間再決定
            }
        }

        private Vector3 GetRespawnPosition()                                    //敵の生成位置を決定するメソッド
        {
            float x = Random.Range(Respawn_MinX_Pos, Respawn_MaxX_Pos);
            float y = Random.Range(Respawn_MinY_Pos, Respawn_MaxY_Pos);
            float z = Random.Range(Respawn_MinZ_Pos, Respawn_MaxZ_Pos);

            return new Vector3(x, y, z);
        }
    }
}