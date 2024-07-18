using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    CharacterController controller;
    public float Speed;
    public Transform pivot;

    // Start is called before the first frame update
    void Start()
    {
        controller=GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 hAxis = Input.GetAxis("Horizontal") * Vector3.right;
        Vector3 vAxis = Input.GetAxis("Vertical") * Vector3.forward;

        print($"h={hAxis} & v={vAxis}");

        Vector3 movement = hAxis + vAxis;
        movement = movement.normalized;
        movement *= Speed;
        controller.Move(movement * Time.deltaTime);

        pivot.position = transform.position;

    }
}
