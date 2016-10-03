#pragma strict

function OnTriggerExit (tr : Collider)
{
	if(tr.gameObject.name == "Player")
		tr.SendMessage("npcOff");
}

function OnTriggerEnter (tr : Collider)
{	    
	if(tr.gameObject.name == "Player"){
		tr.SendMessage("npcOn");
	}
}