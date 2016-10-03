#pragma strict

function OnTriggerExit (tr : Collider)
{
	if(tr.gameObject.name == "Player")
		tr.SendMessage("mudarParaCameraDois");
}

function OnTriggerEnter (tr : Collider)
{
	if(tr.gameObject.name == "Player")
		tr.SendMessage("mudarParaCameraTres");
}