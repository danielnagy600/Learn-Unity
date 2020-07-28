using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotoMenulButton : MyButton
{
    protected  override void Click()
    {
        NavigationManager.GotoMenu();
    }
}
