#pragma strict



function OnTriggerEnter (tr : Collider)
{
		if(tr.gameObject.name == "Player")
			tr.SendMessage("morrer");
} 