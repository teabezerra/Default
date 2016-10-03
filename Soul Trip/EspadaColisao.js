#pragma strict


var espada_som : AudioClip;

function Start(){
	audio.clip = espada_som;
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

    if(tr.gameObject.name == "alma"){
 		if ( !audio.isPlaying ) {
	 		var float_pitch = Random.Range(0.75f, 1.6f);
	 		audio.pitch = float_pitch;
	 		audio.Play();
 		}
 	}

}

