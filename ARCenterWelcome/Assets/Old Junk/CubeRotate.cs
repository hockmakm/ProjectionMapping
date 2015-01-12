using UnityEngine;
using System.Collections;

public class CubeRotate : MonoBehaviour {

	// Use this for initialization
	public float speed = 1f;
	
	
	void Update ()
	{
		transform.Rotate(Vector3.up+Vector3.left, speed);
	}
}