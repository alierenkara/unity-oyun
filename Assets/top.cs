using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class top : MonoBehaviour {


    
    public Transform klon;
    public float timer = 0f;
    public float timerMax = 3.0f;
    
    void Start () {

        timer = timerMax;
      
    }
	
	void Update () {


        timer -= Time.deltaTime;
        CreatTriangle();
    

            }
    void CreatTriangle(){
        if (timer < 0)
        {

            Instantiate(klon, new Vector3(-0.2f,10.6f, 2.83f), Quaternion.identity);
            timer = timerMax;
        }


    }

    }
