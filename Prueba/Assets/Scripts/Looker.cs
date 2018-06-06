using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looker : MonoBehaviour {

    [SerializeField] Transform traget;
	
	
	void Update () {
        var diff = traget.position - transform.position;
        diff.y = 0;
        var dir = diff.normalized;

        transform.forward = dir;
	}
}
