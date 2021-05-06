using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Watcher: MonoBehaviour {

    private float speedY = -0.006f;
    private float speed;
    public GameObject watcher;

	void Start () {
        
        speed = Random.RandomRange(-0.04f, 0.04f);
        
        
    }
	
   
	
	void FixedUpdate () {
        watcher.transform.Translate(speed, speedY, 0);
        if (watcher.transform.position.x > 1)
        {
            speed = -speed;
        }
        else if (watcher.transform.position.x < -1)
        {
            speed = -speed;
        }
        
	}
}
