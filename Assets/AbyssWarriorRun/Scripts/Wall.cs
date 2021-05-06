using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour {
    
    private Vector2 StartPos;
	
	void Start () {
        StartPos = this.transform.position;
	}
	
	
	void FixedUpdate () {
        transform.Translate(0, -0.08f, 0);
       
        
        
	}
    public void OnCollisionEnter2D(Collision2D Collision2D)
    {
        if (Collision2D.gameObject.CompareTag("Destroy"))
        {
            this.transform.position = new Vector2(StartPos.x, -0.25f);
        }
        
    }
    


}
