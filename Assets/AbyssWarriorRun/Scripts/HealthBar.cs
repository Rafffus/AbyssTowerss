using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour {

    public Image HpBar;
    public float fill;
	void Start () {
        fill = 1f;
	}
	
	
	void FixedUpdate () {
        HpBar.fillAmount = fill;
        fill -= Time.deltaTime * 0.1f;
	}
}
