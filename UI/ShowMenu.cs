using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ShowMenu : MonoBehaviour
{
    public GameObject Menu;
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Escape)) 
        { 
                Instantiate(Menu);
        }
    }
}
