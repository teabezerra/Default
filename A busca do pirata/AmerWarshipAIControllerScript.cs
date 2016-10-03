using UnityEngine;
using System.Collections;

public class AmerWarshipAIControllerScript : MonoBehaviour {

    [SerializeField]
    Transform target1;
    [SerializeField]
    Transform target2;

    NavMeshAgent agent;

    // Use this for initialization
    void Start() {
        agent = GetComponent<NavMeshAgent>();
        agent.destination = target1.position;
    }
	
	// Update is called once per frame
	void Update () {
 
    }
}
