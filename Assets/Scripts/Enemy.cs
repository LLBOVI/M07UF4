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
        transform.position = new Vector3(Random.Range(-100, 100),1,Random.Range(-50, 100));
        emocion = Random.Range(1, 6);
        
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
        {
        if (targetPosition != null)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
        }
    }
    }
}