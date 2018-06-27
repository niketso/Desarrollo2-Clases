using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class navEjemplo : MonoBehaviour {

    [SerializeField] Transform target;
    [SerializeField] Transform ori;
    private NavMeshAgent navEje;


    private void Awake()
    {
        navEje = GetComponent<NavMeshAgent>();
        navEje.SetDestination(target.position);
    }
    private void Update()
    {
        if (!navEje.pathPending && navEje.remainingDistance < navEje.stoppingDistance)
        {


        }
    }
}
