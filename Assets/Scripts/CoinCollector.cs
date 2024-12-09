using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CoinCollector : MonoBehaviour
{
    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.TryGetComponent<ICollectable>(out ICollectable icoll))
            icoll.OnCollected();    
    }
}