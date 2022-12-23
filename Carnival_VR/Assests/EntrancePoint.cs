using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntrancePoint : MonoBehaviour
{
    public bool enter = false;
    public int randomNum = 0;
    //public Collider ring;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }

    public bool GetEntrance() {
        return enter;
    }
    

    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("walk")) {
            enter = !enter;
        }
              
    }
}
