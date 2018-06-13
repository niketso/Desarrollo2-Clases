using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camaraRay : MonoBehaviour {

    [SerializeField] Transform target;
    [SerializeField] float range;
	
	
	void Update () {

        RaycastHit hitInfo;

        var diff = target.position - transform.position;

        Debug.DrawRay(transform.position, diff,Color.green);
        Physics.Raycast(transform.position, diff, out hitInfo, range);

        if (!hitInfo.transform.GetComponent<Transform>().CompareTag("Player"))
        {
            MeshRenderer rend = hitInfo.transform.GetComponent<MeshRenderer>();
           rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b, 0.5f);
        }


        

    }
}
