using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CancelButton : MyButton
{
    protected override void Click()
    {
        NavigationManager.Back();
    }
}
