using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turtle : MonoBehaviour {

	public bool turtleSeen = false;
	static int turtleCount = 0;

	public void Seen(){
		if (this.turtleSeen == false) {
			turtleCount += 1;
			turtleSeen = true;
			print ("Turtles seen: " + turtleCount);
		}
	}

	public int GetTurtleCount(){

		return turtleCount;
	}
}
