using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordDamage : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Muccer")
        {
            other.GetComponent<EnemyLife>().Life = -2;
        }   
        
    }
}
