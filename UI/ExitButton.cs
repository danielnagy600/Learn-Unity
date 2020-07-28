public class ExitButton : MyButton
{
    protected override void Click(){
        NavigationManager.Exit();
    }
}
