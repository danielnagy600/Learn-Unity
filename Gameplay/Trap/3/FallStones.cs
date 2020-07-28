using UnityEngine;

public class FallStones : MonoBehaviour
{
    private void OnTriggerEnter(Collider Something)
    {
            if (Something.gameObject.CompareTag("Player"))
        {
            Something.GetComponent<Animator>().SetBool("isFall", true);
            GetComponent<Rigidbody>().useGravity = true;
        }
    }
}
