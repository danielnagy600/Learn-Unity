using UnityEngine;

public class InfoTest2 : MonoBehaviour 
{ 
    public GameObject SecondTrap;
    private GameObject cloneSecondTrap;

    private void OnTriggerEnter(Collider other)
    {
         cloneSecondTrap = Instantiate(SecondTrap);
    }

    private void OnTriggerExit(Collider other)
    {
        Destroy(cloneSecondTrap);
    }
}
