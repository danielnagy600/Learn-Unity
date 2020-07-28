using UnityEngine;

public class InfoTest1 : MonoBehaviour
{
    public GameObject FirstTrap;
    private GameObject cloneFirstTrapInfo;

    private void OnTriggerEnter(Collider other)
    {
         cloneFirstTrapInfo = Instantiate(FirstTrap);
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(cloneFirstTrapInfo);
    }
}
