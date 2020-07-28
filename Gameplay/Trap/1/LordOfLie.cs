using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LordOfLie : MonoBehaviour
{
    public GameObject DiePicture;
    public GameObject Stone;


    void OnTriggerEnter(Collider Player)
    {
      Stone.GetComponent<Rigidbody>().useGravity = true;
      Player.GetComponent<LifeHandler>().Life = 0;
      StartCoroutine(ShowDiePicture());
    }


    private IEnumerator ShowDiePicture()
    {
        yield return new WaitForSeconds(1);
        Instantiate(DiePicture);
    }

}
