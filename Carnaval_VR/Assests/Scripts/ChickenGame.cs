using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class ChickenGame : MonoBehaviour
{
    public GameObject[] Collider;
    public static int score = 0;
    public Text scoreDisplay;


    // Update is called once per frame
    void Update()
    { 
        scoreDisplay.text = "Score: " + score.ToString();
    }


}
