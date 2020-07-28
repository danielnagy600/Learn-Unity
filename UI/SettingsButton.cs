using UnityEngine;

public class SettingsButton : MyButton
{
    protected  override void Click()
    {
        NavigationManager.ShowSettings();
    }
}
