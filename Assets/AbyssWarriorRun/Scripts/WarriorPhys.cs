using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WarriorPhys : MonoBehaviour {
    public GameObject pn;
    private Warrior warrior;
    public bool bl;

    void Awake() {
        warrior = pn.GetComponent<Warrior>();
        
        
        
    }


    private void OnCollisionEnter2D(Collision2D collision2D)
    {
        
        if (collision2D.gameObject.CompareTag("Wall"))
        {
            bl = true;
        }
    }

    private void OnCollisionExit2D(Collision2D collision2D)
    {
        if (collision2D.gameObject.CompareTag("Wall"))
        {
            bl = false;
        }
    }



    private void OnTriggerEnter2D(Collider2D collision2D)
    {
        

        if (collision2D.gameObject.CompareTag("Enemy") && bl == false)
        {
            Destroy(collision2D.gameObject);

        }


    }

    

    
}
