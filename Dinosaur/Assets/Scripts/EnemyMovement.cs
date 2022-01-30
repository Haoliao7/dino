using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public GameManager mymanager;
    new Vector2 newPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newPos = gameObject.transform.position;// store the current position into newPos 

        newPos.x -= mymanager.speed * Time.deltaTime;// make the x position move to left

        gameObject.transform.position = newPos;// store the changed position back to this gameobject


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
