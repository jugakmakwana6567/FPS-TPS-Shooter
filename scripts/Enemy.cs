using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    int Health = 7;
    Material Mat;
    Rigidbody rb;




    // Start is called before the first frame update
    void Start()
    {
        MeshRenderer Mesh = GetComponent<MeshRenderer>();
        Mat = Mesh.material;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(collision.gameObject);
            rb.AddForce(transform.forward);
            Health--;
            if (Health == 5)
            {
                Mat.color = Color.green;
            }
            if (Health == 3)
            {
                Mat.color = Color.yellow;
            }
            if (Health == 1)
            {
                Mat.color = Color.red;

            }
            if (Health <= 0)
            {
                Destroy(gameObject);

            }
            print("hello");


        }

    }
}
