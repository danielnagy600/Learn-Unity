using System.Collections;
using UnityEngine;

public class CanvasController : MonoBehaviour
{
    public GameObject startPicture;

    void Start()
    {
        startPicture = GameObject.Find("StartInfoCanvasDialog");
        StartCoroutine(StartInfo());    
    }

    private IEnumerator  StartInfo()
    {
        yield return new WaitForSeconds(5);
        startPicture.SetActive(false);
    }
}
