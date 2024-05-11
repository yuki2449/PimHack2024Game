using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCont : MonoBehaviour
{

    private GameObject mainCamera;
    private GameObject playerObject;
    public float rotatespeed = 2.0f;

    // Start is called before the first frame update
    void Start()
    {
        mainCamera = Camera.main.gameObject;
        playerObject = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        rotatecamera();
    }

    private void rotatecamera()
    {
        Vector3 angle = new Vector3(Input.GetAxis("Mouse X") * rotatespeed, Input.GetAxis("Mouse Y") * rotatespeed, 0);

        mainCamera.transform.RotateAround(playerObject.transform.position, Vector3.up, angle.x);
        mainCamera.transform.RotateAround(playerObject.transform.position, transform.right, angle.y);

    }


}
