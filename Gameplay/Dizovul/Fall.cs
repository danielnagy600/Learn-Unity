using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fall : MonoBehaviour
{
    public GameObject DiePicture;


    private void OnTriggerEnter(Collider Player)
    {
        if (Player.gameObject.CompareTag("Player")) {
            Player.GetComponent<Animator>().SetBool("isFall", true);
            Instantiate(DiePicture);
        } 
        
    }

   
}
