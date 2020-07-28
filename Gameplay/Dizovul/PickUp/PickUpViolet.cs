using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpViolet : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            gameObject.SetActive(false);
            other.GetComponent<LifeHandler>().Life=4;
        } 

    }
}
