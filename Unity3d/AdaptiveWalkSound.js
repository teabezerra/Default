#pragma strict

// Script para controle de audio de passos em diversos terrenos
//
// Permite alternar dinamicamente o audio clip para cada tipo de terreno
// Cria uma pequena variação de pitch, dando maior sensação de imersão de cena
// A Vantagem da utilização deste método é o maior realismo pois o som nunca será exatamente o mesmo e só sera disparado no contato do solo com o pé do personagem. O que elimina problema de sincronismo com a velocidade da animação.
// A desvantagem é o maior consumo de processamento.

var audioclip_terra : AudioClip; //Audio clip de passos na terra
var audioclip_agua : AudioClip; //Audio clip de passos na água


function OnTriggerEnter (tr : Collider)
{

    var audioclip_temp: AudioClip;
    var _AudioSource: AudioSource;
    _AudioSource = GetComponent.<AudioSource>();

	if(tr.gameObject.name == "Terrain"){
		
		// Variação de sonoridade
	    _AudioSource.pitch = Random.Range(1.35f, 1.5f);
		
		// audio de passos na terra
		audioclip_temp = audioclip_terra;
		
 	}

	else if(tr.gameObject.name == "water"){ // Caso a 
		
		// Variação de sonoridade
	    _AudioSource.pitch = Random.Range(0.7f, 0.8f);

		// audio de passos na agua
	 	audioclip_temp = audioclip_agua;
		
 	}
 	
	// tocar audio
	_AudioSource.PlayOneShot(audioclip_temp);
	
}

