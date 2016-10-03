using UnityEngine;
using System.Collections;

public class ControladorCaronte : MonoBehaviour {

	public GameObject objCaronteNPC;
	public GameObject objCaronteBriga;
	public GameObject objBarco;
	public GameObject objPlayer;
	private bool validaAtivaCaronte;
	private MyPlayerController scriptPlayerController;
	private MyAI scriptAICaronte ;
	private bool boolValidaMorte;

	// Use this for initialization
	void Start () {

		objCaronteNPC.SetActive(true);
		objCaronteBriga.SetActive(false);
		validaAtivaCaronte = true;
		scriptPlayerController = (MyPlayerController) objPlayer.transform.GetComponent("MyPlayerController");
		scriptAICaronte = (MyAI) objCaronteBriga.transform.GetComponent("MyAI");
		boolValidaMorte = true;
	}

	void Update(){

		scriptAICaronte = (MyAI) objCaronteBriga.transform.GetComponent("MyAI");

		if(boolValidaMorte){
			if(scriptAICaronte.IsDead){
				objPlayer.SendMessage("mensagemCaronteDerrotadoOn");
				objBarco.SendMessage("ativar");
				boolValidaMorte = false;
			}
		}
	}
	
	// Update is called once per frame
	void OnTriggerEnter(Collider other) {

		if(other.gameObject.name.Equals("Player")){

			if(validaAtivaCaronte){
			
				scriptPlayerController = (MyPlayerController) objPlayer.transform.GetComponent("MyPlayerController");

				if( scriptPlayerController.boolArmado ){

					objCaronteNPC.SetActive(false);
					objCaronteBriga.SetActive(true);
				
					validaAtivaCaronte = false;

				}
				else if(scriptPlayerController.obulos == 3){
						
					HUDGame hud = (HUDGame) objPlayer.transform.GetComponent("HUDGame");
					
					hud.SendMessage("mensagemPagarOn");

					objBarco.SendMessage("ativar");
					
					validaAtivaCaronte = false;
					
				}



			}

		}

	}
}
