using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerWASD : MonoBehaviour 
{
	public float speed = 5f;
	public float turnSmoothing = 15f;
	private Rigidbody rb;
	private Animator anim;

	Vector3 movement;

	// Use this for initialization
	void Awake () {
		rb = GetComponent<Rigidbody> ();	
		anim = GetComponent<Animator>();
	}

	void FixedUpdate()
	{	
		float hor, ver;
		hor = Input.GetAxis ("Horizontal");
		ver = Input.GetAxis ("Vertical");

		Move (hor, ver);
	}

	void Move(float h, float v)
	{
		movement.Set (h, 0, v);
		movement = movement.normalized * speed * Time.deltaTime;
		rb.MovePosition (transform.position + movement);

		if (h != 0 || v != 0) 
		{
			// Player is moving
			Rotating (h, v);
			anim.SetFloat("Speed", 5f, speed, Time.deltaTime);
		}
		else
		{
			// Player is not moving
			anim.SetFloat("Speed", 0);
		}
	}

	//   _\|/_
	void Rotating(float h, float v)
	{
		Vector3 targetDirection = new Vector3 (h, 0, v);
		Quaternion targetRotation = Quaternion.LookRotation (targetDirection, Vector3.up);
		Quaternion newRotation = Quaternion.Lerp (rb.rotation, targetRotation, turnSmoothing * Time.deltaTime );
		rb.MoveRotation (newRotation);
	}

	void AudioManagement ()
	{
		
	}
}
