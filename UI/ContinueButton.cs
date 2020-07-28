using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ContinueButton : MyButton
{
    protected override void Click()
    {
        NavigationManager.ContinuePlay();
        Cursor.visible = false;
    }
}
