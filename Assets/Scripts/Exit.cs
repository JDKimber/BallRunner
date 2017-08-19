using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit : MonoBehaviour {

	public void exitgame()
	{
		Debug.Log ("You pressed the exit Button");
		Application.Quit();
	}
}
