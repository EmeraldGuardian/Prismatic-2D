using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLaserGateScript : MonoBehaviour
{
    BoxCollider2D m_Collider;
    private Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        //Fetch the GameObject's Collider (make sure it has a Collider component)
        m_Collider = GetComponent<BoxCollider2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void turnOff()
    {
        animator.Play("green_gate_disabled");
        m_Collider.enabled = false;
    }
}
