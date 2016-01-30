using UnityEngine;
using System;
using System.Collections;

public class GoalController : MonoBehaviour {
    
    private bool[] sheepsArrived;

	public GameObject[] sheeps;

	void Start() {
		sheepsArrived = new bool[10];
		// the defualt value of bool is false
	}

    void OnCollisionEnter(Collision collision)
    {
		Debug.Log ("Collision: " + collision.collider.name);
        if (collision.collider.name.Contains("Sheep")){
			int sheepNum = getSheepNum(collision.collider.name);
            sheepsArrived[sheepNum] = true;

			Debug.Log("Sheep" + sheepNum + " is in the goal zone");

			if (allSheep()) {
				Debug.Log("All the sheeps are in the goal zone");
				int score = calculateSickness();
				Debug.Log("Player scored " + score + " out of 1000");
				//finishlevel

			}
        }
    }

    void OnCollisionExit(Collision collision)
    {
		if (collision.collider.name.Contains("Sheep")){
			int sheepNum = getSheepNum(collision.collider.name);
			sheepsArrived[sheepNum] = false;

			Debug.Log("Sheep" + sheepNum + " has left the goal zone");
		}
    }


	bool allSheep () {
		// goes over the sheeps array, returns true iff all the array is true (i.e.  all sheeps are in the goal zone)
		int i;
		for (i=0; i<10; i++) {
			if (!sheepsArrived[i]) {
				return false;
			}
		}

		return true;
	}

	int getSheepNum (string sheep) {
		//All sheep have a number: Takes the sheep's number from it's name -> Takes the 6th char, turns it into a number (double), converts it to int

		return Convert.ToInt32(Char.GetNumericValue(sheep[5]));
	}

	int calculateSickness() {
		// for each sheep calculate how sick it is. Then do avarage on  all sheeps.
		// a sheep starts with red 1.0, for each collision it loses some (0.3 ATM, could change)
		// so a max score is numOfSheeps * 100 (1000)

		float[] sickness = new float[10];
		int i;
		int sum = 0;

		for(i=0; i<10; i++){
			sickness[i] = sheeps[i].renderer.material.color.r * 100;
			sum += Convert.ToInt32(sickness[i]);
		}

		return sum;
	}
}
