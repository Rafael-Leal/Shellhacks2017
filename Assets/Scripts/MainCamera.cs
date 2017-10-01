using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera : MonoBehaviour {

	Player player;
	// Use this for initialization
	void Start () {
		player = FindObjectOfType<Player>();
		print (player.name);
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.position = player.transform.position;
	}
}
