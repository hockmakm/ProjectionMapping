using UnityEngine;
using System.Collections;

public class PointAtScreen : MonoBehaviour {
	public Vector3 target;
	// Use this for initialization
	void Start () {
		//TODO: Get vector from a target object, instead of hard coding
	}
	
	// Update is called once per frame
	void Update () {
		transform.LookAt(target);
	}
}
