using UnityEngine;
using System.Collections;

public class HUDGame : MonoBehaviour {

	
	private bool falarNPC;
	
	// background image that is 256 x 32
	public Texture2D bgImage; 
	
	// foreground image that is 256 x 32
	public Texture2D fgImage; 

	// background image that is 256 x 32
	public Texture2D bgMessageImage; 

	private bool boolMensagemObulo;
	private bool boolMensagemArma;
	private bool falarNPCBloqueio;
	private bool boolMenssagemPagar;
	private bool boolMenssagemCaronteDerrotado;

	public GameObject player;

	void Start () {

		falarNPC = false;
		falarNPCBloqueio = false;
		boolMensagemObulo = false;
		boolMensagemArma = false;
		boolMenssagemPagar = false;
		boolMenssagemCaronteDerrotado = false;
		
	}

	
	void OnGUI () {

		lifebar();

		MyPlayerController AI = (MyPlayerController)player.transform.GetComponent("MyPlayerController");

		if(boolMenssagemPagar){ 
			MensagemPagarCaronte();
		}
		else if(falarNPC && !falarNPCBloqueio){ 
			falarComNPC();
		}

		if(boolMensagemArma){ 
			MensagemArmas();
		}
		
		if(boolMensagemObulo){ 
			MensagemObulos();
		}

		if(boolMenssagemCaronteDerrotado)
			MensagemCaronteDerrotado();

		
	}

	public void npcOn(){
			falarNPC = true;
	}

	public void mensagemArmaOn(){
		boolMensagemArma = true;
	}

	public void mensagemPagarOn(){
		boolMenssagemPagar = true;
	}

	public void mensagemObuloOn(){
		boolMensagemObulo = true;
	}

	public void mensagemCaronteDerrotadoOn(){
		boolMenssagemCaronteDerrotado = true;
	}
	
	public void npcOff(){
		falarNPC = false;
	}

	private void falarComNPC(){

		int larguraWindow = 350;
		int alturaWindow = 200;

		int larguraBotao = 120;
		int alturaBotao = 26;

		GUI.BeginGroup (new Rect (Screen.width / 2 - larguraWindow/2, Screen.height / 2 - alturaWindow/2, larguraWindow, alturaWindow));

		GUI.Box (new Rect (-larguraWindow,-alturaWindow,larguraWindow*3,alturaWindow*3) , bgMessageImage);


		GUI.BeginGroup (new Rect (0,0,larguraWindow,alturaWindow));


		GUI.Box(new Rect (0, 0, larguraWindow, alturaWindow), "\nNinguém atravessa o rio Aqueronte sem pagar Caronte!\n\n\n Missão 1\nEncontre 3 óbulos e pague a travessia.\n\n Missão 2\nEncontrar armas para lutar contra Caronte.");
		//GUI.Box(new Rect (Screen.width / 2 - largura/2, Screen.heighte/ 2 - altura/2, largura, altura),"Congratulations!  You have defeated all the Evil Skellies!");

		if(GUI.Button(new Rect(larguraWindow/2 -  larguraBotao/2, alturaWindow - alturaBotao-10, larguraBotao, alturaBotao), "Continuar"))falarNPC=false;

		GUI.EndGroup ();

		GUI.EndGroup ();
	}

	private void MensagemArmas(){
		
		int larguraWindow = 260;
		int alturaWindow = 150;
		
		int larguraBotao = 120;
		int alturaBotao = 26;
		
		GUI.BeginGroup (new Rect (Screen.width / 2 - larguraWindow/2, Screen.height / 2 - alturaWindow/2, larguraWindow, alturaWindow));
		
		GUI.Box (new Rect (-larguraWindow,-alturaWindow,larguraWindow*3,alturaWindow*3) , bgMessageImage);
		
		
		GUI.BeginGroup (new Rect (0,0,larguraWindow,alturaWindow));
		
		
		GUI.Box(new Rect (0, 0, larguraWindow, alturaWindow), "\nVocê encontrou as armas secretas!\n\nDefesa x3\nAtaque x3");

		if(GUI.Button(new Rect(larguraWindow/2 -  larguraBotao/2, alturaWindow - alturaBotao-10, larguraBotao, alturaBotao), "Continuar"))boolMensagemArma=false;
		
		GUI.EndGroup ();
		
		GUI.EndGroup ();

	}
	
	private void MensagemObulos(){
		
		int larguraWindow = 260;
		int alturaWindow = 150;
		
		int larguraBotao = 120;
		int alturaBotao = 26;
		
		GUI.BeginGroup (new Rect (Screen.width / 2 - larguraWindow/2, Screen.height / 2 - alturaWindow/2, larguraWindow, alturaWindow));
		
		GUI.Box (new Rect (-larguraWindow,-alturaWindow,larguraWindow*3,alturaWindow*3) , bgMessageImage);
		
		
		GUI.BeginGroup (new Rect (0,0,larguraWindow,alturaWindow));
		
		
		GUI.Box(new Rect (0, 0, larguraWindow, alturaWindow), "\nVocê encontrou um óbulo.");

		if(GUI.Button(new Rect(larguraWindow/2 -  larguraBotao/2, alturaWindow - alturaBotao-10, larguraBotao, alturaBotao), "Continuar"))boolMensagemObulo=false;
		
		GUI.EndGroup ();
		
		GUI.EndGroup ();
		
	}

	private void MensagemPagarCaronte(){
		
		int larguraWindow = 260;
		int alturaWindow = 150;
		
		int larguraBotao = 180;
		int alturaBotao = 26;
		
		GUI.BeginGroup (new Rect (Screen.width / 2 - larguraWindow/2, Screen.height / 2 - alturaWindow/2, larguraWindow, alturaWindow));
		
		GUI.Box (new Rect (-larguraWindow,-alturaWindow,larguraWindow*3,alturaWindow*3) , bgMessageImage);
		
		
		GUI.BeginGroup (new Rect (0,0,larguraWindow,alturaWindow));
		
		
		GUI.Box(new Rect (0, 0, larguraWindow, alturaWindow), "\nObrigado pelo pagamento\n\nMeu barco está a sua disposição.\n\nChegue proximo ao barco para embarcar.");
		
		if(GUI.Button(new Rect(larguraWindow/2 -  larguraBotao/2, alturaWindow - alturaBotao-10, larguraBotao, alturaBotao), "Continuar")){
			boolMenssagemPagar=false;
			falarNPCBloqueio=true;
		}

		GUI.EndGroup ();
		
		GUI.EndGroup ();
		
	}

	private void MensagemCaronteDerrotado(){
		
		int larguraWindow = 260;
		int alturaWindow = 150;
		
		int larguraBotao = 180;
		int alturaBotao = 26;
		
		GUI.BeginGroup (new Rect (Screen.width / 2 - larguraWindow/2, Screen.height / 2 - alturaWindow/2, larguraWindow, alturaWindow));
		
		GUI.Box (new Rect (-larguraWindow,-alturaWindow,larguraWindow*3,alturaWindow*3) , bgMessageImage);
		
		
		GUI.BeginGroup (new Rect (0,0,larguraWindow,alturaWindow));
		
		
		GUI.Box(new Rect (0, 0, larguraWindow, alturaWindow), "\n\nVoce ganhou o barco do Caronte.\n\nChegue proximo ao barco para embarcar.");
		
		if(GUI.Button(new Rect(larguraWindow/2 -  larguraBotao/2, alturaWindow - alturaBotao-10, larguraBotao, alturaBotao), "Continuar")){
			boolMenssagemCaronteDerrotado=false;
			falarNPCBloqueio=true;
		}
		
		GUI.EndGroup ();
		
		GUI.EndGroup ();
		
	}

	private void lifebar(){

		Health HP = (Health)player.transform.GetComponent("Health");
		MyPlayerController AI = (MyPlayerController)player.transform.GetComponent("MyPlayerController"); 


		int vida_atual_porcento = (int)(HP.CurrentHealth * 100 / HP.MaxHealth);
		int defesa = (int)(AI.Damage);
		int ataque = (int)(HP.Defesa);
		int larguraWindow = 100;
		int alturaWindow = 30;

		
		GUI.BeginGroup (new Rect (10, 5, larguraWindow, alturaWindow));
		
			GUI.Box (new Rect (-larguraWindow,-alturaWindow,larguraWindow*3,alturaWindow*3) , bgMessageImage);

			GUI.BeginGroup (new Rect (0,0,larguraWindow,alturaWindow));

		        GUI.Box(new Rect (0, 0, larguraWindow, alturaWindow),  "Life "+vida_atual_porcento+"%");

			GUI.EndGroup ();
		
		GUI.EndGroup ();


		GUI.BeginGroup (new Rect (10, 38, larguraWindow, alturaWindow));
		
			GUI.Box (new Rect (-larguraWindow,-alturaWindow,larguraWindow*3,alturaWindow*3) , bgMessageImage);
			
			GUI.BeginGroup (new Rect (0,0,larguraWindow,alturaWindow));
			
		    GUI.Box(new Rect (0, 0, larguraWindow, alturaWindow),  "Ataque "+ataque+"%");
			
			GUI.EndGroup ();
		
		GUI.EndGroup ();


		GUI.BeginGroup (new Rect (10, 72, larguraWindow, alturaWindow));
		
			GUI.Box (new Rect (-larguraWindow,-alturaWindow,larguraWindow*3,alturaWindow*3) , bgMessageImage);
			
			GUI.BeginGroup (new Rect (0,0,larguraWindow,alturaWindow));
			
			GUI.Box(new Rect (0, 0, larguraWindow, alturaWindow),  "Defesa "+defesa+"%");
			
			GUI.EndGroup ();
		
		GUI.EndGroup ();
		
		


	}

}
