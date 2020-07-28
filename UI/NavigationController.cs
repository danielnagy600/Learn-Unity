using UnityEngine;
using UnityEngine.SceneManagement;


public class NavigationController : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Loading1");
        SceneManager.LoadSceneAsync("Game");

    }

    public void ShowSettings()
    {
        SceneManager.LoadSceneAsync("Settings");
    }

    public void Back(){
        if (SceneManager.GetSceneByName("Game").IsValid())
        {
            SceneManager.LoadSceneAsync("Game");
        }
        else SceneManager.LoadSceneAsync("Menu");
    }

    public void GotoMenu()
    {
         SceneManager.LoadSceneAsync("Menu");
    }

    public void ContinuePlay(){
        GameObject UIRendering = GameObject.FindGameObjectWithTag("ShowMenu");
        Destroy(UIRendering);
    }
    
    public void Exit(){
        Application.Quit();
    }

}
