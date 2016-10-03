using UnityEngine;
using System.Collections;

public class testePErsonagem : MonoBehaviour {


	//Variaveis de controle para andar, correr, saltar.
	public bool esta_no_chao = false;
	public float moveForce = 400.0f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 7.0f;				// The fastest the player can travel in the x axis.
	public float jumpForce = 2500.0f;			    // Amount of force added when the player jumps.
	public bool saltando = false;
	public GameObject obj;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//indo para esquerda
		if(Input.GetKey(KeyCode.LeftArrow)){
			
			obj.transform.rotation = Quaternion.Euler(0, 180, 0);
			if(obj.rigidbody2D.velocity.x > -maxSpeed)
				obj.rigidbody2D.AddForce(Vector2.right * -moveForce);
			
		}
		
		//indo para direita
		else if(Input.GetKey(KeyCode.RightArrow)){
			
			obj.transform.rotation = Quaternion.Euler(0, 0, 0);
			if(obj.rigidbody2D.velocity.x < maxSpeed)
				obj.rigidbody2D.AddForce(Vector2.right * moveForce);
		}

	}
}
