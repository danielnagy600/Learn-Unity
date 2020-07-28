using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public Transform TeleportTarget;
    public GameObject Level2Picture;
    private GameObject cloneLevel2Picture;


    void OnTriggerEnter(Collider Player)
    {
        cloneLevel2Picture = Instantiate(Level2Picture);
        StartCoroutine(ShowLevel2Picture());
        Player.transform.position = TeleportTarget.transform.position;
        
    }

    private IEnumerator ShowLevel2Picture()
    {
        yield return new WaitForSeconds(1.2f);
        Destroy(cloneLevel2Picture);
    }
}
