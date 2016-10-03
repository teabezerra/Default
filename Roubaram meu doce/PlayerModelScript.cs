using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerModelScript : MonoBehaviour {

	//Referencia do modelo
	public  GameObject modelo;

	//Animacoes do modelo player
	public AnimationClip[] VET_ANIMATION = new AnimationClip[10];

	//Estados das animacoes do modelo player 
	public static int ANIMATION_IDLE           = 0;
	public static int ANIMATION_IDLE2          = 1;
	public static int ANIMATION_WALK           = 2;
	public static int ANIMATION_RUN            = 3;
	public static int ANIMATION_JUMP           = 4;
	public static int ANIMATION_ATACK_PREPARA  = 5;
	public static int ANIMATION_ATACK          = 6;
	public static int ANIMATION_ATACK_CORRENDO = 7;
	public static int ANIMATION_DANO           = 8;
	public static int ANIMATION_MORRE          = 9;
	public static int ANIMATION_CAI            = 10;
	
	private static int ANIMATION_ATUAL;
	private static float ANIMATION_ATUAL_TIME;


	//Rotacoes do modelo player
	public static int TURN_LEFT       = 255;
	public static int TURN_RIGHT      = 105;
	private int ROTATION;

	// Use this for initialization
	void Start () {

		ROTATION = TURN_RIGHT;
		ANIMATION_ATUAL_TIME = 0.15f;
		ANIMATION_ATUAL = ANIMATION_IDLE;

		if(modelo!=null)
			setPosition(0,0,0);

	}
	
	// Update is called once per frame
	void Update () {
		if(VET_ANIMATION[ANIMATION_ATUAL]!=null)
			animation.CrossFade( VET_ANIMATION[ANIMATION_ATUAL].name, ANIMATION_ATUAL_TIME);
	}
	
	public void setRotation(int rotation){

		this.ROTATION = rotation;

		//Altera a orientacao (rotacao) do modelo do personagem 
		if(modelo!=null)
			modelo.transform.rotation = Quaternion.Euler(0, ROTATION, 0);

	}

	public void setPosition(float x,float y,float z){

		if(modelo!=null)
			modelo.transform.position = new Vector3(x,y-0.5f,z);

	}

	public void setAnimation(int animation, float time){
		ANIMATION_ATUAL = animation;
		ANIMATION_ATUAL_TIME = time;
	}

}
