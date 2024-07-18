using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform player;
    Vector3 offset;
    public Transform pivot;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {

       // Cursor.lockState = CursorLockMode.Locked;

        var mouseX = Input.GetAxis("Mouse X");

        var mouseY = Input.GetAxis("Mouse Y");
        pivot.Rotate(mouseY*2, mouseX * 2, 0);
        //0 1 -> 0 360
        var rotation = Quaternion.Euler(pivot.eulerAngles.x, pivot.eulerAngles.y, 0);
        transform.position = player.position + (rotation * offset);

        Vector3 rotate = transform.eulerAngles;
        rotate.y = pivot.eulerAngles.y;
        rotate.x =  pivot.eulerAngles.x;
        transform.rotation = Quaternion.Euler(rotate);


    }

}
