using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitClaw : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            FindObjectOfType<LifeHandler>().Life = -1;
            Debug.Log("Megkarmolt");
        }
    }
}
