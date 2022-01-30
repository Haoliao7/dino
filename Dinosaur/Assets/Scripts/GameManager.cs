using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float time;
    public float speed;
    public Text timeText;


    public GameObject lose;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lose.activeSelf)//if the player lose
        {

            //stop the timer
        }
        else //if the player is still playing
        {
            time += Time.deltaTime * 10; 

            timeText.text = "Score:" + Mathf.Round(time).ToString(); // set the time into an integer and change it to string so it can be displayed as text

        }

        speed = 5 + Mathf.FloorToInt(time/ 100); // add speed every 100 point
    }

    public void Restart() {

        Scene scene = SceneManager.GetActiveScene(); //get the current scene
        SceneManager.LoadScene(scene.name);//reload this scene
    }




}
