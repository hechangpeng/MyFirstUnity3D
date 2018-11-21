﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BolletMoveMent : MonoBehaviour {

    public int speed = 5;
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update () {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        Debug.Log("h="+h+",v="+v);
        this.transform.Translate(new Vector3(h,v,0)*Time.deltaTime*speed);
    }
}
