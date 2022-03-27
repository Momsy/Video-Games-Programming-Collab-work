using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
	float moveSpeed =10f;    //this is the speed of the bullet which is launched.

	Rigidbody ball;

	Vector3 moveDirection;		//The move direction is used to follow the rocket when the bullet is launched.

	// Use this for initialization
	void Start () {
		ball = GetComponent<Rigidbody> ();
		//target = GameObject.FindObjectOfType<CharacterMvt>();						//We affect the rocket like target.
		//moveDirection = (target.transform.position - transform.position).normalized * moveSpeed; //This is the change of direction, we take the rocket's position and we adapt the new position of the next bullet with the same speed.
		//ball.velocity = new Vector3 (moveDirection.x, 0,0);        //It represents the rate of change of Rigidbody position (x and y axis).
		//Destroy (gameObject, 3f);
	}

    void FixedUpdate(){
        float movementhorizontal = Input.GetAxis("Horizontal");
        float movementvertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3 (movementhorizontal, 0.0f, movementvertical);
        ball.velocity = movement * moveSpeed;
    }

	void OnCollisionEnter(Collision col)
	{
		if (col.gameObject.name.Equals ("Player")) {  //we test if the player has a collision with a bullet.
			//Debug.Log ("Hit!");
			Destroy (this.gameObject);      //If the bullet hit the rocket, the rocket is automatically destroyed.
		}
        if (col.gameObject.name.Equals ("Obstacle")) {  //we test if the player has a collision with a bullet.
			//Debug.Log ("Hit!");
			Destroy(gameObject);      //If the bullet hit the rocket, the rocket is automatically destroyed.
		}
	}

}

