using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;
using UnityEngine.Experimental.VFX;

public class LordOfTruth : MonoBehaviour
{

    public GameObject DiePicture;
    public GameObject Fire;

    private void Start()
    {
        Fire.GetComponent<VisualEffect>().Stop();
    }


    void OnTriggerEnter(Collider Player){
       Fire.GetComponent<VisualEffect>().Play();
        Player.GetComponent<LifeHandler>().Life = 0;
        StartCoroutine(ShowDiePicture());

    }

    private IEnumerator ShowDiePicture()
    {
        yield return new WaitForSeconds(1.5f);
        Instantiate(DiePicture);

    }
}


