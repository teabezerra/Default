using UnityEngine;
using System.Collections;

public class AreaEmbarqueScript : MonoBehaviour {

	public GameObject barco;

	public void OnTriggerEnter (Collider tr)
	{	    
		if(tr.gameObject.name == "Player"){
			barco.SendMessage("embarque");
		}
	}

}
