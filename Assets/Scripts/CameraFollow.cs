using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

	public GameObject ballsphere;

	private Vector3 distance;
	// Use this for initialization
	void Start () {
		distance = transform.position - ballsphere.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = distance + ballsphere.transform.position;
	}
}
