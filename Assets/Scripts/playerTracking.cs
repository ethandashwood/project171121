using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class playerTracking : MonoBehaviour
{

    public Transform playerTrack;
    

    private NavMeshAgent navi;
    private int dest;

    void Start()
    {
        navi = GetComponent<NavMeshAgent>();
    }


    void Update()
    {

        if (!navi.pathPending && navi.remainingDistance < 0.5f)
            GoToNextPoint();

    }

    void GoToNextPoint()
    {


        navi.destination = playerTrack.position;
 

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Destroy(other.gameObject);

        }


    }
}