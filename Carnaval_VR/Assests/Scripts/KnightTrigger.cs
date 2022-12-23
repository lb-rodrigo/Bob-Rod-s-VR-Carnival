using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightTrigger : MonoBehaviour
{
    public KnightGame game;
    public float countdown = 3.0f;
    bool flag = false;
    float x, y, z;
    // Start is called before the first frame update
    void Start()
    {
        x = this.transform.eulerAngles.x;
        y = this.transform.eulerAngles.y;
        z = this.transform.eulerAngles.z;
    }

    // Update is called once per frame
    void Update()
    {
        
        countdown -= Time.deltaTime;

        
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("target")) {
            KnightGame.score++;
            this.transform.eulerAngles = new Vector3(x-81, y, z);
            flag = true;
            countdown = 3.0f;
        }
              
    }
}
