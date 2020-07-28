using UnityEngine;

public class PickUpSnowdrop : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) {
            gameObject.SetActive(false);
            other.GetComponent<LifeHandler>().Life=3;
        } 
    }
}
