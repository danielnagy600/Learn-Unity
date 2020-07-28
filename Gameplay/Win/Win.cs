using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour
{
    public GameObject Muccer;
    public GameObject Victory;
    
    private void OnTriggerEnter(Collider other)
    {
        if (Muccer.GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).IsName("Die"))
        {
            Instantiate(Victory);
        }
    }

}
