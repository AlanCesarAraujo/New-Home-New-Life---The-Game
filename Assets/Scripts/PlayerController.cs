using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boudary{

	public float xMin, xMax, zMin, zMax;

}

public class PlayerController : MonoBehaviour {

	public Rigidbody rb;
	public float speed;
	public Boudary boudary;
	

	void Start(){

		rb = GetComponent<Rigidbody>();

	}

	void FixedUpdate(){

		float horizontal = Input.GetAxis("Horizontal");
		float vertical = Input.GetAxis("Vertical");

		Vector3 movement = new Vector3(horizontal, 0.0f, vertical);
		rb.velocity = movement * speed;

		rb.position = new Vector3( 
			Mathf.Clamp(rb.position.x, boudary.xMin, boudary.xMax), 
			0.0f,
			Mathf.Clamp(rb.position.z, boudary.zMin, boudary.zMax)
		);

	}
}
