using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    /*  public GameObject enemy ;


      public GameObject player;

      public float speed;


      // Start is called before the first frame update
      void Start()
      {
          InvokeRepeating("Enemy", 5f,10f);
      }

      // Update is called once per frame
      void Update()
      {
        enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, player.transform.position, speed);
      }
      void Enemy()
      {


          float xOffset = Random.Range(-26.27f, 26.57f);
          float zOffset = Random.Range(-56.73f, 56.60f);
          float yoffset = Random.Range(1, 1);
          Vector3 vector3 = new Vector3(xOffset,yoffset, zOffset);
          var c = Instantiate(enemy, vector3, Quaternion.Euler(0, 0, 0));
        //  Destroy(c, 10);


      }*/
     GameObject target;
    float speed;

    private void Start()
    {
        speed = 3f;
        target = GameObject.Find("FreeSample_male_1");
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.transform.position, speed*Time.deltaTime);
    }
}
