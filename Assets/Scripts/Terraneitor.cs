using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class Terraneitor : MonoBehaviour
{
    public NavMeshAgent enemy;
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(player.position);
        
        Vector3 targetDestination = player.position - transform.position;
        Debug.DrawRay(transform.position, targetDestination, Color.red);

        //transform.rotation = Quaternion.LookRotation(targetDestination);

    }
}

