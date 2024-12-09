using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundChecker : MonoBehaviour
{
    private float range = 1.1f;
    private Vector3 offset = new Vector3(0,1f,0);
    private Animator _animator;
    void Awake()
    {
        _animator = GetComponent<Animator>();
    }
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position + offset, -transform.up);
        Debug.DrawLine(transform.position +offset, transform.position +offset - transform.up * range, Color.red);
        if(Physics.Raycast(ray, out hit, range))
        {
            if(hit.collider.gameObject.layer == 7)
           {
            Debug.Log("Walkable");
            _animator .SetBool("Grounded", true);
           } 
           else
           {
            _animator .SetBool("Grounded", false);
           }
        }
        if(Input.GetKey(KeyCode.W))
        {
            _animator.SetBool("Walking", true);
        }
        else
        {
            _animator.SetBool("Walking", false);
        }
        if(Input.GetKey(KeyCode.Space))
        {
            _animator.SetBool("Jumping", true);
        }
        else
        {
            _animator.SetBool("Jumping", false);
        }
    }
}
