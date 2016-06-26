using UnityEngine;
using System.Collections;

// Pequeno script para controle de audio de passos em diversos terrenos
// Permite alternar dinamicamente o audio clip para cada tipo de terreno
// Cria uma pequena variação de pitch, dando maior sensação de imersão de cena
// A Vantagem da utilização deste método é o maior realismo pois o som nunca será exatamente o mesmo e só sera disparado no contato do solo com o pé do personagem. O que elimina problema de sincronismo com a velocidade da animação.
// A desvantagem é o maior consumo de processamento.


public class AdaptiveWalkSound : MonoBehaviour {

    [SerializeField]
    AudioClip audioclip_terra;          // AudioClip de passos na terra

    [SerializeField]
    AudioClip audioclip_agua;           // AudioClip de passos na água

    private AudioClip audioclip_temp;   // AudioClip usado para referenciar o audio que sera tocado no momento.
    private AudioSource _AudioSource;   // Referencia do audio source do objeto que receberá o script


    // Use this for initialization
    void Start()
    {

        //Instanciando
        audioclip_temp = null;

        // Capturando a referencia do AudioSource do objeto, evitando chamadas 
        _AudioSource = GetComponent<AudioSource>();

    }

    void OnTriggerEnter(Collider tr)
    {

        if (tr.gameObject.name == "Terrain")
        {

            // Variação de sonoridade
            _AudioSource.pitch = Random.Range(1.35f, 1.5f);

            // audio de passos na terra
            audioclip_temp = audioclip_terra;

        }

        else if (tr.gameObject.name == "water")
        { // Caso a 

            // Variação de sonoridade
            _AudioSource.pitch = Random.Range(0.7f, 0.8f);

            // audio de passos na agua
            audioclip_temp = audioclip_agua;

        }

        // tocar audio
        _AudioSource.PlayOneShot(audioclip_temp);

    }

}
