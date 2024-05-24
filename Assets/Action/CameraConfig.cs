using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace PLAYER
{
    public class CameraConfig : MonoBehaviour
    {
        [SerializeField] GameObject Player;

        void Update()
        {
            // マウスの移動量を取得
            float mouseX = Input.GetAxis("Mouse X");
            float mouseY = Input.GetAxis("Mouse Y");

            if (Mathf.Abs(mouseX) > 0.001f)                                     //X軸方向にマウス移動させたらカメラ横回転
            {
                transform.RotateAround(Player.transform.position, Vector3.up, mouseX * 4);
            }
            if (Mathf.Abs(mouseY) > 0.001f)                                     //Y軸方向にマウス回転でカメラ縦回転
            {
                transform.RotateAround(Player.transform.position, transform.right, mouseY * 2);
            }
        }
    }

}
