using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MasterControls : MonoBehaviour {
    public float gametimePerDay = 0.05f; 
 
    public void SlowTime() { 
        gametimePerDay = 0.05f; 
    } 
 
    public void ResetTime() { 
        gametimePerDay = 0.099f; 
    } 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
