using UnityEngine;
using System.Collections;

public class AreaDesembarqueScript : MonoBehaviour {

	public GameObject barco;
	
	public void OnTriggerEnter (Collider tr)
	{	    
		if(tr.gameObject == barco){
			barco.SendMessage("desembarque");
		}
	}

}
