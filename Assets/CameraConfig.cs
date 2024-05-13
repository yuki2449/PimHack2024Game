using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConfig : MonoBehaviour
{
    [SerializeField] GameObject Player;
    // Update is called once per frame
    void Update()
    {
        // マウスの移動量を取得
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");

        if (Mathf.Abs(mouseX) > 0.001f)
        {
            transform.RotateAround(Player.transform.position, Vector3.up, mouseX * 4);
        }
        if (Mathf.Abs(mouseY) > 0.001f)
        {
            transform.RotateAround(Player.transform.position, transform.right, mouseY);
        }
    }
}
