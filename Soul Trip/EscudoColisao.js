#pragma strict
@script RequireComponent(AudioSource) 


var escudo_som : AudioClip;


function Start(){
	
	//Debug.Log("FOI");
}


/*
function OnCollisionEnter (aColisao : Collision) {

Debug.Log("FOI1");

	if(aColisao.gameObject.name == "plane")
	{
		Debug.Log("FOI2");audio.PlayOneShot(som);
	}
}
*/


function OnTriggerEnter (tr : Collider)
{

	var float_pitch = Random.Range(0.2f, 0.3f);

 	audio.pitch = float_pitch;

	if(!audio.isPlaying)
 		audio.PlayOneShot(escudo_som);
 	
 	//if(tr.gameObject.name == "Cube")
 	//	tr.SendMessage("danoDeEspada");

}

