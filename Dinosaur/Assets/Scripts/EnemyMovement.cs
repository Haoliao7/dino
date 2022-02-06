using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    void Update()
    {
        
        transform.position = UtilScript.Vector3Modify(transform.position,GameManager.speed*Time.deltaTime, 0, 0); // change its x position


        if (gameObject.transform.position.x < -10)// if this object move out of the screen
        {

            if (gameObject.tag == "enemyup")// make the upper enemy not so frequent
            {
                gameObject.transform.position = new Vector2(Random.Range(25, 40), transform.position.y);// send it back to the right side
            }
            else {
                gameObject.transform.position = new Vector2(Random.Range(10, 25), transform.position.y);// send it back to the right side
            }

           
        
        }



    }
}
