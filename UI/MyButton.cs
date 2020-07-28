using UnityEngine;
using UnityEngine.UI;


public abstract class MyButton : MonoBehaviour {
    private Button _button;
    protected NavigationController NavigationManager;

    private void Awake() 
    {
        _button = GetComponent<Button>();
        NavigationManager = FindObjectOfType<NavigationController>();
    }

    private void Start() 
    {
        _button.onClick.AddListener(Click);
    }

    private void OnDestroy()
    {
        _button.onClick.RemoveListener(Click);
    }
    protected abstract  void Click();
}
