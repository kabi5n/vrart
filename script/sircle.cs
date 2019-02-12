using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sircle : MonoBehaviour {

    public float circle;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(new Vector3(0, circle, 0));
    }
}
