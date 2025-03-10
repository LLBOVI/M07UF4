using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmotionChooser : MonoBehaviour
{
    public int currentPerson;
    public Animator animator;
    private void OnEnable() {
        Person.SetEmotion += CheckFeeling ;
    }
    private void OnDisable() {
                Person.SetEmotion -= CheckFeeling;

    }
    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Player")
        {
        currentPerson = other.GetComponent<Person>().sentiment.num;
        animator = other.GetComponent<Animator>();
        }

    }
    private void OnTriggerExit(Collider other) {
        currentPerson=7;
        animator = null;
    }

    public void CheckFeeling(int num)
    {
        Debug.Log(num);
        Debug.Log(currentPerson);

        if(num == currentPerson&& animator != null)
        {

            animator.SetBool("IsDead", true);
            animator.gameObject.GetComponent<Collider>().enabled = false;
            Destroy(animator.gameObject, 1f);
        }
    }
}
