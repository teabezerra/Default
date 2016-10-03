#pragma strict


var passos_terra: AudioClip;
var passos_agua: AudioClip;


function OnTriggerEnter (tr : Collider)
{

	var float_pitch;

	if(tr.gameObject.name == "Terrain"){
		float_pitch = Random.Range(1.35f, 1.5f);
	 	audio.pitch = float_pitch;
	 	audio.volume = 0.1f;
	 	audio.PlayOneShot(passos_terra);
 	}

	else if(tr.gameObject.name == "water"){
		float_pitch = Random.Range(0.7f, 0.8f);
	 	audio.pitch = float_pitch;
	 	audio.volume = 0.1f;
	 	audio.PlayOneShot(passos_agua);
 	}
 	
}

