using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButton : MyButton 
{
    public GameObject Contorller;

    protected  override void Click()
    {
        Contorller.GetComponent<SettingsController>().SaveSettings();
        FindObjectOfType<SettingsController>().SetCurrentLanguage();
        NavigationManager.Back();
    }
}
