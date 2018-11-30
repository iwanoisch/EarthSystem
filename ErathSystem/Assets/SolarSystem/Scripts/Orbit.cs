using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour {
    public Transform aroundBody;
    public float orbitalPeriod = 27.3f; // earth days for one complete orbit
    private MasterControls controls;
    //public float gameTimePerDay = 24f; // realtime seconds per game earth day

	// Use this for initialization
	void Start () {
        GameObject controller = GameObject.Find("GameController");
        controls = controller.GetComponent<MasterControls>();
	}
	
	// Update is called once per frame
	void Update () {
        // float deltaAngle = (360.0f / (gameTimePerDay * orbitalPeriod)) * Time.deltaTime;
        float deltaAngle = (360.0f / (orbitalPeriod * controls.gametimePerDay)) * Time.deltaTime;
        transform.RotateAround(aroundBody.position, Vector3.up, deltaAngle);
	}
}
