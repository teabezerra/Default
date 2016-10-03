#pragma strict

// Variaveis do script
var bool_MouseDown ;
var bool_mouseover ; 
var creditos : GameObject;


function Start(){
	
}
function Update(){
	if(!creditos.active)
		transform.active = false;
		}

function OnMouseEnter () {
	
}

function OnMouseExit () {
	
}

function OnMouseDown () {

	bool_MouseDown=true;
	
}

function OnMouseUp () {
	creditos.SetActive(false);
}