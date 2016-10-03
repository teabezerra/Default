using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CamMoveToTarget : MonoBehaviour {



	public GameObject obj_target;
	public GameObject cam;
	public float zoom;

	public float dampTime = 0.15f;
	private Vector3 velocity = Vector3.zero;
	private Transform target;

	// Use this for initialization
	void Start () {
		target = obj_target.GetComponent<Transform>();
	}
	
	// Update is called once per frame
	void Update (){

		//cam.transform.position = new Vector3(target.transform.position.x,target.transform.position.y+0.75f,target.transform.position.z-(-1*zoom));

		if (target)
		{
			Vector3 point = camera.WorldToViewportPoint(target.position);
			Vector3 delta = target.position - camera.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, point.z)); //(new Vector3(0.5, 0.5, point.z));
			Vector3 destination = transform.position + delta;
			transform.position = Vector3.SmoothDamp(transform.position, destination, ref velocity, dampTime);
			transform.position = new Vector3(transform.position.x,target.transform.position.y + 0.75f, target.transform.position.z - (-1*zoom));
		}
	}
}
