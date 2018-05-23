using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestAnimation : MonoBehaviour {
    private Rigidbody rb;
    private Animator anim;
    [SerializeField] float maxSpeed;



    private void Awake()
    {
        anim = GetComponent<Animator>();
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


   
    void FixedUpdate()
    {
        rb.velocity = transform.forward * Input.GetAxis(" Vertical") * maxSpeed;
        
        
        

            
    }
}
