using UnityEngine;

public class DontDestroy : MonoBehaviour
{
    public GameObject _backgroundMusic;
    public GameObject _NavigationManager;
    public GameObject _settingsManager; 

    public void Awake()
    {
        DontDestroyOnLoad(_backgroundMusic);
        DontDestroyOnLoad(_NavigationManager);
        DontDestroyOnLoad(_settingsManager);
    }
    public void Start()
    {
        GameObject[] _tmpMusic = GameObject.FindGameObjectsWithTag("BackgroundMusic");
        if (_tmpMusic.Length > 1)
        {
            Destroy(_backgroundMusic);
            Destroy(_NavigationManager);
            Destroy(_settingsManager);
        }
    }
}
