using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitSword : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Muccer")
        {
            Debug.Log("Muegutottem a szornyet.");
            FindObjectOfType<EnemyLife>().Life =2;
        }
    }
}
