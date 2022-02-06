using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    


    public static float time; // set it to static so it can be called by other scripts
    public static float speed = -5f; // set it to static so it can be called by other scripts like enemyMove script

    public static bool lose = false;


    //singleton pattern, set a variable of the type GameManager and call it instance
    private static GameManager instance;

    //in case some variables of this game manager isn't static, we'll need a reference to it
    public static GameManager FindInstance()
    {
        return instance;
    }


    private void Awake()
    {
        //if we already have a main game manager and this main manager is not this instance of the class
        if (instance != null && instance != this)
        {
            Destroy(this); // then destroy this
        }
        else //if we do not have a main game manager
        {
            instance = this;//make this the main game manager
            DontDestroyOnLoad(gameObject);//and do not destroy this game object when we load new scenes
        }
    }

    void Start()
    {
        time = 0;
        lose = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (lose)//if the player lose
        {
            //stop the timer
        }
        else //if the player is still playing
        {
            time += Time.deltaTime * 10;

        }


        speed = -5f - Mathf.FloorToInt(time/ 100); // add speed every 100 point

        if (Input.GetKeyDown(KeyCode.Space))
        {
            time = 0;
            SceneManager.LoadScene("SampleScene");//load game scene
            lose = false;
        }
        

    }

   




}
