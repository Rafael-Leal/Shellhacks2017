using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomPlacement : MonoBehaviour {

	// Use this for initialization
	void Start () {
		generateRandom (5);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void generateRandom(int numOfObjects){

		Vector3 area = new Vector3(Random.Range(-1500.0f, 1500.0f), Random.Range(-30.0f, 420.0f), Random.Range(-10.0f, 10.0f));
		for (int i = 0; i < numOfObjects; i++) {
			Instantiate(this.gameObject, area, Quaternion.identity);
		}
	}
}
