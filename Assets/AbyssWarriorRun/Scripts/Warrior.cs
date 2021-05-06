using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Events;
public class Warrior : MonoBehaviour, IPointerClickHandler {
    
    private Animator anim;
    public GameObject warrior;
    private Rigidbody2D rb;
    private float Speed;
    public bool spdx = false;
    public int t = 0;
    private float SpwnTime;
    public GameObject watcher;
    private void Start()
    {
        StartCoroutine(WatcherCoroutine());
        anim = warrior.GetComponent<Animator>();
        rb = warrior.GetComponent<Rigidbody2D>();
        SpwnTime = Random.RandomRange(35, 50);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        spdx = !spdx;
        anim.Play("Jump");

    }


    public IEnumerator WatcherCoroutine()
    {
        for (; ;  )
        {

            
              
              yield return new WaitForSeconds(SpwnTime);
              Instantiate(watcher);



        }
    }


    void FixedUpdate () {
        
        if(spdx == true)
        {
            t = 1;
            Speed = -1500;
            rb.velocity = new Vector2(Speed * Time.deltaTime, 0);
            warrior.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z + 90);
            
        }
        else if(spdx == false)
        {
            t = 2;
            Speed = 1500;
           rb.velocity = new Vector2(Speed * Time.deltaTime, 0);
            warrior.transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, transform.rotation.eulerAngles.z + 90);
        }
        
        

    }
}
