using UnityEngine;
using System.Collections;

public class AmerWarshipControllerScript : MonoBehaviour {

    [SerializeField]
    Transform target;

    [SerializeField]
    Camera cam;

    NavMeshAgent agent;

    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();
       // cam = Camera.main;
        //agent.destination = transform.position+Vector3.forward*2;
    }
	
	// Update is called once per frame
	void Update () {

        if (agent != null)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;// = camera.ScreenPointToRay(Input.mousePosition);

                if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, 500))

                {
                    print(hit.point);
                    agent.destination = hit.point;

                }

            }
        }

    }


/*
    float shootforce = 0f;
    float time_start = 0f;
    float time_stop = 0f;

    void FixedUpdate()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            print("fire");
            time_start = Time.time;
        }

        if (Input.GetKeyUp (KeyCode.A))
        {
            time_stop = Time.time;
            shootforce = time_stop - time_start;
            print("Now: "+ shootforce);
        }

        Mathf.Clamp(shootforce, 0, 1);

    }
    */


     void OnTriggerEnter(Collider other)
    {

        print(other.gameObject.tag); 
        if (other.gameObject.CompareTag("Inimigo"))
        {
            Application.LoadLevel(2);
        }

    }


}
