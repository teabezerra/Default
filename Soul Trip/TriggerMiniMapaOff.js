#pragma strict

function OnTriggerExit (tr : Collider)
{
	if(tr.gameObject.name == "Player")
		tr.SendMessage("desligarMinimapa");
}
