using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class PlayerMovment : MonoBehaviour

{

    CharacterController character;
    public float speed;
    public Transform pivot;
    private Animator animation;



    public GameObject enemy;


    public GameObject player;

   // public float speed;




    // Start is called before the first frame update
    void Start()
    {
        character = GetComponent<CharacterController>();
        animation = GetComponent<Animator>();

        InvokeRepeating("Enemy", 5f, 10f);


    }

    // Update is called once per frame
    void Update()
    {
        float hAxis = CrossPlatformInputManager.GetAxis("Horizontal");
        float vAxis = CrossPlatformInputManager.GetAxis("Vertical");
        var Movment = hAxis * transform.right + vAxis * transform.forward;
        Movment = Movment.normalized;
        Movment *= speed * Time.deltaTime;

        pivot.position = transform.position;

        if (CrossPlatformInputManager.GetAxis("Horizontal") != 0 || CrossPlatformInputManager.GetAxis("Vertical") != 0)
        {
            transform.rotation = Quaternion.Euler(0, pivot.eulerAngles.y, 0);

            Quaternion newRotation = Quaternion.LookRotation(new Vector3(Movment.x, 0, Movment.z));

            Transform ghost = transform.GetChild(0);
            ghost.rotation = Quaternion.Slerp(ghost.rotation, newRotation, 0f);
            //transform.rotation = newRotation;
        }
      /*  if (character.isGrounded)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                animation.SetTrigger("Jump");
                Movment.y = 2;
            }
        }*/

        //print("====>  "+Physics.gravity.y); //-9.81
     //   Movment.y += Physics.gravity.y * Time.deltaTime * .2f;

        animation.SetFloat("walk", vAxis);
        animation.SetFloat("run", vAxis);
        animation.SetFloat("backward", vAxis);

        character.Move(Movment);
    }
    void Enemy()
    {


        float xOffset = Random.Range(-26.27f, 26.57f);
        float zOffset = Random.Range(-56.73f, 56.60f);
        float yoffset = Random.Range(1, 1);
        Vector3 vector3 = new Vector3(xOffset, yoffset, zOffset);
        var c = Instantiate(enemy, vector3, Quaternion.Euler(0, 0, 0));
        //  Destroy(c, 10);


    }
}
