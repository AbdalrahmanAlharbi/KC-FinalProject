using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemies : MonoBehaviour
{
    private NavMeshAgent nav;
    public GameObject Player;

    public void start()
    {
        nav = GetComponent<NavMeshAgent>();
        Invoke("FindTarget", 2); 
    }
    void Findtarget()
    {
        nav.destination = Player.transform.position;
    }
}
