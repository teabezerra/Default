using UnityEngine;
using System.Collections;

public class BarcoController : MonoBehaviour {

	
	public float movespeed=4;
	public GameObject CamUm;
	public GameObject objPlayer;
	public GameObject areaEmbarque;
	public float curvatura;
	public int camInicial;
	public bool enableNavegar;
	public AudioClip somRemo;
	
	// Use this for initialization
	void Start () {
		
		if(camInicial==0)
			camInicial=1;

		barcoDisable();

	}
	
	// Update is called once per frame
	
	void Update () {
		//Victory

		
		//DEATH
		if(enableNavegar){

			mudarParaCameraUm();

			//MOVEMENT
			
			var esquerda = Input.GetKey(KeyCode.A);
			var direita = Input.GetKey(KeyCode.D);
			var cima = Input.GetKey(KeyCode.W);
			
			if (esquerda) 
				moveRotation( -movespeed );
			else if (direita )
				moveRotation( movespeed );		
			
			if (cima) 
				moveIncremental();


			if(esquerda || direita || cima){
				audio.clip = somRemo;
				if(!audio.isPlaying)
					audio.Play();
			}


		}

	}
	

	/*
	 * Metodo criado para movimentacao
	 */
	void moveRotation(float RotationEmY){
		
		curvatura += RotationEmY/8;
		
		if( curvatura > 360.0f )
			curvatura = 0;
		else if (curvatura < 0.0f)
			curvatura = 360.0f;
		
		transform.rotation=Quaternion.Euler(0, curvatura, 0);
		
	} 
	
	/*
	 * Metodo criado para movimentacao
	 */
	void moveIncremental(){
		
		transform.position += transform.forward * + movespeed * Time.deltaTime;
		
	}
	

	public void ativar(){
		Debug.Log("Barco Ativo");
		areaEmbarque.SetActive(true);
	}

	/*
	 * Metodo que permite ativar camera 1 via trigger com troca de mensagem
	 */
	public void mudarParaCameraUm(){
		if(CamUm) CamUm.SetActive(true);
	}
	

	public void barcoEnable(){
		enableNavegar = true;
		CamUm.SetActive(true);
		enableNavegar = true;
		rigidbody.isKinematic = false;
	}

	public void barcoDisable(){
		enableNavegar = false;
		CamUm.SetActive(false);
		enableNavegar = false;
		rigidbody.isKinematic = true;
	}

	public void embarque(){
		objPlayer.SetActive(false);
		barcoEnable();
	}

	public void desembarque(){
		objPlayer.SetActive(true);
		objPlayer.SendMessage("activePlayerSpot2");
		objPlayer.SendMessage("mudarParaCameraUm");
		barcoDisable();
		objPlayer.SetActive(true);
	}
}
