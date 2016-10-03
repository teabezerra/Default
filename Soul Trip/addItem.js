#pragma strict

var nomeDoItem: String;
var item: GameObject;

private var jaColediu = false;

function OnTriggerEnter (tr : Collider)
{
	if(tr.gameObject.name == "Player" && !jaColediu){
	 	jaColediu = true;
	 	tr.SendMessage("addItem",nomeDoItem);
	 	Destroy(item);
 	}
} 