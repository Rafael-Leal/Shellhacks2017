using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtleFinder : MonoBehaviour {

	string objectCollided;
	GameObject turtle;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {

		RaycastHit hit; // the one who stores hit info - very important !!!
		Vector3 origin = transform.position;
		Vector3 direction = transform.TransformDirection(Vector3.forward);
		Ray myRay = new Ray (origin, direction);

		Debug.DrawRay (origin, direction);

		if (Physics.Raycast (myRay, out hit, 300f)) 
		{
			if (hit.collider.tag == "turtle") {
				Debug.Log("hit a turtle");
				Turtle turtle = hit.transform.GetComponent<Turtle> ();
				turtle.Seen ();
				Debug.Log("Seen");
				}

			}
		} 

	}

