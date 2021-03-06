﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinCloud : MonoBehaviour {
    //public float gametimePerDay = 96.0f;
    public float rotationRate = 1f; 
    private MasterControls controls;

	// Use this for initialization
	void Start () {
        GameObject controller = GameObject.Find("GameController");
        controls = controller.GetComponent<MasterControls>();
	}
	
	// Update is called once per frame
	void Update () {
        //float deltaAngle = (360.0f / gametimePerDay) * Time.deltaTime;
        float deltaAngle = (360.0f / (rotationRate * controls.gametimePerDay)) * Time.deltaTime;
        transform.Rotate(0f, deltaAngle, 0f);
	}
}
