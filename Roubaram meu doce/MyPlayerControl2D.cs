using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class MyPlayerControl2D : MonoBehaviour {


	public float movespeed = 4;

	//Variaveis de controle para andar, correr, saltar.
	public bool esta_no_chao = false;
	public float moveForce = 550.0f;			// Amount of force added to move the player left and right.
	public float maxSpeed = 7.0f;				// The fastest the player can travel in the x axis.
	public float jumpForce = 3000.0f;			    // Amount of force added when the player jumps.
	public bool saltando = false;

	public  GameObject objModelPlayer;
	private PlayerModelScript playerModelScript;

	
	private void pular(){

		rigidbody2D.AddForce(new Vector2(0f, jumpForce));
		saltando = true;

	}


	private void pulando(){
		if(saltando){
			playerModelScript.setAnimation(PlayerModelScript.ANIMATION_JUMP, 0.15f);
			rigidbody2D.drag = 0.0f;
		}
		else if( !saltando && !esta_no_chao ){
			rigidbody2D.drag = 0.0f;
		}
		else if (!saltando && esta_no_chao ){
			rigidbody2D.drag = 1.0f;
		}
	}


	// Use this for initialization
	void Start () {

		this.transform.rotation = Quaternion.Euler(0, 0, 0);

		playerModelScript = (PlayerModelScript) objModelPlayer.GetComponent("PlayerModelScript");
		playerModelScript.setRotation(PlayerModelScript.TURN_RIGHT);

	}


	// Update is called once per frame
	void FixedUpdate () {

		//indo para esquerda
		if(Input.GetKey(KeyCode.LeftArrow)){

			this.transform.rotation = Quaternion.Euler(0, 180, 0);
			if(rigidbody2D.velocity.x > -maxSpeed)
				rigidbody2D.AddForce(Vector2.right * -moveForce);

		}

		//indo para direita
		else if(Input.GetKey(KeyCode.RightArrow)){

			this.transform.rotation = Quaternion.Euler(0, 0, 0);
			if(rigidbody2D.velocity.x < maxSpeed)
				rigidbody2D.AddForce(Vector2.right * moveForce);
		}


		//em idle 
		else{
			playerModelScript.setAnimation(PlayerModelScript.ANIMATION_IDLE2, 0.15f);
		}


		//pulando 
		if(Input.GetKey(KeyCode.Space) && esta_no_chao){
			pular();
		}

	}

		void Update () {

		if(rigidbody2D.velocity.x < 0){

			playerModelScript.setRotation(PlayerModelScript.TURN_LEFT);

			if(rigidbody2D.velocity.x >= ((-maxSpeed/4)*3))
				playerModelScript.setAnimation(PlayerModelScript.ANIMATION_WALK, 0.15f);
			else
				playerModelScript.setAnimation(PlayerModelScript.ANIMATION_RUN, 0.15f);

		}
		else if(rigidbody2D.velocity.x > 0 ){

			playerModelScript.setRotation(PlayerModelScript.TURN_RIGHT);

			if(rigidbody2D.velocity.x <= ((maxSpeed/4)*3))
				playerModelScript.setAnimation(PlayerModelScript.ANIMATION_WALK, 0.15f);
			else
				playerModelScript.setAnimation(PlayerModelScript.ANIMATION_RUN, 0.15f);

		}

		if(rigidbody2D.velocity.y < -1.0f && !esta_no_chao && !saltando){
			playerModelScript.setAnimation(PlayerModelScript.ANIMATION_CAI, 0.15f);
		}

		pulando();
	
		playerModelScript.setPosition(transform.position.x, transform.position.y, transform.position.z);

	}

	void OnTriggerStay2D(Collider2D other) {

		//configura variaveis para poder saltar
		if(other.name == "RockTile"){
			toqueiOChao();
		}

	}

	private void toqueiOChao(){
		esta_no_chao = true;
		saltando = false;
		//rigidbody2D.AddForce(new Vector2(0f, 0f));
	}

	void OnTriggerExit2D(Collider2D other){

		//configura variaveis para poder saltar
		//if(other.name == "RockTile"){
			esta_no_chao = false;
		//}

	}



 
}
