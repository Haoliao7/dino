using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cloudMove : MonoBehaviour
{
    public  GameManager mymanager;


    new Vector2 newPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        newPos = gameObject.transform.position; // store the current position into newPos 

        newPos.x -= mymanager.speed * Time.deltaTime / 2; // make the x position move to left, the speed should be less cuz it's far

        gameObject.transform.position = newPos; // store the changed position back to this gameobject


        if (gameObject.transform.position.x < -10) // if this object move out of the screen
        {

            gameObject.transform.position = new Vector2(Random.Range(10, 30), Random.Range(0, 4.5f)); // send it back to the right side



        }

    }
}
