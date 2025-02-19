using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Animator animator;
    public int emocion; // 1 indiferencia, 2 alegria, 3 tristeza, 4 confusion, 5 enfado, 6 miedo

    public GameObject indiferencia;
    public GameObject alegría;
    public GameObject tristeza;
    public GameObject confusión;
    public GameObject enfado;
    public GameObject miedo; 
    
    public Transform targetPosition;
    public float speed = 10f;

    void Start()
    { 
        transform.position = new Vector3(Random.Range(-100, 100),0,Random.Range(-50, 100));
        emocion = Random.Range(1, 6);
        gameObject.tag = "Enemy_" + emocion;
        
        if(emocion == 1)
        {
            speed = 10f;
            indiferencia.SetActive(true);
            animator.SetLayerWeight(emocion, 1);
        }
       
        else if(emocion == 2)
        {
            speed = 15f;
            alegría.SetActive(true);
            animator.SetLayerWeight(emocion, 1);
        }
        
        else if(emocion == 3)
        {
            speed = 5f;
            tristeza.SetActive(true);
            animator.SetLayerWeight(emocion, 1);
        }
        
        else if(emocion == 4)
        {
            speed = 5f;
            confusión.SetActive(true);
            animator.SetLayerWeight(emocion, 1);
        }
        
        else if(emocion == 5)
        {
            speed = 20f;
            enfado.SetActive(true);
            animator.SetLayerWeight(emocion, 1);
        }
        
        else
        {
            speed = 10f;
            miedo.SetActive(true);
            animator.SetLayerWeight(emocion, 1);
        }

    }
    void Update() 
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
        Vector3 direction = (targetPosition.position - transform.position).normalized;
        Quaternion lookRotation = Quaternion.LookRotation(new Vector3(direction.x, 0, direction.z));
        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, Time.deltaTime * speed);
    }

}