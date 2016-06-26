#pragma strict

// Pequeno script para controle de audio de passos em diversos terrenos
// Permite alternar dinamicamente o audio clip para cada tipo de terreno
// Cria uma peguena variação de pitch, dando maior sensação de imersão de cena


var audioclip_terra: AudioClip;
var audioclip_agua: AudioClip;


function OnTriggerEnter (tr : Collider)
{

	var audioclip_temp: AudioClip;

	if(tr.gameObject.name == "Terrain"){
		
		// Variação de sonoridade
	 	audio.pitch = Random.Range(1.35f, 1.5f);
		
		// audio de passos na terra
		audioclip_temp = audioclip_terra;
		
 	}

	else if(tr.gameObject.name == "water"){ // Caso a 
		
		// Variação de sonoridade
		audio.pitch = Random.Range(0.7f, 0.8f);

		// audio de passos na agua
	 	audioclip_temp = audioclip_agua;
		
 	}
 	
	// tocar audio
	audio.PlayOneShot(audioclip_temp);
	
}

