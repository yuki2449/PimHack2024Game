using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace PLAYER
{
    public class Attack : MonoBehaviour
    {
        [SerializeField] public GameObject bullet;
        [SerializeField] private float speed;
        [SerializeField] private int count;
        [SerializeField] private float interval = 0;

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                interval += 2;

                if (interval % 2 == 0 && count > 0)
                {
                    count -= 1;

                    GameObject ball = (GameObject)Instantiate(
                        bullet,
                        transform.position,
                        Quaternion.Euler(
                            transform.parent.eulerAngles.x,
                            transform.parent.eulerAngles.y,
                            0));
                    Rigidbody ballrb = ball.GetComponent<Rigidbody>();
                    ballrb.AddForce(transform.forward * speed);

                    //２秒経ったら破壊する
                    Destroy(ball, 2.0f);

                }
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                count = 30;
            }
        }
    }

}