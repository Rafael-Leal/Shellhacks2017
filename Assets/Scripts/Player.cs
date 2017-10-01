using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public int speed;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");

		Vector3 position = this.transform.position;
			
		position.x += moveHorizontal * speed * Time.deltaTime;
		position.z += moveVertical * speed * Time.deltaTime;

		transform.position = position;

	}
}
