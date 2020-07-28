using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsSoundButton : MyButton
{
    public SwitchPanelActivator PanelActivator;

    protected override void Click(){
        PanelActivator.Activate(gameObject.GetComponent<MyButton>());
    }
}
