using UnityEngine;
using System.Collections;

public class shipSript : MonoBehaviour {

    [SerializeField]
    Transform _CeterOfMass;


	// Use this for initialization
	void Start () {

        GetComponent<Rigidbody>().centerOfMass = _CeterOfMass.position;

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
