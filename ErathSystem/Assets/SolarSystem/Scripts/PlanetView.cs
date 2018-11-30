using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetView : MonoBehaviour {
    public Transform solarSystem;
    public Transform planet;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 position = solarSystem.localPosition;
        if(planet != null) {
            
            // Move solar system so planet is in the center
            position.x = -planet.localPosition.x * solarSystem.localScale.x;
            position.z = -planet.localPosition.z * solarSystem.localScale.x;
        } else {

            // Center solar system on the sun
            position.x = 0f;
            position.z = 0f;
        }
        solarSystem.localPosition = position;
		
	}
}
