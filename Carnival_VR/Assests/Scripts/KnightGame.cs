using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;

public class KnightGame : MonoBehaviour
{
    public GameObject[] Collider;
    public float countdown = 3.0f;
    public int randomNum = 0;
    public int prev = 0;
    public static int score = 0;
    public Text scoreDisplay;

    public EntrancePoint entrance_script;

    float x1, y1, z1, x2, y2, z2, x3, y3, z3, x4, y4, z4, x5, y5, z5;

    public void turnPower(int rand) {

        if (rand == 0) {
            Collider[0].SetActive(true);
            Collider[1].SetActive(false); 
            Collider[2].SetActive(false); 
            Collider[3].SetActive(false); 
            Collider[4].SetActive(false); 
        }
        else if (rand == 1) {
            Collider[0].SetActive(false); 
            Collider[1].SetActive(true);
            Collider[2].SetActive(false); 
            Collider[3].SetActive(false); 
            Collider[4].SetActive(false);
        }
        else if (rand == 2) {
            Collider[0].SetActive(false); 
            Collider[1].SetActive(false); 
            Collider[2].SetActive(true);
            Collider[3].SetActive(false);
            Collider[4].SetActive(false); 
        }
        else if (rand == 3) {
            Collider[0].SetActive(false); 
            Collider[1].SetActive(false); 
            Collider[2].SetActive(false); 
            Collider[3].SetActive(true);
            Collider[4].SetActive(false);
        }
        else if (rand == 4) {
            Collider[0].SetActive(false); 
            Collider[1].SetActive(false); 
            Collider[2].SetActive(false); 
            Collider[3].SetActive(false);
            Collider[4].SetActive(true);
        }
    }

    public void trigger() {
            randomNum = Random.Range(0, 4);
            if(prev == randomNum){
                if(randomNum == 4){
                    randomNum--;
                }
                else{
                    randomNum++;
                }
            }
           //score = score + 1;
           //scoreDisplay.text = "Score: " + score;
            

            turnPower(randomNum);    
            countdown = 2.0f; 
    }

    public void resetKnights() {
        Collider[0].SetActive(true);
        Collider[1].SetActive(true);
        Collider[2].SetActive(true);
        Collider[3].SetActive(true);
        Collider[4].SetActive(false);
    }
    
    // Start is called before the first frame update
    void Start()
    {
        resetKnights();

        x1 = this.transform.eulerAngles.x;
        y1 = this.transform.eulerAngles.y;
        z1 = this.transform.eulerAngles.z;

        x2 = this.transform.eulerAngles.x;
        y2 = this.transform.eulerAngles.y;
        z2 = this.transform.eulerAngles.z;

        x3 = this.transform.eulerAngles.x;
        y3 = this.transform.eulerAngles.y;
        z3 = this.transform.eulerAngles.z;

        x4 = this.transform.eulerAngles.x;
        y4 = this.transform.eulerAngles.y;
        z4 = this.transform.eulerAngles.z;

        x5 = this.transform.eulerAngles.x;
        y5 = this.transform.eulerAngles.y;
        z5 = this.transform.eulerAngles.z;

    }


    // Update is called once per frame
    void Update()
    {
      

        if (entrance_script.GetEntrance() == true) {
            scoreDisplay.text = "Score: " + score.ToString();

            prev = randomNum;
            randomNum = Random.Range(0, 3);
            countdown -= Time.deltaTime;

            if(countdown < 0.0f) {

                if(prev == randomNum){
                    if(randomNum == 3){
                        randomNum--;
                    }
                    else{
                        randomNum++;
                    }
                }

                turnPower(randomNum);
                countdown = 3.0f;
            }
        }
        else {
            resetKnights();
        }
    }


}
