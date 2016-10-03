#pragma strict
// Sprites
protected    var img_offFocus : Texture;
var img_onFocus  : Texture;
var img_onClick  : Texture;

// Sons
var som_onFocus  : AudioClip;
var som_offFocus : AudioClip;
var som_onClick  : AudioClip;




// funcao do botao
var funcao :  byte ;


// Variaveis do script
var bool_MouseDown ;
var bool_mouseover ; 
var creditos : GameObject;
var creditos_shadow : GameObject;


function Start(){

	img_offFocus = guiTexture.texture;

}



function OnMouseEnter () {

	bool_mouseover = true;
	guiTexture.texture = img_onFocus;
    audio.PlayOneShot(som_onFocus);
    bool_MouseDown=false;

}

function OnMouseExit () {

	bool_mouseover = false;
	guiTexture.texture = img_offFocus;
	audio.PlayOneShot(som_offFocus);

}

function OnMouseDown () {

	guiTexture.texture = img_onClick;
	audio.PlayOneShot(som_onClick);
	bool_MouseDown=true;

}

function OnMouseUp () {

	clicou();
	bool_MouseDown=false;
	
}

protected function clicou(){

  if (bool_MouseDown && bool_mouseover)
    {
		switch (funcao){
		
			case 0: // funcao sair do jogo
				Application.Quit();  
				break;
				
			case 1: // funcao iniciar primeira fase
				audio.PlayOneShot(som_onClick);
				Application.LoadLevel("LEVEL_1");
				break;
				
			case 2: // funcao creditos
				audio.PlayOneShot(som_onClick);
				creditos.SetActive(true);
				creditos_shadow.SetActive(true);
				break;
				
			case 3: // funcao opcoes
				audio.PlayOneShot(som_onClick);
				Application.LoadLevel("sceneMenu_2");
				break;
				
			default: 
				break;
				
		}
    }
      
}