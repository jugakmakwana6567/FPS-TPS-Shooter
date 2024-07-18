using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform BulletSpawnpoint;
    public GameObject BulletPrefab;
    public float BulletSpeed;


    private void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            var bullet = Instantiate(BulletPrefab, BulletSpawnpoint.position,BulletSpawnpoint.rotation);
            bullet.GetComponent<Rigidbody>().velocity = BulletSpawnpoint.forward * BulletSpeed;
        }
    }



}
