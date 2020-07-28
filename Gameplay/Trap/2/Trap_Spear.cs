using System.Collections;
using UnityEngine;

public class Trap_Spear : MonoBehaviour
{
    public GameObject DiePicture;

    private void OnTriggerEnter(Collider somebody)
    {
        if(somebody.CompareTag("Player"))
        {
            somebody.GetComponent<Animator>().SetBool("isDying", true);
            somebody.GetComponent<LifeHandler>().Life = 0;
            StartCoroutine(Die());
        }
    }

    IEnumerator Die()
    {
        yield return new WaitForSeconds(2.5f);
        Instantiate(DiePicture);
    }

}
