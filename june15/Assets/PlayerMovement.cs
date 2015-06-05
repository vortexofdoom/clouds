using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {
	public float speed;
	public float jumpSpeed;
	private Rigidbody rb;
	void Start()
	{
		rb = GetComponent<Rigidbody>();
	}
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);
		
		rb.AddForce(movement * speed);
		if(
			Input.GetButton("Jump"))
			Jump();

	}

	void Jump()
	{
		rb.AddForce(Vector3.up * jumpSpeed);
	}
}
