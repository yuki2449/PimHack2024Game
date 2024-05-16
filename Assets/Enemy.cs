using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ENEMY
{

    public class Enemy : MonoBehaviour
    {
        [SerializeField] public int HP;         //HP

        void Update()
        {
            if (HP <= 0)                        //HPが０になった時消える
            {
                Destroy(gameObject);
            }
        }
        public void Damage(int damage)          //ダメージを受けた時、HPを減らす
        {
            HP -= damage;
        }

    }
}