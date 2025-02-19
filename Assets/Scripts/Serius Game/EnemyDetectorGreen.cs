using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDetectorGreen : MonoBehaviour
{
public bool enemyInGreen;
void OnTriggerEnter (Collider other)
{
    bool enemyInGreen = true;
}

}
