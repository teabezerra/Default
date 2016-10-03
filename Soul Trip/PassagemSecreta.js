#pragma strict

var item1: GameObject;
var item2: GameObject;
var som_coruja : AudioClip;

function Start () {
	audio.PlayOneShot(som_coruja);
}

function Update () {

	if(!item1 && !item2){
		Destroy(this);	
	}

}

function OnTriggerEnter (tr : Collider)
{
		if(item1 || item2){
			audio.clip = som_coruja;
				if(!audio.isPlaying)
					audio.Play();
		}
} 