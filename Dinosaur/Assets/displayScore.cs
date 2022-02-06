using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class displayScore : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<Text>().text ="Score:" + Mathf.Round(GameManager.time).ToString(); // set the time into an integer and change it to string so it can be displayed as text
    }
}
