using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ray : MonoBehaviour {

    [SerializeField] float range;
    [SerializeField] GameObject ps;

	void Update () {
        Debug.DrawRay(transform.position, transform.forward * range,Color.green);
        RaycastHit hitInfo;
        if(Input.GetButtonDown ("Fire1"))
        {
            if (Physics.Raycast(transform.position, transform.forward, out hitInfo, range))
               {
                    Instantiate(ps, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));
               }

        }
            

	}
}
