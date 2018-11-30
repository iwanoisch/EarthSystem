using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class PlanetMarkerHandler : MonoBehaviour {
    public List<GameObject> bodiesObj;
    public List<Transform> bodies = new List<Transform>();
    //public List<string> markerId = new List<string>();

    private int planetN;

    private VuMarkManager mVuMarkManager;
    private PlanetView planetView;

	// Use this for initialization
	void Start () {
        // Get the Planet View component
        planetView = GetComponent<PlanetView>();

        

        // Register callbacks to VuMark Manager
        mVuMarkManager = TrackerManager.Instance.GetStateManager().GetVuMarkManager();
        mVuMarkManager.RegisterVuMarkDetectedCallback(OnVuMarkDetected);


        mVuMarkManager.RegisterVuMarkLostCallback(OnVuMarkLost);

        // Deactivate all Planet views
		//solarSystem.SetActive(false);
        foreach(GameObject item in bodiesObj) {
            Debug.Log("item : "+ item) ;
            //Debug.Log(item);
            //item.SetActive(false);
        }
            
		    
        		
	}

    public void OnVuMarkLost(VuMarkTarget target){

    }

    public void OnVuMarkDetected(VuMarkTarget target) {
       // Debug.Log("New VuMark1: " + target.InstanceId.StringValue); //Print MarkID
        
        int id = markIdToInt(target.InstanceId.StringValue);
        // Debug.Log("New VuMark2: " + id);
        
        planetView.planet = bodies[id];
        
        // Debug.Log("New VuMark3: " + bodies[id]);


        // GameObject solarSystem = GameObject.Find("SolarSystem");

        // GameObject sun = GameObject.Find("Sun");
        // GameObject venus = GameObject.Find("Venus");
        // GameObject mercury = GameObject.Find("Mercury");      
        // GameObject earthMoon = GameObject.Find("Earth-Moon");
        // GameObject mars = GameObject.Find("Mars");
        // GameObject jupiter = GameObject.Find("Jupiter");
        // GameObject saturn = GameObject.Find("Saturn");
        // GameObject uranus = GameObject.Find("Uranus");
        // GameObject neptune = GameObject.Find("Neptune");
        // GameObject pluto = GameObject.Find("Pluto");


        // switch(id){
        //     case 0 : solarSystem.SetActive(true);
        //     Debug.Log("New VuMark3: " + bodies[id]);
        //         return;
        //     case 1 : 
                
        //         mercury.SetActive(true);
        //         Debug.Log("New VuMark3: " + bodies[id]);
        //         return;
        //     case 2 : venus.SetActive(true);
        //         return;
        //     case 3 : earthMoon.SetActive(true);
        //         return;
        //     case 4 : mars.SetActive(true);
        //         return;
        //     case 5 : jupiter.SetActive(true);
        //         return;
        //     case 6 : saturn.SetActive(true);
        //         return;
        //     case 7 : uranus.SetActive(true);
        //         return;
        //     case 8 : neptune.SetActive(true);
        //         return;
        //     case 9 : pluto.SetActive(true);
        //         return;
        // }

        // if (id == 0) {

        //     foreach(Transform item in bodies){ // Activate all Planet
		// 	item.SetActive (true);
        //     // Debug.Log("New VuMark: " + item);
		//     } 
            
        // } else {
        //         for (int i = 0; i < bodies.Count; i++) {
        //             if (bodies [i] == getVuMarkID (target)) {
        //                 bodies [i].SetActive (true);

        //                 // Set model number
        //                 planetId = i;
        //             }
        //         }
        //     }
    }

    private int markIdToInt(string str) {
        // Debug.Log("New VuMark4: " + str);
       /* if (str ==  "al"){
            str = "1" ;
            return int.Parse(str);
        }
        if (str == "bu")
        {
            str = "2";
            return int.Parse(str);
        }
        */
        //return string str;
        return int.Parse(str);
    }

 
	// Update is called once per frame
	void Update () {
		
	}
}
