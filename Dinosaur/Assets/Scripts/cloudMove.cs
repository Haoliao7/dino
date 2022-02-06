using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMove : MonoBehaviour
{
    
    void Update()
    {
        

        transform.position = UtilScript.Vector3Modify(transform.position, GameManager.speed/2 * Time.deltaTime, 0, 0); //change its x position(but slower than enemy)


        if (gameObject.transform.position.x < -10) // if this object move out of the screen
        {

            gameObject.transform.position = new Vector2(Random.Range(10, 30), Random.Range(0, 4.5f)); // send it back to the right side



        }

    }
}
