using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FingerTrigger : MonoBehaviour
{
    public FingerGame game;
    //public Collider ring;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("target")) {
            FingerGame.score++;
        }
              
    }
}
