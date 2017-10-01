using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	Turtle turtle;
	Text text;

	// Use this for initialization
	void Start () {
		turtle = FindObjectOfType<Turtle> ();
		text = GetComponent<Text> ();
	}
	
	// Update is called once per frame
	void Update () {
		text.text = turtle.GetTurtleCount ().ToString ();
	}
}
