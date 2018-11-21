using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot : MonoBehaviour {
    public GameObject clickbox;
    private int speed = 30;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            GameObject gameObject= GameObject.Instantiate(clickbox,this.transform.position,this.transform.rotation);
            Rigidbody rgb = gameObject.GetComponent<Rigidbody>();
            rgb.velocity = this.transform.forward * speed;
        }
	}
}
