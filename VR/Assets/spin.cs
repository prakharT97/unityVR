using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spin : MonoBehaviour {

    public float spinVal = 90;

	
	void Start () {
		
	}
	
	
	void Update () {

        transform.Rotate(Vector3.up * spinVal * Time.deltaTime);

	}

    public void flipspin() {

        spinVal = -spinVal;

    }
}
